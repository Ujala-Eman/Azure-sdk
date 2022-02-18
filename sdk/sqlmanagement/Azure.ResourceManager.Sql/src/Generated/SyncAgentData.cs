// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the SyncAgent data model. </summary>
    public partial class SyncAgentData : ResourceData
    {
        /// <summary> Initializes a new instance of SyncAgentData. </summary>
        public SyncAgentData()
        {
        }

        /// <summary> Initializes a new instance of SyncAgentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="namePropertiesName"> Name of the sync agent. </param>
        /// <param name="syncDatabaseId"> ARM resource id of the sync database in the sync agent. </param>
        /// <param name="lastAliveTime"> Last alive time of the sync agent. </param>
        /// <param name="state"> State of the sync agent. </param>
        /// <param name="isUpToDate"> If the sync agent version is up to date. </param>
        /// <param name="expiryTime"> Expiration time of the sync agent version. </param>
        /// <param name="version"> Version of the sync agent. </param>
        internal SyncAgentData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string namePropertiesName, string syncDatabaseId, DateTimeOffset? lastAliveTime, SyncAgentState? state, bool? isUpToDate, DateTimeOffset? expiryTime, string version) : base(id, name, type, systemData)
        {
            NamePropertiesName = namePropertiesName;
            SyncDatabaseId = syncDatabaseId;
            LastAliveTime = lastAliveTime;
            State = state;
            IsUpToDate = isUpToDate;
            ExpiryTime = expiryTime;
            Version = version;
        }

        /// <summary> Name of the sync agent. </summary>
        public string NamePropertiesName { get; }
        /// <summary> ARM resource id of the sync database in the sync agent. </summary>
        public string SyncDatabaseId { get; set; }
        /// <summary> Last alive time of the sync agent. </summary>
        public DateTimeOffset? LastAliveTime { get; }
        /// <summary> State of the sync agent. </summary>
        public SyncAgentState? State { get; }
        /// <summary> If the sync agent version is up to date. </summary>
        public bool? IsUpToDate { get; }
        /// <summary> Expiration time of the sync agent version. </summary>
        public DateTimeOffset? ExpiryTime { get; }
        /// <summary> Version of the sync agent. </summary>
        public string Version { get; }
    }
}
