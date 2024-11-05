// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.MySql.Samples
{
    public partial class Sample_MySqlFirewallRuleResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_FirewallRuleGet()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2017-12-01/examples/FirewallRuleGet.json
            // this example is just showing the usage of "FirewallRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFirewallRuleResource created on azure
            // for more information of creating MySqlFirewallRuleResource, please refer to the document of MySqlFirewallRuleResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            string firewallRuleName = "rule1";
            ResourceIdentifier mySqlFirewallRuleResourceId = MySqlFirewallRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, firewallRuleName);
            MySqlFirewallRuleResource mySqlFirewallRule = client.GetMySqlFirewallRuleResource(mySqlFirewallRuleResourceId);

            // invoke the operation
            MySqlFirewallRuleResource result = await mySqlFirewallRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_FirewallRuleDelete()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2017-12-01/examples/FirewallRuleDelete.json
            // this example is just showing the usage of "FirewallRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFirewallRuleResource created on azure
            // for more information of creating MySqlFirewallRuleResource, please refer to the document of MySqlFirewallRuleResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            string firewallRuleName = "rule1";
            ResourceIdentifier mySqlFirewallRuleResourceId = MySqlFirewallRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, firewallRuleName);
            MySqlFirewallRuleResource mySqlFirewallRule = client.GetMySqlFirewallRuleResource(mySqlFirewallRuleResourceId);

            // invoke the operation
            await mySqlFirewallRule.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_FirewallRuleCreate()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2017-12-01/examples/FirewallRuleCreate.json
            // this example is just showing the usage of "FirewallRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFirewallRuleResource created on azure
            // for more information of creating MySqlFirewallRuleResource, please refer to the document of MySqlFirewallRuleResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            string firewallRuleName = "rule1";
            ResourceIdentifier mySqlFirewallRuleResourceId = MySqlFirewallRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, firewallRuleName);
            MySqlFirewallRuleResource mySqlFirewallRule = client.GetMySqlFirewallRuleResource(mySqlFirewallRuleResourceId);

            // invoke the operation
            MySqlFirewallRuleData data = new MySqlFirewallRuleData(IPAddress.Parse("0.0.0.0"), IPAddress.Parse("255.255.255.255"));
            ArmOperation<MySqlFirewallRuleResource> lro = await mySqlFirewallRule.UpdateAsync(WaitUntil.Completed, data);
            MySqlFirewallRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
