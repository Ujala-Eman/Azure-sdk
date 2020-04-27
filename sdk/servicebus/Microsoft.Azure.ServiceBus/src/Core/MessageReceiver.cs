// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.ServiceBus.Core
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Transactions;
    using Microsoft.Azure.Amqp;
    using Microsoft.Azure.Amqp.Encoding;
    using Microsoft.Azure.Amqp.Framing;
    using Amqp;
    using Primitives;

    /// <summary>
    /// The MessageReceiver can be used to receive messages from Queues and Subscriptions and acknowledge them.
    /// </summary>
    /// <example>
    /// Create a new MessageReceiver to receive a message from a Subscription
    /// <code>
    /// IMessageReceiver messageReceiver = new MessageReceiver(
    ///     namespaceConnectionString,
    ///     EntityNameHelper.FormatSubscriptionPath(topicName, subscriptionName),
    ///     ReceiveMode.PeekLock);
    /// </code>
    ///
    /// Receive a message from the Subscription.
    /// <code>
    /// var message = await messageReceiver.ReceiveAsync();
    /// await messageReceiver.CompleteAsync(message.SystemProperties.LockToken);
    /// </code>
    /// </example>
    /// <remarks>
    /// The MessageReceiver provides advanced functionality that is not found in the
    /// <see cref="QueueClient" /> or <see cref="SubscriptionClient" />. For instance,
    /// <see cref="ReceiveAsync()"/>, which allows you to receive messages on demand, but also requires
    /// you to manually renew locks using <see cref="RenewLockAsync(Message)"/>.
    /// It uses AMQP protocol to communicate with service.
    /// </remarks>
    public class MessageReceiver : ClientEntity, IMessageReceiver
    {
        private static readonly TimeSpan DefaultBatchFlushInterval = TimeSpan.FromMilliseconds(20);

        private readonly ConcurrentExpiringSet<Guid> _requestResponseLockedMessages;
        private readonly bool _isSessionReceiver;
        private readonly object _messageReceivePumpSyncLock;
        private readonly ActiveClientLinkManager _clientLinkManager;
        private readonly ServiceBusDiagnosticSource _diagnosticSource;

        private int _prefetchCount;
        private long _lastPeekedSequenceNumber;
        private MessageReceivePump _receivePump;
        private CancellationTokenSource _receivePumpCancellationTokenSource;

        /// <summary>
        /// Creates a new MessageReceiver from a <see cref="ServiceBusConnectionStringBuilder"/>.
        /// </summary>
        /// <param name="connectionStringBuilder">The <see cref="ServiceBusConnectionStringBuilder"/> having entity level connection details.</param>
        /// <param name="receiveMode">The <see cref="ServiceBus.ReceiveMode"/> used to specify how messages are received. Defaults to PeekLock mode.</param>
        /// <param name="retryPolicy">The <see cref="RetryPolicy"/> that will be used when communicating with Service Bus. Defaults to <see cref="RetryPolicy.Default"/>.</param>
        /// <param name="prefetchCount">The <see cref="PrefetchCount"/> that specifies the upper limit of messages this receiver
        /// will actively receive regardless of whether a receive operation is pending. Defaults to 0.</param>
        /// <remarks>Creates a new connection to the entity, which is opened during the first operation.</remarks>
        public MessageReceiver(
            ServiceBusConnectionStringBuilder connectionStringBuilder,
            ReceiveMode receiveMode = ReceiveMode.PeekLock,
            RetryPolicy retryPolicy = null,
            int prefetchCount = Constants.DefaultClientPrefetchCount)
            : this(connectionStringBuilder?.GetNamespaceConnectionString(), connectionStringBuilder?.EntityPath, receiveMode, retryPolicy, prefetchCount)
        {
        }

        /// <summary>
        /// Creates a new MessageReceiver from a specified connection string and entity path.
        /// </summary>
        /// <param name="connectionString">Namespace connection string used to communicate with Service Bus. Must not contain Entity details.</param>
        /// <param name="entityPath">The path of the entity for this receiver. For Queues this will be the name, but for Subscriptions this will be the path.
        /// You can use <see cref="EntityNameHelper.FormatSubscriptionPath(string, string)"/>, to help create this path.</param>
        /// <param name="receiveMode">The <see cref="ServiceBus.ReceiveMode"/> used to specify how messages are received. Defaults to PeekLock mode.</param>
        /// <param name="retryPolicy">The <see cref="RetryPolicy"/> that will be used when communicating with Service Bus. Defaults to <see cref="RetryPolicy.Default"/></param>
        /// <param name="prefetchCount">The <see cref="PrefetchCount"/> that specifies the upper limit of messages this receiver
        /// will actively receive regardless of whether a receive operation is pending. Defaults to 0.</param>
        /// <remarks>Creates a new connection to the entity, which is opened during the first operation.</remarks>
        public MessageReceiver(
            string connectionString,
            string entityPath,
            ReceiveMode receiveMode = ReceiveMode.PeekLock,
            RetryPolicy retryPolicy = null,
            int prefetchCount = Constants.DefaultClientPrefetchCount)
            : this(entityPath, null, receiveMode, new ServiceBusConnection(connectionString), null, retryPolicy, prefetchCount)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw Fx.Exception.ArgumentNullOrWhiteSpace(connectionString);
            }

            OwnsConnection = true;
        }

        /// <summary>
        /// Creates a new MessageReceiver from a specified endpoint, entity path, and token provider.
        /// </summary>
        /// <param name="endpoint">Fully qualified domain name for Service Bus. Most likely, {yournamespace}.servicebus.windows.net</param>
        /// <param name="entityPath">Queue path.</param>
        /// <param name="tokenProvider">Token provider which will generate security tokens for authorization.</param>
        /// <param name="transportType">Transport type.</param>
        /// <param name="receiveMode">Mode of receive of messages. Defaults to <see cref="ReceiveMode"/>.PeekLock.</param>
        /// <param name="retryPolicy">Retry policy for queue operations. Defaults to <see cref="RetryPolicy.Default"/></param>
        /// <param name="prefetchCount">The <see cref="PrefetchCount"/> that specifies the upper limit of messages this receiver
        /// will actively receive regardless of whether a receive operation is pending. Defaults to 0.</param>
        /// <remarks>Creates a new connection to the entity, which is opened during the first operation.</remarks>
        public MessageReceiver(
            string endpoint,
            string entityPath,
            ITokenProvider tokenProvider,
            TransportType transportType = TransportType.Amqp,
            ReceiveMode receiveMode = ReceiveMode.PeekLock,
            RetryPolicy retryPolicy = null,
            int prefetchCount = Constants.DefaultClientPrefetchCount)
            : this(entityPath, null, receiveMode, new ServiceBusConnection(endpoint, transportType, retryPolicy) {TokenProvider = tokenProvider}, null, retryPolicy, prefetchCount)
        {
            OwnsConnection = true;
        }

        /// <summary>
        /// Creates a new AMQP MessageReceiver on a given <see cref="ServiceBusConnection"/>
        /// </summary>
        /// <param name="serviceBusConnection">Connection object to the service bus namespace.</param>
        /// <param name="entityPath">The path of the entity for this receiver. For Queues this will be the name, but for Subscriptions this will be the path.
        /// You can use <see cref="EntityNameHelper.FormatSubscriptionPath(string, string)"/>, to help create this path.</param>
        /// <param name="receiveMode">The <see cref="ServiceBus.ReceiveMode"/> used to specify how messages are received. Defaults to PeekLock mode.</param>
        /// <param name="retryPolicy">The <see cref="RetryPolicy"/> that will be used when communicating with Service Bus. Defaults to <see cref="RetryPolicy.Default"/></param>
        /// <param name="prefetchCount">The <see cref="PrefetchCount"/> that specifies the upper limit of messages this receiver
        /// will actively receive regardless of whether a receive operation is pending. Defaults to 0.</param>
        public MessageReceiver(
            ServiceBusConnection serviceBusConnection,
            string entityPath,
            ReceiveMode receiveMode = ReceiveMode.PeekLock,
            RetryPolicy retryPolicy = null,
            int prefetchCount = Constants.DefaultClientPrefetchCount)
            : this(entityPath, null, receiveMode, serviceBusConnection, null, retryPolicy, prefetchCount)
        {
            OwnsConnection = false;
        }

        internal MessageReceiver(
            string entityPath,
            MessagingEntityType? entityType,
            ReceiveMode receiveMode,
            ServiceBusConnection serviceBusConnection,
            ICbsTokenProvider cbsTokenProvider,
            RetryPolicy retryPolicy,
            int prefetchCount = Constants.DefaultClientPrefetchCount,
            string sessionId = null,
            bool isSessionReceiver = false)
            : base(nameof(MessageReceiver), entityPath, retryPolicy ?? RetryPolicy.Default)
        {
            MessagingEventSource.Log.MessageReceiverCreateStart(serviceBusConnection?.Endpoint.Authority, entityPath, receiveMode.ToString());

            if (string.IsNullOrWhiteSpace(entityPath))
            {
                throw Fx.Exception.ArgumentNullOrWhiteSpace(entityPath);
            }

            ServiceBusConnection = serviceBusConnection ?? throw new ArgumentNullException(nameof(serviceBusConnection));
            ReceiveMode = receiveMode;
            Path = entityPath;
            EntityType = entityType;
            ServiceBusConnection.ThrowIfClosed();

            if (cbsTokenProvider != null)
            {
                CbsTokenProvider = cbsTokenProvider;
            }
            else if (ServiceBusConnection.TokenProvider != null)
            {
                CbsTokenProvider = new TokenProviderAdapter(ServiceBusConnection.TokenProvider, ServiceBusConnection.OperationTimeout);
            }
            else
            {
                throw new ArgumentNullException($"{nameof(ServiceBusConnection)} doesn't have a valid token provider");
            }

            SessionIdInternal = sessionId;
            _isSessionReceiver = isSessionReceiver;
            ReceiveLinkManager = new FaultTolerantAmqpObject<ReceivingAmqpLink>(CreateLinkAsync, CloseSession);
            RequestResponseLinkManager = new FaultTolerantAmqpObject<RequestResponseAmqpLink>(CreateRequestResponseLinkAsync, CloseRequestResponseSession);
            _requestResponseLockedMessages = new ConcurrentExpiringSet<Guid>();
            PrefetchCount = prefetchCount;
            _messageReceivePumpSyncLock = new object();
            _clientLinkManager = new ActiveClientLinkManager(this, CbsTokenProvider);
            _diagnosticSource = new ServiceBusDiagnosticSource(entityPath, serviceBusConnection.Endpoint);
            MessagingEventSource.Log.MessageReceiverCreateStop(serviceBusConnection.Endpoint.Authority, entityPath, ClientId);
        }

        /// <summary>
        /// Gets a list of currently registered plugins.
        /// </summary>
        public override IList<ServiceBusPlugin> RegisteredPlugins { get; } = new List<ServiceBusPlugin>();

        /// <summary>
        /// Gets the <see cref="ServiceBus.ReceiveMode"/> of the current receiver.
        /// </summary>
        public ReceiveMode ReceiveMode { get; protected set; }

        /// <summary>
        /// Prefetch speeds up the message flow by aiming to have a message readily available for local retrieval when and before the application asks for one using Receive.
        /// Setting a non-zero value prefetches PrefetchCount number of messages.
        /// Setting the value to zero turns prefetch off.
        /// Defaults to 0.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When Prefetch is enabled, the receiver will quietly acquire more messages, up to the PrefetchCount limit, than what the application
        /// immediately asks for. A single initial Receive/ReceiveAsync call will therefore acquire a message for immediate consumption
        /// that will be returned as soon as available, and the client will proceed to acquire further messages to fill the prefetch buffer in the background.
        /// </para>
        /// <para>
        /// While messages are available in the prefetch buffer, any subsequent ReceiveAsync calls will be immediately satisfied from the buffer, and the buffer is
        /// replenished in the background as space becomes available.If there are no messages available for delivery, the receive operation will drain the
        /// buffer and then wait or block as expected.
        /// </para>
        /// <para>Prefetch also works equivalently with the <see cref="RegisterMessageHandler(Func{Message,CancellationToken,Task}, Func{ExceptionReceivedEventArgs, Task})"/> APIs.</para>
        /// <para>Updates to this value take effect on the next receive call to the service.</para>
        /// </remarks>
        public int PrefetchCount
        {
            get => _prefetchCount;

            set
            {
                if (value < 0)
                {
                    throw Fx.Exception.ArgumentOutOfRange(nameof(PrefetchCount), value, "Value cannot be less than 0.");
                }
                _prefetchCount = value;
                if (ReceiveLinkManager.TryGetOpenedObject(out var link))
                {
                    link.SetTotalLinkCredit((uint)value, true, true);
                }
            }
        }

        /// <summary>Gets the sequence number of the last peeked message.</summary>
        /// <seealso cref="PeekAsync()"/>
        public long LastPeekedSequenceNumber
        {
            get => _lastPeekedSequenceNumber;

            internal set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(LastPeekedSequenceNumber), value.ToString());
                }

                _lastPeekedSequenceNumber = value;
            }
        }

        /// <summary>The path of the entity for this receiver. For Queues this will be the name, but for Subscriptions this will be the path.</summary>
        public override string Path { get; }

        /// <summary>
        /// Duration after which individual operations will timeout.
        /// </summary>
        public override TimeSpan OperationTimeout {
            get => ServiceBusConnection.OperationTimeout;
            set => ServiceBusConnection.OperationTimeout = value;
        }

        /// <summary>
        /// Connection object to the service bus namespace.
        /// </summary>
        public override ServiceBusConnection ServiceBusConnection { get; }

        /// <summary>
        /// Gets the DateTime that the current receiver is locked until. This is only applicable when Sessions are used.
        /// </summary>
        internal DateTime LockedUntilUtcInternal { get; set; }

        /// <summary>
        /// Gets the SessionId of the current receiver. This is only applicable when Sessions are used.
        /// </summary>
        internal string SessionIdInternal { get; set; }

        internal MessagingEntityType? EntityType { get; }

        private Exception LinkException { get; set; }

        private ICbsTokenProvider CbsTokenProvider { get; }

        internal FaultTolerantAmqpObject<ReceivingAmqpLink> ReceiveLinkManager { get; }

        private FaultTolerantAmqpObject<RequestResponseAmqpLink> RequestResponseLinkManager { get; }

        /// <summary>
        /// Receive a message from the entity defined by <see cref="Path"/> using <see cref="ReceiveMode"/> mode.
        /// </summary>
        /// <returns>The message received. Returns null if no message is found.</returns>
        /// <remarks>Operation will time out after duration of <see cref="ClientEntity.OperationTimeout"/></remarks>
        public Task<Message> ReceiveAsync()
        {
            return ReceiveAsync(OperationTimeout);
        }

        /// <summary>
        /// Receive a message from the entity defined by <see cref="Path"/> using <see cref="ReceiveMode"/> mode.
        /// </summary>
        /// <param name="operationTimeout">The time span the client waits for receiving a message before it times out.</param>
        /// <returns>The message received. Returns null if no message is found.</returns>
        /// <remarks>
        /// The parameter <paramref name="operationTimeout"/> includes the time taken by the receiver to establish a connection
        /// (either during the first receive or when connection needs to be re-established). If establishing the connection
        /// times out, this will throw <see cref="ServiceBusTimeoutException"/>.
        /// </remarks>
        public async Task<Message> ReceiveAsync(TimeSpan operationTimeout)
        {
            var messages = await ReceiveAsync(1, operationTimeout).ConfigureAwait(false);
            if (messages != null && messages.Count > 0)
            {
                return messages[0];
            }

            return null;
        }

        /// <summary>
        /// Receives a maximum of <paramref name="maxMessageCount"/> messages from the entity defined by <see cref="Path"/> using <see cref="ReceiveMode"/> mode.
        /// </summary>
        /// <param name="maxMessageCount">The maximum number of messages that will be received.</param>
        /// <returns>List of messages received. Returns null if no message is found.</returns>
        /// <remarks>Receiving less than <paramref name="maxMessageCount"/> messages is not an indication of empty entity.</remarks>
        public Task<IList<Message>> ReceiveAsync(int maxMessageCount)
        {
            return ReceiveAsync(maxMessageCount, OperationTimeout);
        }

        /// <summary>
        /// Receives a maximum of <paramref name="maxMessageCount"/> messages from the entity defined by <see cref="Path"/> using <see cref="ReceiveMode"/> mode.
        /// </summary>
        /// <param name="maxMessageCount">The maximum number of messages that will be received.</param>
        /// <param name="operationTimeout">The time span the client waits for receiving a message before it times out.</param>
        /// <returns>List of messages received. Returns null if no message is found.</returns>
        /// <remarks>Receiving less than <paramref name="maxMessageCount"/> messages is not an indication of empty entity.
        /// The parameter <paramref name="operationTimeout"/> includes the time taken by the receiver to establish a connection
        /// (either during the first receive or when connection needs to be re-established). If establishing the connection
        /// times out, this will throw <see cref="ServiceBusTimeoutException"/>.
        /// </remarks>
        public async Task<IList<Message>> ReceiveAsync(int maxMessageCount, TimeSpan operationTimeout)
        {
            ThrowIfClosed();

            if (operationTimeout <= TimeSpan.Zero)
            {
                throw Fx.Exception.ArgumentOutOfRange(nameof(operationTimeout), operationTimeout, Resources.TimeoutMustBePositiveNonZero.FormatForUser(nameof(operationTimeout), operationTimeout));
            }

            MessagingEventSource.Log.MessageReceiveStart(ClientId, maxMessageCount);

            var isDiagnosticSourceEnabled = ServiceBusDiagnosticSource.IsEnabled();
            var activity = isDiagnosticSourceEnabled ? _diagnosticSource.ReceiveStart(maxMessageCount) : null;
            Task receiveTask = null;

            IList<Message> unprocessedMessageList = null;
            try
            {
                receiveTask = RetryPolicy.RunOperation(
                    async () =>
                    {
                        unprocessedMessageList = await OnReceiveAsync(maxMessageCount, operationTimeout)
                            .ConfigureAwait(false);
                    }, operationTimeout);
                await receiveTask.ConfigureAwait(false);

            }
            catch (Exception exception)
            {
                if (isDiagnosticSourceEnabled)
                {
                    _diagnosticSource.ReportException(exception);
                }

                MessagingEventSource.Log.MessageReceiveException(ClientId, exception);
                throw;
            }
            finally
            {
                _diagnosticSource.ReceiveStop(activity, maxMessageCount, receiveTask?.Status, unprocessedMessageList);
            }

            MessagingEventSource.Log.MessageReceiveStop(ClientId, unprocessedMessageList?.Count ?? 0);

            if (unprocessedMessageList == null)
            {
                return unprocessedMessageList;
            }

            return await ProcessMessages(unprocessedMessageList).ConfigureAwait(false);
        }

        /// <summary>
        /// Receives a specific deferred message identified by <paramref name="sequenceNumber"/>.
        /// </summary>
        /// <param name="sequenceNumber">The sequence number of the message that will be received.</param>
        /// <returns>Message identified by sequence number <paramref name="sequenceNumber"/>. Returns null if no such message is found.
        /// Throws if the message has not been deferred.</returns>
        /// <seealso cref="DeferAsync"/>
        public async Task<Message> ReceiveDeferredMessageAsync(long sequenceNumber)
        {
            var messages = await ReceiveDeferredMessageAsync(new[] { sequenceNumber }).ConfigureAwait(false);
            if (messages != null && messages.Count > 0)
            {
                return messages[0];
            }

            return null;
        }

        /// <summary>
        /// Receives a <see cref="IList{Message}"/> of deferred messages identified by <paramref name="sequenceNumbers"/>.
        /// </summary>
        /// <param name="sequenceNumbers">An <see cref="IEnumerable{T}"/> containing the sequence numbers to receive.</param>
        /// <returns>Messages identified by sequence number are returned. Returns null if no messages are found.
        /// Throws if the messages have not been deferred.</returns>
        /// <seealso cref="DeferAsync"/>
        public async Task<IList<Message>> ReceiveDeferredMessageAsync(IEnumerable<long> sequenceNumbers)
        {
            ThrowIfClosed();
            ThrowIfNotPeekLockMode();

            if (sequenceNumbers == null)
            {
                throw Fx.Exception.ArgumentNull(nameof(sequenceNumbers));
            }
            var sequenceNumberList = sequenceNumbers.ToArray();
            if (sequenceNumberList.Length == 0)
            {
                throw Fx.Exception.ArgumentNull(nameof(sequenceNumbers));
            }

            MessagingEventSource.Log.MessageReceiveDeferredMessageStart(ClientId, sequenceNumberList.Length, sequenceNumberList);

            var isDiagnosticSourceEnabled = ServiceBusDiagnosticSource.IsEnabled();
            var activity = isDiagnosticSourceEnabled ? _diagnosticSource.ReceiveDeferredStart(sequenceNumberList) : null;
            Task receiveTask = null;

            IList<Message> messages = null;
            try
            {
                receiveTask = RetryPolicy.RunOperation(
                    async () =>
                    {
                        messages = await OnReceiveDeferredMessageAsync(sequenceNumberList).ConfigureAwait(false);
                    }, OperationTimeout);
                await receiveTask.ConfigureAwait(false);
            }
            catch (Exception exception)
            {
                if (isDiagnosticSourceEnabled)
                {
                    _diagnosticSource.ReportException(exception);
                }

                MessagingEventSource.Log.MessageReceiveDeferredMessageException(ClientId, exception);
                throw;
            }
            finally
            {
                _diagnosticSource.ReceiveDeferredStop(activity, sequenceNumberList, receiveTask?.Status, messages);
            }
            MessagingEventSource.Log.MessageReceiveDeferredMessageStop(ClientId, messages?.Count ?? 0);

            return messages;
        }

        /// <summary>
        /// Completes a <see cref="Message"/> using its lock token. This will delete the message from the service.
        /// </summary>
        /// <param name="lockToken">The lock token of the corresponding message to complete.</param>
        /// <remarks>
        /// A lock token can be found in <see cref="Message.SystemPropertiesCollection.LockToken"/>,
        /// only when <see cref="ReceiveMode"/> is set to <see cref="ServiceBus.ReceiveMode.PeekLock"/>.
        /// This operation can only be performed on messages that were received by this receiver.
        /// </remarks>
        public Task CompleteAsync(string lockToken)
        {
            return CompleteAsync(new[] { lockToken });
        }

        /// <summary>
        /// Completes a series of <see cref="Message"/> using a list of lock tokens. This will delete the message from the service.
        /// </summary>
        /// <remarks>
        /// A lock token can be found in <see cref="Message.SystemPropertiesCollection.LockToken"/>,
        /// only when <see cref="ReceiveMode"/> is set to <see cref="ServiceBus.ReceiveMode.PeekLock"/>.
        /// This operation can only be performed on messages that were received by this receiver.
        /// </remarks>
        /// <param name="lockTokens">An <see cref="IEnumerable{T}"/> containing the lock tokens of the corresponding messages to complete.</param>
        public async Task CompleteAsync(IEnumerable<string> lockTokens)
        {
            ThrowIfClosed();
            ThrowIfNotPeekLockMode();
            if (lockTokens == null)
            {
                throw Fx.Exception.ArgumentNull(nameof(lockTokens));
            }
            var lockTokenList = lockTokens.ToList();
            if (lockTokenList.Count == 0)
            {
                throw Fx.Exception.Argument(nameof(lockTokens), Resources.ListOfLockTokensCannotBeEmpty);
            }

            MessagingEventSource.Log.MessageCompleteStart(ClientId, lockTokenList.Count, lockTokenList);
            var isDiagnosticSourceEnabled = ServiceBusDiagnosticSource.IsEnabled();
            var activity = isDiagnosticSourceEnabled ? _diagnosticSource.CompleteStart(lockTokenList) : null;
            Task completeTask = null;

            try
            {
                completeTask =
                    RetryPolicy.RunOperation(() => OnCompleteAsync(lockTokenList), OperationTimeout);
                await completeTask.ConfigureAwait(false);
            }
            catch (Exception exception)
            {
                if (isDiagnosticSourceEnabled)
                {
                    _diagnosticSource.ReportException(exception);
                }

                MessagingEventSource.Log.MessageCompleteException(ClientId, exception);

                throw;
            }
            finally
            {
                _diagnosticSource.CompleteStop(activity, lockTokenList, completeTask?.Status);
            }

            MessagingEventSource.Log.MessageCompleteStop(ClientId);
        }

        /// <summary>
        /// Abandons a <see cref="Message"/> using a lock token. This will make the message available again for processing.
        /// </summary>
        /// <param name="lockToken">The lock token of the corresponding message to abandon.</param>
        /// <param name="propertiesToModify">The properties of the message to modify while abandoning the message.</param>
        /// <remarks>A lock token can be found in <see cref="Message.SystemPropertiesCollection.LockToken"/>,
        /// only when <see cref="ReceiveMode"/> is set to <see cref="ServiceBus.ReceiveMode.PeekLock"/>.
        /// Abandoning a message will increase the delivery count on the message.
        /// This operation can only be performed on messages that were received by this receiver.
        /// </remarks>
        public async Task AbandonAsync(string lockToken, IDictionary<string, object> propertiesToModify = null)
        {
            ThrowIfClosed();
            ThrowIfNotPeekLockMode();

            MessagingEventSource.Log.MessageAbandonStart(ClientId, 1, lockToken);
            var isDiagnosticSourceEnabled = ServiceBusDiagnosticSource.IsEnabled();
            var activity = isDiagnosticSourceEnabled ? _diagnosticSource.DisposeStart("Abandon", lockToken) : null;
            Task abandonTask = null;

            try
            {
                abandonTask = RetryPolicy.RunOperation(() => OnAbandonAsync(lockToken, propertiesToModify),
                    OperationTimeout);
                await abandonTask.ConfigureAwait(false);
            }
            catch (Exception exception)
            {
                if (isDiagnosticSourceEnabled)
                {
                    _diagnosticSource.ReportException(exception);
                }

                MessagingEventSource.Log.MessageAbandonException(ClientId, exception);
                throw;
            }
            finally
            {
                _diagnosticSource.DisposeStop(activity, lockToken, abandonTask?.Status);
            }


            MessagingEventSource.Log.MessageAbandonStop(ClientId);
        }

        /// <summary>Indicates that the receiver wants to defer the processing for the message.</summary>
        /// <param name="lockToken">The lock token of the <see cref="Message" />.</param>
        /// <param name="propertiesToModify">The properties of the message to modify while deferring the message.</param>
        /// <remarks>
        /// A lock token can be found in <see cref="Message.SystemPropertiesCollection.LockToken"/>,
        /// only when <see cref="ReceiveMode"/> is set to <see cref="ServiceBus.ReceiveMode.PeekLock"/>.
        /// In order to receive this message again in the future, you will need to save the <see cref="Message.SystemPropertiesCollection.SequenceNumber"/>
        /// and receive it using <see cref="ReceiveDeferredMessageAsync(long)"/>.
        /// Deferring messages does not impact message's expiration, meaning that deferred messages can still expire.
        /// This operation can only be performed on messages that were received by this receiver.
        /// </remarks>
        public async Task DeferAsync(string lockToken, IDictionary<string, object> propertiesToModify = null)
        {
            ThrowIfClosed();
            ThrowIfNotPeekLockMode();

            MessagingEventSource.Log.MessageDeferStart(ClientId, 1, lockToken);
            var isDiagnosticSourceEnabled = ServiceBusDiagnosticSource.IsEnabled();
            var activity = isDiagnosticSourceEnabled ? _diagnosticSource.DisposeStart("Defer", lockToken) : null;
            Task deferTask = null;

            try
            {
                deferTask = RetryPolicy.RunOperation(() => OnDeferAsync(lockToken, propertiesToModify),
                    OperationTimeout);
                await deferTask.ConfigureAwait(false);
            }
            catch (Exception exception)
            {
                if (isDiagnosticSourceEnabled)
                {
                    _diagnosticSource.ReportException(exception);
                }

                MessagingEventSource.Log.MessageDeferException(ClientId, exception);
                throw;
            }
            finally
            {
                _diagnosticSource.DisposeStop(activity, lockToken, deferTask?.Status);
            }
            MessagingEventSource.Log.MessageDeferStop(ClientId);
        }

        /// <summary>
        /// Moves a message to the deadletter sub-queue.
        /// </summary>
        /// <param name="lockToken">The lock token of the corresponding message to deadletter.</param>
        /// <param name="propertiesToModify">The properties of the message to modify while moving to sub-queue.</param>
        /// <remarks>
        /// A lock token can be found in <see cref="Message.SystemPropertiesCollection.LockToken"/>,
        /// only when <see cref="ReceiveMode"/> is set to <see cref="ServiceBus.ReceiveMode.PeekLock"/>.
        /// In order to receive a message from the deadletter queue, you will need a new <see cref="IMessageReceiver"/>, with the corresponding path.
        /// You can use <see cref="EntityNameHelper.FormatDeadLetterPath(string)"/> to help with this.
        /// This operation can only be performed on messages that were received by this receiver.
        /// </remarks>
        public async Task DeadLetterAsync(string lockToken, IDictionary<string, object> propertiesToModify = null)
        {
            ThrowIfClosed();
            ThrowIfNotPeekLockMode();

            MessagingEventSource.Log.MessageDeadLetterStart(ClientId, 1, lockToken);
            var isDiagnosticSourceEnabled = ServiceBusDiagnosticSource.IsEnabled();
            var activity = isDiagnosticSourceEnabled ? _diagnosticSource.DisposeStart("DeadLetter", lockToken) : null;
            Task deadLetterTask = null;

            try
            {
                deadLetterTask = RetryPolicy.RunOperation(() => OnDeadLetterAsync(lockToken, propertiesToModify),
                    OperationTimeout);
                await deadLetterTask.ConfigureAwait(false);
            }
            catch (Exception exception)
            {
                if (isDiagnosticSourceEnabled)
                {
                    _diagnosticSource.ReportException(exception);
                }

                MessagingEventSource.Log.MessageDeadLetterException(ClientId, exception);
                throw;
            }
            finally
            {
                _diagnosticSource.DisposeStop(activity, lockToken, deadLetterTask?.Status);
            }
            MessagingEventSource.Log.MessageDeadLetterStop(ClientId);
        }

        /// <summary>
        /// Moves a message to the deadletter sub-queue.
        /// </summary>
        /// <param name="lockToken">The lock token of the corresponding message to deadletter.</param>
        /// <param name="deadLetterReason">The reason for deadlettering the message.</param>
        /// <param name="deadLetterErrorDescription">The error description for deadlettering the message.</param>
        /// <remarks>
        /// A lock token can be found in <see cref="Message.SystemPropertiesCollection.LockToken"/>,
        /// only when <see cref="ReceiveMode"/> is set to <see cref="ServiceBus.ReceiveMode.PeekLock"/>.
        /// In order to receive a message from the deadletter queue, you will need a new <see cref="IMessageReceiver"/>, with the corresponding path.
        /// You can use <see cref="EntityNameHelper.FormatDeadLetterPath(string)"/> to help with this.
        /// This operation can only be performed on messages that were received by this receiver.
        /// </remarks>
        public async Task DeadLetterAsync(string lockToken, string deadLetterReason, string deadLetterErrorDescription = null)
        {
            ThrowIfClosed();
            ThrowIfNotPeekLockMode();

            MessagingEventSource.Log.MessageDeadLetterStart(ClientId, 1, lockToken);
            var isDiagnosticSourceEnabled = ServiceBusDiagnosticSource.IsEnabled();
            var activity = isDiagnosticSourceEnabled ? _diagnosticSource.DisposeStart("DeadLetter", lockToken) : null;
            Task deadLetterTask = null;

            try
            {
                deadLetterTask =
                    RetryPolicy.RunOperation(
                        () => OnDeadLetterAsync(lockToken, null, deadLetterReason, deadLetterErrorDescription),
                        OperationTimeout);
                await deadLetterTask.ConfigureAwait(false);
            }
            catch (Exception exception)
            {
                if (isDiagnosticSourceEnabled)
                {
                    _diagnosticSource.ReportException(exception);
                }

                MessagingEventSource.Log.MessageDeadLetterException(ClientId, exception);
                throw;
            }
            finally
            {
                _diagnosticSource.DisposeStop(activity, lockToken, deadLetterTask?.Status);
            }

            MessagingEventSource.Log.MessageDeadLetterStop(ClientId);
        }

        /// <summary>
        /// Renews the lock on the message specified by the lock token. The lock will be renewed based on the setting specified on the queue.
        /// </summary>
        /// <remarks>
        /// When a message is received in <see cref="ServiceBus.ReceiveMode.PeekLock"/> mode, the message is locked on the server for this
        /// receiver instance for a duration as specified during the Queue/Subscription creation (LockDuration).
        /// If processing of the message requires longer than this duration, the lock needs to be renewed.
        /// For each renewal, it resets the time the message is locked by the LockDuration set on the Entity.
        /// </remarks>
        public async Task RenewLockAsync(Message message)
        {
            message.SystemProperties.LockedUntilUtc = await RenewLockAsync(message.SystemProperties.LockToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Renews the lock on the message. The lock will be renewed based on the setting specified on the queue.
        /// <returns>New lock token expiry date and time in UTC format.</returns>
        /// </summary>
        /// <param name="lockToken">Lock token associated with the message.</param>
        /// <remarks>
        /// When a message is received in <see cref="ServiceBus.ReceiveMode.PeekLock"/> mode, the message is locked on the server for this
        /// receiver instance for a duration as specified during the Queue/Subscription creation (LockDuration).
        /// If processing of the message requires longer than this duration, the lock needs to be renewed.
        /// For each renewal, it resets the time the message is locked by the LockDuration set on the Entity.
        /// </remarks>
        public async Task<DateTime> RenewLockAsync(string lockToken)
        {
            ThrowIfClosed();
            ThrowIfNotPeekLockMode();

            MessagingEventSource.Log.MessageRenewLockStart(ClientId, 1, lockToken);
            var isDiagnosticSourceEnabled = ServiceBusDiagnosticSource.IsEnabled();
            var activity = isDiagnosticSourceEnabled ? _diagnosticSource.RenewLockStart(lockToken) : null;
            Task renewTask = null;

            var lockedUntilUtc = DateTime.MinValue;

            try
            {
                renewTask = RetryPolicy.RunOperation(
                    async () => lockedUntilUtc = await OnRenewLockAsync(lockToken).ConfigureAwait(false),
                    OperationTimeout);
                await renewTask.ConfigureAwait(false);
            }
            catch (Exception exception)
            {
                if (isDiagnosticSourceEnabled)
                {
                    _diagnosticSource.ReportException(exception);
                }

                MessagingEventSource.Log.MessageRenewLockException(ClientId, exception);
                throw;
            }
            finally
            {
                _diagnosticSource.RenewLockStop(activity, lockToken, renewTask?.Status, lockedUntilUtc);
            }
            MessagingEventSource.Log.MessageRenewLockStop(ClientId);

            return lockedUntilUtc;
        }

        /// <summary>
        /// Fetches the next active message without changing the state of the receiver or the message source.
        /// </summary>
        /// <remarks>
        /// The first call to <see cref="PeekAsync()"/> fetches the first active message for this receiver. Each subsequent call
        /// fetches the subsequent message in the entity.
        /// Unlike a received message, peeked message will not have lock token associated with it, and hence it cannot be Completed/Abandoned/Deferred/Deadlettered/Renewed.
        /// Also, unlike <see cref="ReceiveAsync()"/>, this method will fetch even Deferred messages (but not Deadlettered message)
        /// </remarks>
        /// <returns>The <see cref="Message" /> that represents the next message to be read. Returns null when nothing to peek.</returns>
        public Task<Message> PeekAsync()
        {
            return PeekBySequenceNumberAsync(_lastPeekedSequenceNumber + 1);
        }

        /// <summary>
        /// Fetches the next batch of active messages without changing the state of the receiver or the message source.
        /// </summary>
        /// <remarks>
        /// The first call to <see cref="PeekAsync()"/> fetches the first active message for this receiver. Each subsequent call
        /// fetches the subsequent message in the entity.
        /// Unlike a received message, peeked message will not have lock token associated with it, and hence it cannot be Completed/Abandoned/Deferred/Deadlettered/Renewed.
        /// Also, unlike <see cref="ReceiveAsync()"/>, this method will fetch even Deferred messages (but not Deadlettered message)
        /// </remarks>
        /// <returns>List of <see cref="Message" /> that represents the next message to be read. Returns null when nothing to peek.</returns>
        public Task<IList<Message>> PeekAsync(int maxMessageCount)
        {
            return PeekBySequenceNumberAsync(_lastPeekedSequenceNumber + 1, maxMessageCount);
        }

        /// <summary>
        /// Asynchronously reads the next message without changing the state of the receiver or the message source.
        /// </summary>
        /// <param name="fromSequenceNumber">The sequence number from where to read the message.</param>
        /// <returns>The asynchronous operation that returns the <see cref="Message" /> that represents the next message to be read.</returns>
        public async Task<Message> PeekBySequenceNumberAsync(long fromSequenceNumber)
        {
            var messages = await PeekBySequenceNumberAsync(fromSequenceNumber, 1).ConfigureAwait(false);
            return messages?.FirstOrDefault();
        }

        /// <summary>Peeks a batch of messages.</summary>
        /// <param name="fromSequenceNumber">The starting point from which to browse a batch of messages.</param>
        /// <param name="messageCount">The number of messages to retrieve.</param>
        /// <returns>A batch of messages peeked.</returns>
        public async Task<IList<Message>> PeekBySequenceNumberAsync(long fromSequenceNumber, int messageCount)
        {
            ThrowIfClosed();
            IList<Message> messages = null;

            MessagingEventSource.Log.MessagePeekStart(ClientId, fromSequenceNumber, messageCount);
            var isDiagnosticSourceEnabled = ServiceBusDiagnosticSource.IsEnabled();
            var activity = isDiagnosticSourceEnabled ? _diagnosticSource.PeekStart(fromSequenceNumber, messageCount) : null;
            Task peekTask = null;

            try
            {
                peekTask = RetryPolicy.RunOperation(
                    async () =>
                    {
                        messages = await OnPeekAsync(fromSequenceNumber, messageCount).ConfigureAwait(false);
                    }, OperationTimeout);

                await peekTask.ConfigureAwait(false);
            }
            catch (Exception exception)
            {
                if (isDiagnosticSourceEnabled)
                {
                    _diagnosticSource.ReportException(exception);
                }

                MessagingEventSource.Log.MessagePeekException(ClientId, exception);
                throw;
            }
            finally
            {
                _diagnosticSource.PeekStop(activity, fromSequenceNumber, messageCount, peekTask?.Status, messages);
            }

            MessagingEventSource.Log.MessagePeekStop(ClientId, messages?.Count ?? 0);
            return messages;
        }

        /// <summary>
        /// Receive messages continuously from the entity. Registers a message handler and begins a new thread to receive messages.
        /// This handler(<see cref="Func{Message, CancellationToken, Task}"/>) is awaited on every time a new message is received by the receiver.
        /// </summary>
        /// <param name="handler">A <see cref="Func{T1, T2, TResult}"/> that processes messages.</param>
        /// <param name="exceptionReceivedHandler">A <see cref="Func{T1, TResult}"/> that is used to notify exceptions.</param>
        public void RegisterMessageHandler(Func<Message, CancellationToken, Task> handler, Func<ExceptionReceivedEventArgs, Task> exceptionReceivedHandler)
        {
            RegisterMessageHandler(handler, new MessageHandlerOptions(exceptionReceivedHandler));
        }

        /// <summary>
        /// Receive messages continuously from the entity. Registers a message handler and begins a new thread to receive messages.
        /// This handler(<see cref="Func{Message, CancellationToken, Task}"/>) is awaited on every time a new message is received by the receiver.
        /// </summary>
        /// <param name="handler">A <see cref="Func{Message, CancellationToken, Task}"/> that processes messages.</param>
        /// <param name="messageHandlerOptions">The <see cref="MessageHandlerOptions"/> options used to configure the settings of the pump.</param>
        /// <remarks>Enable prefetch to speed up the receive rate.</remarks>
        public void RegisterMessageHandler(Func<Message, CancellationToken, Task> handler, MessageHandlerOptions messageHandlerOptions)
        {
            ThrowIfClosed();
            OnMessageHandler(messageHandlerOptions, handler);
        }

        /// <summary>
        /// Registers a <see cref="ServiceBusPlugin"/> to be used with this receiver.
        /// </summary>
        public override void RegisterPlugin(ServiceBusPlugin serviceBusPlugin)
        {
            ThrowIfClosed();
            if (serviceBusPlugin == null)
            {
                throw new ArgumentNullException(nameof(serviceBusPlugin), Resources.ArgumentNullOrWhiteSpace.FormatForUser(nameof(serviceBusPlugin)));
            }
            if (RegisteredPlugins.Any(p => p.Name == serviceBusPlugin.Name))
            {
                throw new ArgumentException(nameof(serviceBusPlugin), Resources.PluginAlreadyRegistered.FormatForUser(serviceBusPlugin.Name));
            }
            RegisteredPlugins.Add(serviceBusPlugin);
        }

        /// <summary>
        /// Unregisters a <see cref="ServiceBusPlugin"/>.
        /// </summary>
        /// <param name="serviceBusPluginName">The <see cref="ServiceBusPlugin.Name"/> of the plugin to be unregistered.</param>
        public override void UnregisterPlugin(string serviceBusPluginName)
        {
            ThrowIfClosed();
            if (RegisteredPlugins == null)
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(serviceBusPluginName))
            {
                throw new ArgumentNullException(nameof(serviceBusPluginName), Resources.ArgumentNullOrWhiteSpace.FormatForUser(nameof(serviceBusPluginName)));
            }
            if (RegisteredPlugins.Any(p => p.Name == serviceBusPluginName))
            {
                var plugin = RegisteredPlugins.First(p => p.Name == serviceBusPluginName);
                RegisteredPlugins.Remove(plugin);
            }
        }

        internal async Task GetSessionReceiverLinkAsync(TimeSpan serverWaitTime)
        {
            var timeoutHelper = new TimeoutHelper(serverWaitTime, true);
            var receivingAmqpLink = await ReceiveLinkManager.GetOrCreateAsync(timeoutHelper.RemainingTime()).ConfigureAwait(false);

            var source = (Source)receivingAmqpLink.Settings.Source;
            if (!source.FilterSet.TryGetValue<string>(AmqpClientConstants.SessionFilterName, out var tempSessionId))
            {
                receivingAmqpLink.Session.SafeClose();
                throw new ServiceBusException(true, Resources.SessionFilterMissing);
            }

            if (string.IsNullOrWhiteSpace(tempSessionId))
            {
                receivingAmqpLink.Session.SafeClose();
                throw new ServiceBusException(true, Resources.AmqpFieldSessionId);
            }

            receivingAmqpLink.Closed += OnSessionReceiverLinkClosed;
            SessionIdInternal = tempSessionId;
            LockedUntilUtcInternal = receivingAmqpLink.Settings.Properties.TryGetValue<long>(AmqpClientConstants.LockedUntilUtc, out var lockedUntilUtcTicks)
                ? new DateTime(lockedUntilUtcTicks, DateTimeKind.Utc)
                : DateTime.MinValue;
        }

        internal async Task<AmqpResponseMessage> ExecuteRequestResponseAsync(AmqpRequestMessage amqpRequestMessage)
        {
            var amqpMessage = amqpRequestMessage.AmqpMessage;
            if (_isSessionReceiver)
            {
                ThrowIfSessionLockLost();
            }

            var timeoutHelper = new TimeoutHelper(OperationTimeout, true);

            var transactionId = AmqpConstants.NullBinary;
            var ambientTransaction = Transaction.Current;
            if (ambientTransaction != null)
            {
                transactionId = await AmqpTransactionManager.Instance.EnlistAsync(ambientTransaction, ServiceBusConnection).ConfigureAwait(false);
            }

            if (!RequestResponseLinkManager.TryGetOpenedObject(out var requestResponseAmqpLink))
            {
                MessagingEventSource.Log.CreatingNewLink(ClientId, _isSessionReceiver, SessionIdInternal, true, LinkException);
                requestResponseAmqpLink = await RequestResponseLinkManager.GetOrCreateAsync(timeoutHelper.RemainingTime()).ConfigureAwait(false);
            }

            var responseAmqpMessage = await Task.Factory.FromAsync(
                (c, s) => requestResponseAmqpLink.BeginRequest(amqpMessage, transactionId, timeoutHelper.RemainingTime(), c, s),
                (a) => requestResponseAmqpLink.EndRequest(a),
                this).ConfigureAwait(false);

            return AmqpResponseMessage.CreateResponse(responseAmqpMessage);
        }

        protected override async Task OnClosingAsync()
        {
            _clientLinkManager.Close();
            lock (_messageReceivePumpSyncLock)
            {
                if (_receivePump != null)
                {
                    _receivePumpCancellationTokenSource.Cancel();
                    _receivePumpCancellationTokenSource.Dispose();
                    _receivePump = null;
                }
            }
            await ReceiveLinkManager.CloseAsync().ConfigureAwait(false);
            await RequestResponseLinkManager.CloseAsync().ConfigureAwait(false);
            _requestResponseLockedMessages.Close();
        }

        protected virtual async Task<IList<Message>> OnReceiveAsync(int maxMessageCount, TimeSpan serverWaitTime)
        {
            ReceivingAmqpLink receiveLink = null;

            if (_isSessionReceiver)
            {
                ThrowIfSessionLockLost();
            }

            try
            {
                var timeoutHelper = new TimeoutHelper(serverWaitTime, true);
                if(!ReceiveLinkManager.TryGetOpenedObject(out receiveLink))
                {
                    MessagingEventSource.Log.CreatingNewLink(ClientId, _isSessionReceiver, SessionIdInternal, false, LinkException);
                    receiveLink = await ReceiveLinkManager.GetOrCreateAsync(timeoutHelper.RemainingTime()).ConfigureAwait(false);
                }

                IList<Message> brokeredMessages = null;
                ThrowIfClosed();

                IEnumerable<AmqpMessage> amqpMessages = null;
                var hasMessages = await Task.Factory.FromAsync(
                    (c, s) => receiveLink.BeginReceiveRemoteMessages(maxMessageCount, DefaultBatchFlushInterval, timeoutHelper.RemainingTime(), c, s),
                    a => receiveLink.EndReceiveMessages(a, out amqpMessages),
                    this).ConfigureAwait(false);
                Exception exception;
                if ((exception = receiveLink.GetInnerException()) != null)
                {
                    throw exception;
                }

                if (hasMessages && amqpMessages != null)
                {
                    foreach (var amqpMessage in amqpMessages)
                    {
                        if (ReceiveMode == ReceiveMode.ReceiveAndDelete)
                        {
                            receiveLink.DisposeDelivery(amqpMessage, true, AmqpConstants.AcceptedOutcome);
                        }

                        var message = AmqpMessageConverter.AmqpMessageToSBMessage(amqpMessage);
                        if (brokeredMessages == null)
                        {
                            brokeredMessages = new List<Message>();
                        }

                        brokeredMessages.Add(message);
                    }
                }

                return brokeredMessages;
            }
            catch (Exception exception)
            {
                throw AmqpExceptionHelper.GetClientException(exception, receiveLink?.GetTrackingId(), null, receiveLink?.IsClosing() ?? false);
            }
        }

        protected virtual async Task<IList<Message>> OnPeekAsync(long fromSequenceNumber, int messageCount = 1)
        {
            try
            {
                var amqpRequestMessage = AmqpRequestMessage.CreateRequest(
                        ManagementConstants.Operations.PeekMessageOperation,
                        OperationTimeout,
                        null);

                if (ReceiveLinkManager.TryGetOpenedObject(out var receiveLink))
                {
                    amqpRequestMessage.AmqpMessage.ApplicationProperties.Map[ManagementConstants.Request.AssociatedLinkName] = receiveLink.Name;
                }

                amqpRequestMessage.Map[ManagementConstants.Properties.FromSequenceNumber] = fromSequenceNumber;
                amqpRequestMessage.Map[ManagementConstants.Properties.MessageCount] = messageCount;

                if (!string.IsNullOrWhiteSpace(SessionIdInternal))
                {
                    amqpRequestMessage.Map[ManagementConstants.Properties.SessionId] = SessionIdInternal;
                }

                var messages = new List<Message>();

                var amqpResponseMessage = await ExecuteRequestResponseAsync(amqpRequestMessage).ConfigureAwait(false);
                if (amqpResponseMessage.StatusCode == AmqpResponseStatusCode.OK)
                {
                    Message message = null;
                    var messageList = amqpResponseMessage.GetListValue<AmqpMap>(ManagementConstants.Properties.Messages);
                    foreach (var entry in messageList)
                    {
                        var payload = (ArraySegment<byte>)entry[ManagementConstants.Properties.Message];
                        var amqpMessage = AmqpMessage.CreateAmqpStreamMessage(new BufferListStream(new[] { payload }), true);
                        message = AmqpMessageConverter.AmqpMessageToSBMessage(amqpMessage, true);
                        messages.Add(message);
                    }

                    if (message != null)
                    {
                        LastPeekedSequenceNumber = message.SystemProperties.SequenceNumber;
                    }

                    return messages;
                }

                if (amqpResponseMessage.StatusCode == AmqpResponseStatusCode.NoContent ||
                    (amqpResponseMessage.StatusCode == AmqpResponseStatusCode.NotFound && Equals(AmqpClientConstants.MessageNotFoundError, amqpResponseMessage.GetResponseErrorCondition())))
                {
                    return messages;
                }

                throw amqpResponseMessage.ToMessagingContractException();
            }
            catch (Exception exception)
            {
                throw AmqpExceptionHelper.GetClientException(exception);
            }
        }

        protected virtual async Task<IList<Message>> OnReceiveDeferredMessageAsync(long[] sequenceNumbers)
        {
            var messages = new List<Message>();
            try
            {
                var amqpRequestMessage = AmqpRequestMessage.CreateRequest(ManagementConstants.Operations.ReceiveBySequenceNumberOperation, OperationTimeout, null);

                if (ReceiveLinkManager.TryGetOpenedObject(out var receiveLink))
                {
                    amqpRequestMessage.AmqpMessage.ApplicationProperties.Map[ManagementConstants.Request.AssociatedLinkName] = receiveLink.Name;
                }
                amqpRequestMessage.Map[ManagementConstants.Properties.SequenceNumbers] = sequenceNumbers;
                amqpRequestMessage.Map[ManagementConstants.Properties.ReceiverSettleMode] = (uint)(ReceiveMode == ReceiveMode.ReceiveAndDelete ? 0 : 1);
                if (!string.IsNullOrWhiteSpace(SessionIdInternal))
                {
                    amqpRequestMessage.Map[ManagementConstants.Properties.SessionId] = SessionIdInternal;
                }

                var response = await ExecuteRequestResponseAsync(amqpRequestMessage).ConfigureAwait(false);

                if (response.StatusCode == AmqpResponseStatusCode.OK)
                {
                    var amqpMapList = response.GetListValue<AmqpMap>(ManagementConstants.Properties.Messages);
                    foreach (var entry in amqpMapList)
                    {
                        var payload = (ArraySegment<byte>)entry[ManagementConstants.Properties.Message];
                        var amqpMessage = AmqpMessage.CreateAmqpStreamMessage(new BufferListStream(new[] { payload }), true);
                        var message = AmqpMessageConverter.AmqpMessageToSBMessage(amqpMessage);
                        if (entry.TryGetValue<Guid>(ManagementConstants.Properties.LockToken, out var lockToken))
                        {
                            message.SystemProperties.LockTokenGuid = lockToken;
                            _requestResponseLockedMessages.AddOrUpdate(lockToken, message.SystemProperties.LockedUntilUtc);
                        }

                        messages.Add(message);
                    }
                }
                else
                {
                    throw response.ToMessagingContractException();
                }
            }
            catch (Exception exception)
            {
                throw AmqpExceptionHelper.GetClientException(exception);
            }

            return messages;
        }

        protected virtual Task OnCompleteAsync(IEnumerable<string> lockTokens)
        {
            var lockTokenGuids = lockTokens.Select(lt => new Guid(lt)).ToArray();
            if (lockTokenGuids.Any(lt => _requestResponseLockedMessages.Contains(lt)))
            {
                return DisposeMessageRequestResponseAsync(lockTokenGuids, DispositionStatus.Completed);
            }
            return DisposeMessagesAsync(lockTokenGuids, AmqpConstants.AcceptedOutcome);
        }

        protected virtual Task OnAbandonAsync(string lockToken, IDictionary<string, object> propertiesToModify = null)
        {
            var lockTokens = new[] { new Guid(lockToken) };
            if (lockTokens.Any(lt => _requestResponseLockedMessages.Contains(lt)))
            {
                return DisposeMessageRequestResponseAsync(lockTokens, DispositionStatus.Abandoned, propertiesToModify);
            }
            return DisposeMessagesAsync(lockTokens, GetAbandonOutcome(propertiesToModify));
        }

        protected virtual Task OnDeferAsync(string lockToken, IDictionary<string, object> propertiesToModify = null)
        {
            var lockTokens = new[] { new Guid(lockToken) };
            if (lockTokens.Any(lt => _requestResponseLockedMessages.Contains(lt)))
            {
                return DisposeMessageRequestResponseAsync(lockTokens, DispositionStatus.Defered, propertiesToModify);
            }
            return DisposeMessagesAsync(lockTokens, GetDeferOutcome(propertiesToModify));
        }

        protected virtual Task OnDeadLetterAsync(string lockToken, IDictionary<string, object> propertiesToModify = null, string deadLetterReason = null, string deadLetterErrorDescription = null)
        {
            if (deadLetterReason != null && deadLetterReason.Length > Constants.MaxDeadLetterReasonLength)
            {
                throw new ArgumentOutOfRangeException(nameof(deadLetterReason), $@"Maximum permitted length is {Constants.MaxDeadLetterReasonLength}");
            }

            if (deadLetterErrorDescription != null && deadLetterErrorDescription.Length > Constants.MaxDeadLetterReasonLength)
            {
                throw new ArgumentOutOfRangeException(nameof(deadLetterErrorDescription), $@"Maximum permitted length is {Constants.MaxDeadLetterReasonLength}");
            }

            var lockTokens = new[] { new Guid(lockToken) };
            if (lockTokens.Any(lt => _requestResponseLockedMessages.Contains(lt)))
            {
                return DisposeMessageRequestResponseAsync(lockTokens, DispositionStatus.Suspended, propertiesToModify, deadLetterReason, deadLetterErrorDescription);
            }

            return DisposeMessagesAsync(lockTokens, GetRejectedOutcome(propertiesToModify, deadLetterReason, deadLetterErrorDescription));
        }

        protected virtual async Task<DateTime> OnRenewLockAsync(string lockToken)
        {
            DateTime lockedUntilUtc;
            try
            {
                // Create an AmqpRequest Message to renew  lock
                var amqpRequestMessage = AmqpRequestMessage.CreateRequest(ManagementConstants.Operations.RenewLockOperation, OperationTimeout, null);

                if (ReceiveLinkManager.TryGetOpenedObject(out var receiveLink))
                {
                    amqpRequestMessage.AmqpMessage.ApplicationProperties.Map[ManagementConstants.Request.AssociatedLinkName] = receiveLink.Name;
                }
                amqpRequestMessage.Map[ManagementConstants.Properties.LockTokens] = new[] { new Guid(lockToken) };

                var amqpResponseMessage = await ExecuteRequestResponseAsync(amqpRequestMessage).ConfigureAwait(false);

                if (amqpResponseMessage.StatusCode == AmqpResponseStatusCode.OK)
                {
                    var lockedUntilUtcTimes = amqpResponseMessage.GetValue<IEnumerable<DateTime>>(ManagementConstants.Properties.Expirations);
                    lockedUntilUtc = lockedUntilUtcTimes.First();
                }
                else
                {
                    throw amqpResponseMessage.ToMessagingContractException();
                }
            }
            catch (Exception exception)
            {
                throw AmqpExceptionHelper.GetClientException(exception);
            }

            return lockedUntilUtc;
        }

        /// <summary> </summary>
        protected virtual void OnMessageHandler(
            MessageHandlerOptions registerHandlerOptions,
            Func<Message, CancellationToken, Task> callback)
        {
            MessagingEventSource.Log.RegisterOnMessageHandlerStart(ClientId, registerHandlerOptions);

            lock (_messageReceivePumpSyncLock)
            {
                if (_receivePump != null)
                {
                    throw new InvalidOperationException(Resources.MessageHandlerAlreadyRegistered);
                }

                _receivePumpCancellationTokenSource = new CancellationTokenSource();
                _receivePump = new MessageReceivePump(this, registerHandlerOptions, callback, ServiceBusConnection.Endpoint, _receivePumpCancellationTokenSource.Token);
            }

            try
            {
                _receivePump.StartPump();
            }
            catch (Exception exception)
            {
                MessagingEventSource.Log.RegisterOnMessageHandlerException(ClientId, exception);
                lock (_messageReceivePumpSyncLock)
                {
                    if (_receivePump != null)
                    {
                        _receivePumpCancellationTokenSource.Cancel();
                        _receivePumpCancellationTokenSource.Dispose();
                        _receivePump = null;
                    }
                }

                throw;
            }

            MessagingEventSource.Log.RegisterOnMessageHandlerStop(ClientId);
        }

        private static void CloseSession(ReceivingAmqpLink link)
        {
            link.Session.SafeClose();
        }

        private static void CloseRequestResponseSession(RequestResponseAmqpLink requestResponseAmqpLink)
        {
            requestResponseAmqpLink.Session.SafeClose();
        }

        private async Task<Message> ProcessMessage(Message message)
        {
            var processedMessage = message;
            foreach (var plugin in RegisteredPlugins)
            {
                try
                {
                    MessagingEventSource.Log.PluginCallStarted(plugin.Name, message.MessageId);
                    processedMessage = await plugin.AfterMessageReceive(message).ConfigureAwait(false);
                    MessagingEventSource.Log.PluginCallCompleted(plugin.Name, message.MessageId);
                }
                catch (Exception ex)
                {
                    MessagingEventSource.Log.PluginCallFailed(plugin.Name, message.MessageId, ex);
                    if (!plugin.ShouldContinueOnException)
                    {
                        throw;
                    }
                }
            }
            return processedMessage;
        }

        private async Task<IList<Message>> ProcessMessages(IList<Message> messageList)
        {
            if (RegisteredPlugins.Count < 1)
            {
                return messageList;
            }

            var processedMessageList = new List<Message>();
            foreach (var message in messageList)
            {
                var processedMessage = await ProcessMessage(message).ConfigureAwait(false);
                processedMessageList.Add(processedMessage);
            }

            return processedMessageList;
        }

        private async Task DisposeMessagesAsync(IEnumerable<Guid> lockTokens, Outcome outcome)
        {
            if(_isSessionReceiver)
            {
                ThrowIfSessionLockLost();
            }

            var timeoutHelper = new TimeoutHelper(OperationTimeout, true);
            var deliveryTags = ConvertLockTokensToDeliveryTags(lockTokens);

            ReceivingAmqpLink receiveLink = null;
            try
            {
                var transactionId = AmqpConstants.NullBinary;
                var ambientTransaction = Transaction.Current;
                if (ambientTransaction != null)
                {
                    transactionId = await AmqpTransactionManager.Instance.EnlistAsync(ambientTransaction, ServiceBusConnection).ConfigureAwait(false);
                }

                if (!ReceiveLinkManager.TryGetOpenedObject(out receiveLink))
                {
                    MessagingEventSource.Log.CreatingNewLink(ClientId, _isSessionReceiver, SessionIdInternal, false, LinkException);
                    receiveLink = await ReceiveLinkManager.GetOrCreateAsync(timeoutHelper.RemainingTime()).ConfigureAwait(false);
                }

                var disposeMessageTasks = new Task<Outcome>[deliveryTags.Count];
                var i = 0;
                foreach (var deliveryTag in deliveryTags)
                {
                    disposeMessageTasks[i++] = Task.Factory.FromAsync(
                        (c, s) => receiveLink.BeginDisposeMessage(deliveryTag, transactionId, outcome, true, timeoutHelper.RemainingTime(), c, s),
                        a => receiveLink.EndDisposeMessage(a),
                        this);
                }

                var outcomes = await Task.WhenAll(disposeMessageTasks).ConfigureAwait(false);
                Error error = null;
                foreach (var item in outcomes)
                {
                    var disposedOutcome = item.DescriptorCode == Rejected.Code && ((error = ((Rejected)item).Error) != null) ? item : null;
                    if (disposedOutcome != null)
                    {
                        if (error.Condition.Equals(AmqpErrorCode.NotFound))
                        {
                            if (_isSessionReceiver)
                            {
                                throw new SessionLockLostException(Resources.SessionLockExpiredOnMessageSession);
                            }

                            throw new MessageLockLostException(Resources.MessageLockLost);
                        }

                        throw error.ToMessagingContractException();
                    }
                }
            }
            catch (Exception exception)
            {
                if (exception is OperationCanceledException &&
                    receiveLink != null && receiveLink.State != AmqpObjectState.Opened)
                {
                    // The link state is lost, We need to return a non-retriable error.
                    MessagingEventSource.Log.LinkStateLost(ClientId, receiveLink.Name, receiveLink.State, _isSessionReceiver, exception);
                    if (_isSessionReceiver)
                    {
                        throw new SessionLockLostException(Resources.SessionLockExpiredOnMessageSession);
                    }

                    throw new MessageLockLostException(Resources.MessageLockLost);
                }

                throw AmqpExceptionHelper.GetClientException(exception);
            }
        }

        private async Task DisposeMessageRequestResponseAsync(Guid[] lockTokens, DispositionStatus dispositionStatus, IDictionary<string, object> propertiesToModify = null, string deadLetterReason = null, string deadLetterDescription = null)
        {
            try
            {
                // Create an AmqpRequest Message to update disposition
                var amqpRequestMessage = AmqpRequestMessage.CreateRequest(ManagementConstants.Operations.UpdateDispositionOperation, OperationTimeout, null);

                if (ReceiveLinkManager.TryGetOpenedObject(out var receiveLink))
                {
                    amqpRequestMessage.AmqpMessage.ApplicationProperties.Map[ManagementConstants.Request.AssociatedLinkName] = receiveLink.Name;
                }
                amqpRequestMessage.Map[ManagementConstants.Properties.LockTokens] = lockTokens;
                amqpRequestMessage.Map[ManagementConstants.Properties.DispositionStatus] = dispositionStatus.ToString().ToLowerInvariant();

                if (deadLetterReason != null)
                {
                    amqpRequestMessage.Map[ManagementConstants.Properties.DeadLetterReason] = deadLetterReason;
                }

                if (deadLetterDescription != null)
                {
                    amqpRequestMessage.Map[ManagementConstants.Properties.DeadLetterDescription] = deadLetterDescription;
                }

                if (propertiesToModify != null)
                {
                    var amqpPropertiesToModify = new AmqpMap();
                    foreach (var pair in propertiesToModify)
                    {
                        if (AmqpMessageConverter.TryGetAmqpObjectFromNetObject(pair.Value, MappingType.ApplicationProperty, out var amqpObject))
                        {
                            amqpPropertiesToModify[new MapKey(pair.Key)] = amqpObject;
                        }
                        else
                        {
                            throw new NotSupportedException(
                                Resources.InvalidAmqpMessageProperty.FormatForUser(pair.Key.GetType()));
                        }
                    }

                    if (amqpPropertiesToModify.Count > 0)
                    {
                        amqpRequestMessage.Map[ManagementConstants.Properties.PropertiesToModify] = amqpPropertiesToModify;
                    }
                }

                if (!string.IsNullOrWhiteSpace(SessionIdInternal))
                {
                    amqpRequestMessage.Map[ManagementConstants.Properties.SessionId] = SessionIdInternal;
                }

                var amqpResponseMessage = await ExecuteRequestResponseAsync(amqpRequestMessage).ConfigureAwait(false);
                if (amqpResponseMessage.StatusCode != AmqpResponseStatusCode.OK)
                {
                    throw amqpResponseMessage.ToMessagingContractException();
                }
            }
            catch (Exception exception)
            {
                throw AmqpExceptionHelper.GetClientException(exception);
            }
        }

        private async Task<ReceivingAmqpLink> CreateLinkAsync(TimeSpan timeout)
        {
            FilterSet filterMap = null;

            MessagingEventSource.Log.AmqpReceiveLinkCreateStart(ClientId, false, EntityType, Path);

            if (_isSessionReceiver)
            {
                filterMap = new FilterSet { { AmqpClientConstants.SessionFilterName, SessionIdInternal } };
            }

            var amqpLinkSettings = new AmqpLinkSettings
            {
                Role = true,
                TotalLinkCredit = (uint)PrefetchCount,
                AutoSendFlow = PrefetchCount > 0,
                Source = new Source { Address = Path, FilterSet = filterMap },
                SettleType = (ReceiveMode == ReceiveMode.PeekLock) ? SettleMode.SettleOnDispose : SettleMode.SettleOnSend
            };

            if (EntityType != null)
            {
                amqpLinkSettings.AddProperty(AmqpClientConstants.EntityTypeName, (int)EntityType);
            }

            amqpLinkSettings.AddProperty(AmqpClientConstants.TimeoutName, (uint)timeout.TotalMilliseconds);

            var endpointUri = new Uri(ServiceBusConnection.Endpoint, Path);
            var claims = new[] { ClaimConstants.Listen };
            var amqpSendReceiveLinkCreator = new AmqpSendReceiveLinkCreator(
                Path,
                ServiceBusConnection,
                endpointUri,
                new[] { endpointUri.AbsoluteUri },
                claims,
                CbsTokenProvider,
                amqpLinkSettings,
                ClientId);

            var linkDetails = await amqpSendReceiveLinkCreator.CreateAndOpenAmqpLinkAsync().ConfigureAwait(false);

            var receivingAmqpLink = (ReceivingAmqpLink) linkDetails.Item1;
            var activeSendReceiveClientLink = new ActiveSendReceiveClientLink(
                receivingAmqpLink,
                endpointUri,
                new[] { endpointUri.AbsoluteUri },
                claims,
                linkDetails.Item2);

            _clientLinkManager.SetActiveSendReceiveLink(activeSendReceiveClientLink);

            MessagingEventSource.Log.AmqpReceiveLinkCreateStop(ClientId);

            return receivingAmqpLink;
        }

        // TODO: Consolidate the link creation paths
        private async Task<RequestResponseAmqpLink> CreateRequestResponseLinkAsync(TimeSpan timeout)
        {
            var entityPath = Path + '/' + AmqpClientConstants.ManagementAddress;

            MessagingEventSource.Log.AmqpReceiveLinkCreateStart(ClientId, true, EntityType, entityPath);
            var amqpLinkSettings = new AmqpLinkSettings();
            amqpLinkSettings.AddProperty(AmqpClientConstants.EntityTypeName, AmqpClientConstants.EntityTypeManagement);

            var endpointUri = new Uri(ServiceBusConnection.Endpoint, entityPath);
            string[] claims = { ClaimConstants.Manage, ClaimConstants.Listen };
            var amqpRequestResponseLinkCreator = new AmqpRequestResponseLinkCreator(
                entityPath,
                ServiceBusConnection,
                endpointUri,
                new[] { endpointUri.AbsoluteUri },
                claims,
                CbsTokenProvider,
                amqpLinkSettings,
                ClientId);

            var linkDetails = await amqpRequestResponseLinkCreator.CreateAndOpenAmqpLinkAsync().ConfigureAwait(false);

            var requestResponseAmqpLink = (RequestResponseAmqpLink)linkDetails.Item1;
            var activeRequestResponseClientLink = new ActiveRequestResponseLink(
                requestResponseAmqpLink,
                endpointUri,
                new[] { endpointUri.AbsoluteUri },
                claims,
                linkDetails.Item2);
            _clientLinkManager.SetActiveRequestResponseLink(activeRequestResponseClientLink);

            MessagingEventSource.Log.AmqpReceiveLinkCreateStop(ClientId);
            return requestResponseAmqpLink;
        }

        private void OnSessionReceiverLinkClosed(object sender, EventArgs e)
        {
            var receivingAmqpLink = (ReceivingAmqpLink)sender;
            if (receivingAmqpLink != null)
            {
                var exception = receivingAmqpLink.GetInnerException();
                if (!(exception is SessionLockLostException))
                {
                    exception = new SessionLockLostException("Session lock lost. Accept a new session", exception);
                }

                LinkException = exception;
                MessagingEventSource.Log.SessionReceiverLinkClosed(ClientId, SessionIdInternal, LinkException);
            }
        }

        private List<ArraySegment<byte>> ConvertLockTokensToDeliveryTags(IEnumerable<Guid> lockTokens)
        {
            return lockTokens.Select(lockToken => new ArraySegment<byte>(lockToken.ToByteArray())).ToList();
        }

        private void ThrowIfNotPeekLockMode()
        {
            if (ReceiveMode != ReceiveMode.PeekLock)
            {
                throw Fx.Exception.AsError(new InvalidOperationException("The operation is only supported in 'PeekLock' receive mode."));
            }
        }

        private void ThrowIfSessionLockLost()
        {
            if (LinkException != null)
            {
                throw LinkException;
            }
        }

        private Outcome GetAbandonOutcome(IDictionary<string, object> propertiesToModify)
        {
            return GetModifiedOutcome(propertiesToModify, false);
        }

        private Outcome GetDeferOutcome(IDictionary<string, object> propertiesToModify)
        {
            return GetModifiedOutcome(propertiesToModify, true);
        }

        private Outcome GetModifiedOutcome(IDictionary<string, object> propertiesToModify, bool undeliverableHere)
        {
            var modified = new Modified();
            if (undeliverableHere)
            {
                modified.UndeliverableHere = true;
            }

            if (propertiesToModify != null)
            {
                modified.MessageAnnotations = new Fields();
                foreach (var pair in propertiesToModify)
                {
                    if (AmqpMessageConverter.TryGetAmqpObjectFromNetObject(pair.Value, MappingType.ApplicationProperty, out var amqpObject))
                    {
                        modified.MessageAnnotations.Add(pair.Key, amqpObject);
                    }
                    else
                    {
                        throw new NotSupportedException(Resources.InvalidAmqpMessageProperty.FormatForUser(pair.Key.GetType()));
                    }
                }
            }

            return modified;
        }

        private Rejected GetRejectedOutcome(IDictionary<string, object> propertiesToModify, string deadLetterReason, string deadLetterErrorDescription)
        {
            var rejected = AmqpConstants.RejectedOutcome;
            if (deadLetterReason != null || deadLetterErrorDescription != null || propertiesToModify != null)
            {
                rejected = new Rejected { Error = new Error { Condition = AmqpClientConstants.DeadLetterName, Info = new Fields() } };
                if (deadLetterReason != null)
                {
                    rejected.Error.Info.Add(Message.DeadLetterReasonHeader, deadLetterReason);
                }

                if (deadLetterErrorDescription != null)
                {
                    rejected.Error.Info.Add(Message.DeadLetterErrorDescriptionHeader, deadLetterErrorDescription);
                }

                if (propertiesToModify != null)
                {
                    foreach (var pair in propertiesToModify)
                    {
                        if (AmqpMessageConverter.TryGetAmqpObjectFromNetObject(pair.Value, MappingType.ApplicationProperty, out var amqpObject))
                        {
                            rejected.Error.Info.Add(pair.Key, amqpObject);
                        }
                        else
                        {
                            throw new NotSupportedException(Resources.InvalidAmqpMessageProperty.FormatForUser(pair.Key.GetType()));
                        }
                    }
                }
            }

            return rejected;
        }
    }
}
