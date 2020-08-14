// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VirtualHub : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsCollectionDefined(Tags))
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
            if (Optional.IsDefined(VirtualWan))
            {
                writer.WritePropertyName("virtualWan");
                writer.WriteObjectValue(VirtualWan);
            }
            if (Optional.IsDefined(VpnGateway))
            {
                writer.WritePropertyName("vpnGateway");
                writer.WriteObjectValue(VpnGateway);
            }
            if (Optional.IsDefined(P2SVpnGateway))
            {
                writer.WritePropertyName("p2SVpnGateway");
                writer.WriteObjectValue(P2SVpnGateway);
            }
            if (Optional.IsDefined(ExpressRouteGateway))
            {
                writer.WritePropertyName("expressRouteGateway");
                writer.WriteObjectValue(ExpressRouteGateway);
            }
            if (Optional.IsDefined(AzureFirewall))
            {
                writer.WritePropertyName("azureFirewall");
                writer.WriteObjectValue(AzureFirewall);
            }
            if (Optional.IsDefined(SecurityPartnerProvider))
            {
                writer.WritePropertyName("securityPartnerProvider");
                writer.WriteObjectValue(SecurityPartnerProvider);
            }
            if (Optional.IsCollectionDefined(VirtualNetworkConnections))
            {
                writer.WritePropertyName("virtualNetworkConnections");
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AddressPrefix))
            {
                writer.WritePropertyName("addressPrefix");
                writer.WriteStringValue(AddressPrefix);
            }
            if (Optional.IsDefined(RouteTable))
            {
                writer.WritePropertyName("routeTable");
                writer.WriteObjectValue(RouteTable);
            }
            if (Optional.IsDefined(SecurityProviderName))
            {
                writer.WritePropertyName("securityProviderName");
                writer.WriteStringValue(SecurityProviderName);
            }
            if (Optional.IsCollectionDefined(VirtualHubRouteTableV2S))
            {
                writer.WritePropertyName("virtualHubRouteTableV2s");
                writer.WriteStartArray();
                foreach (var item in VirtualHubRouteTableV2S)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteStringValue(Sku);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualHub DeserializeVirtualHub(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<SubResource> virtualWan = default;
            Optional<SubResource> vpnGateway = default;
            Optional<SubResource> p2SVpnGateway = default;
            Optional<SubResource> expressRouteGateway = default;
            Optional<SubResource> azureFirewall = default;
            Optional<SubResource> securityPartnerProvider = default;
            Optional<IList<HubVirtualNetworkConnection>> virtualNetworkConnections = default;
            Optional<string> addressPrefix = default;
            Optional<VirtualHubRouteTable> routeTable = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> securityProviderName = default;
            Optional<IList<VirtualHubRouteTableV2>> virtualHubRouteTableV2s = default;
            Optional<string> sku = default;
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
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("virtualWan"))
                        {
                            virtualWan = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("vpnGateway"))
                        {
                            vpnGateway = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("p2SVpnGateway"))
                        {
                            p2SVpnGateway = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("expressRouteGateway"))
                        {
                            expressRouteGateway = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("azureFirewall"))
                        {
                            azureFirewall = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("securityPartnerProvider"))
                        {
                            securityPartnerProvider = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkConnections"))
                        {
                            List<HubVirtualNetworkConnection> array = new List<HubVirtualNetworkConnection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HubVirtualNetworkConnection.DeserializeHubVirtualNetworkConnection(item));
                            }
                            virtualNetworkConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("addressPrefix"))
                        {
                            addressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("routeTable"))
                        {
                            routeTable = VirtualHubRouteTable.DeserializeVirtualHubRouteTable(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("securityProviderName"))
                        {
                            securityProviderName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualHubRouteTableV2s"))
                        {
                            List<VirtualHubRouteTableV2> array = new List<VirtualHubRouteTableV2>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualHubRouteTableV2.DeserializeVirtualHubRouteTableV2(item));
                            }
                            virtualHubRouteTableV2s = array;
                            continue;
                        }
                        if (property0.NameEquals("sku"))
                        {
                            sku = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualHub(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), etag.Value, virtualWan.Value, vpnGateway.Value, p2SVpnGateway.Value, expressRouteGateway.Value, azureFirewall.Value, securityPartnerProvider.Value, Optional.ToList(virtualNetworkConnections), addressPrefix.Value, routeTable.Value, Optional.ToNullable(provisioningState), securityProviderName.Value, Optional.ToList(virtualHubRouteTableV2s), sku.Value);
        }
    }
}
