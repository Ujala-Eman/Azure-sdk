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
    public partial class Sample_ManagedDiskResource_RevokeAccess_RevokeAccessToAManagedDisk
    {
        // Revoke access to a managed disk.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RevokeAccess()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "Disks_RevokeAccess" operation, for the dependent resources, they will have to be created separately.

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
            await managedDisk.RevokeAccessAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
