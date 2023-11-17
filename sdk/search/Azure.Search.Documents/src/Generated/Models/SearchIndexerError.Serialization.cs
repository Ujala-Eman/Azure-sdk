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
    public partial class SearchIndexerError : IUtf8JsonSerializable, IJsonModel<SearchIndexerError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SearchIndexerError>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SearchIndexerError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SearchIndexerError>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SearchIndexerError>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Key))
                {
                    writer.WritePropertyName("key"u8);
                    writer.WriteStringValue(Key);
                }
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("statusCode"u8);
                writer.WriteNumberValue(StatusCode);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Name))
                {
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(Name);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Details))
                {
                    writer.WritePropertyName("details"u8);
                    writer.WriteStringValue(Details);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DocumentationLink))
                {
                    writer.WritePropertyName("documentationLink"u8);
                    writer.WriteStringValue(DocumentationLink);
                }
            }
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

        SearchIndexerError IJsonModel<SearchIndexerError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchIndexerError)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchIndexerError(document.RootElement, options);
        }

        internal static SearchIndexerError DeserializeSearchIndexerError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> key = default;
            string errorMessage = default;
            int statusCode = default;
            Optional<string> name = default;
            Optional<string> details = default;
            Optional<string> documentationLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusCode"u8))
                {
                    statusCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    details = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("documentationLink"u8))
                {
                    documentationLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SearchIndexerError(key.Value, errorMessage, statusCode, name.Value, details.Value, documentationLink.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SearchIndexerError>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchIndexerError)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SearchIndexerError IPersistableModel<SearchIndexerError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchIndexerError)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSearchIndexerError(document.RootElement, options);
        }

        string IPersistableModel<SearchIndexerError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
