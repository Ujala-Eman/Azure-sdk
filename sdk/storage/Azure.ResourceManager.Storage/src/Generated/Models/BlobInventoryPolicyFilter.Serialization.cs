// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class BlobInventoryPolicyFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PrefixMatch))
            {
                writer.WritePropertyName("prefixMatch");
                writer.WriteStartArray();
                foreach (var item in PrefixMatch)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExcludePrefix))
            {
                writer.WritePropertyName("excludePrefix");
                writer.WriteStartArray();
                foreach (var item in ExcludePrefix)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(BlobTypes))
            {
                writer.WritePropertyName("blobTypes");
                writer.WriteStartArray();
                foreach (var item in BlobTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IncludeBlobVersions))
            {
                writer.WritePropertyName("includeBlobVersions");
                writer.WriteBooleanValue(IncludeBlobVersions.Value);
            }
            if (Optional.IsDefined(IncludeSnapshots))
            {
                writer.WritePropertyName("includeSnapshots");
                writer.WriteBooleanValue(IncludeSnapshots.Value);
            }
            if (Optional.IsDefined(IncludeDeleted))
            {
                writer.WritePropertyName("includeDeleted");
                writer.WriteBooleanValue(IncludeDeleted.Value);
            }
            writer.WriteEndObject();
        }

        internal static BlobInventoryPolicyFilter DeserializeBlobInventoryPolicyFilter(JsonElement element)
        {
            Optional<IList<string>> prefixMatch = default;
            Optional<IList<string>> excludePrefix = default;
            Optional<IList<string>> blobTypes = default;
            Optional<bool> includeBlobVersions = default;
            Optional<bool> includeSnapshots = default;
            Optional<bool> includeDeleted = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prefixMatch"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    prefixMatch = array;
                    continue;
                }
                if (property.NameEquals("excludePrefix"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    excludePrefix = array;
                    continue;
                }
                if (property.NameEquals("blobTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    blobTypes = array;
                    continue;
                }
                if (property.NameEquals("includeBlobVersions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    includeBlobVersions = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("includeSnapshots"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    includeSnapshots = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("includeDeleted"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    includeDeleted = property.Value.GetBoolean();
                    continue;
                }
            }
            return new BlobInventoryPolicyFilter(Optional.ToList(prefixMatch), Optional.ToList(excludePrefix), Optional.ToList(blobTypes), Optional.ToNullable(includeBlobVersions), Optional.ToNullable(includeSnapshots), Optional.ToNullable(includeDeleted));
        }
    }
}
