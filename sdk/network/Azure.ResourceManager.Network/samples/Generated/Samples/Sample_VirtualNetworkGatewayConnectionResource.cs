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
    public partial class Sample_VirtualNetworkGatewayConnectionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetVirtualNetworkGatewayConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualNetworkGatewayConnectionGet.json
            // this example is just showing the usage of "VirtualNetworkGatewayConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkGatewayConnectionResource created on azure
            // for more information of creating VirtualNetworkGatewayConnectionResource, please refer to the document of VirtualNetworkGatewayConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualNetworkGatewayConnectionName = "connS2S";
            ResourceIdentifier virtualNetworkGatewayConnectionResourceId = VirtualNetworkGatewayConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkGatewayConnectionName);
            VirtualNetworkGatewayConnectionResource virtualNetworkGatewayConnection = client.GetVirtualNetworkGatewayConnectionResource(virtualNetworkGatewayConnectionResourceId);

            // invoke the operation
            VirtualNetworkGatewayConnectionResource result = await virtualNetworkGatewayConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkGatewayConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteVirtualNetworkGatewayConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualNetworkGatewayConnectionDelete.json
            // this example is just showing the usage of "VirtualNetworkGatewayConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkGatewayConnectionResource created on azure
            // for more information of creating VirtualNetworkGatewayConnectionResource, please refer to the document of VirtualNetworkGatewayConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualNetworkGatewayConnectionName = "conn1";
            ResourceIdentifier virtualNetworkGatewayConnectionResourceId = VirtualNetworkGatewayConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkGatewayConnectionName);
            VirtualNetworkGatewayConnectionResource virtualNetworkGatewayConnection = client.GetVirtualNetworkGatewayConnectionResource(virtualNetworkGatewayConnectionResourceId);

            // invoke the operation
            await virtualNetworkGatewayConnection.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateVirtualNetworkGatewayConnectionTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualNetworkGatewayConnectionUpdateTags.json
            // this example is just showing the usage of "VirtualNetworkGatewayConnections_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkGatewayConnectionResource created on azure
            // for more information of creating VirtualNetworkGatewayConnectionResource, please refer to the document of VirtualNetworkGatewayConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualNetworkGatewayConnectionName = "test";
            ResourceIdentifier virtualNetworkGatewayConnectionResourceId = VirtualNetworkGatewayConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkGatewayConnectionName);
            VirtualNetworkGatewayConnectionResource virtualNetworkGatewayConnection = client.GetVirtualNetworkGatewayConnectionResource(virtualNetworkGatewayConnectionResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2"
},
            };
            ArmOperation<VirtualNetworkGatewayConnectionResource> lro = await virtualNetworkGatewayConnection.UpdateAsync(WaitUntil.Completed, networkTagsObject);
            VirtualNetworkGatewayConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkGatewayConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task VpnDeviceConfigurationScript_GetVPNDeviceConfigurationScript()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualNetworkGatewayVpnDeviceConfigurationScript.json
            // this example is just showing the usage of "VirtualNetworkGateways_VpnDeviceConfigurationScript" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkGatewayConnectionResource created on azure
            // for more information of creating VirtualNetworkGatewayConnectionResource, please refer to the document of VirtualNetworkGatewayConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualNetworkGatewayConnectionName = "vpngw";
            ResourceIdentifier virtualNetworkGatewayConnectionResourceId = VirtualNetworkGatewayConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkGatewayConnectionName);
            VirtualNetworkGatewayConnectionResource virtualNetworkGatewayConnection = client.GetVirtualNetworkGatewayConnectionResource(virtualNetworkGatewayConnectionResourceId);

            // invoke the operation
            VpnDeviceScriptContent content = new VpnDeviceScriptContent
            {
                Vendor = "Cisco",
                DeviceFamily = "ISR",
                FirmwareVersion = "IOS 15.1 (Preview)",
            };
            string result = await virtualNetworkGatewayConnection.VpnDeviceConfigurationScriptAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task SetSharedKey_SetVirtualNetworkGatewayConnectionSharedKey()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualNetworkGatewayConnectionSetSharedKey.json
            // this example is just showing the usage of "VirtualNetworkGatewayConnections_SetSharedKey" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkGatewayConnectionResource created on azure
            // for more information of creating VirtualNetworkGatewayConnectionResource, please refer to the document of VirtualNetworkGatewayConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualNetworkGatewayConnectionName = "connS2S";
            ResourceIdentifier virtualNetworkGatewayConnectionResourceId = VirtualNetworkGatewayConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkGatewayConnectionName);
            VirtualNetworkGatewayConnectionResource virtualNetworkGatewayConnection = client.GetVirtualNetworkGatewayConnectionResource(virtualNetworkGatewayConnectionResourceId);

            // invoke the operation
            ConnectionSharedKey connectionSharedKey = new ConnectionSharedKey("AzureAbc123");
            ArmOperation<ConnectionSharedKey> lro = await virtualNetworkGatewayConnection.SetSharedKeyAsync(WaitUntil.Completed, connectionSharedKey);
            ConnectionSharedKey result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSharedKey_GetVirtualNetworkGatewayConnectionSharedKey()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualNetworkGatewayConnectionGetSharedKey.json
            // this example is just showing the usage of "VirtualNetworkGatewayConnections_GetSharedKey" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkGatewayConnectionResource created on azure
            // for more information of creating VirtualNetworkGatewayConnectionResource, please refer to the document of VirtualNetworkGatewayConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualNetworkGatewayConnectionName = "connS2S";
            ResourceIdentifier virtualNetworkGatewayConnectionResourceId = VirtualNetworkGatewayConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkGatewayConnectionName);
            VirtualNetworkGatewayConnectionResource virtualNetworkGatewayConnection = client.GetVirtualNetworkGatewayConnectionResource(virtualNetworkGatewayConnectionResourceId);

            // invoke the operation
            ConnectionSharedKey result = await virtualNetworkGatewayConnection.GetSharedKeyAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ResetSharedKey_ResetVirtualNetworkGatewayConnectionSharedKey()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualNetworkGatewayConnectionResetSharedKey.json
            // this example is just showing the usage of "VirtualNetworkGatewayConnections_ResetSharedKey" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkGatewayConnectionResource created on azure
            // for more information of creating VirtualNetworkGatewayConnectionResource, please refer to the document of VirtualNetworkGatewayConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualNetworkGatewayConnectionName = "conn1";
            ResourceIdentifier virtualNetworkGatewayConnectionResourceId = VirtualNetworkGatewayConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkGatewayConnectionName);
            VirtualNetworkGatewayConnectionResource virtualNetworkGatewayConnection = client.GetVirtualNetworkGatewayConnectionResource(virtualNetworkGatewayConnectionResourceId);

            // invoke the operation
            ConnectionResetSharedKey connectionResetSharedKey = new ConnectionResetSharedKey(128);
            ArmOperation<ConnectionResetSharedKey> lro = await virtualNetworkGatewayConnection.ResetSharedKeyAsync(WaitUntil.Completed, connectionResetSharedKey);
            ConnectionResetSharedKey result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task StartPacketCapture_StartPacketCaptureOnVirtualNetworkGatewayConnectionWithFilter()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualNetworkGatewayConnectionStartPacketCaptureFilterData.json
            // this example is just showing the usage of "VirtualNetworkGatewayConnections_StartPacketCapture" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkGatewayConnectionResource created on azure
            // for more information of creating VirtualNetworkGatewayConnectionResource, please refer to the document of VirtualNetworkGatewayConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualNetworkGatewayConnectionName = "vpngwcn1";
            ResourceIdentifier virtualNetworkGatewayConnectionResourceId = VirtualNetworkGatewayConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkGatewayConnectionName);
            VirtualNetworkGatewayConnectionResource virtualNetworkGatewayConnection = client.GetVirtualNetworkGatewayConnectionResource(virtualNetworkGatewayConnectionResourceId);

            // invoke the operation
            VpnPacketCaptureStartContent content = new VpnPacketCaptureStartContent
            {
                FilterData = "{'TracingFlags': 11,'MaxPacketBufferSize': 120,'MaxFileSize': 200,'Filters': [{'SourceSubnets': ['20.1.1.0/24'],'DestinationSubnets': ['10.1.1.0/24'],'SourcePort': [500],'DestinationPort': [4500],'Protocol': 6,'TcpFlags': 16,'CaptureSingleDirectionTrafficOnly': true}]}",
            };
            ArmOperation<string> lro = await virtualNetworkGatewayConnection.StartPacketCaptureAsync(WaitUntil.Completed, content);
            string result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task StartPacketCapture_StartPacketCaptureOnVirtualNetworkGatewayConnectionWithoutFilter()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualNetworkGatewayConnectionStartPacketCapture.json
            // this example is just showing the usage of "VirtualNetworkGatewayConnections_StartPacketCapture" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkGatewayConnectionResource created on azure
            // for more information of creating VirtualNetworkGatewayConnectionResource, please refer to the document of VirtualNetworkGatewayConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualNetworkGatewayConnectionName = "vpngwcn1";
            ResourceIdentifier virtualNetworkGatewayConnectionResourceId = VirtualNetworkGatewayConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkGatewayConnectionName);
            VirtualNetworkGatewayConnectionResource virtualNetworkGatewayConnection = client.GetVirtualNetworkGatewayConnectionResource(virtualNetworkGatewayConnectionResourceId);

            // invoke the operation
            ArmOperation<string> lro = await virtualNetworkGatewayConnection.StartPacketCaptureAsync(WaitUntil.Completed);
            string result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task StopPacketCapture_StopPacketCaptureOnVirtualNetworkGatewayConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualNetworkGatewayConnectionStopPacketCapture.json
            // this example is just showing the usage of "VirtualNetworkGatewayConnections_StopPacketCapture" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkGatewayConnectionResource created on azure
            // for more information of creating VirtualNetworkGatewayConnectionResource, please refer to the document of VirtualNetworkGatewayConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualNetworkGatewayConnectionName = "vpngwcn1";
            ResourceIdentifier virtualNetworkGatewayConnectionResourceId = VirtualNetworkGatewayConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkGatewayConnectionName);
            VirtualNetworkGatewayConnectionResource virtualNetworkGatewayConnection = client.GetVirtualNetworkGatewayConnectionResource(virtualNetworkGatewayConnectionResourceId);

            // invoke the operation
            VpnPacketCaptureStopContent content = new VpnPacketCaptureStopContent
            {
                SasUri = new Uri("https://teststorage.blob.core.windows.net/?sv=2018-03-28&ss=bfqt&srt=sco&sp=rwdlacup&se=2019-09-13T07:44:05Z&st=2019-09-06T23:44:05Z&spr=https&sig=V1h9D1riltvZMI69d6ihENnFo%2FrCvTqGgjO2lf%2FVBhE%3D"),
            };
            ArmOperation<string> lro = await virtualNetworkGatewayConnection.StopPacketCaptureAsync(WaitUntil.Completed, content);
            string result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIkeSas_GetVirtualNetworkGatewayConnectionIkeSa()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualNetworkGatewayConnectionGetIkeSas.json
            // this example is just showing the usage of "VirtualNetworkGatewayConnections_GetIkeSas" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkGatewayConnectionResource created on azure
            // for more information of creating VirtualNetworkGatewayConnectionResource, please refer to the document of VirtualNetworkGatewayConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualNetworkGatewayConnectionName = "vpngwcn1";
            ResourceIdentifier virtualNetworkGatewayConnectionResourceId = VirtualNetworkGatewayConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkGatewayConnectionName);
            VirtualNetworkGatewayConnectionResource virtualNetworkGatewayConnection = client.GetVirtualNetworkGatewayConnectionResource(virtualNetworkGatewayConnectionResourceId);

            // invoke the operation
            ArmOperation<string> lro = await virtualNetworkGatewayConnection.GetIkeSasAsync(WaitUntil.Completed);
            string result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ResetConnection_ResetVirtualNetworkGatewayConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualNetworkGatewayConnectionReset.json
            // this example is just showing the usage of "VirtualNetworkGatewayConnections_ResetConnection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkGatewayConnectionResource created on azure
            // for more information of creating VirtualNetworkGatewayConnectionResource, please refer to the document of VirtualNetworkGatewayConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualNetworkGatewayConnectionName = "conn1";
            ResourceIdentifier virtualNetworkGatewayConnectionResourceId = VirtualNetworkGatewayConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkGatewayConnectionName);
            VirtualNetworkGatewayConnectionResource virtualNetworkGatewayConnection = client.GetVirtualNetworkGatewayConnectionResource(virtualNetworkGatewayConnectionResourceId);

            // invoke the operation
            await virtualNetworkGatewayConnection.ResetConnectionAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }
    }
}
