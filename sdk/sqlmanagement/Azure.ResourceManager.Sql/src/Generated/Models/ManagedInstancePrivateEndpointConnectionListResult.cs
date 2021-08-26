// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of private endpoint connections. </summary>
    internal partial class ManagedInstancePrivateEndpointConnectionListResult
    {
        /// <summary> Initializes a new instance of ManagedInstancePrivateEndpointConnectionListResult. </summary>
        internal ManagedInstancePrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<ManagedInstancePrivateEndpointConnection>();
        }

        /// <summary> Initializes a new instance of ManagedInstancePrivateEndpointConnectionListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ManagedInstancePrivateEndpointConnectionListResult(IReadOnlyList<ManagedInstancePrivateEndpointConnection> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ManagedInstancePrivateEndpointConnection> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
