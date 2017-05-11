// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Result for a single task added as part of an add task collection
    /// operation.
    /// </summary>
    public partial class TaskAddResult
    {
        /// <summary>
        /// Initializes a new instance of the TaskAddResult class.
        /// </summary>
        public TaskAddResult() { }

        /// <summary>
        /// Initializes a new instance of the TaskAddResult class.
        /// </summary>
        /// <param name="status">The status of the add task request.</param>
        /// <param name="taskId">The ID of the task for which this is the
        /// result.</param>
        /// <param name="eTag">The ETag of the task, if the task was
        /// successfully added.</param>
        /// <param name="lastModified">The last modified time of the
        /// task.</param>
        /// <param name="location">The URL of the task, if the task was
        /// successfully added.</param>
        /// <param name="error">The error encountered while attempting to add
        /// the task.</param>
        public TaskAddResult(TaskAddStatus status, string taskId, string eTag = default(string), System.DateTime? lastModified = default(System.DateTime?), string location = default(string), BatchError error = default(BatchError))
        {
            Status = status;
            TaskId = taskId;
            ETag = eTag;
            LastModified = lastModified;
            Location = location;
            Error = error;
        }

        /// <summary>
        /// Gets or sets the status of the add task request.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'success', 'clientError', 'serverError'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public TaskAddStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the ID of the task for which this is the result.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "taskId")]
        public string TaskId { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the task, if the task was successfully
        /// added.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the last modified time of the task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastModified")]
        public System.DateTime? LastModified { get; set; }

        /// <summary>
        /// Gets or sets the URL of the task, if the task was successfully
        /// added.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the error encountered while attempting to add the
        /// task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "error")]
        public BatchError Error { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TaskId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "TaskId");
            }
        }
    }
}
