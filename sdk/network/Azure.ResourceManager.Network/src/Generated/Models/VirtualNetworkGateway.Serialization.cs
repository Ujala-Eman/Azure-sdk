// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VirtualNetworkGateway : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(IpConfigurations))
            {
                writer.WritePropertyName("ipConfigurations");
                writer.WriteStartArray();
                foreach (var item in IpConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(GatewayType))
            {
                writer.WritePropertyName("gatewayType");
                writer.WriteStringValue(GatewayType.Value.ToString());
            }
            if (Optional.IsDefined(VpnType))
            {
                writer.WritePropertyName("vpnType");
                writer.WriteStringValue(VpnType.Value.ToString());
            }
            if (Optional.IsDefined(VpnGatewayGeneration))
            {
                writer.WritePropertyName("vpnGatewayGeneration");
                writer.WriteStringValue(VpnGatewayGeneration.Value.ToString());
            }
            if (Optional.IsDefined(EnableBgp))
            {
                writer.WritePropertyName("enableBgp");
                writer.WriteBooleanValue(EnableBgp.Value);
            }
            if (Optional.IsDefined(EnablePrivateIpAddress))
            {
                writer.WritePropertyName("enablePrivateIpAddress");
                writer.WriteBooleanValue(EnablePrivateIpAddress.Value);
            }
            if (Optional.IsDefined(Active))
            {
                writer.WritePropertyName("activeActive");
                writer.WriteBooleanValue(Active.Value);
            }
            if (Optional.IsDefined(GatewayDefaultSite))
            {
                writer.WritePropertyName("gatewayDefaultSite");
                writer.WriteObjectValue(GatewayDefaultSite);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(VpnClientConfiguration))
            {
                writer.WritePropertyName("vpnClientConfiguration");
                writer.WriteObjectValue(VpnClientConfiguration);
            }
            if (Optional.IsDefined(BgpSettings))
            {
                writer.WritePropertyName("bgpSettings");
                writer.WriteObjectValue(BgpSettings);
            }
            if (Optional.IsDefined(CustomRoutes))
            {
                writer.WritePropertyName("customRoutes");
                writer.WriteObjectValue(CustomRoutes);
            }
            if (Optional.IsDefined(ResourceGuid))
            {
                writer.WritePropertyName("resourceGuid");
                writer.WriteStringValue(ResourceGuid);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(EnableDnsForwarding))
            {
                writer.WritePropertyName("enableDnsForwarding");
                writer.WriteBooleanValue(EnableDnsForwarding.Value);
            }
            if (Optional.IsDefined(InboundDnsForwardingEndpoint))
            {
                writer.WritePropertyName("inboundDnsForwardingEndpoint");
                writer.WriteStringValue(InboundDnsForwardingEndpoint);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualNetworkGateway DeserializeVirtualNetworkGateway(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<IList<VirtualNetworkGatewayIPConfiguration>> ipConfigurations = default;
            Optional<VirtualNetworkGatewayType> gatewayType = default;
            Optional<VpnType> vpnType = default;
            Optional<VpnGatewayGeneration> vpnGatewayGeneration = default;
            Optional<bool> enableBgp = default;
            Optional<bool> enablePrivateIpAddress = default;
            Optional<bool> activeActive = default;
            Optional<SubResource> gatewayDefaultSite = default;
            Optional<VirtualNetworkGatewaySku> sku = default;
            Optional<VpnClientConfiguration> vpnClientConfiguration = default;
            Optional<BgpSettings> bgpSettings = default;
            Optional<AddressSpace> customRoutes = default;
            Optional<string> resourceGuid = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<bool> enableDnsForwarding = default;
            Optional<string> inboundDnsForwardingEndpoint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("ipConfigurations"))
                        {
                            List<VirtualNetworkGatewayIPConfiguration> array = new List<VirtualNetworkGatewayIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(VirtualNetworkGatewayIPConfiguration.DeserializeVirtualNetworkGatewayIPConfiguration(item));
                                }
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("gatewayType"))
                        {
                            gatewayType = new VirtualNetworkGatewayType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vpnType"))
                        {
                            vpnType = new VpnType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vpnGatewayGeneration"))
                        {
                            vpnGatewayGeneration = new VpnGatewayGeneration(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enableBgp"))
                        {
                            enableBgp = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enablePrivateIpAddress"))
                        {
                            enablePrivateIpAddress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("activeActive"))
                        {
                            activeActive = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("gatewayDefaultSite"))
                        {
                            gatewayDefaultSite = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sku"))
                        {
                            sku = VirtualNetworkGatewaySku.DeserializeVirtualNetworkGatewaySku(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("vpnClientConfiguration"))
                        {
                            vpnClientConfiguration = VpnClientConfiguration.DeserializeVpnClientConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("bgpSettings"))
                        {
                            bgpSettings = BgpSettings.DeserializeBgpSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customRoutes"))
                        {
                            customRoutes = AddressSpace.DeserializeAddressSpace(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"))
                        {
                            resourceGuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enableDnsForwarding"))
                        {
                            enableDnsForwarding = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("inboundDnsForwardingEndpoint"))
                        {
                            inboundDnsForwardingEndpoint = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualNetworkGateway(id.HasValue ? id.Value : null, name.HasValue ? name.Value : null, type.HasValue ? type.Value : null, location.HasValue ? location.Value : null, new ChangeTrackingDictionary<string, string>(tags), etag.HasValue ? etag.Value : null, new ChangeTrackingList<VirtualNetworkGatewayIPConfiguration>(ipConfigurations), gatewayType.HasValue ? gatewayType.Value : (VirtualNetworkGatewayType?)null, vpnType.HasValue ? vpnType.Value : (VpnType?)null, vpnGatewayGeneration.HasValue ? vpnGatewayGeneration.Value : (VpnGatewayGeneration?)null, enableBgp.HasValue ? enableBgp.Value : (bool?)null, enablePrivateIpAddress.HasValue ? enablePrivateIpAddress.Value : (bool?)null, activeActive.HasValue ? activeActive.Value : (bool?)null, gatewayDefaultSite.HasValue ? gatewayDefaultSite.Value : null, sku.HasValue ? sku.Value : null, vpnClientConfiguration.HasValue ? vpnClientConfiguration.Value : null, bgpSettings.HasValue ? bgpSettings.Value : null, customRoutes.HasValue ? customRoutes.Value : null, resourceGuid.HasValue ? resourceGuid.Value : null, provisioningState.HasValue ? provisioningState.Value : (ProvisioningState?)null, enableDnsForwarding.HasValue ? enableDnsForwarding.Value : (bool?)null, inboundDnsForwardingEndpoint.HasValue ? inboundDnsForwardingEndpoint.Value : null);
        }
    }
}
