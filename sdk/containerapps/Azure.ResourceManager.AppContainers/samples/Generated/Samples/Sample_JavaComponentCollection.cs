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
    public partial class Sample_JavaComponentCollection
    {
        // List Java Components
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListJavaComponents()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/JavaComponents_List.json
            // this example is just showing the usage of "JavaComponents_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "myenvironment";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this JavaComponentResource
            JavaComponentCollection collection = containerAppManagedEnvironment.GetJavaComponents();

            // invoke the operation and iterate over the result
            await foreach (JavaComponentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                JavaComponentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List Java Components with ServiceBinds
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListJavaComponentsWithServiceBinds()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/JavaComponents_List_ServiceBind.json
            // this example is just showing the usage of "JavaComponents_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "myenvironment";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this JavaComponentResource
            JavaComponentCollection collection = containerAppManagedEnvironment.GetJavaComponents();

            // invoke the operation and iterate over the result
            await foreach (JavaComponentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                JavaComponentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Java Component
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetJavaComponent()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/JavaComponents_Get.json
            // this example is just showing the usage of "JavaComponents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "myenvironment";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this JavaComponentResource
            JavaComponentCollection collection = containerAppManagedEnvironment.GetJavaComponents();

            // invoke the operation
            string name = "myjavacomponent";
            JavaComponentResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            JavaComponentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Java Component
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetJavaComponent()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/JavaComponents_Get.json
            // this example is just showing the usage of "JavaComponents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "myenvironment";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this JavaComponentResource
            JavaComponentCollection collection = containerAppManagedEnvironment.GetJavaComponents();

            // invoke the operation
            string name = "myjavacomponent";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Java Component
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetJavaComponent()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/JavaComponents_Get.json
            // this example is just showing the usage of "JavaComponents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "myenvironment";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this JavaComponentResource
            JavaComponentCollection collection = containerAppManagedEnvironment.GetJavaComponents();

            // invoke the operation
            string name = "myjavacomponent";
            NullableResponse<JavaComponentResource> response = await collection.GetIfExistsAsync(name);
            JavaComponentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                JavaComponentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Get Java Component with ServiceBinds
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetJavaComponentWithServiceBinds()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/JavaComponents_Get_ServiceBind.json
            // this example is just showing the usage of "JavaComponents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "myenvironment";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this JavaComponentResource
            JavaComponentCollection collection = containerAppManagedEnvironment.GetJavaComponents();

            // invoke the operation
            string name = "myjavacomponent";
            JavaComponentResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            JavaComponentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Java Component with ServiceBinds
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetJavaComponentWithServiceBinds()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/JavaComponents_Get_ServiceBind.json
            // this example is just showing the usage of "JavaComponents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "myenvironment";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this JavaComponentResource
            JavaComponentCollection collection = containerAppManagedEnvironment.GetJavaComponents();

            // invoke the operation
            string name = "myjavacomponent";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Java Component with ServiceBinds
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetJavaComponentWithServiceBinds()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/JavaComponents_Get_ServiceBind.json
            // this example is just showing the usage of "JavaComponents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "myenvironment";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this JavaComponentResource
            JavaComponentCollection collection = containerAppManagedEnvironment.GetJavaComponents();

            // invoke the operation
            string name = "myjavacomponent";
            NullableResponse<JavaComponentResource> response = await collection.GetIfExistsAsync(name);
            JavaComponentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                JavaComponentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create or Update Java Component
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateJavaComponent()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/JavaComponents_CreateOrUpdate.json
            // this example is just showing the usage of "JavaComponents_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "myenvironment";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this JavaComponentResource
            JavaComponentCollection collection = containerAppManagedEnvironment.GetJavaComponents();

            // invoke the operation
            string name = "myjavacomponent";
            JavaComponentData data = new JavaComponentData()
            {
                Properties = new SpringBootAdminComponent()
                {
                    Configurations =
{
new JavaComponentConfigurationProperty()
{
PropertyName = "spring.boot.admin.ui.enable-toasts",
Value = "true",
},new JavaComponentConfigurationProperty()
{
PropertyName = "spring.boot.admin.monitor.status-interval",
Value = "10000ms",
}
},
                    Scale = new JavaComponentPropertiesScale()
                    {
                        MinReplicas = 1,
                        MaxReplicas = 1,
                    },
                },
            };
            ArmOperation<JavaComponentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            JavaComponentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            JavaComponentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or Update Java Component with ServiceBinds
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateJavaComponentWithServiceBinds()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/JavaComponents_CreateOrUpdate_ServiceBind.json
            // this example is just showing the usage of "JavaComponents_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "myenvironment";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this JavaComponentResource
            JavaComponentCollection collection = containerAppManagedEnvironment.GetJavaComponents();

            // invoke the operation
            string name = "myjavacomponent";
            JavaComponentData data = new JavaComponentData()
            {
                Properties = new SpringBootAdminComponent()
                {
                    Configurations =
{
new JavaComponentConfigurationProperty()
{
PropertyName = "spring.boot.admin.ui.enable-toasts",
Value = "true",
},new JavaComponentConfigurationProperty()
{
PropertyName = "spring.boot.admin.monitor.status-interval",
Value = "10000ms",
}
},
                    Scale = new JavaComponentPropertiesScale()
                    {
                        MinReplicas = 1,
                        MaxReplicas = 1,
                    },
                    ServiceBinds =
{
new JavaComponentServiceBind()
{
Name = "yellowcat",
ServiceId = new ResourceIdentifier("/subscriptions/8efdecc5-919e-44eb-b179-915dca89ebf9/resourceGroups/examplerg/providers/Microsoft.App/managedEnvironments/myenvironment/javaComponents/yellowcat"),
}
},
                },
            };
            ArmOperation<JavaComponentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            JavaComponentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            JavaComponentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
