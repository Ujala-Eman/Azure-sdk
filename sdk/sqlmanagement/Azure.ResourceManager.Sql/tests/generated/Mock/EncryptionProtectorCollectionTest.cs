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
    /// <summary> Test for EncryptionProtector. </summary>
    public partial class EncryptionProtectorCollectionMockTests : MockTestBase
    {
        public EncryptionProtectorCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
        }

        public EncryptionProtectorCollectionMockTests() : this(false)
        {
        }

        private async Task<Sql.EncryptionProtectorCollection> GetEncryptionProtectorCollectionAsync(string resourceGroupName, string serverName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            ServerCollection serverCollection = resourceGroup.GetServers();
            var serverOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(serverCollection, serverName);
            Server server = serverOperation.Value;
            EncryptionProtectorCollection encryptionProtectorCollection = server.GetEncryptionProtectors();
            return encryptionProtectorCollection;
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Update the encryption protector to key vault
            var collection = await GetEncryptionProtectorCollectionAsync("sqlcrudtest-7398", "sqlcrudtest-4645");
            await TestHelper.CreateOrUpdateExampleInstanceAsync(collection);
        }

        [RecordedTest]
        public async Task GetAllAsync()
        {
            // Example: List encryption protectors by server
            var collection = await GetEncryptionProtectorCollectionAsync("sqlcrudtest-7398", "sqlcrudtest-4645");
            TestHelper.GetAllExampleInstanceAsync(collection).AsPages();
        }
    }
}
