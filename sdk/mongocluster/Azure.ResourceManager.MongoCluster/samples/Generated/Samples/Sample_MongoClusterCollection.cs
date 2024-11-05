// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MongoCluster.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.MongoCluster.Samples
{
    public partial class Sample_MongoClusterCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatesANewMongoClusterResource()
        {
            // Generated from example definition: 2024-07-01/MongoClusters_Create.json
            // this example is just showing the usage of "MongoCluster_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MongoClusterResource
            MongoClusterCollection collection = resourceGroupResource.GetMongoClusters();

            // invoke the operation
            string mongoClusterName = "myMongoCluster";
            MongoClusterData data = new MongoClusterData(new AzureLocation("westus2"))
            {
                Properties = new MongoClusterProperties
                {
                    Administrator = new MongoClusterAdministratorProperties
                    {
                        UserName = "mongoAdmin",
                        Password = "password",
                    },
                    ServerVersion = "5.0",
                    HighAvailabilityTargetMode = HighAvailabilityMode.SameZone,
                    StorageSizeGb = 128L,
                    ShardingShardCount = 1,
                    ComputeTier = "M30",
                },
            };
            ArmOperation<MongoClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, mongoClusterName, data);
            MongoClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MongoClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatesAReplicaMongoClusterResourceFromASourceResource()
        {
            // Generated from example definition: 2024-07-01/MongoClusters_CreateGeoReplica.json
            // this example is just showing the usage of "MongoCluster_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MongoClusterResource
            MongoClusterCollection collection = resourceGroupResource.GetMongoClusters();

            // invoke the operation
            string mongoClusterName = "myReplicaMongoCluster";
            MongoClusterData data = new MongoClusterData(new AzureLocation("centralus"))
            {
                Properties = new MongoClusterProperties
                {
                    CreateMode = MongoClusterCreateMode.GeoReplica,
                    ReplicaParameters = new MongoClusterReplicaContent(new ResourceIdentifier("/subscriptions/ffffffff-ffff-ffff-ffff-ffffffffffff/resourceGroups/TestResourceGroup/providers/Microsoft.DocumentDB/mongoClusters/mySourceMongoCluster"), new AzureLocation("eastus")),
                },
            };
            ArmOperation<MongoClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, mongoClusterName, data);
            MongoClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MongoClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatesAMongoClusterResourceFromAPointInTimeRestore()
        {
            // Generated from example definition: 2024-07-01/MongoClusters_CreatePITR.json
            // this example is just showing the usage of "MongoCluster_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MongoClusterResource
            MongoClusterCollection collection = resourceGroupResource.GetMongoClusters();

            // invoke the operation
            string mongoClusterName = "myMongoCluster";
            MongoClusterData data = new MongoClusterData(new AzureLocation("westus2"))
            {
                Properties = new MongoClusterProperties
                {
                    CreateMode = MongoClusterCreateMode.PointInTimeRestore,
                    RestoreParameters = new MongoClusterRestoreContent
                    {
                        PointInTimeUTC = default,
                        SourceResourceId = new ResourceIdentifier("/subscriptions/ffffffff-ffff-ffff-ffff-ffffffffffff/resourceGroups/TestResourceGroup/providers/Microsoft.DocumentDB/mongoClusters/myOtherMongoCluster"),
                    },
                },
            };
            ArmOperation<MongoClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, mongoClusterName, data);
            MongoClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MongoClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsAMongoClusterResource()
        {
            // Generated from example definition: 2024-07-01/MongoClusters_Get.json
            // this example is just showing the usage of "MongoCluster_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MongoClusterResource
            MongoClusterCollection collection = resourceGroupResource.GetMongoClusters();

            // invoke the operation
            string mongoClusterName = "myMongoCluster";
            MongoClusterResource result = await collection.GetAsync(mongoClusterName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MongoClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListsTheMongoClusterResourcesInAResourceGroup()
        {
            // Generated from example definition: 2024-07-01/MongoClusters_ListByResourceGroup.json
            // this example is just showing the usage of "MongoCluster_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MongoClusterResource
            MongoClusterCollection collection = resourceGroupResource.GetMongoClusters();

            // invoke the operation and iterate over the result
            await foreach (MongoClusterResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MongoClusterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetsAMongoClusterResource()
        {
            // Generated from example definition: 2024-07-01/MongoClusters_Get.json
            // this example is just showing the usage of "MongoCluster_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MongoClusterResource
            MongoClusterCollection collection = resourceGroupResource.GetMongoClusters();

            // invoke the operation
            string mongoClusterName = "myMongoCluster";
            bool result = await collection.ExistsAsync(mongoClusterName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetsAMongoClusterResource()
        {
            // Generated from example definition: 2024-07-01/MongoClusters_Get.json
            // this example is just showing the usage of "MongoCluster_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MongoClusterResource
            MongoClusterCollection collection = resourceGroupResource.GetMongoClusters();

            // invoke the operation
            string mongoClusterName = "myMongoCluster";
            NullableResponse<MongoClusterResource> response = await collection.GetIfExistsAsync(mongoClusterName);
            MongoClusterResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MongoClusterData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
