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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    [PersistableModelProxy(typeof(UnknownAutomationRuleCondition))]
    public partial class SecurityInsightsAutomationRuleCondition : IUtf8JsonSerializable, IJsonModel<SecurityInsightsAutomationRuleCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsAutomationRuleCondition>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecurityInsightsAutomationRuleCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAutomationRuleCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsAutomationRuleCondition)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("conditionType"u8);
            writer.WriteStringValue(ConditionType.ToString());
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

        SecurityInsightsAutomationRuleCondition IJsonModel<SecurityInsightsAutomationRuleCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAutomationRuleCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsAutomationRuleCondition)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsAutomationRuleCondition(document.RootElement, options);
        }

        internal static SecurityInsightsAutomationRuleCondition DeserializeSecurityInsightsAutomationRuleCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("conditionType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Boolean": return BooleanConditionProperties.DeserializeBooleanConditionProperties(element, options);
                    case "Property": return SecurityInsightsPropertyConditionProperties.DeserializeSecurityInsightsPropertyConditionProperties(element, options);
                    case "PropertyArray": return PropertyArrayConditionProperties.DeserializePropertyArrayConditionProperties(element, options);
                    case "PropertyArrayChanged": return SecurityInsightsPropertyArrayChangedConditionProperties.DeserializeSecurityInsightsPropertyArrayChangedConditionProperties(element, options);
                    case "PropertyChanged": return SecurityInsightsPropertyChangedConditionProperties.DeserializeSecurityInsightsPropertyChangedConditionProperties(element, options);
                }
            }
            return UnknownAutomationRuleCondition.DeserializeUnknownAutomationRuleCondition(element, options);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConditionType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  conditionType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  conditionType: ");
                builder.AppendLine($"'{ConditionType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SecurityInsightsAutomationRuleCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAutomationRuleCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsAutomationRuleCondition)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityInsightsAutomationRuleCondition IPersistableModel<SecurityInsightsAutomationRuleCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAutomationRuleCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsAutomationRuleCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsAutomationRuleCondition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsAutomationRuleCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
