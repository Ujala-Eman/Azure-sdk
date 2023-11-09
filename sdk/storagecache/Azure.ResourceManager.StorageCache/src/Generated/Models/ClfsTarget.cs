// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Properties pertaining to the ClfsTarget. </summary>
    internal partial class ClfsTarget
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ClfsTarget"/>. </summary>
        public ClfsTarget()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ClfsTarget"/>. </summary>
        /// <param name="target"> Resource ID of storage container. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClfsTarget(ResourceIdentifier target, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Target = target;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource ID of storage container. </summary>
        public ResourceIdentifier Target { get; set; }
    }
}
