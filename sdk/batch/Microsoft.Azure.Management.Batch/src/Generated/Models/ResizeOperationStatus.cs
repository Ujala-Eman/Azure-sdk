// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Details about the current or last completed resize operation.
    /// </summary>
    /// <remarks>
    /// Describes either the current operation (if the pool AllocationState is
    /// Resizing) or the previously completed operation (if the AllocationState
    /// is Steady).
    /// </remarks>
    public partial class ResizeOperationStatus
    {
        /// <summary>
        /// Initializes a new instance of the ResizeOperationStatus class.
        /// </summary>
        public ResizeOperationStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResizeOperationStatus class.
        /// </summary>
        /// <param name="targetDedicatedNodes">The desired number of dedicated
        /// compute nodes in the pool.</param>
        /// <param name="targetLowPriorityNodes">The desired number of
        /// Spot/low-priority compute nodes in the pool.</param>
        /// <param name="resizeTimeout">The timeout for allocation of compute
        /// nodes to the pool or removal of compute nodes from the
        /// pool.</param>
        /// <param name="nodeDeallocationOption">Determines what to do with a
        /// node and its running task(s) if the pool size is
        /// decreasing.</param>
        /// <param name="startTime">The time when this resize operation was
        /// started.</param>
        /// <param name="errors">Details of any errors encountered while
        /// performing the last resize on the pool.</param>
        public ResizeOperationStatus(int? targetDedicatedNodes = default(int?), int? targetLowPriorityNodes = default(int?), System.TimeSpan? resizeTimeout = default(System.TimeSpan?), ComputeNodeDeallocationOption? nodeDeallocationOption = default(ComputeNodeDeallocationOption?), System.DateTime? startTime = default(System.DateTime?), IList<ResizeError> errors = default(IList<ResizeError>))
        {
            TargetDedicatedNodes = targetDedicatedNodes;
            TargetLowPriorityNodes = targetLowPriorityNodes;
            ResizeTimeout = resizeTimeout;
            NodeDeallocationOption = nodeDeallocationOption;
            StartTime = startTime;
            Errors = errors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the desired number of dedicated compute nodes in the
        /// pool.
        /// </summary>
        [JsonProperty(PropertyName = "targetDedicatedNodes")]
        public int? TargetDedicatedNodes { get; set; }

        /// <summary>
        /// Gets or sets the desired number of Spot/low-priority compute nodes
        /// in the pool.
        /// </summary>
        [JsonProperty(PropertyName = "targetLowPriorityNodes")]
        public int? TargetLowPriorityNodes { get; set; }

        /// <summary>
        /// Gets or sets the timeout for allocation of compute nodes to the
        /// pool or removal of compute nodes from the pool.
        /// </summary>
        /// <remarks>
        /// The default value is 15 minutes. The minimum value is 5 minutes. If
        /// you specify a value less than 5 minutes, the Batch service returns
        /// an error; if you are calling the REST API directly, the HTTP status
        /// code is 400 (Bad Request).
        /// </remarks>
        [JsonProperty(PropertyName = "resizeTimeout")]
        public System.TimeSpan? ResizeTimeout { get; set; }

        /// <summary>
        /// Gets or sets determines what to do with a node and its running
        /// task(s) if the pool size is decreasing.
        /// </summary>
        /// <remarks>
        /// The default value is requeue. Possible values include: 'Requeue',
        /// 'Terminate', 'TaskCompletion', 'RetainedData'
        /// </remarks>
        [JsonProperty(PropertyName = "nodeDeallocationOption")]
        public ComputeNodeDeallocationOption? NodeDeallocationOption { get; set; }

        /// <summary>
        /// Gets or sets the time when this resize operation was started.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets details of any errors encountered while performing the
        /// last resize on the pool.
        /// </summary>
        /// <remarks>
        /// This property is set only if an error occurred during the last pool
        /// resize, and only when the pool allocationState is Steady.
        /// </remarks>
        [JsonProperty(PropertyName = "errors")]
        public IList<ResizeError> Errors { get; set; }

    }
}
