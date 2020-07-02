// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
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
            if (Optional.IsDefined(ExcludedDomains))
            {
                writer.WritePropertyName("excludedDomains");
                writer.WriteStartArray();
                foreach (var item in ExcludedDomains)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TrustedRootCertificates))
            {
                writer.WritePropertyName("trustedRootCertificates");
                writer.WriteStartArray();
                foreach (var item in TrustedRootCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static FirewallPolicyTransportSecurity DeserializeFirewallPolicyTransportSecurity(JsonElement element)
        {
            Optional<FirewallPolicyCertificateAuthority> certificateAuthority = default;
            Optional<IList<string>> excludedDomains = default;
            Optional<IList<FirewallPolicyTrustedRootCertificate>> trustedRootCertificates = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateAuthority"))
                {
                    certificateAuthority = FirewallPolicyCertificateAuthority.DeserializeFirewallPolicyCertificateAuthority(property.Value);
                    continue;
                }
                if (property.NameEquals("excludedDomains"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    excludedDomains = array;
                    continue;
                }
                if (property.NameEquals("trustedRootCertificates"))
                {
                    List<FirewallPolicyTrustedRootCertificate> array = new List<FirewallPolicyTrustedRootCertificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(FirewallPolicyTrustedRootCertificate.DeserializeFirewallPolicyTrustedRootCertificate(item));
                        }
                    }
                    trustedRootCertificates = array;
                    continue;
                }
            }
            return new FirewallPolicyTransportSecurity(certificateAuthority.HasValue ? certificateAuthority.Value : null, new ChangeTrackingList<string>(excludedDomains), new ChangeTrackingList<FirewallPolicyTrustedRootCertificate>(trustedRootCertificates));
        }
    }
}
