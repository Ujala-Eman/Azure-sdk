// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> A collection of StreamingPolicy items. </summary>
    internal partial class StreamingPolicyCollection
    {
        /// <summary> Initializes a new instance of StreamingPolicyCollection. </summary>
        internal StreamingPolicyCollection()
        {
            Value = new ChangeTrackingList<StreamingPolicyData>();
        }

        /// <summary> Initializes a new instance of StreamingPolicyCollection. </summary>
        /// <param name="value"> A collection of StreamingPolicy items. </param>
        /// <param name="odataNextLink"> A link to the next page of the collection (when the collection contains too many results to return in one response). </param>
        internal StreamingPolicyCollection(IReadOnlyList<StreamingPolicyData> value, string odataNextLink)
        {
            Value = value;
            OdataNextLink = odataNextLink;
        }

        /// <summary> A collection of StreamingPolicy items. </summary>
        public IReadOnlyList<StreamingPolicyData> Value { get; }
        /// <summary> A link to the next page of the collection (when the collection contains too many results to return in one response). </summary>
        public string OdataNextLink { get; }
    }
}
