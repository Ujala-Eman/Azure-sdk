// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationSecurityGroupListResult
    {
        internal static ApplicationSecurityGroupListResult DeserializeApplicationSecurityGroupListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ApplicationSecurityGroup>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ApplicationSecurityGroup> array = new List<ApplicationSecurityGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ApplicationSecurityGroup.DeserializeApplicationSecurityGroup(item));
                        }
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ApplicationSecurityGroupListResult(new ChangeTrackingList<ApplicationSecurityGroup>(value), nextLink.HasValue ? nextLink.Value : null);
        }
    }
}
