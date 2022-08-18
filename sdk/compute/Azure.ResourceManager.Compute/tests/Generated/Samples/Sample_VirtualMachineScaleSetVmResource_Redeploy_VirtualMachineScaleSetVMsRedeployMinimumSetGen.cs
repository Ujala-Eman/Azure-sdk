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
    public partial class Sample_VirtualMachineScaleSetVmResource_Redeploy_VirtualMachineScaleSetVMsRedeployMinimumSetGen
    {
        // VirtualMachineScaleSetVMs_Redeploy_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Redeploy()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "VirtualMachineScaleSetVMs_Redeploy" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineScaleSetVmResource created on azure
            // for more information of creating VirtualMachineScaleSetVmResource, please refer to the document of VirtualMachineScaleSetVmResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "aaaaaaaaaaaaa";
            string instanceId = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineScaleSetVmResourceId = Compute.VirtualMachineScaleSetVmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId);
            Compute.VirtualMachineScaleSetVmResource virtualMachineScaleSetVm = client.GetVirtualMachineScaleSetVmResource(virtualMachineScaleSetVmResourceId);

            // invoke the operation
            await virtualMachineScaleSetVm.RedeployAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
