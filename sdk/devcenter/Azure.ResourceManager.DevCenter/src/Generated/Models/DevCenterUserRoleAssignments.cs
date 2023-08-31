// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> Mapping of user object ID to role assignments. </summary>
    public partial class DevCenterUserRoleAssignments
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DevCenterUserRoleAssignments"/>. </summary>
        public DevCenterUserRoleAssignments()
        {
            Roles = new ChangeTrackingDictionary<string, DevCenterEnvironmentRole>();
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterUserRoleAssignments"/>. </summary>
        /// <param name="roles"> A map of roles to assign to the parent user. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DevCenterUserRoleAssignments(IDictionary<string, DevCenterEnvironmentRole> roles, Dictionary<string, BinaryData> rawData)
        {
            Roles = roles;
            _rawData = rawData;
        }

        /// <summary> A map of roles to assign to the parent user. </summary>
        public IDictionary<string, DevCenterEnvironmentRole> Roles { get; }
    }
}
