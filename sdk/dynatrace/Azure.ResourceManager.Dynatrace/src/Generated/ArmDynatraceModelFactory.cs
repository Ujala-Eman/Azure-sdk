// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Dynatrace;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmDynatraceModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.DynatraceAccountCredentialsInfo"/>. </summary>
        /// <param name="accountId"> Account Id of the account this environment is linked to. </param>
        /// <param name="apiKey"> API Key of the user account. </param>
        /// <param name="regionId"> Region in which the account is created. </param>
        /// <returns> A new <see cref="Models.DynatraceAccountCredentialsInfo"/> instance for mocking. </returns>
        public static DynatraceAccountCredentialsInfo DynatraceAccountCredentialsInfo(string accountId = null, string apiKey = null, string regionId = null)
        {
            return new DynatraceAccountCredentialsInfo(accountId, apiKey, regionId);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DynatraceMonitoredResourceDetails"/>. </summary>
        /// <param name="id"> The ARM id of the resource. </param>
        /// <param name="sendingMetricsStatus"> Flag indicating if resource is sending metrics to Dynatrace. </param>
        /// <param name="reasonForMetricsStatus"> Reason for why the resource is sending metrics (or why it is not sending). </param>
        /// <param name="sendingLogsStatus"> Flag indicating if resource is sending logs to Dynatrace. </param>
        /// <param name="reasonForLogsStatus"> Reason for why the resource is sending logs (or why it is not sending). </param>
        /// <returns> A new <see cref="Models.DynatraceMonitoredResourceDetails"/> instance for mocking. </returns>
        public static DynatraceMonitoredResourceDetails DynatraceMonitoredResourceDetails(ResourceIdentifier id = null, MetricsSendingStatus? sendingMetricsStatus = null, string reasonForMetricsStatus = null, LogsSendingStatus? sendingLogsStatus = null, string reasonForLogsStatus = null)
        {
            return new DynatraceMonitoredResourceDetails(id, sendingMetricsStatus, reasonForMetricsStatus, sendingLogsStatus, reasonForLogsStatus);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DynatraceVmExtensionPayload"/>. </summary>
        /// <param name="ingestionKey"> Ingestion key of the environment. </param>
        /// <param name="environmentId"> Id of the environment created. </param>
        /// <returns> A new <see cref="Models.DynatraceVmExtensionPayload"/> instance for mocking. </returns>
        public static DynatraceVmExtensionPayload DynatraceVmExtensionPayload(string ingestionKey = null, string environmentId = null)
        {
            return new DynatraceVmExtensionPayload(ingestionKey, environmentId);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DynatraceSingleSignOnProperties"/>. </summary>
        /// <param name="singleSignOnState"> State of Single Sign On. </param>
        /// <param name="enterpriseAppId"> Version of the Dynatrace agent installed on the VM. </param>
        /// <param name="singleSignOnUri"> The login URL specific to this Dynatrace Environment. </param>
        /// <param name="aadDomains"> array of Aad(azure active directory) domains. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <returns> A new <see cref="Models.DynatraceSingleSignOnProperties"/> instance for mocking. </returns>
        public static DynatraceSingleSignOnProperties DynatraceSingleSignOnProperties(DynatraceSingleSignOnState? singleSignOnState = null, Guid? enterpriseAppId = null, Uri singleSignOnUri = null, IEnumerable<string> aadDomains = null, DynatraceProvisioningState? provisioningState = null)
        {
            aadDomains ??= new List<string>();

            return new DynatraceSingleSignOnProperties(singleSignOnState, enterpriseAppId, singleSignOnUri, aadDomains?.ToList(), provisioningState);
        }

        /// <summary> Initializes a new instance of <see cref="Dynatrace.DynatraceTagRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="logRules"> Set of rules for sending logs for the Monitor resource. </param>
        /// <param name="metricRulesFilteringTags"> Set of rules for sending metrics for the Monitor resource. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <returns> A new <see cref="Dynatrace.DynatraceTagRuleData"/> instance for mocking. </returns>
        public static DynatraceTagRuleData DynatraceTagRuleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DynatraceMonitorResourceLogRules logRules = null, IEnumerable<DynatraceMonitorResourceFilteringTag> metricRulesFilteringTags = null, DynatraceProvisioningState? provisioningState = null)
        {
            metricRulesFilteringTags ??= new List<DynatraceMonitorResourceFilteringTag>();

            return new DynatraceTagRuleData(id, name, resourceType, systemData, logRules, metricRulesFilteringTags != null ? new DynatraceMonitorResourceMetricRules(metricRulesFilteringTags?.ToList()) : null, provisioningState);
        }

        /// <summary> Initializes a new instance of <see cref="Dynatrace.DynatraceSingleSignOnData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="singleSignOnState"> State of Single Sign On. </param>
        /// <param name="enterpriseAppId"> Version of the Dynatrace agent installed on the VM. </param>
        /// <param name="singleSignOnUri"> The login URL specific to this Dynatrace Environment. </param>
        /// <param name="aadDomains"> array of Aad(azure active directory) domains. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <returns> A new <see cref="Dynatrace.DynatraceSingleSignOnData"/> instance for mocking. </returns>
        public static DynatraceSingleSignOnData DynatraceSingleSignOnData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DynatraceSingleSignOnState? singleSignOnState = null, Guid? enterpriseAppId = null, Uri singleSignOnUri = null, IEnumerable<string> aadDomains = null, DynatraceProvisioningState? provisioningState = null)
        {
            aadDomains ??= new List<string>();

            return new DynatraceSingleSignOnData(id, name, resourceType, systemData, singleSignOnState, enterpriseAppId, singleSignOnUri, aadDomains?.ToList(), provisioningState);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DynatraceMonitorVmInfo"/>. </summary>
        /// <param name="resourceId"> Azure VM resource ID. </param>
        /// <param name="version"> Version of the Dynatrace agent installed on the VM. </param>
        /// <param name="monitoringType"> The monitoring mode of OneAgent. </param>
        /// <param name="autoUpdateSetting"> Update settings of OneAgent. </param>
        /// <param name="updateStatus"> The current update status of OneAgent. </param>
        /// <param name="availabilityState"> The availability state of OneAgent. </param>
        /// <param name="logModule"> Tells whether log modules are enabled or not. </param>
        /// <param name="hostGroup"> The name of the host group. </param>
        /// <param name="hostName"> The name of the host. </param>
        /// <returns> A new <see cref="Models.DynatraceMonitorVmInfo"/> instance for mocking. </returns>
        public static DynatraceMonitorVmInfo DynatraceMonitorVmInfo(ResourceIdentifier resourceId = null, string version = null, DynatraceOneAgentMonitoringType? monitoringType = null, DynatraceOneAgentAutoUpdateSetting? autoUpdateSetting = null, DynatraceOneAgentUpdateStatus? updateStatus = null, DynatraceOneAgentAvailabilityState? availabilityState = null, DynatraceLogModuleState? logModule = null, string hostGroup = null, string hostName = null)
        {
            return new DynatraceMonitorVmInfo(resourceId, version, monitoringType, autoUpdateSetting, updateStatus, availabilityState, logModule, hostGroup, hostName);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DynatraceOneAgentEnabledAppServiceInfo"/>. </summary>
        /// <param name="resourceId"> App service resource ID. </param>
        /// <param name="version"> Version of the Dynatrace agent installed on the App Service. </param>
        /// <param name="monitoringType"> The monitoring mode of OneAgent. </param>
        /// <param name="autoUpdateSetting"> Update settings of OneAgent. </param>
        /// <param name="updateStatus"> The current update status of OneAgent. </param>
        /// <param name="availabilityState"> The availability state of OneAgent. </param>
        /// <param name="logModule"> Tells whether log modules are enabled or not. </param>
        /// <param name="hostGroup"> The name of the host group. </param>
        /// <param name="hostName"> The name of the host. </param>
        /// <returns> A new <see cref="Models.DynatraceOneAgentEnabledAppServiceInfo"/> instance for mocking. </returns>
        public static DynatraceOneAgentEnabledAppServiceInfo DynatraceOneAgentEnabledAppServiceInfo(ResourceIdentifier resourceId = null, string version = null, DynatraceOneAgentMonitoringType? monitoringType = null, DynatraceOneAgentAutoUpdateSetting? autoUpdateSetting = null, DynatraceOneAgentUpdateStatus? updateStatus = null, DynatraceOneAgentAvailabilityState? availabilityState = null, DynatraceLogModuleState? logModule = null, string hostGroup = null, string hostName = null)
        {
            return new DynatraceOneAgentEnabledAppServiceInfo(resourceId, version, monitoringType, autoUpdateSetting, updateStatus, availabilityState, logModule, hostGroup, hostName);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DynatraceSsoDetailsResult"/>. </summary>
        /// <param name="isSsoEnabled"> Whether the SSO is enabled for this resource or not. </param>
        /// <param name="metadataUri"> URL for Azure AD metadata. </param>
        /// <param name="singleSignOnUri"> The login URL specific to this Dynatrace Environment. </param>
        /// <param name="aadDomains"> array of Aad(azure active directory) domains. </param>
        /// <param name="adminUsers"> Array of admin user emails. </param>
        /// <returns> A new <see cref="Models.DynatraceSsoDetailsResult"/> instance for mocking. </returns>
        public static DynatraceSsoDetailsResult DynatraceSsoDetailsResult(DynatraceSsoStatus? isSsoEnabled = null, Uri metadataUri = null, Uri singleSignOnUri = null, IEnumerable<string> aadDomains = null, IEnumerable<string> adminUsers = null)
        {
            aadDomains ??= new List<string>();
            adminUsers ??= new List<string>();

            return new DynatraceSsoDetailsResult(isSsoEnabled, metadataUri, singleSignOnUri, aadDomains?.ToList(), adminUsers?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Models.LinkableEnvironmentResult"/>. </summary>
        /// <param name="environmentId"> environment id for which user is an admin. </param>
        /// <param name="environmentName"> Name of the environment. </param>
        /// <param name="planData"> Billing plan information. </param>
        /// <returns> A new <see cref="Models.LinkableEnvironmentResult"/> instance for mocking. </returns>
        public static LinkableEnvironmentResult LinkableEnvironmentResult(string environmentId = null, string environmentName = null, DynatraceBillingPlanInfo planData = null)
        {
            return new LinkableEnvironmentResult(environmentId, environmentName, planData);
        }
    }
}
