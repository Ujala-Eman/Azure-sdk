// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Identity properties of the workspace resource. </summary>
    public partial class WorkspaceIdentity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WorkspaceIdentity"/>. </summary>
        public WorkspaceIdentity()
        {
            Type = WorkspaceIdentityType.SystemAssigned;
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceIdentity"/>. </summary>
        /// <param name="type"> The identity type. Currently the only supported type is 'SystemAssigned'. </param>
        /// <param name="principalId"> The principal id of the identity. </param>
        /// <param name="tenantId"> The client tenant id of the identity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkspaceIdentity(WorkspaceIdentityType type, string principalId, string tenantId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            PrincipalId = principalId;
            TenantId = tenantId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The identity type. Currently the only supported type is 'SystemAssigned'. </summary>
        public WorkspaceIdentityType Type { get; }
        /// <summary> The principal id of the identity. </summary>
        public string PrincipalId { get; }
        /// <summary> The client tenant id of the identity. </summary>
        public string TenantId { get; }
    }
}
