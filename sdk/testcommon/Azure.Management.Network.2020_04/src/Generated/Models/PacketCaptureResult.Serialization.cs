// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class PacketCaptureResult
    {
        internal static PacketCaptureResult DeserializePacketCaptureResult(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> id = default;
            Optional<string> etag = default;
            Optional<string> target = default;
            Optional<int> bytesToCapturePerPacket = default;
            Optional<int> totalBytesPerSession = default;
            Optional<int> timeLimitInSeconds = default;
            Optional<PacketCaptureStorageLocation> storageLocation = default;
            Optional<IReadOnlyList<PacketCaptureFilter>> filters = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("target"))
                        {
                            target = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("bytesToCapturePerPacket"))
                        {
                            bytesToCapturePerPacket = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("totalBytesPerSession"))
                        {
                            totalBytesPerSession = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("timeLimitInSeconds"))
                        {
                            timeLimitInSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("storageLocation"))
                        {
                            storageLocation = PacketCaptureStorageLocation.DeserializePacketCaptureStorageLocation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("filters"))
                        {
                            List<PacketCaptureFilter> array = new List<PacketCaptureFilter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(PacketCaptureFilter.DeserializePacketCaptureFilter(item));
                                }
                            }
                            filters = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PacketCaptureResult(name.HasValue ? name.Value : null, id.HasValue ? id.Value : null, etag.HasValue ? etag.Value : null, target.HasValue ? target.Value : null, bytesToCapturePerPacket.HasValue ? bytesToCapturePerPacket.Value : (int?)null, totalBytesPerSession.HasValue ? totalBytesPerSession.Value : (int?)null, timeLimitInSeconds.HasValue ? timeLimitInSeconds.Value : (int?)null, storageLocation.HasValue ? storageLocation.Value : null, new ChangeTrackingList<PacketCaptureFilter>(filters), provisioningState.HasValue ? provisioningState.Value : (ProvisioningState?)null);
        }
    }
}
