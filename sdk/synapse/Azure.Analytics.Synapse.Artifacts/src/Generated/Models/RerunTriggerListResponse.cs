// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A list of rerun triggers. </summary>
    public partial class RerunTriggerListResponse
    {

        /// <summary> List of rerun triggers. </summary>
        public IReadOnlyList<RerunTriggerResource> Value { get; }
        /// <summary> The continuation token for getting the next page of results, if any remaining results exist, null otherwise. </summary>
        public string NextLink { get; }
    }
}
