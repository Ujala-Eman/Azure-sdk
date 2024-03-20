// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class PinholeTimeouts : IUtf8JsonSerializable, IJsonModel<PinholeTimeouts>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PinholeTimeouts>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PinholeTimeouts>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PinholeTimeouts>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PinholeTimeouts)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Tcp))
            {
                writer.WritePropertyName("tcp"u8);
                writer.WriteNumberValue(Tcp.Value);
            }
            if (Optional.IsDefined(Udp))
            {
                writer.WritePropertyName("udp"u8);
                writer.WriteNumberValue(Udp.Value);
            }
            if (Optional.IsDefined(Icmp))
            {
                writer.WritePropertyName("icmp"u8);
                writer.WriteNumberValue(Icmp.Value);
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

        PinholeTimeouts IJsonModel<PinholeTimeouts>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PinholeTimeouts>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PinholeTimeouts)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePinholeTimeouts(document.RootElement, options);
        }

        internal static PinholeTimeouts DeserializePinholeTimeouts(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? tcp = default;
            int? udp = default;
            int? icmp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tcp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tcp = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("udp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    udp = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("icmp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    icmp = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PinholeTimeouts(tcp, udp, icmp, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PinholeTimeouts>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PinholeTimeouts>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PinholeTimeouts)} does not support '{options.Format}' format.");
            }
        }

        PinholeTimeouts IPersistableModel<PinholeTimeouts>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PinholeTimeouts>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePinholeTimeouts(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PinholeTimeouts)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PinholeTimeouts>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
