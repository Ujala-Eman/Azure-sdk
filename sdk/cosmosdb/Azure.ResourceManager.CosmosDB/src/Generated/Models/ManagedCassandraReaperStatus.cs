// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The ManagedCassandraReaperStatus. </summary>
    public partial class ManagedCassandraReaperStatus
    {
        /// <summary> Initializes a new instance of <see cref="ManagedCassandraReaperStatus"/>. </summary>
        internal ManagedCassandraReaperStatus()
        {
            RepairRunIds = new ChangeTrackingDictionary<string, string>();
            RepairSchedules = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedCassandraReaperStatus"/>. </summary>
        /// <param name="healthy"></param>
        /// <param name="repairRunIds"> Dictionary of &lt;string&gt;. </param>
        /// <param name="repairSchedules"> Dictionary of &lt;string&gt;. </param>
        internal ManagedCassandraReaperStatus(bool? healthy, IReadOnlyDictionary<string, string> repairRunIds, IReadOnlyDictionary<string, string> repairSchedules)
        {
            Healthy = healthy;
            RepairRunIds = repairRunIds;
            RepairSchedules = repairSchedules;
        }

        /// <summary> Gets the healthy. </summary>
        public bool? Healthy { get; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IReadOnlyDictionary<string, string> RepairRunIds { get; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IReadOnlyDictionary<string, string> RepairSchedules { get; }
    }
}
