// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class PublicIPAddressDnsSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DomainNameLabel))
            {
                writer.WritePropertyName("domainNameLabel");
                writer.WriteStringValue(DomainNameLabel);
            }
            if (Optional.IsDefined(Fqdn))
            {
                writer.WritePropertyName("fqdn");
                writer.WriteStringValue(Fqdn);
            }
            if (Optional.IsDefined(ReverseFqdn))
            {
                writer.WritePropertyName("reverseFqdn");
                writer.WriteStringValue(ReverseFqdn);
            }
            writer.WriteEndObject();
        }

        internal static PublicIPAddressDnsSettings DeserializePublicIPAddressDnsSettings(JsonElement element)
        {
            Optional<string> domainNameLabel = default;
            Optional<string> fqdn = default;
            Optional<string> reverseFqdn = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainNameLabel"))
                {
                    domainNameLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fqdn"))
                {
                    fqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reverseFqdn"))
                {
                    reverseFqdn = property.Value.GetString();
                    continue;
                }
            }
            return new PublicIPAddressDnsSettings(domainNameLabel.HasValue ? domainNameLabel.Value : null, fqdn.HasValue ? fqdn.Value : null, reverseFqdn.HasValue ? reverseFqdn.Value : null);
        }
    }
}
