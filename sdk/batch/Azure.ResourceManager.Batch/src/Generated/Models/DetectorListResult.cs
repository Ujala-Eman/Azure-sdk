// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Batch;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Values returned by the List operation. </summary>
    internal partial class DetectorListResult
    {
        /// <summary> Initializes a new instance of DetectorListResult. </summary>
        internal DetectorListResult()
        {
            Value = new ChangeTrackingList<DetectorResponseData>();
        }

        /// <summary> Initializes a new instance of DetectorListResult. </summary>
        /// <param name="value"> The collection of Batch account detectors returned by the listing operation. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal DetectorListResult(IReadOnlyList<DetectorResponseData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The collection of Batch account detectors returned by the listing operation. </summary>
        public IReadOnlyList<DetectorResponseData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
