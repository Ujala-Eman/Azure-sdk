// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    public partial class VpnGatewayNatRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(TypePropertiesType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(TypePropertiesType.Value.ToString());
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode");
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(InternalMappings))
            {
                writer.WritePropertyName("internalMappings");
                writer.WriteStartArray();
                foreach (var item in InternalMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExternalMappings))
            {
                writer.WritePropertyName("externalMappings");
                writer.WriteStartArray();
                foreach (var item in ExternalMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IpConfigurationId))
            {
                writer.WritePropertyName("ipConfigurationId");
                writer.WriteStringValue(IpConfigurationId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VpnGatewayNatRuleData DeserializeVpnGatewayNatRuleData(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            ResourceIdentifier id = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<VpnNatRuleType> type0 = default;
            Optional<VpnNatRuleMode> mode = default;
            Optional<IList<VpnNatRuleMapping>> internalMappings = default;
            Optional<IList<VpnNatRuleMapping>> externalMappings = default;
            Optional<string> ipConfigurationId = default;
            Optional<IReadOnlyList<SubResource>> egressVpnSiteLinkConnections = default;
            Optional<IReadOnlyList<SubResource>> ingressVpnSiteLinkConnections = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("type"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            type0 = new VpnNatRuleType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("mode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            mode = new VpnNatRuleMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("internalMappings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VpnNatRuleMapping> array = new List<VpnNatRuleMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnNatRuleMapping.DeserializeVpnNatRuleMapping(item));
                            }
                            internalMappings = array;
                            continue;
                        }
                        if (property0.NameEquals("externalMappings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VpnNatRuleMapping> array = new List<VpnNatRuleMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnNatRuleMapping.DeserializeVpnNatRuleMapping(item));
                            }
                            externalMappings = array;
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurationId"))
                        {
                            ipConfigurationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("egressVpnSiteLinkConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubResource.DeserializeSubResource(item));
                            }
                            egressVpnSiteLinkConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("ingressVpnSiteLinkConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubResource.DeserializeSubResource(item));
                            }
                            ingressVpnSiteLinkConnections = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VpnGatewayNatRuleData(id, name.Value, etag.Value, type.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(type0), Optional.ToNullable(mode), Optional.ToList(internalMappings), Optional.ToList(externalMappings), ipConfigurationId.Value, Optional.ToList(egressVpnSiteLinkConnections), Optional.ToList(ingressVpnSiteLinkConnections));
        }
    }
}
