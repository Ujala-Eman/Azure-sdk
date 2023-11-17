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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class DefenderForServersGcpOfferingArcAutoProvisioning : IUtf8JsonSerializable, IJsonModel<DefenderForServersGcpOfferingArcAutoProvisioning>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderForServersGcpOfferingArcAutoProvisioning>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DefenderForServersGcpOfferingArcAutoProvisioning>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<DefenderForServersGcpOfferingArcAutoProvisioning>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<DefenderForServersGcpOfferingArcAutoProvisioning>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
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

        DefenderForServersGcpOfferingArcAutoProvisioning IJsonModel<DefenderForServersGcpOfferingArcAutoProvisioning>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DefenderForServersGcpOfferingArcAutoProvisioning)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForServersGcpOfferingArcAutoProvisioning(document.RootElement, options);
        }

        internal static DefenderForServersGcpOfferingArcAutoProvisioning DeserializeDefenderForServersGcpOfferingArcAutoProvisioning(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DefenderForServersGcpOfferingArcAutoProvisioning(Optional.ToNullable(enabled), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefenderForServersGcpOfferingArcAutoProvisioning>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DefenderForServersGcpOfferingArcAutoProvisioning)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DefenderForServersGcpOfferingArcAutoProvisioning IPersistableModel<DefenderForServersGcpOfferingArcAutoProvisioning>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DefenderForServersGcpOfferingArcAutoProvisioning)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDefenderForServersGcpOfferingArcAutoProvisioning(document.RootElement, options);
        }

        string IPersistableModel<DefenderForServersGcpOfferingArcAutoProvisioning>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
