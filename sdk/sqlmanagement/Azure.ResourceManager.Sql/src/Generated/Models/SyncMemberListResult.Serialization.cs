// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using SqlManagementClient;

namespace SqlManagementClient.Models
{
    internal partial class SyncMemberListResult
    {
        internal static SyncMemberListResult DeserializeSyncMemberListResult(JsonElement element)
        {
            Optional<IReadOnlyList<SyncMemberData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SyncMemberData> array = new List<SyncMemberData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyncMemberData.DeserializeSyncMemberData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SyncMemberListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
