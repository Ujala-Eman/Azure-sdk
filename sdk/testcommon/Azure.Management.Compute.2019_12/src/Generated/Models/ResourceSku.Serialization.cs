// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class ResourceSku
    {
        internal static ResourceSku DeserializeResourceSku(JsonElement element)
        {
            Optional<string> resourceType = default;
            Optional<string> name = default;
            Optional<string> tier = default;
            Optional<string> size = default;
            Optional<string> family = default;
            Optional<string> kind = default;
            Optional<ResourceSkuCapacity> capacity = default;
            Optional<IReadOnlyList<string>> locations = default;
            Optional<IReadOnlyList<ResourceSkuLocationInfo>> locationInfo = default;
            Optional<IReadOnlyList<string>> apiVersions = default;
            Optional<IReadOnlyList<ResourceSkuCosts>> costs = default;
            Optional<IReadOnlyList<ResourceSkuCapabilities>> capabilities = default;
            Optional<IReadOnlyList<ResourceSkuRestrictions>> restrictions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"))
                {
                    tier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"))
                {
                    size = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("family"))
                {
                    family = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacity"))
                {
                    capacity = ResourceSkuCapacity.DeserializeResourceSkuCapacity(property.Value);
                    continue;
                }
                if (property.NameEquals("locations"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("locationInfo"))
                {
                    List<ResourceSkuLocationInfo> array = new List<ResourceSkuLocationInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ResourceSkuLocationInfo.DeserializeResourceSkuLocationInfo(item));
                        }
                    }
                    locationInfo = array;
                    continue;
                }
                if (property.NameEquals("apiVersions"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    apiVersions = array;
                    continue;
                }
                if (property.NameEquals("costs"))
                {
                    List<ResourceSkuCosts> array = new List<ResourceSkuCosts>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ResourceSkuCosts.DeserializeResourceSkuCosts(item));
                        }
                    }
                    costs = array;
                    continue;
                }
                if (property.NameEquals("capabilities"))
                {
                    List<ResourceSkuCapabilities> array = new List<ResourceSkuCapabilities>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ResourceSkuCapabilities.DeserializeResourceSkuCapabilities(item));
                        }
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("restrictions"))
                {
                    List<ResourceSkuRestrictions> array = new List<ResourceSkuRestrictions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ResourceSkuRestrictions.DeserializeResourceSkuRestrictions(item));
                        }
                    }
                    restrictions = array;
                    continue;
                }
            }
            return new ResourceSku(resourceType.HasValue ? resourceType.Value : null, name.HasValue ? name.Value : null, tier.HasValue ? tier.Value : null, size.HasValue ? size.Value : null, family.HasValue ? family.Value : null, kind.HasValue ? kind.Value : null, capacity.HasValue ? capacity.Value : null, new ChangeTrackingList<string>(locations), new ChangeTrackingList<ResourceSkuLocationInfo>(locationInfo), new ChangeTrackingList<string>(apiVersions), new ChangeTrackingList<ResourceSkuCosts>(costs), new ChangeTrackingList<ResourceSkuCapabilities>(capabilities), new ChangeTrackingList<ResourceSkuRestrictions>(restrictions));
        }
    }
}
