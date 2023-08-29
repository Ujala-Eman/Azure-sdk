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

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class PurchaseMeterDetails : IUtf8JsonSerializable, IModelJsonSerializable<PurchaseMeterDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PurchaseMeterDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PurchaseMeterDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PurchaseMeterDetails>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("billingType"u8);
            writer.WriteStringValue(BillingType.ToString());
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

        internal static PurchaseMeterDetails DeserializePurchaseMeterDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> productId = default;
            Optional<string> skuId = default;
            Optional<string> termId = default;
            BillingType billingType = default;
            Optional<double> multiplier = default;
            Optional<EdgeOrderProductChargingType> chargingType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("productId"u8))
                {
                    productId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skuId"u8))
                {
                    skuId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("termId"u8))
                {
                    termId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("billingType"u8))
                {
                    billingType = new BillingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("multiplier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    multiplier = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("chargingType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    chargingType = new EdgeOrderProductChargingType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PurchaseMeterDetails(billingType, Optional.ToNullable(multiplier), Optional.ToNullable(chargingType), productId.Value, skuId.Value, termId.Value, rawData);
        }

        PurchaseMeterDetails IModelJsonSerializable<PurchaseMeterDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PurchaseMeterDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePurchaseMeterDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PurchaseMeterDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PurchaseMeterDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PurchaseMeterDetails IModelSerializable<PurchaseMeterDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PurchaseMeterDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePurchaseMeterDetails(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PurchaseMeterDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PurchaseMeterDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePurchaseMeterDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
