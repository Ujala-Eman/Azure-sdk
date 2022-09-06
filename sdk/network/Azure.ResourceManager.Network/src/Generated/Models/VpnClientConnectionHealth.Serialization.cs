// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnClientConnectionHealth
    {
        internal static VpnClientConnectionHealth DeserializeVpnClientConnectionHealth(JsonElement element)
        {
            Optional<long> totalIngressBytesTransferred = default;
            Optional<long> totalEgressBytesTransferred = default;
            Optional<int> vpnClientConnectionsCount = default;
            Optional<IReadOnlyList<string>> allocatedIPAddresses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalIngressBytesTransferred"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalIngressBytesTransferred = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalEgressBytesTransferred"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalEgressBytesTransferred = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("vpnClientConnectionsCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    vpnClientConnectionsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allocatedIpAddresses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allocatedIPAddresses = array;
                    continue;
                }
            }
            return new VpnClientConnectionHealth(Optional.ToNullable(totalIngressBytesTransferred), Optional.ToNullable(totalEgressBytesTransferred), Optional.ToNullable(vpnClientConnectionsCount), Optional.ToList(allocatedIPAddresses));
        }
    }
}
