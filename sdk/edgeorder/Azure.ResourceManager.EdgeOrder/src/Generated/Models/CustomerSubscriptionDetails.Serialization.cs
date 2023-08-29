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
    public partial class CustomerSubscriptionDetails : IUtf8JsonSerializable, IModelJsonSerializable<CustomerSubscriptionDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CustomerSubscriptionDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CustomerSubscriptionDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(RegisteredFeatures))
            {
                writer.WritePropertyName("registeredFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in RegisteredFeatures)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LocationPlacementId))
            {
                writer.WritePropertyName("locationPlacementId"u8);
                writer.WriteStringValue(LocationPlacementId);
            }
            writer.WritePropertyName("quotaId"u8);
            writer.WriteStringValue(QuotaId);
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

        internal static CustomerSubscriptionDetails DeserializeCustomerSubscriptionDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<CustomerSubscriptionRegisteredFeatures>> registeredFeatures = default;
            Optional<string> locationPlacementId = default;
            string quotaId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("registeredFeatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CustomerSubscriptionRegisteredFeatures> array = new List<CustomerSubscriptionRegisteredFeatures>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomerSubscriptionRegisteredFeatures.DeserializeCustomerSubscriptionRegisteredFeatures(item));
                    }
                    registeredFeatures = array;
                    continue;
                }
                if (property.NameEquals("locationPlacementId"u8))
                {
                    locationPlacementId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quotaId"u8))
                {
                    quotaId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CustomerSubscriptionDetails(Optional.ToList(registeredFeatures), locationPlacementId.Value, quotaId, rawData);
        }

        CustomerSubscriptionDetails IModelJsonSerializable<CustomerSubscriptionDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomerSubscriptionDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CustomerSubscriptionDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CustomerSubscriptionDetails IModelSerializable<CustomerSubscriptionDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCustomerSubscriptionDetails(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CustomerSubscriptionDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CustomerSubscriptionDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCustomerSubscriptionDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
