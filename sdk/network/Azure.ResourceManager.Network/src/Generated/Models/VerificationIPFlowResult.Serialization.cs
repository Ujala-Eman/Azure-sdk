// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VerificationIPFlowResult
    {
        internal static VerificationIPFlowResult DeserializeVerificationIPFlowResult(JsonElement element)
        {
            Optional<Access> access = default;
            Optional<string> ruleName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("access"))
                {
                    access = new Access(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ruleName"))
                {
                    ruleName = property.Value.GetString();
                    continue;
                }
            }
            return new VerificationIPFlowResult(access.HasValue ? access.Value : (Access?)null, ruleName.HasValue ? ruleName.Value : null);
        }
    }
}
