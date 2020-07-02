// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class VirtualNetworkBgpCommunities : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("virtualNetworkCommunity");
            writer.WriteStringValue(VirtualNetworkCommunity);
            if (Optional.IsDefined(RegionalCommunity))
            {
                writer.WritePropertyName("regionalCommunity");
                writer.WriteStringValue(RegionalCommunity);
            }
            writer.WriteEndObject();
        }

        internal static VirtualNetworkBgpCommunities DeserializeVirtualNetworkBgpCommunities(JsonElement element)
        {
            string virtualNetworkCommunity = default;
            Optional<string> regionalCommunity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualNetworkCommunity"))
                {
                    virtualNetworkCommunity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("regionalCommunity"))
                {
                    regionalCommunity = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualNetworkBgpCommunities(virtualNetworkCommunity, regionalCommunity.HasValue ? regionalCommunity.Value : null);
        }
    }
}
