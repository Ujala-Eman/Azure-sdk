// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.PolicyInsights;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary>
    /// List of remediations.
    /// Serialized Name: RemediationListResult
    /// </summary>
    internal partial class RemediationListResult
    {
        /// <summary> Initializes a new instance of RemediationListResult. </summary>
        internal RemediationListResult()
        {
            Value = new ChangeTrackingList<RemediationData>();
        }

        /// <summary> Initializes a new instance of RemediationListResult. </summary>
        /// <param name="value">
        /// Array of remediation definitions.
        /// Serialized Name: RemediationListResult.value
        /// </param>
        /// <param name="nextLink">
        /// The URL to get the next set of results.
        /// Serialized Name: RemediationListResult.nextLink
        /// </param>
        internal RemediationListResult(IReadOnlyList<RemediationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Array of remediation definitions.
        /// Serialized Name: RemediationListResult.value
        /// </summary>
        public IReadOnlyList<RemediationData> Value { get; }
        /// <summary>
        /// The URL to get the next set of results.
        /// Serialized Name: RemediationListResult.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
