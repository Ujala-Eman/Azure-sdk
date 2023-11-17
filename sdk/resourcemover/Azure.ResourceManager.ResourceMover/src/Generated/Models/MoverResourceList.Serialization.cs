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
using Azure.ResourceManager.ResourceMover;

namespace Azure.ResourceManager.ResourceMover.Models
{
    internal partial class MoverResourceList : IUtf8JsonSerializable, IJsonModel<MoverResourceList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MoverResourceList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MoverResourceList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MoverResourceList>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MoverResourceList>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
            }
            if (Optional.IsDefined(SummaryCollection))
            {
                if (SummaryCollection != null)
                {
                    writer.WritePropertyName("summaryCollection"u8);
                    writer.WriteObjectValue(SummaryCollection);
                }
                else
                {
                    writer.WriteNull("summaryCollection");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(TotalCount))
                {
                    writer.WritePropertyName("totalCount"u8);
                    writer.WriteNumberValue(TotalCount.Value);
                }
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

        MoverResourceList IJsonModel<MoverResourceList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MoverResourceList)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMoverResourceList(document.RootElement, options);
        }

        internal static MoverResourceList DeserializeMoverResourceList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MoverResourceData>> value = default;
            Optional<string> nextLink = default;
            Optional<MoverSummaryList> summaryCollection = default;
            Optional<long> totalCount = default;
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
                    List<MoverResourceData> array = new List<MoverResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MoverResourceData.DeserializeMoverResourceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("summaryCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        summaryCollection = null;
                        continue;
                    }
                    summaryCollection = MoverSummaryList.DeserializeMoverSummaryList(property.Value);
                    continue;
                }
                if (property.NameEquals("totalCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MoverResourceList(Optional.ToList(value), nextLink.Value, summaryCollection.Value, Optional.ToNullable(totalCount), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MoverResourceList>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MoverResourceList)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MoverResourceList IPersistableModel<MoverResourceList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MoverResourceList)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMoverResourceList(document.RootElement, options);
        }

        string IPersistableModel<MoverResourceList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
