// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkSecurityRulesEvaluationResult
    {
        internal static NetworkSecurityRulesEvaluationResult DeserializeNetworkSecurityRulesEvaluationResult(JsonElement element)
        {
            string name = default;
            bool? protocolMatched = default;
            bool? sourceMatched = default;
            bool? sourcePortMatched = default;
            bool? destinationMatched = default;
            bool? destinationPortMatched = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocolMatched"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protocolMatched = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sourceMatched"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceMatched = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sourcePortMatched"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourcePortMatched = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("destinationMatched"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destinationMatched = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("destinationPortMatched"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destinationPortMatched = property.Value.GetBoolean();
                    continue;
                }
            }
            return new NetworkSecurityRulesEvaluationResult(name, protocolMatched, sourceMatched, sourcePortMatched, destinationMatched, destinationPortMatched);
        }
    }
}
