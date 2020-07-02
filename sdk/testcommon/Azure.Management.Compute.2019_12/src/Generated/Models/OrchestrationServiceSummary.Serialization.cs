// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class OrchestrationServiceSummary
    {
        internal static OrchestrationServiceSummary DeserializeOrchestrationServiceSummary(JsonElement element)
        {
            Optional<string> serviceName = default;
            Optional<OrchestrationServiceState> serviceState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceName"))
                {
                    serviceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceState"))
                {
                    serviceState = new OrchestrationServiceState(property.Value.GetString());
                    continue;
                }
            }
            return new OrchestrationServiceSummary(serviceName.HasValue ? serviceName.Value : null, serviceState.HasValue ? serviceState.Value : (OrchestrationServiceState?)null);
        }
    }
}
