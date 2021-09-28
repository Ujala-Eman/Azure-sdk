// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPolicyInsights : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("isEnabled");
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(RetentionDays))
            {
                writer.WritePropertyName("retentionDays");
                writer.WriteNumberValue(RetentionDays.Value);
            }
            if (Optional.IsDefined(LogAnalyticsResources))
            {
                writer.WritePropertyName("logAnalyticsResources");
                writer.WriteObjectValue(LogAnalyticsResources);
            }
            writer.WriteEndObject();
        }

        internal static FirewallPolicyInsights DeserializeFirewallPolicyInsights(JsonElement element)
        {
            Optional<bool> isEnabled = default;
            Optional<int> retentionDays = default;
            Optional<FirewallPolicyLogAnalyticsResources> logAnalyticsResources = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("retentionDays"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retentionDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("logAnalyticsResources"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    logAnalyticsResources = FirewallPolicyLogAnalyticsResources.DeserializeFirewallPolicyLogAnalyticsResources(property.Value);
                    continue;
                }
            }
            return new FirewallPolicyInsights(Optional.ToNullable(isEnabled), Optional.ToNullable(retentionDays), logAnalyticsResources.Value);
        }
    }
}
