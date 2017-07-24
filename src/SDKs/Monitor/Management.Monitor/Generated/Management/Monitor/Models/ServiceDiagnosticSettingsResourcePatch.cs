// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Monitor.Management.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Monitor;
    using Microsoft.Azure.Management.Monitor.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Service diagnostic setting resource for patch operations
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ServiceDiagnosticSettingsResourcePatch
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ServiceDiagnosticSettingsResourcePatch class.
        /// </summary>
        public ServiceDiagnosticSettingsResourcePatch() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ServiceDiagnosticSettingsResourcePatch class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        /// <param name="storageAccountId">The resource ID of the storage
        /// account to which you would like to send Diagnostic Logs.</param>
        /// <param name="serviceBusRuleId">The service bus rule ID of the
        /// service bus namespace in which you would like to have Event Hubs
        /// created for streaming Diagnostic Logs. The rule ID is of the
        /// format: '{service bus resource ID}/authorizationrules/{key
        /// name}'.</param>
        /// <param name="eventHubAuthorizationRuleId">The resource Id for the
        /// event hub authorization rule.</param>
        /// <param name="metrics">the list of metric settings.</param>
        /// <param name="logs">the list of logs settings.</param>
        /// <param name="workspaceId">The workspace ID (resource ID of a Log
        /// Analytics workspace) for a Log Analytics workspace to which you
        /// would like to send Diagnostic Logs. Example:
        /// /subscriptions/4b9e8510-67ab-4e9a-95a9-e2f1e570ea9c/resourceGroups/insights-integration/providers/Microsoft.OperationalInsights/workspaces/viruela2</param>
        public ServiceDiagnosticSettingsResourcePatch(IDictionary<string, string> tags = default(IDictionary<string, string>), string storageAccountId = default(string), string serviceBusRuleId = default(string), string eventHubAuthorizationRuleId = default(string), IList<MetricSettings> metrics = default(IList<MetricSettings>), IList<LogSettings> logs = default(IList<LogSettings>), string workspaceId = default(string))
        {
            Tags = tags;
            StorageAccountId = storageAccountId;
            ServiceBusRuleId = serviceBusRuleId;
            EventHubAuthorizationRuleId = eventHubAuthorizationRuleId;
            Metrics = metrics;
            Logs = logs;
            WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the resource ID of the storage account to which you
        /// would like to send Diagnostic Logs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountId")]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the service bus rule ID of the service bus namespace
        /// in which you would like to have Event Hubs created for streaming
        /// Diagnostic Logs. The rule ID is of the format: '{service bus
        /// resource ID}/authorizationrules/{key name}'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceBusRuleId")]
        public string ServiceBusRuleId { get; set; }

        /// <summary>
        /// Gets or sets the resource Id for the event hub authorization rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.eventHubAuthorizationRuleId")]
        public string EventHubAuthorizationRuleId { get; set; }

        /// <summary>
        /// Gets or sets the list of metric settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metrics")]
        public IList<MetricSettings> Metrics { get; set; }

        /// <summary>
        /// Gets or sets the list of logs settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.logs")]
        public IList<LogSettings> Logs { get; set; }

        /// <summary>
        /// Gets or sets the workspace ID (resource ID of a Log Analytics
        /// workspace) for a Log Analytics workspace to which you would like to
        /// send Diagnostic Logs. Example:
        /// /subscriptions/4b9e8510-67ab-4e9a-95a9-e2f1e570ea9c/resourceGroups/insights-integration/providers/Microsoft.OperationalInsights/workspaces/viruela2
        /// </summary>
        [JsonProperty(PropertyName = "properties.workspaceId")]
        public string WorkspaceId { get; set; }

    }
}
