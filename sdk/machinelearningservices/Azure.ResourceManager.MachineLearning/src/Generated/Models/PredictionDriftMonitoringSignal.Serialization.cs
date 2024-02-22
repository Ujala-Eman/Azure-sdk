// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class PredictionDriftMonitoringSignal : IUtf8JsonSerializable, IJsonModel<PredictionDriftMonitoringSignal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PredictionDriftMonitoringSignal>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PredictionDriftMonitoringSignal>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionDriftMonitoringSignal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PredictionDriftMonitoringSignal)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("metricThresholds"u8);
            writer.WriteStartArray();
            foreach (var item in MetricThresholds)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("modelType"u8);
            writer.WriteStringValue(ModelType.ToString());
            writer.WritePropertyName("productionData"u8);
            writer.WriteObjectValue(ProductionData);
            writer.WritePropertyName("referenceData"u8);
            writer.WriteObjectValue(ReferenceData);
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            writer.WritePropertyName("signalType"u8);
            writer.WriteStringValue(SignalType.ToString());
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

        PredictionDriftMonitoringSignal IJsonModel<PredictionDriftMonitoringSignal>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionDriftMonitoringSignal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PredictionDriftMonitoringSignal)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePredictionDriftMonitoringSignal(document.RootElement, options);
        }

        internal static PredictionDriftMonitoringSignal DeserializePredictionDriftMonitoringSignal(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<PredictionDriftMetricThresholdBase> metricThresholds = default;
            MonitoringModelType modelType = default;
            MonitoringInputDataBase productionData = default;
            MonitoringInputDataBase referenceData = default;
            Optional<MonitoringNotificationMode> mode = default;
            Optional<IDictionary<string, string>> properties = default;
            MonitoringSignalType signalType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricThresholds"u8))
                {
                    List<PredictionDriftMetricThresholdBase> array = new List<PredictionDriftMetricThresholdBase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PredictionDriftMetricThresholdBase.DeserializePredictionDriftMetricThresholdBase(item, options));
                    }
                    metricThresholds = array;
                    continue;
                }
                if (property.NameEquals("modelType"u8))
                {
                    modelType = new MonitoringModelType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("productionData"u8))
                {
                    productionData = MonitoringInputDataBase.DeserializeMonitoringInputDataBase(property.Value, options);
                    continue;
                }
                if (property.NameEquals("referenceData"u8))
                {
                    referenceData = MonitoringInputDataBase.DeserializeMonitoringInputDataBase(property.Value, options);
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new MonitoringNotificationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("signalType"u8))
                {
                    signalType = new MonitoringSignalType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PredictionDriftMonitoringSignal(Optional.ToNullable(mode), Optional.ToDictionary(properties), signalType, serializedAdditionalRawData, metricThresholds, modelType, productionData, referenceData);
        }

        BinaryData IPersistableModel<PredictionDriftMonitoringSignal>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionDriftMonitoringSignal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PredictionDriftMonitoringSignal)} does not support '{options.Format}' format.");
            }
        }

        PredictionDriftMonitoringSignal IPersistableModel<PredictionDriftMonitoringSignal>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionDriftMonitoringSignal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePredictionDriftMonitoringSignal(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PredictionDriftMonitoringSignal)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PredictionDriftMonitoringSignal>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
