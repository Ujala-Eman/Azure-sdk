// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The paginated list of peering locations. </summary>
    internal partial class PeeringLocationListResult
    {
        /// <summary> Initializes a new instance of PeeringLocationListResult. </summary>
        internal PeeringLocationListResult()
        {
            Value = new ChangeTrackingList<PeeringLocation>();
        }

        /// <summary> Initializes a new instance of PeeringLocationListResult. </summary>
        /// <param name="value"> The list of peering locations. </param>
        /// <param name="nextLink"> The link to fetch the next page of peering locations. </param>
        internal PeeringLocationListResult(IReadOnlyList<PeeringLocation> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of peering locations. </summary>
        public IReadOnlyList<PeeringLocation> Value { get; }
        /// <summary> The link to fetch the next page of peering locations. </summary>
        public string NextLink { get; }
    }
}
