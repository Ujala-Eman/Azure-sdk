// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.Monitor.Query;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The comma separated list of resource IDs to query metrics for. </summary>
    internal partial class ResourceIdList
    {
        /// <summary> Initializes a new instance of <see cref="ResourceIdList"/>. </summary>
        public ResourceIdList()
        {
            Resourceids = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceIdList"/>. </summary>
        /// <param name="resourceids"> The list of resource IDs to query metrics for. </param>
        internal ResourceIdList(IList<ResourceIdentifier> resourceids)
        {
            Resourceids = resourceids;
        }

        /// <summary> The list of resource IDs to query metrics for. </summary>
        public IList<ResourceIdentifier> Resourceids { get; }
    }
}
