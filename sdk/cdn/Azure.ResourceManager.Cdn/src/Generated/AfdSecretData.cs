// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing the AfdSecret data model. </summary>
    public partial class AfdSecretData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="AfdSecretData"/>. </summary>
        public AfdSecretData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AfdSecretData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning status. </param>
        /// <param name="deploymentStatus"></param>
        /// <param name="profileName"> The name of the profile which holds the secret. </param>
        /// <param name="properties">
        /// object which contains secret parameters
        /// Please note <see cref="SecretProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureFirstPartyManagedCertificateProperties"/>, <see cref="CustomerCertificateProperties"/>, <see cref="ManagedCertificateProperties"/> and <see cref="UriSigningKeyProperties"/>.
        /// </param>
        internal AfdSecretData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AfdProvisioningState? provisioningState, AfdDeploymentStatus? deploymentStatus, string profileName, SecretProperties properties) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            DeploymentStatus = deploymentStatus;
            ProfileName = profileName;
            Properties = properties;
        }

        /// <summary> Provisioning status. </summary>
        public AfdProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the deployment status. </summary>
        public AfdDeploymentStatus? DeploymentStatus { get; }
        /// <summary> The name of the profile which holds the secret. </summary>
        public string ProfileName { get; }
        /// <summary>
        /// object which contains secret parameters
        /// Please note <see cref="SecretProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureFirstPartyManagedCertificateProperties"/>, <see cref="CustomerCertificateProperties"/>, <see cref="ManagedCertificateProperties"/> and <see cref="UriSigningKeyProperties"/>.
        /// </summary>
        public SecretProperties Properties { get; set; }
    }
}
