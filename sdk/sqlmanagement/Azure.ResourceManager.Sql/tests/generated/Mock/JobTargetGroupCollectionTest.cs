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
    /// <summary> Test for JobTargetGroup. </summary>
    public partial class JobTargetGroupCollectionMockTests : MockTestBase
    {
        public JobTargetGroupCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
        }

        public JobTargetGroupCollectionMockTests() : this(false)
        {
        }

        private async Task<Sql.JobTargetGroupCollection> GetJobTargetGroupCollectionAsync(string resourceGroupName, string serverName, string jobAgentName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            ServerCollection serverCollection = resourceGroup.GetServers();
            var serverOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(serverCollection, serverName);
            Server server = serverOperation.Value;
            JobAgentCollection jobAgentCollection = server.GetJobAgents();
            var jobAgentOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(jobAgentCollection, jobAgentName);
            JobAgent jobAgent = jobAgentOperation.Value;
            JobTargetGroupCollection jobTargetGroupCollection = jobAgent.GetJobTargetGroups();
            return jobTargetGroupCollection;
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create or update a target group with all properties.
            var collection = await GetJobTargetGroupCollectionAsync("group1", "server1", "agent1");
            await TestHelper.CreateOrUpdateExampleInstanceAsync(collection, "targetGroup1");
        }

        [RecordedTest]
        public async Task GetAllAsync()
        {
            // Example: Get all target groups in an agent.
            var collection = await GetJobTargetGroupCollectionAsync("group1", "server1", "agent1");
            TestHelper.GetAllExampleInstanceAsync(collection).AsPages();
        }
    }
}
