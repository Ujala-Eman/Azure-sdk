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
    public partial class Sample_ComputePrivateEndpointConnectionCollection_Exists_GetInformationAboutAPrivateEndpointConnectionUnderADiskAccessResource
    {
        // Get information about a private endpoint connection under a disk access resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "DiskAccesses_GetAPrivateEndpointConnection" operation, for the dependent resources, they will have to be created separately.

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

            // invoke the operation
            string privateEndpointConnectionName = "myPrivateEndpointConnection";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
