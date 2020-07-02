// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ConnectionMonitorOutput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Optional.IsDefined(WorkspaceSettings))
            {
                writer.WritePropertyName("workspaceSettings");
                writer.WriteObjectValue(WorkspaceSettings);
            }
            writer.WriteEndObject();
        }

        internal static ConnectionMonitorOutput DeserializeConnectionMonitorOutput(JsonElement element)
        {
            Optional<string> type = default;
            Optional<ConnectionMonitorWorkspaceSettings> workspaceSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceSettings"))
                {
                    workspaceSettings = ConnectionMonitorWorkspaceSettings.DeserializeConnectionMonitorWorkspaceSettings(property.Value);
                    continue;
                }
            }
            return new ConnectionMonitorOutput(type.HasValue ? type.Value : null, workspaceSettings.HasValue ? workspaceSettings.Value : null);
        }
    }
}
