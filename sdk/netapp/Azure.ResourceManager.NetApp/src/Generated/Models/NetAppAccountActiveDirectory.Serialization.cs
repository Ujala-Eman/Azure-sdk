// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppAccountActiveDirectory : IUtf8JsonSerializable, IJsonModel<NetAppAccountActiveDirectory>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppAccountActiveDirectory>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetAppAccountActiveDirectory>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppAccountActiveDirectory>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppAccountActiveDirectory)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ActiveDirectoryId != null)
            {
                if (ActiveDirectoryId != null)
                {
                    writer.WritePropertyName("activeDirectoryId"u8);
                    writer.WriteStringValue(ActiveDirectoryId);
                }
                else
                {
                    writer.WriteNull("activeDirectoryId");
                }
            }
            if (Username != null)
            {
                writer.WritePropertyName("username"u8);
                writer.WriteStringValue(Username);
            }
            if (Password != null)
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (Domain != null)
            {
                writer.WritePropertyName("domain"u8);
                writer.WriteStringValue(Domain);
            }
            if (Dns != null)
            {
                writer.WritePropertyName("dns"u8);
                writer.WriteStringValue(Dns);
            }
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && StatusDetails != null)
            {
                writer.WritePropertyName("statusDetails"u8);
                writer.WriteStringValue(StatusDetails);
            }
            if (SmbServerName != null)
            {
                writer.WritePropertyName("smbServerName"u8);
                writer.WriteStringValue(SmbServerName);
            }
            if (OrganizationalUnit != null)
            {
                writer.WritePropertyName("organizationalUnit"u8);
                writer.WriteStringValue(OrganizationalUnit);
            }
            if (Site != null)
            {
                writer.WritePropertyName("site"u8);
                writer.WriteStringValue(Site);
            }
            if (!(BackupOperators is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("backupOperators"u8);
                writer.WriteStartArray();
                foreach (var item in BackupOperators)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Administrators is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("administrators"u8);
                writer.WriteStartArray();
                foreach (var item in Administrators)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (KdcIP != null)
            {
                writer.WritePropertyName("kdcIP"u8);
                writer.WriteStringValue(KdcIP.ToString());
            }
            if (AdName != null)
            {
                writer.WritePropertyName("adName"u8);
                writer.WriteStringValue(AdName);
            }
            if (ServerRootCACertificate != null)
            {
                writer.WritePropertyName("serverRootCACertificate"u8);
                writer.WriteStringValue(ServerRootCACertificate);
            }
            if (IsAesEncryptionEnabled.HasValue)
            {
                writer.WritePropertyName("aesEncryption"u8);
                writer.WriteBooleanValue(IsAesEncryptionEnabled.Value);
            }
            if (IsLdapSigningEnabled.HasValue)
            {
                writer.WritePropertyName("ldapSigning"u8);
                writer.WriteBooleanValue(IsLdapSigningEnabled.Value);
            }
            if (!(SecurityOperators is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("securityOperators"u8);
                writer.WriteStartArray();
                foreach (var item in SecurityOperators)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (IsLdapOverTlsEnabled.HasValue)
            {
                writer.WritePropertyName("ldapOverTLS"u8);
                writer.WriteBooleanValue(IsLdapOverTlsEnabled.Value);
            }
            if (AllowLocalNfsUsersWithLdap.HasValue)
            {
                writer.WritePropertyName("allowLocalNfsUsersWithLdap"u8);
                writer.WriteBooleanValue(AllowLocalNfsUsersWithLdap.Value);
            }
            if (EncryptDCConnections.HasValue)
            {
                writer.WritePropertyName("encryptDCConnections"u8);
                writer.WriteBooleanValue(EncryptDCConnections.Value);
            }
            if (LdapSearchScope != null)
            {
                writer.WritePropertyName("ldapSearchScope"u8);
                writer.WriteObjectValue(LdapSearchScope);
            }
            if (PreferredServersForLdapClient != null)
            {
                writer.WritePropertyName("preferredServersForLdapClient"u8);
                writer.WriteStringValue(PreferredServersForLdapClient);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        NetAppAccountActiveDirectory IJsonModel<NetAppAccountActiveDirectory>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppAccountActiveDirectory>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppAccountActiveDirectory)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppAccountActiveDirectory(document.RootElement, options);
        }

        internal static NetAppAccountActiveDirectory DeserializeNetAppAccountActiveDirectory(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string activeDirectoryId = default;
            string username = default;
            string password = default;
            string domain = default;
            string dns = default;
            NetAppAccountActiveDirectoryStatus? status = default;
            string statusDetails = default;
            string smbServerName = default;
            string organizationalUnit = default;
            string site = default;
            IList<string> backupOperators = default;
            IList<string> administrators = default;
            IPAddress kdcIP = default;
            string adName = default;
            string serverRootCACertificate = default;
            bool? aesEncryption = default;
            bool? ldapSigning = default;
            IList<string> securityOperators = default;
            bool? ldapOverTls = default;
            bool? allowLocalNfsUsersWithLdap = default;
            bool? encryptDCConnections = default;
            NetAppLdapSearchScopeConfiguration ldapSearchScope = default;
            string preferredServersForLdapClient = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activeDirectoryId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        activeDirectoryId = null;
                        continue;
                    }
                    activeDirectoryId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("username"u8))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domain"u8))
                {
                    domain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dns"u8))
                {
                    dns = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new NetAppAccountActiveDirectoryStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusDetails"u8))
                {
                    statusDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("smbServerName"u8))
                {
                    smbServerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organizationalUnit"u8))
                {
                    organizationalUnit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("site"u8))
                {
                    site = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupOperators"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    backupOperators = array;
                    continue;
                }
                if (property.NameEquals("administrators"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    administrators = array;
                    continue;
                }
                if (property.NameEquals("kdcIP"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kdcIP = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("adName"u8))
                {
                    adName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverRootCACertificate"u8))
                {
                    serverRootCACertificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aesEncryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aesEncryption = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ldapSigning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ldapSigning = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("securityOperators"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    securityOperators = array;
                    continue;
                }
                if (property.NameEquals("ldapOverTLS"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ldapOverTls = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowLocalNfsUsersWithLdap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowLocalNfsUsersWithLdap = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("encryptDCConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptDCConnections = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ldapSearchScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ldapSearchScope = NetAppLdapSearchScopeConfiguration.DeserializeNetAppLdapSearchScopeConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("preferredServersForLdapClient"u8))
                {
                    preferredServersForLdapClient = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetAppAccountActiveDirectory(
                activeDirectoryId,
                username,
                password,
                domain,
                dns,
                status,
                statusDetails,
                smbServerName,
                organizationalUnit,
                site,
                backupOperators ?? new ChangeTrackingList<string>(),
                administrators ?? new ChangeTrackingList<string>(),
                kdcIP,
                adName,
                serverRootCACertificate,
                aesEncryption,
                ldapSigning,
                securityOperators ?? new ChangeTrackingList<string>(),
                ldapOverTls,
                allowLocalNfsUsersWithLdap,
                encryptDCConnections,
                ldapSearchScope,
                preferredServersForLdapClient,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppAccountActiveDirectory>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppAccountActiveDirectory>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetAppAccountActiveDirectory)} does not support '{options.Format}' format.");
            }
        }

        NetAppAccountActiveDirectory IPersistableModel<NetAppAccountActiveDirectory>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppAccountActiveDirectory>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetAppAccountActiveDirectory(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetAppAccountActiveDirectory)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppAccountActiveDirectory>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
