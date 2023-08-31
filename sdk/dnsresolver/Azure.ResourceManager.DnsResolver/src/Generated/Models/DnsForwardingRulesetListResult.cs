// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DnsResolver;

namespace Azure.ResourceManager.DnsResolver.Models
{
    /// <summary> The response to an enumeration operation on DNS forwarding rulesets. </summary>
    internal partial class DnsForwardingRulesetListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DnsForwardingRulesetListResult"/>. </summary>
        internal DnsForwardingRulesetListResult()
        {
            Value = new ChangeTrackingList<DnsForwardingRulesetData>();
        }

        /// <summary> Initializes a new instance of <see cref="DnsForwardingRulesetListResult"/>. </summary>
        /// <param name="value"> Enumeration of the DNS forwarding rulesets. </param>
        /// <param name="nextLink"> The continuation token for the next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DnsForwardingRulesetListResult(IReadOnlyList<DnsForwardingRulesetData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Enumeration of the DNS forwarding rulesets. </summary>
        public IReadOnlyList<DnsForwardingRulesetData> Value { get; }
        /// <summary> The continuation token for the next page of results. </summary>
        public string NextLink { get; }
    }
}
