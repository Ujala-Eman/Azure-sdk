// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> Details of the guest configuration assignment report. </summary>
    public partial class GuestConfigurationAssignmentReportDetails
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GuestConfigurationAssignmentReportDetails"/>. </summary>
        internal GuestConfigurationAssignmentReportDetails()
        {
            Resources = new ChangeTrackingList<AssignmentReportResourceInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="GuestConfigurationAssignmentReportDetails"/>. </summary>
        /// <param name="complianceStatus"> A value indicating compliance status of the machine for the assigned guest configuration. </param>
        /// <param name="startOn"> Start date and time of the guest configuration assignment compliance status check. </param>
        /// <param name="endOn"> End date and time of the guest configuration assignment compliance status check. </param>
        /// <param name="jobId"> GUID of the report. </param>
        /// <param name="operationType"> Type of report, Consistency or Initial. </param>
        /// <param name="resources"> The list of resources for which guest configuration assignment compliance is checked. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GuestConfigurationAssignmentReportDetails(AssignedGuestConfigurationMachineComplianceStatus? complianceStatus, DateTimeOffset? startOn, DateTimeOffset? endOn, Guid? jobId, GuestConfigurationAssignmentReportType? operationType, IReadOnlyList<AssignmentReportResourceInfo> resources, Dictionary<string, BinaryData> rawData)
        {
            ComplianceStatus = complianceStatus;
            StartOn = startOn;
            EndOn = endOn;
            JobId = jobId;
            OperationType = operationType;
            Resources = resources;
            _rawData = rawData;
        }

        /// <summary> A value indicating compliance status of the machine for the assigned guest configuration. </summary>
        public AssignedGuestConfigurationMachineComplianceStatus? ComplianceStatus { get; }
        /// <summary> Start date and time of the guest configuration assignment compliance status check. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> End date and time of the guest configuration assignment compliance status check. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> GUID of the report. </summary>
        public Guid? JobId { get; }
        /// <summary> Type of report, Consistency or Initial. </summary>
        public GuestConfigurationAssignmentReportType? OperationType { get; }
        /// <summary> The list of resources for which guest configuration assignment compliance is checked. </summary>
        public IReadOnlyList<AssignmentReportResourceInfo> Resources { get; }
    }
}
