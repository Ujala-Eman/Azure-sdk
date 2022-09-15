// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class ProviderOperationsResourceType
    {
        internal static ProviderOperationsResourceType DeserializeProviderOperationsResourceType(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> displayName = default;
            Optional<IReadOnlyList<ProviderOperationInfo>> operations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ProviderOperationInfo> array = new List<ProviderOperationInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderOperationInfo.DeserializeProviderOperationInfo(item));
                    }
                    operations = array;
                    continue;
                }
            }
            return new ProviderOperationsResourceType(name.Value, displayName.Value, Optional.ToList(operations));
        }
    }
}
