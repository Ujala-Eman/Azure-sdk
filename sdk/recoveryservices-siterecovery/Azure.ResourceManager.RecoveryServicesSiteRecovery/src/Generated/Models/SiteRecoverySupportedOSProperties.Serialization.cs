// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    internal partial class SiteRecoverySupportedOSProperties : IUtf8JsonSerializable, IJsonModel<SiteRecoverySupportedOSProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoverySupportedOSProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoverySupportedOSProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoverySupportedOSProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoverySupportedOSProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(SupportedOSList is ChangeTrackingList<SiteRecoverySupportedOSProperty> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("supportedOsList"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedOSList)
                {
                    writer.WriteObjectValue(item);
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

        SiteRecoverySupportedOSProperties IJsonModel<SiteRecoverySupportedOSProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoverySupportedOSProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoverySupportedOSProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoverySupportedOSProperties(document.RootElement, options);
        }

        internal static SiteRecoverySupportedOSProperties DeserializeSiteRecoverySupportedOSProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SiteRecoverySupportedOSProperty>> supportedOSList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("supportedOsList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoverySupportedOSProperty> array = new List<SiteRecoverySupportedOSProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoverySupportedOSProperty.DeserializeSiteRecoverySupportedOSProperty(item, options));
                    }
                    supportedOSList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoverySupportedOSProperties(Optional.ToList(supportedOSList), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoverySupportedOSProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoverySupportedOSProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoverySupportedOSProperties)} does not support '{options.Format}' format.");
            }
        }

        SiteRecoverySupportedOSProperties IPersistableModel<SiteRecoverySupportedOSProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoverySupportedOSProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoverySupportedOSProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoverySupportedOSProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoverySupportedOSProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
