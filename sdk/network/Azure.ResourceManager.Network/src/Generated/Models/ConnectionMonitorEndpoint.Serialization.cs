// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectionMonitorEndpoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId");
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(Address))
            {
                writer.WritePropertyName("address");
                writer.WriteStringValue(Address);
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter");
                writer.WriteObjectValue(Filter);
            }
            writer.WriteEndObject();
        }

        internal static ConnectionMonitorEndpoint DeserializeConnectionMonitorEndpoint(JsonElement element)
        {
            string name = default;
            Optional<string> resourceId = default;
            Optional<string> address = default;
            Optional<ConnectionMonitorEndpointFilter> filter = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("address"))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filter"))
                {
                    filter = ConnectionMonitorEndpointFilter.DeserializeConnectionMonitorEndpointFilter(property.Value);
                    continue;
                }
            }
            return new ConnectionMonitorEndpoint(name, resourceId.HasValue ? resourceId.Value : null, address.HasValue ? address.Value : null, filter.HasValue ? filter.Value : null);
        }
    }
}
