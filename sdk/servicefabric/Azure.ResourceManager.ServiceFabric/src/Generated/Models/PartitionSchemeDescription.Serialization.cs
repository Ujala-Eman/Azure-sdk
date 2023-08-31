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

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class PartitionSchemeDescription : IUtf8JsonSerializable, IModelJsonSerializable<PartitionSchemeDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PartitionSchemeDescription>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PartitionSchemeDescription>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("partitionScheme"u8);
            writer.WriteStringValue(PartitionScheme.ToString());
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

        internal static PartitionSchemeDescription DeserializePartitionSchemeDescription(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("partitionScheme", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Named": return NamedPartitionSchemeDescription.DeserializeNamedPartitionSchemeDescription(element);
                    case "Singleton": return SingletonPartitionSchemeDescription.DeserializeSingletonPartitionSchemeDescription(element);
                    case "UniformInt64Range": return UniformInt64RangePartitionSchemeDescription.DeserializeUniformInt64RangePartitionSchemeDescription(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            ApplicationPartitionScheme partitionScheme = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionScheme"u8))
                {
                    partitionScheme = new ApplicationPartitionScheme(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownPartitionSchemeDescription(partitionScheme, rawData);
        }

        PartitionSchemeDescription IModelJsonSerializable<PartitionSchemeDescription>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePartitionSchemeDescription(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PartitionSchemeDescription>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PartitionSchemeDescription IModelSerializable<PartitionSchemeDescription>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePartitionSchemeDescription(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PartitionSchemeDescription"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PartitionSchemeDescription"/> to convert. </param>
        public static implicit operator RequestContent(PartitionSchemeDescription model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PartitionSchemeDescription"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PartitionSchemeDescription(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePartitionSchemeDescription(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
