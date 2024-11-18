// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Billing.Samples
{
    public partial class Sample_BillingCustomerRoleDefinitionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_BillingRoleDefinitionGetByCustomer()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingRoleDefinitionGetByCustomer.json
            // this example is just showing the usage of "BillingRoleDefinition_GetByCustomer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingCustomerRoleDefinitionResource created on azure
            // for more information of creating BillingCustomerRoleDefinitionResource, please refer to the document of BillingCustomerRoleDefinitionResource
            string billingAccountName = "10000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            string customerName = "11111111-1111-1111-1111-111111111111";
            string roleDefinitionName = "30000000-aaaa-bbbb-cccc-100000000000";
            ResourceIdentifier billingCustomerRoleDefinitionResourceId = BillingCustomerRoleDefinitionResource.CreateResourceIdentifier(billingAccountName, billingProfileName, customerName, roleDefinitionName);
            BillingCustomerRoleDefinitionResource billingCustomerRoleDefinition = client.GetBillingCustomerRoleDefinitionResource(billingCustomerRoleDefinitionResourceId);

            // invoke the operation
            BillingCustomerRoleDefinitionResource result = await billingCustomerRoleDefinition.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingRoleDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
