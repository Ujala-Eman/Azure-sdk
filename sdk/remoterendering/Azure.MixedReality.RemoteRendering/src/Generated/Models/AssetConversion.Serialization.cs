// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.MixedReality.RemoteRendering
{
    public partial class AssetConversion
    {
        internal static AssetConversion DeserializeAssetConversion(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            AssetConversionOptions settings = default;
            AssetConversionOutput output = default;
            RemoteRenderingServiceError error = default;
            AssetConversionStatus status = default;
            DateTimeOffset creationTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("settings"u8))
                {
                    settings = AssetConversionOptions.DeserializeAssetConversionOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    output = AssetConversionOutput.DeserializeAssetConversionOutput(property.Value);
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        error = null;
                        continue;
                    }
                    error = RemoteRenderingServiceError.DeserializeRemoteRenderingServiceError(property.Value);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new AssetConversionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("creationTime"u8))
                {
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new AssetConversion(
                id,
                settings,
                output,
                error,
                status,
                creationTime);
        }
    }
}
