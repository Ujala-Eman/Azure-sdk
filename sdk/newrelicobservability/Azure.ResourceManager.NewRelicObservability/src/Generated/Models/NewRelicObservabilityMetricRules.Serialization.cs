// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.NewRelicObservability;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    public partial class NewRelicObservabilityMetricRules : IUtf8JsonSerializable, IJsonModel<NewRelicObservabilityMetricRules>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NewRelicObservabilityMetricRules>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NewRelicObservabilityMetricRules>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityMetricRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicObservabilityMetricRules)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (SendMetrics.HasValue)
            {
                writer.WritePropertyName("sendMetrics"u8);
                writer.WriteStringValue(SendMetrics.Value.ToString());
            }
            if (!(FilteringTags is ChangeTrackingList<NewRelicObservabilityFilteringTag> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("filteringTags"u8);
                writer.WriteStartArray();
                foreach (var item in FilteringTags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (UserEmail != null)
            {
                writer.WritePropertyName("userEmail"u8);
                writer.WriteStringValue(UserEmail);
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

        NewRelicObservabilityMetricRules IJsonModel<NewRelicObservabilityMetricRules>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityMetricRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicObservabilityMetricRules)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRelicObservabilityMetricRules(document.RootElement, options);
        }

        internal static NewRelicObservabilityMetricRules DeserializeNewRelicObservabilityMetricRules(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NewRelicObservabilitySendMetricsStatus? sendMetrics = default;
            IList<NewRelicObservabilityFilteringTag> filteringTags = default;
            string userEmail = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sendMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendMetrics = new NewRelicObservabilitySendMetricsStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("filteringTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NewRelicObservabilityFilteringTag> array = new List<NewRelicObservabilityFilteringTag>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NewRelicObservabilityFilteringTag.DeserializeNewRelicObservabilityFilteringTag(item, options));
                    }
                    filteringTags = array;
                    continue;
                }
                if (property.NameEquals("userEmail"u8))
                {
                    userEmail = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NewRelicObservabilityMetricRules(sendMetrics, filteringTags ?? new ChangeTrackingList<NewRelicObservabilityFilteringTag>(), userEmail, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NewRelicObservabilityMetricRules>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityMetricRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NewRelicObservabilityMetricRules)} does not support '{options.Format}' format.");
            }
        }

        NewRelicObservabilityMetricRules IPersistableModel<NewRelicObservabilityMetricRules>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityMetricRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNewRelicObservabilityMetricRules(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NewRelicObservabilityMetricRules)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NewRelicObservabilityMetricRules>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
