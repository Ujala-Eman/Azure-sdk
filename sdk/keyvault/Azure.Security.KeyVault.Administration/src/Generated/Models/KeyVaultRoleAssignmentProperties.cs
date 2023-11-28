// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Security.KeyVault.Administration
{
    /// <summary> Role assignment properties with scope. </summary>
    public partial class KeyVaultRoleAssignmentProperties
    {
        /// <summary> Initializes a new instance of <see cref="KeyVaultRoleAssignmentProperties"/>. </summary>
        internal KeyVaultRoleAssignmentProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultRoleAssignmentProperties"/>. </summary>
        /// <param name="scope"> The role scope. </param>
        /// <param name="roleDefinitionId"> The role definition ID. </param>
        /// <param name="principalId"> The principal ID. </param>
        internal KeyVaultRoleAssignmentProperties(KeyVaultRoleScope? scope, string roleDefinitionId, string principalId)
        {
            Scope = scope;
            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
        }

        /// <summary> The role scope. </summary>
        public KeyVaultRoleScope? Scope { get; }
        /// <summary> The role definition ID. </summary>
        public string RoleDefinitionId { get; }
        /// <summary> The principal ID. </summary>
        public string PrincipalId { get; }
    }
}
