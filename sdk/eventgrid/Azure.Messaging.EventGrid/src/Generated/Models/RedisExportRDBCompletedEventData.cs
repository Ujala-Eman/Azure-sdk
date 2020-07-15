// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.Models
{
    /// <summary> Schema of the Data property of an EventGridEvent for an Microsoft.Cache.ExportRDBCompleted event. </summary>
    internal partial class RedisExportRDBCompletedEventData
    {
        /// <summary> Initializes a new instance of RedisExportRDBCompletedEventData. </summary>
        internal RedisExportRDBCompletedEventData()
        {
        }

        /// <summary> Initializes a new instance of RedisExportRDBCompletedEventData. </summary>
        /// <param name="timestamp"> The time at which the event occurred. </param>
        /// <param name="name"> The name of this event. </param>
        /// <param name="status"> The status of this event. Failed or  succeeded. </param>
        internal RedisExportRDBCompletedEventData(DateTimeOffset? timestamp, string name, string status)
        {
            Timestamp = timestamp;
            Name = name;
            Status = status;
        }

        /// <summary> The time at which the event occurred. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> The name of this event. </summary>
        public string Name { get; }
        /// <summary> The status of this event. Failed or  succeeded. </summary>
        public string Status { get; }
    }
}
