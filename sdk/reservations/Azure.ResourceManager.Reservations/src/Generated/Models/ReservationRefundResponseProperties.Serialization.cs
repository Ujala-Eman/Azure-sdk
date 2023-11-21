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

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ReservationRefundResponseProperties : IUtf8JsonSerializable, IJsonModel<ReservationRefundResponseProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReservationRefundResponseProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReservationRefundResponseProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationRefundResponseProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ReservationRefundResponseProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId.Value);
            }
            if (Optional.IsDefined(Quantity))
            {
                writer.WritePropertyName("quantity"u8);
                writer.WriteNumberValue(Quantity.Value);
            }
            if (Optional.IsDefined(BillingRefundAmount))
            {
                writer.WritePropertyName("billingRefundAmount"u8);
                writer.WriteObjectValue(BillingRefundAmount);
            }
            if (Optional.IsDefined(PricingRefundAmount))
            {
                writer.WritePropertyName("pricingRefundAmount"u8);
                writer.WriteObjectValue(PricingRefundAmount);
            }
            if (Optional.IsDefined(PolicyResult))
            {
                writer.WritePropertyName("policyResult"u8);
                writer.WriteObjectValue(PolicyResult);
            }
            if (Optional.IsDefined(BillingInformation))
            {
                writer.WritePropertyName("billingInformation"u8);
                writer.WriteObjectValue(BillingInformation);
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

        ReservationRefundResponseProperties IJsonModel<ReservationRefundResponseProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationRefundResponseProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ReservationRefundResponseProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationRefundResponseProperties(document.RootElement, options);
        }

        internal static ReservationRefundResponseProperties DeserializeReservationRefundResponseProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> sessionId = default;
            Optional<int> quantity = default;
            Optional<PurchasePrice> billingRefundAmount = default;
            Optional<PurchasePrice> pricingRefundAmount = default;
            Optional<RefundPolicyResult> policyResult = default;
            Optional<ReservationRefundBillingInformation> billingInformation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("quantity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quantity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("billingRefundAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingRefundAmount = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("pricingRefundAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pricingRefundAmount = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("policyResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyResult = RefundPolicyResult.DeserializeRefundPolicyResult(property.Value);
                    continue;
                }
                if (property.NameEquals("billingInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingInformation = ReservationRefundBillingInformation.DeserializeReservationRefundBillingInformation(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReservationRefundResponseProperties(Optional.ToNullable(sessionId), Optional.ToNullable(quantity), billingRefundAmount.Value, pricingRefundAmount.Value, policyResult.Value, billingInformation.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReservationRefundResponseProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationRefundResponseProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ReservationRefundResponseProperties)} does not support '{options.Format}' format.");
            }
        }

        ReservationRefundResponseProperties IPersistableModel<ReservationRefundResponseProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationRefundResponseProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReservationRefundResponseProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ReservationRefundResponseProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReservationRefundResponseProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
