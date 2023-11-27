// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HealthBot.Models
{
    /// <summary> The properties of a Azure Health Bot. The Health Bot Service is a cloud platform that empowers developers in Healthcare organizations to build and deploy their compliant, AI-powered virtual health assistants and health bots, that help them improve processes and reduce costs. </summary>
    public partial class HealthBotProperties
    {
        /// <summary> Initializes a new instance of <see cref="HealthBotProperties"/>. </summary>
        public HealthBotProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HealthBotProperties"/>. </summary>
        /// <param name="provisioningState"> The provisioning state of the Azure Health Bot resource. </param>
        /// <param name="botManagementPortalLink"> The link. </param>
        /// <param name="keyVaultProperties"> KeyVault properties for the resource encryption. </param>
        internal HealthBotProperties(string provisioningState, Uri botManagementPortalLink, HealthBotKeyVaultProperties keyVaultProperties)
        {
            ProvisioningState = provisioningState;
            BotManagementPortalLink = botManagementPortalLink;
            KeyVaultProperties = keyVaultProperties;
        }

        /// <summary> The provisioning state of the Azure Health Bot resource. </summary>
        public string ProvisioningState { get; }
        /// <summary> The link. </summary>
        public Uri BotManagementPortalLink { get; }
        /// <summary> KeyVault properties for the resource encryption. </summary>
        public HealthBotKeyVaultProperties KeyVaultProperties { get; set; }
    }
}
