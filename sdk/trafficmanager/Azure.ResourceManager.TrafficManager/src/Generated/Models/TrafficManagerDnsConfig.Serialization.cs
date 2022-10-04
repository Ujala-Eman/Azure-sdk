// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.TrafficManager.Models
{
    public partial class TrafficManagerDnsConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RelativeName))
            {
                writer.WritePropertyName("relativeName");
                writer.WriteStringValue(RelativeName);
            }
            if (Optional.IsDefined(Ttl))
            {
                writer.WritePropertyName("ttl");
                writer.WriteNumberValue(Ttl.Value);
            }
            writer.WriteEndObject();
        }

        internal static TrafficManagerDnsConfig DeserializeTrafficManagerDnsConfig(JsonElement element)
        {
            Optional<string> relativeName = default;
            Optional<string> fqdn = default;
            Optional<long> ttl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("relativeName"))
                {
                    relativeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fqdn"))
                {
                    fqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ttl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ttl = property.Value.GetInt64();
                    continue;
                }
            }
            return new TrafficManagerDnsConfig(relativeName.Value, fqdn.Value, Optional.ToNullable(ttl));
        }
    }
}
