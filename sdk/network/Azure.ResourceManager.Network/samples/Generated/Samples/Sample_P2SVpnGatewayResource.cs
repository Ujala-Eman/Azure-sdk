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
    public partial class Sample_P2SVpnGatewayResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_P2SVpnGatewayGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/P2SVpnGatewayGet.json
            // this example is just showing the usage of "P2sVpnGateways_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this P2SVpnGatewayResource created on azure
            // for more information of creating P2SVpnGatewayResource, please refer to the document of P2SVpnGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "p2sVpnGateway1";
            ResourceIdentifier p2sVpnGatewayResourceId = P2SVpnGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName);
            P2SVpnGatewayResource p2sVpnGateway = client.GetP2SVpnGatewayResource(p2sVpnGatewayResourceId);

            // invoke the operation
            P2SVpnGatewayResource result = await p2sVpnGateway.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            P2SVpnGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_P2SVpnGatewayDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/P2SVpnGatewayDelete.json
            // this example is just showing the usage of "P2sVpnGateways_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this P2SVpnGatewayResource created on azure
            // for more information of creating P2SVpnGatewayResource, please refer to the document of P2SVpnGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "p2sVpnGateway1";
            ResourceIdentifier p2sVpnGatewayResourceId = P2SVpnGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName);
            P2SVpnGatewayResource p2sVpnGateway = client.GetP2SVpnGatewayResource(p2sVpnGatewayResourceId);

            // invoke the operation
            await p2sVpnGateway.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_P2SVpnGatewayUpdate()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/P2SVpnGatewayUpdateTags.json
            // this example is just showing the usage of "P2sVpnGateways_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this P2SVpnGatewayResource created on azure
            // for more information of creating P2SVpnGatewayResource, please refer to the document of P2SVpnGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "p2sVpnGateway1";
            ResourceIdentifier p2sVpnGatewayResourceId = P2SVpnGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName);
            P2SVpnGatewayResource p2sVpnGateway = client.GetP2SVpnGatewayResource(p2sVpnGatewayResourceId);

            // invoke the operation
            NetworkTagsObject p2sVpnGatewayParameters = new NetworkTagsObject
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2"
},
            };
            ArmOperation<P2SVpnGatewayResource> lro = await p2sVpnGateway.UpdateAsync(WaitUntil.Completed, p2sVpnGatewayParameters);
            P2SVpnGatewayResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            P2SVpnGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Reset_ResetP2SVpnGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/P2SVpnGatewayReset.json
            // this example is just showing the usage of "P2SVpnGateways_Reset" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this P2SVpnGatewayResource created on azure
            // for more information of creating P2SVpnGatewayResource, please refer to the document of P2SVpnGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "p2sVpnGateway1";
            ResourceIdentifier p2sVpnGatewayResourceId = P2SVpnGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName);
            P2SVpnGatewayResource p2sVpnGateway = client.GetP2SVpnGatewayResource(p2sVpnGatewayResourceId);

            // invoke the operation
            ArmOperation<P2SVpnGatewayResource> lro = await p2sVpnGateway.ResetAsync(WaitUntil.Completed);
            P2SVpnGatewayResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            P2SVpnGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GenerateVpnProfile_GenerateP2SVpnGatewayVPNProfile()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/P2SVpnGatewayGenerateVpnProfile.json
            // this example is just showing the usage of "P2sVpnGateways_GenerateVpnProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this P2SVpnGatewayResource created on azure
            // for more information of creating P2SVpnGatewayResource, please refer to the document of P2SVpnGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "p2sVpnGateway1";
            ResourceIdentifier p2sVpnGatewayResourceId = P2SVpnGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName);
            P2SVpnGatewayResource p2sVpnGateway = client.GetP2SVpnGatewayResource(p2sVpnGatewayResourceId);

            // invoke the operation
            P2SVpnProfileContent content = new P2SVpnProfileContent
            {
                AuthenticationMethod = NetworkAuthenticationMethod.Eaptls,
            };
            ArmOperation<VpnProfileResponse> lro = await p2sVpnGateway.GenerateVpnProfileAsync(WaitUntil.Completed, content);
            VpnProfileResponse result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetP2SVpnConnectionHealth_P2SVpnGatewayGetConnectionHealth()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/P2SVpnGatewayGetConnectionHealth.json
            // this example is just showing the usage of "P2sVpnGateways_GetP2SVpnConnectionHealth" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this P2SVpnGatewayResource created on azure
            // for more information of creating P2SVpnGatewayResource, please refer to the document of P2SVpnGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "p2sVpnGateway1";
            ResourceIdentifier p2sVpnGatewayResourceId = P2SVpnGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName);
            P2SVpnGatewayResource p2sVpnGateway = client.GetP2SVpnGatewayResource(p2sVpnGatewayResourceId);

            // invoke the operation
            ArmOperation<P2SVpnGatewayResource> lro = await p2sVpnGateway.GetP2SVpnConnectionHealthAsync(WaitUntil.Completed);
            P2SVpnGatewayResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            P2SVpnGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetP2SVpnConnectionHealthDetailed_P2SVpnGatewayGetConnectionHealthDetailed()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/P2SVpnGatewayGetConnectionHealthDetailed.json
            // this example is just showing the usage of "P2sVpnGateways_GetP2SVpnConnectionHealthDetailed" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this P2SVpnGatewayResource created on azure
            // for more information of creating P2SVpnGatewayResource, please refer to the document of P2SVpnGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "p2s-vpn-gateway-test";
            string gatewayName = "p2svpngateway";
            ResourceIdentifier p2sVpnGatewayResourceId = P2SVpnGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName);
            P2SVpnGatewayResource p2sVpnGateway = client.GetP2SVpnGatewayResource(p2sVpnGatewayResourceId);

            // invoke the operation
            P2SVpnConnectionHealthContent content = new P2SVpnConnectionHealthContent
            {
                VpnUserNamesFilter = { "vpnUser1", "vpnUser2" },
                OutputBlobSasUri = new Uri("https://blobcortextesturl.blob.core.windows.net/folderforconfig/p2sconnectionhealths?sp=rw&se=2018-01-10T03%3A42%3A04Z&sv=2017-04-17&sig=WvXrT5bDmDFfgHs%2Brz%2BjAu123eRCNE9BO0eQYcPDT7pY%3D&sr=b"),
            };
            ArmOperation<P2SVpnConnectionHealth> lro = await p2sVpnGateway.GetP2SVpnConnectionHealthDetailedAsync(WaitUntil.Completed, content);
            P2SVpnConnectionHealth result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task DisconnectP2SVpnConnections_DisconnectVpnConnectionsFromP2sVpnGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/P2sVpnGatewaysDisconnectP2sVpnConnections.json
            // this example is just showing the usage of "P2sVpnGateways_DisconnectP2SVpnConnections" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this P2SVpnGatewayResource created on azure
            // for more information of creating P2SVpnGatewayResource, please refer to the document of P2SVpnGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "p2s-vpn-gateway-test";
            string p2sVpnGatewayName = "p2svpngateway";
            ResourceIdentifier p2sVpnGatewayResourceId = P2SVpnGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, p2sVpnGatewayName);
            P2SVpnGatewayResource p2sVpnGateway = client.GetP2SVpnGatewayResource(p2sVpnGatewayResourceId);

            // invoke the operation
            P2SVpnConnectionRequest request = new P2SVpnConnectionRequest
            {
                VpnConnectionIds = { "vpnconnId1", "vpnconnId2" },
            };
            await p2sVpnGateway.DisconnectP2SVpnConnectionsAsync(WaitUntil.Completed, request).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }
    }
}
