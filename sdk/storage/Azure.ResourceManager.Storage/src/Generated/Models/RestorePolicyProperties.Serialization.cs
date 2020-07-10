// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class RestorePolicyProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("enabled");
            writer.WriteBooleanValue(Enabled);
            if (Days != null)
            {
                writer.WritePropertyName("days");
                writer.WriteNumberValue(Days.Value);
            }
            if (LastEnabledTime != null)
            {
                writer.WritePropertyName("lastEnabledTime");
                writer.WriteStringValue(LastEnabledTime.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static RestorePolicyProperties DeserializeRestorePolicyProperties(JsonElement element)
        {
            bool enabled = default;
            int? days = default;
            DateTimeOffset? lastEnabledTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("days"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    days = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lastEnabledTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastEnabledTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new RestorePolicyProperties(enabled, days, lastEnabledTime);
        }
    }
}
