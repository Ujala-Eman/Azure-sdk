// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Blueprint;

namespace Azure.ResourceManager.Blueprint.Models
{
    internal partial class AssignmentList
    {
        internal static AssignmentList DeserializeAssignmentList(JsonElement element)
        {
            Optional<IReadOnlyList<AssignmentData>> value = default;
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
                    List<AssignmentData> array = new List<AssignmentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AssignmentData.DeserializeAssignmentData(item));
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
            return new AssignmentList(Optional.ToList(value), nextLink.Value);
        }
    }
}
