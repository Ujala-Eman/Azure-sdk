// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> List storage account object replication policies. </summary>
    public partial class ObjectReplicationPolicies
    {
        /// <summary> Initializes a new instance of ObjectReplicationPolicies. </summary>
        internal ObjectReplicationPolicies()
        {
        }

        /// <summary> Initializes a new instance of ObjectReplicationPolicies. </summary>
        /// <param name="value"> The replication policy between two storage accounts. </param>
        internal ObjectReplicationPolicies(IReadOnlyList<ObjectReplicationPolicy> value)
        {
            Value = value;
        }

        /// <summary> The replication policy between two storage accounts. </summary>
        public IReadOnlyList<ObjectReplicationPolicy> Value { get; }
    }
}
