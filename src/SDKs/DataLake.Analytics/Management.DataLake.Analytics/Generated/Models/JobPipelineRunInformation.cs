// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Run info for a specific job pipeline.
    /// </summary>
    public partial class JobPipelineRunInformation
    {
        /// <summary>
        /// Initializes a new instance of the JobPipelineRunInformation class.
        /// </summary>
        public JobPipelineRunInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobPipelineRunInformation class.
        /// </summary>
        /// <param name="runId">The run identifier of an instance of pipeline
        /// executions (a GUID).</param>
        /// <param name="lastSubmitTime">The time this instance was last
        /// submitted.</param>
        public JobPipelineRunInformation(System.Guid? runId = default(System.Guid?), System.DateTimeOffset? lastSubmitTime = default(System.DateTimeOffset?))
        {
            RunId = runId;
            LastSubmitTime = lastSubmitTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the run identifier of an instance of pipeline executions (a
        /// GUID).
        /// </summary>
        [JsonProperty(PropertyName = "runId")]
        public System.Guid? RunId { get; private set; }

        /// <summary>
        /// Gets the time this instance was last submitted.
        /// </summary>
        [JsonProperty(PropertyName = "lastSubmitTime")]
        public System.DateTimeOffset? LastSubmitTime { get; private set; }

    }
}
