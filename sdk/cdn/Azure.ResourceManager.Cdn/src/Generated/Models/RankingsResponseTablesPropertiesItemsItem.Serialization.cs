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

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class RankingsResponseTablesPropertiesItemsItem : IUtf8JsonSerializable, IModelJsonSerializable<RankingsResponseTablesPropertiesItemsItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RankingsResponseTablesPropertiesItemsItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RankingsResponseTablesPropertiesItemsItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(Metrics))
            {
                writer.WritePropertyName("metrics"u8);
                writer.WriteStartArray();
                foreach (var item in Metrics)
                {
                    writer.WriteObjectValue(item);
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

        internal static RankingsResponseTablesPropertiesItemsItem DeserializeRankingsResponseTablesPropertiesItemsItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IReadOnlyList<RankingsResponseTablesPropertiesItemsMetricsItem>> metrics = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RankingsResponseTablesPropertiesItemsMetricsItem> array = new List<RankingsResponseTablesPropertiesItemsMetricsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RankingsResponseTablesPropertiesItemsMetricsItem.DeserializeRankingsResponseTablesPropertiesItemsMetricsItem(item));
                    }
                    metrics = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RankingsResponseTablesPropertiesItemsItem(name.Value, Optional.ToList(metrics), rawData);
        }

        RankingsResponseTablesPropertiesItemsItem IModelJsonSerializable<RankingsResponseTablesPropertiesItemsItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRankingsResponseTablesPropertiesItemsItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RankingsResponseTablesPropertiesItemsItem>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RankingsResponseTablesPropertiesItemsItem IModelSerializable<RankingsResponseTablesPropertiesItemsItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRankingsResponseTablesPropertiesItemsItem(doc.RootElement, options);
        }

        public static implicit operator RequestContent(RankingsResponseTablesPropertiesItemsItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator RankingsResponseTablesPropertiesItemsItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRankingsResponseTablesPropertiesItemsItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
