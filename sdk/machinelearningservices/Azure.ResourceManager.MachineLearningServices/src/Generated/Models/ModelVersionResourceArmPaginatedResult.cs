// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A paginated list of ModelVersion entities. </summary>
    internal partial class ModelVersionResourceArmPaginatedResult
    {
        /// <summary> Initializes a new instance of ModelVersionResourceArmPaginatedResult. </summary>
        internal ModelVersionResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<ModelVersionResourceData>();
        }

        /// <summary> Initializes a new instance of ModelVersionResourceArmPaginatedResult. </summary>
        /// <param name="nextLink"> . </param>
        /// <param name="value"> An array of objects of type ModelVersion. </param>
        internal ModelVersionResourceArmPaginatedResult(string nextLink, IReadOnlyList<ModelVersionResourceData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        public string NextLink { get; }
        /// <summary> An array of objects of type ModelVersion. </summary>
        public IReadOnlyList<ModelVersionResourceData> Value { get; }
    }
}
