// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class CommonDataServiceForAppsSink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("writeBehavior");
            writer.WriteStringValue(WriteBehavior.ToString());
            if (Optional.IsDefined(IgnoreNullValues))
            {
                writer.WritePropertyName("ignoreNullValues");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(IgnoreNullValues);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(IgnoreNullValues.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(AlternateKeyName))
            {
                writer.WritePropertyName("alternateKeyName");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(AlternateKeyName);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(AlternateKeyName.ToString()).RootElement);
#endif
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(CopySinkType);
            if (Optional.IsDefined(WriteBatchSize))
            {
                writer.WritePropertyName("writeBatchSize");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(WriteBatchSize);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(WriteBatchSize.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(WriteBatchTimeout))
            {
                writer.WritePropertyName("writeBatchTimeout");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(WriteBatchTimeout);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(WriteBatchTimeout.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(SinkRetryCount))
            {
                writer.WritePropertyName("sinkRetryCount");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SinkRetryCount);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SinkRetryCount.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(SinkRetryWait))
            {
                writer.WritePropertyName("sinkRetryWait");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SinkRetryWait);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SinkRetryWait.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(MaxConcurrentConnections);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(MaxConcurrentConnections.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(DisableMetricsCollection))
            {
                writer.WritePropertyName("disableMetricsCollection");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DisableMetricsCollection);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(DisableMetricsCollection.ToString()).RootElement);
#endif
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static CommonDataServiceForAppsSink DeserializeCommonDataServiceForAppsSink(JsonElement element)
        {
            DynamicsSinkWriteBehavior writeBehavior = default;
            Optional<BinaryData> ignoreNullValues = default;
            Optional<BinaryData> alternateKeyName = default;
            string type = default;
            Optional<BinaryData> writeBatchSize = default;
            Optional<BinaryData> writeBatchTimeout = default;
            Optional<BinaryData> sinkRetryCount = default;
            Optional<BinaryData> sinkRetryWait = default;
            Optional<BinaryData> maxConcurrentConnections = default;
            Optional<BinaryData> disableMetricsCollection = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("writeBehavior"))
                {
                    writeBehavior = new DynamicsSinkWriteBehavior(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ignoreNullValues"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ignoreNullValues = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("alternateKeyName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    alternateKeyName = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("writeBatchSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    writeBatchSize = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("writeBatchTimeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    writeBatchTimeout = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sinkRetryCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sinkRetryCount = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sinkRetryWait"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sinkRetryWait = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxConcurrentConnections = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    disableMetricsCollection = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new CommonDataServiceForAppsSink(type, writeBatchSize.Value, writeBatchTimeout.Value, sinkRetryCount.Value, sinkRetryWait.Value, maxConcurrentConnections.Value, disableMetricsCollection.Value, additionalProperties, writeBehavior, ignoreNullValues.Value, alternateKeyName.Value);
        }
    }
}
