// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of database usage metrics. </summary>
    internal partial class DatabaseUsageListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DatabaseUsageListResult"/>. </summary>
        internal DatabaseUsageListResult()
        {
            Value = new ChangeTrackingList<DatabaseUsage>();
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseUsageListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DatabaseUsageListResult(IReadOnlyList<DatabaseUsage> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<DatabaseUsage> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
