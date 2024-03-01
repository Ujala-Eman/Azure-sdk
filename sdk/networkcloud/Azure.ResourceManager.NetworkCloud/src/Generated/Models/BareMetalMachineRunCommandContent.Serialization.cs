// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class BareMetalMachineRunCommandContent : IUtf8JsonSerializable, IJsonModel<BareMetalMachineRunCommandContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BareMetalMachineRunCommandContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BareMetalMachineRunCommandContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BareMetalMachineRunCommandContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BareMetalMachineRunCommandContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Arguments is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("arguments"u8);
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("limitTimeSeconds"u8);
            writer.WriteNumberValue(LimitTimeSeconds);
            writer.WritePropertyName("script"u8);
            writer.WriteStringValue(Script);
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

        BareMetalMachineRunCommandContent IJsonModel<BareMetalMachineRunCommandContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BareMetalMachineRunCommandContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BareMetalMachineRunCommandContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBareMetalMachineRunCommandContent(document.RootElement, options);
        }

        internal static BareMetalMachineRunCommandContent DeserializeBareMetalMachineRunCommandContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> arguments = default;
            long limitTimeSeconds = default;
            string script = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("arguments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    arguments = array;
                    continue;
                }
                if (property.NameEquals("limitTimeSeconds"u8))
                {
                    limitTimeSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("script"u8))
                {
                    script = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BareMetalMachineRunCommandContent(arguments ?? new ChangeTrackingList<string>(), limitTimeSeconds, script, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BareMetalMachineRunCommandContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BareMetalMachineRunCommandContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BareMetalMachineRunCommandContent)} does not support '{options.Format}' format.");
            }
        }

        BareMetalMachineRunCommandContent IPersistableModel<BareMetalMachineRunCommandContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BareMetalMachineRunCommandContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBareMetalMachineRunCommandContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BareMetalMachineRunCommandContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BareMetalMachineRunCommandContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
