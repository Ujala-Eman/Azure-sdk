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
    public partial class Sample_VirtualMachineScaleSetVmExtensionCollection_GetAll_ListExtensionsInVmssInstance
    {
        // List extensions in Vmss instance.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "VirtualMachineScaleSetVMExtensions_List" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this VirtualMachineScaleSetVmExtensionResource
            Compute.VirtualMachineScaleSetVmExtensionCollection collection = virtualMachineScaleSetVm.GetVirtualMachineScaleSetVmExtensions();

            // invoke the operation and iterate over the result
            await foreach (Compute.VirtualMachineScaleSetVmExtensionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                Compute.VirtualMachineScaleSetVmExtensionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
