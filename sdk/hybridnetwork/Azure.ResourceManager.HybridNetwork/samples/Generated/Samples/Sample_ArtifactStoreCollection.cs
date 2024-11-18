// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HybridNetwork.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.HybridNetwork.Samples
{
    public partial class Sample_ArtifactStoreCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetApplicationGroupsUnderAPublisherResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ArtifactStoresListByPublisherName.json
            // this example is just showing the usage of "ArtifactStores_ListByPublisher" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublisherResource created on azure
            // for more information of creating PublisherResource, please refer to the document of PublisherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            ResourceIdentifier publisherResourceId = PublisherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName);
            PublisherResource publisher = client.GetPublisherResource(publisherResourceId);

            // get the collection of this ArtifactStoreResource
            ArtifactStoreCollection collection = publisher.GetArtifactStores();

            // invoke the operation and iterate over the result
            await foreach (ArtifactStoreResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ArtifactStoreData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateAnArtifactStoreOfPublisherResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ArtifactStoreCreate.json
            // this example is just showing the usage of "ArtifactStores_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublisherResource created on azure
            // for more information of creating PublisherResource, please refer to the document of PublisherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            ResourceIdentifier publisherResourceId = PublisherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName);
            PublisherResource publisher = client.GetPublisherResource(publisherResourceId);

            // get the collection of this ArtifactStoreResource
            ArtifactStoreCollection collection = publisher.GetArtifactStores();

            // invoke the operation
            string artifactStoreName = "TestArtifactStore";
            ArtifactStoreData data = new ArtifactStoreData(new AzureLocation("eastus"))
            {
                Properties = new ArtifactStorePropertiesFormat()
                {
                    StoreType = ArtifactStoreType.AzureContainerRegistry,
                    ReplicationStrategy = ArtifactReplicationStrategy.SingleReplication,
                    ManagedResourceGroupConfiguration = new ArtifactStorePropertiesFormatManagedResourceGroupConfiguration()
                    {
                        Name = "testRg",
                        Location = new AzureLocation("eastus"),
                    },
                },
            };
            ArmOperation<ArtifactStoreResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, artifactStoreName, data);
            ArtifactStoreResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArtifactStoreData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAArtifactStoreResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ArtifactStoreGet.json
            // this example is just showing the usage of "ArtifactStores_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublisherResource created on azure
            // for more information of creating PublisherResource, please refer to the document of PublisherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            ResourceIdentifier publisherResourceId = PublisherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName);
            PublisherResource publisher = client.GetPublisherResource(publisherResourceId);

            // get the collection of this ArtifactStoreResource
            ArtifactStoreCollection collection = publisher.GetArtifactStores();

            // invoke the operation
            string artifactStoreName = "TestArtifactStoreName";
            ArtifactStoreResource result = await collection.GetAsync(artifactStoreName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArtifactStoreData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAArtifactStoreResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ArtifactStoreGet.json
            // this example is just showing the usage of "ArtifactStores_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublisherResource created on azure
            // for more information of creating PublisherResource, please refer to the document of PublisherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            ResourceIdentifier publisherResourceId = PublisherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName);
            PublisherResource publisher = client.GetPublisherResource(publisherResourceId);

            // get the collection of this ArtifactStoreResource
            ArtifactStoreCollection collection = publisher.GetArtifactStores();

            // invoke the operation
            string artifactStoreName = "TestArtifactStoreName";
            bool result = await collection.ExistsAsync(artifactStoreName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAArtifactStoreResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ArtifactStoreGet.json
            // this example is just showing the usage of "ArtifactStores_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublisherResource created on azure
            // for more information of creating PublisherResource, please refer to the document of PublisherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            ResourceIdentifier publisherResourceId = PublisherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName);
            PublisherResource publisher = client.GetPublisherResource(publisherResourceId);

            // get the collection of this ArtifactStoreResource
            ArtifactStoreCollection collection = publisher.GetArtifactStores();

            // invoke the operation
            string artifactStoreName = "TestArtifactStoreName";
            NullableResponse<ArtifactStoreResource> response = await collection.GetIfExistsAsync(artifactStoreName);
            ArtifactStoreResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ArtifactStoreData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
