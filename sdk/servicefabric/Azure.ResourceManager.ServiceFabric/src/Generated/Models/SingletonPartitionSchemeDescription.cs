// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> SingletonPartitionSchemeDescription. </summary>
    public partial class SingletonPartitionSchemeDescription : PartitionSchemeDescription
    {
        /// <summary> Initializes a new instance of <see cref="SingletonPartitionSchemeDescription"/>. </summary>
        public SingletonPartitionSchemeDescription()
        {
            PartitionScheme = ApplicationPartitionScheme.Singleton;
        }

        /// <summary> Initializes a new instance of <see cref="SingletonPartitionSchemeDescription"/>. </summary>
        /// <param name="partitionScheme"> Specifies how the service is partitioned. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SingletonPartitionSchemeDescription(ApplicationPartitionScheme partitionScheme, Dictionary<string, BinaryData> rawData) : base(partitionScheme, rawData)
        {
            PartitionScheme = partitionScheme;
        }
    }
}
