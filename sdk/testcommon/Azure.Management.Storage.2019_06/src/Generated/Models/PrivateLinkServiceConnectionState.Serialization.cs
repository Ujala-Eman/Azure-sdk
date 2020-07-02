// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class PrivateLinkServiceConnectionState : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ActionRequired))
            {
                writer.WritePropertyName("actionRequired");
                writer.WriteStringValue(ActionRequired);
            }
            writer.WriteEndObject();
        }

        internal static PrivateLinkServiceConnectionState DeserializePrivateLinkServiceConnectionState(JsonElement element)
        {
            Optional<PrivateEndpointServiceConnectionStatus> status = default;
            Optional<string> description = default;
            Optional<string> actionRequired = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    status = new PrivateEndpointServiceConnectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionRequired"))
                {
                    actionRequired = property.Value.GetString();
                    continue;
                }
            }
            return new PrivateLinkServiceConnectionState(status.HasValue ? status.Value : (PrivateEndpointServiceConnectionStatus?)null, description.HasValue ? description.Value : null, actionRequired.HasValue ? actionRequired.Value : null);
        }
    }
}
