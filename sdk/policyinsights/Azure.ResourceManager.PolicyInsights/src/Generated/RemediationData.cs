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
    /// <summary> A class representing the Remediation data model. </summary>
    public partial class RemediationData : ResourceData
    {
        /// <summary> Initializes a new instance of RemediationData. </summary>
        public RemediationData()
        {
        }

        /// <summary> Initializes a new instance of RemediationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="policyAssignmentId">
        /// The resource ID of the policy assignment that should be remediated.
        /// Serialized Name: Remediation.properties.policyAssignmentId
        /// </param>
        /// <param name="policyDefinitionReferenceId">
        /// The policy definition reference ID of the individual definition that should be remediated. Required when the policy assignment being remediated assigns a policy set definition.
        /// Serialized Name: Remediation.properties.policyDefinitionReferenceId
        /// </param>
        /// <param name="resourceDiscoveryMode">
        /// The way resources to remediate are discovered. Defaults to ExistingNonCompliant if not specified.
        /// Serialized Name: Remediation.properties.resourceDiscoveryMode
        /// </param>
        /// <param name="provisioningState">
        /// The status of the remediation.
        /// Serialized Name: Remediation.properties.provisioningState
        /// </param>
        /// <param name="createdOn">
        /// The time at which the remediation was created.
        /// Serialized Name: Remediation.properties.createdOn
        /// </param>
        /// <param name="lastUpdatedOn">
        /// The time at which the remediation was last updated.
        /// Serialized Name: Remediation.properties.lastUpdatedOn
        /// </param>
        /// <param name="filters">
        /// The filters that will be applied to determine which resources to remediate.
        /// Serialized Name: Remediation.properties.filters
        /// </param>
        /// <param name="deploymentStatus">
        /// The deployment status summary for all deployments created by the remediation.
        /// Serialized Name: Remediation.properties.deploymentStatus
        /// </param>
        /// <param name="statusMessage">
        /// The remediation status message. Provides additional details regarding the state of the remediation.
        /// Serialized Name: Remediation.properties.statusMessage
        /// </param>
        /// <param name="correlationId">
        /// The remediation correlation Id. Can be used to find events related to the remediation in the activity log.
        /// Serialized Name: Remediation.properties.correlationId
        /// </param>
        /// <param name="resourceCount">
        /// Determines the max number of resources that can be remediated by the remediation job. If not provided, the default resource count is used.
        /// Serialized Name: Remediation.properties.resourceCount
        /// </param>
        /// <param name="parallelDeployments">
        /// Determines how many resources to remediate at any given time. Can be used to increase or reduce the pace of the remediation. If not provided, the default parallel deployments value is used.
        /// Serialized Name: Remediation.properties.parallelDeployments
        /// </param>
        /// <param name="failureThreshold">
        /// The remediation failure threshold settings
        /// Serialized Name: Remediation.properties.failureThreshold
        /// </param>
        internal RemediationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string policyAssignmentId, string policyDefinitionReferenceId, ResourceDiscoveryMode? resourceDiscoveryMode, string provisioningState, DateTimeOffset? createdOn, DateTimeOffset? lastUpdatedOn, RemediationFilters filters, RemediationDeploymentSummary deploymentStatus, string statusMessage, string correlationId, int? resourceCount, int? parallelDeployments, RemediationPropertiesFailureThreshold failureThreshold) : base(id, name, resourceType, systemData)
        {
            PolicyAssignmentId = policyAssignmentId;
            PolicyDefinitionReferenceId = policyDefinitionReferenceId;
            ResourceDiscoveryMode = resourceDiscoveryMode;
            ProvisioningState = provisioningState;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            Filters = filters;
            DeploymentStatus = deploymentStatus;
            StatusMessage = statusMessage;
            CorrelationId = correlationId;
            ResourceCount = resourceCount;
            ParallelDeployments = parallelDeployments;
            FailureThreshold = failureThreshold;
        }

        /// <summary>
        /// The resource ID of the policy assignment that should be remediated.
        /// Serialized Name: Remediation.properties.policyAssignmentId
        /// </summary>
        public string PolicyAssignmentId { get; set; }
        /// <summary>
        /// The policy definition reference ID of the individual definition that should be remediated. Required when the policy assignment being remediated assigns a policy set definition.
        /// Serialized Name: Remediation.properties.policyDefinitionReferenceId
        /// </summary>
        public string PolicyDefinitionReferenceId { get; set; }
        /// <summary>
        /// The way resources to remediate are discovered. Defaults to ExistingNonCompliant if not specified.
        /// Serialized Name: Remediation.properties.resourceDiscoveryMode
        /// </summary>
        public ResourceDiscoveryMode? ResourceDiscoveryMode { get; set; }
        /// <summary>
        /// The status of the remediation.
        /// Serialized Name: Remediation.properties.provisioningState
        /// </summary>
        public string ProvisioningState { get; }
        /// <summary>
        /// The time at which the remediation was created.
        /// Serialized Name: Remediation.properties.createdOn
        /// </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary>
        /// The time at which the remediation was last updated.
        /// Serialized Name: Remediation.properties.lastUpdatedOn
        /// </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary>
        /// The filters that will be applied to determine which resources to remediate.
        /// Serialized Name: Remediation.properties.filters
        /// </summary>
        internal RemediationFilters Filters { get; set; }
        /// <summary>
        /// The resource locations that will be remediated.
        /// Serialized Name: RemediationFilters.locations
        /// </summary>
        public IList<string> FiltersLocations
        {
            get
            {
                if (Filters is null)
                    Filters = new RemediationFilters();
                return Filters.Locations;
            }
        }

        /// <summary>
        /// The deployment status summary for all deployments created by the remediation.
        /// Serialized Name: Remediation.properties.deploymentStatus
        /// </summary>
        public RemediationDeploymentSummary DeploymentStatus { get; }
        /// <summary>
        /// The remediation status message. Provides additional details regarding the state of the remediation.
        /// Serialized Name: Remediation.properties.statusMessage
        /// </summary>
        public string StatusMessage { get; }
        /// <summary>
        /// The remediation correlation Id. Can be used to find events related to the remediation in the activity log.
        /// Serialized Name: Remediation.properties.correlationId
        /// </summary>
        public string CorrelationId { get; }
        /// <summary>
        /// Determines the max number of resources that can be remediated by the remediation job. If not provided, the default resource count is used.
        /// Serialized Name: Remediation.properties.resourceCount
        /// </summary>
        public int? ResourceCount { get; set; }
        /// <summary>
        /// Determines how many resources to remediate at any given time. Can be used to increase or reduce the pace of the remediation. If not provided, the default parallel deployments value is used.
        /// Serialized Name: Remediation.properties.parallelDeployments
        /// </summary>
        public int? ParallelDeployments { get; set; }
        /// <summary>
        /// The remediation failure threshold settings
        /// Serialized Name: Remediation.properties.failureThreshold
        /// </summary>
        internal RemediationPropertiesFailureThreshold FailureThreshold { get; set; }
        /// <summary>
        /// A number between 0.0 to 1.0 representing the percentage failure threshold. The remediation will fail if the percentage of failed remediation operations (i.e. failed deployments) exceeds this threshold.
        /// Serialized Name: RemediationPropertiesFailureThreshold.percentage
        /// </summary>
        public float? FailureThresholdPercentage
        {
            get => FailureThreshold is null ? default : FailureThreshold.Percentage;
            set
            {
                if (FailureThreshold is null)
                    FailureThreshold = new RemediationPropertiesFailureThreshold();
                FailureThreshold.Percentage = value;
            }
        }
    }
}
