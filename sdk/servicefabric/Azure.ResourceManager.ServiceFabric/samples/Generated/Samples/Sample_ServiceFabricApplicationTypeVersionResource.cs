// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.ServiceFabric.Samples
{
    public partial class Sample_ServiceFabricApplicationTypeVersionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAnApplicationTypeVersion()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ApplicationTypeVersionGetOperation_example.json
            // this example is just showing the usage of "ApplicationTypeVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricApplicationTypeVersionResource created on azure
            // for more information of creating ServiceFabricApplicationTypeVersionResource, please refer to the document of ServiceFabricApplicationTypeVersionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationTypeName = "myAppType";
            string version = "1.0";
            ResourceIdentifier serviceFabricApplicationTypeVersionResourceId = ServiceFabricApplicationTypeVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationTypeName, version);
            ServiceFabricApplicationTypeVersionResource serviceFabricApplicationTypeVersion = client.GetServiceFabricApplicationTypeVersionResource(serviceFabricApplicationTypeVersionResourceId);

            // invoke the operation
            ServiceFabricApplicationTypeVersionResource result = await serviceFabricApplicationTypeVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricApplicationTypeVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAnApplicationTypeVersion()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ApplicationTypeVersionDeleteOperation_example.json
            // this example is just showing the usage of "ApplicationTypeVersions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricApplicationTypeVersionResource created on azure
            // for more information of creating ServiceFabricApplicationTypeVersionResource, please refer to the document of ServiceFabricApplicationTypeVersionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationTypeName = "myAppType";
            string version = "1.0";
            ResourceIdentifier serviceFabricApplicationTypeVersionResourceId = ServiceFabricApplicationTypeVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationTypeName, version);
            ServiceFabricApplicationTypeVersionResource serviceFabricApplicationTypeVersion = client.GetServiceFabricApplicationTypeVersionResource(serviceFabricApplicationTypeVersionResourceId);

            // invoke the operation
            await serviceFabricApplicationTypeVersion.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PutAnApplicationTypeVersion()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ApplicationTypeVersionPutOperation_example.json
            // this example is just showing the usage of "ApplicationTypeVersions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricApplicationTypeVersionResource created on azure
            // for more information of creating ServiceFabricApplicationTypeVersionResource, please refer to the document of ServiceFabricApplicationTypeVersionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationTypeName = "myAppType";
            string version = "1.0";
            ResourceIdentifier serviceFabricApplicationTypeVersionResourceId = ServiceFabricApplicationTypeVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationTypeName, version);
            ServiceFabricApplicationTypeVersionResource serviceFabricApplicationTypeVersion = client.GetServiceFabricApplicationTypeVersionResource(serviceFabricApplicationTypeVersionResourceId);

            // invoke the operation
            ServiceFabricApplicationTypeVersionData data = new ServiceFabricApplicationTypeVersionData(default)
            {
                AppPackageUri = new Uri("http://fakelink.test.com/MyAppType"),
                Tags = { },
            };
            ArmOperation<ServiceFabricApplicationTypeVersionResource> lro = await serviceFabricApplicationTypeVersion.UpdateAsync(WaitUntil.Completed, data);
            ServiceFabricApplicationTypeVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricApplicationTypeVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
