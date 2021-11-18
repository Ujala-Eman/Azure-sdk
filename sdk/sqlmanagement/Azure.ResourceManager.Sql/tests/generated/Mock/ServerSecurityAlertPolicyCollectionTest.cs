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
    /// <summary> Test for ServerSecurityAlertPolicy. </summary>
    public partial class ServerSecurityAlertPolicyCollectionMockTests : MockTestBase
    {
        public ServerSecurityAlertPolicyCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
        }

        public ServerSecurityAlertPolicyCollectionMockTests() : this(false)
        {
        }

        private async Task<Sql.ServerSecurityAlertPolicyCollection> GetServerSecurityAlertPolicyCollectionAsync(string resourceGroupName, string serverName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            ServerCollection serverCollection = resourceGroup.GetServers();
            var serverOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(serverCollection, serverName);
            Server server = serverOperation.Value;
            ServerSecurityAlertPolicyCollection serverSecurityAlertPolicyCollection = server.GetServerSecurityAlertPolicies();
            return serverSecurityAlertPolicyCollection;
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Update a server's threat detection policy with all parameters
            var collection = await GetServerSecurityAlertPolicyCollectionAsync("securityalert-4799", "securityalert-6440");
            await TestHelper.CreateOrUpdateExampleInstanceAsync(collection);
        }

        [RecordedTest]
        public async Task GetAllAsync()
        {
            // Example: List the server's threat detection policies
            var collection = await GetServerSecurityAlertPolicyCollectionAsync("securityalert-4799", "securityalert-6440");
            TestHelper.GetAllExampleInstanceAsync(collection).AsPages();
        }
    }
}
