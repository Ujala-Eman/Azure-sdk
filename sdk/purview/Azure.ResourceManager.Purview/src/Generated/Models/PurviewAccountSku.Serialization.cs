// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Purview.Models
{
    public partial class PurviewAccountSku
    {
        internal static PurviewAccountSku DeserializePurviewAccountSku(JsonElement element)
        {
            Optional<int> capacity = default;
            Optional<PurviewAccountSkuName> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("capacity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    capacity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    name = new PurviewAccountSkuName(property.Value.GetString());
                    continue;
                }
            }
            return new PurviewAccountSku(Optional.ToNullable(capacity), Optional.ToNullable(name));
        }
    }
}
