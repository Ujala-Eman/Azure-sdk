// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class KubernetesRoleResources : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Storage))
            {
                writer.WritePropertyName("storage");
                writer.WriteObjectValue(Storage);
            }
            writer.WritePropertyName("compute");
            writer.WriteObjectValue(Compute);
            writer.WriteEndObject();
        }

        internal static KubernetesRoleResources DeserializeKubernetesRoleResources(JsonElement element)
        {
            Optional<KubernetesRoleStorage> storage = default;
            KubernetesRoleCompute compute = default;
            Optional<KubernetesRoleNetwork> network = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storage = KubernetesRoleStorage.DeserializeKubernetesRoleStorage(property.Value);
                    continue;
                }
                if (property.NameEquals("compute"))
                {
                    compute = KubernetesRoleCompute.DeserializeKubernetesRoleCompute(property.Value);
                    continue;
                }
                if (property.NameEquals("network"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    network = KubernetesRoleNetwork.DeserializeKubernetesRoleNetwork(property.Value);
                    continue;
                }
            }
            return new KubernetesRoleResources(storage.Value, compute, network.Value);
        }
    }
}
