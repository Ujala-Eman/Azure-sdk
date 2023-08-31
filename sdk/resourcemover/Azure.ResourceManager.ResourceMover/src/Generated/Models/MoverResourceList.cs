// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ResourceMover;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the collection of move resources. </summary>
    internal partial class MoverResourceList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MoverResourceList"/>. </summary>
        internal MoverResourceList()
        {
            Value = new ChangeTrackingList<MoverResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="MoverResourceList"/>. </summary>
        /// <param name="value"> Gets the list of move resources. </param>
        /// <param name="nextLink"> Gets the value of  next link. </param>
        /// <param name="summaryCollection"> Gets or sets the list of summary items and the field on which summary is done. </param>
        /// <param name="totalCount"> Gets the total count. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MoverResourceList(IReadOnlyList<MoverResourceData> value, string nextLink, MoverSummaryList summaryCollection, long? totalCount, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            SummaryCollection = summaryCollection;
            TotalCount = totalCount;
            _rawData = rawData;
        }

        /// <summary> Gets the list of move resources. </summary>
        public IReadOnlyList<MoverResourceData> Value { get; }
        /// <summary> Gets the value of  next link. </summary>
        public string NextLink { get; }
        /// <summary> Gets or sets the list of summary items and the field on which summary is done. </summary>
        public MoverSummaryList SummaryCollection { get; }
        /// <summary> Gets the total count. </summary>
        public long? TotalCount { get; }
    }
}
