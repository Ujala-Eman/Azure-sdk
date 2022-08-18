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
    public partial class Sample_RestorePointGroupCollection_CreateOrUpdate_CreateOrUpdateARestorePointCollectionForCrossRegionCopy
    {
        // Create or update a restore point collection for cross region copy.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "RestorePointCollections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this RestorePointGroupResource
            Compute.RestorePointGroupCollection collection = resourceGroupResource.GetRestorePointGroups();

            // invoke the operation
            string restorePointGroupName = "myRpc";
            Compute.RestorePointGroupData data = new RestorePointGroupData(new AzureLocation("norwayeast"))
            {
                Source = new RestorePointGroupSource()
                {
                    Id = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/restorePointCollections/sourceRpcName"),
                },
                Tags =
{
["myTag1"] = "tagValue1",
},
            };
            ArmOperation<Compute.RestorePointGroupResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, restorePointGroupName, data);
            Compute.RestorePointGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.RestorePointGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
