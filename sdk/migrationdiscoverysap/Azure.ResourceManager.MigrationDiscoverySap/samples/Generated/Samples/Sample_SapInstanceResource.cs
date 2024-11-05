// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MigrationDiscoverySap.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.MigrationDiscoverySap.Samples
{
    public partial class Sample_SapInstanceResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GETASAPInstanceResource()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/SAPDiscoverySites/preview/2023-10-01-preview/examples/SAPInstances_Get.json
            // this example is just showing the usage of "SapInstances_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapInstanceResource created on azure
            // for more information of creating SapInstanceResource, please refer to the document of SapInstanceResource
            string subscriptionId = "6d875e77-e412-4d7d-9af4-8895278b4443";
            string resourceGroupName = "test-rg";
            string sapDiscoverySiteName = "SampleSite";
            string sapInstanceName = "MPP_MPP";
            ResourceIdentifier sapInstanceResourceId = SapInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapDiscoverySiteName, sapInstanceName);
            SapInstanceResource sapInstance = client.GetSapInstanceResource(sapInstanceResourceId);

            // invoke the operation
            SapInstanceResource result = await sapInstance.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SapInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeletesTheSAPInstanceResource()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/SAPDiscoverySites/preview/2023-10-01-preview/examples/SAPInstances_Delete.json
            // this example is just showing the usage of "SapInstances_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapInstanceResource created on azure
            // for more information of creating SapInstanceResource, please refer to the document of SapInstanceResource
            string subscriptionId = "6d875e77-e412-4d7d-9af4-8895278b4443";
            string resourceGroupName = "test-rg";
            string sapDiscoverySiteName = "SampleSite";
            string sapInstanceName = "MPP_MPP";
            ResourceIdentifier sapInstanceResourceId = SapInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapDiscoverySiteName, sapInstanceName);
            SapInstanceResource sapInstance = client.GetSapInstanceResource(sapInstanceResourceId);

            // invoke the operation
            await sapInstance.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdatesTheSAPInstanceResource()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/SAPDiscoverySites/preview/2023-10-01-preview/examples/SAPInstances_Update.json
            // this example is just showing the usage of "SapInstances_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapInstanceResource created on azure
            // for more information of creating SapInstanceResource, please refer to the document of SapInstanceResource
            string subscriptionId = "6d875e77-e412-4d7d-9af4-8895278b4443";
            string resourceGroupName = "test-rg";
            string sapDiscoverySiteName = "SampleSite";
            string sapInstanceName = "MPP_MPP";
            ResourceIdentifier sapInstanceResourceId = SapInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapDiscoverySiteName, sapInstanceName);
            SapInstanceResource sapInstance = client.GetSapInstanceResource(sapInstanceResourceId);

            // invoke the operation
            SapInstancePatch patch = new SapInstancePatch
            {
                Tags =
{
["tag1"] = "value1"
},
            };
            SapInstanceResource result = await sapInstance.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SapInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
