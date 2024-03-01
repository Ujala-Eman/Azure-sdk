// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnClientConfiguration : IUtf8JsonSerializable, IJsonModel<VpnClientConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnClientConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VpnClientConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnClientConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnClientConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (VpnClientAddressPool != null)
            {
                writer.WritePropertyName("vpnClientAddressPool"u8);
                writer.WriteObjectValue(VpnClientAddressPool);
            }
            if (!(VpnClientRootCertificates is ChangeTrackingList<VpnClientRootCertificate> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("vpnClientRootCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in VpnClientRootCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(VpnClientRevokedCertificates is ChangeTrackingList<VpnClientRevokedCertificate> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("vpnClientRevokedCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in VpnClientRevokedCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(VpnClientProtocols is ChangeTrackingList<VpnClientProtocol> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("vpnClientProtocols"u8);
                writer.WriteStartArray();
                foreach (var item in VpnClientProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (!(VpnAuthenticationTypes is ChangeTrackingList<VpnAuthenticationType> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("vpnAuthenticationTypes"u8);
                writer.WriteStartArray();
                foreach (var item in VpnAuthenticationTypes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (!(VpnClientIPsecPolicies is ChangeTrackingList<IPsecPolicy> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("vpnClientIpsecPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in VpnClientIPsecPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (RadiusServerAddress != null)
            {
                writer.WritePropertyName("radiusServerAddress"u8);
                writer.WriteStringValue(RadiusServerAddress);
            }
            if (RadiusServerSecret != null)
            {
                writer.WritePropertyName("radiusServerSecret"u8);
                writer.WriteStringValue(RadiusServerSecret);
            }
            if (!(RadiusServers is ChangeTrackingList<RadiusServer> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("radiusServers"u8);
                writer.WriteStartArray();
                foreach (var item in RadiusServers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (AadTenant != null)
            {
                writer.WritePropertyName("aadTenant"u8);
                writer.WriteStringValue(AadTenant);
            }
            if (AadAudience != null)
            {
                writer.WritePropertyName("aadAudience"u8);
                writer.WriteStringValue(AadAudience);
            }
            if (AadIssuer != null)
            {
                writer.WritePropertyName("aadIssuer"u8);
                writer.WriteStringValue(AadIssuer);
            }
            if (!(VngClientConnectionConfigurations is ChangeTrackingList<VngClientConnectionConfiguration> collection5 && collection5.IsUndefined))
            {
                writer.WritePropertyName("vngClientConnectionConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in VngClientConnectionConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        VpnClientConfiguration IJsonModel<VpnClientConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnClientConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnClientConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnClientConfiguration(document.RootElement, options);
        }

        internal static VpnClientConfiguration DeserializeVpnClientConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AddressSpace vpnClientAddressPool = default;
            IList<VpnClientRootCertificate> vpnClientRootCertificates = default;
            IList<VpnClientRevokedCertificate> vpnClientRevokedCertificates = default;
            IList<VpnClientProtocol> vpnClientProtocols = default;
            IList<VpnAuthenticationType> vpnAuthenticationTypes = default;
            IList<IPsecPolicy> vpnClientIPsecPolicies = default;
            string radiusServerAddress = default;
            string radiusServerSecret = default;
            IList<RadiusServer> radiusServers = default;
            string aadTenant = default;
            string aadAudience = default;
            string aadIssuer = default;
            IList<VngClientConnectionConfiguration> vngClientConnectionConfigurations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vpnClientAddressPool"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vpnClientAddressPool = AddressSpace.DeserializeAddressSpace(property.Value, options);
                    continue;
                }
                if (property.NameEquals("vpnClientRootCertificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VpnClientRootCertificate> array = new List<VpnClientRootCertificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VpnClientRootCertificate.DeserializeVpnClientRootCertificate(item, options));
                    }
                    vpnClientRootCertificates = array;
                    continue;
                }
                if (property.NameEquals("vpnClientRevokedCertificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VpnClientRevokedCertificate> array = new List<VpnClientRevokedCertificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VpnClientRevokedCertificate.DeserializeVpnClientRevokedCertificate(item, options));
                    }
                    vpnClientRevokedCertificates = array;
                    continue;
                }
                if (property.NameEquals("vpnClientProtocols"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VpnClientProtocol> array = new List<VpnClientProtocol>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new VpnClientProtocol(item.GetString()));
                    }
                    vpnClientProtocols = array;
                    continue;
                }
                if (property.NameEquals("vpnAuthenticationTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VpnAuthenticationType> array = new List<VpnAuthenticationType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new VpnAuthenticationType(item.GetString()));
                    }
                    vpnAuthenticationTypes = array;
                    continue;
                }
                if (property.NameEquals("vpnClientIpsecPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPsecPolicy> array = new List<IPsecPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPsecPolicy.DeserializeIPsecPolicy(item, options));
                    }
                    vpnClientIPsecPolicies = array;
                    continue;
                }
                if (property.NameEquals("radiusServerAddress"u8))
                {
                    radiusServerAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("radiusServerSecret"u8))
                {
                    radiusServerSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("radiusServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RadiusServer> array = new List<RadiusServer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RadiusServer.DeserializeRadiusServer(item, options));
                    }
                    radiusServers = array;
                    continue;
                }
                if (property.NameEquals("aadTenant"u8))
                {
                    aadTenant = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aadAudience"u8))
                {
                    aadAudience = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aadIssuer"u8))
                {
                    aadIssuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vngClientConnectionConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VngClientConnectionConfiguration> array = new List<VngClientConnectionConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VngClientConnectionConfiguration.DeserializeVngClientConnectionConfiguration(item, options));
                    }
                    vngClientConnectionConfigurations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VpnClientConfiguration(
                vpnClientAddressPool,
                vpnClientRootCertificates ?? new ChangeTrackingList<VpnClientRootCertificate>(),
                vpnClientRevokedCertificates ?? new ChangeTrackingList<VpnClientRevokedCertificate>(),
                vpnClientProtocols ?? new ChangeTrackingList<VpnClientProtocol>(),
                vpnAuthenticationTypes ?? new ChangeTrackingList<VpnAuthenticationType>(),
                vpnClientIPsecPolicies ?? new ChangeTrackingList<IPsecPolicy>(),
                radiusServerAddress,
                radiusServerSecret,
                radiusServers ?? new ChangeTrackingList<RadiusServer>(),
                aadTenant,
                aadAudience,
                aadIssuer,
                vngClientConnectionConfigurations ?? new ChangeTrackingList<VngClientConnectionConfiguration>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VpnClientConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnClientConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VpnClientConfiguration)} does not support '{options.Format}' format.");
            }
        }

        VpnClientConfiguration IPersistableModel<VpnClientConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnClientConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVpnClientConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VpnClientConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VpnClientConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
