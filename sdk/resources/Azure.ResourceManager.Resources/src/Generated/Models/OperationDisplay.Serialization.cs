// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class OperationDisplay
    {
        internal static OperationDisplay DeserializeOperationDisplay(JsonElement element)
        {
            Optional<string> provider = default;
            Optional<string> resource = default;
            Optional<string> operation = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provider"))
                {
                    provider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resource"))
                {
                    resource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operation"))
                {
                    operation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new OperationDisplay(provider.HasValue ? provider.Value : null, resource.HasValue ? resource.Value : null, operation.HasValue ? operation.Value : null, description.HasValue ? description.Value : null);
        }
    }
}
