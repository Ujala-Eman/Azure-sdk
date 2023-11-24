// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    public partial class ExperimentExecutionActionTargetDetailsProperties : IUtf8JsonSerializable, IJsonModel<ExperimentExecutionActionTargetDetailsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExperimentExecutionActionTargetDetailsProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExperimentExecutionActionTargetDetailsProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExperimentExecutionActionTargetDetailsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ExperimentExecutionActionTargetDetailsProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (options.Format != "W" && Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetFailedOn))
            {
                if (TargetFailedOn != null)
                {
                    writer.WritePropertyName("targetFailedTime"u8);
                    writer.WriteStringValue(TargetFailedOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("targetFailedTime");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(TargetCompletedOn))
            {
                if (TargetCompletedOn != null)
                {
                    writer.WritePropertyName("targetCompletedTime"u8);
                    writer.WriteStringValue(TargetCompletedOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("targetCompletedTime");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(Error))
            {
                if (Error != null)
                {
                    writer.WritePropertyName("error"u8);
                    writer.WriteObjectValue(Error);
                }
                else
                {
                    writer.WriteNull("error");
                }
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

        ExperimentExecutionActionTargetDetailsProperties IJsonModel<ExperimentExecutionActionTargetDetailsProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExperimentExecutionActionTargetDetailsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ExperimentExecutionActionTargetDetailsProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExperimentExecutionActionTargetDetailsProperties(document.RootElement, options);
        }

        internal static ExperimentExecutionActionTargetDetailsProperties DeserializeExperimentExecutionActionTargetDetailsProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> status = default;
            Optional<string> target = default;
            Optional<DateTimeOffset?> targetFailedTime = default;
            Optional<DateTimeOffset?> targetCompletedTime = default;
            Optional<ExperimentExecutionActionTargetDetailsError> error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetFailedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetFailedTime = null;
                        continue;
                    }
                    targetFailedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("targetCompletedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetCompletedTime = null;
                        continue;
                    }
                    targetCompletedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        error = null;
                        continue;
                    }
                    error = ExperimentExecutionActionTargetDetailsError.DeserializeExperimentExecutionActionTargetDetailsError(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExperimentExecutionActionTargetDetailsProperties(status.Value, target.Value, Optional.ToNullable(targetFailedTime), Optional.ToNullable(targetCompletedTime), error.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExperimentExecutionActionTargetDetailsProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExperimentExecutionActionTargetDetailsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ExperimentExecutionActionTargetDetailsProperties)} does not support '{options.Format}' format.");
            }
        }

        ExperimentExecutionActionTargetDetailsProperties IPersistableModel<ExperimentExecutionActionTargetDetailsProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExperimentExecutionActionTargetDetailsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExperimentExecutionActionTargetDetailsProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ExperimentExecutionActionTargetDetailsProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExperimentExecutionActionTargetDetailsProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
