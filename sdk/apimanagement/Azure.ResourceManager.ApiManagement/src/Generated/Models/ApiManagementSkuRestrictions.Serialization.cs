// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementSkuRestrictions
    {
        internal static ApiManagementSkuRestrictions DeserializeApiManagementSkuRestrictions(JsonElement element)
        {
            Optional<ApiManagementSkuRestrictionsType> type = default;
            Optional<IReadOnlyList<string>> values = default;
            Optional<ApiManagementSkuRestrictionInfo> restrictionInfo = default;
            Optional<ApiManagementSkuRestrictionsReasonCode> reasonCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = property.Value.GetString().ToApiManagementSkuRestrictionsType();
                    continue;
                }
                if (property.NameEquals("values"))
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
                    values = array;
                    continue;
                }
                if (property.NameEquals("restrictionInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    restrictionInfo = ApiManagementSkuRestrictionInfo.DeserializeApiManagementSkuRestrictionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("reasonCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    reasonCode = property.Value.GetString().ToApiManagementSkuRestrictionsReasonCode();
                    continue;
                }
            }
            return new ApiManagementSkuRestrictions(Optional.ToNullable(type), Optional.ToList(values), restrictionInfo.Value, Optional.ToNullable(reasonCode));
        }
    }
}
