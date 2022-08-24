﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;
using System.Threading.Tasks;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.KeyVault;
using System;

namespace Azure.ResourceManager.Logic.Tests
{
    public class LogicManagementTestBase : ManagementRecordedTestBase<LogicManagementTestEnvironment>
    {
        protected ArmClient Client { get; private set; }
        protected const string ResourceGroupNamePrefix = "LogicAppRG-";
        protected LogicManagementTestBase(bool isAsync, RecordedTestMode mode)
        : base(isAsync, mode)
        {
        }

        protected LogicManagementTestBase(bool isAsync)
            : base(isAsync)
        {
        }

        [SetUp]
        public void CreateCommonClient()
        {
            Client = GetArmClient();
        }

        protected async Task<ResourceGroupResource> CreateResourceGroup(AzureLocation location)
        {
            SubscriptionResource subscription = await Client.GetDefaultSubscriptionAsync();
            string rgName = Recording.GenerateAssetName(ResourceGroupNamePrefix);
            ResourceGroupData input = new ResourceGroupData(location);
            var lro = await subscription.GetResourceGroups().CreateOrUpdateAsync(WaitUntil.Completed, rgName, input);
            return lro.Value;
        }

        protected async Task<IntegrationAccountResource> CreateIntegrationAccount(ResourceGroupResource resourceGroup, string integrationAccountName)
        {
            IntegrationAccountData data = new IntegrationAccountData(resourceGroup.Data.Location)
            {
                SkuName = IntegrationAccountSkuName.Standard,
            };
            var integrationAccount = await resourceGroup.GetIntegrationAccounts().CreateOrUpdateAsync(WaitUntil.Completed, integrationAccountName, data);
            return integrationAccount.Value;
        }

        protected async Task<VirtualNetworkResource> CreateDefaultNetwork(ResourceGroupResource resourceGroup, string vnetName)
        {
            VirtualNetworkData data = new VirtualNetworkData()
            {
                Location = resourceGroup.Data.Location,
            };
            data.AddressPrefixes.Add("10.10.0.0/16");
            data.Subnets.Add(new SubnetData() { Name = "subnet1", AddressPrefix = "10.10.1.0/24" });
            data.Subnets.Add(new SubnetData() { Name = "subnet2", AddressPrefix = "10.10.2.0/24" });
            data.Subnets.Add(new SubnetData() { Name = "subnet3", AddressPrefix = "10.10.3.0/24" });
            data.Subnets.Add(new SubnetData() { Name = "subnet4", AddressPrefix = "10.10.4.0/24" });
            data.Subnets.Add(new SubnetData() { Name = "subnet5", AddressPrefix = "10.10.5.0/24" });
            data.Subnets[0].Delegations.Add(new ServiceDelegation() { Name = "integrationServiceEnvironments", ServiceName = "Microsoft.Logic/integrationServiceEnvironments" });
            var vnet = await resourceGroup.GetVirtualNetworks().CreateOrUpdateAsync(WaitUntil.Completed, vnetName, data);
            return vnet.Value;
        }

        protected async Task<KeyVaultResource> CreateDefaultKeyVault(ResourceGroupResource resourceGroup, string keyvaultName)
        {
            KeyVaultSku sku = new KeyVaultSku(KeyVaultSkuFamily.A, KeyVaultSkuName.Standard);
            KeyVaultProperties properties = new KeyVaultProperties(new Guid(Environment.GetEnvironmentVariable("CLIENT_ID")), sku);
            KeyVaultCreateOrUpdateContent data = new KeyVaultCreateOrUpdateContent(resourceGroup.Data.Location, properties);
            var keyvault = await resourceGroup.GetKeyVaults().CreateOrUpdateAsync(WaitUntil.Completed, keyvaultName, data);
            return keyvault.Value;
        }
    }
}
