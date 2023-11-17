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

namespace Azure.ResourceManager.Resources.Models
{
    public partial class AvailabilityZoneMappings : IUtf8JsonSerializable, IJsonModel<AvailabilityZoneMappings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvailabilityZoneMappings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AvailabilityZoneMappings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AvailabilityZoneMappings>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AvailabilityZoneMappings>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(LogicalZone))
                {
                    writer.WritePropertyName("logicalZone"u8);
                    writer.WriteStringValue(LogicalZone);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(PhysicalZone))
                {
                    writer.WritePropertyName("physicalZone"u8);
                    writer.WriteStringValue(PhysicalZone);
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

        AvailabilityZoneMappings IJsonModel<AvailabilityZoneMappings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvailabilityZoneMappings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailabilityZoneMappings(document.RootElement, options);
        }

        internal static AvailabilityZoneMappings DeserializeAvailabilityZoneMappings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> logicalZone = default;
            Optional<string> physicalZone = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logicalZone"u8))
                {
                    logicalZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("physicalZone"u8))
                {
                    physicalZone = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AvailabilityZoneMappings(logicalZone.Value, physicalZone.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvailabilityZoneMappings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvailabilityZoneMappings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AvailabilityZoneMappings IPersistableModel<AvailabilityZoneMappings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvailabilityZoneMappings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAvailabilityZoneMappings(document.RootElement, options);
        }

        string IPersistableModel<AvailabilityZoneMappings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
