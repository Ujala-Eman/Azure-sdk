// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> Statistics for the queue. </summary>
    public partial class QueueStatistics
    {
        /// <summary> Initializes a new instance of QueueStatistics. </summary>
        /// <param name="queueId"> Id of the queue these details are about. </param>
        /// <param name="length"> Length of the queue: total number of enqueued jobs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queueId"/> is null. </exception>
        internal QueueStatistics(string queueId, int length)
        {
            if (queueId == null)
            {
                throw new ArgumentNullException(nameof(queueId));
            }

            QueueId = queueId;
            Length = length;
            EstimatedWaitTimeMinutes = new ChangeTrackingDictionary<string, double>();
        }

        /// <summary> Initializes a new instance of QueueStatistics. </summary>
        /// <param name="queueId"> Id of the queue these details are about. </param>
        /// <param name="length"> Length of the queue: total number of enqueued jobs. </param>
        /// <param name="estimatedWaitTimeMinutes"> The estimated wait time of this queue rounded up to the nearest minute, grouped by job priority. </param>
        /// <param name="longestJobWaitTimeMinutes"> The wait time of the job that has been enqueued in this queue for the longest. </param>
        internal QueueStatistics(string queueId, int length, IReadOnlyDictionary<string, double> estimatedWaitTimeMinutes, double? longestJobWaitTimeMinutes)
        {
            QueueId = queueId;
            Length = length;
            EstimatedWaitTimeMinutes = estimatedWaitTimeMinutes;
            LongestJobWaitTimeMinutes = longestJobWaitTimeMinutes;
        }

        /// <summary> Id of the queue these details are about. </summary>
        public string QueueId { get; }
        /// <summary> Length of the queue: total number of enqueued jobs. </summary>
        public int Length { get; }
        /// <summary> The estimated wait time of this queue rounded up to the nearest minute, grouped by job priority. </summary>
        public IReadOnlyDictionary<string, double> EstimatedWaitTimeMinutes { get; }
        /// <summary> The wait time of the job that has been enqueued in this queue for the longest. </summary>
        public double? LongestJobWaitTimeMinutes { get; }
    }
}
