// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sphere.Models
{
    public partial class SphereDevicePatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DeviceGroupId))
            {
                writer.WritePropertyName("deviceGroupId"u8);
                writer.WriteStringValue(DeviceGroupId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
