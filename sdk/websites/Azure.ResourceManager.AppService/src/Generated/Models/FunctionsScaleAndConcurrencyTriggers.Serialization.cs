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

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class FunctionsScaleAndConcurrencyTriggers : IUtf8JsonSerializable, IJsonModel<FunctionsScaleAndConcurrencyTriggers>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FunctionsScaleAndConcurrencyTriggers>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FunctionsScaleAndConcurrencyTriggers>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionsScaleAndConcurrencyTriggers>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FunctionsScaleAndConcurrencyTriggers)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Http))
            {
                writer.WritePropertyName("http"u8);
                writer.WriteObjectValue(Http, options);
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

        FunctionsScaleAndConcurrencyTriggers IJsonModel<FunctionsScaleAndConcurrencyTriggers>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionsScaleAndConcurrencyTriggers>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FunctionsScaleAndConcurrencyTriggers)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFunctionsScaleAndConcurrencyTriggers(document.RootElement, options);
        }

        internal static FunctionsScaleAndConcurrencyTriggers DeserializeFunctionsScaleAndConcurrencyTriggers(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FunctionsScaleAndConcurrencyTriggersHttp http = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("http"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    http = FunctionsScaleAndConcurrencyTriggersHttp.DeserializeFunctionsScaleAndConcurrencyTriggersHttp(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FunctionsScaleAndConcurrencyTriggers(http, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("HttpPerInstanceConcurrency", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  http: ");
                builder.AppendLine("{");
                builder.Append("    perInstanceConcurrency: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(Http))
                {
                    builder.Append("  http: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Http, options, 2, false, "  http: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<FunctionsScaleAndConcurrencyTriggers>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionsScaleAndConcurrencyTriggers>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(FunctionsScaleAndConcurrencyTriggers)} does not support writing '{options.Format}' format.");
            }
        }

        FunctionsScaleAndConcurrencyTriggers IPersistableModel<FunctionsScaleAndConcurrencyTriggers>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionsScaleAndConcurrencyTriggers>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFunctionsScaleAndConcurrencyTriggers(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FunctionsScaleAndConcurrencyTriggers)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FunctionsScaleAndConcurrencyTriggers>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
