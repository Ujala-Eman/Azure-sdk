// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resources.Models
{
    public partial class DeploymentValidateResult
    {
        internal static DeploymentValidateResult DeserializeDeploymentValidateResult(JsonElement element)
        {
            Optional<ResourceManagementErrorWithDetails> error = default;
            Optional<DeploymentPropertiesExtended> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    error = ResourceManagementErrorWithDetails.DeserializeResourceManagementErrorWithDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    properties = DeploymentPropertiesExtended.DeserializeDeploymentPropertiesExtended(property.Value);
                    continue;
                }
            }
            return new DeploymentValidateResult(error.HasValue ? error.Value : null, properties.HasValue ? properties.Value : null);
        }
    }
}
