// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The AnalyzeJobState. </summary>
    internal partial class AnalyzeJobState : JobMetadata
    {
        /// <summary> Initializes a new instance of AnalyzeJobState. </summary>
        /// <param name="createdDateTime"> . </param>
        /// <param name="jobId"> . </param>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="status"> . </param>
        /// <param name="tasks"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tasks"/> is null. </exception>
        internal AnalyzeJobState(DateTimeOffset createdDateTime, Guid jobId, DateTimeOffset lastUpdateDateTime, State status, TasksStateTasks tasks) : base(createdDateTime, jobId, lastUpdateDateTime, status)
        {
            if (tasks == null)
            {
                throw new ArgumentNullException(nameof(tasks));
            }

            Errors = new ChangeTrackingList<TextAnalyticsErrorInternal>();
            Tasks = tasks;
        }

        /// <summary> Initializes a new instance of AnalyzeJobState. </summary>
        /// <param name="createdDateTime"> . </param>
        /// <param name="displayName"> . </param>
        /// <param name="expirationDateTime"> . </param>
        /// <param name="jobId"> . </param>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="status"> . </param>
        /// <param name="errors"> . </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the request payload. </param>
        /// <param name="tasks"> . </param>
        /// <param name="nextLink"> . </param>
        internal AnalyzeJobState(DateTimeOffset createdDateTime, string displayName, DateTimeOffset? expirationDateTime, Guid jobId, DateTimeOffset lastUpdateDateTime, State status, IReadOnlyList<TextAnalyticsErrorInternal> errors, TextDocumentBatchStatistics statistics, TasksStateTasks tasks, string nextLink) : base(createdDateTime, displayName, expirationDateTime, jobId, lastUpdateDateTime, status)
        {
            Errors = errors;
            Statistics = statistics;
            Tasks = tasks;
            NextLink = nextLink;
        }

        public IReadOnlyList<TextAnalyticsErrorInternal> Errors { get; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the request payload. </summary>
        public TextDocumentBatchStatistics Statistics { get; }
        public TasksStateTasks Tasks { get; }
        public string NextLink { get; }
    }
}
