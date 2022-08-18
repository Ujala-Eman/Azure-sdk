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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_ManagedDiskCollection_CreateOrUpdate_CreateAManagedDiskFromAnAzureComputeGalleryCommunityImage
    {
        // Create a managed disk from an Azure Compute Gallery community image.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "Disks_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ManagedDiskResource
            Compute.ManagedDiskCollection collection = resourceGroupResource.GetManagedDisks();

            // invoke the operation
            string diskName = "myDisk";
            Compute.ManagedDiskData data = new ManagedDiskData(new AzureLocation("West US"))
            {
                OSType = SupportedOperatingSystemType.Windows,
                CreationData = new DiskCreationData(DiskCreateOption.FromImage)
                {
                    GalleryImageReference = new ImageDiskReference()
                    {
                        CommunityGalleryImageId = "/CommunityGalleries/{communityGalleryPublicGalleryName}/Images/{imageName}/Versions/1.0.0",
                    },
                },
            };
            ArmOperation<Compute.ManagedDiskResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, diskName, data);
            Compute.ManagedDiskResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.ManagedDiskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
