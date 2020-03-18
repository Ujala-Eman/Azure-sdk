// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class EncryptionScopeListResult
    {
        internal static EncryptionScopeListResult DeserializeEncryptionScopeListResult(JsonElement element)
        {
            EncryptionScopeListResult result = new EncryptionScopeListResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Value = new List<EncryptionScope>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Value.Add(EncryptionScope.DeserializeEncryptionScope(item));
                    }
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.NextLink = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
