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
    public partial class Sample_AdvancedThreatProtectionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAServerSAdvancedThreatProtectionSettings()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2023-12-30/examples/AdvancedThreatProtectionSettingsGet.json
            // this example is just showing the usage of "AdvancedThreatProtectionSettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "threatprotection-6852";
            string serverName = "threatprotection-2080";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // get the collection of this AdvancedThreatProtectionResource
            AdvancedThreatProtectionCollection collection = mySqlFlexibleServer.GetAdvancedThreatProtections();

            // invoke the operation
            AdvancedThreatProtectionName advancedThreatProtectionName = AdvancedThreatProtectionName.Default;
            AdvancedThreatProtectionResource result = await collection.GetAsync(advancedThreatProtectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AdvancedThreatProtectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAServerSAdvancedThreatProtectionSettings()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2023-12-30/examples/AdvancedThreatProtectionSettingsGet.json
            // this example is just showing the usage of "AdvancedThreatProtectionSettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "threatprotection-6852";
            string serverName = "threatprotection-2080";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // get the collection of this AdvancedThreatProtectionResource
            AdvancedThreatProtectionCollection collection = mySqlFlexibleServer.GetAdvancedThreatProtections();

            // invoke the operation
            AdvancedThreatProtectionName advancedThreatProtectionName = AdvancedThreatProtectionName.Default;
            bool result = await collection.ExistsAsync(advancedThreatProtectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAServerSAdvancedThreatProtectionSettings()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2023-12-30/examples/AdvancedThreatProtectionSettingsGet.json
            // this example is just showing the usage of "AdvancedThreatProtectionSettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "threatprotection-6852";
            string serverName = "threatprotection-2080";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // get the collection of this AdvancedThreatProtectionResource
            AdvancedThreatProtectionCollection collection = mySqlFlexibleServer.GetAdvancedThreatProtections();

            // invoke the operation
            AdvancedThreatProtectionName advancedThreatProtectionName = AdvancedThreatProtectionName.Default;
            NullableResponse<AdvancedThreatProtectionResource> response = await collection.GetIfExistsAsync(advancedThreatProtectionName);
            AdvancedThreatProtectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AdvancedThreatProtectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_DisableAServerSAdvancedThreatProtectionSettingsWithAllParametersUsingPUT()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2023-12-30/examples/AdvancedThreatProtectionSettingsPutDisabled.json
            // this example is just showing the usage of "AdvancedThreatProtectionSettings_UpdatePut" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "threatprotection-4799";
            string serverName = "threatprotection-6440";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // get the collection of this AdvancedThreatProtectionResource
            AdvancedThreatProtectionCollection collection = mySqlFlexibleServer.GetAdvancedThreatProtections();

            // invoke the operation
            AdvancedThreatProtectionName advancedThreatProtectionName = AdvancedThreatProtectionName.Default;
            AdvancedThreatProtectionData data = new AdvancedThreatProtectionData()
            {
                State = AdvancedThreatProtectionState.Disabled,
            };
            ArmOperation<AdvancedThreatProtectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, advancedThreatProtectionName, data);
            AdvancedThreatProtectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AdvancedThreatProtectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_EnableAServerSAdvancedThreatProtectionSettingsUsingPUT()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2023-12-30/examples/AdvancedThreatProtectionSettingsPutEnabled.json
            // this example is just showing the usage of "AdvancedThreatProtectionSettings_UpdatePut" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "threatprotection-4799";
            string serverName = "threatprotection-6440";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // get the collection of this AdvancedThreatProtectionResource
            AdvancedThreatProtectionCollection collection = mySqlFlexibleServer.GetAdvancedThreatProtections();

            // invoke the operation
            AdvancedThreatProtectionName advancedThreatProtectionName = AdvancedThreatProtectionName.Default;
            AdvancedThreatProtectionData data = new AdvancedThreatProtectionData()
            {
                State = AdvancedThreatProtectionState.Enabled,
            };
            ArmOperation<AdvancedThreatProtectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, advancedThreatProtectionName, data);
            AdvancedThreatProtectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AdvancedThreatProtectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetListOfServerSAdvancedThreatProtectionSettings()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2023-12-30/examples/AdvancedThreatProtectionSettingsList.json
            // this example is just showing the usage of "AdvancedThreatProtectionSettings_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "threatprotection-6852";
            string serverName = "threatprotection-2080";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // get the collection of this AdvancedThreatProtectionResource
            AdvancedThreatProtectionCollection collection = mySqlFlexibleServer.GetAdvancedThreatProtections();

            // invoke the operation and iterate over the result
            await foreach (AdvancedThreatProtectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AdvancedThreatProtectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
