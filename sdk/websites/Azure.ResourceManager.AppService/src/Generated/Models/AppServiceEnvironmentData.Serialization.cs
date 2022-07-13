// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class AppServiceEnvironmentData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
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
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualNetwork))
            {
                writer.WritePropertyName("virtualNetwork");
                writer.WriteObjectValue(VirtualNetwork);
            }
            if (Optional.IsDefined(InternalLoadBalancingMode))
            {
                writer.WritePropertyName("internalLoadBalancingMode");
                writer.WriteStringValue(InternalLoadBalancingMode.Value.ToString());
            }
            if (Optional.IsDefined(MultiSize))
            {
                writer.WritePropertyName("multiSize");
                writer.WriteStringValue(MultiSize);
            }
            if (Optional.IsDefined(IpsslAddressCount))
            {
                writer.WritePropertyName("ipsslAddressCount");
                writer.WriteNumberValue(IpsslAddressCount.Value);
            }
            if (Optional.IsDefined(DnsSuffix))
            {
                writer.WritePropertyName("dnsSuffix");
                writer.WriteStringValue(DnsSuffix);
            }
            if (Optional.IsDefined(FrontEndScaleFactor))
            {
                writer.WritePropertyName("frontEndScaleFactor");
                writer.WriteNumberValue(FrontEndScaleFactor.Value);
            }
            if (Optional.IsCollectionDefined(ClusterSettings))
            {
                writer.WritePropertyName("clusterSettings");
                writer.WriteStartArray();
                foreach (var item in ClusterSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserWhitelistedIPRanges))
            {
                writer.WritePropertyName("userWhitelistedIpRanges");
                writer.WriteStartArray();
                foreach (var item in UserWhitelistedIPRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DedicatedHostCount))
            {
                writer.WritePropertyName("dedicatedHostCount");
                writer.WriteNumberValue(DedicatedHostCount.Value);
            }
            if (Optional.IsDefined(ZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant");
                writer.WriteBooleanValue(ZoneRedundant.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AppServiceEnvironmentData DeserializeAppServiceEnvironmentData(JsonElement element)
        {
            Optional<string> kind = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<HostingEnvironmentStatus> status = default;
            Optional<VirtualNetworkProfile> virtualNetwork = default;
            Optional<LoadBalancingMode> internalLoadBalancingMode = default;
            Optional<string> multiSize = default;
            Optional<int> multiRoleCount = default;
            Optional<int> ipsslAddressCount = default;
            Optional<string> dnsSuffix = default;
            Optional<int> maximumNumberOfMachines = default;
            Optional<int> frontEndScaleFactor = default;
            Optional<bool> suspended = default;
            Optional<IList<NameValuePair>> clusterSettings = default;
            Optional<IList<string>> userWhitelistedIPRanges = default;
            Optional<bool> hasLinuxWorkers = default;
            Optional<int> dedicatedHostCount = default;
            Optional<bool> zoneRedundant = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                            provisioningState = property0.Value.GetString().ToProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = property0.Value.GetString().ToHostingEnvironmentStatus();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetwork"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            virtualNetwork = VirtualNetworkProfile.DeserializeVirtualNetworkProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("internalLoadBalancingMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            internalLoadBalancingMode = new LoadBalancingMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("multiSize"))
                        {
                            multiSize = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("multiRoleCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            multiRoleCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("ipsslAddressCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ipsslAddressCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dnsSuffix"))
                        {
                            dnsSuffix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maximumNumberOfMachines"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maximumNumberOfMachines = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("frontEndScaleFactor"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            frontEndScaleFactor = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("suspended"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            suspended = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("clusterSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<NameValuePair> array = new List<NameValuePair>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NameValuePair.DeserializeNameValuePair(item));
                            }
                            clusterSettings = array;
                            continue;
                        }
                        if (property0.NameEquals("userWhitelistedIpRanges"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            userWhitelistedIPRanges = array;
                            continue;
                        }
                        if (property0.NameEquals("hasLinuxWorkers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hasLinuxWorkers = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("dedicatedHostCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dedicatedHostCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("zoneRedundant"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            zoneRedundant = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AppServiceEnvironmentData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(provisioningState), Optional.ToNullable(status), virtualNetwork.Value, Optional.ToNullable(internalLoadBalancingMode), multiSize.Value, Optional.ToNullable(multiRoleCount), Optional.ToNullable(ipsslAddressCount), dnsSuffix.Value, Optional.ToNullable(maximumNumberOfMachines), Optional.ToNullable(frontEndScaleFactor), Optional.ToNullable(suspended), Optional.ToList(clusterSettings), Optional.ToList(userWhitelistedIPRanges), Optional.ToNullable(hasLinuxWorkers), Optional.ToNullable(dedicatedHostCount), Optional.ToNullable(zoneRedundant), kind.Value);
        }
    }
}
