// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SqlServerPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AdministratorLogin))
            {
                writer.WritePropertyName("administratorLogin");
                writer.WriteStringValue(AdministratorLogin);
            }
            if (Optional.IsDefined(AdministratorLoginPassword))
            {
                writer.WritePropertyName("administratorLoginPassword");
                writer.WriteStringValue(AdministratorLoginPassword);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version");
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(MinimalTlsVersion))
            {
                writer.WritePropertyName("minimalTlsVersion");
                writer.WriteStringValue(MinimalTlsVersion);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(PrimaryUserAssignedIdentityId))
            {
                writer.WritePropertyName("primaryUserAssignedIdentityId");
                writer.WriteStringValue(PrimaryUserAssignedIdentityId);
            }
            if (Optional.IsDefined(FederatedClientId))
            {
                writer.WritePropertyName("federatedClientId");
                writer.WriteStringValue(FederatedClientId.Value);
            }
            if (Optional.IsDefined(KeyId))
            {
                writer.WritePropertyName("keyId");
                writer.WriteStringValue(KeyId.AbsoluteUri);
            }
            if (Optional.IsDefined(Administrators))
            {
                writer.WritePropertyName("administrators");
                writer.WriteObjectValue(Administrators);
            }
            if (Optional.IsDefined(RestrictOutboundNetworkAccess))
            {
                writer.WritePropertyName("restrictOutboundNetworkAccess");
                writer.WriteStringValue(RestrictOutboundNetworkAccess.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
