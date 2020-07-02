// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayBackendHealthPool
    {
        internal static ApplicationGatewayBackendHealthPool DeserializeApplicationGatewayBackendHealthPool(JsonElement element)
        {
            Optional<ApplicationGatewayBackendAddressPool> backendAddressPool = default;
            Optional<IReadOnlyList<ApplicationGatewayBackendHealthHttpSettings>> backendHttpSettingsCollection = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backendAddressPool"))
                {
                    backendAddressPool = ApplicationGatewayBackendAddressPool.DeserializeApplicationGatewayBackendAddressPool(property.Value);
                    continue;
                }
                if (property.NameEquals("backendHttpSettingsCollection"))
                {
                    List<ApplicationGatewayBackendHealthHttpSettings> array = new List<ApplicationGatewayBackendHealthHttpSettings>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ApplicationGatewayBackendHealthHttpSettings.DeserializeApplicationGatewayBackendHealthHttpSettings(item));
                        }
                    }
                    backendHttpSettingsCollection = array;
                    continue;
                }
            }
            return new ApplicationGatewayBackendHealthPool(backendAddressPool.HasValue ? backendAddressPool.Value : null, new ChangeTrackingList<ApplicationGatewayBackendHealthHttpSettings>(backendHttpSettingsCollection));
        }
    }
}
