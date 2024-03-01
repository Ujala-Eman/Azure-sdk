// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EnergyServices;

namespace Azure.ResourceManager.EnergyServices.Models
{
    public partial class DataPartitionsListResult : IUtf8JsonSerializable, IJsonModel<DataPartitionsListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataPartitionsListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataPartitionsListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataPartitionsListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataPartitionsListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(DataPartitionInfo is ChangeTrackingList<DataPartition> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("dataPartitionInfo"u8);
                writer.WriteStartArray();
                foreach (var item in DataPartitionInfo)
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

        DataPartitionsListResult IJsonModel<DataPartitionsListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataPartitionsListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataPartitionsListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataPartitionsListResult(document.RootElement, options);
        }

        internal static DataPartitionsListResult DeserializeDataPartitionsListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DataPartition> dataPartitionInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataPartitionInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataPartition> array = new List<DataPartition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataPartition.DeserializeDataPartition(item, options));
                    }
                    dataPartitionInfo = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataPartitionsListResult(dataPartitionInfo ?? new ChangeTrackingList<DataPartition>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataPartitionsListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataPartitionsListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataPartitionsListResult)} does not support '{options.Format}' format.");
            }
        }

        DataPartitionsListResult IPersistableModel<DataPartitionsListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataPartitionsListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataPartitionsListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataPartitionsListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataPartitionsListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
