// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The ScanRulesetList. </summary>
    internal partial class ScanRulesetList
    {
        /// <summary> Initializes a new instance of ScanRulesetList. </summary>
        internal ScanRulesetList()
        {
            Value = new ChangeTrackingList<ScanRuleset>();
        }

        /// <summary> Initializes a new instance of ScanRulesetList. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        /// <param name="count"></param>
        internal ScanRulesetList(IReadOnlyList<ScanRuleset> value, string nextLink, long? count)
        {
            Value = value;
            NextLink = nextLink;
            Count = count;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<ScanRuleset> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
        /// <summary> Gets the count. </summary>
        public long? Count { get; }
    }
}
