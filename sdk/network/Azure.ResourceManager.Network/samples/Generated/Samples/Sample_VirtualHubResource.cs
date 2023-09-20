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
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_VirtualHubResource
    {
        // VirtualHubGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VirtualHubGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/VirtualHubGet.json
            // this example is just showing the usage of "VirtualHubs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // invoke the operation
            VirtualHubResource result = await virtualHub.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualHubData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualHubUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_VirtualHubUpdate()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/VirtualHubUpdateTags.json
            // this example is just showing the usage of "VirtualHubs_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub2";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // invoke the operation
            NetworkTagsObject virtualHubParameters = new NetworkTagsObject()
            {
                Tags =
{
["key1"] = "value1",
["key2"] = "value2",
},
            };
            VirtualHubResource result = await virtualHub.UpdateAsync(virtualHubParameters);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualHubData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualHubDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_VirtualHubDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/VirtualHubDelete.json
            // this example is just showing the usage of "VirtualHubs_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // invoke the operation
            await virtualHub.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // VirtualHubList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVirtualHubs_VirtualHubList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/VirtualHubList.json
            // this example is just showing the usage of "VirtualHubs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (VirtualHubResource item in subscriptionResource.GetVirtualHubsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualHubData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Effective Routes for a Connection resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVirtualHubEffectiveRoutes_EffectiveRoutesForAConnectionResource()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/EffectiveRoutesListForConnection.json
            // this example is just showing the usage of "VirtualHubs_GetEffectiveVirtualHubRoutes" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // invoke the operation
            EffectiveRoutesContent content = new EffectiveRoutesContent()
            {
                ResourceId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/resourceGroupName/providers/Microsoft.Network/expressRouteGateways/expressRouteGatewayName/expressRouteConnections/connectionName"),
                VirtualWanResourceType = "ExpressRouteConnection",
            };
            ArmOperation<VirtualHubEffectiveRouteList> lro = await virtualHub.GetVirtualHubEffectiveRoutesAsync(WaitUntil.Completed, content: content);
            VirtualHubEffectiveRouteList result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Effective Routes for a Route Table resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVirtualHubEffectiveRoutes_EffectiveRoutesForARouteTableResource()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/EffectiveRoutesListForRouteTable.json
            // this example is just showing the usage of "VirtualHubs_GetEffectiveVirtualHubRoutes" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // invoke the operation
            EffectiveRoutesContent content = new EffectiveRoutesContent()
            {
                ResourceId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/virtualHub1/hubRouteTables/hubRouteTable1"),
                VirtualWanResourceType = "RouteTable",
            };
            ArmOperation<VirtualHubEffectiveRouteList> lro = await virtualHub.GetVirtualHubEffectiveRoutesAsync(WaitUntil.Completed, content: content);
            VirtualHubEffectiveRouteList result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Effective Routes for the Virtual Hub
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVirtualHubEffectiveRoutes_EffectiveRoutesForTheVirtualHub()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/EffectiveRoutesListForVirtualHub.json
            // this example is just showing the usage of "VirtualHubs_GetEffectiveVirtualHubRoutes" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // invoke the operation
            EffectiveRoutesContent content = null;
            ArmOperation<VirtualHubEffectiveRouteList> lro = await virtualHub.GetVirtualHubEffectiveRoutesAsync(WaitUntil.Completed, content: content);
            VirtualHubEffectiveRouteList result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Inbound Routes for the Virtual Hub on a Particular Connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVirtualHubInboundRoutes_InboundRoutesForTheVirtualHubOnAParticularConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/GetInboundRoutes.json
            // this example is just showing the usage of "VirtualHubs_GetInboundRoutes" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // invoke the operation
            VirtualHubInboundRoutesContent content = new VirtualHubInboundRoutesContent()
            {
                ResourceUri = new Uri("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/expressRouteGateways/exrGw1/expressRouteConnections/exrConn1"),
                ConnectionType = "ExpressRouteConnection",
            };
            ArmOperation<EffectiveRouteMapRouteList> lro = await virtualHub.GetVirtualHubInboundRoutesAsync(WaitUntil.Completed, content);
            EffectiveRouteMapRouteList result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Outbound Routes for the Virtual Hub on a Particular Connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVirtualHubOutboundRoutes_OutboundRoutesForTheVirtualHubOnAParticularConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/GetOutboundRoutes.json
            // this example is just showing the usage of "VirtualHubs_GetOutboundRoutes" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // invoke the operation
            VirtualHubOutboundRoutesContent content = new VirtualHubOutboundRoutesContent()
            {
                ResourceUri = new Uri("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/expressRouteGateways/exrGw1/expressRouteConnections/exrConn1"),
                ConnectionType = "ExpressRouteConnection",
            };
            ArmOperation<EffectiveRouteMapRouteList> lro = await virtualHub.GetVirtualHubOutboundRoutesAsync(WaitUntil.Completed, content);
            EffectiveRouteMapRouteList result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
