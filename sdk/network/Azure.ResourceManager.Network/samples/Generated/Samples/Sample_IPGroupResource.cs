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
    public partial class Sample_IPGroupResource
    {
        // Get_IpGroups
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetIpGroups()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/IpGroupsGet.json
            // this example is just showing the usage of "IpGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IPGroupResource created on azure
            // for more information of creating IPGroupResource, please refer to the document of IPGroupResource
            string subscriptionId = "subId";
            string resourceGroupName = "myResourceGroup";
            string ipGroupsName = "ipGroups1";
            ResourceIdentifier ipGroupResourceId = IPGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ipGroupsName);
            IPGroupResource ipGroup = client.GetIPGroupResource(ipGroupResourceId);

            // invoke the operation
            IPGroupResource result = await ipGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IPGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update_IpGroups
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateIpGroups()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/IpGroupsUpdateTags.json
            // this example is just showing the usage of "IpGroups_UpdateGroups" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IPGroupResource created on azure
            // for more information of creating IPGroupResource, please refer to the document of IPGroupResource
            string subscriptionId = "subId";
            string resourceGroupName = "myResourceGroup";
            string ipGroupsName = "ipGroups1";
            ResourceIdentifier ipGroupResourceId = IPGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ipGroupsName);
            IPGroupResource ipGroup = client.GetIPGroupResource(ipGroupResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject()
            {
                Tags =
{
["key1"] = "value1",
["key2"] = "value2",
},
            };
            IPGroupResource result = await ipGroup.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IPGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete_IpGroups
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteIpGroups()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/IpGroupsDelete.json
            // this example is just showing the usage of "IpGroups_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IPGroupResource created on azure
            // for more information of creating IPGroupResource, please refer to the document of IPGroupResource
            string subscriptionId = "subId";
            string resourceGroupName = "myResourceGroup";
            string ipGroupsName = "ipGroups1";
            ResourceIdentifier ipGroupResourceId = IPGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ipGroupsName);
            IPGroupResource ipGroup = client.GetIPGroupResource(ipGroupResourceId);

            // invoke the operation
            await ipGroup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // List_IpGroups
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIPGroups_ListIpGroups()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/IpGroupsListBySubscription.json
            // this example is just showing the usage of "IpGroups_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subId";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (IPGroupResource item in subscriptionResource.GetIPGroupsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                IPGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
