// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabCustomImageData : IUtf8JsonSerializable, IModelJsonSerializable<DevTestLabCustomImageData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DevTestLabCustomImageData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DevTestLabCustomImageData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Vm))
            {
                writer.WritePropertyName("vm"u8);
                writer.WriteObjectValue(Vm);
            }
            if (Optional.IsDefined(Vhd))
            {
                writer.WritePropertyName("vhd"u8);
                writer.WriteObjectValue(Vhd);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Author))
            {
                writer.WritePropertyName("author"u8);
                writer.WriteStringValue(Author);
            }
            if (Optional.IsDefined(ManagedImageId))
            {
                writer.WritePropertyName("managedImageId"u8);
                writer.WriteStringValue(ManagedImageId);
            }
            if (Optional.IsDefined(ManagedSnapshotId))
            {
                writer.WritePropertyName("managedSnapshotId"u8);
                writer.WriteStringValue(ManagedSnapshotId);
            }
            if (Optional.IsCollectionDefined(DataDiskStorageInfo))
            {
                writer.WritePropertyName("dataDiskStorageInfo"u8);
                writer.WriteStartArray();
                foreach (var item in DataDiskStorageInfo)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CustomImagePlan))
            {
                writer.WritePropertyName("customImagePlan"u8);
                writer.WriteObjectValue(CustomImagePlan);
            }
            if (Optional.IsDefined(IsPlanAuthorized))
            {
                writer.WritePropertyName("isPlanAuthorized"u8);
                writer.WriteBooleanValue(IsPlanAuthorized.Value);
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static DevTestLabCustomImageData DeserializeDevTestLabCustomImageData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DevTestLabCustomImageVm> vm = default;
            Optional<DevTestLabCustomImageVhd> vhd = default;
            Optional<string> description = default;
            Optional<string> author = default;
            Optional<DateTimeOffset> creationDate = default;
            Optional<string> managedImageId = default;
            Optional<string> managedSnapshotId = default;
            Optional<IList<DevTestLabDataDiskStorageTypeInfo>> dataDiskStorageInfo = default;
            Optional<DevTestLabCustomImagePlan> customImagePlan = default;
            Optional<bool> isPlanAuthorized = default;
            Optional<string> provisioningState = default;
            Optional<Guid> uniqueIdentifier = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
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
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("vm"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vm = DevTestLabCustomImageVm.DeserializeDevTestLabCustomImageVm(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("vhd"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vhd = DevTestLabCustomImageVhd.DeserializeDevTestLabCustomImageVhd(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("author"u8))
                        {
                            author = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("managedImageId"u8))
                        {
                            managedImageId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedSnapshotId"u8))
                        {
                            managedSnapshotId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataDiskStorageInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DevTestLabDataDiskStorageTypeInfo> array = new List<DevTestLabDataDiskStorageTypeInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabDataDiskStorageTypeInfo.DeserializeDevTestLabDataDiskStorageTypeInfo(item));
                            }
                            dataDiskStorageInfo = array;
                            continue;
                        }
                        if (property0.NameEquals("customImagePlan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customImagePlan = DevTestLabCustomImagePlan.DeserializeDevTestLabCustomImagePlan(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isPlanAuthorized"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isPlanAuthorized = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uniqueIdentifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uniqueIdentifier = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DevTestLabCustomImageData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, vm.Value, vhd.Value, description.Value, author.Value, Optional.ToNullable(creationDate), managedImageId.Value, managedSnapshotId.Value, Optional.ToList(dataDiskStorageInfo), customImagePlan.Value, Optional.ToNullable(isPlanAuthorized), provisioningState.Value, Optional.ToNullable(uniqueIdentifier), rawData);
        }

        DevTestLabCustomImageData IModelJsonSerializable<DevTestLabCustomImageData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabCustomImageData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DevTestLabCustomImageData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DevTestLabCustomImageData IModelSerializable<DevTestLabCustomImageData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDevTestLabCustomImageData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DevTestLabCustomImageData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DevTestLabCustomImageData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDevTestLabCustomImageData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
