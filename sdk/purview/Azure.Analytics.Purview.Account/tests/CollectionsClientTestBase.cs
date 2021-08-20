﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Azure.Core.Pipeline;
using Azure.Core.TestFramework;
using Azure.Identity;

namespace Azure.Analytics.Purview.Account.Tests
{
    public class CollectionsClientTestBase: RecordedTestBase<PurviewCollectionTestEnvironment>
    {
        public CollectionsClientTestBase(bool isAsync) : base(isAsync)
        {
        }

        public CollectionsClientTestBase(bool isAsync, RecordedTestMode mode) : base(isAsync, mode)
        {
        }

        public CollectionsClient GetCollectionsClient()
        {
/*            var credential = new DefaultAzureCredential();*/
            var testEnv = new PurviewCollectionTestEnvironment("https://dotnetLLCPurviewAccount.purview.azure.com");
            var endpoint = new Uri(testEnv.Endpoint);

            var httpHandler = new HttpClientHandler();
            httpHandler.ServerCertificateCustomValidationCallback = (_, _, _, _) =>
            {
                return true;
            };
            var options = new PurviewAccountClientOptions { Transport = new HttpClientTransport(httpHandler) };
            var client = InstrumentClient(
                new CollectionsClient(endpoint, testEnv.Credential, InstrumentClientOptions(options)));
            return client;
        }
    }
}
