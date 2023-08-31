// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Hci;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> List of SKU proxy resources for the HCI cluster. </summary>
    internal partial class HciSkuList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HciSkuList"/>. </summary>
        internal HciSkuList()
        {
            Value = new ChangeTrackingList<HciSkuData>();
        }

        /// <summary> Initializes a new instance of <see cref="HciSkuList"/>. </summary>
        /// <param name="value"> List of SKU proxy resources. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HciSkuList(IReadOnlyList<HciSkuData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of SKU proxy resources. </summary>
        public IReadOnlyList<HciSkuData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
