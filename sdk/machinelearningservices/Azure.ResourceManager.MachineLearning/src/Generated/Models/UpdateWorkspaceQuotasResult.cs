// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The result of update workspace quota. </summary>
    internal partial class UpdateWorkspaceQuotasResult
    {
        /// <summary> Initializes a new instance of UpdateWorkspaceQuotasResult. </summary>
        internal UpdateWorkspaceQuotasResult()
        {
            Value = new ChangeTrackingList<UpdateWorkspaceQuotas>();
        }

        /// <summary> Initializes a new instance of UpdateWorkspaceQuotasResult. </summary>
        /// <param name="value"> The list of workspace quota update result. </param>
        /// <param name="nextLink"> The URI to fetch the next page of workspace quota update result. Call ListNext() with this to fetch the next page of Workspace Quota update result. </param>
        internal UpdateWorkspaceQuotasResult(IReadOnlyList<UpdateWorkspaceQuotas> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of workspace quota update result. </summary>
        public IReadOnlyList<UpdateWorkspaceQuotas> Value { get; }
        /// <summary> The URI to fetch the next page of workspace quota update result. Call ListNext() with this to fetch the next page of Workspace Quota update result. </summary>
        public string NextLink { get; }
    }
}
