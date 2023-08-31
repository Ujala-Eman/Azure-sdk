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
    public partial class VmmToVmmUpdateNetworkMappingContent : IUtf8JsonSerializable, IModelJsonSerializable<VmmToVmmUpdateNetworkMappingContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VmmToVmmUpdateNetworkMappingContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VmmToVmmUpdateNetworkMappingContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmmToVmmUpdateNetworkMappingContent>(this, options.Format);

            writer.WriteStartObject();
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

        internal static VmmToVmmUpdateNetworkMappingContent DeserializeVmmToVmmUpdateNetworkMappingContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string instanceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
            return new VmmToVmmUpdateNetworkMappingContent(instanceType, rawData);
        }

        VmmToVmmUpdateNetworkMappingContent IModelJsonSerializable<VmmToVmmUpdateNetworkMappingContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmmToVmmUpdateNetworkMappingContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVmmToVmmUpdateNetworkMappingContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VmmToVmmUpdateNetworkMappingContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmmToVmmUpdateNetworkMappingContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VmmToVmmUpdateNetworkMappingContent IModelSerializable<VmmToVmmUpdateNetworkMappingContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmmToVmmUpdateNetworkMappingContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVmmToVmmUpdateNetworkMappingContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VmmToVmmUpdateNetworkMappingContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VmmToVmmUpdateNetworkMappingContent"/> to convert. </param>
        public static implicit operator RequestContent(VmmToVmmUpdateNetworkMappingContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VmmToVmmUpdateNetworkMappingContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VmmToVmmUpdateNetworkMappingContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVmmToVmmUpdateNetworkMappingContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
