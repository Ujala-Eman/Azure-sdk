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
    public partial class ReservationToPurchaseCalculateExchange : IUtf8JsonSerializable, IModelJsonSerializable<ReservationToPurchaseCalculateExchange>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ReservationToPurchaseCalculateExchange>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ReservationToPurchaseCalculateExchange>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                if (Properties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ReservationPurchaseContent>)Properties).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(BillingCurrencyTotal))
            {
                writer.WritePropertyName("billingCurrencyTotal"u8);
                if (BillingCurrencyTotal is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PurchasePrice>)BillingCurrencyTotal).Serialize(writer, options);
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

        internal static ReservationToPurchaseCalculateExchange DeserializeReservationToPurchaseCalculateExchange(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ReservationPurchaseContent> properties = default;
            Optional<PurchasePrice> billingCurrencyTotal = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = ReservationPurchaseContent.DeserializeReservationPurchaseContent(property.Value);
                    continue;
                }
                if (property.NameEquals("billingCurrencyTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyTotal = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ReservationToPurchaseCalculateExchange(properties.Value, billingCurrencyTotal.Value, rawData);
        }

        ReservationToPurchaseCalculateExchange IModelJsonSerializable<ReservationToPurchaseCalculateExchange>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationToPurchaseCalculateExchange(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ReservationToPurchaseCalculateExchange>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ReservationToPurchaseCalculateExchange IModelSerializable<ReservationToPurchaseCalculateExchange>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeReservationToPurchaseCalculateExchange(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ReservationToPurchaseCalculateExchange"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ReservationToPurchaseCalculateExchange"/> to convert. </param>
        public static implicit operator RequestContent(ReservationToPurchaseCalculateExchange model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ReservationToPurchaseCalculateExchange"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ReservationToPurchaseCalculateExchange(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeReservationToPurchaseCalculateExchange(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
