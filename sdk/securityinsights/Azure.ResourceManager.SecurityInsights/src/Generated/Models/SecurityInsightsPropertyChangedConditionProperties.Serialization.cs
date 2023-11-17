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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsPropertyChangedConditionProperties : IUtf8JsonSerializable, IJsonModel<SecurityInsightsPropertyChangedConditionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsPropertyChangedConditionProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsPropertyChangedConditionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SecurityInsightsPropertyChangedConditionProperties>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SecurityInsightsPropertyChangedConditionProperties>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ConditionProperties))
            {
                writer.WritePropertyName("conditionProperties"u8);
                writer.WriteObjectValue(ConditionProperties);
            }
            writer.WritePropertyName("conditionType"u8);
            writer.WriteStringValue(ConditionType.ToString());
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

        SecurityInsightsPropertyChangedConditionProperties IJsonModel<SecurityInsightsPropertyChangedConditionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityInsightsPropertyChangedConditionProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsPropertyChangedConditionProperties(document.RootElement, options);
        }

        internal static SecurityInsightsPropertyChangedConditionProperties DeserializeSecurityInsightsPropertyChangedConditionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AutomationRulePropertyValuesChangedCondition> conditionProperties = default;
            ConditionType conditionType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("conditionProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    conditionProperties = AutomationRulePropertyValuesChangedCondition.DeserializeAutomationRulePropertyValuesChangedCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("conditionType"u8))
                {
                    conditionType = new ConditionType(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityInsightsPropertyChangedConditionProperties(conditionType, serializedAdditionalRawData, conditionProperties.Value);
        }

        BinaryData IPersistableModel<SecurityInsightsPropertyChangedConditionProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityInsightsPropertyChangedConditionProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SecurityInsightsPropertyChangedConditionProperties IPersistableModel<SecurityInsightsPropertyChangedConditionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityInsightsPropertyChangedConditionProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSecurityInsightsPropertyChangedConditionProperties(document.RootElement, options);
        }

        string IPersistableModel<SecurityInsightsPropertyChangedConditionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
