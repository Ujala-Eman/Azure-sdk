// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class StorageSyncRegisteredServerCreateOrUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ServerCertificate))
            {
                writer.WritePropertyName("serverCertificate"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ServerCertificate);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ServerCertificate.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion"u8);
                writer.WriteStringValue(AgentVersion);
            }
            if (Optional.IsDefined(ServerOSVersion))
            {
                writer.WritePropertyName("serverOSVersion"u8);
                writer.WriteStringValue(ServerOSVersion);
            }
            if (Optional.IsDefined(LastHeartbeat))
            {
                writer.WritePropertyName("lastHeartBeat"u8);
                writer.WriteStringValue(LastHeartbeat);
            }
            if (Optional.IsDefined(ServerRole))
            {
                writer.WritePropertyName("serverRole"u8);
                writer.WriteStringValue(ServerRole);
            }
            if (Optional.IsDefined(ClusterId))
            {
                writer.WritePropertyName("clusterId"u8);
                writer.WriteStringValue(ClusterId.Value);
            }
            if (Optional.IsDefined(ClusterName))
            {
                writer.WritePropertyName("clusterName"u8);
                writer.WriteStringValue(ClusterName);
            }
            if (Optional.IsDefined(ServerId))
            {
                writer.WritePropertyName("serverId"u8);
                writer.WriteStringValue(ServerId.Value);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ApplicationId))
            {
                writer.WritePropertyName("ApplicationId"u8);
                writer.WriteStringValue(ApplicationId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StorageSyncRegisteredServerCreateOrUpdateContent DeserializeStorageSyncRegisteredServerCreateOrUpdateContent(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<BinaryData> serverCertificate = default;
            Optional<string> agentVersion = default;
            Optional<string> serverOSVersion = default;
            Optional<string> lastHeartbeat = default;
            Optional<string> serverRole = default;
            Optional<Guid> clusterId = default;
            Optional<string> clusterName = default;
            Optional<Guid> serverId = default;
            Optional<string> friendlyName = default;
            Optional<string> applicationId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("serverCertificate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serverCertificate = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("agentVersion"u8))
                        {
                            agentVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverOSVersion"u8))
                        {
                            serverOSVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastHeartBeat"u8))
                        {
                            lastHeartbeat = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverRole"u8))
                        {
                            serverRole = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("clusterName"u8))
                        {
                            clusterName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serverId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ApplicationId"u8))
                        {
                            applicationId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StorageSyncRegisteredServerCreateOrUpdateContent(id, name, type, systemData.Value, serverCertificate.Value, agentVersion.Value, serverOSVersion.Value, lastHeartbeat.Value, serverRole.Value, Optional.ToNullable(clusterId), clusterName.Value, Optional.ToNullable(serverId), friendlyName.Value, applicationId.Value);
        }
    }
}
