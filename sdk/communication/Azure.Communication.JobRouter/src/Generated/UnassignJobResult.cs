// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> Response payload after a job has been successfully unassigned. </summary>
    public partial class UnassignJobResult
    {
        /// <summary> Initializes a new instance of UnassignJobResult. </summary>
        /// <param name="jobId"> The Id of the job unassigned. </param>
        /// <param name="unassignmentCount"> The number of times a job is unassigned. At a maximum 3. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        internal UnassignJobResult(string jobId, int unassignmentCount)
        {
            Argument.AssertNotNull(jobId, nameof(jobId));

            JobId = jobId;
            UnassignmentCount = unassignmentCount;
        }

        /// <summary> The Id of the job unassigned. </summary>
        public string JobId { get; }
        /// <summary> The number of times a job is unassigned. At a maximum 3. </summary>
        public int UnassignmentCount { get; }
    }
}
