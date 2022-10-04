// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Initial workspace AAD admin properties for a CSP subscription. </summary>
    internal partial class CspWorkspaceAdminProperties
    {
        /// <summary> Initializes a new instance of CspWorkspaceAdminProperties. </summary>
        public CspWorkspaceAdminProperties()
        {
        }

        /// <summary> Initializes a new instance of CspWorkspaceAdminProperties. </summary>
        /// <param name="initialWorkspaceAdminObjectId"> AAD object ID of initial workspace admin. </param>
        internal CspWorkspaceAdminProperties(string initialWorkspaceAdminObjectId)
        {
            InitialWorkspaceAdminObjectId = initialWorkspaceAdminObjectId;
        }

        /// <summary> AAD object ID of initial workspace admin. </summary>
        public string InitialWorkspaceAdminObjectId { get; set; }
    }
}
