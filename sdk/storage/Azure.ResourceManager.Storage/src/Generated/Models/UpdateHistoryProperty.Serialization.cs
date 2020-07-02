// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class UpdateHistoryProperty : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Update))
            {
                writer.WritePropertyName("update");
                writer.WriteStringValue(Update.Value.ToString());
            }
            if (Optional.IsDefined(ImmutabilityPeriodSinceCreationInDays))
            {
                writer.WritePropertyName("immutabilityPeriodSinceCreationInDays");
                writer.WriteNumberValue(ImmutabilityPeriodSinceCreationInDays.Value);
            }
            if (Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("timestamp");
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            if (Optional.IsDefined(ObjectIdentifier))
            {
                writer.WritePropertyName("objectIdentifier");
                writer.WriteStringValue(ObjectIdentifier);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId");
                writer.WriteStringValue(TenantId);
            }
            if (Optional.IsDefined(Upn))
            {
                writer.WritePropertyName("upn");
                writer.WriteStringValue(Upn);
            }
            writer.WriteEndObject();
        }

        internal static UpdateHistoryProperty DeserializeUpdateHistoryProperty(JsonElement element)
        {
            Optional<ImmutabilityPolicyUpdateType> update = default;
            Optional<int> immutabilityPeriodSinceCreationInDays = default;
            Optional<DateTimeOffset> timestamp = default;
            Optional<string> objectIdentifier = default;
            Optional<string> tenantId = default;
            Optional<string> upn = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("update"))
                {
                    update = new ImmutabilityPolicyUpdateType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("immutabilityPeriodSinceCreationInDays"))
                {
                    immutabilityPeriodSinceCreationInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timestamp"))
                {
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("objectIdentifier"))
                {
                    objectIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"))
                {
                    tenantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upn"))
                {
                    upn = property.Value.GetString();
                    continue;
                }
            }
            return new UpdateHistoryProperty(update.HasValue ? update.Value : (ImmutabilityPolicyUpdateType?)null, immutabilityPeriodSinceCreationInDays.HasValue ? immutabilityPeriodSinceCreationInDays.Value : (int?)null, timestamp.HasValue ? timestamp.Value : (DateTimeOffset?)null, objectIdentifier.HasValue ? objectIdentifier.Value : null, tenantId.HasValue ? tenantId.Value : null, upn.HasValue ? upn.Value : null);
        }
    }
}
