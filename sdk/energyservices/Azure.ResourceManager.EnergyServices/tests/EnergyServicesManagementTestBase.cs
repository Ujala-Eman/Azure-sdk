﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.EnergyServices.Models;
using Azure.ResourceManager.EnergyServices.Tests.Infrastructure;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Azure.ResourceManager.EnergyServices.Tests
{
    public class EnergyServicesManagementTestBase : ManagementRecordedTestBase<EnergyServicesManagementTestEnvironment>
    {
        public string SubscriptionId { get; set; }
        public ArmClient ArmClient { get; private set; }
        public ResourceGroupCollection ResourceGroupsOperations { get; set; }
        public SubscriptionResource Subscription { get; set; }

        protected EnergyServicesManagementTestBase(bool isAsync, RecordedTestMode mode)
        : base(isAsync, mode)
        {
        }

        protected EnergyServicesManagementTestBase(bool isAsync)
            : base(isAsync)
        {
        }

        [SetUp]
        public async Task CreateCommonClient()
        {
            Mode = RecordedTestMode.Live;
            ArmClient = GetArmClient();
            Subscription = await ArmClient.GetDefaultSubscriptionAsync();
            ResourceGroupsOperations = Subscription.GetResourceGroups();
        }

        protected async Task<ResourceGroupResource> CreateResourceGroup(SubscriptionResource subscription, string rgNamePrefix, AzureLocation location)
        {
            string rgName = Recording.GenerateAssetName(rgNamePrefix);
            ResourceGroupData input = new ResourceGroupData(location);
            var lro = await subscription.GetResourceGroups().CreateOrUpdateAsync(WaitUntil.Completed, rgNamePrefix, input);
            return lro.Value;
        }

        public async Task<ResourceGroupResource> GetResourceGroupAsync(string name)
        {
            return await Subscription.GetResourceGroups().GetAsync(name);
        }

        protected async Task<EnergyServiceCollection> GetEnergyServicesCollectionAsync(string resourceGroupName)
        {
            ResourceGroupResource rg = await GetResourceGroupAsync(resourceGroupName);
            return rg.GetEnergyServices();
        }

        protected EnergyServiceData GetDefaultEnergyServiceData()
        {
            List<DataPartitionNames> dataPartitionNames = new List<DataPartitionNames>();
            dataPartitionNames.Add(new DataPartitionNames("dp"));

            EnergyServiceData energyServiceData = new EnergyServiceData(AzureLocation.EastUS);
            var properties = new EnergyServiceProperties("" ,null, "50BC6073-5E08-4A2A-BFE9-8CB317ABED9D", dataPartitionNames);
            
            energyServiceData.Properties = properties;
            return energyServiceData;
        }
    }
}
