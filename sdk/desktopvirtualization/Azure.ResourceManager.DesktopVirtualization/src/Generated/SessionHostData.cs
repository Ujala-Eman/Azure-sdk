// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing the SessionHost data model.
    /// Represents a SessionHost definition.
    /// </summary>
    public partial class SessionHostData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SessionHostData"/>. </summary>
        public SessionHostData()
        {
            SessionHostHealthCheckResults = new ChangeTrackingList<SessionHostHealthCheckReport>();
        }

        /// <summary> Initializes a new instance of <see cref="SessionHostData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="objectId"> ObjectId of SessionHost. (internal use). </param>
        /// <param name="lastHeartBeatOn"> Last heart beat from SessionHost. </param>
        /// <param name="sessions"> Number of sessions on SessionHost. </param>
        /// <param name="agentVersion"> Version of agent on SessionHost. </param>
        /// <param name="allowNewSession"> Allow a new session. </param>
        /// <param name="vmId"> Virtual Machine Id of SessionHost's underlying virtual machine. </param>
        /// <param name="resourceId"> Resource Id of SessionHost's underlying virtual machine. </param>
        /// <param name="assignedUser"> User assigned to SessionHost. </param>
        /// <param name="friendlyName"> Friendly name of SessionHost. </param>
        /// <param name="status"> Status for a SessionHost. </param>
        /// <param name="statusTimestamp"> The timestamp of the status. </param>
        /// <param name="osVersion"> The version of the OS on the session host. </param>
        /// <param name="sxsStackVersion"> The version of the side by side stack on the session host. </param>
        /// <param name="updateState"> Update state of a SessionHost. </param>
        /// <param name="lastUpdatedOn"> The timestamp of the last update. </param>
        /// <param name="updateErrorMessage"> The error message. </param>
        /// <param name="sessionHostHealthCheckResults"> List of SessionHostHealthCheckReports. </param>
        internal SessionHostData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string objectId, DateTimeOffset? lastHeartBeatOn, int? sessions, string agentVersion, bool? allowNewSession, string vmId, ResourceIdentifier resourceId, string assignedUser, string friendlyName, SessionHostStatus? status, DateTimeOffset? statusTimestamp, string osVersion, string sxsStackVersion, SessionHostUpdateState? updateState, DateTimeOffset? lastUpdatedOn, string updateErrorMessage, IReadOnlyList<SessionHostHealthCheckReport> sessionHostHealthCheckResults) : base(id, name, resourceType, systemData)
        {
            ObjectId = objectId;
            LastHeartBeatOn = lastHeartBeatOn;
            Sessions = sessions;
            AgentVersion = agentVersion;
            AllowNewSession = allowNewSession;
            VmId = vmId;
            ResourceId = resourceId;
            AssignedUser = assignedUser;
            FriendlyName = friendlyName;
            Status = status;
            StatusTimestamp = statusTimestamp;
            OSVersion = osVersion;
            SxsStackVersion = sxsStackVersion;
            UpdateState = updateState;
            LastUpdatedOn = lastUpdatedOn;
            UpdateErrorMessage = updateErrorMessage;
            SessionHostHealthCheckResults = sessionHostHealthCheckResults;
        }

        /// <summary> ObjectId of SessionHost. (internal use). </summary>
        public string ObjectId { get; }
        /// <summary> Last heart beat from SessionHost. </summary>
        public DateTimeOffset? LastHeartBeatOn { get; set; }
        /// <summary> Number of sessions on SessionHost. </summary>
        public int? Sessions { get; set; }
        /// <summary> Version of agent on SessionHost. </summary>
        public string AgentVersion { get; set; }
        /// <summary> Allow a new session. </summary>
        public bool? AllowNewSession { get; set; }
        /// <summary> Virtual Machine Id of SessionHost's underlying virtual machine. </summary>
        public string VmId { get; }
        /// <summary> Resource Id of SessionHost's underlying virtual machine. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> User assigned to SessionHost. </summary>
        public string AssignedUser { get; set; }
        /// <summary> Friendly name of SessionHost. </summary>
        public string FriendlyName { get; set; }
        /// <summary> Status for a SessionHost. </summary>
        public SessionHostStatus? Status { get; set; }
        /// <summary> The timestamp of the status. </summary>
        public DateTimeOffset? StatusTimestamp { get; }
        /// <summary> The version of the OS on the session host. </summary>
        public string OSVersion { get; set; }
        /// <summary> The version of the side by side stack on the session host. </summary>
        public string SxsStackVersion { get; set; }
        /// <summary> Update state of a SessionHost. </summary>
        public SessionHostUpdateState? UpdateState { get; set; }
        /// <summary> The timestamp of the last update. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> The error message. </summary>
        public string UpdateErrorMessage { get; set; }
        /// <summary> List of SessionHostHealthCheckReports. </summary>
        public IReadOnlyList<SessionHostHealthCheckReport> SessionHostHealthCheckResults { get; }
    }
}
