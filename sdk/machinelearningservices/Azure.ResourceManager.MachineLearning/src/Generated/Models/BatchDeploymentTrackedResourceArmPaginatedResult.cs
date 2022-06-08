// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> A paginated list of BatchDeployment entities. </summary>
    internal partial class BatchDeploymentTrackedResourceArmPaginatedResult
    {
        /// <summary> Initializes a new instance of <see cref="BatchDeploymentTrackedResourceArmPaginatedResult"/>. </summary>
        internal BatchDeploymentTrackedResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<BatchDeploymentData>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchDeploymentTrackedResourceArmPaginatedResult"/>. </summary>
        /// <param name="nextLink"> The link to the next page of BatchDeployment objects. If null, there are no additional pages. </param>
        /// <param name="value"> An array of objects of type BatchDeployment. </param>
        internal BatchDeploymentTrackedResourceArmPaginatedResult(string nextLink, IReadOnlyList<BatchDeploymentData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link to the next page of BatchDeployment objects. If null, there are no additional pages. </summary>
        public string NextLink { get; }
        /// <summary> An array of objects of type BatchDeployment. </summary>
        public IReadOnlyList<BatchDeploymentData> Value { get; }
    }
}
