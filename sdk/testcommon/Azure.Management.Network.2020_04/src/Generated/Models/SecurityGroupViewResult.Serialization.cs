// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class SecurityGroupViewResult
    {
        internal static SecurityGroupViewResult DeserializeSecurityGroupViewResult(JsonElement element)
        {
            Optional<IReadOnlyList<SecurityGroupNetworkInterface>> networkInterfaces = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkInterfaces"))
                {
                    List<SecurityGroupNetworkInterface> array = new List<SecurityGroupNetworkInterface>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(SecurityGroupNetworkInterface.DeserializeSecurityGroupNetworkInterface(item));
                        }
                    }
                    networkInterfaces = array;
                    continue;
                }
            }
            return new SecurityGroupViewResult(new ChangeTrackingList<SecurityGroupNetworkInterface>(networkInterfaces));
        }
    }
}
