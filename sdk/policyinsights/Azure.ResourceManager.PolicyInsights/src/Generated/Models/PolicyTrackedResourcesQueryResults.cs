// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary>
    /// Query results.
    /// Serialized Name: PolicyTrackedResourcesQueryResults
    /// </summary>
    internal partial class PolicyTrackedResourcesQueryResults
    {
        /// <summary> Initializes a new instance of PolicyTrackedResourcesQueryResults. </summary>
        internal PolicyTrackedResourcesQueryResults()
        {
            Value = new ChangeTrackingList<PolicyTrackedResource>();
        }

        /// <summary> Initializes a new instance of PolicyTrackedResourcesQueryResults. </summary>
        /// <param name="value">
        /// Query results.
        /// Serialized Name: PolicyTrackedResourcesQueryResults.value
        /// </param>
        /// <param name="nextLink">
        /// The URL to get the next set of results.
        /// Serialized Name: PolicyTrackedResourcesQueryResults.nextLink
        /// </param>
        internal PolicyTrackedResourcesQueryResults(IReadOnlyList<PolicyTrackedResource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Query results.
        /// Serialized Name: PolicyTrackedResourcesQueryResults.value
        /// </summary>
        public IReadOnlyList<PolicyTrackedResource> Value { get; }
        /// <summary>
        /// The URL to get the next set of results.
        /// Serialized Name: PolicyTrackedResourcesQueryResults.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
