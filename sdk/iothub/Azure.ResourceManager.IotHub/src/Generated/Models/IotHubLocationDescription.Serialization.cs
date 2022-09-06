// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubLocationDescription
    {
        internal static IotHubLocationDescription DeserializeIotHubLocationDescription(JsonElement element)
        {
            Optional<AzureLocation> location = default;
            Optional<IotHubReplicaRoleType> role = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("role"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    role = new IotHubReplicaRoleType(property.Value.GetString());
                    continue;
                }
            }
            return new IotHubLocationDescription(Optional.ToNullable(location), Optional.ToNullable(role));
        }
    }
}
