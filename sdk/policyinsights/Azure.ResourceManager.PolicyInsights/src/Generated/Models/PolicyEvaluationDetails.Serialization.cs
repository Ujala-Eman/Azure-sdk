// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PolicyInsights;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class PolicyEvaluationDetails : IUtf8JsonSerializable, IJsonModel<PolicyEvaluationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyEvaluationDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicyEvaluationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEvaluationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyEvaluationDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(EvaluatedExpressions is ChangeTrackingList<ExpressionEvaluationDetails> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("evaluatedExpressions"u8);
                writer.WriteStartArray();
                foreach (var item in EvaluatedExpressions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (IfNotExistsDetails != null)
            {
                writer.WritePropertyName("ifNotExistsDetails"u8);
                writer.WriteObjectValue(IfNotExistsDetails);
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

        PolicyEvaluationDetails IJsonModel<PolicyEvaluationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEvaluationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyEvaluationDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyEvaluationDetails(document.RootElement, options);
        }

        internal static PolicyEvaluationDetails DeserializePolicyEvaluationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ExpressionEvaluationDetails> evaluatedExpressions = default;
            IfNotExistsEvaluationDetails ifNotExistsDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("evaluatedExpressions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExpressionEvaluationDetails> array = new List<ExpressionEvaluationDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExpressionEvaluationDetails.DeserializeExpressionEvaluationDetails(item, options));
                    }
                    evaluatedExpressions = array;
                    continue;
                }
                if (property.NameEquals("ifNotExistsDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ifNotExistsDetails = IfNotExistsEvaluationDetails.DeserializeIfNotExistsEvaluationDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicyEvaluationDetails(evaluatedExpressions ?? new ChangeTrackingList<ExpressionEvaluationDetails>(), ifNotExistsDetails, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyEvaluationDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEvaluationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicyEvaluationDetails)} does not support '{options.Format}' format.");
            }
        }

        PolicyEvaluationDetails IPersistableModel<PolicyEvaluationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEvaluationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicyEvaluationDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicyEvaluationDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyEvaluationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
