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
    public partial class Sample_ServiceBusRuleResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_RulesGet()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/Rules/RuleGet.json
            // this example is just showing the usage of "Rules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusRuleResource created on azure
            // for more information of creating ServiceBusRuleResource, please refer to the document of ServiceBusRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-1319";
            string topicName = "sdk-Topics-2081";
            string subscriptionName = "sdk-Subscriptions-8691";
            string ruleName = "sdk-Rules-6571";
            ResourceIdentifier serviceBusRuleResourceId = ServiceBusRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName, subscriptionName, ruleName);
            ServiceBusRuleResource serviceBusRule = client.GetServiceBusRuleResource(serviceBusRuleResourceId);

            // invoke the operation
            ServiceBusRuleResource result = await serviceBusRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_RulesDelete()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/Rules/RuleDelete.json
            // this example is just showing the usage of "Rules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusRuleResource created on azure
            // for more information of creating ServiceBusRuleResource, please refer to the document of ServiceBusRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-1319";
            string topicName = "sdk-Topics-2081";
            string subscriptionName = "sdk-Subscriptions-8691";
            string ruleName = "sdk-Rules-6571";
            ResourceIdentifier serviceBusRuleResourceId = ServiceBusRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName, subscriptionName, ruleName);
            ServiceBusRuleResource serviceBusRule = client.GetServiceBusRuleResource(serviceBusRuleResourceId);

            // invoke the operation
            await serviceBusRule.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_RulesCreateCorrelationFilter()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/Rules/RuleCreate_CorrelationFilter.json
            // this example is just showing the usage of "Rules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusRuleResource created on azure
            // for more information of creating ServiceBusRuleResource, please refer to the document of ServiceBusRuleResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroupName";
            string namespaceName = "sdk-Namespace-1319";
            string topicName = "sdk-Topics-2081";
            string subscriptionName = "sdk-Subscriptions-8691";
            string ruleName = "sdk-Rules-6571";
            ResourceIdentifier serviceBusRuleResourceId = ServiceBusRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName, subscriptionName, ruleName);
            ServiceBusRuleResource serviceBusRule = client.GetServiceBusRuleResource(serviceBusRuleResourceId);

            // invoke the operation
            ServiceBusRuleData data = new ServiceBusRuleData
            {
                FilterType = ServiceBusFilterType.CorrelationFilter,
                CorrelationFilter = new ServiceBusCorrelationFilter
                {
                    ApplicationProperties =
{
["topicHint"] = "Crop"
},
                },
            };
            ArmOperation<ServiceBusRuleResource> lro = await serviceBusRule.UpdateAsync(WaitUntil.Completed, data);
            ServiceBusRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_RulesCreateOrUpdate()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/Rules/RuleCreate.json
            // this example is just showing the usage of "Rules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusRuleResource created on azure
            // for more information of creating ServiceBusRuleResource, please refer to the document of ServiceBusRuleResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroupName";
            string namespaceName = "sdk-Namespace-1319";
            string topicName = "sdk-Topics-2081";
            string subscriptionName = "sdk-Subscriptions-8691";
            string ruleName = "sdk-Rules-6571";
            ResourceIdentifier serviceBusRuleResourceId = ServiceBusRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName, subscriptionName, ruleName);
            ServiceBusRuleResource serviceBusRule = client.GetServiceBusRuleResource(serviceBusRuleResourceId);

            // invoke the operation
            ServiceBusRuleData data = new ServiceBusRuleData();
            ArmOperation<ServiceBusRuleResource> lro = await serviceBusRule.UpdateAsync(WaitUntil.Completed, data);
            ServiceBusRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_RulesCreateSqlFilter()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/Rules/RuleCreate_SqlFilter.json
            // this example is just showing the usage of "Rules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusRuleResource created on azure
            // for more information of creating ServiceBusRuleResource, please refer to the document of ServiceBusRuleResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroupName";
            string namespaceName = "sdk-Namespace-1319";
            string topicName = "sdk-Topics-2081";
            string subscriptionName = "sdk-Subscriptions-8691";
            string ruleName = "sdk-Rules-6571";
            ResourceIdentifier serviceBusRuleResourceId = ServiceBusRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName, subscriptionName, ruleName);
            ServiceBusRuleResource serviceBusRule = client.GetServiceBusRuleResource(serviceBusRuleResourceId);

            // invoke the operation
            ServiceBusRuleData data = new ServiceBusRuleData
            {
                FilterType = ServiceBusFilterType.SqlFilter,
                SqlFilter = new ServiceBusSqlFilter
                {
                    SqlExpression = "myproperty=test",
                },
            };
            ArmOperation<ServiceBusRuleResource> lro = await serviceBusRule.UpdateAsync(WaitUntil.Completed, data);
            ServiceBusRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
