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
    public partial class Sample_VirtualMachineScaleSetExtensionCollection_GetAll_VirtualMachineScaleSetExtensionsListMinimumSetGen
    {
        // VirtualMachineScaleSetExtensions_List_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "VirtualMachineScaleSetExtensions_List" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineScaleSetResource created on azure
            // for more information of creating VirtualMachineScaleSetResource, please refer to the document of VirtualMachineScaleSetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineScaleSetResourceId = Compute.VirtualMachineScaleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName);
            Compute.VirtualMachineScaleSetResource virtualMachineScaleSet = client.GetVirtualMachineScaleSetResource(virtualMachineScaleSetResourceId);

            // get the collection of this VirtualMachineScaleSetExtensionResource
            Compute.VirtualMachineScaleSetExtensionCollection collection = virtualMachineScaleSet.GetVirtualMachineScaleSetExtensions();

            // invoke the operation and iterate over the result
            await foreach (Compute.VirtualMachineScaleSetExtensionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                Compute.VirtualMachineScaleSetExtensionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
