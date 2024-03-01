// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class PerfCounterDataSource : IUtf8JsonSerializable, IJsonModel<PerfCounterDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PerfCounterDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PerfCounterDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PerfCounterDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PerfCounterDataSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Streams is ChangeTrackingList<PerfCounterDataSourceStream> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("streams"u8);
                writer.WriteStartArray();
                foreach (var item in Streams)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (SamplingFrequencyInSeconds.HasValue)
            {
                writer.WritePropertyName("samplingFrequencyInSeconds"u8);
                writer.WriteNumberValue(SamplingFrequencyInSeconds.Value);
            }
            if (!(CounterSpecifiers is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("counterSpecifiers"u8);
                writer.WriteStartArray();
                foreach (var item in CounterSpecifiers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
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

        PerfCounterDataSource IJsonModel<PerfCounterDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PerfCounterDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PerfCounterDataSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePerfCounterDataSource(document.RootElement, options);
        }

        internal static PerfCounterDataSource DeserializePerfCounterDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<PerfCounterDataSourceStream> streams = default;
            int? samplingFrequencyInSeconds = default;
            IList<string> counterSpecifiers = default;
            string name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streams"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PerfCounterDataSourceStream> array = new List<PerfCounterDataSourceStream>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new PerfCounterDataSourceStream(item.GetString()));
                    }
                    streams = array;
                    continue;
                }
                if (property.NameEquals("samplingFrequencyInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    samplingFrequencyInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("counterSpecifiers"u8))
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
                    counterSpecifiers = array;
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PerfCounterDataSource(streams ?? new ChangeTrackingList<PerfCounterDataSourceStream>(), samplingFrequencyInSeconds, counterSpecifiers ?? new ChangeTrackingList<string>(), name, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PerfCounterDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PerfCounterDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PerfCounterDataSource)} does not support '{options.Format}' format.");
            }
        }

        PerfCounterDataSource IPersistableModel<PerfCounterDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PerfCounterDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePerfCounterDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PerfCounterDataSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PerfCounterDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
