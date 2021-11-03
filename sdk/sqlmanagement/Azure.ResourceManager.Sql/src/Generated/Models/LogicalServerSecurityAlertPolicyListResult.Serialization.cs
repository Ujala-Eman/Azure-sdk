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
    internal partial class LogicalServerSecurityAlertPolicyListResult
    {
        internal static LogicalServerSecurityAlertPolicyListResult DeserializeLogicalServerSecurityAlertPolicyListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ServerSecurityAlertPolicyData>> value = default;
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
                    List<ServerSecurityAlertPolicyData> array = new List<ServerSecurityAlertPolicyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServerSecurityAlertPolicyData.DeserializeServerSecurityAlertPolicyData(item));
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
            return new LogicalServerSecurityAlertPolicyListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
