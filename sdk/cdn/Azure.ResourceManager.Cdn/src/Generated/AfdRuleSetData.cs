// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing the AfdRuleSet data model. </summary>
    public partial class AfdRuleSetData : ResourceData
    {
        /// <summary> Initializes a new instance of AfdRuleSetData. </summary>
        public AfdRuleSetData()
        {
        }

        /// <summary> Initializes a new instance of AfdRuleSetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning status. </param>
        /// <param name="deploymentStatus"></param>
        /// <param name="profileName"> The name of the profile which holds the rule set. </param>
        internal AfdRuleSetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AfdProvisioningState? provisioningState, AfdDeploymentStatus? deploymentStatus, string profileName) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            DeploymentStatus = deploymentStatus;
            ProfileName = profileName;
        }

        /// <summary> Provisioning status. </summary>
        public AfdProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the deployment status. </summary>
        public AfdDeploymentStatus? DeploymentStatus { get; }
        /// <summary> The name of the profile which holds the rule set. </summary>
        public string ProfileName { get; }
    }
}
