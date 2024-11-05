// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ServiceBus.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ServiceBus.Samples
{
    public partial class Sample_ServiceBusTopicAuthorizationRuleCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_TopicAuthorizationRuleCreate()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/Topics/SBTopicAuthorizationRuleCreate.json
            // this example is just showing the usage of "TopicAuthorizationRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusTopicResource created on azure
            // for more information of creating ServiceBusTopicResource, please refer to the document of ServiceBusTopicResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-6261";
            string topicName = "sdk-Topics-1984";
            ResourceIdentifier serviceBusTopicResourceId = ServiceBusTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName);
            ServiceBusTopicResource serviceBusTopic = client.GetServiceBusTopicResource(serviceBusTopicResourceId);

            // get the collection of this ServiceBusTopicAuthorizationRuleResource
            ServiceBusTopicAuthorizationRuleCollection collection = serviceBusTopic.GetServiceBusTopicAuthorizationRules();

            // invoke the operation
            string authorizationRuleName = "sdk-AuthRules-4310";
            ServiceBusAuthorizationRuleData data = new ServiceBusAuthorizationRuleData
            {
                Rights = { ServiceBusAccessRight.Listen, ServiceBusAccessRight.Send },
            };
            ArmOperation<ServiceBusTopicAuthorizationRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, authorizationRuleName, data);
            ServiceBusTopicAuthorizationRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusAuthorizationRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_TopicAuthorizationRuleGet()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/Topics/SBTopicAuthorizationRuleGet.json
            // this example is just showing the usage of "TopicAuthorizationRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusTopicResource created on azure
            // for more information of creating ServiceBusTopicResource, please refer to the document of ServiceBusTopicResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-6261";
            string topicName = "sdk-Topics-1984";
            ResourceIdentifier serviceBusTopicResourceId = ServiceBusTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName);
            ServiceBusTopicResource serviceBusTopic = client.GetServiceBusTopicResource(serviceBusTopicResourceId);

            // get the collection of this ServiceBusTopicAuthorizationRuleResource
            ServiceBusTopicAuthorizationRuleCollection collection = serviceBusTopic.GetServiceBusTopicAuthorizationRules();

            // invoke the operation
            string authorizationRuleName = "sdk-AuthRules-4310";
            ServiceBusTopicAuthorizationRuleResource result = await collection.GetAsync(authorizationRuleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusAuthorizationRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_TopicAuthorizationRuleListAll()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/Topics/SBTopicAuthorizationRuleListAll.json
            // this example is just showing the usage of "TopicAuthorizationRules_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusTopicResource created on azure
            // for more information of creating ServiceBusTopicResource, please refer to the document of ServiceBusTopicResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-6261";
            string topicName = "sdk-Topics-1984";
            ResourceIdentifier serviceBusTopicResourceId = ServiceBusTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName);
            ServiceBusTopicResource serviceBusTopic = client.GetServiceBusTopicResource(serviceBusTopicResourceId);

            // get the collection of this ServiceBusTopicAuthorizationRuleResource
            ServiceBusTopicAuthorizationRuleCollection collection = serviceBusTopic.GetServiceBusTopicAuthorizationRules();

            // invoke the operation and iterate over the result
            await foreach (ServiceBusTopicAuthorizationRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceBusAuthorizationRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_TopicAuthorizationRuleGet()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/Topics/SBTopicAuthorizationRuleGet.json
            // this example is just showing the usage of "TopicAuthorizationRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusTopicResource created on azure
            // for more information of creating ServiceBusTopicResource, please refer to the document of ServiceBusTopicResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-6261";
            string topicName = "sdk-Topics-1984";
            ResourceIdentifier serviceBusTopicResourceId = ServiceBusTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName);
            ServiceBusTopicResource serviceBusTopic = client.GetServiceBusTopicResource(serviceBusTopicResourceId);

            // get the collection of this ServiceBusTopicAuthorizationRuleResource
            ServiceBusTopicAuthorizationRuleCollection collection = serviceBusTopic.GetServiceBusTopicAuthorizationRules();

            // invoke the operation
            string authorizationRuleName = "sdk-AuthRules-4310";
            bool result = await collection.ExistsAsync(authorizationRuleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_TopicAuthorizationRuleGet()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/Topics/SBTopicAuthorizationRuleGet.json
            // this example is just showing the usage of "TopicAuthorizationRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusTopicResource created on azure
            // for more information of creating ServiceBusTopicResource, please refer to the document of ServiceBusTopicResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-6261";
            string topicName = "sdk-Topics-1984";
            ResourceIdentifier serviceBusTopicResourceId = ServiceBusTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName);
            ServiceBusTopicResource serviceBusTopic = client.GetServiceBusTopicResource(serviceBusTopicResourceId);

            // get the collection of this ServiceBusTopicAuthorizationRuleResource
            ServiceBusTopicAuthorizationRuleCollection collection = serviceBusTopic.GetServiceBusTopicAuthorizationRules();

            // invoke the operation
            string authorizationRuleName = "sdk-AuthRules-4310";
            NullableResponse<ServiceBusTopicAuthorizationRuleResource> response = await collection.GetIfExistsAsync(authorizationRuleName);
            ServiceBusTopicAuthorizationRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceBusAuthorizationRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
