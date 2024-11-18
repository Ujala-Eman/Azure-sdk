// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Samples
{
    public partial class Sample_SiteRecoveryLogicalNetworkResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsALogicalNetworkWithSpecifiedServerIdAndLogicalNetworkName()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-08-01/examples/ReplicationLogicalNetworks_Get.json
            // this example is just showing the usage of "ReplicationLogicalNetworks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryLogicalNetworkResource created on azure
            // for more information of creating SiteRecoveryLogicalNetworkResource, please refer to the document of SiteRecoveryLogicalNetworkResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            string logicalNetworkName = "87ab394f-165f-4aa9-bd84-b018500b4509";
            ResourceIdentifier siteRecoveryLogicalNetworkResourceId = SiteRecoveryLogicalNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, logicalNetworkName);
            SiteRecoveryLogicalNetworkResource siteRecoveryLogicalNetwork = client.GetSiteRecoveryLogicalNetworkResource(siteRecoveryLogicalNetworkResourceId);

            // invoke the operation
            SiteRecoveryLogicalNetworkResource result = await siteRecoveryLogicalNetwork.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SiteRecoveryLogicalNetworkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
