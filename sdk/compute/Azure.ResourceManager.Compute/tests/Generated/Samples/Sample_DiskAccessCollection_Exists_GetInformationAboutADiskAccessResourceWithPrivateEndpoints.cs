// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_DiskAccessCollection_Exists_GetInformationAboutADiskAccessResourceWithPrivateEndpoints
    {
        // Get information about a disk access resource with private endpoints.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "DiskAccesses_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskAccessResource
            Compute.DiskAccessCollection collection = resourceGroupResource.GetDiskAccesses();

            // invoke the operation
            string diskAccessName = "myDiskAccess";
            bool result = await collection.ExistsAsync(diskAccessName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
