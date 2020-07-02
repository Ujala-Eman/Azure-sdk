// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class PacketCaptureQueryStatusResult
    {
        internal static PacketCaptureQueryStatusResult DeserializePacketCaptureQueryStatusResult(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> id = default;
            Optional<DateTimeOffset> captureStartTime = default;
            Optional<PcStatus> packetCaptureStatus = default;
            Optional<string> stopReason = default;
            Optional<IReadOnlyList<PcError>> packetCaptureError = default;
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
                if (property.NameEquals("captureStartTime"))
                {
                    captureStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("packetCaptureStatus"))
                {
                    packetCaptureStatus = new PcStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("stopReason"))
                {
                    stopReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("packetCaptureError"))
                {
                    List<PcError> array = new List<PcError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new PcError(item.GetString()));
                    }
                    packetCaptureError = array;
                    continue;
                }
            }
            return new PacketCaptureQueryStatusResult(name.HasValue ? name.Value : null, id.HasValue ? id.Value : null, captureStartTime.HasValue ? captureStartTime.Value : (DateTimeOffset?)null, packetCaptureStatus.HasValue ? packetCaptureStatus.Value : (PcStatus?)null, stopReason.HasValue ? stopReason.Value : null, new ChangeTrackingList<PcError>(packetCaptureError));
        }
    }
}
