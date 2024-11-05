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
    public partial class Sample_PublicIPAddressResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPublicIPAddress()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/PublicIpAddressGet.json
            // this example is just showing the usage of "PublicIPAddresses_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublicIPAddressResource created on azure
            // for more information of creating PublicIPAddressResource, please refer to the document of PublicIPAddressResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string publicIPAddressName = "testDNS-ip";
            ResourceIdentifier publicIPAddressResourceId = PublicIPAddressResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publicIPAddressName);
            PublicIPAddressResource publicIPAddress = client.GetPublicIPAddressResource(publicIPAddressResourceId);

            // invoke the operation
            PublicIPAddressResource result = await publicIPAddress.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublicIPAddressData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeletePublicIPAddress()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/PublicIpAddressDelete.json
            // this example is just showing the usage of "PublicIPAddresses_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublicIPAddressResource created on azure
            // for more information of creating PublicIPAddressResource, please refer to the document of PublicIPAddressResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string publicIPAddressName = "test-ip";
            ResourceIdentifier publicIPAddressResourceId = PublicIPAddressResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publicIPAddressName);
            PublicIPAddressResource publicIPAddress = client.GetPublicIPAddressResource(publicIPAddressResourceId);

            // invoke the operation
            await publicIPAddress.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdatePublicIPAddressTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/PublicIpAddressUpdateTags.json
            // this example is just showing the usage of "PublicIPAddresses_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublicIPAddressResource created on azure
            // for more information of creating PublicIPAddressResource, please refer to the document of PublicIPAddressResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string publicIPAddressName = "test-ip";
            ResourceIdentifier publicIPAddressResourceId = PublicIPAddressResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publicIPAddressName);
            PublicIPAddressResource publicIPAddress = client.GetPublicIPAddressResource(publicIPAddressResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2"
},
            };
            PublicIPAddressResource result = await publicIPAddress.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublicIPAddressData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task DdosProtectionStatus_GetDdosProtectionStatusOfAPublicIPAddress()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/PublicIpAddressGetDdosProtectionStatus.json
            // this example is just showing the usage of "PublicIPAddresses_DdosProtectionStatus" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublicIPAddressResource created on azure
            // for more information of creating PublicIPAddressResource, please refer to the document of PublicIPAddressResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string publicIPAddressName = "test-pip";
            ResourceIdentifier publicIPAddressResourceId = PublicIPAddressResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publicIPAddressName);
            PublicIPAddressResource publicIPAddress = client.GetPublicIPAddressResource(publicIPAddressResourceId);

            // invoke the operation
            ArmOperation<PublicIPDdosProtectionStatusResult> lro = await publicIPAddress.DdosProtectionStatusAsync(WaitUntil.Completed);
            PublicIPDdosProtectionStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
