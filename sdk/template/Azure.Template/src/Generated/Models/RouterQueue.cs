// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> A queue that can contain jobs to be routed. </summary>
    public partial class RouterQueue
    {
        /// <summary> Initializes a new instance of RouterQueue. </summary>
        public RouterQueue()
        {
            Labels = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of RouterQueue. </summary>
        /// <param name="id"> The Id of this queue. </param>
        /// <param name="name"> The name of this queue. </param>
        /// <param name="distributionPolicyId"> The ID of the distribution policy that will determine how a job is distributed to workers. </param>
        /// <param name="labels"> A set of key/value pairs that are identifying attributes used by the rules engines to make decisions. </param>
        /// <param name="exceptionPolicyId"> (Optional) The ID of the exception policy that determines various job escalation rules. </param>
        internal RouterQueue(string id, string name, string distributionPolicyId, IDictionary<string, object> labels, string exceptionPolicyId)
        {
            Id = id;
            Name = name;
            DistributionPolicyId = distributionPolicyId;
            Labels = labels;
            ExceptionPolicyId = exceptionPolicyId;
        }

        /// <summary> The Id of this queue. </summary>
        public string Id { get; }
        /// <summary> The name of this queue. </summary>
        public string Name { get; set; }
        /// <summary> The ID of the distribution policy that will determine how a job is distributed to workers. </summary>
        public string DistributionPolicyId { get; set; }
        /// <summary> A set of key/value pairs that are identifying attributes used by the rules engines to make decisions. </summary>
        public IDictionary<string, object> Labels { get; }
        /// <summary> (Optional) The ID of the exception policy that determines various job escalation rules. </summary>
        public string ExceptionPolicyId { get; set; }
    }
}
