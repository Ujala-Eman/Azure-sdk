// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Protection Profile Collection details. </summary>
    internal partial class SiteRecoveryPolicyListResult
    {
        /// <summary> Initializes a new instance of SiteRecoveryPolicyListResult. </summary>
        internal SiteRecoveryPolicyListResult()
        {
            Value = new ChangeTrackingList<SiteRecoveryPolicyData>();
        }

        /// <summary> Initializes a new instance of SiteRecoveryPolicyListResult. </summary>
        /// <param name="value"> The policy details. </param>
        /// <param name="nextLink"> The value of next link. </param>
        internal SiteRecoveryPolicyListResult(IReadOnlyList<SiteRecoveryPolicyData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The policy details. </summary>
        public IReadOnlyList<SiteRecoveryPolicyData> Value { get; }
        /// <summary> The value of next link. </summary>
        public string NextLink { get; }
    }
}
