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

namespace Azure.ResourceManager.SelfHelp.Models
{
    public partial class SelfHelpStep : IUtf8JsonSerializable, IJsonModel<SelfHelpStep>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SelfHelpStep>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SelfHelpStep>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SelfHelpStep>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SelfHelpStep>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Guidance))
            {
                writer.WritePropertyName("guidance"u8);
                writer.WriteStringValue(Guidance);
            }
            if (Optional.IsDefined(ExecutionStatus))
            {
                writer.WritePropertyName("executionStatus"u8);
                writer.WriteStringValue(ExecutionStatus.Value.ToString());
            }
            if (Optional.IsDefined(ExecutionStatusDescription))
            {
                writer.WritePropertyName("executionStatusDescription"u8);
                writer.WriteStringValue(ExecutionStatusDescription);
            }
            if (Optional.IsDefined(StepType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(StepType.Value.ToString());
            }
            if (Optional.IsDefined(IsLastStep))
            {
                writer.WritePropertyName("isLastStep"u8);
                writer.WriteBooleanValue(IsLastStep.Value);
            }
            if (Optional.IsCollectionDefined(Inputs))
            {
                writer.WritePropertyName("inputs"u8);
                writer.WriteStartArray();
                foreach (var item in Inputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AutomatedCheckResults))
            {
                writer.WritePropertyName("automatedCheckResults"u8);
                writer.WriteObjectValue(AutomatedCheckResults);
            }
            if (Optional.IsCollectionDefined(Insights))
            {
                writer.WritePropertyName("insights"u8);
                writer.WriteStartArray();
                foreach (var item in Insights)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
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

        SelfHelpStep IJsonModel<SelfHelpStep>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SelfHelpStep)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSelfHelpStep(document.RootElement, options);
        }

        internal static SelfHelpStep DeserializeSelfHelpStep(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> title = default;
            Optional<string> description = default;
            Optional<string> guidance = default;
            Optional<ExecutionStatus> executionStatus = default;
            Optional<string> executionStatusDescription = default;
            Optional<SelfHelpType> type = default;
            Optional<bool> isLastStep = default;
            Optional<IReadOnlyList<StepInput>> inputs = default;
            Optional<AutomatedCheckResult> automatedCheckResults = default;
            Optional<IReadOnlyList<SelfHelpDiagnosticInsight>> insights = default;
            Optional<ResponseError> error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("guidance"u8))
                {
                    guidance = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("executionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    executionStatus = new ExecutionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("executionStatusDescription"u8))
                {
                    executionStatusDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new SelfHelpType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isLastStep"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isLastStep = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StepInput> array = new List<StepInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StepInput.DeserializeStepInput(item));
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("automatedCheckResults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    automatedCheckResults = AutomatedCheckResult.DeserializeAutomatedCheckResult(property.Value);
                    continue;
                }
                if (property.NameEquals("insights"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SelfHelpDiagnosticInsight> array = new List<SelfHelpDiagnosticInsight>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SelfHelpDiagnosticInsight.DeserializeSelfHelpDiagnosticInsight(item));
                    }
                    insights = array;
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
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SelfHelpStep(id.Value, title.Value, description.Value, guidance.Value, Optional.ToNullable(executionStatus), executionStatusDescription.Value, Optional.ToNullable(type), Optional.ToNullable(isLastStep), Optional.ToList(inputs), automatedCheckResults.Value, Optional.ToList(insights), error.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SelfHelpStep>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SelfHelpStep)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SelfHelpStep IPersistableModel<SelfHelpStep>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SelfHelpStep)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSelfHelpStep(document.RootElement, options);
        }

        string IPersistableModel<SelfHelpStep>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
