// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> The properties for a group information object. </summary>
    public partial class DeviceProvisioningServicesPrivateLinkResourceProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesPrivateLinkResourceProperties"/>. </summary>
        internal DeviceProvisioningServicesPrivateLinkResourceProperties()
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesPrivateLinkResourceProperties"/>. </summary>
        /// <param name="groupId"> The group id. </param>
        /// <param name="requiredMembers"> The required members for a specific group id. </param>
        /// <param name="requiredZoneNames"> The required DNS zones for a specific group id. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceProvisioningServicesPrivateLinkResourceProperties(string groupId, IReadOnlyList<string> requiredMembers, IReadOnlyList<string> requiredZoneNames, Dictionary<string, BinaryData> rawData)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
            _rawData = rawData;
        }

        /// <summary> The group id. </summary>
        public string GroupId { get; }
        /// <summary> The required members for a specific group id. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> The required DNS zones for a specific group id. </summary>
        public IReadOnlyList<string> RequiredZoneNames { get; }
    }
}
