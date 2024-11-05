// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;
using Azure.ResourceManager.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningOnlineEndpointCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateWorkspaceOnlineEndpoint()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/OnlineEndpoint/createOrUpdate.json
            // this example is just showing the usage of "OnlineEndpoints_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceResource created on azure
            // for more information of creating MachineLearningWorkspaceResource, please refer to the document of MachineLearningWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            ResourceIdentifier machineLearningWorkspaceResourceId = MachineLearningWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            MachineLearningWorkspaceResource machineLearningWorkspace = client.GetMachineLearningWorkspaceResource(machineLearningWorkspaceResourceId);

            // get the collection of this MachineLearningOnlineEndpointResource
            MachineLearningOnlineEndpointCollection collection = machineLearningWorkspace.GetMachineLearningOnlineEndpoints();

            // invoke the operation
            string endpointName = "testEndpointName";
            MachineLearningOnlineEndpointData data = new MachineLearningOnlineEndpointData(new AzureLocation("string"), new MachineLearningOnlineEndpointProperties(MachineLearningEndpointAuthMode.AmlToken)
            {
                Compute = "string",
                Traffic =
{
["string"] = 1
},
                Description = "string",
                Properties =
{
["string"] = "string"
},
            })
            {
                Kind = "string",
                Identity = new ManagedServiceIdentity(default)
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("string")] = null
},
                },
                Sku = new MachineLearningSku("string")
                {
                    Tier = MachineLearningSkuTier.Free,
                    Size = "string",
                    Family = "string",
                    Capacity = 1,
                },
                Tags = { },
            };
            ArmOperation<MachineLearningOnlineEndpointResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, endpointName, data);
            MachineLearningOnlineEndpointResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningOnlineEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetWorkspaceOnlineEndpoint()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/OnlineEndpoint/get.json
            // this example is just showing the usage of "OnlineEndpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceResource created on azure
            // for more information of creating MachineLearningWorkspaceResource, please refer to the document of MachineLearningWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            ResourceIdentifier machineLearningWorkspaceResourceId = MachineLearningWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            MachineLearningWorkspaceResource machineLearningWorkspace = client.GetMachineLearningWorkspaceResource(machineLearningWorkspaceResourceId);

            // get the collection of this MachineLearningOnlineEndpointResource
            MachineLearningOnlineEndpointCollection collection = machineLearningWorkspace.GetMachineLearningOnlineEndpoints();

            // invoke the operation
            string endpointName = "testEndpointName";
            MachineLearningOnlineEndpointResource result = await collection.GetAsync(endpointName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningOnlineEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListWorkspaceOnlineEndpoint()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/OnlineEndpoint/list.json
            // this example is just showing the usage of "OnlineEndpoints_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceResource created on azure
            // for more information of creating MachineLearningWorkspaceResource, please refer to the document of MachineLearningWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            ResourceIdentifier machineLearningWorkspaceResourceId = MachineLearningWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            MachineLearningWorkspaceResource machineLearningWorkspace = client.GetMachineLearningWorkspaceResource(machineLearningWorkspaceResourceId);

            // get the collection of this MachineLearningOnlineEndpointResource
            MachineLearningOnlineEndpointCollection collection = machineLearningWorkspace.GetMachineLearningOnlineEndpoints();

            // invoke the operation and iterate over the result
            MachineLearningOnlineEndpointCollectionGetAllOptions options = new MachineLearningOnlineEndpointCollectionGetAllOptions { Name = "string", Count = 1, ComputeType = MachineLearningEndpointComputeType.Managed, Tags = "string", Properties = "string", OrderBy = MachineLearningOrderString.CreatedAtDesc };
            await foreach (MachineLearningOnlineEndpointResource item in collection.GetAllAsync(options))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningOnlineEndpointData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetWorkspaceOnlineEndpoint()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/OnlineEndpoint/get.json
            // this example is just showing the usage of "OnlineEndpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceResource created on azure
            // for more information of creating MachineLearningWorkspaceResource, please refer to the document of MachineLearningWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            ResourceIdentifier machineLearningWorkspaceResourceId = MachineLearningWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            MachineLearningWorkspaceResource machineLearningWorkspace = client.GetMachineLearningWorkspaceResource(machineLearningWorkspaceResourceId);

            // get the collection of this MachineLearningOnlineEndpointResource
            MachineLearningOnlineEndpointCollection collection = machineLearningWorkspace.GetMachineLearningOnlineEndpoints();

            // invoke the operation
            string endpointName = "testEndpointName";
            bool result = await collection.ExistsAsync(endpointName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetWorkspaceOnlineEndpoint()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/OnlineEndpoint/get.json
            // this example is just showing the usage of "OnlineEndpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceResource created on azure
            // for more information of creating MachineLearningWorkspaceResource, please refer to the document of MachineLearningWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            ResourceIdentifier machineLearningWorkspaceResourceId = MachineLearningWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            MachineLearningWorkspaceResource machineLearningWorkspace = client.GetMachineLearningWorkspaceResource(machineLearningWorkspaceResourceId);

            // get the collection of this MachineLearningOnlineEndpointResource
            MachineLearningOnlineEndpointCollection collection = machineLearningWorkspace.GetMachineLearningOnlineEndpoints();

            // invoke the operation
            string endpointName = "testEndpointName";
            NullableResponse<MachineLearningOnlineEndpointResource> response = await collection.GetIfExistsAsync(endpointName);
            MachineLearningOnlineEndpointResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningOnlineEndpointData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
