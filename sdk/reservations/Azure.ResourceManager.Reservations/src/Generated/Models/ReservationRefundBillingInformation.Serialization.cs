// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ReservationRefundBillingInformation : IUtf8JsonSerializable, IModelJsonSerializable<ReservationRefundBillingInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ReservationRefundBillingInformation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ReservationRefundBillingInformation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(BillingPlan))
            {
                writer.WritePropertyName("billingPlan"u8);
                writer.WriteStringValue(BillingPlan.Value.ToString());
            }
            if (Optional.IsDefined(CompletedTransactions))
            {
                writer.WritePropertyName("completedTransactions"u8);
                writer.WriteNumberValue(CompletedTransactions.Value);
            }
            if (Optional.IsDefined(TotalTransactions))
            {
                writer.WritePropertyName("totalTransactions"u8);
                writer.WriteNumberValue(TotalTransactions.Value);
            }
            if (Optional.IsDefined(BillingCurrencyTotalPaidAmount))
            {
                writer.WritePropertyName("billingCurrencyTotalPaidAmount"u8);
                if (BillingCurrencyTotalPaidAmount is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PurchasePrice>)BillingCurrencyTotalPaidAmount).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(BillingCurrencyProratedAmount))
            {
                writer.WritePropertyName("billingCurrencyProratedAmount"u8);
                if (BillingCurrencyProratedAmount is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PurchasePrice>)BillingCurrencyProratedAmount).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(BillingCurrencyRemainingCommitmentAmount))
            {
                writer.WritePropertyName("billingCurrencyRemainingCommitmentAmount"u8);
                if (BillingCurrencyRemainingCommitmentAmount is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PurchasePrice>)BillingCurrencyRemainingCommitmentAmount).Serialize(writer, options);
                }
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ReservationRefundBillingInformation DeserializeReservationRefundBillingInformation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ReservationBillingPlan> billingPlan = default;
            Optional<int> completedTransactions = default;
            Optional<int> totalTransactions = default;
            Optional<PurchasePrice> billingCurrencyTotalPaidAmount = default;
            Optional<PurchasePrice> billingCurrencyProratedAmount = default;
            Optional<PurchasePrice> billingCurrencyRemainingCommitmentAmount = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("billingPlan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingPlan = new ReservationBillingPlan(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("completedTransactions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    completedTransactions = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalTransactions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalTransactions = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("billingCurrencyTotalPaidAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyTotalPaidAmount = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("billingCurrencyProratedAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyProratedAmount = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("billingCurrencyRemainingCommitmentAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyRemainingCommitmentAmount = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ReservationRefundBillingInformation(Optional.ToNullable(billingPlan), Optional.ToNullable(completedTransactions), Optional.ToNullable(totalTransactions), billingCurrencyTotalPaidAmount.Value, billingCurrencyProratedAmount.Value, billingCurrencyRemainingCommitmentAmount.Value, rawData);
        }

        ReservationRefundBillingInformation IModelJsonSerializable<ReservationRefundBillingInformation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationRefundBillingInformation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ReservationRefundBillingInformation>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ReservationRefundBillingInformation IModelSerializable<ReservationRefundBillingInformation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeReservationRefundBillingInformation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ReservationRefundBillingInformation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ReservationRefundBillingInformation"/> to convert. </param>
        public static implicit operator RequestContent(ReservationRefundBillingInformation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ReservationRefundBillingInformation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ReservationRefundBillingInformation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeReservationRefundBillingInformation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
