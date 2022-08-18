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
    public partial class Sample_VirtualMachineExtensionResource_Delete_VirtualMachineExtensionsDeleteMaximumSetGen
    {
        // VirtualMachineExtensions_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "VirtualMachineExtensions_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineExtensionResource created on azure
            // for more information of creating VirtualMachineExtensionResource, please refer to the document of VirtualMachineExtensionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string vmName = "aaaaaaaaaaaaa";
            string vmExtensionName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineExtensionResourceId = Compute.VirtualMachineExtensionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName, vmExtensionName);
            Compute.VirtualMachineExtensionResource virtualMachineExtension = client.GetVirtualMachineExtensionResource(virtualMachineExtensionResourceId);

            // invoke the operation
            await virtualMachineExtension.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
