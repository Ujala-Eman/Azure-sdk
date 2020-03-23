﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Messaging.ServiceBus
{
    /// <summary>
    /// Contains information about a receiver that has attempted to receive a message from the Azure Service Bus entity.
    /// </summary>
    public class ProcessMessageEventArgs : EventArgs
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessMessageEventArgs"/> class.
        /// </summary>
        ///
        /// <param name="message"></param>
        /// <param name="receiver"></param>
        /// <param name="cancellationToken"></param>
        internal ProcessMessageEventArgs(ServiceBusReceivedMessage message, ServiceBusReceiver receiver, CancellationToken cancellationToken)
        {
            Message = message;
            _receiver = receiver;
            CancellationToken = cancellationToken;
        }

        /// <summary>
        /// The received message to be processed. Expected to be <c>null</c> if the receive call has timed out.
        /// </summary>
        public ServiceBusReceivedMessage Message { get; }

        private readonly ServiceBusReceiver _receiver;

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="propertiesToModify"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task AbandonAsync(
            ServiceBusReceivedMessage message,
            IDictionary<string, object> propertiesToModify,
            CancellationToken cancellationToken = default) =>
            await _receiver.AbandonAsync(message, propertiesToModify, cancellationToken)
            .ConfigureAwait(false);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task CompleteAsync(
            ServiceBusReceivedMessage message,
            CancellationToken cancellationToken = default) =>
            await _receiver.CompleteAsync(
                message,
                cancellationToken)
            .ConfigureAwait(false);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="deadLetterReason"></param>
        /// <param name="deadLetterErrorDescription"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task DeadLetterAsync(
            ServiceBusReceivedMessage message,
            string deadLetterReason,
            string deadLetterErrorDescription,
            CancellationToken cancellationToken = default) =>
            await _receiver.DeadLetterAsync(
                message,
                deadLetterReason,
                deadLetterErrorDescription,
                cancellationToken)
            .ConfigureAwait(false);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="propertiesToModify"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task DeadLetterAsync(
            ServiceBusReceivedMessage message,
            IDictionary<string, object> propertiesToModify,
            CancellationToken cancellationToken = default) =>
            await _receiver.DeadLetterAsync(
                message,
                propertiesToModify,
                cancellationToken)
            .ConfigureAwait(false);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="propertiesToModify"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task DeferAsync(
            ServiceBusReceivedMessage message,
            IDictionary<string, object> propertiesToModify,
            CancellationToken cancellationToken = default) =>
            await _receiver.DeferAsync(
                message,
                propertiesToModify,
                cancellationToken)
            .ConfigureAwait(false);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task RenewMessageLock(
            ServiceBusReceivedMessage message,
            CancellationToken cancellationToken = default) =>
            await _receiver.RenewMessageLockAsync(
                message,
                cancellationToken)
            .ConfigureAwait(false);

        /// <summary>
        /// A <see cref="System.Threading.CancellationToken"/> instance to signal the request to cancel the operation.
        /// </summary>
        public CancellationToken CancellationToken { get; }
    }
}
