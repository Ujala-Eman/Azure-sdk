// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.AgFoodPlatform.SatelliteDataIngestionJobStatusChanged event. </summary>
    public partial class FarmBeatsSatelliteDataIngestionJobStatusChangedEventData
    {
        /// <summary> Initializes a new instance of FarmBeatsSatelliteDataIngestionJobStatusChangedEventData. </summary>
        internal FarmBeatsSatelliteDataIngestionJobStatusChangedEventData()
        {
            Properties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of FarmBeatsSatelliteDataIngestionJobStatusChangedEventData. </summary>
        /// <param name="farmerId"> Farmer id for which job was created. </param>
        /// <param name="message"> Status message to capture more details of the job. </param>
        /// <param name="status"> Various states a job can be in. </param>
        /// <param name="lastActionDateTime"> Date-time when last action was taken on job, sample format: yyyy-MM-ddTHH:mm:ssZ. </param>
        /// <param name="isCancellationRequested"> Flag that gets set when job cancellation is requested. </param>
        /// <param name="id"> Unique id of resource. </param>
        /// <param name="name"> Name to identify resource. </param>
        /// <param name="description"> Textual description of resource. </param>
        /// <param name="createdDateTime"> Date-time when resource was created, sample format: yyyy-MM-ddTHH:mm:ssZ. </param>
        /// <param name="properties">
        /// A list of key value pairs that describe the resource.
        /// 
        /// Only string and numeral values are supported.
        /// </param>
        internal FarmBeatsSatelliteDataIngestionJobStatusChangedEventData(string farmerId, string message, FarmBeatsJobStatus? status, DateTimeOffset? lastActionDateTime, bool? isCancellationRequested, string id, string name, string description, DateTimeOffset? createdDateTime, IReadOnlyDictionary<string, object> properties)
        {
            FarmerId = farmerId;
            Message = message;
            Status = status;
            LastActionDateTime = lastActionDateTime;
            IsCancellationRequested = isCancellationRequested;
            Id = id;
            Name = name;
            Description = description;
            CreatedDateTime = createdDateTime;
            Properties = properties;
        }

        /// <summary> Farmer id for which job was created. </summary>
        public string FarmerId { get; }
        /// <summary> Status message to capture more details of the job. </summary>
        public string Message { get; }
        /// <summary> Various states a job can be in. </summary>
        public FarmBeatsJobStatus? Status { get; }
        /// <summary> Date-time when last action was taken on job, sample format: yyyy-MM-ddTHH:mm:ssZ. </summary>
        public DateTimeOffset? LastActionDateTime { get; }
        /// <summary> Flag that gets set when job cancellation is requested. </summary>
        public bool? IsCancellationRequested { get; }
        /// <summary> Unique id of resource. </summary>
        public string Id { get; }
        /// <summary> Name to identify resource. </summary>
        public string Name { get; }
        /// <summary> Textual description of resource. </summary>
        public string Description { get; }
        /// <summary> Date-time when resource was created, sample format: yyyy-MM-ddTHH:mm:ssZ. </summary>
        public DateTimeOffset? CreatedDateTime { get; }
        /// <summary>
        /// A list of key value pairs that describe the resource.
        /// 
        /// Only string and numeral values are supported.
        /// </summary>
        public IReadOnlyDictionary<string, object> Properties { get; }
    }
}
