﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Testing;
using Azure.Security.KeyVault.Keys.Cryptography;
using NUnit.Framework;

namespace Azure.Security.KeyVault.Keys.Tests
{
    public class KeyResolverMockTests : ClientTestBase
    {
        public KeyResolverMockTests(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        public async Task ShouldNotRequireGetPermission()
        {
            // Test for https://github.com/Azure/azure-sdk-for-net/issues/11574
            MockTransport transport = new MockTransport(request => new MockResponse(403, "Forbidden"));

            KeyResolver resolver = GetResolver(transport);
            CryptographyClient client = await resolver.ResolveAsync(new Uri("https://mock.vault.azure.net/keys/mock-key"));

            RequestFailedException ex = Assert.ThrowsAsync<RequestFailedException>(() => client.UnwrapKeyAsync(KeyWrapAlgorithm.A256KW, new byte[] { 0, 1, 2, 3 }));
            Assert.AreEqual(403, ex.Status);
        }

        protected KeyResolver GetResolver(MockTransport transport)
        {
            Assert.NotNull(transport);

            CryptographyClientOptions options = new CryptographyClientOptions
            {
                Transport = transport,
            };

            return InstrumentClient(
                new KeyResolver(new NullTokenCredential(), options));
        }

        private class NullTokenCredential : TokenCredential
        {
            public override AccessToken GetToken(TokenRequestContext requestContext, CancellationToken cancellationToken) =>
                new AccessToken("invalid", DateTimeOffset.Now.AddHours(1));

            public override ValueTask<AccessToken> GetTokenAsync(TokenRequestContext requestContext, CancellationToken cancellationToken) =>
                new ValueTask<AccessToken>(GetToken(requestContext, cancellationToken));
        }
    }
}
