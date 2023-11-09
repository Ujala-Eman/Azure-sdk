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
    internal partial class GetEvents : IUtf8JsonSerializable, IJsonModel<GetEvents>
    {
        void IJsonModel<GetEvents>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
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
            if (Optional.IsCollectionDefined(ProjectedProperties))
            {
                writer.WritePropertyName("projectedProperties"u8);
                writer.WriteStartArray();
                foreach (var item in ProjectedProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Take))
            {
                writer.WritePropertyName("take"u8);
                writer.WriteNumberValue(Take.Value);
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

        GetEvents IJsonModel<GetEvents>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(GetEvents)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGetEvents(document.RootElement, options);
        }

        internal static GetEvents DeserializeGetEvents(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<object> timeSeriesId = default;
            DateTimeRange searchSpan = default;
            Optional<TimeSeriesExpression> filter = default;
            Optional<IList<TimeSeriesInsightsEventProperty>> projectedProperties = default;
            Optional<int> take = default;
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
                if (property.NameEquals("projectedProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TimeSeriesInsightsEventProperty> array = new List<TimeSeriesInsightsEventProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimeSeriesInsightsEventProperty.DeserializeTimeSeriesInsightsEventProperty(item));
                    }
                    projectedProperties = array;
                    continue;
                }
                if (property.NameEquals("take"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    take = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GetEvents(timeSeriesId, searchSpan, filter.Value, Optional.ToList(projectedProperties), Optional.ToNullable(take), serializedAdditionalRawData);
        }

        BinaryData IModel<GetEvents>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(GetEvents)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        GetEvents IModel<GetEvents>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(GetEvents)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeGetEvents(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<GetEvents>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
