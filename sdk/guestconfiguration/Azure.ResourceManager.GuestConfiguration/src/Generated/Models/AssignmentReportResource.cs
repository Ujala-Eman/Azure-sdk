// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> The guest configuration assignment resource. </summary>
    public partial class AssignmentReportResource
    {
        /// <summary> Initializes a new instance of AssignmentReportResource. </summary>
        public AssignmentReportResource()
        {
            Reasons = new ChangeTrackingList<AssignmentReportResourceComplianceReason>();
        }

        /// <summary> Initializes a new instance of AssignmentReportResource. </summary>
        /// <param name="complianceStatus"> A value indicating compliance status of the machine for the assigned guest configuration. </param>
        /// <param name="resourceId"> Name of the guest configuration assignment resource setting. </param>
        /// <param name="reasons"> Compliance reason and reason code for a resource. </param>
        /// <param name="properties"> Properties of a guest configuration assignment resource. </param>
        internal AssignmentReportResource(ComplianceStatus? complianceStatus, string resourceId, IList<AssignmentReportResourceComplianceReason> reasons, BinaryData properties)
        {
            ComplianceStatus = complianceStatus;
            ResourceId = resourceId;
            Reasons = reasons;
            Properties = properties;
        }

        /// <summary> A value indicating compliance status of the machine for the assigned guest configuration. </summary>
        public ComplianceStatus? ComplianceStatus { get; }
        /// <summary> Name of the guest configuration assignment resource setting. </summary>
        public string ResourceId { get; }
        /// <summary> Compliance reason and reason code for a resource. </summary>
        public IList<AssignmentReportResourceComplianceReason> Reasons { get; }
        /// <summary>
        /// Properties of a guest configuration assignment resource..
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Properties { get; }
    }
}
