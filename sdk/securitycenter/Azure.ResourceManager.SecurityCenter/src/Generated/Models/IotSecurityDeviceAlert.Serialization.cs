// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class IotSecurityDeviceAlert : IUtf8JsonSerializable, IJsonModel<IotSecurityDeviceAlert>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotSecurityDeviceAlert>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IotSecurityDeviceAlert>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecurityDeviceAlert>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotSecurityDeviceAlert)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && AlertDisplayName != null)
            {
                writer.WritePropertyName("alertDisplayName"u8);
                writer.WriteStringValue(AlertDisplayName);
            }
            if (options.Format != "W" && ReportedSeverity.HasValue)
            {
                writer.WritePropertyName("reportedSeverity"u8);
                writer.WriteStringValue(ReportedSeverity.Value.ToString());
            }
            if (options.Format != "W" && AlertsCount.HasValue)
            {
                writer.WritePropertyName("alertsCount"u8);
                writer.WriteNumberValue(AlertsCount.Value);
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

        IotSecurityDeviceAlert IJsonModel<IotSecurityDeviceAlert>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecurityDeviceAlert>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotSecurityDeviceAlert)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotSecurityDeviceAlert(document.RootElement, options);
        }

        internal static IotSecurityDeviceAlert DeserializeIotSecurityDeviceAlert(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string alertDisplayName = default;
            ReportedSeverity? reportedSeverity = default;
            long? alertsCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alertDisplayName"u8))
                {
                    alertDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reportedSeverity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reportedSeverity = new ReportedSeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("alertsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alertsCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotSecurityDeviceAlert(alertDisplayName, reportedSeverity, alertsCount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotSecurityDeviceAlert>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecurityDeviceAlert>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotSecurityDeviceAlert)} does not support '{options.Format}' format.");
            }
        }

        IotSecurityDeviceAlert IPersistableModel<IotSecurityDeviceAlert>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecurityDeviceAlert>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotSecurityDeviceAlert(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotSecurityDeviceAlert)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotSecurityDeviceAlert>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
