// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The response from the List Storage SKUs operation. </summary>
    internal partial class StorageSkuListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageSkuListResult"/>. </summary>
        internal StorageSkuListResult()
        {
            Value = new ChangeTrackingList<StorageSkuInformation>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageSkuListResult"/>. </summary>
        /// <param name="value"> Get the list result of storage SKUs and their properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageSkuListResult(IReadOnlyList<StorageSkuInformation> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Get the list result of storage SKUs and their properties. </summary>
        public IReadOnlyList<StorageSkuInformation> Value { get; }
    }
}
