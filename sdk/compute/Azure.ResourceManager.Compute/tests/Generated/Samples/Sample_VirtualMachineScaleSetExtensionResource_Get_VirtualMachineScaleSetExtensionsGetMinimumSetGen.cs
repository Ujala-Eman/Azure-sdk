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
    public partial class Sample_VirtualMachineScaleSetExtensionResource_Get_VirtualMachineScaleSetExtensionsGetMinimumSetGen
    {
        // VirtualMachineScaleSetExtensions_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "VirtualMachineScaleSetExtensions_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineScaleSetExtensionResource created on azure
            // for more information of creating VirtualMachineScaleSetExtensionResource, please refer to the document of VirtualMachineScaleSetExtensionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "a";
            string vmssExtensionName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineScaleSetExtensionResourceId = Compute.VirtualMachineScaleSetExtensionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName, vmssExtensionName);
            Compute.VirtualMachineScaleSetExtensionResource virtualMachineScaleSetExtension = client.GetVirtualMachineScaleSetExtensionResource(virtualMachineScaleSetExtensionResourceId);

            // invoke the operation
            Compute.VirtualMachineScaleSetExtensionResource result = await virtualMachineScaleSetExtension.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.VirtualMachineScaleSetExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
