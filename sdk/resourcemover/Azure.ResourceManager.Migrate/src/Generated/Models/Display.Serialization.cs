// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    public partial class Display
    {
        internal static Display DeserializeDisplay(JsonElement element)
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
            return new Display(provider.Value, resource.Value, operation.Value, description.Value);
        }
    }
}
