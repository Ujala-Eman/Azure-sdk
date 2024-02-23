// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.MixedReality.RemoteRendering
{
    public partial class AssetConversionInputOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("storageContainerUri"u8);
            writer.WriteStringValue(StorageContainerUri.AbsoluteUri);
            if (StorageContainerReadListSas != null)
            {
                writer.WritePropertyName("storageContainerReadListSas"u8);
                writer.WriteStringValue(StorageContainerReadListSas);
            }
            if (BlobPrefix != null)
            {
                writer.WritePropertyName("blobPrefix"u8);
                writer.WriteStringValue(BlobPrefix);
            }
            writer.WritePropertyName("relativeInputAssetPath"u8);
            writer.WriteStringValue(RelativeInputAssetPath);
            writer.WriteEndObject();
        }

        internal static AssetConversionInputOptions DeserializeAssetConversionInputOptions(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri storageContainerUri = default;
            Optional<string> storageContainerReadListSas = default;
            Optional<string> blobPrefix = default;
            string relativeInputAssetPath = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageContainerUri"u8))
                {
                    storageContainerUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageContainerReadListSas"u8))
                {
                    storageContainerReadListSas = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("blobPrefix"u8))
                {
                    blobPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relativeInputAssetPath"u8))
                {
                    relativeInputAssetPath = property.Value.GetString();
                    continue;
                }
            }
            return new AssetConversionInputOptions(storageContainerUri, storageContainerReadListSas.Value, blobPrefix.Value, relativeInputAssetPath);
        }
    }
}
