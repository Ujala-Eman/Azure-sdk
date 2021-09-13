// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewaySslProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TrustedClientCertificates))
            {
                writer.WritePropertyName("trustedClientCertificates");
                writer.WriteStartArray();
                foreach (var item in TrustedClientCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SslPolicy))
            {
                writer.WritePropertyName("sslPolicy");
                writer.WriteObjectValue(SslPolicy);
            }
            if (Optional.IsDefined(ClientAuthConfiguration))
            {
                writer.WritePropertyName("clientAuthConfiguration");
                writer.WriteObjectValue(ClientAuthConfiguration);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationGatewaySslProfile DeserializeApplicationGatewaySslProfile(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            ResourceIdentifier id = default;
            Optional<IList<SubResource>> trustedClientCertificates = default;
            Optional<ApplicationGatewaySslPolicy> sslPolicy = default;
            Optional<ApplicationGatewayClientAuthConfiguration> clientAuthConfiguration = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("trustedClientCertificates"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubResource.DeserializeSubResource(item));
                            }
                            trustedClientCertificates = array;
                            continue;
                        }
                        if (property0.NameEquals("sslPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sslPolicy = ApplicationGatewaySslPolicy.DeserializeApplicationGatewaySslPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clientAuthConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clientAuthConfiguration = ApplicationGatewayClientAuthConfiguration.DeserializeApplicationGatewayClientAuthConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationGatewaySslProfile(id, name.Value, etag.Value, type.Value, Optional.ToList(trustedClientCertificates), sslPolicy.Value, clientAuthConfiguration.Value, Optional.ToNullable(provisioningState));
        }
    }
}
