// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Workloads.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Workloads.Samples
{
    public partial class Sample_SapLandscapeMonitorResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPropertiesOfASAPMonitor()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/workloadmonitor/SapLandscapeMonitor_Get.json
            // this example is just showing the usage of "SapLandscapeMonitor_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapLandscapeMonitorResource created on azure
            // for more information of creating SapLandscapeMonitorResource, please refer to the document of SapLandscapeMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "mySapMonitor";
            ResourceIdentifier sapLandscapeMonitorResourceId = SapLandscapeMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            SapLandscapeMonitorResource sapLandscapeMonitor = client.GetSapLandscapeMonitorResource(sapLandscapeMonitorResourceId);

            // invoke the operation
            SapLandscapeMonitorResource result = await sapLandscapeMonitor.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SapLandscapeMonitorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateForSAPLandscapeMonitorDashboard()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/workloadmonitor/SapLandscapeMonitor_Create.json
            // this example is just showing the usage of "SapLandscapeMonitor_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapLandscapeMonitorResource created on azure
            // for more information of creating SapLandscapeMonitorResource, please refer to the document of SapLandscapeMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "mySapMonitor";
            ResourceIdentifier sapLandscapeMonitorResourceId = SapLandscapeMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            SapLandscapeMonitorResource sapLandscapeMonitor = client.GetSapLandscapeMonitorResource(sapLandscapeMonitorResourceId);

            // invoke the operation
            SapLandscapeMonitorData data = new SapLandscapeMonitorData()
            {
                Grouping = new SapLandscapeMonitorPropertiesGrouping()
                {
                    Landscape =
{
new SapLandscapeMonitorSidMapping()
{
Name = "Prod",
TopSid =
{
"SID1","SID2"
},
}
},
                    SapApplication =
{
new SapLandscapeMonitorSidMapping()
{
Name = "ERP1",
TopSid =
{
"SID1","SID2"
},
}
},
                },
                TopMetricsThresholds =
{
new SapLandscapeMonitorMetricThresholds()
{
Name = "Instance Availability",
Green = 90,
Yellow = 75,
Red = 50,
}
},
            };
            ArmOperation<SapLandscapeMonitorResource> lro = await sapLandscapeMonitor.CreateOrUpdateAsync(WaitUntil.Completed, data);
            SapLandscapeMonitorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SapLandscapeMonitorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeletesSAPMonitor()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/workloadmonitor/SapLandscapeMonitor_Delete.json
            // this example is just showing the usage of "SapLandscapeMonitor_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapLandscapeMonitorResource created on azure
            // for more information of creating SapLandscapeMonitorResource, please refer to the document of SapLandscapeMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "mySapMonitor";
            ResourceIdentifier sapLandscapeMonitorResourceId = SapLandscapeMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            SapLandscapeMonitorResource sapLandscapeMonitor = client.GetSapLandscapeMonitorResource(sapLandscapeMonitorResourceId);

            // invoke the operation
            await sapLandscapeMonitor.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateSAPMonitor()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/workloadmonitor/SapLandscapeMonitor_Update.json
            // this example is just showing the usage of "SapLandscapeMonitor_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapLandscapeMonitorResource created on azure
            // for more information of creating SapLandscapeMonitorResource, please refer to the document of SapLandscapeMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "mySapMonitor";
            ResourceIdentifier sapLandscapeMonitorResourceId = SapLandscapeMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            SapLandscapeMonitorResource sapLandscapeMonitor = client.GetSapLandscapeMonitorResource(sapLandscapeMonitorResourceId);

            // invoke the operation
            SapLandscapeMonitorData data = new SapLandscapeMonitorData()
            {
                Grouping = new SapLandscapeMonitorPropertiesGrouping()
                {
                    Landscape =
{
new SapLandscapeMonitorSidMapping()
{
Name = "Prod",
TopSid =
{
"SID1","SID2"
},
}
},
                    SapApplication =
{
new SapLandscapeMonitorSidMapping()
{
Name = "ERP1",
TopSid =
{
"SID1","SID2"
},
}
},
                },
                TopMetricsThresholds =
{
new SapLandscapeMonitorMetricThresholds()
{
Name = "Instance Availability",
Green = 90,
Yellow = 75,
Red = 50,
}
},
            };
            SapLandscapeMonitorResource result = await sapLandscapeMonitor.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SapLandscapeMonitorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
