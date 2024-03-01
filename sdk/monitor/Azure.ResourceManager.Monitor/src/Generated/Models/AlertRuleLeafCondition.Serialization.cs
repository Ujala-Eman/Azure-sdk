// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class AlertRuleLeafCondition : IUtf8JsonSerializable, IJsonModel<AlertRuleLeafCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AlertRuleLeafCondition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AlertRuleLeafCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertRuleLeafCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AlertRuleLeafCondition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Field != null)
            {
                writer.WritePropertyName("field"u8);
                writer.WriteStringValue(Field);
            }
            if (EqualsValue != null)
            {
                writer.WritePropertyName("equals"u8);
                writer.WriteStringValue(EqualsValue);
            }
            if (!(ContainsAny is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("containsAny"u8);
                writer.WriteStartArray();
                foreach (var item in ContainsAny)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        AlertRuleLeafCondition IJsonModel<AlertRuleLeafCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertRuleLeafCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AlertRuleLeafCondition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAlertRuleLeafCondition(document.RootElement, options);
        }

        internal static AlertRuleLeafCondition DeserializeAlertRuleLeafCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string field = default;
            string @equals = default;
            IList<string> containsAny = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("field"u8))
                {
                    field = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("equals"u8))
                {
                    @equals = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containsAny"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    containsAny = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AlertRuleLeafCondition(field, @equals, containsAny ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AlertRuleLeafCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertRuleLeafCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AlertRuleLeafCondition)} does not support '{options.Format}' format.");
            }
        }

        AlertRuleLeafCondition IPersistableModel<AlertRuleLeafCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertRuleLeafCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAlertRuleLeafCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AlertRuleLeafCondition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AlertRuleLeafCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
