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
    internal partial class StorageError : IUtf8JsonSerializable, IJsonModel<StorageError>, IXmlSerializable, IModel<StorageError>
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "StorageError");
            if (Optional.IsDefined(Error))
            {
                writer.WriteObjectValue(Error, "error");
            }
            writer.WriteEndElement();
        }

        internal static StorageError DeserializeStorageError(XElement element, ModelReaderWriterOptions options = null)
        {
            StorageErrorError error = default;
            if (element.Element("error") is XElement errorElement)
            {
                error = StorageErrorError.DeserializeStorageErrorError(errorElement);
            }
            return new StorageError(error, default);
        }

        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageError>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<StorageError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
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

        StorageError IJsonModel<StorageError>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageError)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageError(document.RootElement, options);
        }

        internal static StorageError DeserializeStorageError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StorageErrorError> error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = StorageErrorError.DeserializeStorageErrorError(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageError(error.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<StorageError>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageError)} does not support '{options.Format}' format.");
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

        StorageError IModel<StorageError>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageError)} does not support '{options.Format}' format.");
            }

            if (data.ToMemory().Span.StartsWith("{"u8))
            {
                using JsonDocument document = JsonDocument.Parse(data);
                return DeserializeStorageError(document.RootElement, options);
            }
            else
            {
                return DeserializeStorageError(XElement.Load(data.ToStream()), options);
            }
        }

        ModelReaderWriterFormat IModel<StorageError>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Xml;
    }
}
