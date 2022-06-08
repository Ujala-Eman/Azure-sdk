// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List Usages operation response. </summary>
    internal partial class ListUsagesResult
    {
        /// <summary> Initializes a new instance of <see cref="ListUsagesResult"/>. </summary>
        /// <param name="value"> The list of compute resource usages. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ListUsagesResult(IEnumerable<ComputeUsage> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ListUsagesResult"/>. </summary>
        /// <param name="value"> The list of compute resource usages. </param>
        /// <param name="nextLink"> The URI to fetch the next page of compute resource usage information. Call ListNext() with this to fetch the next page of compute resource usage information. </param>
        internal ListUsagesResult(IReadOnlyList<ComputeUsage> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of compute resource usages. </summary>
        public IReadOnlyList<ComputeUsage> Value { get; }
        /// <summary> The URI to fetch the next page of compute resource usage information. Call ListNext() with this to fetch the next page of compute resource usage information. </summary>
        public string NextLink { get; }
    }
}
