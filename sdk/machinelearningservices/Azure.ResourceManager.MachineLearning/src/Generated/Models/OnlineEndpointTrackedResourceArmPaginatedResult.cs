// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> A paginated list of OnlineEndpoint entities. </summary>
    internal partial class OnlineEndpointTrackedResourceArmPaginatedResult
    {
        /// <summary> Initializes a new instance of OnlineEndpointTrackedResourceArmPaginatedResult. </summary>
        internal OnlineEndpointTrackedResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<OnlineEndpointDataData>();
        }

        /// <summary> Initializes a new instance of OnlineEndpointTrackedResourceArmPaginatedResult. </summary>
        /// <param name="nextLink"> The link to the next page of OnlineEndpoint objects. If null, there are no additional pages. </param>
        /// <param name="value"> An array of objects of type OnlineEndpoint. </param>
        internal OnlineEndpointTrackedResourceArmPaginatedResult(string nextLink, IReadOnlyList<OnlineEndpointDataData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link to the next page of OnlineEndpoint objects. If null, there are no additional pages. </summary>
        public string NextLink { get; }
        /// <summary> An array of objects of type OnlineEndpoint. </summary>
        public IReadOnlyList<OnlineEndpointDataData> Value { get; }
    }
}
