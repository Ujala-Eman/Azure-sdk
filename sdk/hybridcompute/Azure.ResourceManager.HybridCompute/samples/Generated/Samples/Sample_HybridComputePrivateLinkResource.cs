// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.HybridCompute.Samples
{
    public partial class Sample_HybridComputePrivateLinkResource
    {
        // Gets private endpoint connection.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsPrivateEndpointConnection()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/stable/2024-07-10/examples/privateLinkScope/PrivateLinkScopePrivateLinkResource_Get.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridComputePrivateLinkResource created on azure
            // for more information of creating HybridComputePrivateLinkResource, please refer to the document of HybridComputePrivateLinkResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "myResourceGroup";
            string scopeName = "myPrivateLinkScope";
            string groupName = "hybridcompute";
            ResourceIdentifier hybridComputePrivateLinkResourceId = HybridComputePrivateLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, scopeName, groupName);
            HybridComputePrivateLinkResource hybridComputePrivateLinkResource = client.GetHybridComputePrivateLinkResource(hybridComputePrivateLinkResourceId);

            // invoke the operation
            HybridComputePrivateLinkResource result = await hybridComputePrivateLinkResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridComputePrivateLinkResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
