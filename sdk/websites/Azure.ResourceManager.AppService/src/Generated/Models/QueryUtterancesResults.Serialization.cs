// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class QueryUtterancesResults : IUtf8JsonSerializable, IJsonModel<QueryUtterancesResults>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QueryUtterancesResults>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<QueryUtterancesResults>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryUtterancesResults>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueryUtterancesResults)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Query))
            {
                writer.WritePropertyName("query"u8);
                writer.WriteStringValue(Query);
            }
            if (Optional.IsCollectionDefined(Results))
            {
                writer.WritePropertyName("results"u8);
                writer.WriteStartArray();
                foreach (var item in Results)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        QueryUtterancesResults IJsonModel<QueryUtterancesResults>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryUtterancesResults>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueryUtterancesResults)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQueryUtterancesResults(document.RootElement, options);
        }

        internal static QueryUtterancesResults DeserializeQueryUtterancesResults(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> query = default;
            Optional<IList<QueryUtterancesResult>> results = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"u8))
                {
                    query = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QueryUtterancesResult> array = new List<QueryUtterancesResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueryUtterancesResult.DeserializeQueryUtterancesResult(item, options));
                    }
                    results = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new QueryUtterancesResults(query.Value, Optional.ToList(results), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QueryUtterancesResults>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryUtterancesResults>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(QueryUtterancesResults)} does not support '{options.Format}' format.");
            }
        }

        QueryUtterancesResults IPersistableModel<QueryUtterancesResults>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryUtterancesResults>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQueryUtterancesResults(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QueryUtterancesResults)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<QueryUtterancesResults>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
