// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Strictly used in update requests. </summary>
    public partial class BatchDeploymentDataPatch
    {
        /// <summary> Initializes a new instance of BatchDeploymentDataPatch. </summary>
        public BatchDeploymentDataPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Managed service identity (system assigned and/or user assigned identities). </summary>
        public PartialManagedServiceIdentity Identity { get; set; }
        /// <summary> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type. </summary>
        public string Kind { get; set; }
        /// <summary> The geo-location where the resource lives. </summary>
        public string Location { get; set; }
        /// <summary> Additional attributes of the entity. </summary>
        public PartialBatchDeployment Properties { get; set; }
        /// <summary> Sku details required for ARM contract for Autoscaling. </summary>
        public PartialSku Sku { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
