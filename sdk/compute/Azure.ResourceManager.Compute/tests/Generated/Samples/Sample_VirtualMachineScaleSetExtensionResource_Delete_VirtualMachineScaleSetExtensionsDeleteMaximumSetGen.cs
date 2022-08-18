// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_VirtualMachineScaleSetExtensionResource_Delete_VirtualMachineScaleSetExtensionsDeleteMaximumSetGen
    {
        // VirtualMachineScaleSetExtensions_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "VirtualMachineScaleSetExtensions_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineScaleSetExtensionResource created on azure
            // for more information of creating VirtualMachineScaleSetExtensionResource, please refer to the document of VirtualMachineScaleSetExtensionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string vmssExtensionName = "aaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineScaleSetExtensionResourceId = Compute.VirtualMachineScaleSetExtensionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName, vmssExtensionName);
            Compute.VirtualMachineScaleSetExtensionResource virtualMachineScaleSetExtension = client.GetVirtualMachineScaleSetExtensionResource(virtualMachineScaleSetExtensionResourceId);

            // invoke the operation
            await virtualMachineScaleSetExtension.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
