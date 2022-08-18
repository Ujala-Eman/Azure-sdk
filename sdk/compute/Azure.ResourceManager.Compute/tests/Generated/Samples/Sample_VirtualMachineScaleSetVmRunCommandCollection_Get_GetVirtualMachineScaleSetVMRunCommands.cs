// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_VirtualMachineScaleSetVmRunCommandCollection_Get_GetVirtualMachineScaleSetVMRunCommands
    {
        // Get VirtualMachineScaleSet VM run commands.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "VirtualMachineScaleSetVMRunCommands_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineScaleSetVmResource created on azure
            // for more information of creating VirtualMachineScaleSetVmResource, please refer to the document of VirtualMachineScaleSetVmResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string virtualMachineScaleSetName = "myvmScaleSet";
            string instanceId = "0";
            ResourceIdentifier virtualMachineScaleSetVmResourceId = Compute.VirtualMachineScaleSetVmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId);
            Compute.VirtualMachineScaleSetVmResource virtualMachineScaleSetVm = client.GetVirtualMachineScaleSetVmResource(virtualMachineScaleSetVmResourceId);

            // get the collection of this VirtualMachineScaleSetVmRunCommandResource
            Compute.VirtualMachineScaleSetVmRunCommandCollection collection = virtualMachineScaleSetVm.GetVirtualMachineScaleSetVmRunCommands();

            // invoke the operation
            string runCommandName = "myRunCommand";
            Compute.VirtualMachineScaleSetVmRunCommandResource result = await collection.GetAsync(runCommandName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.VirtualMachineRunCommandData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
