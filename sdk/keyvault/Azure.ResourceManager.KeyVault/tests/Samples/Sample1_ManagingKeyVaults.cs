// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
#region Snippet:Manage_KeyVaults_Namespaces
using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;
#endregion Snippet:Manage_KeyVaults_Namespaces

namespace Azure.ResourceManager.KeyVault.Tests.Samples
{
    public class Sample1_ManagingKeyVaults
    {
        private ResourceGroupResource resourceGroup;

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate()
        {
            #region Snippet:Managing_KeyVaults_CreateAVault
            KeyVaultCollection vaultCollection = resourceGroup.GetKeyVaults();

            string vaultName = "myVault";
            Guid tenantIdGuid = new Guid("Your tenantId");
            string objectId = "Your Object Id";
            IdentityAccessPermissions permissions = new IdentityAccessPermissions
            {
                Keys = { new IdentityAccessKeyPermission("all") },
                Secrets = { new IdentityAccessSecretPermission("all") },
                Certificates = { new IdentityAccessCertificatePermission("all") },
                Storage = { new IdentityAccessStoragePermission("all") },
            };
            KeyVaultAccessPolicy AccessPolicy = new KeyVaultAccessPolicy(tenantIdGuid, objectId, permissions);

            KeyVaultProperties VaultProperties = new KeyVaultProperties(tenantIdGuid, new KeyVaultSku(KeyVaultSkuFamily.A, KeyVaultSkuName.Standard));
            VaultProperties.EnabledForDeployment = true;
            VaultProperties.EnabledForDiskEncryption = true;
            VaultProperties.EnabledForTemplateDeployment = true;
            VaultProperties.EnableSoftDelete = true;
            VaultProperties.VaultUri = new Uri("http://vaulturi.com");
            VaultProperties.NetworkRuleSet = new KeyVaultNetworkRuleSet()
            {
                Bypass = "AzureServices",
                DefaultAction = "Allow",
                IPRules =
                {
                    new KeyVaultIPRule("1.2.3.4/32"),
                    new KeyVaultIPRule("1.0.0.0/25")
                }
            };
            VaultProperties.AccessPolicies.Add(AccessPolicy);

            KeyVaultCreateOrUpdateContent parameters = new KeyVaultCreateOrUpdateContent(AzureLocation.WestUS, VaultProperties);

            var rawVault = await vaultCollection.CreateOrUpdateAsync(WaitUntil.Started, vaultName, parameters).ConfigureAwait(false);
            KeyVaultResource vault = await rawVault.WaitForCompletionAsync();
            #endregion
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task List()
        {
            #region Snippet:Managing_KeyVaults_ListAllVaults
            KeyVaultCollection vaultCollection = resourceGroup.GetKeyVaults();

            AsyncPageable<KeyVaultResource> response = vaultCollection.GetAllAsync();
            await foreach (KeyVaultResource vault in response)
            {
                Console.WriteLine(vault.Data.Name);
            }
            #endregion
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task Get()
        {
            #region Snippet:Managing_KeyVaults_GetAVault
            KeyVaultCollection vaultCollection = resourceGroup.GetKeyVaults();

            KeyVaultResource vault = await vaultCollection.GetAsync("myVault");
            Console.WriteLine(vault.Data.Name);
            #endregion
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task Delete()
        {
            #region Snippet:Managing_KeyVaults_DeleteAVault
            KeyVaultCollection vaultCollection = resourceGroup.GetKeyVaults();

            KeyVaultResource vault = await vaultCollection.GetAsync("myVault");
            await vault.DeleteAsync(WaitUntil.Completed);
            #endregion
        }

        [SetUp]
        protected async Task initialize()
        {
            #region Snippet:Readme_DefaultSubscription
            ArmClient armClient = new ArmClient(new DefaultAzureCredential());
            SubscriptionResource subscription = await armClient.GetDefaultSubscriptionAsync();
            #endregion

            #region Snippet:Readme_GetResourceGroupCollection
            ResourceGroupCollection rgCollection = subscription.GetResourceGroups();
            // With the collection, we can create a new resource group with an specific name
            string rgName = "myRgName";
            AzureLocation location = AzureLocation.WestUS2;
            ResourceGroupResource resourceGroup = await rgCollection.CreateOrUpdate(WaitUntil.Completed, rgName, new ResourceGroupData(location)).WaitForCompletionAsync();
            #endregion

            this.resourceGroup = resourceGroup;
        }
    }
}
