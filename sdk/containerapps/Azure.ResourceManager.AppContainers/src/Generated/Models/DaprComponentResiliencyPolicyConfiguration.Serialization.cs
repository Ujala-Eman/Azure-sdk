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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class DaprComponentResiliencyPolicyConfiguration : IUtf8JsonSerializable, IJsonModel<DaprComponentResiliencyPolicyConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DaprComponentResiliencyPolicyConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DaprComponentResiliencyPolicyConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DaprComponentResiliencyPolicyConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DaprComponentResiliencyPolicyConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(HttpRetryPolicy))
            {
                writer.WritePropertyName("httpRetryPolicy"u8);
                writer.WriteObjectValue(HttpRetryPolicy, options);
            }
            if (Optional.IsDefined(TimeoutPolicy))
            {
                writer.WritePropertyName("timeoutPolicy"u8);
                writer.WriteObjectValue(TimeoutPolicy, options);
            }
            if (Optional.IsDefined(CircuitBreakerPolicy))
            {
                writer.WritePropertyName("circuitBreakerPolicy"u8);
                writer.WriteObjectValue(CircuitBreakerPolicy, options);
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

        DaprComponentResiliencyPolicyConfiguration IJsonModel<DaprComponentResiliencyPolicyConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DaprComponentResiliencyPolicyConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DaprComponentResiliencyPolicyConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDaprComponentResiliencyPolicyConfiguration(document.RootElement, options);
        }

        internal static DaprComponentResiliencyPolicyConfiguration DeserializeDaprComponentResiliencyPolicyConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DaprComponentResiliencyPolicyHttpRetryPolicyConfiguration httpRetryPolicy = default;
            DaprComponentResiliencyPolicyTimeoutPolicyConfiguration timeoutPolicy = default;
            DaprComponentResiliencyPolicyCircuitBreakerPolicyConfiguration circuitBreakerPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("httpRetryPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpRetryPolicy = DaprComponentResiliencyPolicyHttpRetryPolicyConfiguration.DeserializeDaprComponentResiliencyPolicyHttpRetryPolicyConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("timeoutPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeoutPolicy = DaprComponentResiliencyPolicyTimeoutPolicyConfiguration.DeserializeDaprComponentResiliencyPolicyTimeoutPolicyConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("circuitBreakerPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    circuitBreakerPolicy = DaprComponentResiliencyPolicyCircuitBreakerPolicyConfiguration.DeserializeDaprComponentResiliencyPolicyCircuitBreakerPolicyConfiguration(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DaprComponentResiliencyPolicyConfiguration(httpRetryPolicy, timeoutPolicy, circuitBreakerPolicy, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HttpRetryPolicy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  httpRetryPolicy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HttpRetryPolicy))
                {
                    builder.Append("  httpRetryPolicy: ");
                    BicepSerializationHelpers.AppendChildObject(builder, HttpRetryPolicy, options, 2, false, "  httpRetryPolicy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("ResponseTimeoutInSeconds", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  timeoutPolicy: ");
                builder.AppendLine("{");
                builder.Append("    responseTimeoutInSeconds: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(TimeoutPolicy))
                {
                    builder.Append("  timeoutPolicy: ");
                    BicepSerializationHelpers.AppendChildObject(builder, TimeoutPolicy, options, 2, false, "  timeoutPolicy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CircuitBreakerPolicy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  circuitBreakerPolicy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CircuitBreakerPolicy))
                {
                    builder.Append("  circuitBreakerPolicy: ");
                    BicepSerializationHelpers.AppendChildObject(builder, CircuitBreakerPolicy, options, 2, false, "  circuitBreakerPolicy: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DaprComponentResiliencyPolicyConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DaprComponentResiliencyPolicyConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DaprComponentResiliencyPolicyConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        DaprComponentResiliencyPolicyConfiguration IPersistableModel<DaprComponentResiliencyPolicyConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DaprComponentResiliencyPolicyConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDaprComponentResiliencyPolicyConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DaprComponentResiliencyPolicyConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DaprComponentResiliencyPolicyConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
