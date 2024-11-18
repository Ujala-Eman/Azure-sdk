// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.ManagedNetworkFabric.Samples
{
    public partial class Sample_NetworkRackResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_NetworkRacksGetMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkRacks_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkRacks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkRackResource created on azure
            // for more information of creating NetworkRackResource, please refer to the document of NetworkRackResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkRackName = "example-rack";
            ResourceIdentifier networkRackResourceId = NetworkRackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkRackName);
            NetworkRackResource networkRack = client.GetNetworkRackResource(networkRackResourceId);

            // invoke the operation
            NetworkRackResource result = await networkRack.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkRackData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_NetworkRacksUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkRacks_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkRacks_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkRackResource created on azure
            // for more information of creating NetworkRackResource, please refer to the document of NetworkRackResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkRackName = "example-rack";
            ResourceIdentifier networkRackResourceId = NetworkRackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkRackName);
            NetworkRackResource networkRack = client.GetNetworkRackResource(networkRackResourceId);

            // invoke the operation
            NetworkRackPatch patch = new NetworkRackPatch()
            {
                Tags =
{
["keyID"] = "keyValue",
},
            };
            ArmOperation<NetworkRackResource> lro = await networkRack.UpdateAsync(WaitUntil.Completed, patch);
            NetworkRackResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkRackData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_NetworkRacksDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkRacks_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkRacks_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkRackResource created on azure
            // for more information of creating NetworkRackResource, please refer to the document of NetworkRackResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkRackName = "example-rack";
            ResourceIdentifier networkRackResourceId = NetworkRackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkRackName);
            NetworkRackResource networkRack = client.GetNetworkRackResource(networkRackResourceId);

            // invoke the operation
            await networkRack.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetNetworkRacks_NetworkRacksListBySubscriptionMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkRacks_ListBySubscription_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkRacks_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (NetworkRackResource item in subscriptionResource.GetNetworkRacksAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkRackData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
