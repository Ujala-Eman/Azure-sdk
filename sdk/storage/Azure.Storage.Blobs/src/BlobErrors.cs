﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Globalization;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Shared;
using Internals = Azure.Storage.Shared;

namespace Azure.Storage.Blobs
{
    /// <summary>
    /// Create exceptions for common error cases.
    /// </summary>
    internal class BlobErrors : Internals.Errors
    {
        public static ArgumentOutOfRangeException BlobConditionsMustBeDefault(params string[] conditions) =>
            new ArgumentOutOfRangeException($"The {string.Join(" and ", conditions)} conditions must have their default values because they are ignored by the blob service");

        public static InvalidOperationException BlobOrContainerMissing(string leaseClient,
            string blobBaseClient,
            string blobContainerClient) =>
            new InvalidOperationException($"{leaseClient} requires either a {blobBaseClient} or {blobContainerClient}");

        public static ArgumentException InvalidDateTimeUtc(string dateTime) =>
            new ArgumentException($"{dateTime} must be UTC");

        internal static void VerifyHttpsCustomerProvidedKey(Uri uri, CustomerProvidedKey? customerProvidedKey)
        {
            if (customerProvidedKey.HasValue && !string.Equals(uri.Scheme, Constants.Https, StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("Cannot use client-provided key without HTTPS.");
            }
        }

        public static ArgumentException ParsingFullHttpRangeFailed(string range)
            => new ArgumentException("Could not obtain the total length from HTTP range " + range);
    }
}
