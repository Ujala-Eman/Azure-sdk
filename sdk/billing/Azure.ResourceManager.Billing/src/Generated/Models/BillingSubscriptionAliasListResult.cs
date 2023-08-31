// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Billing;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The list of billing subscription aliases. </summary>
    internal partial class BillingSubscriptionAliasListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BillingSubscriptionAliasListResult"/>. </summary>
        internal BillingSubscriptionAliasListResult()
        {
            Value = new ChangeTrackingList<BillingSubscriptionAliasData>();
        }

        /// <summary> Initializes a new instance of <see cref="BillingSubscriptionAliasListResult"/>. </summary>
        /// <param name="value"> The list of billing subscription aliases. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingSubscriptionAliasListResult(IReadOnlyList<BillingSubscriptionAliasData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of billing subscription aliases. </summary>
        public IReadOnlyList<BillingSubscriptionAliasData> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
