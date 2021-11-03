// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace SqlManagementClient.Models
{
    /// <summary> Execution statistics for one particular query. </summary>
    internal partial class ManagedInstanceQueryStatistics
    {
        /// <summary> Initializes a new instance of ManagedInstanceQueryStatistics. </summary>
        internal ManagedInstanceQueryStatistics()
        {
            Value = new ChangeTrackingList<QueryStatistics>();
        }

        /// <summary> Initializes a new instance of ManagedInstanceQueryStatistics. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ManagedInstanceQueryStatistics(IReadOnlyList<QueryStatistics> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<QueryStatistics> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
