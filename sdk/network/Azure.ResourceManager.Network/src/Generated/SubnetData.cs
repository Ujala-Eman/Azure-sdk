// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the Subnet data model. </summary>
    public partial class SubnetData : NetworkWritableResourceData
    {
        /// <summary> Initializes a new instance of SubnetData. </summary>
        public SubnetData()
        {
            AddressPrefixes = new ChangeTrackingList<string>();
            ServiceEndpoints = new ChangeTrackingList<ServiceEndpointPropertiesFormat>();
            ServiceEndpointPolicies = new ChangeTrackingList<ServiceEndpointPolicyData>();
            PrivateEndpoints = new ChangeTrackingList<PrivateEndpointData>();
            IPConfigurations = new ChangeTrackingList<IPConfiguration>();
            IPConfigurationProfiles = new ChangeTrackingList<IPConfigurationProfile>();
            IPAllocations = new ChangeTrackingList<WritableSubResource>();
            ResourceNavigationLinks = new ChangeTrackingList<ResourceNavigationLink>();
            ServiceAssociationLinks = new ChangeTrackingList<ServiceAssociationLink>();
            Delegations = new ChangeTrackingList<ServiceDelegation>();
            ApplicationGatewayIPConfigurations = new ChangeTrackingList<ApplicationGatewayIPConfiguration>();
        }

        /// <summary> Initializes a new instance of SubnetData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="eTag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="addressPrefix"> The address prefix for the subnet. </param>
        /// <param name="addressPrefixes"> List of address prefixes for the subnet. </param>
        /// <param name="networkSecurityGroup"> The reference to the NetworkSecurityGroup resource. </param>
        /// <param name="routeTable"> The reference to the RouteTable resource. </param>
        /// <param name="natGateway"> Nat gateway associated with this subnet. </param>
        /// <param name="serviceEndpoints"> An array of service endpoints. </param>
        /// <param name="serviceEndpointPolicies"> An array of service endpoint policies. </param>
        /// <param name="privateEndpoints"> An array of references to private endpoints. </param>
        /// <param name="ipConfigurations"> An array of references to the network interface IP configurations using subnet. </param>
        /// <param name="ipConfigurationProfiles"> Array of IP configuration profiles which reference this subnet. </param>
        /// <param name="ipAllocations"> Array of IpAllocation which reference this subnet. </param>
        /// <param name="resourceNavigationLinks"> An array of references to the external resources using subnet. </param>
        /// <param name="serviceAssociationLinks"> An array of references to services injecting into this subnet. </param>
        /// <param name="delegations"> An array of references to the delegations on the subnet. </param>
        /// <param name="purpose"> A read-only string identifying the intention of use for this subnet based on delegations and other user-defined properties. </param>
        /// <param name="provisioningState"> The provisioning state of the subnet resource. </param>
        /// <param name="virtualNetworkPrivateEndpointNetworkPolicy"> Enable or Disable apply network policies on private end point in the subnet. </param>
        /// <param name="virtualNetworkPrivateLinkServiceNetworkPolicy"> Enable or Disable apply network policies on private link service in the subnet. </param>
        /// <param name="applicationGatewayIPConfigurations"> Application gateway IP configurations of virtual network resource. </param>
        internal SubnetData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? eTag, string addressPrefix, IList<string> addressPrefixes, NetworkSecurityGroupData networkSecurityGroup, RouteTableData routeTable, WritableSubResource natGateway, IList<ServiceEndpointPropertiesFormat> serviceEndpoints, IList<ServiceEndpointPolicyData> serviceEndpointPolicies, IReadOnlyList<PrivateEndpointData> privateEndpoints, IReadOnlyList<IPConfiguration> ipConfigurations, IReadOnlyList<IPConfigurationProfile> ipConfigurationProfiles, IList<WritableSubResource> ipAllocations, IReadOnlyList<ResourceNavigationLink> resourceNavigationLinks, IReadOnlyList<ServiceAssociationLink> serviceAssociationLinks, IList<ServiceDelegation> delegations, string purpose, NetworkProvisioningState? provisioningState, VirtualNetworkPrivateEndpointNetworkPolicy? virtualNetworkPrivateEndpointNetworkPolicy, VirtualNetworkPrivateLinkServiceNetworkPolicy? virtualNetworkPrivateLinkServiceNetworkPolicy, IList<ApplicationGatewayIPConfiguration> applicationGatewayIPConfigurations) : base(id, name, resourceType)
        {
            ETag = eTag;
            AddressPrefix = addressPrefix;
            AddressPrefixes = addressPrefixes;
            NetworkSecurityGroup = networkSecurityGroup;
            RouteTable = routeTable;
            NatGateway = natGateway;
            ServiceEndpoints = serviceEndpoints;
            ServiceEndpointPolicies = serviceEndpointPolicies;
            PrivateEndpoints = privateEndpoints;
            IPConfigurations = ipConfigurations;
            IPConfigurationProfiles = ipConfigurationProfiles;
            IPAllocations = ipAllocations;
            ResourceNavigationLinks = resourceNavigationLinks;
            ServiceAssociationLinks = serviceAssociationLinks;
            Delegations = delegations;
            Purpose = purpose;
            ProvisioningState = provisioningState;
            VirtualNetworkPrivateEndpointNetworkPolicy = virtualNetworkPrivateEndpointNetworkPolicy;
            VirtualNetworkPrivateLinkServiceNetworkPolicy = virtualNetworkPrivateLinkServiceNetworkPolicy;
            ApplicationGatewayIPConfigurations = applicationGatewayIPConfigurations;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The address prefix for the subnet. </summary>
        public string AddressPrefix { get; set; }
        /// <summary> List of address prefixes for the subnet. </summary>
        public IList<string> AddressPrefixes { get; }
        /// <summary> The reference to the NetworkSecurityGroup resource. </summary>
        public NetworkSecurityGroupData NetworkSecurityGroup { get; set; }
        /// <summary> The reference to the RouteTable resource. </summary>
        public RouteTableData RouteTable { get; set; }
        /// <summary> Nat gateway associated with this subnet. </summary>
        internal WritableSubResource NatGateway { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier NatGatewayId
        {
            get => NatGateway is null ? default : NatGateway.Id;
            set
            {
                if (NatGateway is null)
                    NatGateway = new WritableSubResource();
                NatGateway.Id = value;
            }
        }

        /// <summary> An array of service endpoints. </summary>
        public IList<ServiceEndpointPropertiesFormat> ServiceEndpoints { get; }
        /// <summary> An array of service endpoint policies. </summary>
        public IList<ServiceEndpointPolicyData> ServiceEndpointPolicies { get; }
        /// <summary> An array of references to private endpoints. </summary>
        public IReadOnlyList<PrivateEndpointData> PrivateEndpoints { get; }
        /// <summary> An array of references to the network interface IP configurations using subnet. </summary>
        public IReadOnlyList<IPConfiguration> IPConfigurations { get; }
        /// <summary> Array of IP configuration profiles which reference this subnet. </summary>
        public IReadOnlyList<IPConfigurationProfile> IPConfigurationProfiles { get; }
        /// <summary> Array of IpAllocation which reference this subnet. </summary>
        public IList<WritableSubResource> IPAllocations { get; }
        /// <summary> An array of references to the external resources using subnet. </summary>
        public IReadOnlyList<ResourceNavigationLink> ResourceNavigationLinks { get; }
        /// <summary> An array of references to services injecting into this subnet. </summary>
        public IReadOnlyList<ServiceAssociationLink> ServiceAssociationLinks { get; }
        /// <summary> An array of references to the delegations on the subnet. </summary>
        public IList<ServiceDelegation> Delegations { get; }
        /// <summary> A read-only string identifying the intention of use for this subnet based on delegations and other user-defined properties. </summary>
        public string Purpose { get; }
        /// <summary> The provisioning state of the subnet resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> Enable or Disable apply network policies on private end point in the subnet. </summary>
        public VirtualNetworkPrivateEndpointNetworkPolicy? VirtualNetworkPrivateEndpointNetworkPolicy { get; set; }
        /// <summary> Enable or Disable apply network policies on private link service in the subnet. </summary>
        public VirtualNetworkPrivateLinkServiceNetworkPolicy? VirtualNetworkPrivateLinkServiceNetworkPolicy { get; set; }
        /// <summary> Application gateway IP configurations of virtual network resource. </summary>
        public IList<ApplicationGatewayIPConfiguration> ApplicationGatewayIPConfigurations { get; }
    }
}
