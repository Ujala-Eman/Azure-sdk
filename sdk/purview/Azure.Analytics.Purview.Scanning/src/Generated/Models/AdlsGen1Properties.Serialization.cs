// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Scanning.Models
{
    public partial class AdlsGen1Properties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpoint");
                writer.WriteStringValue(Endpoint);
            }
            if (Optional.IsDefined(ResourceGroup))
            {
                writer.WritePropertyName("resourceGroup");
                writer.WriteStringValue(ResourceGroup);
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId");
                writer.WriteStringValue(SubscriptionId);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsDefined(ResourceName))
            {
                writer.WritePropertyName("resourceName");
                writer.WriteStringValue(ResourceName);
            }
            if (Optional.IsDefined(Collection))
            {
                writer.WritePropertyName("collection");
                writer.WriteObjectValue(Collection);
            }
            writer.WriteEndObject();
        }

        internal static AdlsGen1Properties DeserializeAdlsGen1Properties(JsonElement element)
        {
            Optional<string> endpoint = default;
            Optional<string> resourceGroup = default;
            Optional<string> subscriptionId = default;
            Optional<string> location = default;
            Optional<string> resourceName = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<DateTimeOffset> lastModifiedAt = default;
            Optional<DataSourcePropertiesCollection> collection = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpoint"))
                {
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceName"))
                {
                    resourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastModifiedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("collection"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    collection = DataSourcePropertiesCollection.DeserializeDataSourcePropertiesCollection(property.Value);
                    continue;
                }
            }
            return new AdlsGen1Properties(Optional.ToNullable(createdAt), Optional.ToNullable(lastModifiedAt), collection.Value, resourceGroup.Value, subscriptionId.Value, location.Value, resourceName.Value, endpoint.Value);
        }
    }
}
