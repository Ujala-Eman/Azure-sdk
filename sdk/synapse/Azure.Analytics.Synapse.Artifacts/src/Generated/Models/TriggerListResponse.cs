// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A list of trigger resources. </summary>
    public partial class TriggerListResponse
    {
        /// <summary> Initializes a new instance of TriggerListResponse. </summary>
        /// <param name="value"> List of triggers. </param>
        internal TriggerListResponse(IEnumerable<TriggerResource> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToArray();
        }

        /// <summary> Initializes a new instance of TriggerListResponse. </summary>
        /// <param name="value"> List of triggers. </param>
        /// <param name="nextLink"> The link to the next page of results, if any remaining results exist. </param>
        internal TriggerListResponse(IReadOnlyList<TriggerResource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of triggers. </summary>
        public IReadOnlyList<TriggerResource> Value { get; }
        /// <summary> The link to the next page of results, if any remaining results exist. </summary>
        public string NextLink { get; }
    }
}
