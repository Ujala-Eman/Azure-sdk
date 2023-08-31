// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Domain regenerate share access key request. </summary>
    public partial class EventGridDomainRegenerateKeyContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EventGridDomainRegenerateKeyContent"/>. </summary>
        /// <param name="keyName"> Key name to regenerate key1 or key2. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public EventGridDomainRegenerateKeyContent(string keyName)
        {
            Argument.AssertNotNull(keyName, nameof(keyName));

            KeyName = keyName;
        }

        /// <summary> Initializes a new instance of <see cref="EventGridDomainRegenerateKeyContent"/>. </summary>
        /// <param name="keyName"> Key name to regenerate key1 or key2. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EventGridDomainRegenerateKeyContent(string keyName, Dictionary<string, BinaryData> rawData)
        {
            KeyName = keyName;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="EventGridDomainRegenerateKeyContent"/> for deserialization. </summary>
        internal EventGridDomainRegenerateKeyContent()
        {
        }

        /// <summary> Key name to regenerate key1 or key2. </summary>
        public string KeyName { get; }
    }
}
