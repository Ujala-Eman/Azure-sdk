// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> The JobRequest. </summary>
    public partial class JobRequest
    {
        /// <summary> Initializes a new instance of JobRequest. </summary>
        public JobRequest()
        {
        }

        /// <summary> Initializes a new instance of JobRequest. </summary>
        /// <param name="jobId"> Job identifier. </param>
        /// <param name="type"> The type of job to execute. </param>
        /// <param name="cloudToDeviceMethod"> Required if jobType is cloudToDeviceMethod. The method type and parameters. </param>
        /// <param name="updateTwin"> The state information for a device or module. Implicitly created and deleted when the corresponding device/ module identity is created or deleted in IoT Hub. </param>
        /// <param name="queryCondition"> Required if jobType is updateTwin or cloudToDeviceMethod. Condition for device query to get devices to execute the job on. </param>
        /// <param name="startTime"> ISO 8601 date time to start the job. </param>
        /// <param name="maxExecutionTimeInSeconds"> Max execution time in secounds (ttl duration). </param>
        internal JobRequest(string jobId, JobRequestType? type, CloudToDeviceMethod cloudToDeviceMethod, TwinData updateTwin, string queryCondition, DateTimeOffset? startTime, long? maxExecutionTimeInSeconds)
        {
            JobId = jobId;
            Type = type;
            CloudToDeviceMethod = cloudToDeviceMethod;
            UpdateTwin = updateTwin;
            QueryCondition = queryCondition;
            StartTime = startTime;
            MaxExecutionTimeInSeconds = maxExecutionTimeInSeconds;
        }

        /// <summary> Job identifier. </summary>
        public string JobId { get; set; }
        /// <summary> The type of job to execute. </summary>
        public JobRequestType? Type { get; set; }
        /// <summary> Required if jobType is cloudToDeviceMethod. The method type and parameters. </summary>
        public CloudToDeviceMethod CloudToDeviceMethod { get; set; }
        /// <summary> The state information for a device or module. Implicitly created and deleted when the corresponding device/ module identity is created or deleted in IoT Hub. </summary>
        public TwinData UpdateTwin { get; set; }
        /// <summary> Required if jobType is updateTwin or cloudToDeviceMethod. Condition for device query to get devices to execute the job on. </summary>
        public string QueryCondition { get; set; }
        /// <summary> ISO 8601 date time to start the job. </summary>
        public DateTimeOffset? StartTime { get; set; }
        /// <summary> Max execution time in secounds (ttl duration). </summary>
        public long? MaxExecutionTimeInSeconds { get; set; }
    }
}
