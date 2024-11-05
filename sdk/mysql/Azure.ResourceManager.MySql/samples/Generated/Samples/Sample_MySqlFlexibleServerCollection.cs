// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.MySql.FlexibleServers.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.MySql.FlexibleServers.Samples
{
    public partial class Sample_MySqlFlexibleServerCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateANewServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2023-12-30/examples/ServerCreate.json
            // this example is just showing the usage of "Servers_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MySqlFlexibleServerResource
            MySqlFlexibleServerCollection collection = resourceGroupResource.GetMySqlFlexibleServers();

            // invoke the operation
            string serverName = "mysqltestserver";
            MySqlFlexibleServerData data = new MySqlFlexibleServerData(new AzureLocation("southeastasia"))
            {
                Sku = new MySqlFlexibleServerSku("Standard_D2ds_v4", MySqlFlexibleServerSkuTier.GeneralPurpose),
                AdministratorLogin = "cloudsa",
                AdministratorLoginPassword = "your_password",
                Version = MySqlFlexibleServerVersion.Ver5_7,
                AvailabilityZone = "1",
                CreateMode = MySqlFlexibleServerCreateMode.Default,
                Storage = new MySqlFlexibleServerStorage
                {
                    StorageSizeInGB = 100,
                    Iops = 600,
                    AutoGrow = MySqlFlexibleServerEnableStatusEnum.Disabled,
                },
                Backup = new MySqlFlexibleServerBackupProperties
                {
                    BackupRetentionDays = 7,
                    BackupIntervalHours = 24,
                    GeoRedundantBackup = MySqlFlexibleServerEnableStatusEnum.Disabled,
                },
                HighAvailability = new MySqlFlexibleServerHighAvailability
                {
                    Mode = MySqlFlexibleServerHighAvailabilityMode.ZoneRedundant,
                    StandbyAvailabilityZone = "3",
                },
                Tags =
{
["num"] = "1"
},
            };
            ArmOperation<MySqlFlexibleServerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, serverName, data);
            MySqlFlexibleServerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAReplicaServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2023-12-30/examples/ServerCreateReplica.json
            // this example is just showing the usage of "Servers_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testgr";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MySqlFlexibleServerResource
            MySqlFlexibleServerCollection collection = resourceGroupResource.GetMySqlFlexibleServers();

            // invoke the operation
            string serverName = "replica-server";
            MySqlFlexibleServerData data = new MySqlFlexibleServerData(new AzureLocation("SoutheastAsia"))
            {
                CreateMode = MySqlFlexibleServerCreateMode.Replica,
                SourceServerResourceId = new ResourceIdentifier("/subscriptions/ffffffff-ffff-ffff-ffff-ffffffffffff/resourceGroups/testgr/providers/Microsoft.DBforMySQL/flexibleServers/source-server"),
            };
            ArmOperation<MySqlFlexibleServerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, serverName, data);
            MySqlFlexibleServerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAServerAsAPointInTimeRestore()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2023-12-30/examples/ServerCreateWithPointInTimeRestore.json
            // this example is just showing the usage of "Servers_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TargetResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MySqlFlexibleServerResource
            MySqlFlexibleServerCollection collection = resourceGroupResource.GetMySqlFlexibleServers();

            // invoke the operation
            string serverName = "targetserver";
            MySqlFlexibleServerData data = new MySqlFlexibleServerData(new AzureLocation("SoutheastAsia"))
            {
                Sku = new MySqlFlexibleServerSku("Standard_D14_v2", MySqlFlexibleServerSkuTier.GeneralPurpose),
                CreateMode = MySqlFlexibleServerCreateMode.PointInTimeRestore,
                SourceServerResourceId = new ResourceIdentifier("/subscriptions/ffffffff-ffff-ffff-ffff-ffffffffffff/resourceGroups/SourceResourceGroup/providers/Microsoft.DBforMySQL/flexibleServers/sourceserver"),
                RestorePointInTime = default,
                Tags =
{
["num"] = "1"
},
            };
            ArmOperation<MySqlFlexibleServerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, serverName, data);
            MySqlFlexibleServerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAServerWithByok()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2023-12-30/examples/ServerCreateWithBYOK.json
            // this example is just showing the usage of "Servers_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MySqlFlexibleServerResource
            MySqlFlexibleServerCollection collection = resourceGroupResource.GetMySqlFlexibleServers();

            // invoke the operation
            string serverName = "mysqltestserver";
            MySqlFlexibleServerData data = new MySqlFlexibleServerData(new AzureLocation("southeastasia"))
            {
                Identity = new ManagedServiceIdentity(default)
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/ffffffff-ffff-ffff-ffff-ffffffffffff/resourceGroups/testrg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/test-identity")] = null
},
                },
                Sku = new MySqlFlexibleServerSku("Standard_D2ds_v4", MySqlFlexibleServerSkuTier.GeneralPurpose),
                AdministratorLogin = "cloudsa",
                AdministratorLoginPassword = "your_password",
                Version = MySqlFlexibleServerVersion.Ver5_7,
                AvailabilityZone = "1",
                CreateMode = MySqlFlexibleServerCreateMode.Default,
                DataEncryption = new MySqlFlexibleServerDataEncryption
                {
                    PrimaryUserAssignedIdentityId = new ResourceIdentifier("/subscriptions/ffffffff-ffff-ffff-ffff-ffffffffffff/resourceGroups/testrg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/test-identity"),
                    PrimaryKeyUri = new Uri("https://test.vault.azure.net/keys/key/c8a92236622244c0a4fdb892666f671a"),
                    GeoBackupUserAssignedIdentityId = new ResourceIdentifier("/subscriptions/ffffffff-ffff-ffff-ffff-ffffffffffff/resourceGroups/testrg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/test-geo-identity"),
                    GeoBackupKeyUri = new Uri("https://test-geo.vault.azure.net/keys/key/c8a92236622244c0a4fdb892666f671a"),
                    EncryptionType = MySqlFlexibleServerDataEncryptionType.AzureKeyVault,
                },
                Storage = new MySqlFlexibleServerStorage
                {
                    StorageSizeInGB = 100,
                    Iops = 600,
                    AutoGrow = MySqlFlexibleServerEnableStatusEnum.Disabled,
                },
                Backup = new MySqlFlexibleServerBackupProperties
                {
                    BackupRetentionDays = 7,
                    BackupIntervalHours = 24,
                    GeoRedundantBackup = MySqlFlexibleServerEnableStatusEnum.Disabled,
                },
                HighAvailability = new MySqlFlexibleServerHighAvailability
                {
                    Mode = MySqlFlexibleServerHighAvailabilityMode.ZoneRedundant,
                    StandbyAvailabilityZone = "3",
                },
                Tags =
{
["num"] = "1"
},
            };
            ArmOperation<MySqlFlexibleServerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, serverName, data);
            MySqlFlexibleServerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2023-12-30/examples/ServerGet.json
            // this example is just showing the usage of "Servers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MySqlFlexibleServerResource
            MySqlFlexibleServerCollection collection = resourceGroupResource.GetMySqlFlexibleServers();

            // invoke the operation
            string serverName = "mysqltestserver";
            MySqlFlexibleServerResource result = await collection.GetAsync(serverName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAServerWithVnet()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2023-12-30/examples/ServerGetWithVnet.json
            // this example is just showing the usage of "Servers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MySqlFlexibleServerResource
            MySqlFlexibleServerCollection collection = resourceGroupResource.GetMySqlFlexibleServers();

            // invoke the operation
            string serverName = "mysqltestserver";
            MySqlFlexibleServerResource result = await collection.GetAsync(serverName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListServersInAResourceGroup()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2023-12-30/examples/ServersListByResourceGroup.json
            // this example is just showing the usage of "Servers_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MySqlFlexibleServerResource
            MySqlFlexibleServerCollection collection = resourceGroupResource.GetMySqlFlexibleServers();

            // invoke the operation and iterate over the result
            await foreach (MySqlFlexibleServerResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlFlexibleServerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetReplicas_ListReplicasForAServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2023-12-30/examples/ReplicasListByServer.json
            // this example is just showing the usage of "Replicas_ListByServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MySqlFlexibleServerResource
            MySqlFlexibleServerCollection collection = resourceGroupResource.GetMySqlFlexibleServers();

            // invoke the operation and iterate over the result
            string serverName = "mysqltestserver";
            await foreach (MySqlFlexibleServerResource item in collection.GetReplicasAsync(serverName))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlFlexibleServerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2023-12-30/examples/ServerGet.json
            // this example is just showing the usage of "Servers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MySqlFlexibleServerResource
            MySqlFlexibleServerCollection collection = resourceGroupResource.GetMySqlFlexibleServers();

            // invoke the operation
            string serverName = "mysqltestserver";
            bool result = await collection.ExistsAsync(serverName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAServerWithVnet()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2023-12-30/examples/ServerGetWithVnet.json
            // this example is just showing the usage of "Servers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MySqlFlexibleServerResource
            MySqlFlexibleServerCollection collection = resourceGroupResource.GetMySqlFlexibleServers();

            // invoke the operation
            string serverName = "mysqltestserver";
            bool result = await collection.ExistsAsync(serverName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2023-12-30/examples/ServerGet.json
            // this example is just showing the usage of "Servers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MySqlFlexibleServerResource
            MySqlFlexibleServerCollection collection = resourceGroupResource.GetMySqlFlexibleServers();

            // invoke the operation
            string serverName = "mysqltestserver";
            NullableResponse<MySqlFlexibleServerResource> response = await collection.GetIfExistsAsync(serverName);
            MySqlFlexibleServerResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlFlexibleServerData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAServerWithVnet()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2023-12-30/examples/ServerGetWithVnet.json
            // this example is just showing the usage of "Servers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MySqlFlexibleServerResource
            MySqlFlexibleServerCollection collection = resourceGroupResource.GetMySqlFlexibleServers();

            // invoke the operation
            string serverName = "mysqltestserver";
            NullableResponse<MySqlFlexibleServerResource> response = await collection.GetIfExistsAsync(serverName);
            MySqlFlexibleServerResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlFlexibleServerData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
