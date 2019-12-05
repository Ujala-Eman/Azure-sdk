﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Reflection;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Testing;
using Microsoft.Identity.Client;
using NUnit.Framework;

namespace Azure.Identity.Tests
{
    // !!!!!! WARNING !!!!!
    // Recordings the tests in this class WILL NOT be sanitized, and hence will
    // contain sensitive information which when pushed will FULLY COMPROMISE the
    // account used to record the test. For this reason these tests should only
    // be recorded with a temporary account which must be deleted IMMEDIATELY
    // after recording, and BEFORE any recordings are pushed to tho public repo
    // or fork. To re-record these tests the following steps MUST be COMPLETELY
    // followed before pushing any updates.
    //
    // - Create a temporary account in a tenant with MFA not enabled. Azure SDK
    //   team members can use the azuresdkplayground.onmicrosoft.com tenant
    //   (c54fac88-3dd3-461f-a7c4-8a368e0340b3)
    // - Set the environment variables
    //    IDENTITYTEST_USERNAMEPASSWORDCREDENTIAL_USERNAME
    //    IDENTITYTEST_USERNAMEPASSWORDCREDENTIAL_PASSWORD
    //    IDENTITYTEST_USERNAMEPASSWORDCREDENTIAL_TENANTID
    //   to the corresponding values of the newly created temp account.
    // - Run the tests in "Record" mode and copy the updated recordings into the
    //   .\SessionRecords folder.
    // - Run the tests in "Playback" mode to ensure the recordings work properly.
    // - Delete the temporary account.
    // - Run the tests in live mode. Ensure the tests fail to authenticate now
    //   that the account is deleted with the following error message:
    //   "AADSTS50034: The user account {EmailHidden} does not exist in the
    //   <tenantId> directory."
    //
    public class UsernamePasswordCredentialLiveTests : RecordedTestBase
    {
        private const string ClientId = "04b07795-8ddb-461a-bbee-02f9e1bf7b46";

        public UsernamePasswordCredentialLiveTests(bool isAsync) : base(isAsync)
        {
            Matcher.ExcludeHeaders.Add("client-request-id");
            Matcher.ExcludeHeaders.Add("x-client-OS");
            Matcher.ExcludeHeaders.Add("x-client-SKU");
            Matcher.ExcludeHeaders.Add("x-client-CPU");
        }

        [SetUp]
        public void ClearDiscoveryCache()
        {
            Type staticMetadataProviderType = typeof(PublicClientApplication).Assembly.GetType("Microsoft.Identity.Client.Instance.Discovery.StaticMetadataProvider", true);

            var staticMetadataProvider = Activator.CreateInstance(staticMetadataProviderType);

            staticMetadataProvider.GetType().GetMethod("Clear", BindingFlags.Public | BindingFlags.Instance).Invoke(staticMetadataProvider, null);
        }

        // !!!!!! WARNING !!!!!
        // Recordings the tests in this class WILL NOT be sanitized, and hence will
        // contain sensitive information which when pushed will FULLY COMPROMISE the
        // account used to record the test. For this reason these tests should only
        // be recorded with a temporary account which must be deleted IMMEDIATELY
        // after recording, and BEFORE any recordings are pushed to tho public repo
        // or fork. To re-record these tests the following steps MUST be COMPLETELY
        // followed before pushing any updates. See class comment for instructions
        [Test]
        public async Task AuthenticateUsernamePasswordLive()
        {
            var username = Recording.GetVariableFromEnvironment("IDENTITYTEST_USERNAMEPASSWORDCREDENTIAL_USERNAME");

            var password = Environment.GetEnvironmentVariable("IDENTITYTEST_USERNAMEPASSWORDCREDENTIAL_PASSWORD") ?? "SANITIZED";

            var tenantId = Recording.GetVariableFromEnvironment("IDENTITYTEST_USERNAMEPASSWORDCREDENTIAL_TENANTID");

            var options = Recording.InstrumentClientOptions(new TokenCredentialOptions());

            var cred = InstrumentClient(new UsernamePasswordCredential(username, password, tenantId, ClientId, options));

            AccessToken token = await cred.GetTokenAsync(new TokenRequestContext(new string[] { "https://vault.azure.net/.default" }));

            Assert.IsNotNull(token.Token);
        }
    }
}
