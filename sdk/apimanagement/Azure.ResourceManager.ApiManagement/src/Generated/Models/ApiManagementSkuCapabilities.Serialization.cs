// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementSkuCapabilities
    {
        internal static ApiManagementSkuCapabilities DeserializeApiManagementSkuCapabilities(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
            }
            return new ApiManagementSkuCapabilities(name.Value, value.Value);
        }
    }
}
