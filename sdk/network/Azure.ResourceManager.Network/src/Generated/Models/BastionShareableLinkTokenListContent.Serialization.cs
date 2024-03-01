// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    public partial class BastionShareableLinkTokenListContent : IUtf8JsonSerializable, IJsonModel<BastionShareableLinkTokenListContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BastionShareableLinkTokenListContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BastionShareableLinkTokenListContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BastionShareableLinkTokenListContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BastionShareableLinkTokenListContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tokens is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tokens"u8);
                writer.WriteStartArray();
                foreach (var item in Tokens)
                {
                    writer.WriteStringValue(item);
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

        BastionShareableLinkTokenListContent IJsonModel<BastionShareableLinkTokenListContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BastionShareableLinkTokenListContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BastionShareableLinkTokenListContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBastionShareableLinkTokenListContent(document.RootElement, options);
        }

        internal static BastionShareableLinkTokenListContent DeserializeBastionShareableLinkTokenListContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> tokens = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tokens"u8))
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
                    tokens = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BastionShareableLinkTokenListContent(tokens ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BastionShareableLinkTokenListContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BastionShareableLinkTokenListContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BastionShareableLinkTokenListContent)} does not support '{options.Format}' format.");
            }
        }

        BastionShareableLinkTokenListContent IPersistableModel<BastionShareableLinkTokenListContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BastionShareableLinkTokenListContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBastionShareableLinkTokenListContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BastionShareableLinkTokenListContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BastionShareableLinkTokenListContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
