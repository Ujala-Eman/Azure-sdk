// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary> A class representing the PortalDelegationSetting data model. </summary>
    public partial class PortalDelegationSettingData : ResourceData
    {
        /// <summary> Initializes a new instance of PortalDelegationSettingData. </summary>
        public PortalDelegationSettingData()
        {
        }

        /// <summary> Initializes a new instance of PortalDelegationSettingData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="uri"> A delegation Url. </param>
        /// <param name="validationKey"> A base64-encoded validation key to validate, that a request is coming from Azure API Management. </param>
        /// <param name="subscriptions"> Subscriptions delegation settings. </param>
        /// <param name="userRegistration"> User registration delegation settings. </param>
        internal PortalDelegationSettingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Uri uri, string validationKey, SubscriptionsDelegationSettingsProperties subscriptions, RegistrationDelegationSettingsProperties userRegistration) : base(id, name, resourceType, systemData)
        {
            Uri = uri;
            ValidationKey = validationKey;
            Subscriptions = subscriptions;
            UserRegistration = userRegistration;
        }

        /// <summary> A delegation Url. </summary>
        public Uri Uri { get; set; }
        /// <summary> A base64-encoded validation key to validate, that a request is coming from Azure API Management. </summary>
        public string ValidationKey { get; set; }
        /// <summary> Subscriptions delegation settings. </summary>
        internal SubscriptionsDelegationSettingsProperties Subscriptions { get; set; }
        /// <summary> Enable or disable delegation for subscriptions. </summary>
        public bool? SubscriptionsEnabled
        {
            get => Subscriptions is null ? default : Subscriptions.Enabled;
            set
            {
                if (Subscriptions is null)
                    Subscriptions = new SubscriptionsDelegationSettingsProperties();
                Subscriptions.Enabled = value;
            }
        }

        /// <summary> User registration delegation settings. </summary>
        internal RegistrationDelegationSettingsProperties UserRegistration { get; set; }
        /// <summary> Enable or disable delegation for user registration. </summary>
        public bool? UserRegistrationEnabled
        {
            get => UserRegistration is null ? default : UserRegistration.Enabled;
            set
            {
                if (UserRegistration is null)
                    UserRegistration = new RegistrationDelegationSettingsProperties();
                UserRegistration.Enabled = value;
            }
        }
    }
}
