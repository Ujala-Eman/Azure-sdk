// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ServiceWorkspaceProductPolicyResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetEntityTag_ApiManagementHeadWorkspaceProductPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementHeadWorkspaceProductPolicy.json
            // this example is just showing the usage of "WorkspaceProductPolicy_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceProductPolicyResource created on azure
            // for more information of creating ServiceWorkspaceProductPolicyResource, please refer to the document of ServiceWorkspaceProductPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string productId = "unlimited";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier serviceWorkspaceProductPolicyResourceId = ServiceWorkspaceProductPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, productId, policyId);
            ServiceWorkspaceProductPolicyResource serviceWorkspaceProductPolicy = client.GetServiceWorkspaceProductPolicyResource(serviceWorkspaceProductPolicyResourceId);

            // invoke the operation
            bool result = await serviceWorkspaceProductPolicy.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetWorkspaceProductPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetWorkspaceProductPolicy.json
            // this example is just showing the usage of "WorkspaceProductPolicy_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceProductPolicyResource created on azure
            // for more information of creating ServiceWorkspaceProductPolicyResource, please refer to the document of ServiceWorkspaceProductPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string productId = "kjoshiarmTemplateProduct4";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier serviceWorkspaceProductPolicyResourceId = ServiceWorkspaceProductPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, productId, policyId);
            ServiceWorkspaceProductPolicyResource serviceWorkspaceProductPolicy = client.GetServiceWorkspaceProductPolicyResource(serviceWorkspaceProductPolicyResourceId);

            // invoke the operation
            ServiceWorkspaceProductPolicyResource result = await serviceWorkspaceProductPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementCreateWorkspaceProductPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementCreateWorkspaceProductPolicy.json
            // this example is just showing the usage of "WorkspaceProductPolicy_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceProductPolicyResource created on azure
            // for more information of creating ServiceWorkspaceProductPolicyResource, please refer to the document of ServiceWorkspaceProductPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string productId = "5702e97e5157a50f48dce801";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier serviceWorkspaceProductPolicyResourceId = ServiceWorkspaceProductPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, productId, policyId);
            ServiceWorkspaceProductPolicyResource serviceWorkspaceProductPolicy = client.GetServiceWorkspaceProductPolicyResource(serviceWorkspaceProductPolicyResourceId);

            // invoke the operation
            PolicyContractData data = new PolicyContractData()
            {
                Value = "<policies>\r\n  <inbound>\r\n    <rate-limit calls=\"{{call-count}}\" renewal-period=\"15\"></rate-limit>\r\n    <log-to-eventhub logger-id=\"16\">\r\n                      @( string.Join(\",\", DateTime.UtcNow, context.Deployment.ServiceName, context.RequestId, context.Request.IpAddress, context.Operation.Name) ) \r\n                  </log-to-eventhub>\r\n    <quota-by-key calls=\"40\" counter-key=\"cc\" renewal-period=\"3600\" increment-count=\"@(context.Request.Method == &quot;POST&quot; ? 1:2)\" />\r\n    <base />\r\n  </inbound>\r\n  <backend>\r\n    <base />\r\n  </backend>\r\n  <outbound>\r\n    <base />\r\n  </outbound>\r\n</policies>",
                Format = PolicyContentFormat.Xml,
            };
            ArmOperation<ServiceWorkspaceProductPolicyResource> lro = await serviceWorkspaceProductPolicy.UpdateAsync(WaitUntil.Completed, data);
            ServiceWorkspaceProductPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeleteWorkspaceProductPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementDeleteWorkspaceProductPolicy.json
            // this example is just showing the usage of "WorkspaceProductPolicy_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceProductPolicyResource created on azure
            // for more information of creating ServiceWorkspaceProductPolicyResource, please refer to the document of ServiceWorkspaceProductPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string productId = "testproduct";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier serviceWorkspaceProductPolicyResourceId = ServiceWorkspaceProductPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, productId, policyId);
            ServiceWorkspaceProductPolicyResource serviceWorkspaceProductPolicy = client.GetServiceWorkspaceProductPolicyResource(serviceWorkspaceProductPolicyResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await serviceWorkspaceProductPolicy.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine("Succeeded");
        }
    }
}
