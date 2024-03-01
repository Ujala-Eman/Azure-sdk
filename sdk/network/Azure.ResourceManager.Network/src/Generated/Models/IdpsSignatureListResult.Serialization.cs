// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class IdpsSignatureListResult : IUtf8JsonSerializable, IJsonModel<IdpsSignatureListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IdpsSignatureListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IdpsSignatureListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IdpsSignatureListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IdpsSignatureListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (MatchingRecordsCount.HasValue)
            {
                writer.WritePropertyName("matchingRecordsCount"u8);
                writer.WriteNumberValue(MatchingRecordsCount.Value);
            }
            if (!(Signatures is ChangeTrackingList<IdpsSignatureResult> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("signatures"u8);
                writer.WriteStartArray();
                foreach (var item in Signatures)
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

        IdpsSignatureListResult IJsonModel<IdpsSignatureListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IdpsSignatureListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IdpsSignatureListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIdpsSignatureListResult(document.RootElement, options);
        }

        internal static IdpsSignatureListResult DeserializeIdpsSignatureListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? matchingRecordsCount = default;
            IReadOnlyList<IdpsSignatureResult> signatures = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("matchingRecordsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    matchingRecordsCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("signatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IdpsSignatureResult> array = new List<IdpsSignatureResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IdpsSignatureResult.DeserializeIdpsSignatureResult(item, options));
                    }
                    signatures = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IdpsSignatureListResult(matchingRecordsCount, signatures ?? new ChangeTrackingList<IdpsSignatureResult>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IdpsSignatureListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IdpsSignatureListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IdpsSignatureListResult)} does not support '{options.Format}' format.");
            }
        }

        IdpsSignatureListResult IPersistableModel<IdpsSignatureListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IdpsSignatureListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIdpsSignatureListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IdpsSignatureListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IdpsSignatureListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
