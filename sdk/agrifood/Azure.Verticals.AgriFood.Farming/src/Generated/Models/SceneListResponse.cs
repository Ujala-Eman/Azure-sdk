// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Verticals.AgriFood.Farming.Models
{
    /// <summary> Paged response contains list of requested objects and a URL link to get the next set of results. </summary>
    internal partial class SceneListResponse
    {
        /// <summary> Initializes a new instance of SceneListResponse. </summary>
        internal SceneListResponse()
        {
            Value = new ChangeTrackingList<Scene>();
        }

        /// <summary> Initializes a new instance of SceneListResponse. </summary>
        /// <param name="value"> List of requested objects. </param>
        /// <param name="skipToken"> Token used in retrieving the next page. If null, there are no additional pages. </param>
        /// <param name="nextLink"> Continuation link (absolute URI) to the next page of results in the list. </param>
        internal SceneListResponse(IReadOnlyList<Scene> value, string skipToken, string nextLink)
        {
            Value = value;
            SkipToken = skipToken;
            NextLink = nextLink;
        }

        /// <summary> List of requested objects. </summary>
        public IReadOnlyList<Scene> Value { get; }
        /// <summary> Token used in retrieving the next page. If null, there are no additional pages. </summary>
        public string SkipToken { get; }
        /// <summary> Continuation link (absolute URI) to the next page of results in the list. </summary>
        public string NextLink { get; }
    }
}
