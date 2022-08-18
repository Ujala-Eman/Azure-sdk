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
    public partial class Sample_GalleryImageVersionResource_Get_GetAGalleryImageVersionWithVhdAsASource
    {
        // Get a gallery image version with vhd as a source.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "GalleryImageVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this GalleryImageVersionResource created on azure
            // for more information of creating GalleryImageVersionResource, please refer to the document of GalleryImageVersionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryImageName = "myGalleryImageName";
            string galleryImageVersionName = "1.0.0";
            ResourceIdentifier galleryImageVersionResourceId = Compute.GalleryImageVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryImageName, galleryImageVersionName);
            Compute.GalleryImageVersionResource galleryImageVersion = client.GetGalleryImageVersionResource(galleryImageVersionResourceId);

            // invoke the operation
            Compute.GalleryImageVersionResource result = await galleryImageVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.GalleryImageVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
