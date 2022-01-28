// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the WorkerPoolResource data model. </summary>
    public partial class WorkerPoolResourceData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of WorkerPoolResourceData. </summary>
        public WorkerPoolResourceData()
        {
            InstanceNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of WorkerPoolResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="sku"> Description of a SKU for a scalable resource. </param>
        /// <param name="workerSizeId"> Worker size ID for referencing this worker pool. </param>
        /// <param name="computeMode"> Shared or dedicated app hosting. </param>
        /// <param name="workerSize"> VM size of the worker pool instances. </param>
        /// <param name="workerCount"> Number of instances in the worker pool. </param>
        /// <param name="instanceNames"> Names of all instances in the worker pool (read only). </param>
        internal WorkerPoolResourceData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string kind, SkuDescription sku, int? workerSizeId, ComputeModeOptions? computeMode, string workerSize, int? workerCount, IReadOnlyList<string> instanceNames) : base(id, name, type, systemData, kind)
        {
            Sku = sku;
            WorkerSizeId = workerSizeId;
            ComputeMode = computeMode;
            WorkerSize = workerSize;
            WorkerCount = workerCount;
            InstanceNames = instanceNames;
        }

        /// <summary> Description of a SKU for a scalable resource. </summary>
        public SkuDescription Sku { get; set; }
        /// <summary> Worker size ID for referencing this worker pool. </summary>
        public int? WorkerSizeId { get; set; }
        /// <summary> Shared or dedicated app hosting. </summary>
        public ComputeModeOptions? ComputeMode { get; set; }
        /// <summary> VM size of the worker pool instances. </summary>
        public string WorkerSize { get; set; }
        /// <summary> Number of instances in the worker pool. </summary>
        public int? WorkerCount { get; set; }
        /// <summary> Names of all instances in the worker pool (read only). </summary>
        public IReadOnlyList<string> InstanceNames { get; }
    }
}
