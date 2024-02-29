﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using NUnit.Framework;
using Azure.Provisioning.ResourceManager;
using System;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.Core.Tests.TestFramework;
using Azure.Identity;
using Azure.Provisioning.AppService;
using Azure.Provisioning.KeyVaults;
using Azure.Provisioning.Sql;
using Azure.Provisioning.Resources;
using Azure.Provisioning.Storage;
using Azure.Provisioning.AppConfiguration;
using Azure.Provisioning.Authorization;
using Azure.ResourceManager;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.Provisioning.Tests
{
    public class ProvisioningTests
    {
        private static readonly string _infrastructureRoot = Path.Combine(GetGitRoot(), "sdk", "provisioning", "Azure.Provisioning", "tests", "Infrastructure");

        [Test]
        public async Task WebSiteUsingL1()
        {
            var infra = new TestInfrastructure();

            Parameter sqlAdminPasswordParam = new Parameter("sqlAdminPassword", "SQL Server administrator password", isSecure: true);
            infra.AddParameter(sqlAdminPasswordParam);
            Parameter appUserPasswordParam = new Parameter("appUserPassword", "Application user password", isSecure: true);
            infra.AddParameter(appUserPasswordParam);

            infra.AddResourceGroup();
            infra.GetSingleResource<ResourceGroup>()!.Properties.Tags.Add("key", "value");

            AppServicePlan appServicePlan = infra.AddAppServicePlan();

            WebSite frontEnd = new WebSite(infra, "frontEnd", appServicePlan, WebSiteRuntime.Node, "18-lts");
            Assert.AreEqual(Environment.GetEnvironmentVariable("AZURE_SUBSCRIPTION_ID"), frontEnd.Properties.AppServicePlanId.SubscriptionId);

            var frontEndPrincipalId = frontEnd.AddOutput(
                website => website.Identity.PrincipalId, //Identity.PrincipalId
                "SERVICE_API_IDENTITY_PRINCIPAL_ID",
                isSecure: true);

            infra.AddKeyVault()
                .AddAccessPolicy(frontEndPrincipalId); // frontEnd.properties.identity.principalId

            KeyVaultSecret sqlAdminSecret = new KeyVaultSecret(infra, "sqlAdminPassword");
            sqlAdminSecret.AssignParameter(secret => secret.Properties.Value, sqlAdminPasswordParam);

            KeyVaultSecret appUserSecret = new KeyVaultSecret(infra, "appUserPassword");
            appUserSecret.AssignParameter(secret => secret.Properties.Value, appUserPasswordParam);

            SqlServer sqlServer = new SqlServer(infra, "sqlserver");
            sqlServer.AssignParameter(sql => sql.AdministratorLoginPassword, sqlAdminPasswordParam);
            Output sqlServerName = sqlServer.AddOutput(sql => sql.FullyQualifiedDomainName, "sqlServerName");

            SqlDatabase sqlDatabase = new SqlDatabase(infra, sqlServer);

            KeyVaultSecret sqlAzureConnectionStringSecret = new KeyVaultSecret(infra, "connectionString", sqlDatabase.GetConnectionString(appUserPasswordParam));

            SqlFirewallRule sqlFirewallRule = new SqlFirewallRule(infra, "firewallRule");

            DeploymentScript deploymentScript = new DeploymentScript(
                infra,
                "cliScript",
                sqlDatabase,
                new Parameter(sqlServerName),
                appUserPasswordParam,
                sqlAdminPasswordParam);

            WebSite backEnd = new WebSite(infra, "backEnd", appServicePlan, WebSiteRuntime.Dotnetcore, "6.0");

            WebSiteConfigLogs logs = new WebSiteConfigLogs(infra, "logs", frontEnd);

            infra.Build(GetOutputPath());

            await ValidateBicepAsync(BinaryData.FromObjectAsJson(
                new
                {
                    sqlAdminPassword = new { value = "password" },
                    appUserPassword = new { value = "password" }
                }));
        }

        [Test]
        public async Task ResourceGroupOnly()
        {
            TestInfrastructure infrastructure = new TestInfrastructure();
            var resourceGroup = infrastructure.AddResourceGroup();
            infrastructure.Build(GetOutputPath());

            await ValidateBicepAsync();
        }

        [Test]
        public async Task WebSiteUsingL2()
        {
            var infra = new TestInfrastructure();
            infra.AddFrontEndWebSite();
            Assert.AreEqual(Environment.GetEnvironmentVariable("AZURE_SUBSCRIPTION_ID"), infra.GetSingleResourceInScope<WebSite>()!.Properties.AppServicePlanId.SubscriptionId);

            infra.AddCommonSqlDatabase();
            infra.AddBackEndWebSite();

            infra.GetSingleResource<ResourceGroup>()!.Properties.Tags.Add("key", "value");
            infra.Build(GetOutputPath());

            await ValidateBicepAsync(BinaryData.FromObjectAsJson(
                new
                {
                    sqlAdminPassword = new { value = "password" },
                    appUserPassword = new { value = "password" }
                }));
        }

        [Test]
        public async Task WebSiteUsingL3()
        {
            var infra = new TestInfrastructure();
            infra.AddWebSiteWithSqlBackEnd();

            infra.GetSingleResource<ResourceGroup>()!.Properties.Tags.Add("key", "value");
            infra.GetSingleResourceInScope<KeyVault>()!.Properties.Tags.Add("key", "value");

            var subscriptionId = Environment.GetEnvironmentVariable("AZURE_SUBSCRIPTION_ID");
            foreach (var website in infra.GetResources().Where(r => r is WebSite))
            {
                Assert.AreEqual(subscriptionId, ((WebSite)website).Properties.AppServicePlanId.SubscriptionId);
            }

            infra.Build(GetOutputPath());

            await ValidateBicepAsync(BinaryData.FromObjectAsJson(
                new
                {
                    sqlAdminPassword = new { value = "password" },
                    appUserPassword = new { value = "password" }
                }));
        }

        [Test]
        public async Task WebSiteUsingL3SpecificSubscription()
        {
            var infra = new TestInfrastructure(Guid.Empty);
            infra.AddWebSiteWithSqlBackEnd();

            infra.GetSingleResource<ResourceGroup>()!.Properties.Tags.Add("key", "value");
            infra.GetSingleResourceInScope<KeyVault>()!.Properties.Tags.Add("key", "value");
            foreach (var website in infra.GetResources().Where(r => r is WebSite))
            {
                Assert.AreEqual(Guid.Empty.ToString(), ((WebSite)website).Properties.AppServicePlanId.SubscriptionId);
            }

            infra.Build(GetOutputPath());

            await ValidateBicepAsync(BinaryData.FromObjectAsJson(
                new
                {
                    sqlAdminPassword = new { value = "password" },
                    appUserPassword = new { value = "password" }
                }));
        }

        [Test]
        public async Task WebSiteUsingL3ResourceGroupScope()
        {
            var infra = new TestInfrastructure(scope: ConstructScope.ResourceGroup, configuration: new Configuration { UseInteractiveMode = true });
            infra.AddWebSiteWithSqlBackEnd();

            infra.GetSingleResource<ResourceGroup>()!.Properties.Tags.Add("key", "value");
            infra.GetSingleResourceInScope<KeyVault>()!.Properties.Tags.Add("key", "value");

            foreach (var website in infra.GetResources().Where(r => r is WebSite))
            {
                Assert.AreEqual("subscription()", ((WebSite)website).Properties.AppServicePlanId.SubscriptionId);
                Assert.AreEqual("resourceGroup()", ((WebSite)website).Properties.AppServicePlanId.ResourceGroupName);
            }

            infra.Build(GetOutputPath());

            await ValidateBicepAsync(BinaryData.FromObjectAsJson(
                new
                {
                    sqlAdminPassword = new { value = "password" },
                    appUserPassword = new { value = "password" }
                }), interactiveMode: true);
        }

        [Test]
        public async Task StorageBlobDefaults()
        {
            var infra = new TestInfrastructure();
            var storageAccount = infra.AddStorageAccount(name: "photoAcct", sku: StorageSkuName.PremiumLrs, kind: StorageKind.BlockBlobStorage);
            infra.AddBlobService();
            infra.Build(GetOutputPath());

            await ValidateBicepAsync();
        }

        [Test]
        public async Task RoleAssignmentWithParameter()
        {
            var infra = new TestInfrastructure(configuration: new Configuration { UseInteractiveMode = true });
            var storageAccount = infra.AddStorageAccount(name: "photoAcct", sku: StorageSkuName.PremiumLrs, kind: StorageKind.BlockBlobStorage);
            infra.AddBlobService();
            storageAccount.AssignRole(RoleDefinition.StorageBlobDataContributor);
            infra.Build(GetOutputPath());

            await ValidateBicepAsync(BinaryData.FromObjectAsJson(new { principalId = new { value = Guid.Empty }}), interactiveMode: true);
        }

        [Test]
        public async Task RoleAssignmentWithoutParameter()
        {
            var infra = new TestInfrastructure();
            var storageAccount = infra.AddStorageAccount(name: "photoAcct", sku: StorageSkuName.PremiumLrs, kind: StorageKind.BlockBlobStorage);
            infra.AddBlobService();
            storageAccount.AssignRole(RoleDefinition.StorageBlobDataContributor, Guid.Empty);
            infra.Build(GetOutputPath());

            await ValidateBicepAsync();
        }

        [Test]
        public async Task RoleAssignmentWithoutParameterInteractiveMode()
        {
            var infra = new TestInfrastructure(configuration: new Configuration { UseInteractiveMode = true });
            var storageAccount = infra.AddStorageAccount(name: "photoAcct", sku: StorageSkuName.PremiumLrs, kind: StorageKind.BlockBlobStorage);
            infra.AddBlobService();
            storageAccount.AssignRole(RoleDefinition.StorageBlobDataContributor, Guid.Empty);
            infra.Build(GetOutputPath());

            await ValidateBicepAsync(interactiveMode: true);
        }

        [Test]
        public void RoleAssignmentPrincipalMustBeSuppliedInNonInteractiveMode()
        {
            var infra = new TestInfrastructure();
            var storageAccount = infra.AddStorageAccount(name: "photoAcct", sku: StorageSkuName.PremiumLrs, kind: StorageKind.BlockBlobStorage);
            infra.AddBlobService();

            Assert.Throws<InvalidOperationException>(() => storageAccount.AssignRole(RoleDefinition.StorageBlobDataContributor));
        }

        [Test]
        public async Task StorageBlobDefaultsInPromptMode()
        {
            var infra = new TestInfrastructure(configuration: new Configuration { UseInteractiveMode = true });
            infra.AddStorageAccount(name: "photoAcct", sku: StorageSkuName.PremiumLrs, kind: StorageKind.BlockBlobStorage);
            infra.AddBlobService();
            infra.Build(GetOutputPath());

            await ValidateBicepAsync(interactiveMode: true);
        }

        [Test]
        public void CannotAddLocationParameterInPromptMode()
        {
            var infra = new TestInfrastructure(configuration: new Configuration { UseInteractiveMode = true });
            var sa = infra.AddStorageAccount(name: "photoAcct", sku: StorageSkuName.PremiumLrs, kind: StorageKind.BlockBlobStorage);
            Assert.Throws<InvalidOperationException>(() =>
                sa.AssignParameter(d => d.Location, new Parameter("myLocationParam")));
        }

        [Test]
        public void CannotOverrideSamePropertyMoreThanOnce()
        {
            var infra = new TestInfrastructure();
            var sa = infra.AddStorageAccount(name: "photoAcct", sku: StorageSkuName.PremiumLrs, kind: StorageKind.BlockBlobStorage);

            sa.AssignParameter(d => d.Kind, new Parameter("skuParam"));
            Assert.Throws<InvalidOperationException>(() =>
                sa.AssignProperty(d => d.Kind, StorageKind.BlockBlobStorage.ToString()));
            Assert.Throws<InvalidOperationException>(() =>
                sa.AssignParameter(d => d.Kind, new Parameter("skuParam")));

            sa.AssignProperty(d => d.AccessTier, StorageAccountAccessTier.Cool.ToString());
            Assert.Throws<InvalidOperationException>(() =>
                sa.AssignProperty(d => d.AccessTier, StorageAccountAccessTier.Cool.ToString()));
            Assert.Throws<InvalidOperationException>(() =>
                sa.AssignParameter(d => d.AccessTier, new Parameter("tierParam")));
        }

        [Test]
        public async Task StorageBlobDropDown()
        {
            var infra = new TestInfrastructure();
            infra.AddStorageAccount(name: "photoAcct", sku: StorageSkuName.PremiumLrs, kind: StorageKind.BlockBlobStorage);
            var blob = infra.AddBlobService();
            blob.Properties.DeleteRetentionPolicy = new DeleteRetentionPolicy()
            {
                IsEnabled = true
            };
            infra.Build(GetOutputPath());

            await ValidateBicepAsync();
        }

        [Test]
        public async Task AppConfiguration()
        {
            var infra = new TestInfrastructure();
            infra.AddAppConfigurationStore();
            infra.Build(GetOutputPath());

            await ValidateBicepAsync();
        }

        [Test]
        public void MultipleSubscriptions()
        {
            // ensure deterministic subscription names and directories
            var random = new TestRandom(RecordedTestMode.Playback, 1);
            var infra = new TestSubscriptionInfrastructure();
            var sub1 = new Subscription(infra, random.NewGuid());
            var sub2 = new Subscription(infra, random.NewGuid());
            _ = new ResourceGroup(infra, parent: sub1);
            _ = new ResourceGroup(infra, parent: sub2);
            infra.Build(GetOutputPath());

            // Multiple subscriptions are not fully supported yet. https://github.com/Azure/azure-sdk-for-net/issues/42146
            // await ValidateBicepAsync();
        }

        [Test]
        public async Task OutputsSpanningModules()
        {
            var infra = new TestInfrastructure();
            var rg1 = new ResourceGroup(infra, "rg1");
            var rg2 = new ResourceGroup(infra, "rg2");
            var rg3 = new ResourceGroup(infra, "rg3");
            var appServicePlan = infra.AddAppServicePlan(parent: rg1);
            WebSite frontEnd1 = new WebSite(infra, "frontEnd", appServicePlan, WebSiteRuntime.Node, "18-lts", parent: rg1);

            var output1 = frontEnd1.AddOutput(data => data.Identity.PrincipalId, "STORAGE_PRINCIPAL_ID");
            var output2 = frontEnd1.AddOutput(data => data.Location, "LOCATION");

            KeyVault keyVault = infra.AddKeyVault(resourceGroup: rg1);
            keyVault.AssignParameter(data => data.Properties.EnableSoftDelete, new Parameter("enableSoftDelete", "Enable soft delete", defaultValue: true, isSecure: false));

            WebSite frontEnd2 = new WebSite(infra, "frontEnd", appServicePlan, WebSiteRuntime.Node, "18-lts", parent: rg2);

            frontEnd2.AssignParameter(data => data.Identity.PrincipalId, new Parameter(output1));

            var testFrontEndWebSite = new TestFrontEndWebSite(infra, parent: rg3);
            infra.Build(GetOutputPath());

            Assert.AreEqual(3, infra.GetParameters().Count());
            Assert.AreEqual(4, infra.GetOutputs().Count());

            Assert.AreEqual(0, testFrontEndWebSite.GetParameters().Count());
            Assert.AreEqual(1, testFrontEndWebSite.GetOutputs().Count());

            await ValidateBicepAsync();
        }

        public async Task ValidateBicepAsync(BinaryData? parameters = null, bool interactiveMode = false)
        {
            if (TestEnvironment.GlobalIsRunningInCI)
            {
                return;
            }

            var testPath = Path.Combine(_infrastructureRoot, TestContext.CurrentContext.Test.Name);
            var client = new ArmClient(new DefaultAzureCredential());
            ResourceGroupResource? rg = null;

            SubscriptionResource subscription = await client.GetSubscriptions().GetAsync(Environment.GetEnvironmentVariable("SUBSCRIPTION_ID"));

            try
            {
                var bicepPath = Path.Combine(testPath, "main.bicep");
                var args = Path.Combine(
                    TestEnvironment.RepositoryRoot,
                    "eng",
                    "scripts",
                    $"Validate-Bicep.ps1 {bicepPath}");
                var processInfo = new ProcessStartInfo("pwsh.exe", args)
                {
                    UseShellExecute = false, RedirectStandardOutput = true, RedirectStandardError = true,
                };
                var process = Process.Start(processInfo);
                while (!process!.HasExited && !process!.StandardError.EndOfStream)
                {
                    var error = process.StandardError.ReadLine();
                    TestContext.Progress.WriteLine(error);
                    if (error!.StartsWith("ERROR"))
                    {
                        Assert.Fail(error);
                    }
                }

                ResourceIdentifier scope;
                if (interactiveMode)
                {
                    var rgs = subscription.GetResourceGroups();
                    var data = new ResourceGroupData("westus");
                    rg = (await rgs.CreateOrUpdateAsync(WaitUntil.Completed, TestContext.CurrentContext.Test.Name, data)).Value;
                    scope = ResourceGroupResource.CreateResourceIdentifier(subscription.Id.SubscriptionId,
                        TestContext.CurrentContext.Test.Name);
                }
                else
                {
                    scope = subscription.Id;
                }

                var resource = client.GetArmDeploymentResource(ArmDeploymentResource.CreateResourceIdentifier(scope, TestContext.CurrentContext.Test.Name));
                var content = new ArmDeploymentContent(
                    new ArmDeploymentProperties(ArmDeploymentMode.Incremental)
                    {
                        Template = new BinaryData(File.ReadAllText(Path.Combine(testPath, "main.json"))),
                        Parameters = parameters
                    });
                if (!interactiveMode)
                {
                    content.Location = "westus";
                }
                await resource.ValidateAsync(WaitUntil.Completed, content);
            }
            finally
            {
                File.Delete(Path.Combine(testPath, "main.json"));
                if (rg != null)
                {
                    await rg.DeleteAsync(WaitUntil.Completed);
                }
            }
        }

        private static string GetGitRoot()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "git",
                Arguments = "rev-parse --show-toplevel",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(startInfo)!)
            {
                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    string gitRoot = process.StandardOutput.ReadToEnd().Trim();
                    return gitRoot;
                }
                else
                {
                    throw new Exception("Failed to get the root of the Git repository.");
                }
            }
        }

        private string GetOutputPath()
        {
            string output = Path.Combine(_infrastructureRoot, TestContext.CurrentContext.Test.Name);
            if (!Directory.Exists(output))
            {
                Directory.CreateDirectory(output);
            }
            return output;
        }
    }
}
