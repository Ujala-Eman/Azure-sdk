// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    public partial class VirtualMachineTemplateData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation");
                writer.WriteObjectValue(ExtendedLocation);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(VCenterId))
            {
                writer.WritePropertyName("vCenterId");
                writer.WriteStringValue(VCenterId);
            }
            if (Optional.IsDefined(MoRefId))
            {
                writer.WritePropertyName("moRefId");
                writer.WriteStringValue(MoRefId);
            }
            if (Optional.IsDefined(InventoryItemId))
            {
                writer.WritePropertyName("inventoryItemId");
                writer.WriteStringValue(InventoryItemId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualMachineTemplateData DeserializeVirtualMachineTemplateData(JsonElement element)
        {
            Optional<ExtendedLocation> extendedLocation = default;
            Optional<SystemData> systemData = default;
            Optional<string> kind = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> uuid = default;
            Optional<string> vCenterId = default;
            Optional<string> moRefId = default;
            Optional<string> inventoryItemId = default;
            Optional<string> moName = default;
            Optional<int> memorySizeMB = default;
            Optional<int> numCPUs = default;
            Optional<int> numCoresPerSocket = default;
            Optional<OSType> osType = default;
            Optional<string> osName = default;
            Optional<string> folderPath = default;
            Optional<IReadOnlyList<NetworkInterface>> networkInterfaces = default;
            Optional<IReadOnlyList<VirtualDisk>> disks = default;
            Optional<string> customResourceName = default;
            Optional<string> toolsVersionStatus = default;
            Optional<string> toolsVersion = default;
            Optional<FirmwareType> firmwareType = default;
            Optional<IReadOnlyList<ResourceStatus>> statuses = default;
            Optional<string> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    extendedLocation = ExtendedLocation.DeserializeExtendedLocation(property.Value);
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
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
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
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
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
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("uuid"))
                        {
                            uuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vCenterId"))
                        {
                            vCenterId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("moRefId"))
                        {
                            moRefId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("inventoryItemId"))
                        {
                            inventoryItemId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("moName"))
                        {
                            moName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("memorySizeMB"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            memorySizeMB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("numCPUs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            numCPUs = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("numCoresPerSocket"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            numCoresPerSocket = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("osType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            osType = new OSType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("osName"))
                        {
                            osName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("folderPath"))
                        {
                            folderPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkInterfaces"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<NetworkInterface> array = new List<NetworkInterface>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkInterface.DeserializeNetworkInterface(item));
                            }
                            networkInterfaces = array;
                            continue;
                        }
                        if (property0.NameEquals("disks"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VirtualDisk> array = new List<VirtualDisk>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualDisk.DeserializeVirtualDisk(item));
                            }
                            disks = array;
                            continue;
                        }
                        if (property0.NameEquals("customResourceName"))
                        {
                            customResourceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("toolsVersionStatus"))
                        {
                            toolsVersionStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("toolsVersion"))
                        {
                            toolsVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("firmwareType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            firmwareType = new FirmwareType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("statuses"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ResourceStatus> array = new List<ResourceStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ResourceStatus.DeserializeResourceStatus(item));
                            }
                            statuses = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualMachineTemplateData(id, name, type, tags, location, extendedLocation.Value, systemData, kind.Value, uuid.Value, vCenterId.Value, moRefId.Value, inventoryItemId.Value, moName.Value, Optional.ToNullable(memorySizeMB), Optional.ToNullable(numCPUs), Optional.ToNullable(numCoresPerSocket), Optional.ToNullable(osType), osName.Value, folderPath.Value, Optional.ToList(networkInterfaces), Optional.ToList(disks), customResourceName.Value, toolsVersionStatus.Value, toolsVersion.Value, Optional.ToNullable(firmwareType), Optional.ToList(statuses), provisioningState.Value);
        }
    }
}
