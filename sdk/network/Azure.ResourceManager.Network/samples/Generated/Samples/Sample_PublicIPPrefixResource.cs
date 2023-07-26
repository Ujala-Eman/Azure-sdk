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
    public partial class Sample_PublicIPPrefixResource
    {
        // Delete public IP prefix
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletePublicIPPrefix()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/PublicIpPrefixDelete.json
            // this example is just showing the usage of "PublicIPPrefixes_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublicIPPrefixResource created on azure
            // for more information of creating PublicIPPrefixResource, please refer to the document of PublicIPPrefixResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string publicIPPrefixName = "test-ipprefix";
            ResourceIdentifier publicIPPrefixResourceId = PublicIPPrefixResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publicIPPrefixName);
            PublicIPPrefixResource publicIPPrefix = client.GetPublicIPPrefixResource(publicIPPrefixResourceId);

            // invoke the operation
            await publicIPPrefix.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get public IP prefix
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPublicIPPrefix()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/PublicIpPrefixGet.json
            // this example is just showing the usage of "PublicIPPrefixes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublicIPPrefixResource created on azure
            // for more information of creating PublicIPPrefixResource, please refer to the document of PublicIPPrefixResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string publicIPPrefixName = "test-ipprefix";
            ResourceIdentifier publicIPPrefixResourceId = PublicIPPrefixResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publicIPPrefixName);
            PublicIPPrefixResource publicIPPrefix = client.GetPublicIPPrefixResource(publicIPPrefixResourceId);

            // invoke the operation
            PublicIPPrefixResource result = await publicIPPrefix.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublicIPPrefixData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update public IP prefix tags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdatePublicIPPrefixTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/PublicIpPrefixUpdateTags.json
            // this example is just showing the usage of "PublicIPPrefixes_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublicIPPrefixResource created on azure
            // for more information of creating PublicIPPrefixResource, please refer to the document of PublicIPPrefixResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string publicIPPrefixName = "test-ipprefix";
            ResourceIdentifier publicIPPrefixResourceId = PublicIPPrefixResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publicIPPrefixName);
            PublicIPPrefixResource publicIPPrefix = client.GetPublicIPPrefixResource(publicIPPrefixResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            PublicIPPrefixResource result = await publicIPPrefix.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublicIPPrefixData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List all public IP prefixes
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPublicIPPrefixes_ListAllPublicIPPrefixes()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/PublicIpPrefixListAll.json
            // this example is just showing the usage of "PublicIPPrefixes_ListAll" operation, for the dependent resources, they will have to be created separately.

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
            await foreach (PublicIPPrefixResource item in subscriptionResource.GetPublicIPPrefixesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PublicIPPrefixData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
