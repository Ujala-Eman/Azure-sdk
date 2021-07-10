// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> Strictly used in update requests. </summary>
    public partial class PartialOnlineDeploymentPartialTrackedResource
    {
        /// <summary> Initializes a new instance of PartialOnlineDeploymentPartialTrackedResource. </summary>
        public PartialOnlineDeploymentPartialTrackedResource()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Service identity associated with a resource. </summary>
        public ResourceIdentity Identity { get; set; }
        public string Kind { get; set; }
        public string Location { get; set; }
        /// <summary> Additional attributes of the entity. </summary>
        public PartialOnlineDeployment Properties { get; set; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
