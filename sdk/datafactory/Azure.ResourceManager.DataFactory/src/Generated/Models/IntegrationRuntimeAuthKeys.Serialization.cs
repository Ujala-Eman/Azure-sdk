// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class IntegrationRuntimeAuthKeys
    {
        internal static IntegrationRuntimeAuthKeys DeserializeIntegrationRuntimeAuthKeys(JsonElement element)
        {
            Optional<string> authKey1 = default;
            Optional<string> authKey2 = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authKey1"))
                {
                    authKey1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authKey2"))
                {
                    authKey2 = property.Value.GetString();
                    continue;
                }
            }
            return new IntegrationRuntimeAuthKeys(authKey1.Value, authKey2.Value);
        }
    }
}
