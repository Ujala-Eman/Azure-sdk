// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Relay;

namespace Azure.ResourceManager.Relay.Models
{
    /// <summary> The response of the list WCF relay operation. </summary>
    internal partial class WcfRelaysListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WcfRelaysListResult"/>. </summary>
        internal WcfRelaysListResult()
        {
            Value = new ChangeTrackingList<WcfRelayData>();
        }

        /// <summary> Initializes a new instance of <see cref="WcfRelaysListResult"/>. </summary>
        /// <param name="value"> Result of the list WCF relay operation. </param>
        /// <param name="nextLink"> Link to the next set of results. Not empty if value contains incomplete list of WCF relays. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WcfRelaysListResult(IReadOnlyList<WcfRelayData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Result of the list WCF relay operation. </summary>
        public IReadOnlyList<WcfRelayData> Value { get; }
        /// <summary> Link to the next set of results. Not empty if value contains incomplete list of WCF relays. </summary>
        public string NextLink { get; }
    }
}
