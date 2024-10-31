// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppContainers.Models;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_HttpRouteConfigResource
    {
        // Get HttpRoute
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetHttpRoute()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/HttpRouteConfig_Get.json
            // this example is just showing the usage of "HttpRouteConfig_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HttpRouteConfigResource created on azure
            // for more information of creating HttpRouteConfigResource, please refer to the document of HttpRouteConfigResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            string environmentName = "testcontainerenv";
            string httpRouteName = "httproutefriendlyname";
            ResourceIdentifier httpRouteConfigResourceId = HttpRouteConfigResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName, httpRouteName);
            HttpRouteConfigResource httpRouteConfig = client.GetHttpRouteConfigResource(httpRouteConfigResourceId);

            // invoke the operation
            HttpRouteConfigResource result = await httpRouteConfig.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HttpRouteConfigData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Patch Managed Http Route
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchManagedHttpRoute()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/HttpRouteConfig_Patch.json
            // this example is just showing the usage of "HttpRouteConfig_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HttpRouteConfigResource created on azure
            // for more information of creating HttpRouteConfigResource, please refer to the document of HttpRouteConfigResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            string environmentName = "testcontainerenv";
            string httpRouteName = "httproutefriendlyname";
            ResourceIdentifier httpRouteConfigResourceId = HttpRouteConfigResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName, httpRouteName);
            HttpRouteConfigResource httpRouteConfig = client.GetHttpRouteConfigResource(httpRouteConfigResourceId);

            // invoke the operation
            HttpRouteConfigData data = new HttpRouteConfigData()
            {
                Properties = new HttpRouteConfigProperties()
                {
                    CustomDomains =
{
new ContainerAppCustomDomain("example.com")
{
BindingType = ContainerAppCustomDomainBindingType.SniEnabled,
CertificateId = new ResourceIdentifier("/subscriptions/34adfa4f-cedf-4dc0-ba29-b6d1a69ab345/resourceGroups/examplerg/providers/Microsoft.App/managedEnvironments/testcontainerenv/certificates/certificate-1"),
}
},
                    Rules =
{
new HttpRouteRule()
{
Targets =
{
new HttpRouteTarget("capp-1")
{
Revision = "rev-1",
Weight = 100,
}
},
Routes =
{
new HttpRoute()
{
Match = new HttpRouteMatch()
{
Path = "/v1",
CaseSensitive = true,
},
ActionPrefixRewrite = "/v1/api",
}
},
Description = "random-description",
}
},
                },
            };
            HttpRouteConfigResource result = await httpRouteConfig.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HttpRouteConfigData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete Certificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteCertificate()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/HttpRouteConfig_Delete.json
            // this example is just showing the usage of "HttpRouteConfig_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HttpRouteConfigResource created on azure
            // for more information of creating HttpRouteConfigResource, please refer to the document of HttpRouteConfigResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            string environmentName = "testcontainerenv";
            string httpRouteName = "httproutefriendlyname";
            ResourceIdentifier httpRouteConfigResourceId = HttpRouteConfigResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName, httpRouteName);
            HttpRouteConfigResource httpRouteConfig = client.GetHttpRouteConfigResource(httpRouteConfigResourceId);

            // invoke the operation
            await httpRouteConfig.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
