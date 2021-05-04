// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Core
{
    /// <summary> The IdentityUserAssignedIdentitiesValue. </summary>
    public partial class IdentityUserAssignedIdentitiesValue
    {
        /// <summary> Initializes a new instance of IdentityUserAssignedIdentitiesValue. </summary>
        public IdentityUserAssignedIdentitiesValue()
        {
        }

        /// <summary> Initializes a new instance of IdentityUserAssignedIdentitiesValue. </summary>
        /// <param name="principalId"> The principal id of user assigned identity. </param>
        /// <param name="clientId"> The client id of user assigned identity. </param>
        internal IdentityUserAssignedIdentitiesValue(string principalId, string clientId)
        {
            PrincipalId = principalId;
            ClientId = clientId;
        }

        /// <summary> The principal id of user assigned identity. </summary>
        public string PrincipalId { get; }
        /// <summary> The client id of user assigned identity. </summary>
        public string ClientId { get; }
    }
}
