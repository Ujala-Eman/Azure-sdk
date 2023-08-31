// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Search;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Response containing a list of Azure Cognitive Search services. </summary>
    internal partial class SearchServiceListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SearchServiceListResult"/>. </summary>
        internal SearchServiceListResult()
        {
            Value = new ChangeTrackingList<SearchServiceData>();
        }

        /// <summary> Initializes a new instance of <see cref="SearchServiceListResult"/>. </summary>
        /// <param name="value"> The list of Search services. </param>
        /// <param name="nextLink"> Request URL that can be used to query next page of search services. Returned when the total number of requested search services exceed maximum page size. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchServiceListResult(IReadOnlyList<SearchServiceData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of Search services. </summary>
        public IReadOnlyList<SearchServiceData> Value { get; }
        /// <summary> Request URL that can be used to query next page of search services. Returned when the total number of requested search services exceed maximum page size. </summary>
        public string NextLink { get; }
    }
}
