// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PolicyInsights.Models;

namespace Azure.ResourceManager.PolicyInsights
{
    /// <summary> A class representing the Attestation data model. </summary>
    public partial class AttestationData : ResourceData
    {
        /// <summary> Initializes a new instance of AttestationData. </summary>
        /// <param name="policyAssignmentId"> The resource ID of the policy assignment that the attestation is setting the state for. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyAssignmentId"/> is null. </exception>
        public AttestationData(ResourceIdentifier policyAssignmentId)
        {
            if (policyAssignmentId == null)
            {
                throw new ArgumentNullException(nameof(policyAssignmentId));
            }

            PolicyAssignmentId = policyAssignmentId;
            Evidence = new ChangeTrackingList<AttestationEvidence>();
        }

        /// <summary> Initializes a new instance of AttestationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="policyAssignmentId"> The resource ID of the policy assignment that the attestation is setting the state for. </param>
        /// <param name="policyDefinitionReferenceId"> The policy definition reference ID from a policy set definition that the attestation is setting the state for. If the policy assignment assigns a policy set definition the attestation can choose a definition within the set definition with this property or omit this and set the state for the entire set definition. </param>
        /// <param name="complianceState"> The compliance state that should be set on the resource. </param>
        /// <param name="expireOn"> The time the compliance state should expire. </param>
        /// <param name="owner"> The person responsible for setting the state of the resource. This value is typically an Azure Active Directory object ID. </param>
        /// <param name="comments"> Comments describing why this attestation was created. </param>
        /// <param name="evidence"> The evidence supporting the compliance state set in this attestation. </param>
        /// <param name="provisioningState"> The status of the attestation. </param>
        /// <param name="lastComplianceStateChangeOn"> The time the compliance state was last changed in this attestation. </param>
        internal AttestationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier policyAssignmentId, string policyDefinitionReferenceId, PolicyComplianceState? complianceState, DateTimeOffset? expireOn, string owner, string comments, IList<AttestationEvidence> evidence, string provisioningState, DateTimeOffset? lastComplianceStateChangeOn) : base(id, name, resourceType, systemData)
        {
            PolicyAssignmentId = policyAssignmentId;
            PolicyDefinitionReferenceId = policyDefinitionReferenceId;
            ComplianceState = complianceState;
            ExpireOn = expireOn;
            Owner = owner;
            Comments = comments;
            Evidence = evidence;
            ProvisioningState = provisioningState;
            LastComplianceStateChangeOn = lastComplianceStateChangeOn;
        }

        /// <summary> The resource ID of the policy assignment that the attestation is setting the state for. </summary>
        public ResourceIdentifier PolicyAssignmentId { get; set; }
        /// <summary> The policy definition reference ID from a policy set definition that the attestation is setting the state for. If the policy assignment assigns a policy set definition the attestation can choose a definition within the set definition with this property or omit this and set the state for the entire set definition. </summary>
        public string PolicyDefinitionReferenceId { get; set; }
        /// <summary> The compliance state that should be set on the resource. </summary>
        public PolicyComplianceState? ComplianceState { get; set; }
        /// <summary> The time the compliance state should expire. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> The person responsible for setting the state of the resource. This value is typically an Azure Active Directory object ID. </summary>
        public string Owner { get; set; }
        /// <summary> Comments describing why this attestation was created. </summary>
        public string Comments { get; set; }
        /// <summary> The evidence supporting the compliance state set in this attestation. </summary>
        public IList<AttestationEvidence> Evidence { get; }
        /// <summary> The status of the attestation. </summary>
        public string ProvisioningState { get; }
        /// <summary> The time the compliance state was last changed in this attestation. </summary>
        public DateTimeOffset? LastComplianceStateChangeOn { get; }
    }
}
