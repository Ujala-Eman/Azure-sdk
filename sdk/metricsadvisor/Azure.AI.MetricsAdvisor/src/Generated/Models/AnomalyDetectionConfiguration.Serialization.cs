// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class AnomalyDetectionConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("metricId");
            writer.WriteStringValue(MetricId);
            writer.WritePropertyName("wholeMetricConfiguration");
            writer.WriteObjectValue(WholeSeriesDetectionConditions);
            if (Optional.IsCollectionDefined(SeriesGroupDetectionConditions))
            {
                writer.WritePropertyName("dimensionGroupOverrideConfigurations");
                writer.WriteStartArray();
                foreach (var item in SeriesGroupDetectionConditions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SeriesDetectionConditions))
            {
                writer.WritePropertyName("seriesOverrideConfigurations");
                writer.WriteStartArray();
                foreach (var item in SeriesDetectionConditions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AnomalyDetectionConfiguration DeserializeAnomalyDetectionConfiguration(JsonElement element)
        {
            Optional<string> anomalyDetectionConfigurationId = default;
            string name = default;
            Optional<string> description = default;
            string metricId = default;
            MetricWholeSeriesDetectionCondition wholeMetricConfiguration = default;
            Optional<IList<MetricSeriesGroupDetectionCondition>> dimensionGroupOverrideConfigurations = default;
            Optional<IList<MetricSingleSeriesDetectionCondition>> seriesOverrideConfigurations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("anomalyDetectionConfigurationId"))
                {
                    anomalyDetectionConfigurationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricId"))
                {
                    metricId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("wholeMetricConfiguration"))
                {
                    wholeMetricConfiguration = MetricWholeSeriesDetectionCondition.DeserializeMetricWholeSeriesDetectionCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("dimensionGroupOverrideConfigurations"))
                {
                    List<MetricSeriesGroupDetectionCondition> array = new List<MetricSeriesGroupDetectionCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricSeriesGroupDetectionCondition.DeserializeMetricSeriesGroupDetectionCondition(item));
                    }
                    dimensionGroupOverrideConfigurations = array;
                    continue;
                }
                if (property.NameEquals("seriesOverrideConfigurations"))
                {
                    List<MetricSingleSeriesDetectionCondition> array = new List<MetricSingleSeriesDetectionCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricSingleSeriesDetectionCondition.DeserializeMetricSingleSeriesDetectionCondition(item));
                    }
                    seriesOverrideConfigurations = array;
                    continue;
                }
            }
            return new AnomalyDetectionConfiguration(anomalyDetectionConfigurationId.Value, name, description.Value, metricId, wholeMetricConfiguration, Optional.ToList(dimensionGroupOverrideConfigurations), Optional.ToList(seriesOverrideConfigurations));
        }
    }
}
