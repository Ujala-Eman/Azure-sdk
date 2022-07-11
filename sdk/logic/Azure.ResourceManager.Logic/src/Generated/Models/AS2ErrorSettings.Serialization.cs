// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class AS2ErrorSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("suspendDuplicateMessage");
            writer.WriteBooleanValue(SuspendDuplicateMessage);
            writer.WritePropertyName("resendIfMDNNotReceived");
            writer.WriteBooleanValue(ResendIfMDNNotReceived);
            writer.WriteEndObject();
        }

        internal static AS2ErrorSettings DeserializeAS2ErrorSettings(JsonElement element)
        {
            bool suspendDuplicateMessage = default;
            bool resendIfMDNNotReceived = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("suspendDuplicateMessage"))
                {
                    suspendDuplicateMessage = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("resendIfMDNNotReceived"))
                {
                    resendIfMDNNotReceived = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AS2ErrorSettings(suspendDuplicateMessage, resendIfMDNNotReceived);
        }
    }
}
