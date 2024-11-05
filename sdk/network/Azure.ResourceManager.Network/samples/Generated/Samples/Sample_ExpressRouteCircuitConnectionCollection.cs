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
    public partial class Sample_ExpressRouteCircuitConnectionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ExpressRouteCircuitConnectionCreate()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ExpressRouteCircuitConnectionCreate.json
            // this example is just showing the usage of "ExpressRouteCircuitConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCircuitPeeringResource created on azure
            // for more information of creating ExpressRouteCircuitPeeringResource, please refer to the document of ExpressRouteCircuitPeeringResource
            string subscriptionId = "subid1";
            string resourceGroupName = "rg1";
            string circuitName = "ExpressRouteARMCircuitA";
            string peeringName = "AzurePrivatePeering";
            ResourceIdentifier expressRouteCircuitPeeringResourceId = ExpressRouteCircuitPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, circuitName, peeringName);
            ExpressRouteCircuitPeeringResource expressRouteCircuitPeering = client.GetExpressRouteCircuitPeeringResource(expressRouteCircuitPeeringResourceId);

            // get the collection of this ExpressRouteCircuitConnectionResource
            ExpressRouteCircuitConnectionCollection collection = expressRouteCircuitPeering.GetExpressRouteCircuitConnections();

            // invoke the operation
            string connectionName = "circuitConnectionUSAUS";
            ExpressRouteCircuitConnectionData data = new ExpressRouteCircuitConnectionData
            {
                ExpressRouteCircuitPeeringId = new ResourceIdentifier("/subscriptions/subid1/resourceGroups/dedharcktinit/providers/Microsoft.Network/expressRouteCircuits/dedharcktlocal/peerings/AzurePrivatePeering"),
                PeerExpressRouteCircuitPeeringId = new ResourceIdentifier("/subscriptions/subid2/resourceGroups/dedharcktpeer/providers/Microsoft.Network/expressRouteCircuits/dedharcktremote/peerings/AzurePrivatePeering"),
                AddressPrefix = "10.0.0.0/29",
                AuthorizationKey = "946a1918-b7a2-4917-b43c-8c4cdaee006a",
                IPv6CircuitConnectionConfig = new IPv6CircuitConnectionConfig
                {
                    AddressPrefix = "aa:bb::/125",
                },
            };
            ArmOperation<ExpressRouteCircuitConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, connectionName, data);
            ExpressRouteCircuitConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteCircuitConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ExpressRouteCircuitConnectionGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ExpressRouteCircuitConnectionGet.json
            // this example is just showing the usage of "ExpressRouteCircuitConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCircuitPeeringResource created on azure
            // for more information of creating ExpressRouteCircuitPeeringResource, please refer to the document of ExpressRouteCircuitPeeringResource
            string subscriptionId = "subid1";
            string resourceGroupName = "rg1";
            string circuitName = "ExpressRouteARMCircuitA";
            string peeringName = "AzurePrivatePeering";
            ResourceIdentifier expressRouteCircuitPeeringResourceId = ExpressRouteCircuitPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, circuitName, peeringName);
            ExpressRouteCircuitPeeringResource expressRouteCircuitPeering = client.GetExpressRouteCircuitPeeringResource(expressRouteCircuitPeeringResourceId);

            // get the collection of this ExpressRouteCircuitConnectionResource
            ExpressRouteCircuitConnectionCollection collection = expressRouteCircuitPeering.GetExpressRouteCircuitConnections();

            // invoke the operation
            string connectionName = "circuitConnectionUSAUS";
            ExpressRouteCircuitConnectionResource result = await collection.GetAsync(connectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteCircuitConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListExpressRouteCircuitConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ExpressRouteCircuitConnectionList.json
            // this example is just showing the usage of "ExpressRouteCircuitConnections_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCircuitPeeringResource created on azure
            // for more information of creating ExpressRouteCircuitPeeringResource, please refer to the document of ExpressRouteCircuitPeeringResource
            string subscriptionId = "subid1";
            string resourceGroupName = "rg1";
            string circuitName = "ExpressRouteARMCircuitA";
            string peeringName = "AzurePrivatePeering";
            ResourceIdentifier expressRouteCircuitPeeringResourceId = ExpressRouteCircuitPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, circuitName, peeringName);
            ExpressRouteCircuitPeeringResource expressRouteCircuitPeering = client.GetExpressRouteCircuitPeeringResource(expressRouteCircuitPeeringResourceId);

            // get the collection of this ExpressRouteCircuitConnectionResource
            ExpressRouteCircuitConnectionCollection collection = expressRouteCircuitPeering.GetExpressRouteCircuitConnections();

            // invoke the operation and iterate over the result
            await foreach (ExpressRouteCircuitConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExpressRouteCircuitConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ExpressRouteCircuitConnectionGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ExpressRouteCircuitConnectionGet.json
            // this example is just showing the usage of "ExpressRouteCircuitConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCircuitPeeringResource created on azure
            // for more information of creating ExpressRouteCircuitPeeringResource, please refer to the document of ExpressRouteCircuitPeeringResource
            string subscriptionId = "subid1";
            string resourceGroupName = "rg1";
            string circuitName = "ExpressRouteARMCircuitA";
            string peeringName = "AzurePrivatePeering";
            ResourceIdentifier expressRouteCircuitPeeringResourceId = ExpressRouteCircuitPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, circuitName, peeringName);
            ExpressRouteCircuitPeeringResource expressRouteCircuitPeering = client.GetExpressRouteCircuitPeeringResource(expressRouteCircuitPeeringResourceId);

            // get the collection of this ExpressRouteCircuitConnectionResource
            ExpressRouteCircuitConnectionCollection collection = expressRouteCircuitPeering.GetExpressRouteCircuitConnections();

            // invoke the operation
            string connectionName = "circuitConnectionUSAUS";
            bool result = await collection.ExistsAsync(connectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ExpressRouteCircuitConnectionGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ExpressRouteCircuitConnectionGet.json
            // this example is just showing the usage of "ExpressRouteCircuitConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCircuitPeeringResource created on azure
            // for more information of creating ExpressRouteCircuitPeeringResource, please refer to the document of ExpressRouteCircuitPeeringResource
            string subscriptionId = "subid1";
            string resourceGroupName = "rg1";
            string circuitName = "ExpressRouteARMCircuitA";
            string peeringName = "AzurePrivatePeering";
            ResourceIdentifier expressRouteCircuitPeeringResourceId = ExpressRouteCircuitPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, circuitName, peeringName);
            ExpressRouteCircuitPeeringResource expressRouteCircuitPeering = client.GetExpressRouteCircuitPeeringResource(expressRouteCircuitPeeringResourceId);

            // get the collection of this ExpressRouteCircuitConnectionResource
            ExpressRouteCircuitConnectionCollection collection = expressRouteCircuitPeering.GetExpressRouteCircuitConnections();

            // invoke the operation
            string connectionName = "circuitConnectionUSAUS";
            NullableResponse<ExpressRouteCircuitConnectionResource> response = await collection.GetIfExistsAsync(connectionName);
            ExpressRouteCircuitConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExpressRouteCircuitConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
