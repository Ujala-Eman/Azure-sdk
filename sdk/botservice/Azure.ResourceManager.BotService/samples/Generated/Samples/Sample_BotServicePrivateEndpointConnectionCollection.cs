// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.BotService.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.BotService.Samples
{
    public partial class Sample_BotServicePrivateEndpointConnectionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListPrivateEndpointConnections()
        {
            // Generated from example definition: specification/botservice/resource-manager/Microsoft.BotService/stable/2022-09-15/examples/ListPrivateEndpointConnections.json
            // this example is just showing the usage of "PrivateEndpointConnections_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BotResource created on azure
            // for more information of creating BotResource, please refer to the document of BotResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string resourceName = "sto2527";
            ResourceIdentifier botResourceId = BotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            BotResource bot = client.GetBotResource(botResourceId);

            // get the collection of this BotServicePrivateEndpointConnectionResource
            BotServicePrivateEndpointConnectionCollection collection = bot.GetBotServicePrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (BotServicePrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BotServicePrivateEndpointConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/botservice/resource-manager/Microsoft.BotService/stable/2022-09-15/examples/GetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BotResource created on azure
            // for more information of creating BotResource, please refer to the document of BotResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string resourceName = "sto2527";
            ResourceIdentifier botResourceId = BotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            BotResource bot = client.GetBotResource(botResourceId);

            // get the collection of this BotServicePrivateEndpointConnectionResource
            BotServicePrivateEndpointConnectionCollection collection = bot.GetBotServicePrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            BotServicePrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BotServicePrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/botservice/resource-manager/Microsoft.BotService/stable/2022-09-15/examples/GetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BotResource created on azure
            // for more information of creating BotResource, please refer to the document of BotResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string resourceName = "sto2527";
            ResourceIdentifier botResourceId = BotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            BotResource bot = client.GetBotResource(botResourceId);

            // get the collection of this BotServicePrivateEndpointConnectionResource
            BotServicePrivateEndpointConnectionCollection collection = bot.GetBotServicePrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/botservice/resource-manager/Microsoft.BotService/stable/2022-09-15/examples/GetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BotResource created on azure
            // for more information of creating BotResource, please refer to the document of BotResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string resourceName = "sto2527";
            ResourceIdentifier botResourceId = BotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            BotResource bot = client.GetBotResource(botResourceId);

            // get the collection of this BotServicePrivateEndpointConnectionResource
            BotServicePrivateEndpointConnectionCollection collection = bot.GetBotServicePrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            NullableResponse<BotServicePrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionName);
            BotServicePrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BotServicePrivateEndpointConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_PutPrivateEndpointConnection()
        {
            // Generated from example definition: specification/botservice/resource-manager/Microsoft.BotService/stable/2022-09-15/examples/PutPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BotResource created on azure
            // for more information of creating BotResource, please refer to the document of BotResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res7687";
            string resourceName = "sto9699";
            ResourceIdentifier botResourceId = BotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            BotResource bot = client.GetBotResource(botResourceId);

            // get the collection of this BotServicePrivateEndpointConnectionResource
            BotServicePrivateEndpointConnectionCollection collection = bot.GetBotServicePrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            BotServicePrivateEndpointConnectionData data = new BotServicePrivateEndpointConnectionData()
            {
                ConnectionState = new BotServicePrivateLinkServiceConnectionState()
                {
                    Status = BotServicePrivateEndpointServiceConnectionStatus.Approved,
                    Description = "Auto-Approved",
                },
            };
            ArmOperation<BotServicePrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, data);
            BotServicePrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BotServicePrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
