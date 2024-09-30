// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Nginx.Models
{
    public partial class WebApplicationFirewallPackage : IUtf8JsonSerializable, IJsonModel<WebApplicationFirewallPackage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebApplicationFirewallPackage>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WebApplicationFirewallPackage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationFirewallPackage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebApplicationFirewallPackage)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("version"u8);
            writer.WriteStringValue(Version);
            writer.WritePropertyName("revisionDatetime"u8);
            writer.WriteStringValue(RevisionDatetime, "O");
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

        WebApplicationFirewallPackage IJsonModel<WebApplicationFirewallPackage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationFirewallPackage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebApplicationFirewallPackage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebApplicationFirewallPackage(document.RootElement, options);
        }

        internal static WebApplicationFirewallPackage DeserializeWebApplicationFirewallPackage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string version = default;
            DateTimeOffset revisionDatetime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("revisionDatetime"u8))
                {
                    revisionDatetime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WebApplicationFirewallPackage(version, revisionDatetime, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebApplicationFirewallPackage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationFirewallPackage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebApplicationFirewallPackage)} does not support writing '{options.Format}' format.");
            }
        }

        WebApplicationFirewallPackage IPersistableModel<WebApplicationFirewallPackage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationFirewallPackage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebApplicationFirewallPackage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebApplicationFirewallPackage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebApplicationFirewallPackage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
