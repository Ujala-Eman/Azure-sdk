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
    public partial class Sample_VirtualMachineScaleSetRollingUpgradeResource_Get_VirtualMachineScaleSetRollingUpgradesGetLatestMinimumSetGen
    {
        // VirtualMachineScaleSetRollingUpgrades_GetLatest_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "VirtualMachineScaleSetRollingUpgrades_GetLatest" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineScaleSetRollingUpgradeResource created on azure
            // for more information of creating VirtualMachineScaleSetRollingUpgradeResource, please refer to the document of VirtualMachineScaleSetRollingUpgradeResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "aaaaaaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineScaleSetRollingUpgradeResourceId = Compute.VirtualMachineScaleSetRollingUpgradeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName);
            Compute.VirtualMachineScaleSetRollingUpgradeResource virtualMachineScaleSetRollingUpgrade = client.GetVirtualMachineScaleSetRollingUpgradeResource(virtualMachineScaleSetRollingUpgradeResourceId);

            // invoke the operation
            Compute.VirtualMachineScaleSetRollingUpgradeResource result = await virtualMachineScaleSetRollingUpgrade.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.VirtualMachineScaleSetRollingUpgradeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
