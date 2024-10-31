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
    public partial class WorkflowEnvelopeProperties : IUtf8JsonSerializable, IJsonModel<WorkflowEnvelopeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkflowEnvelopeProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WorkflowEnvelopeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkflowEnvelopeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkflowEnvelopeProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Files))
            {
                writer.WritePropertyName("files"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Files);
#else
                using (JsonDocument document = JsonDocument.Parse(Files))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(FlowState))
            {
                writer.WritePropertyName("flowState"u8);
                writer.WriteStringValue(FlowState.Value.ToString());
            }
            if (Optional.IsDefined(Health))
            {
                writer.WritePropertyName("health"u8);
                writer.WriteObjectValue(Health, options);
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

        WorkflowEnvelopeProperties IJsonModel<WorkflowEnvelopeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkflowEnvelopeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkflowEnvelopeProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkflowEnvelopeProperties(document.RootElement, options);
        }

        internal static WorkflowEnvelopeProperties DeserializeWorkflowEnvelopeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BinaryData files = default;
            WorkflowState? flowState = default;
            WorkflowHealth health = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("files"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    files = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("flowState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    flowState = new WorkflowState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("health"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    health = WorkflowHealth.DeserializeWorkflowHealth(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WorkflowEnvelopeProperties(files, flowState, health, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Files), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  files: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Files))
                {
                    builder.Append("  files: ");
                    builder.AppendLine($"'{Files.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FlowState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  flowState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(FlowState))
                {
                    builder.Append("  flowState: ");
                    builder.AppendLine($"'{FlowState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Health), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  health: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Health))
                {
                    builder.Append("  health: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Health, options, 2, false, "  health: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<WorkflowEnvelopeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkflowEnvelopeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(WorkflowEnvelopeProperties)} does not support writing '{options.Format}' format.");
            }
        }

        WorkflowEnvelopeProperties IPersistableModel<WorkflowEnvelopeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkflowEnvelopeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkflowEnvelopeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkflowEnvelopeProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkflowEnvelopeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
