// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(CosmosDbSqlApiSourceConverter))]
    public partial class CosmosDbSqlApiSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Query))
            {
                writer.WritePropertyName("query"u8);
                writer.WriteObjectValue(Query);
            }
            if (Optional.IsDefined(PageSize))
            {
                writer.WritePropertyName("pageSize"u8);
                writer.WriteObjectValue(PageSize);
            }
            if (Optional.IsDefined(PreferredRegions))
            {
                writer.WritePropertyName("preferredRegions"u8);
                writer.WriteObjectValue(PreferredRegions);
            }
            if (Optional.IsDefined(DetectDatetime))
            {
                writer.WritePropertyName("detectDatetime"u8);
                writer.WriteObjectValue(DetectDatetime);
            }
            if (Optional.IsDefined(AdditionalColumns))
            {
                writer.WritePropertyName("additionalColumns"u8);
                writer.WriteObjectValue(AdditionalColumns);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(SourceRetryCount))
            {
                writer.WritePropertyName("sourceRetryCount"u8);
                writer.WriteObjectValue(SourceRetryCount);
            }
            if (Optional.IsDefined(SourceRetryWait))
            {
                writer.WritePropertyName("sourceRetryWait"u8);
                writer.WriteObjectValue(SourceRetryWait);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            if (AdditionalProperties != null)
            {
                foreach (var item in AdditionalProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
            }
            writer.WriteEndObject();
        }

        internal static CosmosDbSqlApiSource DeserializeCosmosDbSqlApiSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> query = default;
            Optional<object> pageSize = default;
            Optional<object> preferredRegions = default;
            Optional<object> detectDatetime = default;
            Optional<object> additionalColumns = default;
            string type = default;
            Optional<object> sourceRetryCount = default;
            Optional<object> sourceRetryWait = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    query = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("pageSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pageSize = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("preferredRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preferredRegions = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("detectDatetime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    detectDatetime = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("additionalColumns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalColumns = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sourceRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryWait = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new CosmosDbSqlApiSource(type, sourceRetryCount.Value, sourceRetryWait.Value, maxConcurrentConnections.Value, additionalProperties, query.Value, pageSize.Value, preferredRegions.Value, detectDatetime.Value, additionalColumns.Value);
        }

        internal partial class CosmosDbSqlApiSourceConverter : JsonConverter<CosmosDbSqlApiSource>
        {
            public override void Write(Utf8JsonWriter writer, CosmosDbSqlApiSource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override CosmosDbSqlApiSource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeCosmosDbSqlApiSource(document.RootElement);
            }
        }
    }
}
