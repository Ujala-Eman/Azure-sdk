// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class Usage
    {
        internal static Usage DeserializeUsage(JsonElement element)
        {
            string id = default;
            string unit = default;
            long currentValue = default;
            long limit = default;
            UsageName name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currentValue"))
                {
                    currentValue = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("limit"))
                {
                    limit = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = UsageName.DeserializeUsageName(property.Value);
                    continue;
                }
            }
            return new Usage(id, unit, currentValue, limit, name);
        }
    }
}
