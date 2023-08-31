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
    public partial class CalculateExchangeResultProperties : IUtf8JsonSerializable, IModelJsonSerializable<CalculateExchangeResultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CalculateExchangeResultProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CalculateExchangeResultProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId.Value);
            }
            if (Optional.IsDefined(NetPayable))
            {
                writer.WritePropertyName("netPayable"u8);
                if (NetPayable is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PurchasePrice>)NetPayable).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(RefundsTotal))
            {
                writer.WritePropertyName("refundsTotal"u8);
                if (RefundsTotal is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PurchasePrice>)RefundsTotal).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(PurchasesTotal))
            {
                writer.WritePropertyName("purchasesTotal"u8);
                if (PurchasesTotal is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PurchasePrice>)PurchasesTotal).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(ReservationsToPurchase))
            {
                writer.WritePropertyName("reservationsToPurchase"u8);
                writer.WriteStartArray();
                foreach (var item in ReservationsToPurchase)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ReservationToPurchaseCalculateExchange>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SavingsPlansToPurchase))
            {
                writer.WritePropertyName("savingsPlansToPurchase"u8);
                writer.WriteStartArray();
                foreach (var item in SavingsPlansToPurchase)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SavingsPlanToPurchaseCalculateExchange>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ReservationsToExchange))
            {
                writer.WritePropertyName("reservationsToExchange"u8);
                writer.WriteStartArray();
                foreach (var item in ReservationsToExchange)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ReservationToExchange>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PolicyResult))
            {
                writer.WritePropertyName("policyResult"u8);
                if (PolicyResult is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ExchangePolicyErrors>)PolicyResult).Serialize(writer, options);
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

        internal static CalculateExchangeResultProperties DeserializeCalculateExchangeResultProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> sessionId = default;
            Optional<PurchasePrice> netPayable = default;
            Optional<PurchasePrice> refundsTotal = default;
            Optional<PurchasePrice> purchasesTotal = default;
            Optional<IReadOnlyList<ReservationToPurchaseCalculateExchange>> reservationsToPurchase = default;
            Optional<IReadOnlyList<SavingsPlanToPurchaseCalculateExchange>> savingsPlansToPurchase = default;
            Optional<IReadOnlyList<ReservationToExchange>> reservationsToExchange = default;
            Optional<ExchangePolicyErrors> policyResult = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                if (property.NameEquals("netPayable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    netPayable = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("refundsTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refundsTotal = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("purchasesTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    purchasesTotal = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("reservationsToPurchase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReservationToPurchaseCalculateExchange> array = new List<ReservationToPurchaseCalculateExchange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReservationToPurchaseCalculateExchange.DeserializeReservationToPurchaseCalculateExchange(item));
                    }
                    reservationsToPurchase = array;
                    continue;
                }
                if (property.NameEquals("savingsPlansToPurchase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SavingsPlanToPurchaseCalculateExchange> array = new List<SavingsPlanToPurchaseCalculateExchange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SavingsPlanToPurchaseCalculateExchange.DeserializeSavingsPlanToPurchaseCalculateExchange(item));
                    }
                    savingsPlansToPurchase = array;
                    continue;
                }
                if (property.NameEquals("reservationsToExchange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReservationToExchange> array = new List<ReservationToExchange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReservationToExchange.DeserializeReservationToExchange(item));
                    }
                    reservationsToExchange = array;
                    continue;
                }
                if (property.NameEquals("policyResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyResult = ExchangePolicyErrors.DeserializeExchangePolicyErrors(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CalculateExchangeResultProperties(Optional.ToNullable(sessionId), netPayable.Value, refundsTotal.Value, purchasesTotal.Value, Optional.ToList(reservationsToPurchase), Optional.ToList(savingsPlansToPurchase), Optional.ToList(reservationsToExchange), policyResult.Value, rawData);
        }

        CalculateExchangeResultProperties IModelJsonSerializable<CalculateExchangeResultProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCalculateExchangeResultProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CalculateExchangeResultProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CalculateExchangeResultProperties IModelSerializable<CalculateExchangeResultProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCalculateExchangeResultProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CalculateExchangeResultProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CalculateExchangeResultProperties"/> to convert. </param>
        public static implicit operator RequestContent(CalculateExchangeResultProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CalculateExchangeResultProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CalculateExchangeResultProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCalculateExchangeResultProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
