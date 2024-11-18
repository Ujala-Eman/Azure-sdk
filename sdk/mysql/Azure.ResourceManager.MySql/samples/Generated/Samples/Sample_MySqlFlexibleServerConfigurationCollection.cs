// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MySql.FlexibleServers.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.MySql.FlexibleServers.Samples
{
    public partial class Sample_MySqlFlexibleServerConfigurationCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ConfigurationCreateOrUpdate()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/Configurations/stable/2023-12-30/examples/ConfigurationCreateOrUpdate.json
            // this example is just showing the usage of "Configurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // get the collection of this MySqlFlexibleServerConfigurationResource
            MySqlFlexibleServerConfigurationCollection collection = mySqlFlexibleServer.GetMySqlFlexibleServerConfigurations();

            // invoke the operation
            string configurationName = "event_scheduler";
            MySqlFlexibleServerConfigurationData data = new MySqlFlexibleServerConfigurationData()
            {
                Value = "off",
                Source = MySqlFlexibleServerConfigurationSource.UserOverride,
            };
            ArmOperation<MySqlFlexibleServerConfigurationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, configurationName, data);
            MySqlFlexibleServerConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServerConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAConfiguration()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/Configurations/stable/2023-12-30/examples/ConfigurationGet.json
            // this example is just showing the usage of "Configurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // get the collection of this MySqlFlexibleServerConfigurationResource
            MySqlFlexibleServerConfigurationCollection collection = mySqlFlexibleServer.GetMySqlFlexibleServerConfigurations();

            // invoke the operation
            string configurationName = "event_scheduler";
            MySqlFlexibleServerConfigurationResource result = await collection.GetAsync(configurationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServerConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAConfiguration()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/Configurations/stable/2023-12-30/examples/ConfigurationGet.json
            // this example is just showing the usage of "Configurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // get the collection of this MySqlFlexibleServerConfigurationResource
            MySqlFlexibleServerConfigurationCollection collection = mySqlFlexibleServer.GetMySqlFlexibleServerConfigurations();

            // invoke the operation
            string configurationName = "event_scheduler";
            bool result = await collection.ExistsAsync(configurationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAConfiguration()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/Configurations/stable/2023-12-30/examples/ConfigurationGet.json
            // this example is just showing the usage of "Configurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // get the collection of this MySqlFlexibleServerConfigurationResource
            MySqlFlexibleServerConfigurationCollection collection = mySqlFlexibleServer.GetMySqlFlexibleServerConfigurations();

            // invoke the operation
            string configurationName = "event_scheduler";
            NullableResponse<MySqlFlexibleServerConfigurationResource> response = await collection.GetIfExistsAsync(configurationName);
            MySqlFlexibleServerConfigurationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlFlexibleServerConfigurationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAllConfigurationsForAServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/Configurations/stable/2023-12-30/examples/ConfigurationsListByServer.json
            // this example is just showing the usage of "Configurations_ListByServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "mysqltestserver";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // get the collection of this MySqlFlexibleServerConfigurationResource
            MySqlFlexibleServerConfigurationCollection collection = mySqlFlexibleServer.GetMySqlFlexibleServerConfigurations();

            // invoke the operation and iterate over the result
            int? page = 1;
            int? pageSize = 8;
            await foreach (MySqlFlexibleServerConfigurationResource item in collection.GetAllAsync(page: page, pageSize: pageSize))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlFlexibleServerConfigurationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
