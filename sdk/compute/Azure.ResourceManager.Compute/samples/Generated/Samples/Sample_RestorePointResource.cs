// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_RestorePointResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CopyARestorePointToADifferentRegion()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/restorePointExamples/RestorePoint_Copy_BetweenRegions.json
            // this example is just showing the usage of "RestorePoints_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RestorePointResource created on azure
            // for more information of creating RestorePointResource, please refer to the document of RestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string restorePointGroupName = "rpcName";
            string restorePointName = "rpName";
            ResourceIdentifier restorePointResourceId = RestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, restorePointName);
            RestorePointResource restorePoint = client.GetRestorePointResource(restorePointResourceId);

            // invoke the operation
            RestorePointData data = new RestorePointData()
            {
                SourceRestorePointId = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/restorePointCollections/sourceRpcName/restorePoints/sourceRpName"),
            };
            ArmOperation<RestorePointResource> lro = await restorePoint.UpdateAsync(WaitUntil.Completed, data);
            RestorePointResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RestorePointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateARestorePoint()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/restorePointExamples/RestorePoint_Create.json
            // this example is just showing the usage of "RestorePoints_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RestorePointResource created on azure
            // for more information of creating RestorePointResource, please refer to the document of RestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string restorePointGroupName = "rpcName";
            string restorePointName = "rpName";
            ResourceIdentifier restorePointResourceId = RestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, restorePointName);
            RestorePointResource restorePoint = client.GetRestorePointResource(restorePointResourceId);

            // invoke the operation
            RestorePointData data = new RestorePointData()
            {
                ExcludeDisks =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/disks/disk123"),
}
},
            };
            ArmOperation<RestorePointResource> lro = await restorePoint.UpdateAsync(WaitUntil.Completed, data);
            RestorePointResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RestorePointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_RestorePointDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/restorePointExamples/RestorePoint_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "RestorePoints_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RestorePointResource created on azure
            // for more information of creating RestorePointResource, please refer to the document of RestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string restorePointGroupName = "aaaaaaaaaaaaaaaaaaaaaa";
            string restorePointName = "a";
            ResourceIdentifier restorePointResourceId = RestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, restorePointName);
            RestorePointResource restorePoint = client.GetRestorePointResource(restorePointResourceId);

            // invoke the operation
            await restorePoint.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_RestorePointDeleteMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/restorePointExamples/RestorePoint_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "RestorePoints_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RestorePointResource created on azure
            // for more information of creating RestorePointResource, please refer to the document of RestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string restorePointGroupName = "aaaaaaaaaaaaaaaaa";
            string restorePointName = "aaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier restorePointResourceId = RestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, restorePointName);
            RestorePointResource restorePoint = client.GetRestorePointResource(restorePointResourceId);

            // invoke the operation
            await restorePoint.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetARestorePoint()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/restorePointExamples/RestorePoint_Get.json
            // this example is just showing the usage of "RestorePoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RestorePointResource created on azure
            // for more information of creating RestorePointResource, please refer to the document of RestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string restorePointGroupName = "rpcName";
            string restorePointName = "rpName";
            ResourceIdentifier restorePointResourceId = RestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, restorePointName);
            RestorePointResource restorePoint = client.GetRestorePointResource(restorePointResourceId);

            // invoke the operation
            RestorePointResource result = await restorePoint.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RestorePointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetRestorePointWithInstanceView()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/restorePointExamples/RestorePoint_Get_WithInstanceView.json
            // this example is just showing the usage of "RestorePoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RestorePointResource created on azure
            // for more information of creating RestorePointResource, please refer to the document of RestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string restorePointGroupName = "rpcName";
            string restorePointName = "rpName";
            ResourceIdentifier restorePointResourceId = RestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, restorePointName);
            RestorePointResource restorePoint = client.GetRestorePointResource(restorePointResourceId);

            // invoke the operation
            RestorePointResource result = await restorePoint.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RestorePointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
