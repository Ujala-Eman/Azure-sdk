﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core.Testing;
using Azure.Storage.Test;
using Azure.Storage.Queues.Models;
using Azure.Storage.Queues.Tests;
using NUnit.Framework;
using Azure.Core;
using Azure.Storage.Sas;

namespace Azure.Storage.Queues.Test
{
    public class QueueClientTests : QueueTestBase
    {
        public QueueClientTests(bool async)
            : base(async, null /* RecordedTestMode.Record /* to re-record */)
        {
        }

        [Test]
        public void Ctor_ConnectionString()
        {
            var accountName = "accountName";
            var accountKey = Convert.ToBase64String(new byte[] { 0, 1, 2, 3, 4, 5 });

            var credentials = new StorageSharedKeyCredential(accountName, accountKey);
            var queueEndpoint = new Uri("http://127.0.0.1/" + accountName);
            var queueSecondaryEndpoint = new Uri("http://127.0.0.1/" + accountName + "-secondary");

            var connectionString = new StorageConnectionString(credentials, (default, default), (queueEndpoint, queueSecondaryEndpoint), (default, default));

            var queueName = GetNewQueueName();

            QueueClient client1 = InstrumentClient(new QueueClient(connectionString.ToString(true), queueName, GetOptions()));

            QueueClient client2 = InstrumentClient(new QueueClient(connectionString.ToString(true), queueName));

            var builder1 = new QueueUriBuilder(client1.Uri);
            var builder2 = new QueueUriBuilder(client2.Uri);

            Assert.AreEqual(queueName, builder1.QueueName);
            Assert.AreEqual(queueName, builder2.QueueName);

            //Assert.AreEqual("accountName", builder.AccountName);
        }

        [Test]
        public async Task Ctor_ConnectionString_Sas()
        {
            // Arrange
            var sasBuilder = new AccountSasBuilder
            {
                ExpiresOn = Recording.UtcNow.AddHours(1),
                Services = AccountSasServices.All,
                ResourceTypes = AccountSasResourceTypes.All,
                Protocol = SasProtocol.Https,
            };
            sasBuilder.SetPermissions(AccountSasPermissions.All);
            var cred = new StorageSharedKeyCredential(TestConfigDefault.AccountName, TestConfigDefault.AccountKey);
            string sasToken = sasBuilder.ToSasQueryParameters(cred).ToString();
            var sasCred = new SharedAccessSignatureCredentials(sasToken);

            (Uri, Uri) queueUri = StorageConnectionString.ConstructQueueEndpoint(
                Constants.Https,
                TestConfigDefault.AccountName,
                default,
                default);

            StorageConnectionString conn1 =
                new StorageConnectionString(
                    sasCred,
                    (default, default),
                    queueUri,
                    (default, default));

            QueueClient queueClient1 = GetClient(conn1.ToString(exportSecrets: true));

            // Also test with a connection string not containing the blob endpoint.
            // This should still work provided account name and Sas credential are present.
            StorageConnectionString conn2 = TestExtensions.CreateStorageConnectionString(
                sasCred,
                TestConfigDefault.AccountName);

            QueueClient queueClient2 = GetClient(conn2.ToString(exportSecrets: true));

            QueueClient GetClient(string connectionString) =>
                InstrumentClient(
                    new QueueClient(
                        connectionString,
                        GetNewQueueName(),
                        GetOptions()));

            try
            {
                // Act
                await queueClient1.CreateAsync();
                await queueClient2.CreateAsync();

                var data = GetRandomBuffer(Constants.KB);

                Response<QueueProperties> prop1 = await queueClient1.GetPropertiesAsync();
                Response<QueueProperties> prop2 = await queueClient2.GetPropertiesAsync();

                // Assert
                Assert.IsNotNull(prop1.Value.Metadata);
                Assert.IsNotNull(prop2.Value.Metadata);
            }
            finally
            {
                // Clean up
                await queueClient1.DeleteAsync();
                await queueClient2.DeleteAsync();
            }
        }

        [Test]
        public void Ctor_Uri()
        {
            var accountName = "accountName";
            var accountKey = Convert.ToBase64String(new byte[] { 0, 1, 2, 3, 4, 5 });
            var queueEndpoint = new Uri("http://127.0.0.1/" + accountName);
            var credentials = new StorageSharedKeyCredential(accountName, accountKey);

            QueueClient queue = InstrumentClient(new QueueClient(queueEndpoint, credentials));
            var builder = new QueueUriBuilder(queue.Uri);

            Assert.AreEqual(accountName, builder.AccountName);
        }

        [Test]
        public void Ctor_TokenCredential_Http()
        {
            // Arrange
            TokenCredential tokenCredential = GetOAuthCredential(TestConfigHierarchicalNamespace);
            Uri uri = new Uri(TestConfigPremiumBlob.BlobServiceEndpoint).ToHttp();

            // Act
            TestHelper.AssertExpectedException(
                () => new QueueClient(uri, tokenCredential),
                new ArgumentException("Cannot use TokenCredential without HTTPS."));
        }

        [Test]
        public void Ctor_SAS_Http()
        {
            // Arrange
            QueueUriBuilder builder = new QueueUriBuilder(new Uri(TestConfigDefault.QueueServiceEndpoint))
            {
                Sas = GetNewQueueServiceSasCredentials(GetNewQueueName())
            };
            Uri httpUri = builder.ToUri().ToHttp();
            TokenCredential tokenCredential = GetOAuthCredential(TestConfigHierarchicalNamespace);
            StorageSharedKeyCredential sharedKeyCredential = GetNewSharedKeyCredentials();

            // Act
            TestHelper.AssertExpectedException(
                () => new QueueClient(httpUri),
                new ArgumentException(Constants.ErrorMessages.SasHttps));
            TestHelper.AssertExpectedException(
                () => new QueueClient(httpUri, GetOptions()),
                new ArgumentException(Constants.ErrorMessages.SasHttps));
            TestHelper.AssertExpectedException(
                () => new QueueClient(httpUri, tokenCredential),
                new ArgumentException(Constants.ErrorMessages.SasHttps));
            TestHelper.AssertExpectedException(
                () => new QueueClient(httpUri, tokenCredential, GetOptions()),
                new ArgumentException(Constants.ErrorMessages.SasHttps));
            TestHelper.AssertExpectedException(
                () => new QueueClient(httpUri, sharedKeyCredential),
                new ArgumentException(Constants.ErrorMessages.SasHttps));
            TestHelper.AssertExpectedException(
                () => new QueueClient(httpUri, sharedKeyCredential, GetOptions()),
                new ArgumentException(Constants.ErrorMessages.SasHttps));

            // Arrange
            StorageConnectionString conn = GetConnectionString(true);

            // Act
            TestHelper.AssertExpectedException(
                () => new QueueClient(conn.ToString(true), GetNewQueueName()),
                new ArgumentException(Constants.ErrorMessages.SasHttps));
            TestHelper.AssertExpectedException(
                () => new QueueClient(conn.ToString(true), GetNewQueueName(), GetOptions()),
                new ArgumentException(Constants.ErrorMessages.SasHttps));
        }

        [Test]
        public async Task CreateAsync_WithSharedKey()
        {
            // Arrange
            var queueName = GetNewQueueName();
            QueueServiceClient service = GetServiceClient_SharedKey();
            QueueClient queue = InstrumentClient(service.GetQueueClient(queueName));

            try
            {
                // Act
                Response result = await queue.CreateAsync();

                // Assert
                Assert.IsNotNull(result.Headers.RequestId, $"{nameof(result)} may not be populated");
            }
            finally
            {
                await queue.DeleteAsync();
            }
        }

        [Test]
        public async Task CreateAsync_FromService()
        {
            var name = GetNewQueueName();
            QueueServiceClient service = GetServiceClient_SharedKey();
            try
            {
                Response<QueueClient> result = await service.CreateQueueAsync(name);
                QueueClient queue = result.Value;
                Response<QueueProperties> properties = await queue.GetPropertiesAsync();
                Assert.AreEqual(0, properties.Value.ApproximateMessagesCount);
                var accountName = new QueueUriBuilder(service.Uri).AccountName;
                TestHelper.AssertCacheableProperty(accountName, () => queue.AccountName);
                TestHelper.AssertCacheableProperty(name, () => queue.Name);
            }
            finally
            {
                await service.DeleteQueueAsync(name);
            }
        }

        [Test]
        public async Task CreateAsync_WithOauth()
        {
            // Arrange
            var queueName = GetNewQueueName();
            QueueServiceClient service = GetServiceClient_OauthAccount();
            QueueClient queue = InstrumentClient(service.GetQueueClient(queueName));

            try
            {
                // Act
                Response result = await queue.CreateAsync();

                // Assert
                Assert.IsNotNull(result.Headers.RequestId, $"{nameof(result)} may not be populated");
            }
            finally
            {
                await queue.DeleteAsync();
            }
        }

        [Test]
        public async Task CreateAsync_WithAccountSas()
        {
            // Arrange
            var queueName = GetNewQueueName();
            QueueServiceClient service = GetServiceClient_AccountSas();
            QueueClient queue = InstrumentClient(service.GetQueueClient(queueName));

            try
            {
                // Act
                Response result = await queue.CreateAsync();

                // Assert
                Assert.IsNotNull(result.Headers.RequestId, $"{nameof(result)} may not be populated");
            }
            finally
            {
                await queue.DeleteAsync();
            }
        }

        [Test]
        public async Task CreateAsync_WithQueueServiceSas()
        {
            // Arrange
            var queueName = GetNewQueueName();
            QueueServiceClient service = GetServiceClient_QueueServiceSas(queueName);
            QueueClient queue = InstrumentClient(service.GetQueueClient(queueName));
            var pass = false;

            try
            {
                // Act
                Response result = await queue.CreateAsync();


                // Assert
                Assert.Fail("CreateAsync unexpected success: queue service SAS should not be usable to create queue");
            }
            catch (RequestFailedException ex) when (ex.ErrorCode == "AuthorizationFailure") // TODO verify if this is a missing service code
            {
                pass = true;
            }
            finally
            {
                if (!pass)
                {
                    await queue.DeleteAsync();
                }
            }
        }

        [Test]
        public async Task CreateAsync_Error()
        {
            // Arrange
            var queueName = GetNewQueueName();
            QueueServiceClient service = GetServiceClient_SharedKey();
            QueueClient queue = InstrumentClient(service.GetQueueClient(queueName));
            await queue.CreateAsync();

            // Act
            await TestHelper.AssertExpectedExceptionAsync<RequestFailedException>(
                queue.CreateAsync(metadata: new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "key", "value" } }),
                actualException => Assert.AreEqual("QueueAlreadyExists", actualException.ErrorCode));
        }

        [Test]
        public async Task GetPropertiesAsync()
        {
            // Arrange
            await using DisposingQueue test = await GetTestQueueAsync();

            // Act
            Response<Models.QueueProperties> queueProperties = await test.Queue.GetPropertiesAsync();

            // Assert
            Assert.IsNotNull(queueProperties);
        }

        [Test]
        public async Task GetPropertiesAsync_Error()
        {
            // Arrange
            var queueName = GetNewQueueName();
            QueueServiceClient service = GetServiceClient_SharedKey();
            QueueClient queue = InstrumentClient(service.GetQueueClient(queueName));

            // Act
            await TestHelper.AssertExpectedExceptionAsync<RequestFailedException>(
                queue.GetPropertiesAsync(),
                actualException => Assert.AreEqual("QueueNotFound", actualException.ErrorCode));
        }

        #region Secondary Storage

        [Test]
        public async Task GetPropertiesAsync_SecondaryStorage()
        {
            QueueClient queueClient = GetQueueClient_SecondaryAccount_ReadEnabledOnRetry(1, out TestExceptionPolicy testExceptionPolicy);
            await queueClient.CreateAsync();
            Response<QueueProperties> properties = await EnsurePropagatedAsync(
                async () => await queueClient.GetPropertiesAsync(),
                properties => properties.GetRawResponse().Status != 404);

            Assert.IsNotNull(properties);
            Assert.AreEqual(200, properties.GetRawResponse().Status);

            await queueClient.DeleteAsync();
            AssertSecondaryStorageFirstRetrySuccessful(SecondaryStorageTenantPrimaryHost(), SecondaryStorageTenantSecondaryHost(), testExceptionPolicy);
        }
        #endregion

        [Test]
        public async Task SetMetadataAsync_OnCreate()
        {
            // Arrange
            IDictionary<string, string> metadata = BuildMetadata();
            await using DisposingQueue test = await GetTestQueueAsync(metadata: metadata);

            // Assert
            Response<Models.QueueProperties> result = await test.Queue.GetPropertiesAsync();
            Assert.AreEqual("bar", result.Value.Metadata["foo"]);
            Assert.AreEqual("data", result.Value.Metadata["meta"]);
        }

        [Test]
        public async Task SetMetadataAsync_Metadata()
        {
            // Arrange
            await using DisposingQueue test = await GetTestQueueAsync();

            // Act
            IDictionary<string, string> metadata = BuildMetadata();
            await test.Queue.SetMetadataAsync(metadata);

            // Assert
            Response<Models.QueueProperties> result = await test.Queue.GetPropertiesAsync();
            Assert.AreEqual("bar", result.Value.Metadata["foo"]);
            Assert.AreEqual("data", result.Value.Metadata["meta"]);
        }

        // Note that this test intentionally does not call queue.CreateAsync()
        [Test]
        public async Task SetMetadataAsync_Error()
        {
            // Arrange
            var queueName = GetNewQueueName();
            QueueServiceClient service = GetServiceClient_SharedKey();
            QueueClient queue = InstrumentClient(service.GetQueueClient(queueName));
            IDictionary<string, string> metadata = BuildMetadata();

            // Act
            await TestHelper.AssertExpectedExceptionAsync<RequestFailedException>(
                queue.SetMetadataAsync(metadata),
                actualException => Assert.AreEqual("QueueNotFound", actualException.ErrorCode));
        }

        [Test]
        public async Task GetAccessPolicyAsync()
        {
            // Arrange
            await using DisposingQueue test = await GetTestQueueAsync();

            Models.QueueSignedIdentifier[] signedIdentifiers = BuildSignedIdentifiers();

            // Act
            Response setResult = await test.Queue.SetAccessPolicyAsync(signedIdentifiers);

            // Assert
            Response<IEnumerable<Models.QueueSignedIdentifier>> result = await test.Queue.GetAccessPolicyAsync();
            Models.QueueSignedIdentifier acl = result.Value.First();

            Assert.AreEqual(1, result.Value.Count());
            Assert.AreEqual(signedIdentifiers[0].Id, acl.Id);
            Assert.AreEqual(signedIdentifiers[0].AccessPolicy.StartsOn, acl.AccessPolicy.StartsOn);
            Assert.AreEqual(signedIdentifiers[0].AccessPolicy.ExpiresOn, acl.AccessPolicy.ExpiresOn);
            Assert.AreEqual(signedIdentifiers[0].AccessPolicy.Permissions, acl.AccessPolicy.Permissions);
        }

        // Note that this test intentionally does not call queue.CreateAsync()
        [Test]
        public async Task GetAccessPolicyAsync_Error()
        {
            // Arrange
            var queueName = GetNewQueueName();
            QueueServiceClient service = GetServiceClient_SharedKey();
            QueueClient queue = InstrumentClient(service.GetQueueClient(queueName));

            // Act
            await TestHelper.AssertExpectedExceptionAsync<RequestFailedException>(
                queue.GetAccessPolicyAsync(),
                actualException => Assert.AreEqual("QueueNotFound", actualException.ErrorCode));
        }

        [Test]
        public async Task SetAccessPolicyAsync()
        {
            await using DisposingQueue test = await GetTestQueueAsync();

            Models.QueueSignedIdentifier[] signedIdentifiers = BuildSignedIdentifiers();
            Response result = await test.Queue.SetAccessPolicyAsync(signedIdentifiers);
            Assert.IsFalse(string.IsNullOrWhiteSpace(result.Headers.RequestId));
        }

        // Note that this test intentionally does not call queue.CreateAsync()
        [Test]
        public async Task SetAccessPolicyAsync_Error()
        {
            // Arrange
            var queueName = GetNewQueueName();
            QueueServiceClient service = GetServiceClient_SharedKey();
            QueueClient queue = InstrumentClient(service.GetQueueClient(queueName));
            Models.QueueSignedIdentifier[] signedIdentifiers = BuildSignedIdentifiers();

            // Act
            await TestHelper.AssertExpectedExceptionAsync<RequestFailedException>(
                queue.SetAccessPolicyAsync(signedIdentifiers),
                actualException => Assert.AreEqual("QueueNotFound", actualException.ErrorCode));
        }

        [Test]
        public async Task DeleteAsync()
        {
            // Arrange
            var queueName = GetNewQueueName();
            QueueServiceClient service = GetServiceClient_SharedKey();
            QueueClient queue = InstrumentClient(service.GetQueueClient(queueName));
            await queue.CreateAsync();

            // Act
            Response result = await queue.DeleteAsync();

            // Assert
            Assert.AreNotEqual(default, result.Headers.RequestId, $"{nameof(result)} may not be populated");
        }

        [Test]
        public async Task DeleteAsync_FromService()
        {
            var name = GetNewQueueName();
            QueueServiceClient service = GetServiceClient_SharedKey();
            try
            {
                QueueClient queue = (await service.CreateQueueAsync(name)).Value;
                await service.DeleteQueueAsync(name);

                // Ensure the queue no longer returns values
                Assert.ThrowsAsync<RequestFailedException>(
                    async () => await queue.GetPropertiesAsync());
            }
            finally
            {
            }
        }

        // Note that this test intentionally does not call queue.CreateAsync()
        [Test]
        public async Task DeleteAsync_Error()
        {
            // Arrange
            var queueName = GetNewQueueName();
            QueueServiceClient service = GetServiceClient_SharedKey();
            QueueClient queue = InstrumentClient(service.GetQueueClient(queueName));

            // Act
            await TestHelper.AssertExpectedExceptionAsync<RequestFailedException>(
                queue.DeleteAsync(),
                actualException => Assert.AreEqual("QueueNotFound", actualException.ErrorCode));
        }
    }
}
