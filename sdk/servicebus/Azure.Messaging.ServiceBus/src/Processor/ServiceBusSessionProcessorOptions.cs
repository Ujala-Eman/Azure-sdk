﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Azure.Core;

namespace Azure.Messaging.ServiceBus
{
    /// <summary>
    /// The set of options that can be specified when creating a
    /// <see cref="ServiceBusSessionProcessor" /> to configure its behavior.
    /// </summary>
    public class ServiceBusSessionProcessorOptions
    {
        /// <inheritdoc cref="ServiceBusProcessorOptions.PrefetchCount"/>
        public int PrefetchCount
        {
            get
            {
                return _prefetchCount;
            }
            set
            {
                Argument.AssertAtLeast(value, 0, nameof(PrefetchCount));
                _prefetchCount = value;
            }
        }
        private int _prefetchCount;

        /// <inheritdoc cref="ServiceBusProcessorOptions.ReceiveMode"/>
        public ServiceBusReceiveMode ReceiveMode { get; set; } = ServiceBusReceiveMode.PeekLock;

        /// <summary>Gets or sets a value that indicates whether the processor
        /// should automatically complete messages after the <see cref="ServiceBusSessionProcessor.ProcessMessageAsync"/>
        /// handler has completed processing. If the message handler triggers an exception,
        /// the message will not be automatically completed.
        /// </summary>
        ///
        /// <value><c>true</c> to complete the message automatically on successful execution of the message handler; otherwise, <c>false</c>.
        /// The default value is <c>true</c>.</value>
        public bool AutoCompleteMessages { get; set; } = true;

        /// <summary>
        /// Gets or sets the maximum duration within which the session lock will be renewed automatically. This value
        /// should be greater than the queue's LockDuration Property.
        /// </summary>
        ///
        /// <value>The maximum duration during which session locks are automatically renewed. The default value is 5 minutes.</value>
        /// <remarks>The session lock renewal can continue for sometime in the background
        /// after completion of message and result in a few false SessionLockLost exceptions temporarily.</remarks>
        /// <exception cref="ArgumentOutOfRangeException">
        ///   A negative value is attempted to be set for the property.
        /// </exception>
        public TimeSpan MaxAutoLockRenewalDuration
        {
            get => _maxAutoRenewDuration;

            set
            {
                Argument.AssertNotNegative(value, nameof(MaxAutoLockRenewalDuration));
                _maxAutoRenewDuration = value;
            }
        }
        private TimeSpan _maxAutoRenewDuration = TimeSpan.FromMinutes(5);

        /// <summary>
        /// Gets or sets the maximum amount of time to wait for a message to be received for the
        /// currently active session. After this time has elapsed, the processor will close the session
        /// and attempt to process another session.
        /// If not specified, the <see cref="ServiceBusRetryOptions.TryTimeout"/> will be used.
        /// </summary>
        ///
        /// <remarks>
        /// If <see cref="SessionIds"/> is populated and <see cref="MaxConcurrentSessions"/> is greater or equal to
        /// the number of sessions specified in <see cref="SessionIds"/>, the session will not be closed when the idle timeout elapses.
        /// However, it will still control the amount of time each receive call waits.
        /// </remarks>
        /// <exception cref="ArgumentOutOfRangeException">
        ///   A value that is not positive is attempted to be set for the property.
        /// </exception>
        public TimeSpan? SessionIdleTimeout
        {
            get => _sessionIdleTimeout;

            set
            {
                if (value.HasValue)
                {
                    Argument.AssertPositive(value.Value, nameof(SessionIdleTimeout));
                }

                _sessionIdleTimeout = value;
            }
        }
        private TimeSpan? _sessionIdleTimeout;

        /// <summary>
        /// Gets or sets the maximum number of sessions that can be processed concurrently by the processor.
        /// </summary>
        ///
        /// <value>The maximum number of concurrent sessions to process. The default value is 8.</value>
        /// <exception cref="ArgumentOutOfRangeException">
        ///   A value that is not positive is attempted to be set for the property.
        /// </exception>
        public int MaxConcurrentSessions
        {
            get => _maxConcurrentSessions;

            set
            {
                Argument.AssertAtLeast(value, 1, nameof(MaxConcurrentSessions));
                _maxConcurrentSessions = value;
            }
        }
        private int _maxConcurrentSessions = 8;

        /// <summary>
        /// Gets or sets the maximum number of concurrent calls to the message handler the processor should initiate per session.
        /// Thus the total number of concurrent calls will be equal to MaxConcurrentSessions * MaxConcurrentCallsPerSession.
        /// The default value is 1.
        /// </summary>
        ///
        /// <value>The maximum number of concurrent calls to the message handler for each session that is being processed.</value>
        /// <exception cref="ArgumentOutOfRangeException">
        ///   A value that is not positive is attempted to be set for the property.
        /// </exception>
        public int MaxConcurrentCallsPerSession
        {
            get => _maxConcurrentCallsPerSessions;

            set
            {
                Argument.AssertAtLeast(value, 1, nameof(MaxConcurrentCallsPerSession));
                _maxConcurrentCallsPerSessions = value;
            }
        }
        private int _maxConcurrentCallsPerSessions = 1;

        /// <summary>Gets or sets the maximum number of concurrent calls to the
        /// message handler the processor should initiate across all sessions. If not specified, this value
        /// will be computed based on the <see cref="MaxConcurrentSessions"/> and <see cref="MaxConcurrentCallsPerSession"/> properties.
        /// </summary>
        ///
        /// <value>The maximum number of concurrent calls to the message handler.</value>
        /// <exception cref="ArgumentOutOfRangeException">
        ///   A value that is not positive is attempted to be set for the property.
        /// </exception>
        /// <remarks>
        /// This does not override the limits specified in <see cref="MaxConcurrentSessions"/> and <see cref="MaxConcurrentCallsPerSession"/>, but acts as further limit
        /// to the total calls. As an example, suppose you want to allow 100 concurrent invocations of the message handler,
        /// and you want to process up to 20 sessions concurrently. You can try setting MaxConcurrentSessions to 20, and MaxConcurrentCallsPerSession to 5.
        /// However, in practice, your queue might typically have only 10 sessions with messages at a given time. So in order to achieve
        /// your desired throughput, you can instead set MaxConcurrentCallsPerSession to 10. This would mean that if your queue ever did have
        /// 20 sessions at a time, you would be doing 200 invocations. In order to prevent this, you can set MaxConcurrentCallsAcrossAllSessions to 100.
        /// This allows the processor to attempt to scale up to the MaxConcurrentCallsPerSession when the number of available sessions is lower,
        /// while still being able to accept new sessions without breaking your throughput requirement as the number of available sessions
        /// increases.
        /// </remarks>
        public int? MaxConcurrentCallsAcrossAllSessions
        {
            get => _maxConcurrentCallsAcrossAllSessions;

            set
            {
                if (value.HasValue)
                {
                    Argument.AssertAtLeast(value.Value, 1, nameof(MaxConcurrentCallsAcrossAllSessions));
                    _maxConcurrentCallsAcrossAllSessions = value;
                }
            }
        }
        private int? _maxConcurrentCallsAcrossAllSessions;

        /// <summary>
        /// Gets an optional list of session IDs to scope
        /// the <see cref="ServiceBusSessionProcessor"/> to. If the list is
        /// left empty, the processor will not be limited to any specific
        /// session IDs.
        /// </summary>
        public IList<string> SessionIds { get; } = new List<string>();

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        ///
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        ///
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => base.Equals(obj);

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        ///
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => base.GetHashCode();

        /// <summary>
        /// Converts the instance to string representation.
        /// </summary>
        ///
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => base.ToString();

        internal ServiceBusProcessorOptions ToProcessorOptions() =>
            new ServiceBusProcessorOptions
            {
                ReceiveMode = ReceiveMode,
                PrefetchCount = PrefetchCount,
                AutoCompleteMessages = AutoCompleteMessages,
                MaxAutoLockRenewalDuration = MaxAutoLockRenewalDuration,
                MaxReceiveWaitTime = SessionIdleTimeout,
            };
    }
}
