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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.ao5gc;
using Azure.ResourceManager.ao5gc.Models;

namespace Azure.ResourceManager.ao5gc.Samples
{
    public partial class Sample_NetworkFunctionResource
    {
        // NetworkFunctions_ListBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetNetworkFunctionResources_NetworkFunctionsListBySubscription()
        {
            // Generated from example definition: specification/mpcnetworkfunction/resource-manager/Microsoft.MobilePacketCore/preview/2023-05-15-preview/examples/NetworkFunctions_ListBySubscription.json
            // this example is just showing the usage of "NetworkFunctions_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (NetworkFunctionResource item in subscriptionResource.GetNetworkFunctionResourcesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkFunctionResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // NetworkFunctions_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NetworkFunctionsGet()
        {
            // Generated from example definition: specification/mpcnetworkfunction/resource-manager/Microsoft.MobilePacketCore/preview/2023-05-15-preview/examples/NetworkFunctions_Get.json
            // this example is just showing the usage of "NetworkFunctions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionResource created on azure
            // for more information of creating NetworkFunctionResource, please refer to the document of NetworkFunctionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkFunctionName = "nf1";
            ResourceIdentifier networkFunctionResourceId = NetworkFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFunctionName);
            NetworkFunctionResource networkFunctionResource = client.GetNetworkFunctionResource(networkFunctionResourceId);

            // invoke the operation
            NetworkFunctionResource result = await networkFunctionResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFunctionResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NetworkFunctions_UpdateTags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_NetworkFunctionsUpdateTags()
        {
            // Generated from example definition: specification/mpcnetworkfunction/resource-manager/Microsoft.MobilePacketCore/preview/2023-05-15-preview/examples/NetworkFunctions_UpdateTags.json
            // this example is just showing the usage of "NetworkFunctions_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionResource created on azure
            // for more information of creating NetworkFunctionResource, please refer to the document of NetworkFunctionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkFunctionName = "nf1";
            ResourceIdentifier networkFunctionResourceId = NetworkFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFunctionName);
            NetworkFunctionResource networkFunctionResource = client.GetNetworkFunctionResource(networkFunctionResourceId);

            // invoke the operation
            NetworkFunctionResourcePatch patch = new NetworkFunctionResourcePatch()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            NetworkFunctionResource result = await networkFunctionResource.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFunctionResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NetworkFunctions_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_NetworkFunctionsDelete()
        {
            // Generated from example definition: specification/mpcnetworkfunction/resource-manager/Microsoft.MobilePacketCore/preview/2023-05-15-preview/examples/NetworkFunctions_Delete.json
            // this example is just showing the usage of "NetworkFunctions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionResource created on azure
            // for more information of creating NetworkFunctionResource, please refer to the document of NetworkFunctionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkFunctionName = "nf1";
            ResourceIdentifier networkFunctionResourceId = NetworkFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFunctionName);
            NetworkFunctionResource networkFunctionResource = client.GetNetworkFunctionResource(networkFunctionResourceId);

            // invoke the operation
            await networkFunctionResource.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
