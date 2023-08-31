// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Collection of fabric details. </summary>
    internal partial class SiteRecoveryListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryListResult"/>. </summary>
        internal SiteRecoveryListResult()
        {
            Value = new ChangeTrackingList<SiteRecoveryEventData>();
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryListResult"/>. </summary>
        /// <param name="value"> The list of events. </param>
        /// <param name="nextLink"> The value of next link. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryListResult(IReadOnlyList<SiteRecoveryEventData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of events. </summary>
        public IReadOnlyList<SiteRecoveryEventData> Value { get; }
        /// <summary> The value of next link. </summary>
        public string NextLink { get; }
    }
}
