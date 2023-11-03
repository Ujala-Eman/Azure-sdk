// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.IntegrationSpaces;

namespace Azure.ResourceManager.IntegrationSpaces.Models
{
    /// <summary> The response of a Space list operation. </summary>
    internal partial class SpaceListResult
    {
        /// <summary> Initializes a new instance of SpaceListResult. </summary>
        /// <param name="value"> The Space items on this page. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SpaceListResult(IEnumerable<SpaceData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of SpaceListResult. </summary>
        /// <param name="value"> The Space items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        internal SpaceListResult(IReadOnlyList<SpaceData> value, Uri nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The Space items on this page. </summary>
        public IReadOnlyList<SpaceData> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public Uri NextLink { get; }
    }
}
