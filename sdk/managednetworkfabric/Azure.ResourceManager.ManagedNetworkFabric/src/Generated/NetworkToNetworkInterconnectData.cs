// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the NetworkToNetworkInterconnect data model.
    /// The Network To Network Interconnect resource definition.
    /// </summary>
    public partial class NetworkToNetworkInterconnectData : ResourceData
    {
        /// <summary> Initializes a new instance of NetworkToNetworkInterconnectData. </summary>
        /// <param name="useOptionB"> Based on this option layer3 parameters are mandatory. Example: True/False. </param>
        public NetworkToNetworkInterconnectData(NetworkFabricBooleanValue useOptionB)
        {
            UseOptionB = useOptionB;
        }

        /// <summary> Initializes a new instance of NetworkToNetworkInterconnectData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="nniType"> Type of NNI used. Example: CE | NPB. </param>
        /// <param name="isManagementType"> Configuration to use NNI for Infrastructure Management. Example: True/False. </param>
        /// <param name="useOptionB"> Based on this option layer3 parameters are mandatory. Example: True/False. </param>
        /// <param name="layer2Configuration"> Common properties for Layer2 Configuration. </param>
        /// <param name="optionBLayer3Configuration"> Common properties for Layer3Configuration. </param>
        /// <param name="npbStaticRouteConfiguration"> NPB Static Route Configuration properties. </param>
        /// <param name="importRoutePolicy"> Import Route Policy configuration. </param>
        /// <param name="exportRoutePolicy"> Export Route Policy configuration. </param>
        /// <param name="egressAclId"> Egress Acl. ARM resource ID of Access Control Lists. </param>
        /// <param name="ingressAclId"> Ingress Acl. ARM resource ID of Access Control Lists. </param>
        /// <param name="configurationState"> Configuration state of the resource. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="administrativeState"> Administrative state of the resource. </param>
        internal NetworkToNetworkInterconnectData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, NniType? nniType, IsManagementType? isManagementType, NetworkFabricBooleanValue useOptionB, Layer2Configuration layer2Configuration, NetworkToNetworkInterconnectOptionBLayer3Configuration optionBLayer3Configuration, NpbStaticRouteConfiguration npbStaticRouteConfiguration, ImportRoutePolicyInformation importRoutePolicy, ExportRoutePolicyInformation exportRoutePolicy, ResourceIdentifier egressAclId, ResourceIdentifier ingressAclId, NetworkFabricConfigurationState? configurationState, NetworkFabricProvisioningState? provisioningState, NetworkFabricAdministrativeState? administrativeState) : base(id, name, resourceType, systemData)
        {
            NniType = nniType;
            IsManagementType = isManagementType;
            UseOptionB = useOptionB;
            Layer2Configuration = layer2Configuration;
            OptionBLayer3Configuration = optionBLayer3Configuration;
            NpbStaticRouteConfiguration = npbStaticRouteConfiguration;
            ImportRoutePolicy = importRoutePolicy;
            ExportRoutePolicy = exportRoutePolicy;
            EgressAclId = egressAclId;
            IngressAclId = ingressAclId;
            ConfigurationState = configurationState;
            ProvisioningState = provisioningState;
            AdministrativeState = administrativeState;
        }

        /// <summary> Type of NNI used. Example: CE | NPB. </summary>
        public NniType? NniType { get; set; }
        /// <summary> Configuration to use NNI for Infrastructure Management. Example: True/False. </summary>
        public IsManagementType? IsManagementType { get; set; }
        /// <summary> Based on this option layer3 parameters are mandatory. Example: True/False. </summary>
        public NetworkFabricBooleanValue UseOptionB { get; set; }
        /// <summary> Common properties for Layer2 Configuration. </summary>
        public Layer2Configuration Layer2Configuration { get; set; }
        /// <summary> Common properties for Layer3Configuration. </summary>
        public NetworkToNetworkInterconnectOptionBLayer3Configuration OptionBLayer3Configuration { get; set; }
        /// <summary> NPB Static Route Configuration properties. </summary>
        public NpbStaticRouteConfiguration NpbStaticRouteConfiguration { get; set; }
        /// <summary> Import Route Policy configuration. </summary>
        public ImportRoutePolicyInformation ImportRoutePolicy { get; set; }
        /// <summary> Export Route Policy configuration. </summary>
        public ExportRoutePolicyInformation ExportRoutePolicy { get; set; }
        /// <summary> Egress Acl. ARM resource ID of Access Control Lists. </summary>
        public ResourceIdentifier EgressAclId { get; set; }
        /// <summary> Ingress Acl. ARM resource ID of Access Control Lists. </summary>
        public ResourceIdentifier IngressAclId { get; set; }
        /// <summary> Configuration state of the resource. </summary>
        public NetworkFabricConfigurationState? ConfigurationState { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public NetworkFabricProvisioningState? ProvisioningState { get; }
        /// <summary> Administrative state of the resource. </summary>
        public NetworkFabricAdministrativeState? AdministrativeState { get; }
    }
}
