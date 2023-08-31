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
    public partial class CalculatePriceResultPropertiesPricingCurrencyTotal : IUtf8JsonSerializable, IModelJsonSerializable<CalculatePriceResultPropertiesPricingCurrencyTotal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CalculatePriceResultPropertiesPricingCurrencyTotal>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CalculatePriceResultPropertiesPricingCurrencyTotal>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CurrencyCode))
            {
                writer.WritePropertyName("currencyCode"u8);
                writer.WriteStringValue(CurrencyCode);
            }
            if (Optional.IsDefined(Amount))
            {
                writer.WritePropertyName("amount"u8);
                writer.WriteNumberValue(Amount.Value);
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

        internal static CalculatePriceResultPropertiesPricingCurrencyTotal DeserializeCalculatePriceResultPropertiesPricingCurrencyTotal(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> currencyCode = default;
            Optional<float> amount = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("currencyCode"u8))
                {
                    currencyCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("amount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    amount = property.Value.GetSingle();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CalculatePriceResultPropertiesPricingCurrencyTotal(currencyCode.Value, Optional.ToNullable(amount), rawData);
        }

        CalculatePriceResultPropertiesPricingCurrencyTotal IModelJsonSerializable<CalculatePriceResultPropertiesPricingCurrencyTotal>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCalculatePriceResultPropertiesPricingCurrencyTotal(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CalculatePriceResultPropertiesPricingCurrencyTotal>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CalculatePriceResultPropertiesPricingCurrencyTotal IModelSerializable<CalculatePriceResultPropertiesPricingCurrencyTotal>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCalculatePriceResultPropertiesPricingCurrencyTotal(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CalculatePriceResultPropertiesPricingCurrencyTotal"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CalculatePriceResultPropertiesPricingCurrencyTotal"/> to convert. </param>
        public static implicit operator RequestContent(CalculatePriceResultPropertiesPricingCurrencyTotal model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CalculatePriceResultPropertiesPricingCurrencyTotal"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CalculatePriceResultPropertiesPricingCurrencyTotal(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCalculatePriceResultPropertiesPricingCurrencyTotal(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
