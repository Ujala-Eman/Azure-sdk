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
    public partial class Sample_VpnServerConfigurationPolicyGroupResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ConfigurationPolicyGroupPut()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ConfigurationPolicyGroupPut.json
            // this example is just showing the usage of "ConfigurationPolicyGroups_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnServerConfigurationPolicyGroupResource created on azure
            // for more information of creating VpnServerConfigurationPolicyGroupResource, please refer to the document of VpnServerConfigurationPolicyGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string vpnServerConfigurationName = "vpnServerConfiguration1";
            string configurationPolicyGroupName = "policyGroup1";
            ResourceIdentifier vpnServerConfigurationPolicyGroupResourceId = VpnServerConfigurationPolicyGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vpnServerConfigurationName, configurationPolicyGroupName);
            VpnServerConfigurationPolicyGroupResource vpnServerConfigurationPolicyGroup = client.GetVpnServerConfigurationPolicyGroupResource(vpnServerConfigurationPolicyGroupResourceId);

            // invoke the operation
            VpnServerConfigurationPolicyGroupData data = new VpnServerConfigurationPolicyGroupData()
            {
                IsDefault = true,
                Priority = 0,
                PolicyMembers =
{
new VpnServerConfigurationPolicyGroupMember()
{
Name = "policy1",
AttributeType = VpnPolicyMemberAttributeType.RadiusAzureGroupId,
AttributeValue = "6ad1bd08",
},new VpnServerConfigurationPolicyGroupMember()
{
Name = "policy2",
AttributeType = VpnPolicyMemberAttributeType.CertificateGroupId,
AttributeValue = "red.com",
}
},
            };
            ArmOperation<VpnServerConfigurationPolicyGroupResource> lro = await vpnServerConfigurationPolicyGroup.UpdateAsync(WaitUntil.Completed, data);
            VpnServerConfigurationPolicyGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnServerConfigurationPolicyGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ConfigurationPolicyGroupDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ConfigurationPolicyGroupDelete.json
            // this example is just showing the usage of "ConfigurationPolicyGroups_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnServerConfigurationPolicyGroupResource created on azure
            // for more information of creating VpnServerConfigurationPolicyGroupResource, please refer to the document of VpnServerConfigurationPolicyGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string vpnServerConfigurationName = "vpnServerConfiguration1";
            string configurationPolicyGroupName = "policyGroup1";
            ResourceIdentifier vpnServerConfigurationPolicyGroupResourceId = VpnServerConfigurationPolicyGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vpnServerConfigurationName, configurationPolicyGroupName);
            VpnServerConfigurationPolicyGroupResource vpnServerConfigurationPolicyGroup = client.GetVpnServerConfigurationPolicyGroupResource(vpnServerConfigurationPolicyGroupResourceId);

            // invoke the operation
            await vpnServerConfigurationPolicyGroup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ConfigurationPolicyGroupGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ConfigurationPolicyGroupGet.json
            // this example is just showing the usage of "ConfigurationPolicyGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnServerConfigurationPolicyGroupResource created on azure
            // for more information of creating VpnServerConfigurationPolicyGroupResource, please refer to the document of VpnServerConfigurationPolicyGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string vpnServerConfigurationName = "vpnServerConfiguration1";
            string configurationPolicyGroupName = "policyGroup1";
            ResourceIdentifier vpnServerConfigurationPolicyGroupResourceId = VpnServerConfigurationPolicyGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vpnServerConfigurationName, configurationPolicyGroupName);
            VpnServerConfigurationPolicyGroupResource vpnServerConfigurationPolicyGroup = client.GetVpnServerConfigurationPolicyGroupResource(vpnServerConfigurationPolicyGroupResourceId);

            // invoke the operation
            VpnServerConfigurationPolicyGroupResource result = await vpnServerConfigurationPolicyGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnServerConfigurationPolicyGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
