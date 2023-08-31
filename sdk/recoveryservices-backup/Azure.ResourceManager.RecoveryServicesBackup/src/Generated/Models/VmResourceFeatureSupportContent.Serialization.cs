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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class VmResourceFeatureSupportContent : IUtf8JsonSerializable, IModelJsonSerializable<VmResourceFeatureSupportContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VmResourceFeatureSupportContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VmResourceFeatureSupportContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmResourceFeatureSupportContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStringValue(VmSize);
            }
            if (Optional.IsDefined(VmSku))
            {
                writer.WritePropertyName("vmSku"u8);
                writer.WriteStringValue(VmSku);
            }
            writer.WritePropertyName("featureType"u8);
            writer.WriteStringValue(FeatureType);
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

        internal static VmResourceFeatureSupportContent DeserializeVmResourceFeatureSupportContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> vmSize = default;
            Optional<string> vmSku = default;
            string featureType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSize"u8))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmSku"u8))
                {
                    vmSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("featureType"u8))
                {
                    featureType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VmResourceFeatureSupportContent(featureType, vmSize.Value, vmSku.Value, rawData);
        }

        VmResourceFeatureSupportContent IModelJsonSerializable<VmResourceFeatureSupportContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmResourceFeatureSupportContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVmResourceFeatureSupportContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VmResourceFeatureSupportContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmResourceFeatureSupportContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VmResourceFeatureSupportContent IModelSerializable<VmResourceFeatureSupportContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmResourceFeatureSupportContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVmResourceFeatureSupportContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VmResourceFeatureSupportContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VmResourceFeatureSupportContent"/> to convert. </param>
        public static implicit operator RequestContent(VmResourceFeatureSupportContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VmResourceFeatureSupportContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VmResourceFeatureSupportContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVmResourceFeatureSupportContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
