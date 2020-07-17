// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Parameters for updating a workspace resource. </summary>
    internal partial class WorkspaceUpdateParameters
    {
        /// <summary> Initializes a new instance of WorkspaceUpdateParameters. </summary>
        internal WorkspaceUpdateParameters()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of WorkspaceUpdateParameters. </summary>
        /// <param name="tags"> The resource tags. </param>
        /// <param name="identity"> Managed service identity of the workspace. </param>
        internal WorkspaceUpdateParameters(IReadOnlyDictionary<string, string> tags, WorkspaceIdentity identity)
        {
            Tags = tags;
            Identity = identity;
        }

        /// <summary> The resource tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary> Managed service identity of the workspace. </summary>
        public WorkspaceIdentity Identity { get; }
    }
}
