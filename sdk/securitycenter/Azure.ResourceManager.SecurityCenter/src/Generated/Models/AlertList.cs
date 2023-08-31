// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> List of security alerts. </summary>
    internal partial class AlertList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AlertList"/>. </summary>
        internal AlertList()
        {
            Value = new ChangeTrackingList<SecurityAlertData>();
        }

        /// <summary> Initializes a new instance of <see cref="AlertList"/>. </summary>
        /// <param name="value"> describes security alert properties. </param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AlertList(IReadOnlyList<SecurityAlertData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> describes security alert properties. </summary>
        public IReadOnlyList<SecurityAlertData> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
