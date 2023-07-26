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
    public partial class Sample_RouteResource
    {
        // Delete route
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteRoute()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/RouteTableRouteDelete.json
            // this example is just showing the usage of "Routes_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RouteResource created on azure
            // for more information of creating RouteResource, please refer to the document of RouteResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string routeTableName = "testrt";
            string routeName = "route1";
            ResourceIdentifier routeResourceId = RouteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, routeTableName, routeName);
            RouteResource route = client.GetRouteResource(routeResourceId);

            // invoke the operation
            await route.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get route
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRoute()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/RouteTableRouteGet.json
            // this example is just showing the usage of "Routes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RouteResource created on azure
            // for more information of creating RouteResource, please refer to the document of RouteResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string routeTableName = "testrt";
            string routeName = "route1";
            ResourceIdentifier routeResourceId = RouteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, routeTableName, routeName);
            RouteResource route = client.GetRouteResource(routeResourceId);

            // invoke the operation
            RouteResource result = await route.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RouteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create route
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateRoute()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/RouteTableRouteCreate.json
            // this example is just showing the usage of "Routes_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RouteResource created on azure
            // for more information of creating RouteResource, please refer to the document of RouteResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string routeTableName = "testrt";
            string routeName = "route1";
            ResourceIdentifier routeResourceId = RouteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, routeTableName, routeName);
            RouteResource route = client.GetRouteResource(routeResourceId);

            // invoke the operation
            RouteData data = new RouteData()
            {
                AddressPrefix = "10.0.3.0/24",
                NextHopType = RouteNextHopType.VirtualNetworkGateway,
            };
            ArmOperation<RouteResource> lro = await route.UpdateAsync(WaitUntil.Completed, data);
            RouteResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RouteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
