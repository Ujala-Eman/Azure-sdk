// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Domain regenerate share access key request. </summary>
    public partial class DomainRegenerateKeyContent
    {
        /// <summary> Initializes a new instance of DomainRegenerateKeyContent. </summary>
        /// <param name="keyName"> Key name to regenerate key1 or key2. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public DomainRegenerateKeyContent(string keyName)
        {
            if (keyName == null)
            {
                throw new ArgumentNullException(nameof(keyName));
            }

            KeyName = keyName;
        }

        /// <summary> Key name to regenerate key1 or key2. </summary>
        public string KeyName { get; }
    }
}
