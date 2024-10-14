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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ServiceBus.Models
{
    public partial class ServiceBusNetworkRuleSetVirtualNetworkRules : IUtf8JsonSerializable, IJsonModel<ServiceBusNetworkRuleSetVirtualNetworkRules>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceBusNetworkRuleSetVirtualNetworkRules>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ServiceBusNetworkRuleSetVirtualNetworkRules>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusNetworkRuleSetVirtualNetworkRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceBusNetworkRuleSetVirtualNetworkRules)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Subnet))
            {
                writer.WritePropertyName("subnet"u8);
                JsonSerializer.Serialize(writer, Subnet);
            }
            if (Optional.IsDefined(IgnoreMissingVnetServiceEndpoint))
            {
                writer.WritePropertyName("ignoreMissingVnetServiceEndpoint"u8);
                writer.WriteBooleanValue(IgnoreMissingVnetServiceEndpoint.Value);
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

        ServiceBusNetworkRuleSetVirtualNetworkRules IJsonModel<ServiceBusNetworkRuleSetVirtualNetworkRules>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusNetworkRuleSetVirtualNetworkRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceBusNetworkRuleSetVirtualNetworkRules)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceBusNetworkRuleSetVirtualNetworkRules(document.RootElement, options);
        }

        internal static ServiceBusNetworkRuleSetVirtualNetworkRules DeserializeServiceBusNetworkRuleSetVirtualNetworkRules(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WritableSubResource subnet = default;
            bool? ignoreMissingVnetServiceEndpoint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnet = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("ignoreMissingVnetServiceEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ignoreMissingVnetServiceEndpoint = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ServiceBusNetworkRuleSetVirtualNetworkRules(subnet, ignoreMissingVnetServiceEndpoint, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("SubnetId", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  subnet: ");
                builder.AppendLine("{");
                builder.Append("    id: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(Subnet))
                {
                    builder.Append("  subnet: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Subnet, options, 2, false, "  subnet: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IgnoreMissingVnetServiceEndpoint), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ignoreMissingVnetServiceEndpoint: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IgnoreMissingVnetServiceEndpoint))
                {
                    builder.Append("  ignoreMissingVnetServiceEndpoint: ");
                    var boolValue = IgnoreMissingVnetServiceEndpoint.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ServiceBusNetworkRuleSetVirtualNetworkRules>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusNetworkRuleSetVirtualNetworkRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ServiceBusNetworkRuleSetVirtualNetworkRules)} does not support writing '{options.Format}' format.");
            }
        }

        ServiceBusNetworkRuleSetVirtualNetworkRules IPersistableModel<ServiceBusNetworkRuleSetVirtualNetworkRules>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusNetworkRuleSetVirtualNetworkRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceBusNetworkRuleSetVirtualNetworkRules(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceBusNetworkRuleSetVirtualNetworkRules)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceBusNetworkRuleSetVirtualNetworkRules>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
