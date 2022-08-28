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
    /// <summary> A class representing the RoleEligibilityScheduleRequest data model. </summary>
    public partial class RoleEligibilityScheduleRequestData : ResourceData
    {
        /// <summary> Initializes a new instance of RoleEligibilityScheduleRequestData. </summary>
        public RoleEligibilityScheduleRequestData()
        {
        }

        /// <summary> Initializes a new instance of RoleEligibilityScheduleRequestData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="scope"> The role eligibility schedule request scope. </param>
        /// <param name="roleDefinitionId"> The role definition ID. </param>
        /// <param name="principalId"> The principal ID. </param>
        /// <param name="principalType"> The principal type of the assigned principal ID. </param>
        /// <param name="requestType"> The type of the role assignment schedule request. Eg: SelfActivate, AdminAssign etc. </param>
        /// <param name="status"> The status of the role eligibility schedule request. </param>
        /// <param name="approvalId"> The approvalId of the role eligibility schedule request. </param>
        /// <param name="targetRoleEligibilityScheduleId"> The resultant role eligibility schedule id or the role eligibility schedule id being updated. </param>
        /// <param name="targetRoleEligibilityScheduleInstanceId"> The role eligibility schedule instance id being updated. </param>
        /// <param name="justification"> Justification for the role eligibility. </param>
        /// <param name="ticketInfo"> Ticket Info of the role eligibility. </param>
        /// <param name="condition"> The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase &apos;foo_storage_container&apos;. </param>
        /// <param name="conditionVersion"> Version of the condition. Currently accepted value is &apos;2.0&apos;. </param>
        /// <param name="createdOn"> DateTime when role eligibility schedule request was created. </param>
        /// <param name="requestorId"> Id of the user who created this request. </param>
        /// <param name="expandedProperties"> Additional properties of principal, scope and role definition. </param>
        /// <param name="startOn"> Start DateTime of the role eligibility schedule. </param>
        /// <param name="expirationType"> Type of the role eligibility schedule expiration. </param>
        /// <param name="endOn"> End DateTime of the role eligibility schedule. </param>
        /// <param name="duration"> Duration of the role eligibility schedule in TimeSpan. </param>
        internal RoleEligibilityScheduleRequestData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string scope, ResourceIdentifier roleDefinitionId, Guid? principalId, RoleManagementPrincipalType? principalType, RoleManagementScheduleRequestType? requestType, RoleManagementScheduleStatus? status, string approvalId, string targetRoleEligibilityScheduleId, string targetRoleEligibilityScheduleInstanceId, string justification, RoleEligibilityScheduleRequestPropertiesTicketInfo ticketInfo, string condition, string conditionVersion, DateTimeOffset? createdOn, Guid? requestorId, RoleManagementExpandedProperties expandedProperties, DateTimeOffset? startOn, RoleManagementScheduleExpirationType? expirationType, DateTimeOffset? endOn, TimeSpan? duration) : base(id, name, resourceType, systemData)
        {
            Scope = scope;
            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
            PrincipalType = principalType;
            RequestType = requestType;
            Status = status;
            ApprovalId = approvalId;
            TargetRoleEligibilityScheduleId = targetRoleEligibilityScheduleId;
            TargetRoleEligibilityScheduleInstanceId = targetRoleEligibilityScheduleInstanceId;
            Justification = justification;
            TicketInfo = ticketInfo;
            Condition = condition;
            ConditionVersion = conditionVersion;
            CreatedOn = createdOn;
            RequestorId = requestorId;
            ExpandedProperties = expandedProperties;
            StartOn = startOn;
            ExpirationType = expirationType;
            EndOn = endOn;
            Duration = duration;
        }

        /// <summary> The role eligibility schedule request scope. </summary>
        public string Scope { get; }
        /// <summary> The role definition ID. </summary>
        public ResourceIdentifier RoleDefinitionId { get; set; }
        /// <summary> The principal ID. </summary>
        public Guid? PrincipalId { get; set; }
        /// <summary> The principal type of the assigned principal ID. </summary>
        public RoleManagementPrincipalType? PrincipalType { get; }
        /// <summary> The type of the role assignment schedule request. Eg: SelfActivate, AdminAssign etc. </summary>
        public RoleManagementScheduleRequestType? RequestType { get; set; }
        /// <summary> The status of the role eligibility schedule request. </summary>
        public RoleManagementScheduleStatus? Status { get; }
        /// <summary> The approvalId of the role eligibility schedule request. </summary>
        public string ApprovalId { get; }
        /// <summary> The resultant role eligibility schedule id or the role eligibility schedule id being updated. </summary>
        public string TargetRoleEligibilityScheduleId { get; set; }
        /// <summary> The role eligibility schedule instance id being updated. </summary>
        public string TargetRoleEligibilityScheduleInstanceId { get; set; }
        /// <summary> Justification for the role eligibility. </summary>
        public string Justification { get; set; }
        /// <summary> Ticket Info of the role eligibility. </summary>
        public RoleEligibilityScheduleRequestPropertiesTicketInfo TicketInfo { get; set; }
        /// <summary> The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase &apos;foo_storage_container&apos;. </summary>
        public string Condition { get; set; }
        /// <summary> Version of the condition. Currently accepted value is &apos;2.0&apos;. </summary>
        public string ConditionVersion { get; set; }
        /// <summary> DateTime when role eligibility schedule request was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Id of the user who created this request. </summary>
        public Guid? RequestorId { get; }
        /// <summary> Additional properties of principal, scope and role definition. </summary>
        public RoleManagementExpandedProperties ExpandedProperties { get; }
        /// <summary> Start DateTime of the role eligibility schedule. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> Type of the role eligibility schedule expiration. </summary>
        public RoleManagementScheduleExpirationType? ExpirationType { get; set; }
        /// <summary> End DateTime of the role eligibility schedule. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> Duration of the role eligibility schedule in TimeSpan. </summary>
        public TimeSpan? Duration { get; set; }
    }
}
