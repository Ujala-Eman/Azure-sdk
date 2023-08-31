// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HDInsight;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> Result of the request to list cluster Applications. It contains a list of operations and a URL link to get the next set of results. </summary>
    internal partial class ApplicationListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationListResult"/>. </summary>
        internal ApplicationListResult()
        {
            Value = new ChangeTrackingList<HDInsightApplicationData>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationListResult"/>. </summary>
        /// <param name="value"> The list of HDInsight applications installed on HDInsight cluster. </param>
        /// <param name="nextLink"> The URL to get the next set of operation list results if there are any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationListResult(IReadOnlyList<HDInsightApplicationData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of HDInsight applications installed on HDInsight cluster. </summary>
        public IReadOnlyList<HDInsightApplicationData> Value { get; }
        /// <summary> The URL to get the next set of operation list results if there are any. </summary>
        public string NextLink { get; }
    }
}
