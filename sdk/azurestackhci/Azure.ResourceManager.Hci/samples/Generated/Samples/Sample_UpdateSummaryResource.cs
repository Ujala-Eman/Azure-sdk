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
using Azure.ResourceManager.Hci;
using Azure.ResourceManager.Hci.Models;

namespace Azure.ResourceManager.Hci.Samples
{
    public partial class Sample_UpdateSummaryResource
    {
        // Delete an Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAnUpdate()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/stable/2023-02-01/examples/DeleteUpdateSummaries.json
            // this example is just showing the usage of "UpdateSummaries_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this UpdateSummaryResource created on azure
            // for more information of creating UpdateSummaryResource, please refer to the document of UpdateSummaryResource
            string subscriptionId = "b8d594e5-51f3-4c11-9c54-a7771b81c712";
            string resourceGroupName = "testrg";
            string clusterName = "testcluster";
            ResourceIdentifier updateSummaryResourceId = UpdateSummaryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            UpdateSummaryResource updateSummary = client.GetUpdateSummaryResource(updateSummaryResourceId);

            // invoke the operation
            await updateSummary.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Put Update summaries under cluster resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutUpdateSummariesUnderClusterResource()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/stable/2023-02-01/examples/PutUpdateSummaries.json
            // this example is just showing the usage of "UpdateSummaries_Put" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this UpdateSummaryResource created on azure
            // for more information of creating UpdateSummaryResource, please refer to the document of UpdateSummaryResource
            string subscriptionId = "b8d594e5-51f3-4c11-9c54-a7771b81c712";
            string resourceGroupName = "testrg";
            string clusterName = "testcluster";
            ResourceIdentifier updateSummaryResourceId = UpdateSummaryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            UpdateSummaryResource updateSummary = client.GetUpdateSummaryResource(updateSummaryResourceId);

            // invoke the operation
            UpdateSummaryData data = new UpdateSummaryData()
            {
                OemFamily = "DellEMC",
                HardwareModel = "PowerEdge R730xd",
                CurrentVersion = "4.2203.2.32",
                LastUpdated = DateTimeOffset.Parse("2022-04-06T14:08:18.254Z"),
                LastChecked = DateTimeOffset.Parse("2022-04-07T18:04:07Z"),
                State = UpdateSummariesPropertiesState.AppliedSuccessfully,
            };
            ArmOperation<UpdateSummaryResource> lro = await updateSummary.CreateOrUpdateAsync(WaitUntil.Completed, data);
            UpdateSummaryResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            UpdateSummaryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Update summaries under cluster resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetUpdateSummariesUnderClusterResource()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/stable/2023-02-01/examples/GetUpdateSummaries.json
            // this example is just showing the usage of "UpdateSummaries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this UpdateSummaryResource created on azure
            // for more information of creating UpdateSummaryResource, please refer to the document of UpdateSummaryResource
            string subscriptionId = "b8d594e5-51f3-4c11-9c54-a7771b81c712";
            string resourceGroupName = "testrg";
            string clusterName = "testcluster";
            ResourceIdentifier updateSummaryResourceId = UpdateSummaryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            UpdateSummaryResource updateSummary = client.GetUpdateSummaryResource(updateSummaryResourceId);

            // invoke the operation
            UpdateSummaryResource result = await updateSummary.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            UpdateSummaryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
