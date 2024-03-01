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
    internal partial class UnknownMultiMetricCriteria : IUtf8JsonSerializable, IJsonModel<MultiMetricCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MultiMetricCriteria>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MultiMetricCriteria>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MultiMetricCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MultiMetricCriteria)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("criterionType"u8);
            writer.WriteStringValue(CriterionType.ToString());
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("metricName"u8);
            writer.WriteStringValue(MetricName);
            if (MetricNamespace != null)
            {
                writer.WritePropertyName("metricNamespace"u8);
                writer.WriteStringValue(MetricNamespace);
            }
            writer.WritePropertyName("timeAggregation"u8);
            writer.WriteStringValue(TimeAggregation.ToString());
            if (!(Dimensions is ChangeTrackingList<MetricDimension> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("dimensions"u8);
                writer.WriteStartArray();
                foreach (var item in Dimensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (SkipMetricValidation.HasValue)
            {
                writer.WritePropertyName("skipMetricValidation"u8);
                writer.WriteBooleanValue(SkipMetricValidation.Value);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        MultiMetricCriteria IJsonModel<MultiMetricCriteria>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MultiMetricCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MultiMetricCriteria)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMultiMetricCriteria(document.RootElement, options);
        }

        internal static UnknownMultiMetricCriteria DeserializeUnknownMultiMetricCriteria(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CriterionType criterionType = "Unknown";
            string name = default;
            string metricName = default;
            string metricNamespace = default;
            MetricCriteriaTimeAggregationType timeAggregation = default;
            IList<MetricDimension> dimensions = default;
            bool? skipMetricValidation = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("criterionType"u8))
                {
                    criterionType = new CriterionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricName"u8))
                {
                    metricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricNamespace"u8))
                {
                    metricNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeAggregation"u8))
                {
                    timeAggregation = new MetricCriteriaTimeAggregationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricDimension> array = new List<MetricDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricDimension.DeserializeMetricDimension(item, options));
                    }
                    dimensions = array;
                    continue;
                }
                if (property.NameEquals("skipMetricValidation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skipMetricValidation = property.Value.GetBoolean();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new UnknownMultiMetricCriteria(
                criterionType,
                name,
                metricName,
                metricNamespace,
                timeAggregation,
                dimensions ?? new ChangeTrackingList<MetricDimension>(),
                skipMetricValidation,
                additionalProperties);
        }

        BinaryData IPersistableModel<MultiMetricCriteria>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MultiMetricCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MultiMetricCriteria)} does not support '{options.Format}' format.");
            }
        }

        MultiMetricCriteria IPersistableModel<MultiMetricCriteria>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MultiMetricCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMultiMetricCriteria(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MultiMetricCriteria)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MultiMetricCriteria>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
