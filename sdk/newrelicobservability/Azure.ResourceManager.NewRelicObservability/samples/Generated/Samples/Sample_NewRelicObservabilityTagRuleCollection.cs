// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NewRelicObservability.Models;

namespace Azure.ResourceManager.NewRelicObservability.Samples
{
    public partial class Sample_NewRelicObservabilityTagRuleCollection
    {
        // TagRules_ListByNewRelicMonitorResource_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_TagRulesListByNewRelicMonitorResourceMaximumSetGen()
        {
            // Generated from example definition: specification/newrelic/resource-manager/NewRelic.Observability/stable/2022-07-01/examples/TagRules_ListByNewRelicMonitorResource_MaximumSet_Gen.json
            // this example is just showing the usage of "TagRules_ListByNewRelicMonitorResource" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NewRelicMonitorResource created on azure
            // for more information of creating NewRelicMonitorResource, please refer to the document of NewRelicMonitorResource
            string subscriptionId = "ddqonpqwjr";
            string resourceGroupName = "rgopenapi";
            string monitorName = "ipxmlcbonyxtolzejcjshkmlron";
            ResourceIdentifier newRelicMonitorResourceId = NewRelicMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            NewRelicMonitorResource newRelicMonitorResource = client.GetNewRelicMonitorResource(newRelicMonitorResourceId);

            // get the collection of this NewRelicObservabilityTagRuleResource
            NewRelicObservabilityTagRuleCollection collection = newRelicMonitorResource.GetNewRelicObservabilityTagRules();

            // invoke the operation and iterate over the result
            await foreach (NewRelicObservabilityTagRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NewRelicObservabilityTagRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // TagRules_ListByNewRelicMonitorResource_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_TagRulesListByNewRelicMonitorResourceMinimumSetGen()
        {
            // Generated from example definition: specification/newrelic/resource-manager/NewRelic.Observability/stable/2022-07-01/examples/TagRules_ListByNewRelicMonitorResource_MinimumSet_Gen.json
            // this example is just showing the usage of "TagRules_ListByNewRelicMonitorResource" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NewRelicMonitorResource created on azure
            // for more information of creating NewRelicMonitorResource, please refer to the document of NewRelicMonitorResource
            string subscriptionId = "ddqonpqwjr";
            string resourceGroupName = "rgopenapi";
            string monitorName = "ipxmlcbonyxtolzejcjshkmlron";
            ResourceIdentifier newRelicMonitorResourceId = NewRelicMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            NewRelicMonitorResource newRelicMonitorResource = client.GetNewRelicMonitorResource(newRelicMonitorResourceId);

            // get the collection of this NewRelicObservabilityTagRuleResource
            NewRelicObservabilityTagRuleCollection collection = newRelicMonitorResource.GetNewRelicObservabilityTagRules();

            // invoke the operation and iterate over the result
            await foreach (NewRelicObservabilityTagRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NewRelicObservabilityTagRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // TagRules_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_TagRulesGetMaximumSetGen()
        {
            // Generated from example definition: specification/newrelic/resource-manager/NewRelic.Observability/stable/2022-07-01/examples/TagRules_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "TagRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NewRelicMonitorResource created on azure
            // for more information of creating NewRelicMonitorResource, please refer to the document of NewRelicMonitorResource
            string subscriptionId = "ddqonpqwjr";
            string resourceGroupName = "rgopenapi";
            string monitorName = "ipxmlcbonyxtolzejcjshkmlron";
            ResourceIdentifier newRelicMonitorResourceId = NewRelicMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            NewRelicMonitorResource newRelicMonitorResource = client.GetNewRelicMonitorResource(newRelicMonitorResourceId);

            // get the collection of this NewRelicObservabilityTagRuleResource
            NewRelicObservabilityTagRuleCollection collection = newRelicMonitorResource.GetNewRelicObservabilityTagRules();

            // invoke the operation
            string ruleSetName = "bxcantgzggsepbhqmedjqyrqeezmfb";
            NewRelicObservabilityTagRuleResource result = await collection.GetAsync(ruleSetName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NewRelicObservabilityTagRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // TagRules_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_TagRulesGetMaximumSetGen()
        {
            // Generated from example definition: specification/newrelic/resource-manager/NewRelic.Observability/stable/2022-07-01/examples/TagRules_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "TagRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NewRelicMonitorResource created on azure
            // for more information of creating NewRelicMonitorResource, please refer to the document of NewRelicMonitorResource
            string subscriptionId = "ddqonpqwjr";
            string resourceGroupName = "rgopenapi";
            string monitorName = "ipxmlcbonyxtolzejcjshkmlron";
            ResourceIdentifier newRelicMonitorResourceId = NewRelicMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            NewRelicMonitorResource newRelicMonitorResource = client.GetNewRelicMonitorResource(newRelicMonitorResourceId);

            // get the collection of this NewRelicObservabilityTagRuleResource
            NewRelicObservabilityTagRuleCollection collection = newRelicMonitorResource.GetNewRelicObservabilityTagRules();

            // invoke the operation
            string ruleSetName = "bxcantgzggsepbhqmedjqyrqeezmfb";
            bool result = await collection.ExistsAsync(ruleSetName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // TagRules_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_TagRulesGetMaximumSetGen()
        {
            // Generated from example definition: specification/newrelic/resource-manager/NewRelic.Observability/stable/2022-07-01/examples/TagRules_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "TagRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NewRelicMonitorResource created on azure
            // for more information of creating NewRelicMonitorResource, please refer to the document of NewRelicMonitorResource
            string subscriptionId = "ddqonpqwjr";
            string resourceGroupName = "rgopenapi";
            string monitorName = "ipxmlcbonyxtolzejcjshkmlron";
            ResourceIdentifier newRelicMonitorResourceId = NewRelicMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            NewRelicMonitorResource newRelicMonitorResource = client.GetNewRelicMonitorResource(newRelicMonitorResourceId);

            // get the collection of this NewRelicObservabilityTagRuleResource
            NewRelicObservabilityTagRuleCollection collection = newRelicMonitorResource.GetNewRelicObservabilityTagRules();

            // invoke the operation
            string ruleSetName = "bxcantgzggsepbhqmedjqyrqeezmfb";
            NullableResponse<NewRelicObservabilityTagRuleResource> response = await collection.GetIfExistsAsync(ruleSetName);
            NewRelicObservabilityTagRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NewRelicObservabilityTagRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // TagRules_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_TagRulesGetMinimumSetGen()
        {
            // Generated from example definition: specification/newrelic/resource-manager/NewRelic.Observability/stable/2022-07-01/examples/TagRules_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "TagRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NewRelicMonitorResource created on azure
            // for more information of creating NewRelicMonitorResource, please refer to the document of NewRelicMonitorResource
            string subscriptionId = "ddqonpqwjr";
            string resourceGroupName = "rgopenapi";
            string monitorName = "ipxmlcbonyxtolzejcjshkmlron";
            ResourceIdentifier newRelicMonitorResourceId = NewRelicMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            NewRelicMonitorResource newRelicMonitorResource = client.GetNewRelicMonitorResource(newRelicMonitorResourceId);

            // get the collection of this NewRelicObservabilityTagRuleResource
            NewRelicObservabilityTagRuleCollection collection = newRelicMonitorResource.GetNewRelicObservabilityTagRules();

            // invoke the operation
            string ruleSetName = "bxcantgzggsepbhqmedjqyrqeezmfb";
            NewRelicObservabilityTagRuleResource result = await collection.GetAsync(ruleSetName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NewRelicObservabilityTagRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // TagRules_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_TagRulesGetMinimumSetGen()
        {
            // Generated from example definition: specification/newrelic/resource-manager/NewRelic.Observability/stable/2022-07-01/examples/TagRules_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "TagRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NewRelicMonitorResource created on azure
            // for more information of creating NewRelicMonitorResource, please refer to the document of NewRelicMonitorResource
            string subscriptionId = "ddqonpqwjr";
            string resourceGroupName = "rgopenapi";
            string monitorName = "ipxmlcbonyxtolzejcjshkmlron";
            ResourceIdentifier newRelicMonitorResourceId = NewRelicMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            NewRelicMonitorResource newRelicMonitorResource = client.GetNewRelicMonitorResource(newRelicMonitorResourceId);

            // get the collection of this NewRelicObservabilityTagRuleResource
            NewRelicObservabilityTagRuleCollection collection = newRelicMonitorResource.GetNewRelicObservabilityTagRules();

            // invoke the operation
            string ruleSetName = "bxcantgzggsepbhqmedjqyrqeezmfb";
            bool result = await collection.ExistsAsync(ruleSetName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // TagRules_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_TagRulesGetMinimumSetGen()
        {
            // Generated from example definition: specification/newrelic/resource-manager/NewRelic.Observability/stable/2022-07-01/examples/TagRules_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "TagRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NewRelicMonitorResource created on azure
            // for more information of creating NewRelicMonitorResource, please refer to the document of NewRelicMonitorResource
            string subscriptionId = "ddqonpqwjr";
            string resourceGroupName = "rgopenapi";
            string monitorName = "ipxmlcbonyxtolzejcjshkmlron";
            ResourceIdentifier newRelicMonitorResourceId = NewRelicMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            NewRelicMonitorResource newRelicMonitorResource = client.GetNewRelicMonitorResource(newRelicMonitorResourceId);

            // get the collection of this NewRelicObservabilityTagRuleResource
            NewRelicObservabilityTagRuleCollection collection = newRelicMonitorResource.GetNewRelicObservabilityTagRules();

            // invoke the operation
            string ruleSetName = "bxcantgzggsepbhqmedjqyrqeezmfb";
            NullableResponse<NewRelicObservabilityTagRuleResource> response = await collection.GetIfExistsAsync(ruleSetName);
            NewRelicObservabilityTagRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NewRelicObservabilityTagRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // TagRules_CreateOrUpdate_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_TagRulesCreateOrUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/newrelic/resource-manager/NewRelic.Observability/stable/2022-07-01/examples/TagRules_CreateOrUpdate_MaximumSet_Gen.json
            // this example is just showing the usage of "TagRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NewRelicMonitorResource created on azure
            // for more information of creating NewRelicMonitorResource, please refer to the document of NewRelicMonitorResource
            string subscriptionId = "ddqonpqwjr";
            string resourceGroupName = "rgopenapi";
            string monitorName = "ipxmlcbonyxtolzejcjshkmlron";
            ResourceIdentifier newRelicMonitorResourceId = NewRelicMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            NewRelicMonitorResource newRelicMonitorResource = client.GetNewRelicMonitorResource(newRelicMonitorResourceId);

            // get the collection of this NewRelicObservabilityTagRuleResource
            NewRelicObservabilityTagRuleCollection collection = newRelicMonitorResource.GetNewRelicObservabilityTagRules();

            // invoke the operation
            string ruleSetName = "bxcantgzggsepbhqmedjqyrqeezmfb";
            NewRelicObservabilityTagRuleData data = new NewRelicObservabilityTagRuleData()
            {
                LogRules = new NewRelicObservabilityLogRules()
                {
                    SendAadLogs = NewRelicObservabilitySendAadLogsStatus.IsEnabled,
                    SendSubscriptionLogs = NewRelicObservabilitySendSubscriptionLogsStatus.IsEnabled,
                    SendActivityLogs = NewRelicObservabilitySendActivityLogsStatus.IsEnabled,
                    FilteringTags =
{
new NewRelicObservabilityFilteringTag()
{
Name = "saokgpjvdlorciqbjmjxazpee",
Value = "sarxrqsxouhdjwsrqqicbeirdb",
Action = NewRelicObservabilityTagAction.Include,
}
},
                },
                MetricRules = new NewRelicObservabilityMetricRules()
                {
                    FilteringTags =
{
new NewRelicObservabilityFilteringTag()
{
Name = "saokgpjvdlorciqbjmjxazpee",
Value = "sarxrqsxouhdjwsrqqicbeirdb",
Action = NewRelicObservabilityTagAction.Include,
}
},
                    UserEmail = "test@testing.com",
                },
            };
            ArmOperation<NewRelicObservabilityTagRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, ruleSetName, data);
            NewRelicObservabilityTagRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NewRelicObservabilityTagRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // TagRules_CreateOrUpdate_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_TagRulesCreateOrUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/newrelic/resource-manager/NewRelic.Observability/stable/2022-07-01/examples/TagRules_CreateOrUpdate_MinimumSet_Gen.json
            // this example is just showing the usage of "TagRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NewRelicMonitorResource created on azure
            // for more information of creating NewRelicMonitorResource, please refer to the document of NewRelicMonitorResource
            string subscriptionId = "ddqonpqwjr";
            string resourceGroupName = "rgopenapi";
            string monitorName = "ipxmlcbonyxtolzejcjshkmlron";
            ResourceIdentifier newRelicMonitorResourceId = NewRelicMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            NewRelicMonitorResource newRelicMonitorResource = client.GetNewRelicMonitorResource(newRelicMonitorResourceId);

            // get the collection of this NewRelicObservabilityTagRuleResource
            NewRelicObservabilityTagRuleCollection collection = newRelicMonitorResource.GetNewRelicObservabilityTagRules();

            // invoke the operation
            string ruleSetName = "bxcantgzggsepbhqmedjqyrqeezmfb";
            NewRelicObservabilityTagRuleData data = new NewRelicObservabilityTagRuleData();
            ArmOperation<NewRelicObservabilityTagRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, ruleSetName, data);
            NewRelicObservabilityTagRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NewRelicObservabilityTagRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
