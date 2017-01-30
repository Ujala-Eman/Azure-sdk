// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Options for changing the size of a pool.
    /// </summary>
    public partial class PoolResizeParameter
    {
        /// <summary>
        /// Initializes a new instance of the PoolResizeParameter class.
        /// </summary>
        public PoolResizeParameter() { }

        /// <summary>
        /// Initializes a new instance of the PoolResizeParameter class.
        /// </summary>
        /// <param name="targetDedicated">The desired number of compute nodes
        /// in the pool.</param>
        /// <param name="resizeTimeout">The timeout for allocation of compute
        /// nodes to the pool or removal of compute nodes from the
        /// pool.</param>
        /// <param name="nodeDeallocationOption">When nodes may be removed from
        /// the pool, if the pool size is decreasing.</param>
        public PoolResizeParameter(int targetDedicated, System.TimeSpan? resizeTimeout = default(System.TimeSpan?), ComputeNodeDeallocationOption? nodeDeallocationOption = default(ComputeNodeDeallocationOption?))
        {
            TargetDedicated = targetDedicated;
            ResizeTimeout = resizeTimeout;
            NodeDeallocationOption = nodeDeallocationOption;
        }

        /// <summary>
        /// Gets or sets the desired number of compute nodes in the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetDedicated")]
        public int TargetDedicated { get; set; }

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
        [Newtonsoft.Json.JsonProperty(PropertyName = "resizeTimeout")]
        public System.TimeSpan? ResizeTimeout { get; set; }

        /// <summary>
        /// Gets or sets when nodes may be removed from the pool, if the pool
        /// size is decreasing.
        /// </summary>
        /// <remarks>
        /// The default value is requeue. Possible values include: 'requeue',
        /// 'terminate', 'taskcompletion', 'retaineddata'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nodeDeallocationOption")]
        public ComputeNodeDeallocationOption? NodeDeallocationOption { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
