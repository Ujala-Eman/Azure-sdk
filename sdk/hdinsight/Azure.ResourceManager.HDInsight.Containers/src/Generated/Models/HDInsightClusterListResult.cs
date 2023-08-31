// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HDInsight.Containers;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The list cluster operation response. </summary>
    internal partial class HDInsightClusterListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterListResult"/>. </summary>
        internal HDInsightClusterListResult()
        {
            Value = new ChangeTrackingList<HDInsightClusterData>();
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterListResult"/>. </summary>
        /// <param name="value"> The list of clusters. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightClusterListResult(IReadOnlyList<HDInsightClusterData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of clusters. </summary>
        public IReadOnlyList<HDInsightClusterData> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
