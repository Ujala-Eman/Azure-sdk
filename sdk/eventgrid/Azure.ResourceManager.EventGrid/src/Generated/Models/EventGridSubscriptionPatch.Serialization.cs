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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class EventGridSubscriptionPatch : IUtf8JsonSerializable, IModelJsonSerializable<EventGridSubscriptionPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EventGridSubscriptionPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EventGridSubscriptionPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Destination))
            {
                writer.WritePropertyName("destination"u8);
                writer.WriteObjectValue(Destination);
            }
            if (Optional.IsDefined(DeliveryWithResourceIdentity))
            {
                writer.WritePropertyName("deliveryWithResourceIdentity"u8);
                writer.WriteObjectValue(DeliveryWithResourceIdentity);
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteObjectValue(Filter);
            }
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartArray();
                foreach (var item in Labels)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationTimeUtc"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(EventDeliverySchema))
            {
                writer.WritePropertyName("eventDeliverySchema"u8);
                writer.WriteStringValue(EventDeliverySchema.Value.ToString());
            }
            if (Optional.IsDefined(RetryPolicy))
            {
                writer.WritePropertyName("retryPolicy"u8);
                writer.WriteObjectValue(RetryPolicy);
            }
            if (Optional.IsDefined(DeadLetterDestination))
            {
                writer.WritePropertyName("deadLetterDestination"u8);
                writer.WriteObjectValue(DeadLetterDestination);
            }
            if (Optional.IsDefined(DeadLetterWithResourceIdentity))
            {
                writer.WritePropertyName("deadLetterWithResourceIdentity"u8);
                writer.WriteObjectValue(DeadLetterWithResourceIdentity);
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

        internal static EventGridSubscriptionPatch DeserializeEventGridSubscriptionPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<EventSubscriptionDestination> destination = default;
            Optional<DeliveryWithResourceIdentity> deliveryWithResourceIdentity = default;
            Optional<EventSubscriptionFilter> filter = default;
            Optional<IList<string>> labels = default;
            Optional<DateTimeOffset> expirationTimeUtc = default;
            Optional<EventDeliverySchema> eventDeliverySchema = default;
            Optional<EventSubscriptionRetryPolicy> retryPolicy = default;
            Optional<DeadLetterDestination> deadLetterDestination = default;
            Optional<DeadLetterWithResourceIdentity> deadLetterWithResourceIdentity = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("destination"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destination = EventSubscriptionDestination.DeserializeEventSubscriptionDestination(property.Value);
                    continue;
                }
                if (property.NameEquals("deliveryWithResourceIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deliveryWithResourceIdentity = DeliveryWithResourceIdentity.DeserializeDeliveryWithResourceIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filter = EventSubscriptionFilter.DeserializeEventSubscriptionFilter(property.Value);
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    labels = array;
                    continue;
                }
                if (property.NameEquals("expirationTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("eventDeliverySchema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventDeliverySchema = new EventDeliverySchema(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("retryPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retryPolicy = EventSubscriptionRetryPolicy.DeserializeEventSubscriptionRetryPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("deadLetterDestination"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deadLetterDestination = DeadLetterDestination.DeserializeDeadLetterDestination(property.Value);
                    continue;
                }
                if (property.NameEquals("deadLetterWithResourceIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deadLetterWithResourceIdentity = DeadLetterWithResourceIdentity.DeserializeDeadLetterWithResourceIdentity(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EventGridSubscriptionPatch(destination.Value, deliveryWithResourceIdentity.Value, filter.Value, Optional.ToList(labels), Optional.ToNullable(expirationTimeUtc), Optional.ToNullable(eventDeliverySchema), retryPolicy.Value, deadLetterDestination.Value, deadLetterWithResourceIdentity.Value, rawData);
        }

        EventGridSubscriptionPatch IModelJsonSerializable<EventGridSubscriptionPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEventGridSubscriptionPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EventGridSubscriptionPatch>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EventGridSubscriptionPatch IModelSerializable<EventGridSubscriptionPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEventGridSubscriptionPatch(doc.RootElement, options);
        }

        public static implicit operator RequestContent(EventGridSubscriptionPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator EventGridSubscriptionPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEventGridSubscriptionPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
