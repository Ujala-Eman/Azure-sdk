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
    public partial class Sample_ComputePrivateEndpointConnectionCollection_GetAll_GetInformationAboutAPrivateEndpointConnectionUnderADiskAccessResource
    {
        // Get information about a private endpoint connection under a disk access resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "DiskAccesses_ListPrivateEndpointConnections" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DiskAccessResource created on azure
            // for more information of creating DiskAccessResource, please refer to the document of DiskAccessResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskAccessName = "myDiskAccess";
            ResourceIdentifier diskAccessResourceId = Compute.DiskAccessResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskAccessName);
            Compute.DiskAccessResource diskAccess = client.GetDiskAccessResource(diskAccessResourceId);

            // get the collection of this ComputePrivateEndpointConnectionResource
            Compute.ComputePrivateEndpointConnectionCollection collection = diskAccess.GetComputePrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (Compute.ComputePrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                Compute.ComputePrivateEndpointConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
