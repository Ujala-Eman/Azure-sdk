// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class ContainerHostBatchBindMountEntry : IUtf8JsonSerializable, IJsonModel<ContainerHostBatchBindMountEntry>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerHostBatchBindMountEntry>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerHostBatchBindMountEntry>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerHostBatchBindMountEntry>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerHostBatchBindMountEntry)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source.Value.ToString());
            }
            if (Optional.IsDefined(IsReadOnly))
            {
                writer.WritePropertyName("isReadOnly"u8);
                writer.WriteBooleanValue(IsReadOnly.Value);
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

        ContainerHostBatchBindMountEntry IJsonModel<ContainerHostBatchBindMountEntry>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerHostBatchBindMountEntry>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerHostBatchBindMountEntry)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerHostBatchBindMountEntry(document.RootElement, options);
        }

        internal static ContainerHostBatchBindMountEntry DeserializeContainerHostBatchBindMountEntry(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerHostDataPath? source = default;
            bool? isReadOnly = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    source = new ContainerHostDataPath(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isReadOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isReadOnly = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerHostBatchBindMountEntry(source, isReadOnly, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerHostBatchBindMountEntry>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerHostBatchBindMountEntry>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerHostBatchBindMountEntry)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerHostBatchBindMountEntry IPersistableModel<ContainerHostBatchBindMountEntry>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerHostBatchBindMountEntry>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerHostBatchBindMountEntry(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerHostBatchBindMountEntry)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerHostBatchBindMountEntry>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ContainerHostBatchBindMountEntry FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeContainerHostBatchBindMountEntry(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
