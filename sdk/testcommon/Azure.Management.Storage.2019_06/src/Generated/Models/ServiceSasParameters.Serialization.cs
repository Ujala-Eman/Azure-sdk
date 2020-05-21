// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class ServiceSasParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("canonicalizedResource");
            writer.WriteStringValue(CanonicalizedResource);
            if (Resource != null)
            {
                writer.WritePropertyName("signedResource");
                writer.WriteStringValue(Resource.Value.ToString());
            }
            if (Permissions != null)
            {
                writer.WritePropertyName("signedPermission");
                writer.WriteStringValue(Permissions.Value.ToString());
            }
            if (IPAddressOrRange != null)
            {
                writer.WritePropertyName("signedIp");
                writer.WriteStringValue(IPAddressOrRange);
            }
            if (Protocols != null)
            {
                writer.WritePropertyName("signedProtocol");
                writer.WriteStringValue(Protocols.Value.ToSerialString());
            }
            if (SharedAccessStartTime != null)
            {
                writer.WritePropertyName("signedStart");
                writer.WriteStringValue(SharedAccessStartTime.Value, "O");
            }
            if (SharedAccessExpiryTime != null)
            {
                writer.WritePropertyName("signedExpiry");
                writer.WriteStringValue(SharedAccessExpiryTime.Value, "O");
            }
            if (Identifier != null)
            {
                writer.WritePropertyName("signedIdentifier");
                writer.WriteStringValue(Identifier);
            }
            if (PartitionKeyStart != null)
            {
                writer.WritePropertyName("startPk");
                writer.WriteStringValue(PartitionKeyStart);
            }
            if (PartitionKeyEnd != null)
            {
                writer.WritePropertyName("endPk");
                writer.WriteStringValue(PartitionKeyEnd);
            }
            if (RowKeyStart != null)
            {
                writer.WritePropertyName("startRk");
                writer.WriteStringValue(RowKeyStart);
            }
            if (RowKeyEnd != null)
            {
                writer.WritePropertyName("endRk");
                writer.WriteStringValue(RowKeyEnd);
            }
            if (KeyToSign != null)
            {
                writer.WritePropertyName("keyToSign");
                writer.WriteStringValue(KeyToSign);
            }
            if (CacheControl != null)
            {
                writer.WritePropertyName("rscc");
                writer.WriteStringValue(CacheControl);
            }
            if (ContentDisposition != null)
            {
                writer.WritePropertyName("rscd");
                writer.WriteStringValue(ContentDisposition);
            }
            if (ContentEncoding != null)
            {
                writer.WritePropertyName("rsce");
                writer.WriteStringValue(ContentEncoding);
            }
            if (ContentLanguage != null)
            {
                writer.WritePropertyName("rscl");
                writer.WriteStringValue(ContentLanguage);
            }
            if (ContentType != null)
            {
                writer.WritePropertyName("rsct");
                writer.WriteStringValue(ContentType);
            }
            writer.WriteEndObject();
        }
    }
}
