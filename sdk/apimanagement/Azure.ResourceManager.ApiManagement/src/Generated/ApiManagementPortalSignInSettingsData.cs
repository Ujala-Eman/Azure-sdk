// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary> A class representing the ApiManagementPortalSignInSettings data model. </summary>
    public partial class ApiManagementPortalSignInSettingsData : ResourceData
    {
        /// <summary> Initializes a new instance of ApiManagementPortalSignInSettingsData. </summary>
        public ApiManagementPortalSignInSettingsData()
        {
        }

        /// <summary> Initializes a new instance of ApiManagementPortalSignInSettingsData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="isEnabled"> Redirect Anonymous users to the Sign-In page. </param>
        internal ApiManagementPortalSignInSettingsData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? isEnabled) : base(id, name, resourceType, systemData)
        {
            IsEnabled = isEnabled;
        }

        /// <summary> Redirect Anonymous users to the Sign-In page. </summary>
        public bool? IsEnabled { get; set; }
    }
}
