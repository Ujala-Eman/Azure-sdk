// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using SqlManagementClient;

namespace SqlManagementClient.Models
{
    /// <summary> A list of managed instance administrators. </summary>
    internal partial class ManagedInstanceAdministratorListResult
    {
        /// <summary> Initializes a new instance of ManagedInstanceAdministratorListResult. </summary>
        internal ManagedInstanceAdministratorListResult()
        {
            Value = new ChangeTrackingList<ManagedInstanceAdministratorData>();
        }

        /// <summary> Initializes a new instance of ManagedInstanceAdministratorListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ManagedInstanceAdministratorListResult(IReadOnlyList<ManagedInstanceAdministratorData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ManagedInstanceAdministratorData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
