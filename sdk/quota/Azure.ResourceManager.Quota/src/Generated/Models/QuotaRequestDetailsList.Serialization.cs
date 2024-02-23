// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Quota;

namespace Azure.ResourceManager.Quota.Models
{
    internal partial class QuotaRequestDetailsList : IUtf8JsonSerializable, IJsonModel<QuotaRequestDetailsList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QuotaRequestDetailsList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<QuotaRequestDetailsList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaRequestDetailsList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QuotaRequestDetailsList)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Value is ChangeTrackingList<QuotaRequestDetailData> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (NextLink != null)
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        QuotaRequestDetailsList IJsonModel<QuotaRequestDetailsList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaRequestDetailsList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QuotaRequestDetailsList)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQuotaRequestDetailsList(document.RootElement, options);
        }

        internal static QuotaRequestDetailsList DeserializeQuotaRequestDetailsList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<QuotaRequestDetailData>> value = default;
            Optional<string> nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QuotaRequestDetailData> array = new List<QuotaRequestDetailData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QuotaRequestDetailData.DeserializeQuotaRequestDetailData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new QuotaRequestDetailsList(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QuotaRequestDetailsList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaRequestDetailsList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(QuotaRequestDetailsList)} does not support '{options.Format}' format.");
            }
        }

        QuotaRequestDetailsList IPersistableModel<QuotaRequestDetailsList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaRequestDetailsList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQuotaRequestDetailsList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QuotaRequestDetailsList)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<QuotaRequestDetailsList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
