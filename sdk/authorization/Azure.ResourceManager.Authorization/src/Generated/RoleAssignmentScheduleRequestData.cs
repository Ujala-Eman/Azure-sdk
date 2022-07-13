// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    /// <summary> A class representing the RoleAssignmentScheduleRequest data model. </summary>
    public partial class RoleAssignmentScheduleRequestData : ResourceData
    {
        /// <summary> Initializes a new instance of RoleAssignmentScheduleRequestData. </summary>
        public RoleAssignmentScheduleRequestData()
        {
        }

        /// <summary> Initializes a new instance of RoleAssignmentScheduleRequestData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="scope"> The role assignment schedule request scope. </param>
        /// <param name="roleDefinitionId"> The role definition ID. </param>
        /// <param name="principalId"> The principal ID. </param>
        /// <param name="principalType"> The principal type of the assigned principal ID. </param>
        /// <param name="requestType"> The type of the role assignment schedule request. Eg: SelfActivate, AdminAssign etc. </param>
        /// <param name="status"> The status of the role assignment schedule request. </param>
        /// <param name="approvalId"> The approvalId of the role assignment schedule request. </param>
        /// <param name="targetRoleAssignmentScheduleId"> The resultant role assignment schedule id or the role assignment schedule id being updated. </param>
        /// <param name="targetRoleAssignmentScheduleInstanceId"> The role assignment schedule instance id being updated. </param>
        /// <param name="scheduleInfo"> Schedule info of the role assignment schedule. </param>
        /// <param name="linkedRoleEligibilityScheduleId"> The linked role eligibility schedule id - to activate an eligibility. </param>
        /// <param name="justification"> Justification for the role assignment. </param>
        /// <param name="ticketInfo"> Ticket Info of the role assignment. </param>
        /// <param name="condition"> The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase &apos;foo_storage_container&apos;. </param>
        /// <param name="conditionVersion"> Version of the condition. Currently accepted value is &apos;2.0&apos;. </param>
        /// <param name="createdOn"> DateTime when role assignment schedule request was created. </param>
        /// <param name="requestorId"> Id of the user who created this request. </param>
        /// <param name="expandedProperties"> Additional properties of principal, scope and role definition. </param>
        internal RoleAssignmentScheduleRequestData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string scope, ResourceIdentifier roleDefinitionId, string principalId, PrincipalType? principalType, RequestType? requestType, RoleAssignmentScheduleRequestStatus? status, string approvalId, string targetRoleAssignmentScheduleId, string targetRoleAssignmentScheduleInstanceId, RoleAssignmentScheduleInfo scheduleInfo, string linkedRoleEligibilityScheduleId, string justification, RoleAssignmentScheduleTicketInfo ticketInfo, string condition, string conditionVersion, DateTimeOffset? createdOn, string requestorId, ExpandedProperties expandedProperties) : base(id, name, resourceType, systemData)
        {
            Scope = scope;
            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
            PrincipalType = principalType;
            RequestType = requestType;
            Status = status;
            ApprovalId = approvalId;
            TargetRoleAssignmentScheduleId = targetRoleAssignmentScheduleId;
            TargetRoleAssignmentScheduleInstanceId = targetRoleAssignmentScheduleInstanceId;
            ScheduleInfo = scheduleInfo;
            LinkedRoleEligibilityScheduleId = linkedRoleEligibilityScheduleId;
            Justification = justification;
            TicketInfo = ticketInfo;
            Condition = condition;
            ConditionVersion = conditionVersion;
            CreatedOn = createdOn;
            RequestorId = requestorId;
            ExpandedProperties = expandedProperties;
        }

        /// <summary> The role assignment schedule request scope. </summary>
        public string Scope { get; }
        /// <summary> The role definition ID. </summary>
        public ResourceIdentifier RoleDefinitionId { get; set; }
        /// <summary> The principal ID. </summary>
        public string PrincipalId { get; set; }
        /// <summary> The principal type of the assigned principal ID. </summary>
        public PrincipalType? PrincipalType { get; }
        /// <summary> The type of the role assignment schedule request. Eg: SelfActivate, AdminAssign etc. </summary>
        public RequestType? RequestType { get; set; }
        /// <summary> The status of the role assignment schedule request. </summary>
        public RoleAssignmentScheduleRequestStatus? Status { get; }
        /// <summary> The approvalId of the role assignment schedule request. </summary>
        public string ApprovalId { get; }
        /// <summary> The resultant role assignment schedule id or the role assignment schedule id being updated. </summary>
        public string TargetRoleAssignmentScheduleId { get; set; }
        /// <summary> The role assignment schedule instance id being updated. </summary>
        public string TargetRoleAssignmentScheduleInstanceId { get; set; }
        /// <summary> Schedule info of the role assignment schedule. </summary>
        public RoleAssignmentScheduleInfo ScheduleInfo { get; set; }
        /// <summary> The linked role eligibility schedule id - to activate an eligibility. </summary>
        public string LinkedRoleEligibilityScheduleId { get; set; }
        /// <summary> Justification for the role assignment. </summary>
        public string Justification { get; set; }
        /// <summary> Ticket Info of the role assignment. </summary>
        public RoleAssignmentScheduleTicketInfo TicketInfo { get; set; }
        /// <summary> The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase &apos;foo_storage_container&apos;. </summary>
        public string Condition { get; set; }
        /// <summary> Version of the condition. Currently accepted value is &apos;2.0&apos;. </summary>
        public string ConditionVersion { get; set; }
        /// <summary> DateTime when role assignment schedule request was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Id of the user who created this request. </summary>
        public string RequestorId { get; }
        /// <summary> Additional properties of principal, scope and role definition. </summary>
        public ExpandedProperties ExpandedProperties { get; }
    }
}
