// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetInstanceView
    {
        internal static VirtualMachineScaleSetInstanceView DeserializeVirtualMachineScaleSetInstanceView(JsonElement element)
        {
            Optional<VirtualMachineScaleSetInstanceViewStatusesSummary> virtualMachine = default;
            Optional<IReadOnlyList<VirtualMachineScaleSetVMExtensionsSummary>> extensions = default;
            Optional<IReadOnlyList<InstanceViewStatus>> statuses = default;
            Optional<IReadOnlyList<OrchestrationServiceSummary>> orchestrationServices = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualMachine"))
                {
                    virtualMachine = VirtualMachineScaleSetInstanceViewStatusesSummary.DeserializeVirtualMachineScaleSetInstanceViewStatusesSummary(property.Value);
                    continue;
                }
                if (property.NameEquals("extensions"))
                {
                    List<VirtualMachineScaleSetVMExtensionsSummary> array = new List<VirtualMachineScaleSetVMExtensionsSummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(VirtualMachineScaleSetVMExtensionsSummary.DeserializeVirtualMachineScaleSetVMExtensionsSummary(item));
                        }
                    }
                    extensions = array;
                    continue;
                }
                if (property.NameEquals("statuses"))
                {
                    List<InstanceViewStatus> array = new List<InstanceViewStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(InstanceViewStatus.DeserializeInstanceViewStatus(item));
                        }
                    }
                    statuses = array;
                    continue;
                }
                if (property.NameEquals("orchestrationServices"))
                {
                    List<OrchestrationServiceSummary> array = new List<OrchestrationServiceSummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(OrchestrationServiceSummary.DeserializeOrchestrationServiceSummary(item));
                        }
                    }
                    orchestrationServices = array;
                    continue;
                }
            }
            return new VirtualMachineScaleSetInstanceView(virtualMachine.HasValue ? virtualMachine.Value : null, new ChangeTrackingList<VirtualMachineScaleSetVMExtensionsSummary>(extensions), new ChangeTrackingList<InstanceViewStatus>(statuses), new ChangeTrackingList<OrchestrationServiceSummary>(orchestrationServices));
        }
    }
}
