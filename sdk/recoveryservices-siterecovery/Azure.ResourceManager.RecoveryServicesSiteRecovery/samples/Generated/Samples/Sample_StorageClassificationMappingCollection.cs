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
using Azure.ResourceManager.RecoveryServicesSiteRecovery;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Samples
{
    public partial class Sample_StorageClassificationMappingCollection
    {
        // Gets the list of storage classification mappings objects under a storage.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetsTheListOfStorageClassificationMappingsObjectsUnderAStorage()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationStorageClassificationMappings_ListByReplicationStorageClassifications.json
            // this example is just showing the usage of "ReplicationStorageClassificationMappings_ListByReplicationStorageClassifications" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageClassificationResource created on azure
            // for more information of creating StorageClassificationResource, please refer to the document of StorageClassificationResource
            string subscriptionId = "9112a37f-0f3e-46ec-9c00-060c6edca071";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "2a48e3770ac08aa2be8bfbd94fcfb1cbf2dcc487b78fb9d3bd778304441b06a0";
            string storageClassificationName = "8891569e-aaef-4a46-a4a0-78c14f2d7b09";
            ResourceIdentifier storageClassificationResourceId = StorageClassificationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, storageClassificationName);
            StorageClassificationResource storageClassification = client.GetStorageClassificationResource(storageClassificationResourceId);

            // get the collection of this StorageClassificationMappingResource
            StorageClassificationMappingCollection collection = storageClassification.GetStorageClassificationMappings();

            // invoke the operation and iterate over the result
            await foreach (StorageClassificationMappingResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StorageClassificationMappingData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Gets the details of a storage classification mapping.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsTheDetailsOfAStorageClassificationMapping()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationStorageClassificationMappings_Get.json
            // this example is just showing the usage of "ReplicationStorageClassificationMappings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageClassificationResource created on azure
            // for more information of creating StorageClassificationResource, please refer to the document of StorageClassificationResource
            string subscriptionId = "9112a37f-0f3e-46ec-9c00-060c6edca071";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "2a48e3770ac08aa2be8bfbd94fcfb1cbf2dcc487b78fb9d3bd778304441b06a0";
            string storageClassificationName = "8891569e-aaef-4a46-a4a0-78c14f2d7b09";
            ResourceIdentifier storageClassificationResourceId = StorageClassificationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, storageClassificationName);
            StorageClassificationResource storageClassification = client.GetStorageClassificationResource(storageClassificationResourceId);

            // get the collection of this StorageClassificationMappingResource
            StorageClassificationMappingCollection collection = storageClassification.GetStorageClassificationMappings();

            // invoke the operation
            string storageClassificationMappingName = "testStorageMapping";
            StorageClassificationMappingResource result = await collection.GetAsync(storageClassificationMappingName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageClassificationMappingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets the details of a storage classification mapping.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsTheDetailsOfAStorageClassificationMapping()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationStorageClassificationMappings_Get.json
            // this example is just showing the usage of "ReplicationStorageClassificationMappings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageClassificationResource created on azure
            // for more information of creating StorageClassificationResource, please refer to the document of StorageClassificationResource
            string subscriptionId = "9112a37f-0f3e-46ec-9c00-060c6edca071";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "2a48e3770ac08aa2be8bfbd94fcfb1cbf2dcc487b78fb9d3bd778304441b06a0";
            string storageClassificationName = "8891569e-aaef-4a46-a4a0-78c14f2d7b09";
            ResourceIdentifier storageClassificationResourceId = StorageClassificationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, storageClassificationName);
            StorageClassificationResource storageClassification = client.GetStorageClassificationResource(storageClassificationResourceId);

            // get the collection of this StorageClassificationMappingResource
            StorageClassificationMappingCollection collection = storageClassification.GetStorageClassificationMappings();

            // invoke the operation
            string storageClassificationMappingName = "testStorageMapping";
            bool result = await collection.ExistsAsync(storageClassificationMappingName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Create storage classification mapping.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateStorageClassificationMapping()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationStorageClassificationMappings_Create.json
            // this example is just showing the usage of "ReplicationStorageClassificationMappings_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageClassificationResource created on azure
            // for more information of creating StorageClassificationResource, please refer to the document of StorageClassificationResource
            string subscriptionId = "9112a37f-0f3e-46ec-9c00-060c6edca071";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "2a48e3770ac08aa2be8bfbd94fcfb1cbf2dcc487b78fb9d3bd778304441b06a0";
            string storageClassificationName = "8891569e-aaef-4a46-a4a0-78c14f2d7b09";
            ResourceIdentifier storageClassificationResourceId = StorageClassificationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, storageClassificationName);
            StorageClassificationResource storageClassification = client.GetStorageClassificationResource(storageClassificationResourceId);

            // get the collection of this StorageClassificationMappingResource
            StorageClassificationMappingCollection collection = storageClassification.GetStorageClassificationMappings();

            // invoke the operation
            string storageClassificationMappingName = "testStorageMapping";
            StorageClassificationMappingCreateOrUpdateContent content = new StorageClassificationMappingCreateOrUpdateContent()
            {
                TargetStorageClassificationId = new ResourceIdentifier("/Subscriptions/9112a37f-0f3e-46ec-9c00-060c6edca071/resourceGroups/resourceGroupPS1/providers/Microsoft.RecoveryServices/vaults/vault1/replicationFabrics/2a48e3770ac08aa2be8bfbd94fcfb1cbf2dcc487b78fb9d3bd778304441b06a0/replicationStorageClassifications/8891569e-aaef-4a46-a4a0-78c14f2d7b09"),
            };
            ArmOperation<StorageClassificationMappingResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, storageClassificationMappingName, content);
            StorageClassificationMappingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageClassificationMappingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
