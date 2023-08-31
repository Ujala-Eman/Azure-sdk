// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Parameters supplied to the Regenerate Authorization Rule operation, specifies which key needs to be reset. </summary>
    public partial class EventHubsRegenerateAccessKeyContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EventHubsRegenerateAccessKeyContent"/>. </summary>
        /// <param name="keyType"> The access key to regenerate. </param>
        public EventHubsRegenerateAccessKeyContent(EventHubsAccessKeyType keyType)
        {
            KeyType = keyType;
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsRegenerateAccessKeyContent"/>. </summary>
        /// <param name="keyType"> The access key to regenerate. </param>
        /// <param name="key"> Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EventHubsRegenerateAccessKeyContent(EventHubsAccessKeyType keyType, string key, Dictionary<string, BinaryData> rawData)
        {
            KeyType = keyType;
            Key = key;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsRegenerateAccessKeyContent"/> for deserialization. </summary>
        internal EventHubsRegenerateAccessKeyContent()
        {
        }

        /// <summary> The access key to regenerate. </summary>
        public EventHubsAccessKeyType KeyType { get; }
        /// <summary> Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType. </summary>
        public string Key { get; set; }
    }
}
