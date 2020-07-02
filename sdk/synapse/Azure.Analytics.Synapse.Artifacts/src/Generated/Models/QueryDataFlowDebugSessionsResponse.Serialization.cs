// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class QueryDataFlowDebugSessionsResponse
    {
        internal static QueryDataFlowDebugSessionsResponse DeserializeQueryDataFlowDebugSessionsResponse(JsonElement element)
        {
            Optional<IReadOnlyList<DataFlowDebugSessionInfo>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<DataFlowDebugSessionInfo> array = new List<DataFlowDebugSessionInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(DataFlowDebugSessionInfo.DeserializeDataFlowDebugSessionInfo(item));
                        }
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
            return new QueryDataFlowDebugSessionsResponse(new ChangeTrackingList<DataFlowDebugSessionInfo>(value), nextLink.HasValue ? nextLink.Value : null);
        }
    }
}
