// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ClusterServerCertificateCommonName : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("certificateCommonName");
            writer.WriteStringValue(CertificateCommonName);
            writer.WritePropertyName("certificateIssuerThumbprint");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CertificateIssuerThumbprint);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(CertificateIssuerThumbprint.ToString()).RootElement);
#endif
            writer.WriteEndObject();
        }

        internal static ClusterServerCertificateCommonName DeserializeClusterServerCertificateCommonName(JsonElement element)
        {
            string certificateCommonName = default;
            BinaryData certificateIssuerThumbprint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateCommonName"))
                {
                    certificateCommonName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificateIssuerThumbprint"))
                {
                    certificateIssuerThumbprint = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new ClusterServerCertificateCommonName(certificateCommonName, certificateIssuerThumbprint);
        }
    }
}
