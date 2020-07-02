// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkConfigurationDiagnosticResponse
    {
        internal static NetworkConfigurationDiagnosticResponse DeserializeNetworkConfigurationDiagnosticResponse(JsonElement element)
        {
            Optional<IReadOnlyList<NetworkConfigurationDiagnosticResult>> results = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    List<NetworkConfigurationDiagnosticResult> array = new List<NetworkConfigurationDiagnosticResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(NetworkConfigurationDiagnosticResult.DeserializeNetworkConfigurationDiagnosticResult(item));
                        }
                    }
                    results = array;
                    continue;
                }
            }
            return new NetworkConfigurationDiagnosticResponse(new ChangeTrackingList<NetworkConfigurationDiagnosticResult>(results));
        }
    }
}
