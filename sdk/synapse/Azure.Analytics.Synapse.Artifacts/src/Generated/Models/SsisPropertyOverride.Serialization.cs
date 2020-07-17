// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class SsisPropertyOverride : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("value");
            writer.WriteObjectValue(Value);
            if (Optional.IsDefined(IsSensitive))
            {
                writer.WritePropertyName("isSensitive");
                writer.WriteBooleanValue(IsSensitive.Value);
            }
            writer.WriteEndObject();
        }

        internal static SsisPropertyOverride DeserializeSsisPropertyOverride(JsonElement element)
        {
            object value = default;
            Optional<bool> isSensitive = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("isSensitive"))
                {
                    isSensitive = property.Value.GetBoolean();
                    continue;
                }
            }
            return new SsisPropertyOverride(value, Optional.ToNullable(isSensitive));
        }
    }
}
