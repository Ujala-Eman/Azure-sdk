// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class KeyVaultReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WritePropertyName("url");
            writer.WriteStringValue(Uri.AbsoluteUri);
            writer.WriteEndObject();
        }

        internal static KeyVaultReference DeserializeKeyVaultReference(JsonElement element)
        {
            string id = default;
            Uri url = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    url = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new KeyVaultReference(id, url);
        }
    }
}
