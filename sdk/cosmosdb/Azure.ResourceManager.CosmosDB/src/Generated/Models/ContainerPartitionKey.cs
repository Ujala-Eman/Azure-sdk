// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The configuration of the partition key to be used for partitioning data into multiple partitions. </summary>
    public partial class ContainerPartitionKey
    {
        /// <summary> Initializes a new instance of <see cref="ContainerPartitionKey"/>. </summary>
        public ContainerPartitionKey()
        {
            Paths = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerPartitionKey"/>. </summary>
        /// <param name="paths"> List of paths using which data within the container can be partitioned. </param>
        /// <param name="kind"> Indicates the kind of algorithm used for partitioning. For MultiHash, multiple partition keys (upto three maximum) are supported for container create. </param>
        /// <param name="version"> Indicates the version of the partition key definition. </param>
        /// <param name="systemKey"> Indicates if the container is using a system generated partition key. </param>
        internal ContainerPartitionKey(IList<string> paths, PartitionKind? kind, int? version, bool? systemKey)
        {
            Paths = paths;
            Kind = kind;
            Version = version;
            SystemKey = systemKey;
        }

        /// <summary> List of paths using which data within the container can be partitioned. </summary>
        public IList<string> Paths { get; }
        /// <summary> Indicates the kind of algorithm used for partitioning. For MultiHash, multiple partition keys (upto three maximum) are supported for container create. </summary>
        public PartitionKind? Kind { get; set; }
        /// <summary> Indicates the version of the partition key definition. </summary>
        public int? Version { get; set; }
        /// <summary> Indicates if the container is using a system generated partition key. </summary>
        public bool? SystemKey { get; }
    }
}
