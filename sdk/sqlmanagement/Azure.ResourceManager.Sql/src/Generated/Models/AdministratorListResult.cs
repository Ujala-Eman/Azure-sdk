// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using SqlManagementClient;

namespace SqlManagementClient.Models
{
    /// <summary> A list of active directory administrators. </summary>
    internal partial class AdministratorListResult
    {
        /// <summary> Initializes a new instance of AdministratorListResult. </summary>
        internal AdministratorListResult()
        {
            Value = new ChangeTrackingList<ServerAzureADAdministratorData>();
        }

        /// <summary> Initializes a new instance of AdministratorListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal AdministratorListResult(IReadOnlyList<ServerAzureADAdministratorData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ServerAzureADAdministratorData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
