// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class Scope : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Cluster))
            {
                if (Cluster != null)
                {
                    writer.WritePropertyName("cluster");
                    writer.WriteObjectValue(Cluster);
                }
                else
                {
                    writer.WriteNull("cluster");
                }
            }
            if (Optional.IsDefined(Namespace))
            {
                if (Namespace != null)
                {
                    writer.WritePropertyName("namespace");
                    writer.WriteObjectValue(Namespace);
                }
                else
                {
                    writer.WriteNull("namespace");
                }
            }
            writer.WriteEndObject();
        }

        internal static Scope DeserializeScope(JsonElement element)
        {
            Optional<ScopeCluster> cluster = default;
            Optional<ScopeNamespace> @namespace = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cluster"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cluster = null;
                        continue;
                    }
                    cluster = ScopeCluster.DeserializeScopeCluster(property.Value);
                    continue;
                }
                if (property.NameEquals("namespace"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        @namespace = null;
                        continue;
                    }
                    @namespace = ScopeNamespace.DeserializeScopeNamespace(property.Value);
                    continue;
                }
            }
            return new Scope(cluster.Value, @namespace.Value);
        }
    }
}
