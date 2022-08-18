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
    public partial class Sample_VirtualMachineScaleSetResource_CancelVirtualMachineScaleSetRollingUpgrade_VirtualMachineScaleSetRollingUpgradesCancelMinimumSetGen
    {
        // VirtualMachineScaleSetRollingUpgrades_Cancel_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CancelVirtualMachineScaleSetRollingUpgrade()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "VirtualMachineScaleSetRollingUpgrades_Cancel" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineScaleSetResource created on azure
            // for more information of creating VirtualMachineScaleSetResource, please refer to the document of VirtualMachineScaleSetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "aaaaaa";
            ResourceIdentifier virtualMachineScaleSetResourceId = Compute.VirtualMachineScaleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName);
            Compute.VirtualMachineScaleSetResource virtualMachineScaleSet = client.GetVirtualMachineScaleSetResource(virtualMachineScaleSetResourceId);

            // invoke the operation
            await virtualMachineScaleSet.CancelVirtualMachineScaleSetRollingUpgradeAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
