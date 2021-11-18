// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for ManagedInstancePrivateEndpointConnection. </summary>
    public partial class ManagedInstancePrivateEndpointConnectionCollectionMockTests : MockTestBase
    {
        public ManagedInstancePrivateEndpointConnectionCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
        }

        public ManagedInstancePrivateEndpointConnectionCollectionMockTests() : this(false)
        {
        }

        private async Task<Sql.ManagedInstancePrivateEndpointConnectionCollection> GetManagedInstancePrivateEndpointConnectionCollectionAsync(string resourceGroupName, string managedInstanceName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            ManagedInstanceCollection managedInstanceCollection = resourceGroup.GetManagedInstances();
            var managedInstanceOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(managedInstanceCollection, managedInstanceName);
            ManagedInstance managedInstance = managedInstanceOperation.Value;
            ManagedInstancePrivateEndpointConnectionCollection managedInstancePrivateEndpointConnectionCollection = managedInstance.GetManagedInstancePrivateEndpointConnections();
            return managedInstancePrivateEndpointConnectionCollection;
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Approve or reject a private endpoint connection with a given name.
            var collection = await GetManagedInstancePrivateEndpointConnectionCollectionAsync("Default", "test-cl");
            await TestHelper.CreateOrUpdateExampleInstanceAsync(collection, "private-endpoint-connection-name");
        }

        [RecordedTest]
        public async Task GetAllAsync()
        {
            // Example: Gets list of private endpoint connections on a server.
            var collection = await GetManagedInstancePrivateEndpointConnectionCollectionAsync("Default", "test-cl");
            TestHelper.GetAllExampleInstanceAsync(collection).AsPages();
        }
    }
}
