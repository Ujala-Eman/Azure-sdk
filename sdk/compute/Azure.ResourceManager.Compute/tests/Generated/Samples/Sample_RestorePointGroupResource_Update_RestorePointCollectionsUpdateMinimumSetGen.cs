// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_RestorePointGroupResource_Update_RestorePointCollectionsUpdateMinimumSetGen
    {
        // RestorePointCollections_Update_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "RestorePointCollections_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this RestorePointGroupResource created on azure
            // for more information of creating RestorePointGroupResource, please refer to the document of RestorePointGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string restorePointGroupName = "aaaaaaaaaaaaaaaaaa";
            ResourceIdentifier restorePointGroupResourceId = Compute.RestorePointGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName);
            Compute.RestorePointGroupResource restorePointGroup = client.GetRestorePointGroupResource(restorePointGroupResourceId);

            // invoke the operation
            Compute.Models.RestorePointGroupPatch patch = new RestorePointGroupPatch();
            Compute.RestorePointGroupResource result = await restorePointGroup.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.RestorePointGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
