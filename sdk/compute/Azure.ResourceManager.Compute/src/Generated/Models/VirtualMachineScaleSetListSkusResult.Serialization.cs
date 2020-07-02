// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetListSkusResult
    {
        internal static VirtualMachineScaleSetListSkusResult DeserializeVirtualMachineScaleSetListSkusResult(JsonElement element)
        {
            IReadOnlyList<VirtualMachineScaleSetSku> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<VirtualMachineScaleSetSku> array = new List<VirtualMachineScaleSetSku>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(VirtualMachineScaleSetSku.DeserializeVirtualMachineScaleSetSku(item));
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
            return new VirtualMachineScaleSetListSkusResult(value, nextLink.HasValue ? nextLink.Value : null);
        }
    }
}
