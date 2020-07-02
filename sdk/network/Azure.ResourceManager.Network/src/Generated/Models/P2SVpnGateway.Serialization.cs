// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class P2SVpnGateway : IUtf8JsonSerializable
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
            if (Optional.IsDefined(VirtualHub))
            {
                writer.WritePropertyName("virtualHub");
                writer.WriteObjectValue(VirtualHub);
            }
            if (Optional.IsDefined(P2SConnectionConfigurations))
            {
                writer.WritePropertyName("p2SConnectionConfigurations");
                writer.WriteStartArray();
                foreach (var item in P2SConnectionConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(VpnGatewayScaleUnit))
            {
                writer.WritePropertyName("vpnGatewayScaleUnit");
                writer.WriteNumberValue(VpnGatewayScaleUnit.Value);
            }
            if (Optional.IsDefined(VpnServerConfiguration))
            {
                writer.WritePropertyName("vpnServerConfiguration");
                writer.WriteObjectValue(VpnServerConfiguration);
            }
            if (Optional.IsDefined(VpnClientConnectionHealth))
            {
                writer.WritePropertyName("vpnClientConnectionHealth");
                writer.WriteObjectValue(VpnClientConnectionHealth);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static P2SVpnGateway DeserializeP2SVpnGateway(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<SubResource> virtualHub = default;
            Optional<IList<P2SConnectionConfiguration>> p2SConnectionConfigurations = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<int> vpnGatewayScaleUnit = default;
            Optional<SubResource> vpnServerConfiguration = default;
            Optional<VpnClientConnectionHealth> vpnClientConnectionHealth = default;
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
                        if (property0.NameEquals("virtualHub"))
                        {
                            virtualHub = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("p2SConnectionConfigurations"))
                        {
                            List<P2SConnectionConfiguration> array = new List<P2SConnectionConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(P2SConnectionConfiguration.DeserializeP2SConnectionConfiguration(item));
                                }
                            }
                            p2SConnectionConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vpnGatewayScaleUnit"))
                        {
                            vpnGatewayScaleUnit = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("vpnServerConfiguration"))
                        {
                            vpnServerConfiguration = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("vpnClientConnectionHealth"))
                        {
                            vpnClientConnectionHealth = VpnClientConnectionHealth.DeserializeVpnClientConnectionHealth(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new P2SVpnGateway(id.HasValue ? id.Value : null, name.HasValue ? name.Value : null, type.HasValue ? type.Value : null, location.HasValue ? location.Value : null, new ChangeTrackingDictionary<string, string>(tags), etag.HasValue ? etag.Value : null, virtualHub.HasValue ? virtualHub.Value : null, new ChangeTrackingList<P2SConnectionConfiguration>(p2SConnectionConfigurations), provisioningState.HasValue ? provisioningState.Value : (ProvisioningState?)null, vpnGatewayScaleUnit.HasValue ? vpnGatewayScaleUnit.Value : (int?)null, vpnServerConfiguration.HasValue ? vpnServerConfiguration.Value : null, vpnClientConnectionHealth.HasValue ? vpnClientConnectionHealth.Value : null);
        }
    }
}
