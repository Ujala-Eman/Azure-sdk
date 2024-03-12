// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Unknown version of ClusterJobProperties. </summary>
    internal partial class UnknownClusterJobProperties : ClusterJobProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownClusterJobProperties"/>. </summary>
        /// <param name="jobType"> Type of cluster job. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownClusterJobProperties(ClusterJobType jobType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(jobType, serializedAdditionalRawData)
        {
            JobType = jobType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownClusterJobProperties"/> for deserialization. </summary>
        internal UnknownClusterJobProperties()
        {
        }
    }
}
