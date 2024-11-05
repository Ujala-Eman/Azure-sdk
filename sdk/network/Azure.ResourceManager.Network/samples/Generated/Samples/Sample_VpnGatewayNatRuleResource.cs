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
    public partial class Sample_VpnGatewayNatRuleResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_NatRuleGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NatRuleGet.json
            // this example is just showing the usage of "NatRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnGatewayNatRuleResource created on azure
            // for more information of creating VpnGatewayNatRuleResource, please refer to the document of VpnGatewayNatRuleResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            string natRuleName = "natRule1";
            ResourceIdentifier vpnGatewayNatRuleResourceId = VpnGatewayNatRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName, natRuleName);
            VpnGatewayNatRuleResource vpnGatewayNatRule = client.GetVpnGatewayNatRuleResource(vpnGatewayNatRuleResourceId);

            // invoke the operation
            VpnGatewayNatRuleResource result = await vpnGatewayNatRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnGatewayNatRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_NatRuleDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NatRuleDelete.json
            // this example is just showing the usage of "NatRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnGatewayNatRuleResource created on azure
            // for more information of creating VpnGatewayNatRuleResource, please refer to the document of VpnGatewayNatRuleResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            string natRuleName = "natRule1";
            ResourceIdentifier vpnGatewayNatRuleResourceId = VpnGatewayNatRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName, natRuleName);
            VpnGatewayNatRuleResource vpnGatewayNatRule = client.GetVpnGatewayNatRuleResource(vpnGatewayNatRuleResourceId);

            // invoke the operation
            await vpnGatewayNatRule.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_NatRulePut()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NatRulePut.json
            // this example is just showing the usage of "NatRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnGatewayNatRuleResource created on azure
            // for more information of creating VpnGatewayNatRuleResource, please refer to the document of VpnGatewayNatRuleResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            string natRuleName = "natRule1";
            ResourceIdentifier vpnGatewayNatRuleResourceId = VpnGatewayNatRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName, natRuleName);
            VpnGatewayNatRuleResource vpnGatewayNatRule = client.GetVpnGatewayNatRuleResource(vpnGatewayNatRuleResourceId);

            // invoke the operation
            VpnGatewayNatRuleData data = new VpnGatewayNatRuleData
            {
                VpnNatRuleType = VpnNatRuleType.Static,
                Mode = VpnNatRuleMode.EgressSnat,
                InternalMappings = {new VpnNatRuleMapping
{
AddressSpace = "10.4.0.0/24",
}},
                ExternalMappings = {new VpnNatRuleMapping
{
AddressSpace = "192.168.21.0/24",
}},
                IPConfigurationId = "/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworkGateways/cloudnet1-VNG/ipConfigurations/default",
            };
            ArmOperation<VpnGatewayNatRuleResource> lro = await vpnGatewayNatRule.UpdateAsync(WaitUntil.Completed, data);
            VpnGatewayNatRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnGatewayNatRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
