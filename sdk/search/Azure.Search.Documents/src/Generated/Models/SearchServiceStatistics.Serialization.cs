// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchServiceStatistics : IUtf8JsonSerializable, IJsonModel<SearchServiceStatistics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SearchServiceStatistics>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SearchServiceStatistics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SearchServiceStatistics>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SearchServiceStatistics>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("counters"u8);
            writer.WriteObjectValue(Counters);
            writer.WritePropertyName("limits"u8);
            writer.WriteObjectValue(Limits);
            if (_serializedAdditionalRawData != null && options.Format == "J")
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SearchServiceStatistics IJsonModel<SearchServiceStatistics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchServiceStatistics)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchServiceStatistics(document.RootElement, options);
        }

        internal static SearchServiceStatistics DeserializeSearchServiceStatistics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SearchServiceCounters counters = default;
            SearchServiceLimits limits = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("counters"u8))
                {
                    counters = SearchServiceCounters.DeserializeSearchServiceCounters(property.Value);
                    continue;
                }
                if (property.NameEquals("limits"u8))
                {
                    limits = SearchServiceLimits.DeserializeSearchServiceLimits(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SearchServiceStatistics(counters, limits, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SearchServiceStatistics>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchServiceStatistics)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SearchServiceStatistics IPersistableModel<SearchServiceStatistics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchServiceStatistics)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSearchServiceStatistics(document.RootElement, options);
        }

        string IPersistableModel<SearchServiceStatistics>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
