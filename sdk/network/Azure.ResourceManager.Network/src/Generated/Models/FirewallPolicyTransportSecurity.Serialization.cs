// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPolicyTransportSecurity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CertificateAuthority))
            {
                writer.WritePropertyName("certificateAuthority");
                writer.WriteObjectValue(CertificateAuthority);
            }
            writer.WriteEndObject();
        }

        internal static FirewallPolicyTransportSecurity DeserializeFirewallPolicyTransportSecurity(JsonElement element)
        {
            Optional<FirewallPolicyCertificateAuthority> certificateAuthority = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateAuthority"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    certificateAuthority = FirewallPolicyCertificateAuthority.DeserializeFirewallPolicyCertificateAuthority(property.Value);
                    continue;
                }
            }
            return new FirewallPolicyTransportSecurity(certificateAuthority.Value);
        }
    }
}
