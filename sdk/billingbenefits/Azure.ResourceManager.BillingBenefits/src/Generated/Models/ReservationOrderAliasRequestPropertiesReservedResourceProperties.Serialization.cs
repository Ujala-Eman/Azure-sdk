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

namespace Azure.ResourceManager.BillingBenefits.Models
{
    internal partial class ReservationOrderAliasRequestPropertiesReservedResourceProperties : IUtf8JsonSerializable, IJsonModel<ReservationOrderAliasRequestPropertiesReservedResourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReservationOrderAliasRequestPropertiesReservedResourceProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ReservationOrderAliasRequestPropertiesReservedResourceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ReservationOrderAliasRequestPropertiesReservedResourceProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ReservationOrderAliasRequestPropertiesReservedResourceProperties>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(InstanceFlexibility))
            {
                writer.WritePropertyName("instanceFlexibility"u8);
                writer.WriteStringValue(InstanceFlexibility.Value.ToString());
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

        ReservationOrderAliasRequestPropertiesReservedResourceProperties IJsonModel<ReservationOrderAliasRequestPropertiesReservedResourceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ReservationOrderAliasRequestPropertiesReservedResourceProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationOrderAliasRequestPropertiesReservedResourceProperties(document.RootElement, options);
        }

        internal static ReservationOrderAliasRequestPropertiesReservedResourceProperties DeserializeReservationOrderAliasRequestPropertiesReservedResourceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BillingBenefitsInstanceFlexibility> instanceFlexibility = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceFlexibility"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceFlexibility = new BillingBenefitsInstanceFlexibility(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReservationOrderAliasRequestPropertiesReservedResourceProperties(Optional.ToNullable(instanceFlexibility), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReservationOrderAliasRequestPropertiesReservedResourceProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ReservationOrderAliasRequestPropertiesReservedResourceProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ReservationOrderAliasRequestPropertiesReservedResourceProperties IPersistableModel<ReservationOrderAliasRequestPropertiesReservedResourceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ReservationOrderAliasRequestPropertiesReservedResourceProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeReservationOrderAliasRequestPropertiesReservedResourceProperties(document.RootElement, options);
        }

        string IPersistableModel<ReservationOrderAliasRequestPropertiesReservedResourceProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
