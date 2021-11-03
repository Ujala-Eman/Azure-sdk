// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using SqlManagementClient;

namespace SqlManagementClient.Models
{
    /// <summary> A list of managed databases. </summary>
    internal partial class ManagedDatabaseListResult
    {
        /// <summary> Initializes a new instance of ManagedDatabaseListResult. </summary>
        internal ManagedDatabaseListResult()
        {
            Value = new ChangeTrackingList<ManagedDatabaseData>();
        }

        /// <summary> Initializes a new instance of ManagedDatabaseListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ManagedDatabaseListResult(IReadOnlyList<ManagedDatabaseData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ManagedDatabaseData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
