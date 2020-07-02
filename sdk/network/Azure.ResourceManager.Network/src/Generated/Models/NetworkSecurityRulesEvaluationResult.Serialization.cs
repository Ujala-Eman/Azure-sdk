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
            Optional<string> name = default;
            Optional<bool> protocolMatched = default;
            Optional<bool> sourceMatched = default;
            Optional<bool> sourcePortMatched = default;
            Optional<bool> destinationMatched = default;
            Optional<bool> destinationPortMatched = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocolMatched"))
                {
                    protocolMatched = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sourceMatched"))
                {
                    sourceMatched = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sourcePortMatched"))
                {
                    sourcePortMatched = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("destinationMatched"))
                {
                    destinationMatched = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("destinationPortMatched"))
                {
                    destinationPortMatched = property.Value.GetBoolean();
                    continue;
                }
            }
            return new NetworkSecurityRulesEvaluationResult(name.HasValue ? name.Value : null, protocolMatched.HasValue ? protocolMatched.Value : (bool?)null, sourceMatched.HasValue ? sourceMatched.Value : (bool?)null, sourcePortMatched.HasValue ? sourcePortMatched.Value : (bool?)null, destinationMatched.HasValue ? destinationMatched.Value : (bool?)null, destinationPortMatched.HasValue ? destinationPortMatched.Value : (bool?)null);
        }
    }
}
