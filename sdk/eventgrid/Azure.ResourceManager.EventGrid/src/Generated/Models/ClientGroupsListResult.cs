// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Result of the List Client Group operation. </summary>
    internal partial class ClientGroupsListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ClientGroupsListResult"/>. </summary>
        internal ClientGroupsListResult()
        {
            Value = new ChangeTrackingList<EventGridNamespaceClientGroupData>();
        }

        /// <summary> Initializes a new instance of <see cref="ClientGroupsListResult"/>. </summary>
        /// <param name="value"> A collection of Client Group. </param>
        /// <param name="nextLink"> A link for the next page of Client Group. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ClientGroupsListResult(IReadOnlyList<EventGridNamespaceClientGroupData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A collection of Client Group. </summary>
        public IReadOnlyList<EventGridNamespaceClientGroupData> Value { get; }
        /// <summary> A link for the next page of Client Group. </summary>
        public string NextLink { get; }
    }
}
