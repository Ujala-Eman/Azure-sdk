// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class WsfcDomainCredentials : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClusterBootstrapAccountPassword))
            {
                writer.WritePropertyName("clusterBootstrapAccountPassword");
                writer.WriteStringValue(ClusterBootstrapAccountPassword);
            }
            if (Optional.IsDefined(ClusterOperatorAccountPassword))
            {
                writer.WritePropertyName("clusterOperatorAccountPassword");
                writer.WriteStringValue(ClusterOperatorAccountPassword);
            }
            if (Optional.IsDefined(SqlServiceAccountPassword))
            {
                writer.WritePropertyName("sqlServiceAccountPassword");
                writer.WriteStringValue(SqlServiceAccountPassword);
            }
            writer.WriteEndObject();
        }

        internal static WsfcDomainCredentials DeserializeWsfcDomainCredentials(JsonElement element)
        {
            Optional<string> clusterBootstrapAccountPassword = default;
            Optional<string> clusterOperatorAccountPassword = default;
            Optional<string> sqlServiceAccountPassword = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterBootstrapAccountPassword"))
                {
                    clusterBootstrapAccountPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterOperatorAccountPassword"))
                {
                    clusterOperatorAccountPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sqlServiceAccountPassword"))
                {
                    sqlServiceAccountPassword = property.Value.GetString();
                    continue;
                }
            }
            return new WsfcDomainCredentials(clusterBootstrapAccountPassword.Value, clusterOperatorAccountPassword.Value, sqlServiceAccountPassword.Value);
        }
    }
}
