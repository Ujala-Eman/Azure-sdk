// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the VirtualNetworkGateway data model.
    /// A common class for general resource information.
    /// </summary>
    public partial class VirtualNetworkGatewayData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="VirtualNetworkGatewayData"/>. </summary>
        public VirtualNetworkGatewayData()
        {
            IPConfigurations = new ChangeTrackingList<VirtualNetworkGatewayIPConfiguration>();
            VirtualNetworkGatewayPolicyGroups = new ChangeTrackingList<VirtualNetworkGatewayPolicyGroup>();
            NatRules = new ChangeTrackingList<VirtualNetworkGatewayNatRuleData>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkGatewayData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="extendedLocation"> The extended location of type local virtual network gateway. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="autoScaleConfiguration"> Autoscale configuration for virutal network gateway. </param>
        /// <param name="ipConfigurations"> IP configurations for virtual network gateway. </param>
        /// <param name="gatewayType"> The type of this virtual network gateway. </param>
        /// <param name="vpnType"> The type of this virtual network gateway. </param>
        /// <param name="vpnGatewayGeneration"> The generation for this VirtualNetworkGateway. Must be None if gatewayType is not VPN. </param>
        /// <param name="enableBgp"> Whether BGP is enabled for this virtual network gateway or not. </param>
        /// <param name="enablePrivateIPAddress"> Whether private IP needs to be enabled on this gateway for connections or not. </param>
        /// <param name="active"> ActiveActive flag. </param>
        /// <param name="disableIPSecReplayProtection"> disableIPSecReplayProtection flag. </param>
        /// <param name="gatewayDefaultSite"> The reference to the LocalNetworkGateway resource which represents local network site having default routes. Assign Null value in case of removing existing default site setting. </param>
        /// <param name="sku"> The reference to the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network gateway. </param>
        /// <param name="vpnClientConfiguration"> The reference to the VpnClientConfiguration resource which represents the P2S VpnClient configurations. </param>
        /// <param name="virtualNetworkGatewayPolicyGroups"> The reference to the VirtualNetworkGatewayPolicyGroup resource which represents the available VirtualNetworkGatewayPolicyGroup for the gateway. </param>
        /// <param name="bgpSettings"> Virtual network gateway's BGP speaker settings. </param>
        /// <param name="customRoutes"> The reference to the address space resource which represents the custom routes address space specified by the customer for virtual network gateway and VpnClient. </param>
        /// <param name="resourceGuid"> The resource GUID property of the virtual network gateway resource. </param>
        /// <param name="provisioningState"> The provisioning state of the virtual network gateway resource. </param>
        /// <param name="enableDnsForwarding"> Whether dns forwarding is enabled or not. </param>
        /// <param name="inboundDnsForwardingEndpoint"> The IP address allocated by the gateway to which dns requests can be sent. </param>
        /// <param name="vNetExtendedLocationResourceId"> Customer vnet resource id. VirtualNetworkGateway of type local gateway is associated with the customer vnet. </param>
        /// <param name="natRules"> NatRules for virtual network gateway. </param>
        /// <param name="enableBgpRouteTranslationForNat"> EnableBgpRouteTranslationForNat flag. </param>
        /// <param name="allowVirtualWanTraffic"> Configures this gateway to accept traffic from remote Virtual WAN networks. </param>
        /// <param name="allowRemoteVnetTraffic"> Configure this gateway to accept traffic from other Azure Virtual Networks. This configuration does not support connectivity to Azure Virtual WAN. </param>
        /// <param name="adminState"> Property to indicate if the Express Route Gateway serves traffic when there are multiple Express Route Gateways in the vnet. </param>
        internal VirtualNetworkGatewayData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, ExtendedLocation extendedLocation, ETag? etag, VirtualNetworkGatewayAutoScaleConfiguration autoScaleConfiguration, IList<VirtualNetworkGatewayIPConfiguration> ipConfigurations, VirtualNetworkGatewayType? gatewayType, VpnType? vpnType, VpnGatewayGeneration? vpnGatewayGeneration, bool? enableBgp, bool? enablePrivateIPAddress, bool? active, bool? disableIPSecReplayProtection, WritableSubResource gatewayDefaultSite, VirtualNetworkGatewaySku sku, VpnClientConfiguration vpnClientConfiguration, IList<VirtualNetworkGatewayPolicyGroup> virtualNetworkGatewayPolicyGroups, BgpSettings bgpSettings, AddressSpace customRoutes, Guid? resourceGuid, NetworkProvisioningState? provisioningState, bool? enableDnsForwarding, string inboundDnsForwardingEndpoint, ResourceIdentifier vNetExtendedLocationResourceId, IList<VirtualNetworkGatewayNatRuleData> natRules, bool? enableBgpRouteTranslationForNat, bool? allowVirtualWanTraffic, bool? allowRemoteVnetTraffic, ExpressRouteGatewayAdminState? adminState) : base(id, name, resourceType, location, tags, serializedAdditionalRawData)
        {
            ExtendedLocation = extendedLocation;
            ETag = etag;
            AutoScaleConfiguration = autoScaleConfiguration;
            IPConfigurations = ipConfigurations;
            GatewayType = gatewayType;
            VpnType = vpnType;
            VpnGatewayGeneration = vpnGatewayGeneration;
            EnableBgp = enableBgp;
            EnablePrivateIPAddress = enablePrivateIPAddress;
            Active = active;
            DisableIPSecReplayProtection = disableIPSecReplayProtection;
            GatewayDefaultSite = gatewayDefaultSite;
            Sku = sku;
            VpnClientConfiguration = vpnClientConfiguration;
            VirtualNetworkGatewayPolicyGroups = virtualNetworkGatewayPolicyGroups;
            BgpSettings = bgpSettings;
            CustomRoutes = customRoutes;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            EnableDnsForwarding = enableDnsForwarding;
            InboundDnsForwardingEndpoint = inboundDnsForwardingEndpoint;
            VNetExtendedLocationResourceId = vNetExtendedLocationResourceId;
            NatRules = natRules;
            EnableBgpRouteTranslationForNat = enableBgpRouteTranslationForNat;
            AllowVirtualWanTraffic = allowVirtualWanTraffic;
            AllowRemoteVnetTraffic = allowRemoteVnetTraffic;
            AdminState = adminState;
        }

        /// <summary> The extended location of type local virtual network gateway. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Autoscale configuration for virutal network gateway. </summary>
        internal VirtualNetworkGatewayAutoScaleConfiguration AutoScaleConfiguration { get; set; }
        /// <summary> The bounds of the autoscale configuration. </summary>
        public VirtualNetworkGatewayAutoScaleBounds AutoScaleBounds
        {
            get => AutoScaleConfiguration is null ? default : AutoScaleConfiguration.Bounds;
            set
            {
                if (AutoScaleConfiguration is null)
                    AutoScaleConfiguration = new VirtualNetworkGatewayAutoScaleConfiguration();
                AutoScaleConfiguration.Bounds = value;
            }
        }

        /// <summary> IP configurations for virtual network gateway. </summary>
        public IList<VirtualNetworkGatewayIPConfiguration> IPConfigurations { get; }
        /// <summary> The type of this virtual network gateway. </summary>
        public VirtualNetworkGatewayType? GatewayType { get; set; }
        /// <summary> The type of this virtual network gateway. </summary>
        public VpnType? VpnType { get; set; }
        /// <summary> The generation for this VirtualNetworkGateway. Must be None if gatewayType is not VPN. </summary>
        public VpnGatewayGeneration? VpnGatewayGeneration { get; set; }
        /// <summary> Whether BGP is enabled for this virtual network gateway or not. </summary>
        public bool? EnableBgp { get; set; }
        /// <summary> Whether private IP needs to be enabled on this gateway for connections or not. </summary>
        public bool? EnablePrivateIPAddress { get; set; }
        /// <summary> ActiveActive flag. </summary>
        public bool? Active { get; set; }
        /// <summary> disableIPSecReplayProtection flag. </summary>
        public bool? DisableIPSecReplayProtection { get; set; }
        /// <summary> The reference to the LocalNetworkGateway resource which represents local network site having default routes. Assign Null value in case of removing existing default site setting. </summary>
        internal WritableSubResource GatewayDefaultSite { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier GatewayDefaultSiteId
        {
            get => GatewayDefaultSite is null ? default : GatewayDefaultSite.Id;
            set
            {
                if (GatewayDefaultSite is null)
                    GatewayDefaultSite = new WritableSubResource();
                GatewayDefaultSite.Id = value;
            }
        }

        /// <summary> The reference to the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network gateway. </summary>
        public VirtualNetworkGatewaySku Sku { get; set; }
        /// <summary> The reference to the VpnClientConfiguration resource which represents the P2S VpnClient configurations. </summary>
        public VpnClientConfiguration VpnClientConfiguration { get; set; }
        /// <summary> The reference to the VirtualNetworkGatewayPolicyGroup resource which represents the available VirtualNetworkGatewayPolicyGroup for the gateway. </summary>
        public IList<VirtualNetworkGatewayPolicyGroup> VirtualNetworkGatewayPolicyGroups { get; }
        /// <summary> Virtual network gateway's BGP speaker settings. </summary>
        public BgpSettings BgpSettings { get; set; }
        /// <summary> The reference to the address space resource which represents the custom routes address space specified by the customer for virtual network gateway and VpnClient. </summary>
        internal AddressSpace CustomRoutes { get; set; }
        /// <summary> A list of address blocks reserved for this virtual network in CIDR notation. </summary>
        public IList<string> CustomRoutesAddressPrefixes
        {
            get
            {
                if (CustomRoutes is null)
                    CustomRoutes = new AddressSpace();
                return CustomRoutes.AddressPrefixes;
            }
        }

        /// <summary> The resource GUID property of the virtual network gateway resource. </summary>
        public Guid? ResourceGuid { get; }
        /// <summary> The provisioning state of the virtual network gateway resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> Whether dns forwarding is enabled or not. </summary>
        public bool? EnableDnsForwarding { get; set; }
        /// <summary> The IP address allocated by the gateway to which dns requests can be sent. </summary>
        public string InboundDnsForwardingEndpoint { get; }
        /// <summary> Customer vnet resource id. VirtualNetworkGateway of type local gateway is associated with the customer vnet. </summary>
        public ResourceIdentifier VNetExtendedLocationResourceId { get; set; }
        /// <summary> NatRules for virtual network gateway. </summary>
        public IList<VirtualNetworkGatewayNatRuleData> NatRules { get; }
        /// <summary> EnableBgpRouteTranslationForNat flag. </summary>
        public bool? EnableBgpRouteTranslationForNat { get; set; }
        /// <summary> Configures this gateway to accept traffic from remote Virtual WAN networks. </summary>
        public bool? AllowVirtualWanTraffic { get; set; }
        /// <summary> Configure this gateway to accept traffic from other Azure Virtual Networks. This configuration does not support connectivity to Azure Virtual WAN. </summary>
        public bool? AllowRemoteVnetTraffic { get; set; }
        /// <summary> Property to indicate if the Express Route Gateway serves traffic when there are multiple Express Route Gateways in the vnet. </summary>
        public ExpressRouteGatewayAdminState? AdminState { get; set; }
    }
}
