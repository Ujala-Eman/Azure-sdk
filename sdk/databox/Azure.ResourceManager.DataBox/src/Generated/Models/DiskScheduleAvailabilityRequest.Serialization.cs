// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DiskScheduleAvailabilityRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("expectedDataSizeInTeraBytes");
            writer.WriteNumberValue(ExpectedDataSizeInTeraBytes);
            writer.WritePropertyName("storageLocation");
            writer.WriteStringValue(StorageLocation);
            writer.WritePropertyName("skuName");
            writer.WriteStringValue(SkuName.ToSerialString());
            if (Optional.IsDefined(Country))
            {
                writer.WritePropertyName("country");
                writer.WriteStringValue(Country);
            }
            writer.WriteEndObject();
        }
    }
}
