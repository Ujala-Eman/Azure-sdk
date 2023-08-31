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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareCbtProtectionContainerMappingDetails : IUtf8JsonSerializable, IModelJsonSerializable<VMwareCbtProtectionContainerMappingDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VMwareCbtProtectionContainerMappingDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VMwareCbtProtectionContainerMappingDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VMwareCbtProtectionContainerMappingDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ExcludedSkus))
            {
                writer.WritePropertyName("excludedSkus"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedSkus)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        internal static VMwareCbtProtectionContainerMappingDetails DeserializeVMwareCbtProtectionContainerMappingDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> keyVaultId = default;
            Optional<Uri> keyVaultUri = default;
            Optional<ResourceIdentifier> storageAccountId = default;
            Optional<string> storageAccountSasSecretName = default;
            Optional<string> serviceBusConnectionStringSecretName = default;
            Optional<string> targetLocation = default;
            Optional<IReadOnlyDictionary<string, int>> roleSizeToNicCountMap = default;
            Optional<IReadOnlyList<string>> excludedSkus = default;
            string instanceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVaultUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountSasSecretName"u8))
                {
                    storageAccountSasSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceBusConnectionStringSecretName"u8))
                {
                    serviceBusConnectionStringSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetLocation"u8))
                {
                    targetLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roleSizeToNicCountMap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetInt32());
                    }
                    roleSizeToNicCountMap = dictionary;
                    continue;
                }
                if (property.NameEquals("excludedSkus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    excludedSkus = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VMwareCbtProtectionContainerMappingDetails(instanceType, keyVaultId.Value, keyVaultUri.Value, storageAccountId.Value, storageAccountSasSecretName.Value, serviceBusConnectionStringSecretName.Value, targetLocation.Value, Optional.ToDictionary(roleSizeToNicCountMap), Optional.ToList(excludedSkus), rawData);
        }

        VMwareCbtProtectionContainerMappingDetails IModelJsonSerializable<VMwareCbtProtectionContainerMappingDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VMwareCbtProtectionContainerMappingDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareCbtProtectionContainerMappingDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VMwareCbtProtectionContainerMappingDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VMwareCbtProtectionContainerMappingDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VMwareCbtProtectionContainerMappingDetails IModelSerializable<VMwareCbtProtectionContainerMappingDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VMwareCbtProtectionContainerMappingDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVMwareCbtProtectionContainerMappingDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VMwareCbtProtectionContainerMappingDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VMwareCbtProtectionContainerMappingDetails"/> to convert. </param>
        public static implicit operator RequestContent(VMwareCbtProtectionContainerMappingDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VMwareCbtProtectionContainerMappingDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VMwareCbtProtectionContainerMappingDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVMwareCbtProtectionContainerMappingDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
