// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class BlobInventoryPolicySchema : IUtf8JsonSerializable, IJsonModel<BlobInventoryPolicySchema>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BlobInventoryPolicySchema>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BlobInventoryPolicySchema>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobInventoryPolicySchema>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BlobInventoryPolicySchema)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("enabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            if (options.Format != "W" && Optional.IsDefined(Destination))
            {
                writer.WritePropertyName("destination"u8);
                writer.WriteStringValue(Destination);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(RuleType.ToString());
            writer.WritePropertyName("rules"u8);
            writer.WriteStartArray();
            foreach (var item in Rules)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
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

        BlobInventoryPolicySchema IJsonModel<BlobInventoryPolicySchema>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobInventoryPolicySchema>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BlobInventoryPolicySchema)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBlobInventoryPolicySchema(document.RootElement, options);
        }

        internal static BlobInventoryPolicySchema DeserializeBlobInventoryPolicySchema(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool enabled = default;
            string destination = default;
            BlobInventoryRuleType type = default;
            IList<BlobInventoryPolicyRule> rules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("destination"u8))
                {
                    destination = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new BlobInventoryRuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rules"u8))
                {
                    List<BlobInventoryPolicyRule> array = new List<BlobInventoryPolicyRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BlobInventoryPolicyRule.DeserializeBlobInventoryPolicyRule(item, options));
                    }
                    rules = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BlobInventoryPolicySchema(enabled, destination, type, rules, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  enabled: ");
                var boolValue = IsEnabled == true ? "true" : "false";
                builder.AppendLine($"{boolValue}");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Destination), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  destination: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Destination))
                {
                    builder.Append("  destination: ");
                    if (Destination.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Destination}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Destination}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RuleType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  type: ");
                builder.AppendLine($"'{RuleType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Rules), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  rules: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Rules))
                {
                    if (Rules.Any())
                    {
                        builder.Append("  rules: ");
                        builder.AppendLine("[");
                        foreach (var item in Rules)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  rules: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<BlobInventoryPolicySchema>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobInventoryPolicySchema>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BlobInventoryPolicySchema)} does not support writing '{options.Format}' format.");
            }
        }

        BlobInventoryPolicySchema IPersistableModel<BlobInventoryPolicySchema>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobInventoryPolicySchema>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBlobInventoryPolicySchema(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BlobInventoryPolicySchema)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BlobInventoryPolicySchema>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
