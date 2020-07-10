// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnClientConnectionHealth : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (TotalIngressBytesTransferred != null)
            {
                writer.WritePropertyName("totalIngressBytesTransferred");
                writer.WriteNumberValue(TotalIngressBytesTransferred.Value);
            }
            if (TotalEgressBytesTransferred != null)
            {
                writer.WritePropertyName("totalEgressBytesTransferred");
                writer.WriteNumberValue(TotalEgressBytesTransferred.Value);
            }
            if (VpnClientConnectionsCount != null)
            {
                writer.WritePropertyName("vpnClientConnectionsCount");
                writer.WriteNumberValue(VpnClientConnectionsCount.Value);
            }
            if (AllocatedIpAddresses != null)
            {
                writer.WritePropertyName("allocatedIpAddresses");
                writer.WriteStartArray();
                foreach (var item in AllocatedIpAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static VpnClientConnectionHealth DeserializeVpnClientConnectionHealth(JsonElement element)
        {
            long? totalIngressBytesTransferred = default;
            long? totalEgressBytesTransferred = default;
            int? vpnClientConnectionsCount = default;
            IList<string> allocatedIpAddresses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalIngressBytesTransferred"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalIngressBytesTransferred = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalEgressBytesTransferred"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalEgressBytesTransferred = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("vpnClientConnectionsCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vpnClientConnectionsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allocatedIpAddresses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    allocatedIpAddresses = array;
                    continue;
                }
            }
            return new VpnClientConnectionHealth(totalIngressBytesTransferred, totalEgressBytesTransferred, vpnClientConnectionsCount, allocatedIpAddresses);
        }
    }
}
