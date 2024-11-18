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
    public partial class Sample_VpnLinkConnectionSharedKeyResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_VpnSiteLinkConnectionDefaultSharedKeyGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VpnSiteLinkConnectionDefaultSharedKeyGet.json
            // this example is just showing the usage of "VpnLinkConnections_GetDefaultSharedKey" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnLinkConnectionSharedKeyResource created on azure
            // for more information of creating VpnLinkConnectionSharedKeyResource, please refer to the document of VpnLinkConnectionSharedKeyResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            string connectionName = "vpnConnection1";
            string linkConnectionName = "Connection-Link1";
            ResourceIdentifier vpnLinkConnectionSharedKeyResourceId = VpnLinkConnectionSharedKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName, connectionName, linkConnectionName);
            VpnLinkConnectionSharedKeyResource vpnLinkConnectionSharedKey = client.GetVpnLinkConnectionSharedKeyResource(vpnLinkConnectionSharedKeyResourceId);

            // invoke the operation
            VpnLinkConnectionSharedKeyResource result = await vpnLinkConnectionSharedKey.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnLinkConnectionSharedKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_VpnSiteLinkConnectionDefaultSharedKeyPut()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VpnSiteLinkConnectionDefaultSharedKeyPut.json
            // this example is just showing the usage of "VpnLinkConnections_SetOrInitDefaultSharedKey" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnLinkConnectionSharedKeyResource created on azure
            // for more information of creating VpnLinkConnectionSharedKeyResource, please refer to the document of VpnLinkConnectionSharedKeyResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            string connectionName = "vpnConnection1";
            string linkConnectionName = "Connection-Link1";
            ResourceIdentifier vpnLinkConnectionSharedKeyResourceId = VpnLinkConnectionSharedKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName, connectionName, linkConnectionName);
            VpnLinkConnectionSharedKeyResource vpnLinkConnectionSharedKey = client.GetVpnLinkConnectionSharedKeyResource(vpnLinkConnectionSharedKeyResourceId);

            // invoke the operation
            VpnLinkConnectionSharedKeyData data = new VpnLinkConnectionSharedKeyData()
            {
                Properties = new VpnLinkConnectionSharedKeyProperties()
                {
                    SharedKey = "ABCDEF123456",
                },
            };
            ArmOperation<VpnLinkConnectionSharedKeyResource> lro = await vpnLinkConnectionSharedKey.CreateOrUpdateAsync(WaitUntil.Completed, data);
            VpnLinkConnectionSharedKeyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnLinkConnectionSharedKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetDefaultSharedKey_VpnSiteLinkConnectionDefaultSharedKeyList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VpnSiteLinkConnectionDefaultSharedKeyList.json
            // this example is just showing the usage of "VpnLinkConnections_ListDefaultSharedKey" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnLinkConnectionSharedKeyResource created on azure
            // for more information of creating VpnLinkConnectionSharedKeyResource, please refer to the document of VpnLinkConnectionSharedKeyResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            string connectionName = "vpnConnection1";
            string linkConnectionName = "Connection-Link1";
            ResourceIdentifier vpnLinkConnectionSharedKeyResourceId = VpnLinkConnectionSharedKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName, connectionName, linkConnectionName);
            VpnLinkConnectionSharedKeyResource vpnLinkConnectionSharedKey = client.GetVpnLinkConnectionSharedKeyResource(vpnLinkConnectionSharedKeyResourceId);

            // invoke the operation
            VpnLinkConnectionSharedKeyResource result = await vpnLinkConnectionSharedKey.GetDefaultSharedKeyAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnLinkConnectionSharedKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
