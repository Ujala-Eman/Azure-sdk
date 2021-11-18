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
    /// <summary> Test for SyncGroup. </summary>
    public partial class SyncGroupCollectionMockTests : MockTestBase
    {
        public SyncGroupCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
        }

        public SyncGroupCollectionMockTests() : this(false)
        {
        }

        private async Task<Sql.SyncGroupCollection> GetSyncGroupCollectionAsync(string resourceGroupName, string serverName, string databaseName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            ServerCollection serverCollection = resourceGroup.GetServers();
            var serverOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(serverCollection, serverName);
            Server server = serverOperation.Value;
            DatabaseCollection databaseCollection = server.GetDatabases();
            var databaseOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(databaseCollection, databaseName);
            Database database = databaseOperation.Value;
            SyncGroupCollection syncGroupCollection = database.GetSyncGroups();
            return syncGroupCollection;
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create a sync group
            var collection = await GetSyncGroupCollectionAsync("syncgroupcrud-65440", "syncgroupcrud-8475", "syncgroupcrud-4328");
            await TestHelper.CreateOrUpdateExampleInstanceAsync(collection, "syncgroupcrud-3187");
        }

        [RecordedTest]
        public async Task GetAllAsync()
        {
            // Example: List sync groups under a given database
            var collection = await GetSyncGroupCollectionAsync("syncgroupcrud-65440", "syncgroupcrud-8475", "syncgroupcrud-4328");
            TestHelper.GetAllExampleInstanceAsync(collection).AsPages();
        }
    }
}
