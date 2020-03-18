// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class ManagementPolicyFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (PrefixMatch != null)
            {
                writer.WritePropertyName("prefixMatch");
                writer.WriteStartArray();
                foreach (var item in PrefixMatch)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("blobTypes");
            writer.WriteStartArray();
            foreach (var item in BlobTypes)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static ManagementPolicyFilter DeserializeManagementPolicyFilter(JsonElement element)
        {
            ManagementPolicyFilter result = new ManagementPolicyFilter();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prefixMatch"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.PrefixMatch = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.PrefixMatch.Add(item.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("blobTypes"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.BlobTypes.Add(item.GetString());
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
