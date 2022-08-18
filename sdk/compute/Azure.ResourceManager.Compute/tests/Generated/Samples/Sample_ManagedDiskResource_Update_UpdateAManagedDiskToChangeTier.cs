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
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_ManagedDiskResource_Update_UpdateAManagedDiskToChangeTier
    {
        // Update a managed disk to change tier.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "Disks_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ManagedDiskResource created on azure
            // for more information of creating ManagedDiskResource, please refer to the document of ManagedDiskResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskName = "myDisk";
            ResourceIdentifier managedDiskResourceId = Compute.ManagedDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskName);
            Compute.ManagedDiskResource managedDisk = client.GetManagedDiskResource(managedDiskResourceId);

            // invoke the operation
            Compute.Models.ManagedDiskPatch patch = new ManagedDiskPatch()
            {
                Tier = "P30",
            };
            ArmOperation<Compute.ManagedDiskResource> lro = await managedDisk.UpdateAsync(WaitUntil.Completed, patch);
            Compute.ManagedDiskResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.ManagedDiskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
