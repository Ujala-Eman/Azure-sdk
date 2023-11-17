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
    public partial class SemanticSearch : IUtf8JsonSerializable, IJsonModel<SemanticSearch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SemanticSearch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SemanticSearch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SemanticSearch>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SemanticSearch>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultConfigurationName))
            {
                writer.WritePropertyName("defaultConfiguration"u8);
                writer.WriteStringValue(DefaultConfigurationName);
            }
            if (Optional.IsCollectionDefined(Configurations))
            {
                writer.WritePropertyName("configurations"u8);
                writer.WriteStartArray();
                foreach (var item in Configurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        SemanticSearch IJsonModel<SemanticSearch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SemanticSearch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSemanticSearch(document.RootElement, options);
        }

        internal static SemanticSearch DeserializeSemanticSearch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> defaultConfiguration = default;
            Optional<IList<SemanticConfiguration>> configurations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultConfiguration"u8))
                {
                    defaultConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SemanticConfiguration> array = new List<SemanticConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SemanticConfiguration.DeserializeSemanticConfiguration(item));
                    }
                    configurations = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SemanticSearch(defaultConfiguration.Value, Optional.ToList(configurations), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SemanticSearch>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SemanticSearch)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SemanticSearch IPersistableModel<SemanticSearch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SemanticSearch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSemanticSearch(document.RootElement, options);
        }

        string IPersistableModel<SemanticSearch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
