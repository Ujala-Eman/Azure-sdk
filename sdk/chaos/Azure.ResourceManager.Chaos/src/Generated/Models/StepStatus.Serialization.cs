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

namespace Azure.ResourceManager.Chaos.Models
{
    public partial class StepStatus : IUtf8JsonSerializable, IJsonModel<StepStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StepStatus>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<StepStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<StepStatus>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<StepStatus>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(StepName))
                {
                    writer.WritePropertyName("stepName"u8);
                    writer.WriteStringValue(StepName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(StepId))
                {
                    writer.WritePropertyName("stepId"u8);
                    writer.WriteStringValue(StepId);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Status))
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(Status);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Branches))
                {
                    writer.WritePropertyName("branches"u8);
                    writer.WriteStartArray();
                    foreach (var item in Branches)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
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

        StepStatus IJsonModel<StepStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StepStatus)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStepStatus(document.RootElement, options);
        }

        internal static StepStatus DeserializeStepStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> stepName = default;
            Optional<string> stepId = default;
            Optional<string> status = default;
            Optional<IReadOnlyList<BranchStatus>> branches = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stepName"u8))
                {
                    stepName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stepId"u8))
                {
                    stepId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("branches"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BranchStatus> array = new List<BranchStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BranchStatus.DeserializeBranchStatus(item));
                    }
                    branches = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StepStatus(stepName.Value, stepId.Value, status.Value, Optional.ToList(branches), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StepStatus>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StepStatus)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        StepStatus IPersistableModel<StepStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StepStatus)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeStepStatus(document.RootElement, options);
        }

        string IPersistableModel<StepStatus>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
