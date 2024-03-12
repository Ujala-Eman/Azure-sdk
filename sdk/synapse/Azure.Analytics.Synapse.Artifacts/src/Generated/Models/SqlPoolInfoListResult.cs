// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> List of SQL pools. </summary>
    public partial class SqlPoolInfoListResult
    {
        /// <summary> Initializes a new instance of <see cref="SqlPoolInfoListResult"/>. </summary>
        internal SqlPoolInfoListResult()
        {
            Value = new ChangeTrackingList<SqlPool>();
        }

        /// <summary> Initializes a new instance of <see cref="SqlPoolInfoListResult"/>. </summary>
        /// <param name="nextLink"> Link to the next page of results. </param>
        /// <param name="value"> List of SQL pools. </param>
        internal SqlPoolInfoListResult(string nextLink, IReadOnlyList<SqlPool> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> Link to the next page of results. </summary>
        public string NextLink { get; }
        /// <summary> List of SQL pools. </summary>
        public IReadOnlyList<SqlPool> Value { get; }
    }
}
