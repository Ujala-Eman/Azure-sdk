// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class SkuInformation
    {
        internal static SkuInformation DeserializeSkuInformation(JsonElement element)
        {
            SkuInformation result = new SkuInformation();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    result.Name = new SkuName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Tier = property.Value.GetString().ToSkuTier();
                    continue;
                }
                if (property.NameEquals("resourceType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ResourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Kind = new Kind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("locations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Locations = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Locations.Add(item.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("capabilities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Capabilities = new List<SKUCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Capabilities.Add(SKUCapability.DeserializeSKUCapability(item));
                    }
                    continue;
                }
                if (property.NameEquals("restrictions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Restrictions = new List<Restriction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Restrictions.Add(Restriction.DeserializeRestriction(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
