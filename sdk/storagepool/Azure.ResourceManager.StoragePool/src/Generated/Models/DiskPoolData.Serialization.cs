// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.StoragePool.Models;

namespace Azure.ResourceManager.StoragePool
{
    public partial class DiskPoolData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
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
            writer.WritePropertyName("availabilityZones");
            writer.WriteStartArray();
            foreach (var item in AvailabilityZones)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("status");
            writer.WriteStringValue(Status.ToString());
            if (Optional.IsCollectionDefined(Disks))
            {
                writer.WritePropertyName("disks");
                writer.WriteStartArray();
                foreach (var item in Disks)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("subnetId");
            writer.WriteStringValue(SubnetId);
            if (Optional.IsCollectionDefined(AdditionalCapabilities))
            {
                writer.WritePropertyName("additionalCapabilities");
                writer.WriteStartArray();
                foreach (var item in AdditionalCapabilities)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DiskPoolData DeserializeDiskPoolData(JsonElement element)
        {
            Optional<StoragePoolSku> sku = default;
            Optional<string> managedBy = default;
            Optional<IReadOnlyList<string>> managedByExtended = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            DiskPoolIscsiTargetProvisioningState provisioningState = default;
            IList<string> availabilityZones = default;
            StoragePoolOperationalStatus status = default;
            Optional<IList<WritableSubResource>> disks = default;
            ResourceIdentifier subnetId = default;
            Optional<IList<string>> additionalCapabilities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = StoragePoolSku.DeserializeStoragePoolSku(property.Value);
                    continue;
                }
                if (property.NameEquals("managedBy"))
                {
                    managedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedByExtended"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    managedByExtended = array;
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
                            provisioningState = new DiskPoolIscsiTargetProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("availabilityZones"))
                        {
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            availabilityZones = array;
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            status = new StoragePoolOperationalStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("disks"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.ToString()));
                            }
                            disks = array;
                            continue;
                        }
                        if (property0.NameEquals("subnetId"))
                        {
                            subnetId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("additionalCapabilities"))
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
                            additionalCapabilities = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DiskPoolData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku.Value, managedBy.Value, Optional.ToList(managedByExtended), provisioningState, availabilityZones, status, Optional.ToList(disks), subnetId, Optional.ToList(additionalCapabilities));
        }
    }
}
