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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsIncidentEntitiesResult : IUtf8JsonSerializable, IModelJsonSerializable<SecurityInsightsIncidentEntitiesResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecurityInsightsIncidentEntitiesResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecurityInsightsIncidentEntitiesResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Entities))
            {
                writer.WritePropertyName("entities"u8);
                writer.WriteStartArray();
                foreach (var item in Entities)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SecurityInsightsEntity>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MetaData))
            {
                writer.WritePropertyName("metaData"u8);
                writer.WriteStartArray();
                foreach (var item in MetaData)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SecurityInsightsIncidentEntitiesMetadata>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
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

        internal static SecurityInsightsIncidentEntitiesResult DeserializeSecurityInsightsIncidentEntitiesResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SecurityInsightsEntity>> entities = default;
            Optional<IReadOnlyList<SecurityInsightsIncidentEntitiesMetadata>> metaData = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("entities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityInsightsEntity> array = new List<SecurityInsightsEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityInsightsEntity.DeserializeSecurityInsightsEntity(item));
                    }
                    entities = array;
                    continue;
                }
                if (property.NameEquals("metaData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityInsightsIncidentEntitiesMetadata> array = new List<SecurityInsightsIncidentEntitiesMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityInsightsIncidentEntitiesMetadata.DeserializeSecurityInsightsIncidentEntitiesMetadata(item));
                    }
                    metaData = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SecurityInsightsIncidentEntitiesResult(Optional.ToList(entities), Optional.ToList(metaData), rawData);
        }

        SecurityInsightsIncidentEntitiesResult IModelJsonSerializable<SecurityInsightsIncidentEntitiesResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsIncidentEntitiesResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecurityInsightsIncidentEntitiesResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecurityInsightsIncidentEntitiesResult IModelSerializable<SecurityInsightsIncidentEntitiesResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecurityInsightsIncidentEntitiesResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SecurityInsightsIncidentEntitiesResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SecurityInsightsIncidentEntitiesResult"/> to convert. </param>
        public static implicit operator RequestContent(SecurityInsightsIncidentEntitiesResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SecurityInsightsIncidentEntitiesResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SecurityInsightsIncidentEntitiesResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSecurityInsightsIncidentEntitiesResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
