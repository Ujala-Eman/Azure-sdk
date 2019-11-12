﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Azure.Storage.Shared;
using Internals = Azure.Storage.Shared;

#pragma warning disable SA1402  // File may only contain a single type

namespace Azure.Storage.Blobs.Models
{
    /// <summary>
    /// Convert StorageErrors into StorageRequestFailedExceptions.
    /// </summary>
    internal partial class StorageError
    {
        /// <summary>
        /// Additional error information.
        /// </summary>
        public IDictionary<string, string> AdditionalInformation { get; } = new Dictionary<string, string>();

        /// <summary>
        /// Get any additional XML elements for the error.
        /// </summary>
        /// <param name="root">The XML element</param>
        /// <param name="error">The StorageError</param>
        static partial void CustomizeFromXml(XElement root, StorageError error)
        {
            foreach (XElement element in root.Elements())
            {
                switch (element.Name.LocalName)
                {
                    case Internals.Constants.Xml.Code:
                    case Internals.Constants.Xml.Message:
                        continue;
                    default:
                        error.AdditionalInformation[element.Name.LocalName] = element.Value;
                        break;
                }
            }
        }

        /// <summary>
        /// Create an exception corresponding to the StorageError.
        /// </summary>
        /// <param name="response">The failed response.</param>
        /// <returns>A RequestFailedException.</returns>
        public Exception CreateException(Azure.Response response)
            => Internals.StorageExceptionExtensions.CreateException(response, Message, null, Code, AdditionalInformation);
    }

    /// <summary>
    /// Convert ConditionNotMetErrors into StorageRequestFailedExceptions.
    /// </summary>
    internal partial class ConditionNotMetError
    {
        /// <summary>
        /// Create an exception corresponding to the ConditionNotMetError.
        /// </summary>
        /// <param name="response">The failed response.</param>
        /// <returns>A RequestFailedException.</returns>
        public Exception CreateException(Azure.Response response)
            => Internals.StorageExceptionExtensions.CreateException(response, null, null, ErrorCode);
    }

    /// <summary>
    /// Convert DataLakeStorageError into StorageRequestFailedExceptions.
    /// </summary>
    internal partial class DataLakeStorageError
    {
        /// <summary>
        /// Create an exception corresponding to the DataLakeStorageError.
        /// </summary>
        /// <param name="response">The failed response.</param>
        /// <returns>A RequestFailedException.</returns>
        public Exception CreateException(Azure.Response response)
            => Internals.StorageExceptionExtensions.CreateException(response, Error.Message, null, Error.Code);
    }
}
