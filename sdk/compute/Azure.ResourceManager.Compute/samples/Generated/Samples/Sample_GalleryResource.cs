// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Compute.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_GalleryResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetACommunityGallery()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2023-07-03/examples/galleryExamples/CommunityGallery_Get.json
            // this example is just showing the usage of "Galleries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryResource created on azure
            // for more information of creating GalleryResource, please refer to the document of GalleryResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            ResourceIdentifier galleryResourceId = GalleryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName);
            GalleryResource gallery = client.GetGalleryResource(galleryResourceId);

            // invoke the operation
            GalleryResource result = await gallery.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GalleryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAGalleryWithExpandSharingProfileGroups()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2023-07-03/examples/galleryExamples/Gallery_Get_WithExpandSharingProfileGroups.json
            // this example is just showing the usage of "Galleries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryResource created on azure
            // for more information of creating GalleryResource, please refer to the document of GalleryResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            ResourceIdentifier galleryResourceId = GalleryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName);
            GalleryResource gallery = client.GetGalleryResource(galleryResourceId);

            // invoke the operation
            GalleryExpand? expand = GalleryExpand.SharingProfileGroups;
            GalleryResource result = await gallery.GetAsync(expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GalleryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAGalleryWithSelectPermissions()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2023-07-03/examples/galleryExamples/Gallery_Get_WithSelectPermissions.json
            // this example is just showing the usage of "Galleries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryResource created on azure
            // for more information of creating GalleryResource, please refer to the document of GalleryResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            ResourceIdentifier galleryResourceId = GalleryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName);
            GalleryResource gallery = client.GetGalleryResource(galleryResourceId);

            // invoke the operation
            SelectPermission? select = SelectPermission.Permissions;
            GalleryResource result = await gallery.GetAsync(select);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GalleryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAGallery()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2023-07-03/examples/galleryExamples/Gallery_Get.json
            // this example is just showing the usage of "Galleries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryResource created on azure
            // for more information of creating GalleryResource, please refer to the document of GalleryResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            ResourceIdentifier galleryResourceId = GalleryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName);
            GalleryResource gallery = client.GetGalleryResource(galleryResourceId);

            // invoke the operation
            GalleryResource result = await gallery.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GalleryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAGallery()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2023-07-03/examples/galleryExamples/Gallery_Delete.json
            // this example is just showing the usage of "Galleries_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryResource created on azure
            // for more information of creating GalleryResource, please refer to the document of GalleryResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            ResourceIdentifier galleryResourceId = GalleryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName);
            GalleryResource gallery = client.GetGalleryResource(galleryResourceId);

            // invoke the operation
            await gallery.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateASimpleGallery()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2023-07-03/examples/galleryExamples/Gallery_Update.json
            // this example is just showing the usage of "Galleries_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryResource created on azure
            // for more information of creating GalleryResource, please refer to the document of GalleryResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            ResourceIdentifier galleryResourceId = GalleryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName);
            GalleryResource gallery = client.GetGalleryResource(galleryResourceId);

            // invoke the operation
            GalleryPatch patch = new GalleryPatch
            {
                Description = "This is the gallery description.",
            };
            ArmOperation<GalleryResource> lro = await gallery.UpdateAsync(WaitUntil.Completed, patch);
            GalleryResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GalleryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task UpdateSharingProfile_AddSharingIdToTheSharingProfileOfAGallery()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2023-07-03/examples/galleryExamples/Gallery_AddToSharingProfile.json
            // this example is just showing the usage of "GallerySharingProfile_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryResource created on azure
            // for more information of creating GalleryResource, please refer to the document of GalleryResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            ResourceIdentifier galleryResourceId = GalleryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName);
            GalleryResource gallery = client.GetGalleryResource(galleryResourceId);

            // invoke the operation
            SharingUpdate sharingUpdate = new SharingUpdate(SharingUpdateOperationType.Add)
            {
                Groups = {new SharingProfileGroup
{
GroupType = SharingProfileGroupType.Subscriptions,
Ids = {"34a4ab42-0d72-47d9-bd1a-aed207386dac", "380fd389-260b-41aa-bad9-0a83108c370b"},
}, new SharingProfileGroup
{
GroupType = SharingProfileGroupType.AADTenants,
Ids = {"c24c76aa-8897-4027-9b03-8f7928b54ff6"},
}},
            };
            ArmOperation<SharingUpdate> lro = await gallery.UpdateSharingProfileAsync(WaitUntil.Completed, sharingUpdate);
            SharingUpdate result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task UpdateSharingProfile_ResetSharingProfileOfAGallery()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2023-07-03/examples/galleryExamples/Gallery_ResetSharingProfile.json
            // this example is just showing the usage of "GallerySharingProfile_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryResource created on azure
            // for more information of creating GalleryResource, please refer to the document of GalleryResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            ResourceIdentifier galleryResourceId = GalleryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName);
            GalleryResource gallery = client.GetGalleryResource(galleryResourceId);

            // invoke the operation
            SharingUpdate sharingUpdate = new SharingUpdate(SharingUpdateOperationType.Reset);
            ArmOperation<SharingUpdate> lro = await gallery.UpdateSharingProfileAsync(WaitUntil.Completed, sharingUpdate);
            SharingUpdate result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task UpdateSharingProfile_ShareAGalleryToCommunity()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2023-07-03/examples/galleryExamples/Gallery_EnableCommunityGallery.json
            // this example is just showing the usage of "GallerySharingProfile_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryResource created on azure
            // for more information of creating GalleryResource, please refer to the document of GalleryResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            ResourceIdentifier galleryResourceId = GalleryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName);
            GalleryResource gallery = client.GetGalleryResource(galleryResourceId);

            // invoke the operation
            SharingUpdate sharingUpdate = new SharingUpdate(SharingUpdateOperationType.EnableCommunity);
            ArmOperation<SharingUpdate> lro = await gallery.UpdateSharingProfileAsync(WaitUntil.Completed, sharingUpdate);
            SharingUpdate result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
