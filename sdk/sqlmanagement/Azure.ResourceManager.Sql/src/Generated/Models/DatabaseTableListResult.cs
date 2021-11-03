// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using SqlManagementClient;

namespace SqlManagementClient.Models
{
    /// <summary> A list of database tables. </summary>
    internal partial class DatabaseTableListResult
    {
        /// <summary> Initializes a new instance of DatabaseTableListResult. </summary>
        internal DatabaseTableListResult()
        {
            Value = new ChangeTrackingList<DatabaseTableData>();
        }

        /// <summary> Initializes a new instance of DatabaseTableListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal DatabaseTableListResult(IReadOnlyList<DatabaseTableData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<DatabaseTableData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
