// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class Destination : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccountResourceId))
            {
                writer.WritePropertyName("storageAccountResourceId");
                writer.WriteStringValue(StorageAccountResourceId);
            }
            if (Optional.IsDefined(BlobContainer))
            {
                writer.WritePropertyName("blobContainer");
                writer.WriteStringValue(BlobContainer);
            }
            if (Optional.IsDefined(ArchiveNameFormat))
            {
                writer.WritePropertyName("archiveNameFormat");
                writer.WriteStringValue(ArchiveNameFormat);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static Destination DeserializeDestination(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> storageAccountResourceId = default;
            Optional<string> blobContainer = default;
            Optional<string> archiveNameFormat = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("storageAccountResourceId"))
                        {
                            storageAccountResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("blobContainer"))
                        {
                            blobContainer = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("archiveNameFormat"))
                        {
                            archiveNameFormat = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Destination(name.Value, storageAccountResourceId.Value, blobContainer.Value, archiveNameFormat.Value);
        }
    }
}
