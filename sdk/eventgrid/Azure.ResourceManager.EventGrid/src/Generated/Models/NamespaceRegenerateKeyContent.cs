// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Namespace regenerate share access key request. </summary>
    public partial class NamespaceRegenerateKeyContent
    {
        /// <summary> Initializes a new instance of <see cref="NamespaceRegenerateKeyContent"/>. </summary>
        /// <param name="keyName"> Key name to regenerate key1 or key2. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public NamespaceRegenerateKeyContent(string keyName)
        {
            Argument.AssertNotNull(keyName, nameof(keyName));

            KeyName = keyName;
        }

        /// <summary> Key name to regenerate key1 or key2. </summary>
        public string KeyName { get; }
    }
}
