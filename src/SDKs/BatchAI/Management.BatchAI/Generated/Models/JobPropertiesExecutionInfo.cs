// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contains information about the execution of a job in the Azure Batch
    /// service.
    /// </summary>
    public partial class JobPropertiesExecutionInfo
    {
        /// <summary>
        /// Initializes a new instance of the JobPropertiesExecutionInfo class.
        /// </summary>
        public JobPropertiesExecutionInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobPropertiesExecutionInfo class.
        /// </summary>
        /// <param name="startTime">The time at which the job started
        /// running.</param>
        /// <param name="endTime">The time at which the job completed.</param>
        /// <param name="exitCode">The exit code of the job.</param>
        /// <param name="errors">Contains details of various errors encountered
        /// by the service during job execution</param>
        public JobPropertiesExecutionInfo(System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), int? exitCode = default(int?), IList<BatchAIError> errors = default(IList<BatchAIError>))
        {
            StartTime = startTime;
            EndTime = endTime;
            ExitCode = exitCode;
            Errors = errors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the time at which the job started running.
        /// </summary>
        /// <remarks>
        /// 'Running' corresponds to the running state. If the job has been
        /// restarted or retried, this is the most recent time at which the job
        /// started running. This property is present only for job that are in
        /// the running or completed state.
        /// </remarks>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the job completed.
        /// </summary>
        /// <remarks>
        /// This property is only returned if the job is in completed state.
        /// </remarks>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the exit code of the job.
        /// </summary>
        /// <remarks>
        /// This property is only returned if the job is in completed state.
        /// </remarks>
        [JsonProperty(PropertyName = "exitCode")]
        public int? ExitCode { get; set; }

        /// <summary>
        /// Gets or sets contains details of various errors encountered by the
        /// service during job execution
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<BatchAIError> Errors { get; set; }

    }
}
