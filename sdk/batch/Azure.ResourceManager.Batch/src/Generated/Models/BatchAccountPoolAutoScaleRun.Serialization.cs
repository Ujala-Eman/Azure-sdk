// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchAccountPoolAutoScaleRun : IUtf8JsonSerializable, IJsonModel<BatchAccountPoolAutoScaleRun>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchAccountPoolAutoScaleRun>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchAccountPoolAutoScaleRun>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountPoolAutoScaleRun>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BatchAccountPoolAutoScaleRun)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("evaluationTime"u8);
            writer.WriteStringValue(EvaluationOn, "O");
            if (Optional.IsDefined(Results))
            {
                writer.WritePropertyName("results"u8);
                writer.WriteStringValue(Results);
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
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

        BatchAccountPoolAutoScaleRun IJsonModel<BatchAccountPoolAutoScaleRun>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountPoolAutoScaleRun>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BatchAccountPoolAutoScaleRun)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchAccountPoolAutoScaleRun(document.RootElement, options);
        }

        internal static BatchAccountPoolAutoScaleRun DeserializeBatchAccountPoolAutoScaleRun(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset evaluationTime = default;
            Optional<string> results = default;
            Optional<ResponseError> error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("evaluationTime"u8))
                {
                    evaluationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("results"u8))
                {
                    results = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchAccountPoolAutoScaleRun(evaluationTime, results.Value, error.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchAccountPoolAutoScaleRun>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountPoolAutoScaleRun>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(BatchAccountPoolAutoScaleRun)} does not support '{options.Format}' format.");
            }
        }

        BatchAccountPoolAutoScaleRun IPersistableModel<BatchAccountPoolAutoScaleRun>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountPoolAutoScaleRun>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchAccountPoolAutoScaleRun(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(BatchAccountPoolAutoScaleRun)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchAccountPoolAutoScaleRun>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
