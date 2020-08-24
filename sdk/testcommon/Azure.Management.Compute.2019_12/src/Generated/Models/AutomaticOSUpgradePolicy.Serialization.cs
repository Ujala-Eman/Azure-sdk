// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class AutomaticOSUpgradePolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EnableAutomaticOSUpgrade))
            {
                writer.WritePropertyName("enableAutomaticOSUpgrade");
                writer.WriteBooleanValue(EnableAutomaticOSUpgrade.Value);
            }
            if (Optional.IsDefined(DisableAutomaticRollback))
            {
                writer.WritePropertyName("disableAutomaticRollback");
                writer.WriteBooleanValue(DisableAutomaticRollback.Value);
            }
            writer.WriteEndObject();
        }

        internal static AutomaticOSUpgradePolicy DeserializeAutomaticOSUpgradePolicy(JsonElement element)
        {
            Optional<bool> enableAutomaticOSUpgrade = default;
            Optional<bool> disableAutomaticRollback = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableAutomaticOSUpgrade"))
                {
                    enableAutomaticOSUpgrade = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableAutomaticRollback"))
                {
                    disableAutomaticRollback = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AutomaticOSUpgradePolicy(Optional.ToNullable(enableAutomaticOSUpgrade), Optional.ToNullable(disableAutomaticRollback));
        }
    }
}
