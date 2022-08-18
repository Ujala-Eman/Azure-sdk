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
    public partial class Sample_GalleryResource_Get_GetAGallery
    {
        // Get a gallery.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "Galleries_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this GalleryResource created on azure
            // for more information of creating GalleryResource, please refer to the document of GalleryResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            ResourceIdentifier galleryResourceId = Compute.GalleryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName);
            Compute.GalleryResource gallery = client.GetGalleryResource(galleryResourceId);

            // invoke the operation
            Compute.GalleryResource result = await gallery.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.GalleryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
