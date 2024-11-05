// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ConnectionMonitorResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetConnectionMonitor()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherConnectionMonitorGet.json
            // this example is just showing the usage of "ConnectionMonitors_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConnectionMonitorResource created on azure
            // for more information of creating ConnectionMonitorResource, please refer to the document of ConnectionMonitorResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            string connectionMonitorName = "cm1";
            ResourceIdentifier connectionMonitorResourceId = ConnectionMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName, connectionMonitorName);
            ConnectionMonitorResource connectionMonitor = client.GetConnectionMonitorResource(connectionMonitorResourceId);

            // invoke the operation
            ConnectionMonitorResource result = await connectionMonitor.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConnectionMonitorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteConnectionMonitor()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherConnectionMonitorDelete.json
            // this example is just showing the usage of "ConnectionMonitors_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConnectionMonitorResource created on azure
            // for more information of creating ConnectionMonitorResource, please refer to the document of ConnectionMonitorResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            string connectionMonitorName = "cm1";
            ResourceIdentifier connectionMonitorResourceId = ConnectionMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName, connectionMonitorName);
            ConnectionMonitorResource connectionMonitor = client.GetConnectionMonitorResource(connectionMonitorResourceId);

            // invoke the operation
            await connectionMonitor.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateConnectionMonitorTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherConnectionMonitorUpdateTags.json
            // this example is just showing the usage of "ConnectionMonitors_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConnectionMonitorResource created on azure
            // for more information of creating ConnectionMonitorResource, please refer to the document of ConnectionMonitorResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            string connectionMonitorName = "cm1";
            ResourceIdentifier connectionMonitorResourceId = ConnectionMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName, connectionMonitorName);
            ConnectionMonitorResource connectionMonitor = client.GetConnectionMonitorResource(connectionMonitorResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2"
},
            };
            ConnectionMonitorResource result = await connectionMonitor.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConnectionMonitorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Stop_StopConnectionMonitor()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherConnectionMonitorStop.json
            // this example is just showing the usage of "ConnectionMonitors_Stop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConnectionMonitorResource created on azure
            // for more information of creating ConnectionMonitorResource, please refer to the document of ConnectionMonitorResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            string connectionMonitorName = "cm1";
            ResourceIdentifier connectionMonitorResourceId = ConnectionMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName, connectionMonitorName);
            ConnectionMonitorResource connectionMonitor = client.GetConnectionMonitorResource(connectionMonitorResourceId);

            // invoke the operation
            await connectionMonitor.StopAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Start_StartConnectionMonitor()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherConnectionMonitorStart.json
            // this example is just showing the usage of "ConnectionMonitors_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConnectionMonitorResource created on azure
            // for more information of creating ConnectionMonitorResource, please refer to the document of ConnectionMonitorResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            string connectionMonitorName = "cm1";
            ResourceIdentifier connectionMonitorResourceId = ConnectionMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName, connectionMonitorName);
            ConnectionMonitorResource connectionMonitor = client.GetConnectionMonitorResource(connectionMonitorResourceId);

            // invoke the operation
            await connectionMonitor.StartAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Query_QueryConnectionMonitor()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherConnectionMonitorQuery.json
            // this example is just showing the usage of "ConnectionMonitors_Query" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConnectionMonitorResource created on azure
            // for more information of creating ConnectionMonitorResource, please refer to the document of ConnectionMonitorResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            string connectionMonitorName = "cm1";
            ResourceIdentifier connectionMonitorResourceId = ConnectionMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName, connectionMonitorName);
            ConnectionMonitorResource connectionMonitor = client.GetConnectionMonitorResource(connectionMonitorResourceId);

            // invoke the operation
            ArmOperation<ConnectionMonitorQueryResult> lro = await connectionMonitor.QueryAsync(WaitUntil.Completed);
            ConnectionMonitorQueryResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
