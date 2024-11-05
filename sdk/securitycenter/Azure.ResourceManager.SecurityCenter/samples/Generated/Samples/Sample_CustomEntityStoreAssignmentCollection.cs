// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SecurityCenter.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SecurityCenter.Samples
{
    public partial class Sample_CustomEntityStoreAssignmentCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateACustomEntityStoreAssignment()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2021-07-01-preview/examples/CustomEntityStoreAssignments/customEntityStoreAssignmentCreate_example.json
            // this example is just showing the usage of "CustomEntityStoreAssignments_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "e5d1b86c-3051-44d5-8802-aa65d45a279b";
            string resourceGroupName = "TestResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CustomEntityStoreAssignmentResource
            CustomEntityStoreAssignmentCollection collection = resourceGroupResource.GetCustomEntityStoreAssignments();

            // invoke the operation
            string customEntityStoreAssignmentName = "33e7cc6e-a139-4723-a0e5-76993aee0771";
            CustomEntityStoreAssignmentCreateOrUpdateContent content = new CustomEntityStoreAssignmentCreateOrUpdateContent
            {
                Principal = "aaduser=f3923a3e-ad57-4752-b1a9-fbf3c8e5e082;72f988bf-86f1-41af-91ab-2d7cd011db47",
            };
            ArmOperation<CustomEntityStoreAssignmentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, customEntityStoreAssignmentName, content);
            CustomEntityStoreAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CustomEntityStoreAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetACustomEntityStoreAssignment()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2021-07-01-preview/examples/CustomEntityStoreAssignments/customEntityStoreAssignmentGet_example.json
            // this example is just showing the usage of "CustomEntityStoreAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "e5d1b86c-3051-44d5-8802-aa65d45a279b";
            string resourceGroupName = "TestResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CustomEntityStoreAssignmentResource
            CustomEntityStoreAssignmentCollection collection = resourceGroupResource.GetCustomEntityStoreAssignments();

            // invoke the operation
            string customEntityStoreAssignmentName = "33e7cc6e-a139-4723-a0e5-76993aee0771";
            CustomEntityStoreAssignmentResource result = await collection.GetAsync(customEntityStoreAssignmentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CustomEntityStoreAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListCustomEntityStoreAssignmentsInASubscriptionAndAResourceGroup()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2021-07-01-preview/examples/CustomEntityStoreAssignments/customEntityStoreAssignmentListByResourceGroup_example.json
            // this example is just showing the usage of "CustomEntityStoreAssignments_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "e5d1b86c-3051-44d5-8802-aa65d45a279b";
            string resourceGroupName = "TestResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CustomEntityStoreAssignmentResource
            CustomEntityStoreAssignmentCollection collection = resourceGroupResource.GetCustomEntityStoreAssignments();

            // invoke the operation and iterate over the result
            await foreach (CustomEntityStoreAssignmentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CustomEntityStoreAssignmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetACustomEntityStoreAssignment()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2021-07-01-preview/examples/CustomEntityStoreAssignments/customEntityStoreAssignmentGet_example.json
            // this example is just showing the usage of "CustomEntityStoreAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "e5d1b86c-3051-44d5-8802-aa65d45a279b";
            string resourceGroupName = "TestResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CustomEntityStoreAssignmentResource
            CustomEntityStoreAssignmentCollection collection = resourceGroupResource.GetCustomEntityStoreAssignments();

            // invoke the operation
            string customEntityStoreAssignmentName = "33e7cc6e-a139-4723-a0e5-76993aee0771";
            bool result = await collection.ExistsAsync(customEntityStoreAssignmentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetACustomEntityStoreAssignment()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2021-07-01-preview/examples/CustomEntityStoreAssignments/customEntityStoreAssignmentGet_example.json
            // this example is just showing the usage of "CustomEntityStoreAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "e5d1b86c-3051-44d5-8802-aa65d45a279b";
            string resourceGroupName = "TestResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CustomEntityStoreAssignmentResource
            CustomEntityStoreAssignmentCollection collection = resourceGroupResource.GetCustomEntityStoreAssignments();

            // invoke the operation
            string customEntityStoreAssignmentName = "33e7cc6e-a139-4723-a0e5-76993aee0771";
            NullableResponse<CustomEntityStoreAssignmentResource> response = await collection.GetIfExistsAsync(customEntityStoreAssignmentName);
            CustomEntityStoreAssignmentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CustomEntityStoreAssignmentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
