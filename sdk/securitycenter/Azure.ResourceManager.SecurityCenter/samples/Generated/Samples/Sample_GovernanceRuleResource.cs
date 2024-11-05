// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.SecurityCenter.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SecurityCenter.Samples
{
    public partial class Sample_GovernanceRuleResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAGovernanceRuleOverManagementGroupScope()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2022-01-01-preview/examples/GovernanceRules/GetManagementGroupGovernanceRule_example.json
            // this example is just showing the usage of "GovernanceRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GovernanceRuleResource created on azure
            // for more information of creating GovernanceRuleResource, please refer to the document of GovernanceRuleResource
            string scope = "providers/Microsoft.Management/managementGroups/contoso";
            string ruleId = "ad9a8e26-29d9-4829-bb30-e597a58cdbb8";
            ResourceIdentifier governanceRuleResourceId = GovernanceRuleResource.CreateResourceIdentifier(scope, ruleId);
            GovernanceRuleResource governanceRule = client.GetGovernanceRuleResource(governanceRuleResourceId);

            // invoke the operation
            GovernanceRuleResource result = await governanceRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GovernanceRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAGovernanceRuleOverSecurityConnectorScope()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2022-01-01-preview/examples/GovernanceRules/GetSecurityConnectorGovernanceRule_example.json
            // this example is just showing the usage of "GovernanceRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GovernanceRuleResource created on azure
            // for more information of creating GovernanceRuleResource, please refer to the document of GovernanceRuleResource
            string scope = "subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23/resourceGroups/gcpResourceGroup/providers/Microsoft.Security/securityConnectors/gcpconnector";
            string ruleId = "ad9a8e26-29d9-4829-bb30-e597a58cdbb8";
            ResourceIdentifier governanceRuleResourceId = GovernanceRuleResource.CreateResourceIdentifier(scope, ruleId);
            GovernanceRuleResource governanceRule = client.GetGovernanceRuleResource(governanceRuleResourceId);

            // invoke the operation
            GovernanceRuleResource result = await governanceRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GovernanceRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAGovernanceRuleOverSubscriptionScope()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2022-01-01-preview/examples/GovernanceRules/GetGovernanceRule_example.json
            // this example is just showing the usage of "GovernanceRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GovernanceRuleResource created on azure
            // for more information of creating GovernanceRuleResource, please refer to the document of GovernanceRuleResource
            string scope = "subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string ruleId = "ad9a8e26-29d9-4829-bb30-e597a58cdbb8";
            ResourceIdentifier governanceRuleResourceId = GovernanceRuleResource.CreateResourceIdentifier(scope, ruleId);
            GovernanceRuleResource governanceRule = client.GetGovernanceRuleResource(governanceRuleResourceId);

            // invoke the operation
            GovernanceRuleResource result = await governanceRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GovernanceRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAGovernanceRuleOverManagementGroupScope()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2022-01-01-preview/examples/GovernanceRules/DeleteManagementGroupGovernanceRule_example.json
            // this example is just showing the usage of "GovernanceRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GovernanceRuleResource created on azure
            // for more information of creating GovernanceRuleResource, please refer to the document of GovernanceRuleResource
            string scope = "providers/Microsoft.Management/managementGroups/contoso";
            string ruleId = "ad9a8e26-29d9-4829-bb30-e597a58cdbb8";
            ResourceIdentifier governanceRuleResourceId = GovernanceRuleResource.CreateResourceIdentifier(scope, ruleId);
            GovernanceRuleResource governanceRule = client.GetGovernanceRuleResource(governanceRuleResourceId);

            // invoke the operation
            await governanceRule.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAGovernanceRuleOverSecurityConnectorScope()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2022-01-01-preview/examples/GovernanceRules/DeleteSecurityConnectorGovernanceRule_example.json
            // this example is just showing the usage of "GovernanceRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GovernanceRuleResource created on azure
            // for more information of creating GovernanceRuleResource, please refer to the document of GovernanceRuleResource
            string scope = "subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23/resourceGroups/gcpResourceGroup/providers/Microsoft.Security/securityConnectors/gcpconnector";
            string ruleId = "ad9a8e26-29d9-4829-bb30-e597a58cdbb8";
            ResourceIdentifier governanceRuleResourceId = GovernanceRuleResource.CreateResourceIdentifier(scope, ruleId);
            GovernanceRuleResource governanceRule = client.GetGovernanceRuleResource(governanceRuleResourceId);

            // invoke the operation
            await governanceRule.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAGovernanceRuleOverSubscriptionScope()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2022-01-01-preview/examples/GovernanceRules/DeleteGovernanceRule_example.json
            // this example is just showing the usage of "GovernanceRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GovernanceRuleResource created on azure
            // for more information of creating GovernanceRuleResource, please refer to the document of GovernanceRuleResource
            string scope = "subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string ruleId = "ad9a8e26-29d9-4829-bb30-e597a58cdbb8";
            ResourceIdentifier governanceRuleResourceId = GovernanceRuleResource.CreateResourceIdentifier(scope, ruleId);
            GovernanceRuleResource governanceRule = client.GetGovernanceRuleResource(governanceRuleResourceId);

            // invoke the operation
            await governanceRule.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateGovernanceRuleOverManagementGroupScope()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2022-01-01-preview/examples/GovernanceRules/PutManagementGroupGovernanceRule_example.json
            // this example is just showing the usage of "GovernanceRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GovernanceRuleResource created on azure
            // for more information of creating GovernanceRuleResource, please refer to the document of GovernanceRuleResource
            string scope = "providers/Microsoft.Management/managementGroups/contoso";
            string ruleId = "ad9a8e26-29d9-4829-bb30-e597a58cdbb8";
            ResourceIdentifier governanceRuleResourceId = GovernanceRuleResource.CreateResourceIdentifier(scope, ruleId);
            GovernanceRuleResource governanceRule = client.GetGovernanceRuleResource(governanceRuleResourceId);

            // invoke the operation
            GovernanceRuleData data = new GovernanceRuleData
            {
                DisplayName = "Management group rule",
                Description = "A rule for a management group",
                RemediationTimeframe = "7.00:00:00",
                IsGracePeriod = true,
                RulePriority = 200,
                IsDisabled = false,
                RuleType = GovernanceRuleType.Integrated,
                SourceResourceType = GovernanceRuleSourceResourceType.Assessments,
                ExcludedScopes = { "/subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23" },
                ConditionSets = {BinaryData.FromObjectAsJson(new
{
conditions = new object[]
{
new Dictionary<string, object>
{
["operator"] = "In",
["property"] = "$.AssessmentKey",
["value"] = "[\"b1cd27e0-4ecc-4246-939f-49c426d9d72f\", \"fe83f80b-073d-4ccf-93d9-6797eb870201\"]"
}
},
})},
                OwnerSource = new GovernanceRuleOwnerSource
                {
                    SourceType = GovernanceRuleOwnerSourceType.Manually,
                    Value = "user@contoso.com",
                },
                GovernanceEmailNotification = new GovernanceRuleEmailNotification
                {
                    IsManagerEmailNotificationDisabled = true,
                    IsOwnerEmailNotificationDisabled = false,
                },
            };
            ArmOperation<GovernanceRuleResource> lro = await governanceRule.UpdateAsync(WaitUntil.Completed, data);
            GovernanceRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GovernanceRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateGovernanceRuleOverSecurityConnectorScope()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2022-01-01-preview/examples/GovernanceRules/PutSecurityConnectorGovernanceRule_example.json
            // this example is just showing the usage of "GovernanceRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GovernanceRuleResource created on azure
            // for more information of creating GovernanceRuleResource, please refer to the document of GovernanceRuleResource
            string scope = "subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23/resourceGroups/gcpResourceGroup/providers/Microsoft.Security/securityConnectors/gcpconnector";
            string ruleId = "ad9a8e26-29d9-4829-bb30-e597a58cdbb8";
            ResourceIdentifier governanceRuleResourceId = GovernanceRuleResource.CreateResourceIdentifier(scope, ruleId);
            GovernanceRuleResource governanceRule = client.GetGovernanceRuleResource(governanceRuleResourceId);

            // invoke the operation
            GovernanceRuleData data = new GovernanceRuleData
            {
                DisplayName = "GCP Admin's rule",
                Description = "A rule on critical GCP recommendations",
                RemediationTimeframe = "7.00:00:00",
                IsGracePeriod = true,
                RulePriority = 200,
                IsDisabled = false,
                RuleType = GovernanceRuleType.Integrated,
                SourceResourceType = GovernanceRuleSourceResourceType.Assessments,
                ConditionSets = {BinaryData.FromObjectAsJson(new
{
conditions = new object[]
{
new Dictionary<string, object>
{
["operator"] = "In",
["property"] = "$.AssessmentKey",
["value"] = "[\"b1cd27e0-4ecc-4246-939f-49c426d9d72f\", \"fe83f80b-073d-4ccf-93d9-6797eb870201\"]"
}
},
})},
                OwnerSource = new GovernanceRuleOwnerSource
                {
                    SourceType = GovernanceRuleOwnerSourceType.Manually,
                    Value = "user@contoso.com",
                },
                GovernanceEmailNotification = new GovernanceRuleEmailNotification
                {
                    IsManagerEmailNotificationDisabled = true,
                    IsOwnerEmailNotificationDisabled = false,
                },
            };
            ArmOperation<GovernanceRuleResource> lro = await governanceRule.UpdateAsync(WaitUntil.Completed, data);
            GovernanceRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GovernanceRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateGovernanceRuleOverSubscriptionScope()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2022-01-01-preview/examples/GovernanceRules/PutGovernanceRule_example.json
            // this example is just showing the usage of "GovernanceRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GovernanceRuleResource created on azure
            // for more information of creating GovernanceRuleResource, please refer to the document of GovernanceRuleResource
            string scope = "subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string ruleId = "ad9a8e26-29d9-4829-bb30-e597a58cdbb8";
            ResourceIdentifier governanceRuleResourceId = GovernanceRuleResource.CreateResourceIdentifier(scope, ruleId);
            GovernanceRuleResource governanceRule = client.GetGovernanceRuleResource(governanceRuleResourceId);

            // invoke the operation
            GovernanceRuleData data = new GovernanceRuleData
            {
                DisplayName = "Admin's rule",
                Description = "A rule for critical recommendations",
                RemediationTimeframe = "7.00:00:00",
                IsGracePeriod = true,
                RulePriority = 200,
                IsDisabled = false,
                RuleType = GovernanceRuleType.Integrated,
                SourceResourceType = GovernanceRuleSourceResourceType.Assessments,
                ConditionSets = {BinaryData.FromObjectAsJson(new
{
conditions = new object[]
{
new Dictionary<string, object>
{
["operator"] = "In",
["property"] = "$.AssessmentKey",
["value"] = "[\"b1cd27e0-4ecc-4246-939f-49c426d9d72f\", \"fe83f80b-073d-4ccf-93d9-6797eb870201\"]"
}
},
})},
                OwnerSource = new GovernanceRuleOwnerSource
                {
                    SourceType = GovernanceRuleOwnerSourceType.Manually,
                    Value = "user@contoso.com",
                },
                GovernanceEmailNotification = new GovernanceRuleEmailNotification
                {
                    IsManagerEmailNotificationDisabled = false,
                    IsOwnerEmailNotificationDisabled = false,
                },
            };
            ArmOperation<GovernanceRuleResource> lro = await governanceRule.UpdateAsync(WaitUntil.Completed, data);
            GovernanceRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GovernanceRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Execute_ExecuteGovernanceRuleOverSubscriptionScope()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2022-01-01-preview/examples/GovernanceRules/PostGovernanceRule_example.json
            // this example is just showing the usage of "GovernanceRules_Execute" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GovernanceRuleResource created on azure
            // for more information of creating GovernanceRuleResource, please refer to the document of GovernanceRuleResource
            string scope = "subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string ruleId = "ad9a8e26-29d9-4829-bb30-e597a58cdbb8";
            ResourceIdentifier governanceRuleResourceId = GovernanceRuleResource.CreateResourceIdentifier(scope, ruleId);
            GovernanceRuleResource governanceRule = client.GetGovernanceRuleResource(governanceRuleResourceId);

            // invoke the operation
            await governanceRule.ExecuteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Execute_ExecuteGovernanceRuleOverManagementGroupScope()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2022-01-01-preview/examples/GovernanceRules/PostManagementGroupGovernanceRule_example.json
            // this example is just showing the usage of "GovernanceRules_Execute" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GovernanceRuleResource created on azure
            // for more information of creating GovernanceRuleResource, please refer to the document of GovernanceRuleResource
            string scope = "providers/Microsoft.Management/managementGroups/contoso";
            string ruleId = "ad9a8e26-29d9-4829-bb30-e597a58cdbb8";
            ResourceIdentifier governanceRuleResourceId = GovernanceRuleResource.CreateResourceIdentifier(scope, ruleId);
            GovernanceRuleResource governanceRule = client.GetGovernanceRuleResource(governanceRuleResourceId);

            // invoke the operation
            await governanceRule.ExecuteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Execute_ExecuteGovernanceRuleOverSecurityConnectorScope()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2022-01-01-preview/examples/GovernanceRules/PostSecurityConnectorGovernanceRule_example.json
            // this example is just showing the usage of "GovernanceRules_Execute" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GovernanceRuleResource created on azure
            // for more information of creating GovernanceRuleResource, please refer to the document of GovernanceRuleResource
            string scope = "subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23/resourceGroups/gcpResourceGroup/providers/Microsoft.Security/securityConnectors/gcpconnector";
            string ruleId = "ad9a8e26-29d9-4829-bb30-e597a58cdbb8";
            ResourceIdentifier governanceRuleResourceId = GovernanceRuleResource.CreateResourceIdentifier(scope, ruleId);
            GovernanceRuleResource governanceRule = client.GetGovernanceRuleResource(governanceRuleResourceId);

            // invoke the operation
            await governanceRule.ExecuteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }
    }
}
