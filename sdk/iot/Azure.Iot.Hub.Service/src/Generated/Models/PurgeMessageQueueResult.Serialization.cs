// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    public partial class PurgeMessageQueueResult
    {
        internal static PurgeMessageQueueResult DeserializePurgeMessageQueueResult(JsonElement element)
        {
            Optional<int> totalMessagesPurged = default;
            Optional<string> deviceId = default;
            Optional<string> moduleId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalMessagesPurged"))
                {
                    totalMessagesPurged = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("deviceId"))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("moduleId"))
                {
                    moduleId = property.Value.GetString();
                    continue;
                }
            }
            return new PurgeMessageQueueResult(totalMessagesPurged.HasValue ? totalMessagesPurged.Value : (int?)null, deviceId.HasValue ? deviceId.Value : null, moduleId.HasValue ? moduleId.Value : null);
        }
    }
}
