// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class CosmosDBSqlRoleDefinitionList
    {
        internal static CosmosDBSqlRoleDefinitionList DeserializeCosmosDBSqlRoleDefinitionList(JsonElement element)
        {
            Optional<IReadOnlyList<CosmosDBSqlRoleDefinitionData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CosmosDBSqlRoleDefinitionData> array = new List<CosmosDBSqlRoleDefinitionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBSqlRoleDefinitionData.DeserializeCosmosDBSqlRoleDefinitionData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CosmosDBSqlRoleDefinitionList(Optional.ToList(value));
        }
    }
}
