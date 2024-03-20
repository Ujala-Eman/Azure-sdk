// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_LoadBalancerResource
    {
        // Delete load balancer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteLoadBalancer()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/LoadBalancerDelete.json
            // this example is just showing the usage of "LoadBalancers_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LoadBalancerResource created on azure
            // for more information of creating LoadBalancerResource, please refer to the document of LoadBalancerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string loadBalancerName = "lb";
            ResourceIdentifier loadBalancerResourceId = LoadBalancerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, loadBalancerName);
            LoadBalancerResource loadBalancer = client.GetLoadBalancerResource(loadBalancerResourceId);

            // invoke the operation
            await loadBalancer.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get load balancer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetLoadBalancer()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/LoadBalancerGet.json
            // this example is just showing the usage of "LoadBalancers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LoadBalancerResource created on azure
            // for more information of creating LoadBalancerResource, please refer to the document of LoadBalancerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string loadBalancerName = "lb";
            ResourceIdentifier loadBalancerResourceId = LoadBalancerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, loadBalancerName);
            LoadBalancerResource loadBalancer = client.GetLoadBalancerResource(loadBalancerResourceId);

            // invoke the operation
            LoadBalancerResource result = await loadBalancer.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LoadBalancerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get load balancer with inbound NAT rule port mapping
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetLoadBalancerWithInboundNATRulePortMapping()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/LoadBalancerGetInboundNatRulePortMapping.json
            // this example is just showing the usage of "LoadBalancers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LoadBalancerResource created on azure
            // for more information of creating LoadBalancerResource, please refer to the document of LoadBalancerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string loadBalancerName = "lb";
            ResourceIdentifier loadBalancerResourceId = LoadBalancerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, loadBalancerName);
            LoadBalancerResource loadBalancer = client.GetLoadBalancerResource(loadBalancerResourceId);

            // invoke the operation
            LoadBalancerResource result = await loadBalancer.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LoadBalancerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update load balancer tags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateLoadBalancerTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/LoadBalancerUpdateTags.json
            // this example is just showing the usage of "LoadBalancers_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LoadBalancerResource created on azure
            // for more information of creating LoadBalancerResource, please refer to the document of LoadBalancerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string loadBalancerName = "lb";
            ResourceIdentifier loadBalancerResourceId = LoadBalancerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, loadBalancerName);
            LoadBalancerResource loadBalancer = client.GetLoadBalancerResource(loadBalancerResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            LoadBalancerResource result = await loadBalancer.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LoadBalancerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List all load balancers
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetLoadBalancers_ListAllLoadBalancers()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/LoadBalancerListAll.json
            // this example is just showing the usage of "LoadBalancers_ListAll" operation, for the dependent resources, they will have to be created separately.

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
            await foreach (LoadBalancerResource item in subscriptionResource.GetLoadBalancersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LoadBalancerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Swap VIPs between two load balancers.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SwapPublicIPAddressesLoadBalancer_SwapVIPsBetweenTwoLoadBalancers()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/LoadBalancersSwapPublicIpAddresses.json
            // this example is just showing the usage of "LoadBalancers_SwapPublicIpAddresses" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("westus");
            LoadBalancerVipSwapContent content = new LoadBalancerVipSwapContent()
            {
                FrontendIPConfigurations =
{
new LoadBalancerVipSwapRequestFrontendIPConfiguration()
{
Id = "/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/loadBalancers/lb1/frontendIPConfigurations/lbfe1",
PublicIPAddressId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg2/providers/Microsoft.Network/publicIPAddresses/pip2"),
},new LoadBalancerVipSwapRequestFrontendIPConfiguration()
{
Id = "/subscriptions/subid/resourceGroups/rg2/providers/Microsoft.Network/loadBalancers/lb2/frontendIPConfigurations/lbfe2",
PublicIPAddressId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/publicIPAddresses/pip1"),
}
},
            };
            await subscriptionResource.SwapPublicIPAddressesLoadBalancerAsync(WaitUntil.Completed, location, content);

            Console.WriteLine($"Succeeded");
        }

        // Migrate load balancer to IP Based
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task MigrateToIPBased_MigrateLoadBalancerToIPBased()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/MigrateLoadBalancerToIPBased.json
            // this example is just showing the usage of "LoadBalancers_MigrateToIpBased" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LoadBalancerResource created on azure
            // for more information of creating LoadBalancerResource, please refer to the document of LoadBalancerResource
            string subscriptionId = "subid";
            string groupName = "rg1";
            string loadBalancerName = "lb1";
            ResourceIdentifier loadBalancerResourceId = LoadBalancerResource.CreateResourceIdentifier(subscriptionId, groupName, loadBalancerName);
            LoadBalancerResource loadBalancer = client.GetLoadBalancerResource(loadBalancerResourceId);

            // invoke the operation
            MigrateLoadBalancerToIPBasedContent content = new MigrateLoadBalancerToIPBasedContent()
            {
                Pools =
{
"pool1","pool2"
},
            };
            MigrateLoadBalancerToIPBasedResult result = await loadBalancer.MigrateToIPBasedAsync(content: content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // LoadBalancerNetworkInterfaceListSimple
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetLoadBalancerNetworkInterfaces_LoadBalancerNetworkInterfaceListSimple()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/LoadBalancerNetworkInterfaceListSimple.json
            // this example is just showing the usage of "LoadBalancerNetworkInterfaces_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LoadBalancerResource created on azure
            // for more information of creating LoadBalancerResource, please refer to the document of LoadBalancerResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string loadBalancerName = "lb";
            ResourceIdentifier loadBalancerResourceId = LoadBalancerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, loadBalancerName);
            LoadBalancerResource loadBalancer = client.GetLoadBalancerResource(loadBalancerResourceId);

            // invoke the operation and iterate over the result
            await foreach (NetworkInterfaceResource item in loadBalancer.GetLoadBalancerNetworkInterfacesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkInterfaceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // LoadBalancerNetworkInterfaceListVmss
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetLoadBalancerNetworkInterfaces_LoadBalancerNetworkInterfaceListVmss()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/LoadBalancerNetworkInterfaceListVmss.json
            // this example is just showing the usage of "LoadBalancerNetworkInterfaces_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LoadBalancerResource created on azure
            // for more information of creating LoadBalancerResource, please refer to the document of LoadBalancerResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string loadBalancerName = "lb";
            ResourceIdentifier loadBalancerResourceId = LoadBalancerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, loadBalancerName);
            LoadBalancerResource loadBalancer = client.GetLoadBalancerResource(loadBalancerResourceId);

            // invoke the operation and iterate over the result
            await foreach (NetworkInterfaceResource item in loadBalancer.GetLoadBalancerNetworkInterfacesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkInterfaceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
