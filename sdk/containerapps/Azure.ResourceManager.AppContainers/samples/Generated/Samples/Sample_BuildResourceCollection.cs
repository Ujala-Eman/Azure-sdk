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
    public partial class Sample_BuildResourceCollection
    {
        // Builds_ListByBuilderResource_0
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_BuildsListByBuilderResource0()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/Builds_ListByBuilderResource.json
            // this example is just showing the usage of "BuildsByBuilderResource_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BuilderResource created on azure
            // for more information of creating BuilderResource, please refer to the document of BuilderResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string builderName = "testBuilder";
            ResourceIdentifier builderResourceId = BuilderResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, builderName);
            BuilderResource builderResource = client.GetBuilderResource(builderResourceId);

            // get the collection of this BuildResource
            BuildResourceCollection collection = builderResource.GetBuildResources();

            // invoke the operation and iterate over the result
            await foreach (BuildResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BuildResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Builds_Get_0
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_BuildsGet0()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/Builds_Get.json
            // this example is just showing the usage of "Builds_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BuilderResource created on azure
            // for more information of creating BuilderResource, please refer to the document of BuilderResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string builderName = "testBuilder";
            ResourceIdentifier builderResourceId = BuilderResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, builderName);
            BuilderResource builderResource = client.GetBuilderResource(builderResourceId);

            // get the collection of this BuildResource
            BuildResourceCollection collection = builderResource.GetBuildResources();

            // invoke the operation
            string buildName = "testBuild";
            BuildResource result = await collection.GetAsync(buildName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BuildResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Builds_Get_0
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_BuildsGet0()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/Builds_Get.json
            // this example is just showing the usage of "Builds_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BuilderResource created on azure
            // for more information of creating BuilderResource, please refer to the document of BuilderResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string builderName = "testBuilder";
            ResourceIdentifier builderResourceId = BuilderResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, builderName);
            BuilderResource builderResource = client.GetBuilderResource(builderResourceId);

            // get the collection of this BuildResource
            BuildResourceCollection collection = builderResource.GetBuildResources();

            // invoke the operation
            string buildName = "testBuild";
            bool result = await collection.ExistsAsync(buildName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Builds_Get_0
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_BuildsGet0()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/Builds_Get.json
            // this example is just showing the usage of "Builds_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BuilderResource created on azure
            // for more information of creating BuilderResource, please refer to the document of BuilderResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string builderName = "testBuilder";
            ResourceIdentifier builderResourceId = BuilderResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, builderName);
            BuilderResource builderResource = client.GetBuilderResource(builderResourceId);

            // get the collection of this BuildResource
            BuildResourceCollection collection = builderResource.GetBuildResources();

            // invoke the operation
            string buildName = "testBuild";
            NullableResponse<BuildResource> response = await collection.GetIfExistsAsync(buildName);
            BuildResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BuildResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Builds_CreateOrUpdate_NoConfig
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_BuildsCreateOrUpdateNoConfig()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/Builds_CreateOrUpdate_NoConfig.json
            // this example is just showing the usage of "Builds_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BuilderResource created on azure
            // for more information of creating BuilderResource, please refer to the document of BuilderResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string builderName = "testBuilder";
            ResourceIdentifier builderResourceId = BuilderResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, builderName);
            BuilderResource builderResource = client.GetBuilderResource(builderResourceId);

            // get the collection of this BuildResource
            BuildResourceCollection collection = builderResource.GetBuildResources();

            // invoke the operation
            string buildName = "testBuild";
            BuildResourceData data = new BuildResourceData();
            ArmOperation<BuildResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, buildName, data);
            BuildResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BuildResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Builds_CreateOrUpdate_WithConfig
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_BuildsCreateOrUpdateWithConfig()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/Builds_CreateOrUpdate.json
            // this example is just showing the usage of "Builds_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BuilderResource created on azure
            // for more information of creating BuilderResource, please refer to the document of BuilderResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string builderName = "testBuilder";
            ResourceIdentifier builderResourceId = BuilderResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, builderName);
            BuilderResource builderResource = client.GetBuilderResource(builderResourceId);

            // get the collection of this BuildResource
            BuildResourceCollection collection = builderResource.GetBuildResources();

            // invoke the operation
            string buildName = "testBuild-123456789az";
            BuildResourceData data = new BuildResourceData()
            {
                DestinationContainerRegistry = new ContainerRegistryWithCustomImage("test.azurecr.io")
                {
                    Image = "test.azurecr.io/repo:tag",
                },
                Configuration = new BuildConfiguration()
                {
                    BaseOS = "DebianBullseye",
                    Platform = "dotnetcore",
                    PlatformVersion = "7.0",
                    EnvironmentVariables =
{
new EnvironmentVariable("foo1","bar1"),new EnvironmentVariable("foo2","bar2")
},
                    PreBuildSteps =
{
new PreBuildStep()
{
Description = "First pre build step.",
Scripts =
{
"echo 'hello'","echo 'world'"
},
HttpGet = new HttpGet(new Uri("https://microsoft.com"))
{
FileName = "output.txt",
Headers =
{
"foo","bar"
},
},
},new PreBuildStep()
{
Description = "Second pre build step.",
Scripts =
{
"echo 'hello'","echo 'again'"
},
HttpGet = new HttpGet(new Uri("https://microsoft.com"))
{
FileName = "output.txt",
Headers =
{
"foo"
},
},
}
},
                },
            };
            ArmOperation<BuildResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, buildName, data);
            BuildResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BuildResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
