// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_BgpConnectionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_VirtualHubVirtualHubRouteTableV2Get()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualHubBgpConnectionGet.json
            // this example is just showing the usage of "VirtualHubBgpConnection_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "hub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // get the collection of this BgpConnectionResource
            BgpConnectionCollection collection = virtualHub.GetBgpConnections();

            // invoke the operation
            string connectionName = "conn1";
            BgpConnectionResource result = await collection.GetAsync(connectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BgpConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_VirtualHubVirtualHubRouteTableV2Get()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualHubBgpConnectionGet.json
            // this example is just showing the usage of "VirtualHubBgpConnection_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "hub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // get the collection of this BgpConnectionResource
            BgpConnectionCollection collection = virtualHub.GetBgpConnections();

            // invoke the operation
            string connectionName = "conn1";
            bool result = await collection.ExistsAsync(connectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_VirtualHubVirtualHubRouteTableV2Get()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualHubBgpConnectionGet.json
            // this example is just showing the usage of "VirtualHubBgpConnection_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "hub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // get the collection of this BgpConnectionResource
            BgpConnectionCollection collection = virtualHub.GetBgpConnections();

            // invoke the operation
            string connectionName = "conn1";
            NullableResponse<BgpConnectionResource> response = await collection.GetIfExistsAsync(connectionName);
            BgpConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BgpConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_VirtualHubRouteTableV2Put()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualHubBgpConnectionPut.json
            // this example is just showing the usage of "VirtualHubBgpConnection_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "hub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // get the collection of this BgpConnectionResource
            BgpConnectionCollection collection = virtualHub.GetBgpConnections();

            // invoke the operation
            string connectionName = "conn1";
            BgpConnectionData data = new BgpConnectionData()
            {
                PeerAsn = 20000L,
                PeerIP = "192.168.1.5",
                HubVirtualNetworkConnectionId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/hub1/hubVirtualNetworkConnections/hubVnetConn1"),
            };
            ArmOperation<BgpConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, connectionName, data);
            BgpConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BgpConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_VirtualHubRouteTableV2List()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualHubBgpConnectionList.json
            // this example is just showing the usage of "VirtualHubBgpConnections_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "hub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // get the collection of this BgpConnectionResource
            BgpConnectionCollection collection = virtualHub.GetBgpConnections();

            // invoke the operation and iterate over the result
            await foreach (BgpConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BgpConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
