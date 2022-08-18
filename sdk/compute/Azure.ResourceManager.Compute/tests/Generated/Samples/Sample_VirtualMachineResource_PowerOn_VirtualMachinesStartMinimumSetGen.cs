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
    public partial class Sample_VirtualMachineResource_PowerOn_VirtualMachinesStartMinimumSetGen
    {
        // VirtualMachines_Start_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task PowerOn()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "VirtualMachines_Start" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineResource created on azure
            // for more information of creating VirtualMachineResource, please refer to the document of VirtualMachineResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string vmName = "aaaaa";
            ResourceIdentifier virtualMachineResourceId = Compute.VirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName);
            Compute.VirtualMachineResource virtualMachine = client.GetVirtualMachineResource(virtualMachineResourceId);

            // invoke the operation
            await virtualMachine.PowerOnAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
