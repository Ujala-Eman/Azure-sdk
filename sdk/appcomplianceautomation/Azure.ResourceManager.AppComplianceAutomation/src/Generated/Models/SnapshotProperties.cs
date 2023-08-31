// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> Snapshot's properties. </summary>
    public partial class SnapshotProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SnapshotProperties"/>. </summary>
        internal SnapshotProperties()
        {
            ComplianceResults = new ChangeTrackingList<ComplianceResult>();
        }

        /// <summary> Initializes a new instance of <see cref="SnapshotProperties"/>. </summary>
        /// <param name="id"> Snapshot id in the database. </param>
        /// <param name="snapshotName"> Snapshot name. </param>
        /// <param name="createdOn"> The timestamp of resource creation (UTC). </param>
        /// <param name="provisioningState"> Azure lifecycle management. </param>
        /// <param name="reportProperties"> The report essential info. </param>
        /// <param name="reportSystemData"> Metadata pertaining to creation and last modification of the resource. </param>
        /// <param name="complianceResults"> List of compliance results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SnapshotProperties(string id, string snapshotName, DateTimeOffset? createdOn, ProvisioningState? provisioningState, ReportProperties reportProperties, SystemData reportSystemData, IReadOnlyList<ComplianceResult> complianceResults, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            SnapshotName = snapshotName;
            CreatedOn = createdOn;
            ProvisioningState = provisioningState;
            ReportProperties = reportProperties;
            ReportSystemData = reportSystemData;
            ComplianceResults = complianceResults;
            _rawData = rawData;
        }

        /// <summary> Snapshot id in the database. </summary>
        public string Id { get; }
        /// <summary> Snapshot name. </summary>
        public string SnapshotName { get; }
        /// <summary> The timestamp of resource creation (UTC). </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Azure lifecycle management. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The report essential info. </summary>
        public ReportProperties ReportProperties { get; }
        /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
        public SystemData ReportSystemData { get; }
        /// <summary> List of compliance results. </summary>
        public IReadOnlyList<ComplianceResult> ComplianceResults { get; }
    }
}
