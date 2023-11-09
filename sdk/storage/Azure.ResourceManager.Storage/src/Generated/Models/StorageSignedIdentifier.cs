// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The StorageSignedIdentifier. </summary>
    public partial class StorageSignedIdentifier
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageSignedIdentifier"/>. </summary>
        public StorageSignedIdentifier()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageSignedIdentifier"/>. </summary>
        /// <param name="id"> An unique identifier of the stored access policy. </param>
        /// <param name="accessPolicy"> Access policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageSignedIdentifier(string id, StorageServiceAccessPolicy accessPolicy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            AccessPolicy = accessPolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> An unique identifier of the stored access policy. </summary>
        public string Id { get; set; }
        /// <summary> Access policy. </summary>
        public StorageServiceAccessPolicy AccessPolicy { get; set; }
    }
}
