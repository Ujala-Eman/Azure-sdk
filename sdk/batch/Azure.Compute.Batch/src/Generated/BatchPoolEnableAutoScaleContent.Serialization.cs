// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class BatchPoolEnableAutoScaleContent : IUtf8JsonSerializable, IJsonModel<BatchPoolEnableAutoScaleContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchPoolEnableAutoScaleContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BatchPoolEnableAutoScaleContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPoolEnableAutoScaleContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchPoolEnableAutoScaleContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AutoScaleFormula))
            {
                writer.WritePropertyName("autoScaleFormula"u8);
                writer.WriteStringValue(AutoScaleFormula);
            }
            if (Optional.IsDefined(AutoScaleEvaluationInterval))
            {
                writer.WritePropertyName("autoScaleEvaluationInterval"u8);
                writer.WriteStringValue(AutoScaleEvaluationInterval.Value, "P");
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

        BatchPoolEnableAutoScaleContent IJsonModel<BatchPoolEnableAutoScaleContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPoolEnableAutoScaleContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchPoolEnableAutoScaleContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchPoolEnableAutoScaleContent(document.RootElement, options);
        }

        internal static BatchPoolEnableAutoScaleContent DeserializeBatchPoolEnableAutoScaleContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string autoScaleFormula = default;
            TimeSpan? autoScaleEvaluationInterval = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("autoScaleFormula"u8))
                {
                    autoScaleFormula = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoScaleEvaluationInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoScaleEvaluationInterval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BatchPoolEnableAutoScaleContent(autoScaleFormula, autoScaleEvaluationInterval, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchPoolEnableAutoScaleContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPoolEnableAutoScaleContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchPoolEnableAutoScaleContent)} does not support writing '{options.Format}' format.");
            }
        }

        BatchPoolEnableAutoScaleContent IPersistableModel<BatchPoolEnableAutoScaleContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPoolEnableAutoScaleContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchPoolEnableAutoScaleContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchPoolEnableAutoScaleContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchPoolEnableAutoScaleContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BatchPoolEnableAutoScaleContent FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBatchPoolEnableAutoScaleContent(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
