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
using Azure.ResourceManager.CostManagement;
using Azure.ResourceManager.CostManagement.Models;

namespace Azure.ResourceManager.CostManagement.Samples
{
    public partial class Sample_ScheduledActionCollection
    {
        // ScheduledActionsListByScope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ScheduledActionsListByScope()
        {
            // Generated from example definition: specification/cost-management/resource-manager/Microsoft.CostManagement/stable/2023-03-01/examples/scheduledActions/scheduledActions-list-shared.json
            // this example is just showing the usage of "ScheduledActions_ListByScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ScheduledActionResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ScheduledActionCollection collection = client.GetScheduledActions(scopeId);

            // invoke the operation and iterate over the result
            await foreach (ScheduledActionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ScheduledActionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ScheduledActionsListByScopeFilterByViewId
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ScheduledActionsListByScopeFilterByViewId()
        {
            // Generated from example definition: specification/cost-management/resource-manager/Microsoft.CostManagement/stable/2023-03-01/examples/scheduledActions/scheduledActions-listWithFilter-shared.json
            // this example is just showing the usage of "ScheduledActions_ListByScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ScheduledActionResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ScheduledActionCollection collection = client.GetScheduledActions(scopeId);

            // invoke the operation and iterate over the result
            string filter = "properties/viewId eq '/providers/Microsoft.CostManagement/views/swaggerExample'";
            await foreach (ScheduledActionResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ScheduledActionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CreateOrUpdateInsightAlertScheduledActionByScope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateInsightAlertScheduledActionByScope()
        {
            // Generated from example definition: specification/cost-management/resource-manager/Microsoft.CostManagement/stable/2023-03-01/examples/scheduledActions/scheduledAction-insightAlert-createOrUpdate-shared.json
            // this example is just showing the usage of "ScheduledActions_CreateOrUpdateByScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ScheduledActionResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ScheduledActionCollection collection = client.GetScheduledActions(scopeId);

            // invoke the operation
            string name = "dailyAnomalyByResource";
            ScheduledActionData data = new ScheduledActionData()
            {
                DisplayName = "Daily anomaly by resource",
                Notification = new NotificationProperties(new string[]
            {
"user@gmail.com","team@gmail.com"
            }, "Cost anomaly detected in the resource"),
                Schedule = new ScheduleProperties(ScheduleFrequency.Daily, DateTimeOffset.Parse("2020-06-19T22:21:51.1287144Z"), DateTimeOffset.Parse("2021-06-19T22:21:51.1287144Z")),
                Status = ScheduledActionStatus.Enabled,
                ViewId = new ResourceIdentifier("/providers/Microsoft.CostManagement/views/swaggerExample"),
                Kind = ScheduledActionKind.InsightAlert,
            };
            string ifMatch = "";
            ArmOperation<ScheduledActionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data, ifMatch: ifMatch);
            ScheduledActionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScheduledActionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CreateOrUpdateScheduledActionByScope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateScheduledActionByScope()
        {
            // Generated from example definition: specification/cost-management/resource-manager/Microsoft.CostManagement/stable/2023-03-01/examples/scheduledActions/scheduledAction-createOrUpdate-shared.json
            // this example is just showing the usage of "ScheduledActions_CreateOrUpdateByScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ScheduledActionResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ScheduledActionCollection collection = client.GetScheduledActions(scopeId);

            // invoke the operation
            string name = "monthlyCostByResource";
            ScheduledActionData data = new ScheduledActionData()
            {
                DisplayName = "Monthly Cost By Resource",
                FileFormats =
{
ScheduledActionFileFormat.Csv
},
                Notification = new NotificationProperties(new string[]
            {
"user@gmail.com","team@gmail.com"
            }, "Cost by resource this month"),
                Schedule = new ScheduleProperties(ScheduleFrequency.Monthly, DateTimeOffset.Parse("2020-06-19T22:21:51.1287144Z"), DateTimeOffset.Parse("2021-06-19T22:21:51.1287144Z"))
                {
                    HourOfDay = 10,
                    DaysOfWeek =
{
ScheduledActionDaysOfWeek.Monday
},
                    WeeksOfMonth =
{
ScheduledActionWeeksOfMonth.First,ScheduledActionWeeksOfMonth.Third
},
                },
                Status = ScheduledActionStatus.Enabled,
                ViewId = new ResourceIdentifier("/providers/Microsoft.CostManagement/views/swaggerExample"),
                Kind = ScheduledActionKind.Email,
            };
            string ifMatch = "";
            ArmOperation<ScheduledActionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data, ifMatch: ifMatch);
            ScheduledActionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScheduledActionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ScheduledActionByScope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ScheduledActionByScope()
        {
            // Generated from example definition: specification/cost-management/resource-manager/Microsoft.CostManagement/stable/2023-03-01/examples/scheduledActions/scheduledAction-get-shared.json
            // this example is just showing the usage of "ScheduledActions_GetByScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ScheduledActionResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ScheduledActionCollection collection = client.GetScheduledActions(scopeId);

            // invoke the operation
            string name = "monthlyCostByResource";
            ScheduledActionResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScheduledActionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ScheduledActionByScope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ScheduledActionByScope()
        {
            // Generated from example definition: specification/cost-management/resource-manager/Microsoft.CostManagement/stable/2023-03-01/examples/scheduledActions/scheduledAction-get-shared.json
            // this example is just showing the usage of "ScheduledActions_GetByScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ScheduledActionResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ScheduledActionCollection collection = client.GetScheduledActions(scopeId);

            // invoke the operation
            string name = "monthlyCostByResource";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ScheduledActionByScope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ScheduledActionByScope()
        {
            // Generated from example definition: specification/cost-management/resource-manager/Microsoft.CostManagement/stable/2023-03-01/examples/scheduledActions/scheduledAction-get-shared.json
            // this example is just showing the usage of "ScheduledActions_GetByScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ScheduledActionResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ScheduledActionCollection collection = client.GetScheduledActions(scopeId);

            // invoke the operation
            string name = "monthlyCostByResource";
            NullableResponse<ScheduledActionResource> response = await collection.GetIfExistsAsync(name);
            ScheduledActionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ScheduledActionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
