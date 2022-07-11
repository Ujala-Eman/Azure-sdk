// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class AaddsResourceDetails
    {
        internal static AaddsResourceDetails DeserializeAaddsResourceDetails(JsonElement element)
        {
            Optional<string> domainName = default;
            Optional<bool> initialSyncComplete = default;
            Optional<bool> ldapsEnabled = default;
            Optional<string> ldapsPublicCertificateInBase64 = default;
            Optional<string> resourceId = default;
            Optional<string> subnetId = default;
            Optional<Guid> tenantId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialSyncComplete"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    initialSyncComplete = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ldapsEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ldapsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ldapsPublicCertificateInBase64"))
                {
                    ldapsPublicCertificateInBase64 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnetId"))
                {
                    subnetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
            }
            return new AaddsResourceDetails(domainName.Value, Optional.ToNullable(initialSyncComplete), Optional.ToNullable(ldapsEnabled), ldapsPublicCertificateInBase64.Value, resourceId.Value, subnetId.Value, Optional.ToNullable(tenantId));
        }
    }
}
