// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> SessionHost properties that can be patched. </summary>
    public partial class PatchableSessionHostData : ResourceData
    {
        /// <summary> Initializes a new instance of PatchableSessionHostData. </summary>
        public PatchableSessionHostData()
        {
        }

        /// <summary> Initializes a new instance of PatchableSessionHostData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="allowNewSession"> Allow a new session. </param>
        /// <param name="assignedUser"> User assigned to SessionHost. </param>
        internal PatchableSessionHostData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? allowNewSession, string assignedUser) : base(id, name, resourceType, systemData)
        {
            AllowNewSession = allowNewSession;
            AssignedUser = assignedUser;
        }

        /// <summary> Allow a new session. </summary>
        public bool? AllowNewSession { get; set; }
        /// <summary> User assigned to SessionHost. </summary>
        public string AssignedUser { get; set; }
    }
}
