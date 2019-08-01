﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;

namespace Azure.Messaging.EventHubs.Processor
{
    /// <summary>
    ///   Responsible for dealing with the interaction with the chosen storage service.  A class implementing
    ///   this interface must be able to create checkpoints and list/claim ownership.
    /// </summary>
    ///
    /// <remarks>
    ///   An instance of a class implementing this interface is provided by the user in the <see cref="EventProcessor" />
    ///   constructor.
    /// </remarks>
    ///
    public interface IPartitionManager
    {
        /// <summary>
        ///   Retrieves a complete ownership list from the chosen storage service.
        /// </summary>
        ///
        /// <param name="eventHubName">The path of the specific Event Hub the ownership are associated with, relative to the Event Hubs namespace that contains it.</param>
        /// <param name="consumerGroup">The name of the consumer group the ownership are associated with.</param>
        ///
        /// <returns>An array containing all the existing ownership for the associated Event Hub and consumer group.</returns>
        ///
        public Task<PartitionOwnership[]> ListOwnership(string eventHubName,
                                                        string consumerGroup);

        /// <summary>
        ///   Tries to claim a list of specified ownership.
        /// </summary>
        ///
        /// <param name="partitionOwnership">An array containing all the ownership to claim.</param>
        ///
        /// <returns>An array containing all the existing ownership for the associated Event Hub and consumer group.</returns>
        ///
        public Task<PartitionOwnership[]> ClaimOwnership(PartitionOwnership[] partitionOwnership);

        /// <summary>
        ///   Updates the checkpoint using the given information for the associated partition and consumer group in the chosen storage service.
        /// </summary>
        ///
        /// <param name="checkpoint">The checkpoint containing the information to be stored.</param>
        ///
        /// <returns>A task to be resolved on when the operation has completed.</returns>
        ///
        public Task UpdateCheckpoint(Checkpoint checkpoint);
    }
}
