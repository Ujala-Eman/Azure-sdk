// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsTableResultStatistics : IUtf8JsonSerializable, IJsonModel<OperationalInsightsTableResultStatistics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationalInsightsTableResultStatistics>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OperationalInsightsTableResultStatistics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsTableResultStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsTableResultStatistics)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Progress))
            {
                writer.WritePropertyName("progress"u8);
                writer.WriteNumberValue(Progress.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IngestedRecords))
            {
                writer.WritePropertyName("ingestedRecords"u8);
                writer.WriteNumberValue(IngestedRecords.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ScannedGB))
            {
                writer.WritePropertyName("scannedGb"u8);
                writer.WriteNumberValue(ScannedGB.Value);
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
        }

        OperationalInsightsTableResultStatistics IJsonModel<OperationalInsightsTableResultStatistics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsTableResultStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsTableResultStatistics)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsTableResultStatistics(document.RootElement, options);
        }

        internal static OperationalInsightsTableResultStatistics DeserializeOperationalInsightsTableResultStatistics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float? progress = default;
            int? ingestedRecords = default;
            float? scannedGb = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("progress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    progress = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("ingestedRecords"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ingestedRecords = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scannedGb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scannedGb = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OperationalInsightsTableResultStatistics(progress, ingestedRecords, scannedGb, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Progress), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  progress: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Progress))
                {
                    builder.Append("  progress: ");
                    builder.AppendLine($"'{Progress.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IngestedRecords), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ingestedRecords: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IngestedRecords))
                {
                    builder.Append("  ingestedRecords: ");
                    builder.AppendLine($"{IngestedRecords.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ScannedGB), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  scannedGb: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ScannedGB))
                {
                    builder.Append("  scannedGb: ");
                    builder.AppendLine($"'{ScannedGB.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<OperationalInsightsTableResultStatistics>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsTableResultStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsTableResultStatistics)} does not support writing '{options.Format}' format.");
            }
        }

        OperationalInsightsTableResultStatistics IPersistableModel<OperationalInsightsTableResultStatistics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsTableResultStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOperationalInsightsTableResultStatistics(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsTableResultStatistics)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OperationalInsightsTableResultStatistics>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
