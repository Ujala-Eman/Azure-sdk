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
    /// <summary> Test for Job. </summary>
    public partial class JobMockTests : MockTestBase
    {
        public JobMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
        }

        public JobMockTests() : this(false)
        {
        }

        private async Task<Sql.JobCollection> GetJobCollectionAsync(string resourceGroupName, string serverName, string jobAgentName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            ServerCollection serverCollection = resourceGroup.GetServers();
            var serverOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(serverCollection, serverName);
            Server server = serverOperation.Value;
            JobAgentCollection jobAgentCollection = server.GetJobAgents();
            var jobAgentOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(jobAgentCollection, jobAgentName);
            JobAgent jobAgent = jobAgentOperation.Value;
            JobCollection jobCollection = jobAgent.GetJobs();
            return jobCollection;
        }

        private async Task<Sql.Job> GetJobAsync()
        {
            var collection = await GetJobCollectionAsync("group1", "server1", "agent1");
            var createOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(collection, "job1");
            return createOperation.Value;
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get a job
            var resource = await GetJobAsync();

            await resource.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: Delete a job
            var resource = await GetJobAsync();

            await resource.DeleteAsync();
        }

        [RecordedTest]
        public async Task CreateJobExecutionAsync()
        {
            // Example: Start a job execution.
            var resource = await GetJobAsync();

            await resource.CreateJobExecutionAsync();
        }
    }
}
