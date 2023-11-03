// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.IntegrationSpaces;

namespace Azure.ResourceManager.IntegrationSpaces.Models
{
    internal partial class InfrastructureResourceListResult
    {
        internal static InfrastructureResourceListResult DeserializeInfrastructureResourceListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<InfrastructureResourceData> value = default;
            Optional<Uri> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<InfrastructureResourceData> array = new List<InfrastructureResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InfrastructureResourceData.DeserializeInfrastructureResourceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLink = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new InfrastructureResourceListResult(value, nextLink.Value);
        }
    }
}
