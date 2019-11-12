﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;
using Azure.Core.Pipeline;

#if CommonSDK
using Internals = Azure.Storage.Shared.Common;
namespace Azure.Storage.Shared.Common
#else
using Internals = Azure.Storage.Shared;
namespace Azure.Storage.Shared
#endif
{
internal class StorageResponseClassifier : ResponseClassifier
    {
        public Uri SecondaryStorageUri { get; }

        public StorageResponseClassifier(Uri secondaryStorageUri)
        {
            SecondaryStorageUri = secondaryStorageUri;
        }

        /// <summary>
        /// Overridden version of IsRetriableResponse that allows for retrying 404 that occurs against the secondary host.
        /// </summary>
        /// <param name="message">The message containing both Response and Request</param>
        /// <returns></returns>
        public override bool IsRetriableResponse(HttpMessage message)
        {
            if (message.Request.Uri.Host == SecondaryStorageUri.Host && message.Response.Status == Internals.Constants.HttpStatusCode.NotFound)
            {
                return true;
            }
            return base.IsRetriableResponse(message);
        }
    }
}
