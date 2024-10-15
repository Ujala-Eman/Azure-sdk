// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ServiceWorkspaceProductResource
    {
        // ApiManagementHeadWorkspaceProduct
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetEntityTag_ApiManagementHeadWorkspaceProduct()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementHeadWorkspaceProduct.json
            // this example is just showing the usage of "WorkspaceProduct_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceProductResource created on azure
            // for more information of creating ServiceWorkspaceProductResource, please refer to the document of ServiceWorkspaceProductResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string productId = "unlimited";
            ResourceIdentifier serviceWorkspaceProductResourceId = ServiceWorkspaceProductResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, productId);
            ServiceWorkspaceProductResource serviceWorkspaceProduct = client.GetServiceWorkspaceProductResource(serviceWorkspaceProductResourceId);

            // invoke the operation
            bool result = await serviceWorkspaceProduct.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetWorkspaceProduct
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetWorkspaceProduct()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetWorkspaceProduct.json
            // this example is just showing the usage of "WorkspaceProduct_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceProductResource created on azure
            // for more information of creating ServiceWorkspaceProductResource, please refer to the document of ServiceWorkspaceProductResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string productId = "unlimited";
            ResourceIdentifier serviceWorkspaceProductResourceId = ServiceWorkspaceProductResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, productId);
            ServiceWorkspaceProductResource serviceWorkspaceProduct = client.GetServiceWorkspaceProductResource(serviceWorkspaceProductResourceId);

            // invoke the operation
            ServiceWorkspaceProductResource result = await serviceWorkspaceProduct.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementProductData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementUpdateWorkspaceProduct
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementUpdateWorkspaceProduct()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementUpdateWorkspaceProduct.json
            // this example is just showing the usage of "WorkspaceProduct_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceProductResource created on azure
            // for more information of creating ServiceWorkspaceProductResource, please refer to the document of ServiceWorkspaceProductResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string productId = "testproduct";
            ResourceIdentifier serviceWorkspaceProductResourceId = ServiceWorkspaceProductResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, productId);
            ServiceWorkspaceProductResource serviceWorkspaceProduct = client.GetServiceWorkspaceProductResource(serviceWorkspaceProductResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            ApiManagementProductPatch patch = new ApiManagementProductPatch()
            {
                DisplayName = "Test Template ProductName 4",
            };
            ServiceWorkspaceProductResource result = await serviceWorkspaceProduct.UpdateAsync(ifMatch, patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementProductData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementDeleteWorkspaceProduct
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ApiManagementDeleteWorkspaceProduct()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementDeleteWorkspaceProduct.json
            // this example is just showing the usage of "WorkspaceProduct_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceProductResource created on azure
            // for more information of creating ServiceWorkspaceProductResource, please refer to the document of ServiceWorkspaceProductResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string productId = "testproduct";
            ResourceIdentifier serviceWorkspaceProductResourceId = ServiceWorkspaceProductResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, productId);
            ServiceWorkspaceProductResource serviceWorkspaceProduct = client.GetServiceWorkspaceProductResource(serviceWorkspaceProductResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            bool? deleteSubscriptions = true;
            await serviceWorkspaceProduct.DeleteAsync(WaitUntil.Completed, ifMatch, deleteSubscriptions: deleteSubscriptions);

            Console.WriteLine($"Succeeded");
        }
    }
}
