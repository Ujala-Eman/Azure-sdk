// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class Location : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LocationName))
            {
                writer.WritePropertyName("locationName");
                writer.WriteStringValue(LocationName);
            }
            if (Optional.IsDefined(FailoverPriority))
            {
                writer.WritePropertyName("failoverPriority");
                writer.WriteNumberValue(FailoverPriority.Value);
            }
            if (Optional.IsDefined(IsZoneRedundant))
            {
                writer.WritePropertyName("isZoneRedundant");
                writer.WriteBooleanValue(IsZoneRedundant.Value);
            }
            writer.WriteEndObject();
        }

        internal static Location DeserializeLocation(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> locationName = default;
            Optional<string> documentEndpoint = default;
            Optional<string> provisioningState = default;
            Optional<int> failoverPriority = default;
            Optional<bool> isZoneRedundant = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locationName"))
                {
                    locationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("documentEndpoint"))
                {
                    documentEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("failoverPriority"))
                {
                    failoverPriority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isZoneRedundant"))
                {
                    isZoneRedundant = property.Value.GetBoolean();
                    continue;
                }
            }
            return new Location(id.Value, locationName.Value, documentEndpoint.Value, provisioningState.Value, Optional.ToNullable(failoverPriority), Optional.ToNullable(isZoneRedundant));
        }
    }
}
