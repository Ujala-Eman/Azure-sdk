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

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class BackupFeatureValidationResult : IUtf8JsonSerializable, IModelJsonSerializable<BackupFeatureValidationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BackupFeatureValidationResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BackupFeatureValidationResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BackupFeatureValidationResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FeatureType))
            {
                writer.WritePropertyName("featureType"u8);
                writer.WriteStringValue(FeatureType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Features))
            {
                writer.WritePropertyName("features"u8);
                writer.WriteStartArray();
                foreach (var item in Features)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        internal static BackupFeatureValidationResult DeserializeBackupFeatureValidationResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BackupSupportedFeatureType> featureType = default;
            Optional<IReadOnlyList<BackupSupportedFeature>> features = default;
            string objectType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("featureType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    featureType = new BackupSupportedFeatureType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("features"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BackupSupportedFeature> array = new List<BackupSupportedFeature>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BackupSupportedFeature.DeserializeBackupSupportedFeature(item));
                    }
                    features = array;
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BackupFeatureValidationResult(objectType, Optional.ToNullable(featureType), Optional.ToList(features), rawData);
        }

        BackupFeatureValidationResult IModelJsonSerializable<BackupFeatureValidationResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BackupFeatureValidationResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupFeatureValidationResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BackupFeatureValidationResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BackupFeatureValidationResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BackupFeatureValidationResult IModelSerializable<BackupFeatureValidationResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BackupFeatureValidationResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBackupFeatureValidationResult(doc.RootElement, options);
        }

        public static implicit operator RequestContent(BackupFeatureValidationResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator BackupFeatureValidationResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBackupFeatureValidationResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
