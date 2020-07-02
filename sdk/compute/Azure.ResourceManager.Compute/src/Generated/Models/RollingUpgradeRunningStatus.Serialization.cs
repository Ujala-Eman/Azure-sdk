// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RollingUpgradeRunningStatus : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Code))
            {
                writer.WritePropertyName("code");
                writer.WriteStringValue(Code.Value.ToSerialString());
            }
            if (Optional.IsDefined(StartTime))
            {
                writer.WritePropertyName("startTime");
                writer.WriteStringValue(StartTime.Value, "O");
            }
            if (Optional.IsDefined(LastAction))
            {
                writer.WritePropertyName("lastAction");
                writer.WriteStringValue(LastAction.Value.ToSerialString());
            }
            if (Optional.IsDefined(LastActionTime))
            {
                writer.WritePropertyName("lastActionTime");
                writer.WriteStringValue(LastActionTime.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static RollingUpgradeRunningStatus DeserializeRollingUpgradeRunningStatus(JsonElement element)
        {
            Optional<RollingUpgradeStatusCode> code = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<RollingUpgradeActionType> lastAction = default;
            Optional<DateTimeOffset> lastActionTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString().ToRollingUpgradeStatusCode();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastAction"))
                {
                    lastAction = property.Value.GetString().ToRollingUpgradeActionType();
                    continue;
                }
                if (property.NameEquals("lastActionTime"))
                {
                    lastActionTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new RollingUpgradeRunningStatus(code.HasValue ? code.Value : (RollingUpgradeStatusCode?)null, startTime.HasValue ? startTime.Value : (DateTimeOffset?)null, lastAction.HasValue ? lastAction.Value : (RollingUpgradeActionType?)null, lastActionTime.HasValue ? lastActionTime.Value : (DateTimeOffset?)null);
        }
    }
}
