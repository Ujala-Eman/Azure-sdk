// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AlertsManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Set of related alerts grouped together smartly by AMS.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SmartGroup : Resource
    {
        /// <summary>
        /// Initializes a new instance of the SmartGroup class.
        /// </summary>
        public SmartGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SmartGroup class.
        /// </summary>
        /// <param name="id">Azure resource Id</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="alertsCount">Total number of alerts in smart
        /// group</param>
        /// <param name="smartGroupState">Smart group state. Possible values
        /// include: 'New', 'Acknowledged', 'Closed'</param>
        /// <param name="severity">Severity of smart group is the highest(Sev0
        /// &gt;... &gt; Sev4) severity of all the alerts in the group.
        /// Possible values include: 'Sev0', 'Sev1', 'Sev2', 'Sev3',
        /// 'Sev4'</param>
        /// <param name="startDateTime">Creation time of smart group. Date-Time
        /// in ISO-8601 format.</param>
        /// <param name="lastModifiedDateTime">Last updated time of smart
        /// group. Date-Time in ISO-8601 format.</param>
        /// <param name="lastModifiedUserName">Last modified by user
        /// name.</param>
        /// <param name="resources">Summary of target resources in the smart
        /// group</param>
        /// <param name="resourceTypes">Summary of target resource types in the
        /// smart group</param>
        /// <param name="resourceGroups">Summary of target resource groups in
        /// the smart group</param>
        /// <param name="monitorServices">Summary of monitorServices in the
        /// smart group</param>
        /// <param name="monitorConditions">Summary of monitorConditions in the
        /// smart group</param>
        /// <param name="alertStates">Summary of alertStates in the smart
        /// group</param>
        /// <param name="alertSeverities">Summary of alertSeverities in the
        /// smart group</param>
        /// <param name="nextLink">The URI to fetch the next page of alerts.
        /// Call ListNext() with this URI to fetch the next page
        /// alerts.</param>
        public SmartGroup(string id = default(string), string type = default(string), string name = default(string), long? alertsCount = default(long?), string smartGroupState = default(string), string severity = default(string), System.DateTime? startDateTime = default(System.DateTime?), System.DateTime? lastModifiedDateTime = default(System.DateTime?), string lastModifiedUserName = default(string), IList<SmartGroupAggregatedProperty> resources = default(IList<SmartGroupAggregatedProperty>), IList<SmartGroupAggregatedProperty> resourceTypes = default(IList<SmartGroupAggregatedProperty>), IList<SmartGroupAggregatedProperty> resourceGroups = default(IList<SmartGroupAggregatedProperty>), IList<SmartGroupAggregatedProperty> monitorServices = default(IList<SmartGroupAggregatedProperty>), IList<SmartGroupAggregatedProperty> monitorConditions = default(IList<SmartGroupAggregatedProperty>), IList<SmartGroupAggregatedProperty> alertStates = default(IList<SmartGroupAggregatedProperty>), IList<SmartGroupAggregatedProperty> alertSeverities = default(IList<SmartGroupAggregatedProperty>), string nextLink = default(string))
            : base(id, type, name)
        {
            AlertsCount = alertsCount;
            SmartGroupState = smartGroupState;
            Severity = severity;
            StartDateTime = startDateTime;
            LastModifiedDateTime = lastModifiedDateTime;
            LastModifiedUserName = lastModifiedUserName;
            Resources = resources;
            ResourceTypes = resourceTypes;
            ResourceGroups = resourceGroups;
            MonitorServices = monitorServices;
            MonitorConditions = monitorConditions;
            AlertStates = alertStates;
            AlertSeverities = alertSeverities;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets total number of alerts in smart group
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertsCount")]
        public long? AlertsCount { get; set; }

        /// <summary>
        /// Gets smart group state. Possible values include: 'New',
        /// 'Acknowledged', 'Closed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.smartGroupState")]
        public string SmartGroupState { get; private set; }

        /// <summary>
        /// Gets severity of smart group is the highest(Sev0 &amp;gt;...
        /// &amp;gt; Sev4) severity of all the alerts in the group. Possible
        /// values include: 'Sev0', 'Sev1', 'Sev2', 'Sev3', 'Sev4'
        /// </summary>
        [JsonProperty(PropertyName = "properties.severity")]
        public string Severity { get; private set; }

        /// <summary>
        /// Gets creation time of smart group. Date-Time in ISO-8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startDateTime")]
        public System.DateTime? StartDateTime { get; private set; }

        /// <summary>
        /// Gets last updated time of smart group. Date-Time in ISO-8601
        /// format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedDateTime")]
        public System.DateTime? LastModifiedDateTime { get; private set; }

        /// <summary>
        /// Gets last modified by user name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedUserName")]
        public string LastModifiedUserName { get; private set; }

        /// <summary>
        /// Gets or sets summary of target resources in the smart group
        /// </summary>
        [JsonProperty(PropertyName = "properties.resources")]
        public IList<SmartGroupAggregatedProperty> Resources { get; set; }

        /// <summary>
        /// Gets or sets summary of target resource types in the smart group
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceTypes")]
        public IList<SmartGroupAggregatedProperty> ResourceTypes { get; set; }

        /// <summary>
        /// Gets or sets summary of target resource groups in the smart group
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGroups")]
        public IList<SmartGroupAggregatedProperty> ResourceGroups { get; set; }

        /// <summary>
        /// Gets or sets summary of monitorServices in the smart group
        /// </summary>
        [JsonProperty(PropertyName = "properties.monitorServices")]
        public IList<SmartGroupAggregatedProperty> MonitorServices { get; set; }

        /// <summary>
        /// Gets or sets summary of monitorConditions in the smart group
        /// </summary>
        [JsonProperty(PropertyName = "properties.monitorConditions")]
        public IList<SmartGroupAggregatedProperty> MonitorConditions { get; set; }

        /// <summary>
        /// Gets or sets summary of alertStates in the smart group
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertStates")]
        public IList<SmartGroupAggregatedProperty> AlertStates { get; set; }

        /// <summary>
        /// Gets or sets summary of alertSeverities in the smart group
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertSeverities")]
        public IList<SmartGroupAggregatedProperty> AlertSeverities { get; set; }

        /// <summary>
        /// Gets or sets the URI to fetch the next page of alerts. Call
        /// ListNext() with this URI to fetch the next page alerts.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nextLink")]
        public string NextLink { get; set; }

    }
}
