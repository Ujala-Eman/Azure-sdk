﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Storage.Queues;
using Microsoft.Azure.WebJobs.Logging;
using Microsoft.Extensions.Logging;
using System;

namespace Microsoft.Azure.WebJobs.Host.Queues
{
    /// <summary>
    /// Provides context input for <see cref="IQueueProcessorFactory"/>.
    /// </summary>
    public partial class QueueProcessorFactoryContext
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="queue">TODO.</param>
        /// <param name="loggerFactory">The <see cref="ILoggerFactory"/> to create an <see cref="ILogger"/> from.</param>
        /// <param name="poisonQueue">The queue to move messages to when unable to process a message after the maximum dequeue count has been exceeded. May be null.</param>
        public QueueProcessorFactoryContext(QueueClient queue, ILoggerFactory loggerFactory, QueueClient poisonQueue = null)
        {
            Queue = queue ?? throw new ArgumentNullException(nameof(queue));
            PoisonQueue = poisonQueue;
            Logger = loggerFactory?.CreateLogger(LogCategories.CreateTriggerCategory("Queue"));
        }

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="queue">TODO.</param>
        /// <param name="loggerFactory">The <see cref="ILoggerFactory"/> to create an <see cref="ILogger"/> from.</param>
        /// <param name="options">The queue configuration.</param>
        /// <param name="poisonQueue">The queue to move messages to when unable to process a message after the maximum dequeue count has been exceeded. May be null.</param>
        // TODO (kasobol-msft) this was internal - hide after decoupling blobs.
        public QueueProcessorFactoryContext(QueueClient queue, ILoggerFactory loggerFactory, QueuesOptions options, QueueClient poisonQueue = null)
            : this(queue, loggerFactory, poisonQueue)
        {
            Options = options;
        }

        /// <summary>
        /// TODO.
        /// </summary>
        public QueueClient Queue { get; private set; }

        /// <summary>
        /// TODO.
        /// May be null.
        /// </summary>
        public QueueClient PoisonQueue { get; private set; }

        /// <summary>
        /// Gets the <see cref="ILogger"/>.
        /// </summary>
        public ILogger Logger { get; private set; }

        /// <summary>
        /// TODO.
        /// </summary>
        public QueuesOptions Options { get; private set; }
    }
}
