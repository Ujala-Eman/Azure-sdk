// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightAutoScaleConfigurationUpdateContent : IUtf8JsonSerializable, IJsonModel<HDInsightAutoScaleConfigurationUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightAutoScaleConfigurationUpdateContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HDInsightAutoScaleConfigurationUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAutoScaleConfigurationUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightAutoScaleConfigurationUpdateContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AutoScale))
            {
                writer.WritePropertyName("autoscale"u8);
                writer.WriteObjectValue(AutoScale, options);
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

        HDInsightAutoScaleConfigurationUpdateContent IJsonModel<HDInsightAutoScaleConfigurationUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAutoScaleConfigurationUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightAutoScaleConfigurationUpdateContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightAutoScaleConfigurationUpdateContent(document.RootElement, options);
        }

        internal static HDInsightAutoScaleConfigurationUpdateContent DeserializeHDInsightAutoScaleConfigurationUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HDInsightAutoScaleConfiguration autoScale = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("autoscale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoScale = HDInsightAutoScaleConfiguration.DeserializeHDInsightAutoScaleConfiguration(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HDInsightAutoScaleConfigurationUpdateContent(autoScale, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightAutoScaleConfigurationUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAutoScaleConfigurationUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightAutoScaleConfigurationUpdateContent)} does not support writing '{options.Format}' format.");
            }
        }

        HDInsightAutoScaleConfigurationUpdateContent IPersistableModel<HDInsightAutoScaleConfigurationUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAutoScaleConfigurationUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightAutoScaleConfigurationUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightAutoScaleConfigurationUpdateContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightAutoScaleConfigurationUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
