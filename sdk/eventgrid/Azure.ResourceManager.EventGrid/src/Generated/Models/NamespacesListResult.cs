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
    /// <summary> Result of the List Namespaces operation. </summary>
    internal partial class NamespacesListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NamespacesListResult"/>. </summary>
        internal NamespacesListResult()
        {
            Value = new ChangeTrackingList<EventGridNamespaceData>();
        }

        /// <summary> Initializes a new instance of <see cref="NamespacesListResult"/>. </summary>
        /// <param name="value"> A collection of namespaces. </param>
        /// <param name="nextLink"> A link for the next page of namespaces. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NamespacesListResult(IReadOnlyList<EventGridNamespaceData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A collection of namespaces. </summary>
        public IReadOnlyList<EventGridNamespaceData> Value { get; }
        /// <summary> A link for the next page of namespaces. </summary>
        public string NextLink { get; }
    }
}
