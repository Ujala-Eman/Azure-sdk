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

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchAccountPoolScaleSettings : IUtf8JsonSerializable, IJsonModel<BatchAccountPoolScaleSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchAccountPoolScaleSettings>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<BatchAccountPoolScaleSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<BatchAccountPoolScaleSettings>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<BatchAccountPoolScaleSettings>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FixedScale))
            {
                writer.WritePropertyName("fixedScale"u8);
                writer.WriteObjectValue(FixedScale);
            }
            if (Optional.IsDefined(AutoScale))
            {
                writer.WritePropertyName("autoScale"u8);
                writer.WriteObjectValue(AutoScale);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        BatchAccountPoolScaleSettings IJsonModel<BatchAccountPoolScaleSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BatchAccountPoolScaleSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchAccountPoolScaleSettings(document.RootElement, options);
        }

        internal static BatchAccountPoolScaleSettings DeserializeBatchAccountPoolScaleSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BatchAccountFixedScaleSettings> fixedScale = default;
            Optional<BatchAccountAutoScaleSettings> autoScale = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fixedScale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fixedScale = BatchAccountFixedScaleSettings.DeserializeBatchAccountFixedScaleSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("autoScale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoScale = BatchAccountAutoScaleSettings.DeserializeBatchAccountAutoScaleSettings(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchAccountPoolScaleSettings(fixedScale.Value, autoScale.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchAccountPoolScaleSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BatchAccountPoolScaleSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BatchAccountPoolScaleSettings IPersistableModel<BatchAccountPoolScaleSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BatchAccountPoolScaleSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBatchAccountPoolScaleSettings(document.RootElement, options);
        }

        string IPersistableModel<BatchAccountPoolScaleSettings>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
