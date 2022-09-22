// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class StorageCacheActiveDirectorySettingsCredentials : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("username");
            writer.WriteStringValue(Username);
            writer.WritePropertyName("password");
            writer.WriteStringValue(Password);
            writer.WriteEndObject();
        }

        internal static StorageCacheActiveDirectorySettingsCredentials DeserializeStorageCacheActiveDirectorySettingsCredentials(JsonElement element)
        {
            string username = default;
            string password = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("username"))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"))
                {
                    password = property.Value.GetString();
                    continue;
                }
            }
            return new StorageCacheActiveDirectorySettingsCredentials(username, password);
        }
    }
}
