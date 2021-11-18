// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for WorkloadClassifier. </summary>
    public partial class WorkloadClassifierMockTests : MockTestBase
    {
        public WorkloadClassifierMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
        }

        public WorkloadClassifierMockTests() : this(false)
        {
        }

        private async Task<Sql.WorkloadClassifierCollection> GetWorkloadClassifierCollectionAsync(string resourceGroupName, string serverName, string databaseName, string workloadGroupName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            ServerCollection serverCollection = resourceGroup.GetServers();
            var serverOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(serverCollection, serverName);
            Server server = serverOperation.Value;
            DatabaseCollection databaseCollection = server.GetDatabases();
            var databaseOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(databaseCollection, databaseName);
            Database database = databaseOperation.Value;
            WorkloadGroupCollection workloadGroupCollection = database.GetWorkloadGroups();
            var workloadGroupOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(workloadGroupCollection, workloadGroupName);
            WorkloadGroup workloadGroup = workloadGroupOperation.Value;
            WorkloadClassifierCollection workloadClassifierCollection = workloadGroup.GetWorkloadClassifiers();
            return workloadClassifierCollection;
        }

        private async Task<Sql.WorkloadClassifier> GetWorkloadClassifierAsync()
        {
            var collection = await GetWorkloadClassifierCollectionAsync("Default-SQL-SouthEastAsia", "testsvr", "testdb", "wlm_workloadgroup");
            var createOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(collection, "wlm_workloadclassifier");
            return createOperation.Value;
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Gets a workload classifier for a data warehouse
            var resource = await GetWorkloadClassifierAsync();

            await resource.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: Delete a workload classifier
            var resource = await GetWorkloadClassifierAsync();

            await resource.DeleteAsync();
        }
    }
}
