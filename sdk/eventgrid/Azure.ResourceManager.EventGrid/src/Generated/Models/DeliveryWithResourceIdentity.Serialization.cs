// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class DeliveryWithResourceIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsDefined(Destination))
            {
                writer.WritePropertyName("destination");
                writer.WriteObjectValue(Destination);
            }
            writer.WriteEndObject();
        }

        internal static DeliveryWithResourceIdentity DeserializeDeliveryWithResourceIdentity(JsonElement element)
        {
            Optional<EventSubscriptionIdentity> identity = default;
            Optional<EventSubscriptionDestination> destination = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = EventSubscriptionIdentity.DeserializeEventSubscriptionIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("destination"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    destination = EventSubscriptionDestination.DeserializeEventSubscriptionDestination(property.Value);
                    continue;
                }
            }
            return new DeliveryWithResourceIdentity(identity.Value, destination.Value);
        }
    }
}
