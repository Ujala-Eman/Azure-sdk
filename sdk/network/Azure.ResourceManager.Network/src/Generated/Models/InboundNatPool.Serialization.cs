// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class InboundNatPool : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(FrontendIPConfiguration))
            {
                writer.WritePropertyName("frontendIPConfiguration");
                writer.WriteObjectValue(FrontendIPConfiguration);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(FrontendPortRangeStart))
            {
                writer.WritePropertyName("frontendPortRangeStart");
                writer.WriteNumberValue(FrontendPortRangeStart.Value);
            }
            if (Optional.IsDefined(FrontendPortRangeEnd))
            {
                writer.WritePropertyName("frontendPortRangeEnd");
                writer.WriteNumberValue(FrontendPortRangeEnd.Value);
            }
            if (Optional.IsDefined(BackendPort))
            {
                writer.WritePropertyName("backendPort");
                writer.WriteNumberValue(BackendPort.Value);
            }
            if (Optional.IsDefined(IdleTimeoutInMinutes))
            {
                writer.WritePropertyName("idleTimeoutInMinutes");
                writer.WriteNumberValue(IdleTimeoutInMinutes.Value);
            }
            if (Optional.IsDefined(EnableFloatingIP))
            {
                writer.WritePropertyName("enableFloatingIP");
                writer.WriteBooleanValue(EnableFloatingIP.Value);
            }
            if (Optional.IsDefined(EnableTcpReset))
            {
                writer.WritePropertyName("enableTcpReset");
                writer.WriteBooleanValue(EnableTcpReset.Value);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static InboundNatPool DeserializeInboundNatPool(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            Optional<string> id = default;
            Optional<SubResource> frontendIPConfiguration = default;
            Optional<TransportProtocol> protocol = default;
            Optional<int> frontendPortRangeStart = default;
            Optional<int> frontendPortRangeEnd = default;
            Optional<int> backendPort = default;
            Optional<int> idleTimeoutInMinutes = default;
            Optional<bool> enableFloatingIP = default;
            Optional<bool> enableTcpReset = default;
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
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("frontendIPConfiguration"))
                        {
                            frontendIPConfiguration = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("protocol"))
                        {
                            protocol = new TransportProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("frontendPortRangeStart"))
                        {
                            frontendPortRangeStart = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("frontendPortRangeEnd"))
                        {
                            frontendPortRangeEnd = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("backendPort"))
                        {
                            backendPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("idleTimeoutInMinutes"))
                        {
                            idleTimeoutInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enableFloatingIP"))
                        {
                            enableFloatingIP = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableTcpReset"))
                        {
                            enableTcpReset = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new InboundNatPool(id.HasValue ? id.Value : null, name.HasValue ? name.Value : null, etag.HasValue ? etag.Value : null, type.HasValue ? type.Value : null, frontendIPConfiguration.HasValue ? frontendIPConfiguration.Value : null, protocol.HasValue ? protocol.Value : (TransportProtocol?)null, frontendPortRangeStart.HasValue ? frontendPortRangeStart.Value : (int?)null, frontendPortRangeEnd.HasValue ? frontendPortRangeEnd.Value : (int?)null, backendPort.HasValue ? backendPort.Value : (int?)null, idleTimeoutInMinutes.HasValue ? idleTimeoutInMinutes.Value : (int?)null, enableFloatingIP.HasValue ? enableFloatingIP.Value : (bool?)null, enableTcpReset.HasValue ? enableTcpReset.Value : (bool?)null, provisioningState.HasValue ? provisioningState.Value : (ProvisioningState?)null);
        }
    }
}
