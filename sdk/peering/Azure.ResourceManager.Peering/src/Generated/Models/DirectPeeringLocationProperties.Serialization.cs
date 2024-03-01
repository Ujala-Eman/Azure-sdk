// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Peering;

namespace Azure.ResourceManager.Peering.Models
{
    public partial class DirectPeeringLocationProperties : IUtf8JsonSerializable, IJsonModel<DirectPeeringLocationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DirectPeeringLocationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DirectPeeringLocationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DirectPeeringLocationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DirectPeeringLocationProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(PeeringFacilities is ChangeTrackingList<DirectPeeringFacility> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("peeringFacilities"u8);
                writer.WriteStartArray();
                foreach (var item in PeeringFacilities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(BandwidthOffers is ChangeTrackingList<PeeringBandwidthOffer> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("bandwidthOffers"u8);
                writer.WriteStartArray();
                foreach (var item in BandwidthOffers)
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

        DirectPeeringLocationProperties IJsonModel<DirectPeeringLocationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DirectPeeringLocationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DirectPeeringLocationProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDirectPeeringLocationProperties(document.RootElement, options);
        }

        internal static DirectPeeringLocationProperties DeserializeDirectPeeringLocationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<DirectPeeringFacility> peeringFacilities = default;
            IList<PeeringBandwidthOffer> bandwidthOffers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("peeringFacilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DirectPeeringFacility> array = new List<DirectPeeringFacility>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DirectPeeringFacility.DeserializeDirectPeeringFacility(item, options));
                    }
                    peeringFacilities = array;
                    continue;
                }
                if (property.NameEquals("bandwidthOffers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PeeringBandwidthOffer> array = new List<PeeringBandwidthOffer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PeeringBandwidthOffer.DeserializePeeringBandwidthOffer(item, options));
                    }
                    bandwidthOffers = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DirectPeeringLocationProperties(peeringFacilities ?? new ChangeTrackingList<DirectPeeringFacility>(), bandwidthOffers ?? new ChangeTrackingList<PeeringBandwidthOffer>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DirectPeeringLocationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DirectPeeringLocationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DirectPeeringLocationProperties)} does not support '{options.Format}' format.");
            }
        }

        DirectPeeringLocationProperties IPersistableModel<DirectPeeringLocationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DirectPeeringLocationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDirectPeeringLocationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DirectPeeringLocationProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DirectPeeringLocationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
