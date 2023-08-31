// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> SingletonPartitionScheme. </summary>
    public partial class SingletonPartitionScheme : ManagedServicePartitionScheme
    {
        /// <summary> Initializes a new instance of <see cref="SingletonPartitionScheme"/>. </summary>
        public SingletonPartitionScheme()
        {
            PartitionScheme = PartitionScheme.Singleton;
        }

        /// <summary> Initializes a new instance of <see cref="SingletonPartitionScheme"/>. </summary>
        /// <param name="partitionScheme"> Specifies how the service is partitioned. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SingletonPartitionScheme(PartitionScheme partitionScheme, Dictionary<string, BinaryData> rawData) : base(partitionScheme, rawData)
        {
            PartitionScheme = partitionScheme;
        }
    }
}
