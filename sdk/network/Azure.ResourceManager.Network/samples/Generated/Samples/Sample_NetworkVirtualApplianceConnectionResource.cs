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

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_NetworkVirtualApplianceConnectionResource
    {
        // NetworkVirtualApplianceConnectionPut
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_NetworkVirtualApplianceConnectionPut()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/NetworkVirtualApplianceConnectionPut.json
            // this example is just showing the usage of "NetworkVirtualApplianceConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceConnectionResource created on azure
            // for more information of creating NetworkVirtualApplianceConnectionResource, please refer to the document of NetworkVirtualApplianceConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva1";
            string connectionName = "connection1";
            ResourceIdentifier networkVirtualApplianceConnectionResourceId = NetworkVirtualApplianceConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName, connectionName);
            NetworkVirtualApplianceConnectionResource networkVirtualApplianceConnection = client.GetNetworkVirtualApplianceConnectionResource(networkVirtualApplianceConnectionResourceId);

            // invoke the operation
            NetworkVirtualApplianceConnectionData data = new NetworkVirtualApplianceConnectionData()
            {
                NamePropertiesName = "connection1",
                Asn = 64512,
                TunnelIdentifier = 0,
                BgpPeerAddress =
{
"169.254.16.13","169.254.16.14"
},
                EnableInternetSecurity = false,
                RoutingConfiguration = new RoutingConfigurationNfv()
                {
                    AssociatedRouteTableResourceUri = new Uri("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/virtualHub1/hubRouteTables/hubRouteTable1"),
                    PropagatedRouteTables = new PropagatedRouteTableNfv()
                    {
                        Labels =
{
"label1"
},
                        Ids =
{
new RoutingConfigurationNfvSubResource()
{
ResourceUri = new Uri("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/virtualHub1/hubRouteTables/hubRouteTable1"),
}
},
                    },
                    InboundRouteMapResourceUri = new Uri("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/virtualHub1/routeMaps/routeMap1"),
                    OutboundRouteMapResourceUri = new Uri("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/virtualHub1/routeMaps/routeMap2"),
                },
                Name = "connection1",
            };
            ArmOperation<NetworkVirtualApplianceConnectionResource> lro = await networkVirtualApplianceConnection.UpdateAsync(WaitUntil.Completed, data);
            NetworkVirtualApplianceConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkVirtualApplianceConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NetworkVirtualApplianceConnectionGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NetworkVirtualApplianceConnectionGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/NetworkVirtualApplianceConnectionGet.json
            // this example is just showing the usage of "NetworkVirtualApplianceConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceConnectionResource created on azure
            // for more information of creating NetworkVirtualApplianceConnectionResource, please refer to the document of NetworkVirtualApplianceConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva1";
            string connectionName = "connection1";
            ResourceIdentifier networkVirtualApplianceConnectionResourceId = NetworkVirtualApplianceConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName, connectionName);
            NetworkVirtualApplianceConnectionResource networkVirtualApplianceConnection = client.GetNetworkVirtualApplianceConnectionResource(networkVirtualApplianceConnectionResourceId);

            // invoke the operation
            NetworkVirtualApplianceConnectionResource result = await networkVirtualApplianceConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkVirtualApplianceConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NetworkVirtualApplianceConnectionDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_NetworkVirtualApplianceConnectionDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/NetworkVirtualApplianceConnectionDelete.json
            // this example is just showing the usage of "NetworkVirtualApplianceConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceConnectionResource created on azure
            // for more information of creating NetworkVirtualApplianceConnectionResource, please refer to the document of NetworkVirtualApplianceConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva1";
            string connectionName = "connection1";
            ResourceIdentifier networkVirtualApplianceConnectionResourceId = NetworkVirtualApplianceConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName, connectionName);
            NetworkVirtualApplianceConnectionResource networkVirtualApplianceConnection = client.GetNetworkVirtualApplianceConnectionResource(networkVirtualApplianceConnectionResourceId);

            // invoke the operation
            await networkVirtualApplianceConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
