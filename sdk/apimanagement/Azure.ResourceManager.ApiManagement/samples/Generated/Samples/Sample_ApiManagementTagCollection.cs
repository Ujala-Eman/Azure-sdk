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
using Azure.ResourceManager.ApiManagement;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiManagementTagCollection
    {
        // ApiManagementListTags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ApiManagementListTags()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementListTags.json
            // this example is just showing the usage of "Tag_ListByService" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementServiceResource created on azure
            // for more information of creating ApiManagementServiceResource, please refer to the document of ApiManagementServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementServiceResourceId = ApiManagementServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementServiceResource apiManagementService = client.GetApiManagementServiceResource(apiManagementServiceResourceId);

            // get the collection of this ApiManagementTagResource
            ApiManagementTagCollection collection = apiManagementService.GetApiManagementTags();

            // invoke the operation and iterate over the result
            await foreach (ApiManagementTagResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TagContractData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ApiManagementGetTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementGetTag.json
            // this example is just showing the usage of "Tag_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementServiceResource created on azure
            // for more information of creating ApiManagementServiceResource, please refer to the document of ApiManagementServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementServiceResourceId = ApiManagementServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementServiceResource apiManagementService = client.GetApiManagementServiceResource(apiManagementServiceResourceId);

            // get the collection of this ApiManagementTagResource
            ApiManagementTagCollection collection = apiManagementService.GetApiManagementTags();

            // invoke the operation
            string tagId = "59306a29e4bbd510dc24e5f9";
            ApiManagementTagResource result = await collection.GetAsync(tagId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementGetTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ApiManagementGetTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementGetTag.json
            // this example is just showing the usage of "Tag_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementServiceResource created on azure
            // for more information of creating ApiManagementServiceResource, please refer to the document of ApiManagementServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementServiceResourceId = ApiManagementServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementServiceResource apiManagementService = client.GetApiManagementServiceResource(apiManagementServiceResourceId);

            // get the collection of this ApiManagementTagResource
            ApiManagementTagCollection collection = apiManagementService.GetApiManagementTags();

            // invoke the operation
            string tagId = "59306a29e4bbd510dc24e5f9";
            bool result = await collection.ExistsAsync(tagId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ApiManagementGetTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementGetTag.json
            // this example is just showing the usage of "Tag_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementServiceResource created on azure
            // for more information of creating ApiManagementServiceResource, please refer to the document of ApiManagementServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementServiceResourceId = ApiManagementServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementServiceResource apiManagementService = client.GetApiManagementServiceResource(apiManagementServiceResourceId);

            // get the collection of this ApiManagementTagResource
            ApiManagementTagCollection collection = apiManagementService.GetApiManagementTags();

            // invoke the operation
            string tagId = "59306a29e4bbd510dc24e5f9";
            NullableResponse<ApiManagementTagResource> response = await collection.GetIfExistsAsync(tagId);
            ApiManagementTagResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TagContractData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ApiManagementCreateTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ApiManagementCreateTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementCreateTag.json
            // this example is just showing the usage of "Tag_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementServiceResource created on azure
            // for more information of creating ApiManagementServiceResource, please refer to the document of ApiManagementServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementServiceResourceId = ApiManagementServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementServiceResource apiManagementService = client.GetApiManagementServiceResource(apiManagementServiceResourceId);

            // get the collection of this ApiManagementTagResource
            ApiManagementTagCollection collection = apiManagementService.GetApiManagementTags();

            // invoke the operation
            string tagId = "tagId1";
            ApiManagementTagCreateOrUpdateContent content = new ApiManagementTagCreateOrUpdateContent()
            {
                DisplayName = "tag1",
            };
            ArmOperation<ApiManagementTagResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, tagId, content);
            ApiManagementTagResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
