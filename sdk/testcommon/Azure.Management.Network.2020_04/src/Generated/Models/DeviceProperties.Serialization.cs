// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class DeviceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DeviceVendor))
            {
                writer.WritePropertyName("deviceVendor");
                writer.WriteStringValue(DeviceVendor);
            }
            if (Optional.IsDefined(DeviceModel))
            {
                writer.WritePropertyName("deviceModel");
                writer.WriteStringValue(DeviceModel);
            }
            if (Optional.IsDefined(LinkSpeedInMbps))
            {
                writer.WritePropertyName("linkSpeedInMbps");
                writer.WriteNumberValue(LinkSpeedInMbps.Value);
            }
            writer.WriteEndObject();
        }

        internal static DeviceProperties DeserializeDeviceProperties(JsonElement element)
        {
            Optional<string> deviceVendor = default;
            Optional<string> deviceModel = default;
            Optional<int> linkSpeedInMbps = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceVendor"))
                {
                    deviceVendor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceModel"))
                {
                    deviceModel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkSpeedInMbps"))
                {
                    linkSpeedInMbps = property.Value.GetInt32();
                    continue;
                }
            }
            return new DeviceProperties(deviceVendor.HasValue ? deviceVendor.Value : null, deviceModel.HasValue ? deviceModel.Value : null, linkSpeedInMbps.HasValue ? linkSpeedInMbps.Value : (int?)null);
        }
    }
}
