// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.StorageActions.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.StorageActions.Samples
{
    public partial class Sample_StorageTaskResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetStorageTask()
        {
            // Generated from example definition: specification/storageactions/resource-manager/Microsoft.StorageActions/stable/2023-01-01/examples/storageTasksCrud/GetStorageTask.json
            // this example is just showing the usage of "StorageTasks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageTaskResource created on azure
            // for more information of creating StorageTaskResource, please refer to the document of StorageTaskResource
            string subscriptionId = "1f31ba14-ce16-4281-b9b4-3e78da6e1616";
            string resourceGroupName = "res4228";
            string storageTaskName = "mytask1";
            ResourceIdentifier storageTaskResourceId = StorageTaskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageTaskName);
            StorageTaskResource storageTask = client.GetStorageTaskResource(storageTaskResourceId);

            // invoke the operation
            StorageTaskResource result = await storageTask.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageTaskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteStorageTask()
        {
            // Generated from example definition: specification/storageactions/resource-manager/Microsoft.StorageActions/stable/2023-01-01/examples/storageTasksCrud/DeleteStorageTask.json
            // this example is just showing the usage of "StorageTasks_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageTaskResource created on azure
            // for more information of creating StorageTaskResource, please refer to the document of StorageTaskResource
            string subscriptionId = "1f31ba14-ce16-4281-b9b4-3e78da6e1616";
            string resourceGroupName = "res4228";
            string storageTaskName = "mytask1";
            ResourceIdentifier storageTaskResourceId = StorageTaskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageTaskName);
            StorageTaskResource storageTask = client.GetStorageTaskResource(storageTaskResourceId);

            // invoke the operation
            await storageTask.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PatchStorageTask()
        {
            // Generated from example definition: specification/storageactions/resource-manager/Microsoft.StorageActions/stable/2023-01-01/examples/storageTasksCrud/PatchStorageTask.json
            // this example is just showing the usage of "StorageTasks_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageTaskResource created on azure
            // for more information of creating StorageTaskResource, please refer to the document of StorageTaskResource
            string subscriptionId = "1f31ba14-ce16-4281-b9b4-3e78da6e1616";
            string resourceGroupName = "res4228";
            string storageTaskName = "mytask1";
            ResourceIdentifier storageTaskResourceId = StorageTaskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageTaskName);
            StorageTaskResource storageTask = client.GetStorageTaskResource(storageTaskResourceId);

            // invoke the operation
            StorageTaskPatch patch = new StorageTaskPatch
            {
                Identity = new ManagedServiceIdentity(default)
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/1f31ba14-ce16-4281-b9b4-3e78da6e1616/resourceGroups/res4228/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myUserAssignedIdentity")] = null
},
                },
                Properties = new StorageTaskProperties(true, "My Storage task", new StorageTaskAction(new StorageTaskIfCondition("[[equals(AccessTier, 'Cool')]]", new StorageTaskOperationInfo[]
            {
new StorageTaskOperationInfo(StorageTaskOperationName.SetBlobTier)
{
Parameters =
{
["tier"] = "Hot"
},
OnSuccess = OnSuccessAction.Continue,
OnFailure = OnFailureAction.Break,
}
            }))
                {
                    ElseOperations = {new StorageTaskOperationInfo(StorageTaskOperationName.DeleteBlob)
{
OnSuccess = OnSuccessAction.Continue,
OnFailure = OnFailureAction.Break,
}},
                }),
            };
            ArmOperation<StorageTaskResource> lro = await storageTask.UpdateAsync(WaitUntil.Completed, patch);
            StorageTaskResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageTaskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetStorageTaskAssignments_ListStorageTaskAssignmentsByResourceGroup()
        {
            // Generated from example definition: specification/storageactions/resource-manager/Microsoft.StorageActions/stable/2023-01-01/examples/storageTasksList/ListStorageTaskAssignmentIds.json
            // this example is just showing the usage of "StorageTaskAssignment_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageTaskResource created on azure
            // for more information of creating StorageTaskResource, please refer to the document of StorageTaskResource
            string subscriptionId = "1f31ba14-ce16-4281-b9b4-3e78da6e1616";
            string resourceGroupName = "rgroup1";
            string storageTaskName = "mytask1";
            ResourceIdentifier storageTaskResourceId = StorageTaskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageTaskName);
            StorageTaskResource storageTask = client.GetStorageTaskResource(storageTaskResourceId);

            // invoke the operation and iterate over the result
            await foreach (SubResource item in storageTask.GetStorageTaskAssignmentsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetStorageTasksReports_ListStorageTasksByResourceGroup()
        {
            // Generated from example definition: specification/storageactions/resource-manager/Microsoft.StorageActions/stable/2023-01-01/examples/storageTasksList/ListStorageTasksRunReportSummary.json
            // this example is just showing the usage of "StorageTasksReport_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageTaskResource created on azure
            // for more information of creating StorageTaskResource, please refer to the document of StorageTaskResource
            string subscriptionId = "1f31ba14-ce16-4281-b9b4-3e78da6e1616";
            string resourceGroupName = "rgroup1";
            string storageTaskName = "mytask1";
            ResourceIdentifier storageTaskResourceId = StorageTaskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageTaskName);
            StorageTaskResource storageTask = client.GetStorageTaskResource(storageTaskResourceId);

            // invoke the operation and iterate over the result
            await foreach (StorageTaskReportInstance item in storageTask.GetStorageTasksReportsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
