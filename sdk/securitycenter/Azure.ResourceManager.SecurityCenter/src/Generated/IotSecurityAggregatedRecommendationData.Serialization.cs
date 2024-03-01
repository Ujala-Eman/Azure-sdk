// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class IotSecurityAggregatedRecommendationData : IUtf8JsonSerializable, IJsonModel<IotSecurityAggregatedRecommendationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotSecurityAggregatedRecommendationData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IotSecurityAggregatedRecommendationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecurityAggregatedRecommendationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotSecurityAggregatedRecommendationData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (RecommendationName != null)
            {
                writer.WritePropertyName("recommendationName"u8);
                writer.WriteStringValue(RecommendationName);
            }
            if (options.Format != "W" && RecommendationDisplayName != null)
            {
                writer.WritePropertyName("recommendationDisplayName"u8);
                writer.WriteStringValue(RecommendationDisplayName);
            }
            if (options.Format != "W" && Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && RecommendationTypeId != null)
            {
                writer.WritePropertyName("recommendationTypeId"u8);
                writer.WriteStringValue(RecommendationTypeId);
            }
            if (options.Format != "W" && DetectedBy != null)
            {
                writer.WritePropertyName("detectedBy"u8);
                writer.WriteStringValue(DetectedBy);
            }
            if (options.Format != "W" && RemediationSteps != null)
            {
                writer.WritePropertyName("remediationSteps"u8);
                writer.WriteStringValue(RemediationSteps);
            }
            if (options.Format != "W" && ReportedSeverity.HasValue)
            {
                writer.WritePropertyName("reportedSeverity"u8);
                writer.WriteStringValue(ReportedSeverity.Value.ToString());
            }
            if (options.Format != "W" && HealthyDevices.HasValue)
            {
                writer.WritePropertyName("healthyDevices"u8);
                writer.WriteNumberValue(HealthyDevices.Value);
            }
            if (options.Format != "W" && UnhealthyDeviceCount.HasValue)
            {
                writer.WritePropertyName("unhealthyDeviceCount"u8);
                writer.WriteNumberValue(UnhealthyDeviceCount.Value);
            }
            if (options.Format != "W" && LogAnalyticsQuery != null)
            {
                writer.WritePropertyName("logAnalyticsQuery"u8);
                writer.WriteStringValue(LogAnalyticsQuery);
            }
            writer.WriteEndObject();
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

        IotSecurityAggregatedRecommendationData IJsonModel<IotSecurityAggregatedRecommendationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecurityAggregatedRecommendationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotSecurityAggregatedRecommendationData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotSecurityAggregatedRecommendationData(document.RootElement, options);
        }

        internal static IotSecurityAggregatedRecommendationData DeserializeIotSecurityAggregatedRecommendationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string recommendationName = default;
            string recommendationDisplayName = default;
            string description = default;
            string recommendationTypeId = default;
            string detectedBy = default;
            string remediationSteps = default;
            ReportedSeverity? reportedSeverity = default;
            long? healthyDevices = default;
            long? unhealthyDeviceCount = default;
            string logAnalyticsQuery = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("recommendationName"u8))
                        {
                            recommendationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("recommendationDisplayName"u8))
                        {
                            recommendationDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("recommendationTypeId"u8))
                        {
                            recommendationTypeId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("detectedBy"u8))
                        {
                            detectedBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("remediationSteps"u8))
                        {
                            remediationSteps = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reportedSeverity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reportedSeverity = new ReportedSeverity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("healthyDevices"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            healthyDevices = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("unhealthyDeviceCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            unhealthyDeviceCount = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("logAnalyticsQuery"u8))
                        {
                            logAnalyticsQuery = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotSecurityAggregatedRecommendationData(
                id,
                name,
                type,
                systemData,
                recommendationName,
                recommendationDisplayName,
                description,
                recommendationTypeId,
                detectedBy,
                remediationSteps,
                reportedSeverity,
                healthyDevices,
                unhealthyDeviceCount,
                logAnalyticsQuery,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotSecurityAggregatedRecommendationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecurityAggregatedRecommendationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotSecurityAggregatedRecommendationData)} does not support '{options.Format}' format.");
            }
        }

        IotSecurityAggregatedRecommendationData IPersistableModel<IotSecurityAggregatedRecommendationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecurityAggregatedRecommendationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotSecurityAggregatedRecommendationData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotSecurityAggregatedRecommendationData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotSecurityAggregatedRecommendationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
