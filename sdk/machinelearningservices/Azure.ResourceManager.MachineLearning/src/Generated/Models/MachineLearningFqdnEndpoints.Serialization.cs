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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningFqdnEndpoints : IUtf8JsonSerializable, IJsonModel<MachineLearningFqdnEndpoints>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningFqdnEndpoints>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningFqdnEndpoints>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningFqdnEndpoints>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningFqdnEndpoints)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties, options);
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

        MachineLearningFqdnEndpoints IJsonModel<MachineLearningFqdnEndpoints>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningFqdnEndpoints>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningFqdnEndpoints)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningFqdnEndpoints(document.RootElement, options);
        }

        internal static MachineLearningFqdnEndpoints DeserializeMachineLearningFqdnEndpoints(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningFqdnEndpointsProperties properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = MachineLearningFqdnEndpointsProperties.DeserializeMachineLearningFqdnEndpointsProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningFqdnEndpoints(properties, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Properties), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  properties: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Properties))
                {
                    builder.Append("  properties: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Properties, options, 2, false, "  properties: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningFqdnEndpoints>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningFqdnEndpoints>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningFqdnEndpoints)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningFqdnEndpoints IPersistableModel<MachineLearningFqdnEndpoints>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningFqdnEndpoints>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningFqdnEndpoints(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningFqdnEndpoints)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningFqdnEndpoints>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
