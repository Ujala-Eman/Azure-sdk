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

namespace Azure.ResourceManager.RecoveryServices.Models
{
    internal partial class CapabilitiesResultProperties : IUtf8JsonSerializable, IJsonModel<CapabilitiesResultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CapabilitiesResultProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CapabilitiesResultProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<CapabilitiesResultProperties>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<CapabilitiesResultProperties>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DnsZones))
            {
                writer.WritePropertyName("dnsZones"u8);
                writer.WriteStartArray();
                foreach (var item in DnsZones)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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

        CapabilitiesResultProperties IJsonModel<CapabilitiesResultProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CapabilitiesResultProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCapabilitiesResultProperties(document.RootElement, options);
        }

        internal static CapabilitiesResultProperties DeserializeCapabilitiesResultProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<DnsZoneResult>> dnsZones = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dnsZones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DnsZoneResult> array = new List<DnsZoneResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DnsZoneResult.DeserializeDnsZoneResult(item));
                    }
                    dnsZones = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CapabilitiesResultProperties(Optional.ToList(dnsZones), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CapabilitiesResultProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CapabilitiesResultProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        CapabilitiesResultProperties IPersistableModel<CapabilitiesResultProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CapabilitiesResultProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeCapabilitiesResultProperties(document.RootElement, options);
        }

        string IPersistableModel<CapabilitiesResultProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
