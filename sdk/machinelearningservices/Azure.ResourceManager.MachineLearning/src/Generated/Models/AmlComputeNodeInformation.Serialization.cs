// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class AmlComputeNodeInformation
    {
        internal static AmlComputeNodeInformation DeserializeAmlComputeNodeInformation(JsonElement element)
        {
            Optional<string> nodeId = default;
            Optional<string> privateIpAddress = default;
            Optional<string> publicIpAddress = default;
            Optional<int> port = default;
            Optional<NodeState> nodeState = default;
            Optional<string> runId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodeId"))
                {
                    nodeId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateIpAddress"))
                {
                    privateIpAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicIpAddress"))
                {
                    publicIpAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nodeState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nodeState = new NodeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("runId"))
                {
                    runId = property.Value.GetString();
                    continue;
                }
            }
            return new AmlComputeNodeInformation(nodeId.Value, privateIpAddress.Value, publicIpAddress.Value, Optional.ToNullable(port), Optional.ToNullable(nodeState), runId.Value);
        }
    }
}
