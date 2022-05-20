// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> A paginated list of DataVersionBase entities. </summary>
    internal partial class DataVersionBaseResourceArmPaginatedResult
    {
        /// <summary> Initializes a new instance of DataVersionBaseResourceArmPaginatedResult. </summary>
        internal DataVersionBaseResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<DataVersionBaseDataData>();
        }

        /// <summary> Initializes a new instance of DataVersionBaseResourceArmPaginatedResult. </summary>
        /// <param name="nextLink"> The link to the next page of DataVersionBase objects. If null, there are no additional pages. </param>
        /// <param name="value"> An array of objects of type DataVersionBase. </param>
        internal DataVersionBaseResourceArmPaginatedResult(string nextLink, IReadOnlyList<DataVersionBaseDataData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link to the next page of DataVersionBase objects. If null, there are no additional pages. </summary>
        public string NextLink { get; }
        /// <summary> An array of objects of type DataVersionBase. </summary>
        public IReadOnlyList<DataVersionBaseDataData> Value { get; }
    }
}
