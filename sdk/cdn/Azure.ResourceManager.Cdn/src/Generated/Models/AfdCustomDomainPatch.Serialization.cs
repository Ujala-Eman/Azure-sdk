// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class AfdCustomDomainPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(TlsSettings))
            {
                writer.WritePropertyName("tlsSettings");
                writer.WriteObjectValue(TlsSettings);
            }
            if (Optional.IsDefined(DnsZone))
            {
                writer.WritePropertyName("azureDnsZone");
                JsonSerializer.Serialize(writer, DnsZone);
            }
            if (Optional.IsDefined(PreValidatedCustomDomainResource))
            {
                if (PreValidatedCustomDomainResource != null)
                {
                    writer.WritePropertyName("preValidatedCustomDomainResourceId");
                    writer.WriteObjectValue(PreValidatedCustomDomainResource);
                }
                else
                {
                    writer.WriteNull("preValidatedCustomDomainResourceId");
                }
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
