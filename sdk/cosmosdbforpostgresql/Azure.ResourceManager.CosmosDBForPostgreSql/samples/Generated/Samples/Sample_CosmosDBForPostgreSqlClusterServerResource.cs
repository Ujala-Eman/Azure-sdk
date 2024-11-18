// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Samples
{
    public partial class Sample_CosmosDBForPostgreSqlClusterServerResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetTheServerOfCluster()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/ServerGet.json
            // this example is just showing the usage of "Servers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlClusterServerResource created on azure
            // for more information of creating CosmosDBForPostgreSqlClusterServerResource, please refer to the document of CosmosDBForPostgreSqlClusterServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string clusterName = "testcluster1";
            string serverName = "testcluster1-c";
            ResourceIdentifier cosmosDBForPostgreSqlClusterServerResourceId = CosmosDBForPostgreSqlClusterServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, serverName);
            CosmosDBForPostgreSqlClusterServerResource cosmosDBForPostgreSqlClusterServer = client.GetCosmosDBForPostgreSqlClusterServerResource(cosmosDBForPostgreSqlClusterServerResourceId);

            // invoke the operation
            CosmosDBForPostgreSqlClusterServerResource result = await cosmosDBForPostgreSqlClusterServer.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBForPostgreSqlClusterServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetConfigurations_ListConfigurationsOfTheServerThatInTheCluster()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/ConfigurationListByServer.json
            // this example is just showing the usage of "Configurations_ListByServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlClusterServerResource created on azure
            // for more information of creating CosmosDBForPostgreSqlClusterServerResource, please refer to the document of CosmosDBForPostgreSqlClusterServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestResourceGroup";
            string clusterName = "testcluster";
            string serverName = "testserver";
            ResourceIdentifier cosmosDBForPostgreSqlClusterServerResourceId = CosmosDBForPostgreSqlClusterServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, serverName);
            CosmosDBForPostgreSqlClusterServerResource cosmosDBForPostgreSqlClusterServer = client.GetCosmosDBForPostgreSqlClusterServerResource(cosmosDBForPostgreSqlClusterServerResourceId);

            // invoke the operation and iterate over the result
            await foreach (CosmosDBForPostgreSqlServerConfigurationData item in cosmosDBForPostgreSqlClusterServer.GetConfigurationsAsync())
            {
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {item.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
