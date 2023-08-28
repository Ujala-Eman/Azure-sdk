﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.ManagedNetworkFabric.Tests.Scenario
{
    public class InternetGatewayTests : ManagedNetworkFabricManagementTestBase
    {
        public InternetGatewayTests(bool isAsync, RecordedTestMode mode) : base(isAsync, mode) { }
        public InternetGatewayTests(bool isAsync) : base(isAsync) { }

        [Test]
        [RecordedTest]
        [AsyncOnly]
        public async Task InternetGateways_Operations()
        {
            TestContext.Out.WriteLine($"Entered into the Internet Gateway tests....");

            ResourceIdentifier networkFabricInternetGatewayResourceId = NetworkFabricInternetGatewayResource.CreateResourceIdentifier(TestEnvironment.SubscriptionId, TestEnvironment.NFCResourceGroupName, TestEnvironment.InternetGatewayName);
            NetworkFabricInternetGatewayResource networkFabricInternetGateway = Client.GetNetworkFabricInternetGatewayResource(networkFabricInternetGatewayResourceId);

            // invoke the get operation
            NetworkFabricInternetGatewayResource result = await networkFabricInternetGateway.GetAsync();
            NetworkFabricInternetGatewayData resourceData = result.Data;
            Assert.IsNotNull(resourceData);
            Assert.AreEqual(resourceData.Name, TestEnvironment.InternetGatewayName);
            TestContext.Out.WriteLine($"Get Operation Succeeded on id: {resourceData.Id}");

            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(TestEnvironment.SubscriptionId, TestEnvironment.ResourceGroupName);
            ResourceGroupResource resourceGroupResource = Client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this InternetGatewayResource
            NetworkFabricInternetGatewayCollection collection = resourceGroupResource.GetNetworkFabricInternetGateways();

            // invoke the operation and iterate over the result
            await foreach (NetworkFabricInternetGatewayResource item in collection.GetAllAsync())
            {
                NetworkFabricInternetGatewayData listResourceData = item.Data;
                Console.Out.WriteLine($"Succeeded on id: {listResourceData.Id}");
            }

            TestContext.Out.WriteLine($"List by Subscription Succeeded.");
        }
    }
}
