// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> List of Clusters. </summary>
    internal partial class VMwareClusterListResult
    {
        /// <summary> Initializes a new instance of VMwareClusterListResult. </summary>
        /// <param name="value"> Array of Clusters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal VMwareClusterListResult(IEnumerable<VMwareClusterData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of VMwareClusterListResult. </summary>
        /// <param name="nextLink"> Url to follow for getting next page of Clusters. </param>
        /// <param name="value"> Array of Clusters. </param>
        internal VMwareClusterListResult(string nextLink, IReadOnlyList<VMwareClusterData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> Url to follow for getting next page of Clusters. </summary>
        public string NextLink { get; }
        /// <summary> Array of Clusters. </summary>
        public IReadOnlyList<VMwareClusterData> Value { get; }
    }
}
