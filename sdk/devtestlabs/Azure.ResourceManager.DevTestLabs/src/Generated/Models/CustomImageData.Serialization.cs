// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class CustomImageData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
            if (Optional.IsDefined(Vm))
            {
                writer.WritePropertyName("vm");
                writer.WriteObjectValue(Vm);
            }
            if (Optional.IsDefined(Vhd))
            {
                writer.WritePropertyName("vhd");
                writer.WriteObjectValue(Vhd);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Author))
            {
                writer.WritePropertyName("author");
                writer.WriteStringValue(Author);
            }
            if (Optional.IsDefined(ManagedImageId))
            {
                writer.WritePropertyName("managedImageId");
                writer.WriteStringValue(ManagedImageId);
            }
            if (Optional.IsDefined(ManagedSnapshotId))
            {
                writer.WritePropertyName("managedSnapshotId");
                writer.WriteStringValue(ManagedSnapshotId);
            }
            if (Optional.IsCollectionDefined(DataDiskStorageInfo))
            {
                writer.WritePropertyName("dataDiskStorageInfo");
                writer.WriteStartArray();
                foreach (var item in DataDiskStorageInfo)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CustomImagePlan))
            {
                writer.WritePropertyName("customImagePlan");
                writer.WriteObjectValue(CustomImagePlan);
            }
            if (Optional.IsDefined(IsPlanAuthorized))
            {
                writer.WritePropertyName("isPlanAuthorized");
                writer.WriteBooleanValue(IsPlanAuthorized.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CustomImageData DeserializeCustomImageData(JsonElement element)
        {
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<CustomImagePropertiesFromVm> vm = default;
            Optional<CustomImagePropertiesCustom> vhd = default;
            Optional<string> description = default;
            Optional<string> author = default;
            Optional<DateTimeOffset> creationDate = default;
            Optional<string> managedImageId = default;
            Optional<string> managedSnapshotId = default;
            Optional<IList<DataDiskStorageTypeInfo>> dataDiskStorageInfo = default;
            Optional<CustomImagePropertiesFromPlan> customImagePlan = default;
            Optional<bool> isPlanAuthorized = default;
            Optional<string> provisioningState = default;
            Optional<string> uniqueIdentifier = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("vm"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            vm = CustomImagePropertiesFromVm.DeserializeCustomImagePropertiesFromVm(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("vhd"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            vhd = CustomImagePropertiesCustom.DeserializeCustomImagePropertiesCustom(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("author"))
                        {
                            author = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("managedImageId"))
                        {
                            managedImageId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedSnapshotId"))
                        {
                            managedSnapshotId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataDiskStorageInfo"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DataDiskStorageTypeInfo> array = new List<DataDiskStorageTypeInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataDiskStorageTypeInfo.DeserializeDataDiskStorageTypeInfo(item));
                            }
                            dataDiskStorageInfo = array;
                            continue;
                        }
                        if (property0.NameEquals("customImagePlan"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            customImagePlan = CustomImagePropertiesFromPlan.DeserializeCustomImagePropertiesFromPlan(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isPlanAuthorized"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isPlanAuthorized = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uniqueIdentifier"))
                        {
                            uniqueIdentifier = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CustomImageData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, vm.Value, vhd.Value, description.Value, author.Value, Optional.ToNullable(creationDate), managedImageId.Value, managedSnapshotId.Value, Optional.ToList(dataDiskStorageInfo), customImagePlan.Value, Optional.ToNullable(isPlanAuthorized), provisioningState.Value, uniqueIdentifier.Value);
        }
    }
}
