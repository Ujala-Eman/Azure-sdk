// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.Models.SystemEvents
{
    public partial class IotHubDeviceDeletedEventData
    {
        internal static IotHubDeviceDeletedEventData DeserializeIotHubDeviceDeletedEventData(JsonElement element)
        {
            Optional<string> deviceId = default;
            Optional<string> hubName = default;
            Optional<DeviceTwinInfo> twin = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hubName"))
                {
                    hubName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("twin"))
                {
                    twin = DeviceTwinInfo.DeserializeDeviceTwinInfo(property.Value);
                    continue;
                }
            }
            return new IotHubDeviceDeletedEventData(deviceId.Value, hubName.Value, twin.Value);
        }
    }
}
