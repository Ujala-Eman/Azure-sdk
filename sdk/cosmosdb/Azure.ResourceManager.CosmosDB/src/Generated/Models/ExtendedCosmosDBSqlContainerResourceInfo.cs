// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The ExtendedCosmosDBSqlContainerResourceInfo. </summary>
    public partial class ExtendedCosmosDBSqlContainerResourceInfo : CosmosDBSqlContainerResourceInfo
    {
        /// <summary> Initializes a new instance of ExtendedCosmosDBSqlContainerResourceInfo. </summary>
        /// <param name="id"> Name of the Cosmos DB SQL container. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public ExtendedCosmosDBSqlContainerResourceInfo(string id) : base(id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
        }

        /// <summary> Initializes a new instance of ExtendedCosmosDBSqlContainerResourceInfo. </summary>
        /// <param name="id"> Name of the Cosmos DB SQL container. </param>
        /// <param name="indexingPolicy"> The configuration of the indexing policy. By default, the indexing is automatic for all document paths within the container. </param>
        /// <param name="partitionKey"> The configuration of the partition key to be used for partitioning data into multiple partitions. </param>
        /// <param name="defaultTtl"> Default time to live. </param>
        /// <param name="uniqueKeyPolicy"> The unique key policy configuration for specifying uniqueness constraints on documents in the collection in the Azure Cosmos DB service. </param>
        /// <param name="conflictResolutionPolicy"> The conflict resolution policy for the container. </param>
        /// <param name="analyticalStorageTtl"> Analytical TTL. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="timestamp"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="eTag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        internal ExtendedCosmosDBSqlContainerResourceInfo(string id, CosmosDBIndexingPolicy indexingPolicy, ContainerPartitionKey partitionKey, int? defaultTtl, CosmosDBUniqueKeyPolicy uniqueKeyPolicy, ConflictResolutionPolicy conflictResolutionPolicy, long? analyticalStorageTtl, string rid, float? timestamp, ETag? eTag) : base(id, indexingPolicy, partitionKey, defaultTtl, uniqueKeyPolicy, conflictResolutionPolicy, analyticalStorageTtl)
        {
            Rid = rid;
            Timestamp = timestamp;
            ETag = eTag;
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> A system generated property that denotes the last updated timestamp of the resource. </summary>
        public float? Timestamp { get; }
        /// <summary> A system generated property representing the resource etag required for optimistic concurrency control. </summary>
        public ETag? ETag { get; }
    }
}
