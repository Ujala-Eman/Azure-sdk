// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkVirtualAppliance : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
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
            if (Optional.IsDefined(BootStrapConfigurationBlob))
            {
                writer.WritePropertyName("bootStrapConfigurationBlob");
                writer.WriteStartArray();
                foreach (var item in BootStrapConfigurationBlob)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(VirtualHub))
            {
                writer.WritePropertyName("virtualHub");
                writer.WriteObjectValue(VirtualHub);
            }
            if (Optional.IsDefined(CloudInitConfigurationBlob))
            {
                writer.WritePropertyName("cloudInitConfigurationBlob");
                writer.WriteStartArray();
                foreach (var item in CloudInitConfigurationBlob)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(VirtualApplianceAsn))
            {
                writer.WritePropertyName("virtualApplianceAsn");
                writer.WriteNumberValue(VirtualApplianceAsn.Value);
            }
            if (Optional.IsDefined(VirtualApplianceNics))
            {
                writer.WritePropertyName("virtualApplianceNics");
                writer.WriteStartArray();
                foreach (var item in VirtualApplianceNics)
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
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkVirtualAppliance DeserializeNetworkVirtualAppliance(JsonElement element)
        {
            Optional<ManagedServiceIdentity> identity = default;
            Optional<VirtualApplianceSkuProperties> sku = default;
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<IList<string>> bootStrapConfigurationBlob = default;
            Optional<SubResource> virtualHub = default;
            Optional<IList<string>> cloudInitConfigurationBlob = default;
            Optional<long> virtualApplianceAsn = default;
            Optional<IList<VirtualApplianceNicProperties>> virtualApplianceNics = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    identity = ManagedServiceIdentity.DeserializeManagedServiceIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    sku = VirtualApplianceSkuProperties.DeserializeVirtualApplianceSkuProperties(property.Value);
                    continue;
                }
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
                        if (property0.NameEquals("bootStrapConfigurationBlob"))
                        {
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(item.GetString());
                                }
                            }
                            bootStrapConfigurationBlob = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualHub"))
                        {
                            virtualHub = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("cloudInitConfigurationBlob"))
                        {
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(item.GetString());
                                }
                            }
                            cloudInitConfigurationBlob = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualApplianceAsn"))
                        {
                            virtualApplianceAsn = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("virtualApplianceNics"))
                        {
                            List<VirtualApplianceNicProperties> array = new List<VirtualApplianceNicProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(VirtualApplianceNicProperties.DeserializeVirtualApplianceNicProperties(item));
                                }
                            }
                            virtualApplianceNics = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetworkVirtualAppliance(id.HasValue ? id.Value : null, name.HasValue ? name.Value : null, type.HasValue ? type.Value : null, location.HasValue ? location.Value : null, new ChangeTrackingDictionary<string, string>(tags), identity.HasValue ? identity.Value : null, sku.HasValue ? sku.Value : null, etag.HasValue ? etag.Value : null, new ChangeTrackingList<string>(bootStrapConfigurationBlob), virtualHub.HasValue ? virtualHub.Value : null, new ChangeTrackingList<string>(cloudInitConfigurationBlob), virtualApplianceAsn.HasValue ? virtualApplianceAsn.Value : (long?)null, new ChangeTrackingList<VirtualApplianceNicProperties>(virtualApplianceNics), provisioningState.HasValue ? provisioningState.Value : (ProvisioningState?)null);
        }
    }
}
