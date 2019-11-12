﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Azure.Storage.Shared;
using Internals = Azure.Storage.Shared;

namespace Azure.Storage.Queues.Models
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
        /// <param name="root">
        /// The XML element
        /// </param>
        /// <param name="error">
        /// <see cref="StorageError"/>
        /// </param>
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
        /// <param name="response">
        /// The failed response.
        /// </param>
        /// <returns>
        /// A <see cref="RequestFailedException"/>.
        /// </returns>
        public Exception CreateException(Azure.Response response)
            => Internals.StorageExceptionExtensions.CreateException(response, Message, null, Code, AdditionalInformation);
    }
}
