// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class AzureReachabilityReportItem
    {
        internal static AzureReachabilityReportItem DeserializeAzureReachabilityReportItem(JsonElement element)
        {
            string provider = default;
            string azureLocation = default;
            IReadOnlyList<AzureReachabilityReportLatencyInfo> latencies = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provider"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureLocation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("latencies"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureReachabilityReportLatencyInfo> array = new List<AzureReachabilityReportLatencyInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(AzureReachabilityReportLatencyInfo.DeserializeAzureReachabilityReportLatencyInfo(item));
                        }
                    }
                    latencies = array;
                    continue;
                }
            }
            return new AzureReachabilityReportItem(provider, azureLocation, latencies);
        }
    }
}
