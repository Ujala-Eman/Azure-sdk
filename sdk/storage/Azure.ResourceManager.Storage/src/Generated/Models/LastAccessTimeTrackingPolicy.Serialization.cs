// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class LastAccessTimeTrackingPolicy : IUtf8JsonSerializable, IJsonModel<LastAccessTimeTrackingPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LastAccessTimeTrackingPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LastAccessTimeTrackingPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LastAccessTimeTrackingPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LastAccessTimeTrackingPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("enable"u8);
            writer.WriteBooleanValue(IsEnabled);
            if (Name.HasValue)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name.Value.ToString());
            }
            if (TrackingGranularityInDays.HasValue)
            {
                writer.WritePropertyName("trackingGranularityInDays"u8);
                writer.WriteNumberValue(TrackingGranularityInDays.Value);
            }
            if (!(BlobType is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("blobType"u8);
                writer.WriteStartArray();
                foreach (var item in BlobType)
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

        LastAccessTimeTrackingPolicy IJsonModel<LastAccessTimeTrackingPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LastAccessTimeTrackingPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LastAccessTimeTrackingPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLastAccessTimeTrackingPolicy(document.RootElement, options);
        }

        internal static LastAccessTimeTrackingPolicy DeserializeLastAccessTimeTrackingPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool enable = default;
            LastAccessTimeTrackingPolicyName? name = default;
            int? trackingGranularityInDays = default;
            IList<string> blobType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enable"u8))
                {
                    enable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = new LastAccessTimeTrackingPolicyName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trackingGranularityInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trackingGranularityInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("blobType"u8))
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
                    blobType = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LastAccessTimeTrackingPolicy(enable, name, trackingGranularityInDays, blobType ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LastAccessTimeTrackingPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LastAccessTimeTrackingPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LastAccessTimeTrackingPolicy)} does not support '{options.Format}' format.");
            }
        }

        LastAccessTimeTrackingPolicy IPersistableModel<LastAccessTimeTrackingPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LastAccessTimeTrackingPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLastAccessTimeTrackingPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LastAccessTimeTrackingPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LastAccessTimeTrackingPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
