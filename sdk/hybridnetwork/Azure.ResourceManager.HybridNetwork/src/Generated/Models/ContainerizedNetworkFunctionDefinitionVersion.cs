// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Containerized network function network function definition version properties. </summary>
    public partial class ContainerizedNetworkFunctionDefinitionVersion : NetworkFunctionDefinitionVersionPropertiesFormat
    {
        /// <summary> Initializes a new instance of ContainerizedNetworkFunctionDefinitionVersion. </summary>
        public ContainerizedNetworkFunctionDefinitionVersion()
        {
            NetworkFunctionType = NetworkFunctionType.ContainerizedNetworkFunction;
        }

        /// <summary> Initializes a new instance of ContainerizedNetworkFunctionDefinitionVersion. </summary>
        /// <param name="provisioningState"> The provisioning state of the network function definition version resource. </param>
        /// <param name="versionState"> The network function definition version state. </param>
        /// <param name="description"> The network function definition version description. </param>
        /// <param name="deployParameters"> The deployment parameters of the network function definition version. </param>
        /// <param name="secretDeployParameters"> The secret deployment parameters of the network function definition version which can include secrets like passwords, ssh keys etc. </param>
        /// <param name="networkFunctionType"> The network function type. </param>
        /// <param name="networkFunctionTemplate">
        /// Containerized network function template.
        /// Please note <see cref="ContainerizedNetworkFunctionTemplate"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureArcKubernetesNetworkFunctionTemplate"/>.
        /// </param>
        internal ContainerizedNetworkFunctionDefinitionVersion(ProvisioningState? provisioningState, VersionState? versionState, string description, string deployParameters, string secretDeployParameters, NetworkFunctionType networkFunctionType, ContainerizedNetworkFunctionTemplate networkFunctionTemplate) : base(provisioningState, versionState, description, deployParameters, secretDeployParameters, networkFunctionType)
        {
            NetworkFunctionTemplate = networkFunctionTemplate;
            NetworkFunctionType = networkFunctionType;
        }

        /// <summary>
        /// Containerized network function template.
        /// Please note <see cref="ContainerizedNetworkFunctionTemplate"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureArcKubernetesNetworkFunctionTemplate"/>.
        /// </summary>
        public ContainerizedNetworkFunctionTemplate NetworkFunctionTemplate { get; set; }
    }
}
