// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> The pool properties for partial update. Properties not provided in the update request will not be changed. </summary>
    public partial class DevCenterPoolPatch : DevCenterTrackedResourceUpdate
    {
        /// <summary> Initializes a new instance of <see cref="DevCenterPoolPatch"/>. </summary>
        public DevCenterPoolPatch()
        {
        }

        /// <summary> Name of a Dev Box definition in parent Project of this Pool. </summary>
        public string DevBoxDefinitionName { get; set; }
        /// <summary> Name of a Network Connection in parent Project of this Pool. </summary>
        public string NetworkConnectionName { get; set; }
        /// <summary> Specifies the license type indicating the caller has already acquired licenses for the Dev Boxes that will be created. </summary>
        public DevCenterLicenseType? LicenseType { get; set; }
        /// <summary> Indicates whether owners of Dev Boxes in this pool are added as local administrators on the Dev Box. </summary>
        public LocalAdminStatus? LocalAdministrator { get; set; }
        /// <summary> Stop on disconnect configuration settings for Dev Boxes created in this pool. </summary>
        public StopOnDisconnectConfiguration StopOnDisconnect { get; set; }
    }
}
