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
    public partial class Sample_IPAllocationResource
    {
        // Delete IpAllocation
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteIpAllocation()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/IpAllocationDelete.json
            // this example is just showing the usage of "IpAllocations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IPAllocationResource created on azure
            // for more information of creating IPAllocationResource, please refer to the document of IPAllocationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string ipAllocationName = "test-ipallocation";
            ResourceIdentifier ipAllocationResourceId = IPAllocationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ipAllocationName);
            IPAllocationResource ipAllocation = client.GetIPAllocationResource(ipAllocationResourceId);

            // invoke the operation
            await ipAllocation.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get IpAllocation
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetIpAllocation()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/IpAllocationGet.json
            // this example is just showing the usage of "IpAllocations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IPAllocationResource created on azure
            // for more information of creating IPAllocationResource, please refer to the document of IPAllocationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string ipAllocationName = "test-ipallocation";
            ResourceIdentifier ipAllocationResourceId = IPAllocationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ipAllocationName);
            IPAllocationResource ipAllocation = client.GetIPAllocationResource(ipAllocationResourceId);

            // invoke the operation
            IPAllocationResource result = await ipAllocation.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IPAllocationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update virtual network tags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateVirtualNetworkTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/IpAllocationUpdateTags.json
            // this example is just showing the usage of "IpAllocations_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IPAllocationResource created on azure
            // for more information of creating IPAllocationResource, please refer to the document of IPAllocationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string ipAllocationName = "test-ipallocation";
            ResourceIdentifier ipAllocationResourceId = IPAllocationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ipAllocationName);
            IPAllocationResource ipAllocation = client.GetIPAllocationResource(ipAllocationResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            IPAllocationResource result = await ipAllocation.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IPAllocationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List all IpAllocations
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIPAllocations_ListAllIpAllocations()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/IpAllocationList.json
            // this example is just showing the usage of "IpAllocations_List" operation, for the dependent resources, they will have to be created separately.

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
            await foreach (IPAllocationResource item in subscriptionResource.GetIPAllocationsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                IPAllocationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
