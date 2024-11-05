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
    public partial class Sample_FirewallPolicyRuleCollectionGroupResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetFirewallPolicyNatRuleCollectionGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/FirewallPolicyNatRuleCollectionGroupGet.json
            // this example is just showing the usage of "FirewallPolicyRuleCollectionGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirewallPolicyRuleCollectionGroupResource created on azure
            // for more information of creating FirewallPolicyRuleCollectionGroupResource, please refer to the document of FirewallPolicyRuleCollectionGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string firewallPolicyName = "firewallPolicy";
            string ruleCollectionGroupName = "ruleCollectionGroup1";
            ResourceIdentifier firewallPolicyRuleCollectionGroupResourceId = FirewallPolicyRuleCollectionGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, firewallPolicyName, ruleCollectionGroupName);
            FirewallPolicyRuleCollectionGroupResource firewallPolicyRuleCollectionGroup = client.GetFirewallPolicyRuleCollectionGroupResource(firewallPolicyRuleCollectionGroupResourceId);

            // invoke the operation
            FirewallPolicyRuleCollectionGroupResource result = await firewallPolicyRuleCollectionGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirewallPolicyRuleCollectionGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetFirewallPolicyRuleCollectionGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/FirewallPolicyRuleCollectionGroupGet.json
            // this example is just showing the usage of "FirewallPolicyRuleCollectionGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirewallPolicyRuleCollectionGroupResource created on azure
            // for more information of creating FirewallPolicyRuleCollectionGroupResource, please refer to the document of FirewallPolicyRuleCollectionGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string firewallPolicyName = "firewallPolicy";
            string ruleCollectionGroupName = "ruleCollectionGroup1";
            ResourceIdentifier firewallPolicyRuleCollectionGroupResourceId = FirewallPolicyRuleCollectionGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, firewallPolicyName, ruleCollectionGroupName);
            FirewallPolicyRuleCollectionGroupResource firewallPolicyRuleCollectionGroup = client.GetFirewallPolicyRuleCollectionGroupResource(firewallPolicyRuleCollectionGroupResourceId);

            // invoke the operation
            FirewallPolicyRuleCollectionGroupResource result = await firewallPolicyRuleCollectionGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirewallPolicyRuleCollectionGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetFirewallPolicyRuleCollectionGroupWithIpGroups()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/FirewallPolicyRuleCollectionGroupWithIpGroupsGet.json
            // this example is just showing the usage of "FirewallPolicyRuleCollectionGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirewallPolicyRuleCollectionGroupResource created on azure
            // for more information of creating FirewallPolicyRuleCollectionGroupResource, please refer to the document of FirewallPolicyRuleCollectionGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string firewallPolicyName = "firewallPolicy";
            string ruleCollectionGroupName = "ruleGroup1";
            ResourceIdentifier firewallPolicyRuleCollectionGroupResourceId = FirewallPolicyRuleCollectionGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, firewallPolicyName, ruleCollectionGroupName);
            FirewallPolicyRuleCollectionGroupResource firewallPolicyRuleCollectionGroup = client.GetFirewallPolicyRuleCollectionGroupResource(firewallPolicyRuleCollectionGroupResourceId);

            // invoke the operation
            FirewallPolicyRuleCollectionGroupResource result = await firewallPolicyRuleCollectionGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirewallPolicyRuleCollectionGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetFirewallPolicyRuleCollectionGroupWithWebCategories()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/FirewallPolicyRuleCollectionGroupWithWebCategoriesGet.json
            // this example is just showing the usage of "FirewallPolicyRuleCollectionGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirewallPolicyRuleCollectionGroupResource created on azure
            // for more information of creating FirewallPolicyRuleCollectionGroupResource, please refer to the document of FirewallPolicyRuleCollectionGroupResource
            string subscriptionId = "e747cc13-97d4-4a79-b463-42d7f4e558f2";
            string resourceGroupName = "rg1";
            string firewallPolicyName = "firewallPolicy";
            string ruleCollectionGroupName = "ruleCollectionGroup1";
            ResourceIdentifier firewallPolicyRuleCollectionGroupResourceId = FirewallPolicyRuleCollectionGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, firewallPolicyName, ruleCollectionGroupName);
            FirewallPolicyRuleCollectionGroupResource firewallPolicyRuleCollectionGroup = client.GetFirewallPolicyRuleCollectionGroupResource(firewallPolicyRuleCollectionGroupResourceId);

            // invoke the operation
            FirewallPolicyRuleCollectionGroupResource result = await firewallPolicyRuleCollectionGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirewallPolicyRuleCollectionGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteFirewallPolicyRuleCollectionGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/FirewallPolicyRuleCollectionGroupDelete.json
            // this example is just showing the usage of "FirewallPolicyRuleCollectionGroups_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirewallPolicyRuleCollectionGroupResource created on azure
            // for more information of creating FirewallPolicyRuleCollectionGroupResource, please refer to the document of FirewallPolicyRuleCollectionGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string firewallPolicyName = "firewallPolicy";
            string ruleCollectionGroupName = "ruleCollectionGroup1";
            ResourceIdentifier firewallPolicyRuleCollectionGroupResourceId = FirewallPolicyRuleCollectionGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, firewallPolicyName, ruleCollectionGroupName);
            FirewallPolicyRuleCollectionGroupResource firewallPolicyRuleCollectionGroup = client.GetFirewallPolicyRuleCollectionGroupResource(firewallPolicyRuleCollectionGroupResourceId);

            // invoke the operation
            await firewallPolicyRuleCollectionGroup.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateFirewallPolicyNatRuleCollectionGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/FirewallPolicyNatRuleCollectionGroupPut.json
            // this example is just showing the usage of "FirewallPolicyRuleCollectionGroups_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirewallPolicyRuleCollectionGroupResource created on azure
            // for more information of creating FirewallPolicyRuleCollectionGroupResource, please refer to the document of FirewallPolicyRuleCollectionGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string firewallPolicyName = "firewallPolicy";
            string ruleCollectionGroupName = "ruleCollectionGroup1";
            ResourceIdentifier firewallPolicyRuleCollectionGroupResourceId = FirewallPolicyRuleCollectionGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, firewallPolicyName, ruleCollectionGroupName);
            FirewallPolicyRuleCollectionGroupResource firewallPolicyRuleCollectionGroup = client.GetFirewallPolicyRuleCollectionGroupResource(firewallPolicyRuleCollectionGroupResourceId);

            // invoke the operation
            FirewallPolicyRuleCollectionGroupData data = new FirewallPolicyRuleCollectionGroupData
            {
                Priority = 100,
                RuleCollections = {new FirewallPolicyNatRuleCollectionInfo
{
ActionType = FirewallPolicyNatRuleCollectionActionType.Dnat,
Rules = {new NatRule
{
IPProtocols = {FirewallPolicyRuleNetworkProtocol.Tcp, FirewallPolicyRuleNetworkProtocol.Udp},
SourceAddresses = {"2.2.2.2"},
DestinationAddresses = {"152.23.32.23"},
DestinationPorts = {"8080"},
TranslatedPort = "8080",
SourceIPGroups = {},
TranslatedFqdn = "internalhttp.server.net",
Name = "nat-rule1",
}},
Name = "Example-Nat-Rule-Collection",
Priority = 100,
}},
            };
            ArmOperation<FirewallPolicyRuleCollectionGroupResource> lro = await firewallPolicyRuleCollectionGroup.UpdateAsync(WaitUntil.Completed, data);
            FirewallPolicyRuleCollectionGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirewallPolicyRuleCollectionGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateFirewallPolicyRuleCollectionGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/FirewallPolicyRuleCollectionGroupPut.json
            // this example is just showing the usage of "FirewallPolicyRuleCollectionGroups_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirewallPolicyRuleCollectionGroupResource created on azure
            // for more information of creating FirewallPolicyRuleCollectionGroupResource, please refer to the document of FirewallPolicyRuleCollectionGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string firewallPolicyName = "firewallPolicy";
            string ruleCollectionGroupName = "ruleCollectionGroup1";
            ResourceIdentifier firewallPolicyRuleCollectionGroupResourceId = FirewallPolicyRuleCollectionGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, firewallPolicyName, ruleCollectionGroupName);
            FirewallPolicyRuleCollectionGroupResource firewallPolicyRuleCollectionGroup = client.GetFirewallPolicyRuleCollectionGroupResource(firewallPolicyRuleCollectionGroupResourceId);

            // invoke the operation
            FirewallPolicyRuleCollectionGroupData data = new FirewallPolicyRuleCollectionGroupData
            {
                Priority = 100,
                RuleCollections = {new FirewallPolicyFilterRuleCollectionInfo
{
ActionType = FirewallPolicyFilterRuleCollectionActionType.Deny,
Rules = {new NetworkRule
{
IPProtocols = {FirewallPolicyRuleNetworkProtocol.Tcp},
SourceAddresses = {"10.1.25.0/24"},
DestinationAddresses = {"*"},
DestinationPorts = {"*"},
Name = "network-rule1",
}},
Name = "Example-Filter-Rule-Collection",
Priority = 100,
}},
            };
            ArmOperation<FirewallPolicyRuleCollectionGroupResource> lro = await firewallPolicyRuleCollectionGroup.UpdateAsync(WaitUntil.Completed, data);
            FirewallPolicyRuleCollectionGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirewallPolicyRuleCollectionGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateFirewallPolicyRuleCollectionGroupWithIPGroups()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/FirewallPolicyRuleCollectionGroupWithIpGroupsPut.json
            // this example is just showing the usage of "FirewallPolicyRuleCollectionGroups_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirewallPolicyRuleCollectionGroupResource created on azure
            // for more information of creating FirewallPolicyRuleCollectionGroupResource, please refer to the document of FirewallPolicyRuleCollectionGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string firewallPolicyName = "firewallPolicy";
            string ruleCollectionGroupName = "ruleCollectionGroup1";
            ResourceIdentifier firewallPolicyRuleCollectionGroupResourceId = FirewallPolicyRuleCollectionGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, firewallPolicyName, ruleCollectionGroupName);
            FirewallPolicyRuleCollectionGroupResource firewallPolicyRuleCollectionGroup = client.GetFirewallPolicyRuleCollectionGroupResource(firewallPolicyRuleCollectionGroupResourceId);

            // invoke the operation
            FirewallPolicyRuleCollectionGroupData data = new FirewallPolicyRuleCollectionGroupData
            {
                Priority = 110,
                RuleCollections = {new FirewallPolicyFilterRuleCollectionInfo
{
ActionType = FirewallPolicyFilterRuleCollectionActionType.Deny,
Rules = {new NetworkRule
{
IPProtocols = {FirewallPolicyRuleNetworkProtocol.Tcp},
DestinationPorts = {"*"},
SourceIPGroups = {"/subscriptions/subid/providers/Microsoft.Network/resourceGroup/rg1/ipGroups/ipGroups1"},
DestinationIPGroups = {"/subscriptions/subid/providers/Microsoft.Network/resourceGroup/rg1/ipGroups/ipGroups2"},
Name = "network-1",
}},
Name = "Example-Filter-Rule-Collection",
}},
            };
            ArmOperation<FirewallPolicyRuleCollectionGroupResource> lro = await firewallPolicyRuleCollectionGroup.UpdateAsync(WaitUntil.Completed, data);
            FirewallPolicyRuleCollectionGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirewallPolicyRuleCollectionGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateFirewallPolicyRuleCollectionGroupWithWebCategories()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/FirewallPolicyRuleCollectionGroupWithWebCategoriesPut.json
            // this example is just showing the usage of "FirewallPolicyRuleCollectionGroups_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirewallPolicyRuleCollectionGroupResource created on azure
            // for more information of creating FirewallPolicyRuleCollectionGroupResource, please refer to the document of FirewallPolicyRuleCollectionGroupResource
            string subscriptionId = "e747cc13-97d4-4a79-b463-42d7f4e558f2";
            string resourceGroupName = "rg1";
            string firewallPolicyName = "firewallPolicy";
            string ruleCollectionGroupName = "ruleCollectionGroup1";
            ResourceIdentifier firewallPolicyRuleCollectionGroupResourceId = FirewallPolicyRuleCollectionGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, firewallPolicyName, ruleCollectionGroupName);
            FirewallPolicyRuleCollectionGroupResource firewallPolicyRuleCollectionGroup = client.GetFirewallPolicyRuleCollectionGroupResource(firewallPolicyRuleCollectionGroupResourceId);

            // invoke the operation
            FirewallPolicyRuleCollectionGroupData data = new FirewallPolicyRuleCollectionGroupData
            {
                Priority = 110,
                RuleCollections = {new FirewallPolicyFilterRuleCollectionInfo
{
ActionType = FirewallPolicyFilterRuleCollectionActionType.Deny,
Rules = {new ApplicationRule
{
SourceAddresses = {"216.58.216.164", "10.0.0.0/24"},
Protocols = {new FirewallPolicyRuleApplicationProtocol
{
ProtocolType = FirewallPolicyRuleApplicationProtocolType.Https,
Port = 443,
}},
WebCategories = {"Hacking"},
Name = "rule1",
Description = "Deny inbound rule",
}},
Name = "Example-Filter-Rule-Collection",
}},
            };
            ArmOperation<FirewallPolicyRuleCollectionGroupResource> lro = await firewallPolicyRuleCollectionGroup.UpdateAsync(WaitUntil.Completed, data);
            FirewallPolicyRuleCollectionGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirewallPolicyRuleCollectionGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateFirewallPolicyRuleCollectionGroupWithHttpHeaderToInsert()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/FirewallPolicyRuleCollectionGroupWithHttpHeadersToInsert.json
            // this example is just showing the usage of "FirewallPolicyRuleCollectionGroups_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirewallPolicyRuleCollectionGroupResource created on azure
            // for more information of creating FirewallPolicyRuleCollectionGroupResource, please refer to the document of FirewallPolicyRuleCollectionGroupResource
            string subscriptionId = "e747cc13-97d4-4a79-b463-42d7f4e558f2";
            string resourceGroupName = "rg1";
            string firewallPolicyName = "firewallPolicy";
            string ruleCollectionGroupName = "ruleCollectionGroup1";
            ResourceIdentifier firewallPolicyRuleCollectionGroupResourceId = FirewallPolicyRuleCollectionGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, firewallPolicyName, ruleCollectionGroupName);
            FirewallPolicyRuleCollectionGroupResource firewallPolicyRuleCollectionGroup = client.GetFirewallPolicyRuleCollectionGroupResource(firewallPolicyRuleCollectionGroupResourceId);

            // invoke the operation
            FirewallPolicyRuleCollectionGroupData data = new FirewallPolicyRuleCollectionGroupData
            {
                Priority = 110,
                RuleCollections = {new FirewallPolicyFilterRuleCollectionInfo
{
ActionType = FirewallPolicyFilterRuleCollectionActionType.Allow,
Rules = {new ApplicationRule
{
SourceAddresses = {"216.58.216.164", "10.0.0.0/24"},
Protocols = {new FirewallPolicyRuleApplicationProtocol
{
ProtocolType = FirewallPolicyRuleApplicationProtocolType.Http,
Port = 80,
}},
FqdnTags = {"WindowsVirtualDesktop"},
HttpHeadersToInsert = {new FirewallPolicyHttpHeaderToInsert
{
HeaderName = "Restrict-Access-To-Tenants",
HeaderValue = "contoso.com,fabrikam.onmicrosoft.com",
}},
Name = "rule1",
Description = "Insert trusted tenants header",
}},
Name = "Example-Filter-Rule-Collection",
}},
            };
            ArmOperation<FirewallPolicyRuleCollectionGroupResource> lro = await firewallPolicyRuleCollectionGroup.UpdateAsync(WaitUntil.Completed, data);
            FirewallPolicyRuleCollectionGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirewallPolicyRuleCollectionGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
