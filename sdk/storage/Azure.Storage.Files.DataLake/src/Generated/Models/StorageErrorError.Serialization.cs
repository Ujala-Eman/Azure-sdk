// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Files.DataLake.Models
{
    internal partial class StorageErrorError : IUtf8JsonSerializable, IJsonModel<StorageErrorError>, IXmlSerializable, IModel<StorageErrorError>
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "StorageErrorError");
            if (Optional.IsDefined(Code))
            {
                writer.WriteStartElement("Code");
                writer.WriteValue(Code);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(Message))
            {
                writer.WriteStartElement("Message");
                writer.WriteValue(Message);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        internal static StorageErrorError DeserializeStorageErrorError(XElement element, ModelReaderWriterOptions options = null)
        {
            string code = default;
            string message = default;
            if (element.Element("Code") is XElement codeElement)
            {
                code = (string)codeElement;
            }
            if (element.Element("Message") is XElement messageElement)
            {
                message = (string)messageElement;
            }
            return new StorageErrorError(code, message, default);
        }

        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageErrorError>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<StorageErrorError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Code))
            {
                writer.WritePropertyName("Code"u8);
                writer.WriteStringValue(Code);
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("Message"u8);
                writer.WriteStringValue(Message);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        StorageErrorError IJsonModel<StorageErrorError>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageErrorError)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageErrorError(document.RootElement, options);
        }

        internal static StorageErrorError DeserializeStorageErrorError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> code = default;
            Optional<string> message = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageErrorError(code.Value, message.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<StorageErrorError>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageErrorError)} does not support '{options.Format}' format.");
            }

            if (options.Format == ModelReaderWriterFormat.Json)
            {
                return ModelReaderWriter.Write(this, options);
            }
            else
            {
                using MemoryStream stream = new MemoryStream();
                using XmlWriter writer = XmlWriter.Create(stream);
                ((IXmlSerializable)this).Write(writer, null);
                writer.Flush();
                if (stream.Position > int.MaxValue)
                {
                    return BinaryData.FromStream(stream);
                }
                else
                {
                    return new BinaryData(stream.GetBuffer().AsMemory(0, (int)stream.Position));
                }
            }
        }

        StorageErrorError IModel<StorageErrorError>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageErrorError)} does not support '{options.Format}' format.");
            }

            if (data.ToMemory().Span.StartsWith("{"u8))
            {
                using JsonDocument document = JsonDocument.Parse(data);
                return DeserializeStorageErrorError(document.RootElement, options);
            }
            else
            {
                return DeserializeStorageErrorError(XElement.Load(data.ToStream()), options);
            }
        }

        ModelReaderWriterFormat IModel<StorageErrorError>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Xml;
    }
}
