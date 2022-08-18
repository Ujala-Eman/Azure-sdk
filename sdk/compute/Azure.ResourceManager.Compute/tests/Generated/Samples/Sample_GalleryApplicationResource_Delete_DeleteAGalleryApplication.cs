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
    public partial class Sample_GalleryApplicationResource_Delete_DeleteAGalleryApplication
    {
        // Delete a gallery Application.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "GalleryApplications_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this GalleryApplicationResource created on azure
            // for more information of creating GalleryApplicationResource, please refer to the document of GalleryApplicationResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryApplicationName = "myGalleryApplicationName";
            ResourceIdentifier galleryApplicationResourceId = Compute.GalleryApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryApplicationName);
            Compute.GalleryApplicationResource galleryApplication = client.GetGalleryApplicationResource(galleryApplicationResourceId);

            // invoke the operation
            await galleryApplication.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
