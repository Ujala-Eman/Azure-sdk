// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class AggregateSeries : IUtf8JsonSerializable, IJsonModel<AggregateSeries>
    {
        void IJsonModel<AggregateSeries>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("timeSeriesId"u8);
            writer.WriteStartArray();
            foreach (var item in TimeSeriesIdInternal)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("searchSpan"u8);
            writer.WriteObjectValue(SearchSpan);
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteObjectValue(Filter);
            }
            writer.WritePropertyName("interval"u8);
            writer.WriteStringValue(Interval, "P");
            if (Optional.IsCollectionDefined(ProjectedVariables))
            {
                writer.WritePropertyName("projectedVariables"u8);
                writer.WriteStartArray();
                foreach (var item in ProjectedVariables)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(InlineVariables))
            {
                writer.WritePropertyName("inlineVariables"u8);
                writer.WriteStartObject();
                foreach (var item in InlineVariables)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        AggregateSeries IJsonModel<AggregateSeries>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AggregateSeries)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAggregateSeries(document.RootElement, options);
        }

        internal static AggregateSeries DeserializeAggregateSeries(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<object> timeSeriesId = default;
            DateTimeRange searchSpan = default;
            Optional<TimeSeriesExpression> filter = default;
            TimeSpan interval = default;
            Optional<IList<string>> projectedVariables = default;
            Optional<IDictionary<string, TimeSeriesVariable>> inlineVariables = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeSeriesId"u8))
                {
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    timeSeriesId = array;
                    continue;
                }
                if (property.NameEquals("searchSpan"u8))
                {
                    searchSpan = DateTimeRange.DeserializeDateTimeRange(property.Value);
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filter = TimeSeriesExpression.DeserializeTimeSeriesExpression(property.Value);
                    continue;
                }
                if (property.NameEquals("interval"u8))
                {
                    interval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("projectedVariables"u8))
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
                    projectedVariables = array;
                    continue;
                }
                if (property.NameEquals("inlineVariables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, TimeSeriesVariable> dictionary = new Dictionary<string, TimeSeriesVariable>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, TimeSeriesVariable.DeserializeTimeSeriesVariable(property0.Value));
                    }
                    inlineVariables = dictionary;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AggregateSeries(timeSeriesId, searchSpan, filter.Value, interval, Optional.ToList(projectedVariables), Optional.ToDictionary(inlineVariables), serializedAdditionalRawData);
        }

        BinaryData IModel<AggregateSeries>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AggregateSeries)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AggregateSeries IModel<AggregateSeries>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AggregateSeries)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAggregateSeries(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<AggregateSeries>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
