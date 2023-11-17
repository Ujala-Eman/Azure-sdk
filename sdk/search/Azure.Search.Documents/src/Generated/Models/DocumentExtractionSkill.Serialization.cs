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
    public partial class DocumentExtractionSkill : IUtf8JsonSerializable, IJsonModel<DocumentExtractionSkill>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DocumentExtractionSkill>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DocumentExtractionSkill>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<DocumentExtractionSkill>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<DocumentExtractionSkill>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ParsingMode))
            {
                if (ParsingMode != null)
                {
                    writer.WritePropertyName("parsingMode"u8);
                    writer.WriteStringValue(ParsingMode.Value.ToString());
                }
                else
                {
                    writer.WriteNull("parsingMode");
                }
            }
            if (Optional.IsDefined(DataToExtract))
            {
                if (DataToExtract != null)
                {
                    writer.WritePropertyName("dataToExtract"u8);
                    writer.WriteStringValue(DataToExtract.Value.ToString());
                }
                else
                {
                    writer.WriteNull("dataToExtract");
                }
            }
            if (Optional.IsCollectionDefined(Configuration))
            {
                if (Configuration != null)
                {
                    writer.WritePropertyName("configuration"u8);
                    writer.WriteStartObject();
                    foreach (var item in Configuration)
                    {
                        writer.WritePropertyName(item.Key);
                        if (item.Value == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("configuration");
                }
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Context))
            {
                writer.WritePropertyName("context"u8);
                writer.WriteStringValue(Context);
            }
            writer.WritePropertyName("inputs"u8);
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("outputs"u8);
            writer.WriteStartArray();
            foreach (var item in Outputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        DocumentExtractionSkill IJsonModel<DocumentExtractionSkill>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DocumentExtractionSkill)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentExtractionSkill(document.RootElement, options);
        }

        internal static DocumentExtractionSkill DeserializeDocumentExtractionSkill(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BlobIndexerParsingMode?> parsingMode = default;
            Optional<BlobIndexerDataToExtract?> dataToExtract = default;
            Optional<IDictionary<string, object>> configuration = default;
            string odataType = default;
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<string> context = default;
            IList<InputFieldMappingEntry> inputs = default;
            IList<OutputFieldMappingEntry> outputs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parsingMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        parsingMode = null;
                        continue;
                    }
                    parsingMode = new BlobIndexerParsingMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataToExtract"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataToExtract = null;
                        continue;
                    }
                    dataToExtract = new BlobIndexerDataToExtract(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        configuration = null;
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    configuration = dictionary;
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("context"u8))
                {
                    context = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    List<InputFieldMappingEntry> array = new List<InputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InputFieldMappingEntry.DeserializeInputFieldMappingEntry(item));
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    List<OutputFieldMappingEntry> array = new List<OutputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutputFieldMappingEntry.DeserializeOutputFieldMappingEntry(item));
                    }
                    outputs = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DocumentExtractionSkill(odataType, name.Value, description.Value, context.Value, inputs, outputs, serializedAdditionalRawData, Optional.ToNullable(parsingMode), Optional.ToNullable(dataToExtract), Optional.ToDictionary(configuration));
        }

        BinaryData IPersistableModel<DocumentExtractionSkill>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DocumentExtractionSkill)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DocumentExtractionSkill IPersistableModel<DocumentExtractionSkill>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DocumentExtractionSkill)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDocumentExtractionSkill(document.RootElement, options);
        }

        string IPersistableModel<DocumentExtractionSkill>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
