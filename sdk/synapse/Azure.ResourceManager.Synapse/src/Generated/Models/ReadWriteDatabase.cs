// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Class representing a read write database. </summary>
    public partial class ReadWriteDatabase : DatabaseData
    {
        /// <summary> Initializes a new instance of ReadWriteDatabase. </summary>
        public ReadWriteDatabase()
        {
            Kind = SynapseKind.ReadWrite;
        }

        /// <summary> Initializes a new instance of ReadWriteDatabase. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="kind"> Kind of the database. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        /// <param name="softDeletePeriod"> The time the data should be kept before it stops being accessible to queries in TimeSpan. </param>
        /// <param name="hotCachePeriod"> The time the data should be kept in cache for fast queries in TimeSpan. </param>
        /// <param name="statistics"> The statistics of the database. </param>
        /// <param name="isFollowed"> Indicates whether the database is followed. </param>
        internal ReadWriteDatabase(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, SynapseKind kind, ResourceProvisioningState? provisioningState, TimeSpan? softDeletePeriod, TimeSpan? hotCachePeriod, DatabaseStatistics statistics, bool? isFollowed) : base(id, name, resourceType, systemData, location, kind)
        {
            ProvisioningState = provisioningState;
            SoftDeletePeriod = softDeletePeriod;
            HotCachePeriod = hotCachePeriod;
            Statistics = statistics;
            IsFollowed = isFollowed;
            Kind = kind;
        }

        /// <summary> The provisioned state of the resource. </summary>
        public ResourceProvisioningState? ProvisioningState { get; }
        /// <summary> The time the data should be kept before it stops being accessible to queries in TimeSpan. </summary>
        public TimeSpan? SoftDeletePeriod { get; set; }
        /// <summary> The time the data should be kept in cache for fast queries in TimeSpan. </summary>
        public TimeSpan? HotCachePeriod { get; set; }
        /// <summary> The statistics of the database. </summary>
        internal DatabaseStatistics Statistics { get; }
        /// <summary> The database size - the total size of compressed data and index in bytes. </summary>
        public float? StatisticsSize
        {
            get => Statistics?.Size;
        }

        /// <summary> Indicates whether the database is followed. </summary>
        public bool? IsFollowed { get; }
    }
}
