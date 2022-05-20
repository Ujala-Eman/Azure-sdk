// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class AKSSchemaProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClusterFqdn))
            {
                writer.WritePropertyName("clusterFqdn");
                writer.WriteStringValue(ClusterFqdn);
            }
            if (Optional.IsDefined(AgentCount))
            {
                writer.WritePropertyName("agentCount");
                writer.WriteNumberValue(AgentCount.Value);
            }
            if (Optional.IsDefined(AgentVmSize))
            {
                writer.WritePropertyName("agentVmSize");
                writer.WriteStringValue(AgentVmSize);
            }
            if (Optional.IsDefined(ClusterPurpose))
            {
                writer.WritePropertyName("clusterPurpose");
                writer.WriteStringValue(ClusterPurpose.Value.ToString());
            }
            if (Optional.IsDefined(SslConfiguration))
            {
                writer.WritePropertyName("sslConfiguration");
                writer.WriteObjectValue(SslConfiguration);
            }
            if (Optional.IsDefined(AksNetworkingConfiguration))
            {
                writer.WritePropertyName("aksNetworkingConfiguration");
                writer.WriteObjectValue(AksNetworkingConfiguration);
            }
            if (Optional.IsDefined(LoadBalancerType))
            {
                writer.WritePropertyName("loadBalancerType");
                writer.WriteStringValue(LoadBalancerType.Value.ToString());
            }
            if (Optional.IsDefined(LoadBalancerSubnet))
            {
                writer.WritePropertyName("loadBalancerSubnet");
                writer.WriteStringValue(LoadBalancerSubnet);
            }
            writer.WriteEndObject();
        }

        internal static AKSSchemaProperties DeserializeAKSSchemaProperties(JsonElement element)
        {
            Optional<string> clusterFqdn = default;
            Optional<IReadOnlyList<SystemService>> systemServices = default;
            Optional<int> agentCount = default;
            Optional<string> agentVmSize = default;
            Optional<ClusterPurpose> clusterPurpose = default;
            Optional<SslConfiguration> sslConfiguration = default;
            Optional<AksNetworkingConfiguration> aksNetworkingConfiguration = default;
            Optional<LoadBalancerType> loadBalancerType = default;
            Optional<string> loadBalancerSubnet = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterFqdn"))
                {
                    clusterFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemServices"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SystemService> array = new List<SystemService>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SystemService.DeserializeSystemService(item));
                    }
                    systemServices = array;
                    continue;
                }
                if (property.NameEquals("agentCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    agentCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("agentVmSize"))
                {
                    agentVmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterPurpose"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    clusterPurpose = new ClusterPurpose(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sslConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sslConfiguration = SslConfiguration.DeserializeSslConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("aksNetworkingConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    aksNetworkingConfiguration = AksNetworkingConfiguration.DeserializeAksNetworkingConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("loadBalancerType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    loadBalancerType = new LoadBalancerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("loadBalancerSubnet"))
                {
                    loadBalancerSubnet = property.Value.GetString();
                    continue;
                }
            }
            return new AKSSchemaProperties(clusterFqdn.Value, Optional.ToList(systemServices), Optional.ToNullable(agentCount), agentVmSize.Value, Optional.ToNullable(clusterPurpose), sslConfiguration.Value, aksNetworkingConfiguration.Value, Optional.ToNullable(loadBalancerType), loadBalancerSubnet.Value);
        }
    }
}
