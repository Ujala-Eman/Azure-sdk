// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class DelimitedTextDataset : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Structure))
            {
                writer.WritePropertyName("structure");
                writer.WriteObjectValue(Structure);
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema");
                writer.WriteObjectValue(Schema);
            }
            writer.WritePropertyName("linkedServiceName");
            writer.WriteObjectValue(LinkedServiceName);
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Folder))
            {
                writer.WritePropertyName("folder");
                writer.WriteObjectValue(Folder);
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteObjectValue(Location);
            }
            if (Optional.IsDefined(ColumnDelimiter))
            {
                writer.WritePropertyName("columnDelimiter");
                writer.WriteObjectValue(ColumnDelimiter);
            }
            if (Optional.IsDefined(RowDelimiter))
            {
                writer.WritePropertyName("rowDelimiter");
                writer.WriteObjectValue(RowDelimiter);
            }
            if (Optional.IsDefined(EncodingName))
            {
                writer.WritePropertyName("encodingName");
                writer.WriteObjectValue(EncodingName);
            }
            if (Optional.IsDefined(CompressionCodec))
            {
                writer.WritePropertyName("compressionCodec");
                writer.WriteStringValue(CompressionCodec.Value.ToString());
            }
            if (Optional.IsDefined(CompressionLevel))
            {
                writer.WritePropertyName("compressionLevel");
                writer.WriteStringValue(CompressionLevel.Value.ToString());
            }
            if (Optional.IsDefined(QuoteChar))
            {
                writer.WritePropertyName("quoteChar");
                writer.WriteObjectValue(QuoteChar);
            }
            if (Optional.IsDefined(EscapeChar))
            {
                writer.WritePropertyName("escapeChar");
                writer.WriteObjectValue(EscapeChar);
            }
            if (Optional.IsDefined(FirstRowAsHeader))
            {
                writer.WritePropertyName("firstRowAsHeader");
                writer.WriteObjectValue(FirstRowAsHeader);
            }
            if (Optional.IsDefined(NullValue))
            {
                writer.WritePropertyName("nullValue");
                writer.WriteObjectValue(NullValue);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static DelimitedTextDataset DeserializeDelimitedTextDataset(JsonElement element)
        {
            string type = default;
            Optional<string> description = default;
            Optional<object> structure = default;
            Optional<object> schema = default;
            LinkedServiceReference linkedServiceName = default;
            Optional<IDictionary<string, ParameterSpecification>> parameters = default;
            Optional<IList<object>> annotations = default;
            Optional<DatasetFolder> folder = default;
            Optional<DatasetLocation> location = default;
            Optional<object> columnDelimiter = default;
            Optional<object> rowDelimiter = default;
            Optional<object> encodingName = default;
            Optional<DelimitedTextCompressionCodec> compressionCodec = default;
            Optional<DatasetCompressionLevel> compressionLevel = default;
            Optional<object> quoteChar = default;
            Optional<object> escapeChar = default;
            Optional<object> firstRowAsHeader = default;
            Optional<object> nullValue = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("structure"))
                {
                    structure = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("schema"))
                {
                    schema = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("linkedServiceName"))
                {
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                        }
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("folder"))
                {
                    folder = DatasetFolder.DeserializeDatasetFolder(property.Value);
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("location"))
                        {
                            location = DatasetLocation.DeserializeDatasetLocation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("columnDelimiter"))
                        {
                            columnDelimiter = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("rowDelimiter"))
                        {
                            rowDelimiter = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("encodingName"))
                        {
                            encodingName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("compressionCodec"))
                        {
                            compressionCodec = new DelimitedTextCompressionCodec(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("compressionLevel"))
                        {
                            compressionLevel = new DatasetCompressionLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("quoteChar"))
                        {
                            quoteChar = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("escapeChar"))
                        {
                            escapeChar = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("firstRowAsHeader"))
                        {
                            firstRowAsHeader = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("nullValue"))
                        {
                            nullValue = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    additionalPropertiesDictionary.Add(property.Name, null);
                }
                else
                {
                    additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
                }
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DelimitedTextDataset(type, description.HasValue ? description.Value : null, structure.HasValue ? structure.Value : null, schema.HasValue ? schema.Value : null, linkedServiceName, new ChangeTrackingDictionary<string, ParameterSpecification>(parameters), new ChangeTrackingList<object>(annotations), folder.HasValue ? folder.Value : null, additionalProperties, location.HasValue ? location.Value : null, columnDelimiter.HasValue ? columnDelimiter.Value : null, rowDelimiter.HasValue ? rowDelimiter.Value : null, encodingName.HasValue ? encodingName.Value : null, compressionCodec.HasValue ? compressionCodec.Value : (DelimitedTextCompressionCodec?)null, compressionLevel.HasValue ? compressionLevel.Value : (DatasetCompressionLevel?)null, quoteChar.HasValue ? quoteChar.Value : null, escapeChar.HasValue ? escapeChar.Value : null, firstRowAsHeader.HasValue ? firstRowAsHeader.Value : null, nullValue.HasValue ? nullValue.Value : null);
        }
    }
}
