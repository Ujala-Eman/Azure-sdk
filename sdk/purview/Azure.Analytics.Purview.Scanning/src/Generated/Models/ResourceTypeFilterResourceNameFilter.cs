// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The ResourceTypeFilterResourceNameFilter. </summary>
    public partial class ResourceTypeFilterResourceNameFilter : ResourceNameFilter
    {
        /// <summary> Initializes a new instance of ResourceTypeFilterResourceNameFilter. </summary>
        public ResourceTypeFilterResourceNameFilter()
        {
        }

        /// <summary> Initializes a new instance of ResourceTypeFilterResourceNameFilter. </summary>
        /// <param name="excludePrefixes"></param>
        /// <param name="includePrefixes"></param>
        /// <param name="resources"></param>
        internal ResourceTypeFilterResourceNameFilter(IList<string> excludePrefixes, IList<string> includePrefixes, IList<string> resources) : base(excludePrefixes, includePrefixes, resources)
        {
        }
    }
}
