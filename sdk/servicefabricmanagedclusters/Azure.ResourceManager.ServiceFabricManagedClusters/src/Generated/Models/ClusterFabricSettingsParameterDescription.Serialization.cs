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

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ClusterFabricSettingsParameterDescription : IUtf8JsonSerializable, IModelJsonSerializable<ClusterFabricSettingsParameterDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ClusterFabricSettingsParameterDescription>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ClusterFabricSettingsParameterDescription>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("value"u8);
            writer.WriteStringValue(Value);
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

        internal static ClusterFabricSettingsParameterDescription DeserializeClusterFabricSettingsParameterDescription(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ClusterFabricSettingsParameterDescription(name, value, rawData);
        }

        ClusterFabricSettingsParameterDescription IModelJsonSerializable<ClusterFabricSettingsParameterDescription>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterFabricSettingsParameterDescription(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ClusterFabricSettingsParameterDescription>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ClusterFabricSettingsParameterDescription IModelSerializable<ClusterFabricSettingsParameterDescription>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeClusterFabricSettingsParameterDescription(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ClusterFabricSettingsParameterDescription"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ClusterFabricSettingsParameterDescription"/> to convert. </param>
        public static implicit operator RequestContent(ClusterFabricSettingsParameterDescription model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ClusterFabricSettingsParameterDescription"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ClusterFabricSettingsParameterDescription(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeClusterFabricSettingsParameterDescription(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
