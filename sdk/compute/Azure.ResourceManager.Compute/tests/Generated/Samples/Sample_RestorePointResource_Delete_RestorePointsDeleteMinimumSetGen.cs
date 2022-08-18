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
    public partial class Sample_RestorePointResource_Delete_RestorePointsDeleteMinimumSetGen
    {
        // RestorePoints_Delete_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "RestorePoints_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this RestorePointResource created on azure
            // for more information of creating RestorePointResource, please refer to the document of RestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string restorePointGroupName = "aaaaaaaaaaaaaaaaa";
            string restorePointName = "aaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier restorePointResourceId = Compute.RestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, restorePointName);
            Compute.RestorePointResource restorePoint = client.GetRestorePointResource(restorePointResourceId);

            // invoke the operation
            await restorePoint.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
