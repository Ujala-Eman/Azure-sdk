// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resources.Models
{
    public partial class ResourceGroupExportResult
    {
        internal static ResourceGroupExportResult DeserializeResourceGroupExportResult(JsonElement element)
        {
            Optional<object> template = default;
            Optional<ResourceManagementErrorWithDetails> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("template"))
                {
                    template = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    error = ResourceManagementErrorWithDetails.DeserializeResourceManagementErrorWithDetails(property.Value);
                    continue;
                }
            }
            return new ResourceGroupExportResult(template.HasValue ? template.Value : null, error.HasValue ? error.Value : null);
        }
    }
}
