// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> A rule metric data source. The discriminator value is always RuleMetricDataSource in this case. </summary>
    public partial class RuleMetricDataSource : RuleDataSource
    {
        /// <summary> Initializes a new instance of RuleMetricDataSource. </summary>
        public RuleMetricDataSource()
        {
            OdataType = "Microsoft.Azure.Management.Insights.Models.RuleMetricDataSource";
        }

        /// <summary> Initializes a new instance of RuleMetricDataSource. </summary>
        /// <param name="odataType"> specifies the type of data source. There are two types of rule data sources: RuleMetricDataSource and RuleManagementEventDataSource. </param>
        /// <param name="resourceId"> the resource identifier of the resource the rule monitors. **NOTE**: this property cannot be updated for an existing rule. </param>
        /// <param name="legacyResourceId"> the legacy resource identifier of the resource the rule monitors. **NOTE**: this property cannot be updated for an existing rule. </param>
        /// <param name="resourceLocation"> the location of the resource. </param>
        /// <param name="metricNamespace"> the namespace of the metric. </param>
        /// <param name="metricName"> the name of the metric that defines what the rule monitors. </param>
        internal RuleMetricDataSource(string odataType, ResourceIdentifier resourceId, ResourceIdentifier legacyResourceId, string resourceLocation, string metricNamespace, string metricName) : base(odataType, resourceId, legacyResourceId, resourceLocation, metricNamespace)
        {
            MetricName = metricName;
            OdataType = odataType ?? "Microsoft.Azure.Management.Insights.Models.RuleMetricDataSource";
        }

        /// <summary> the name of the metric that defines what the rule monitors. </summary>
        public string MetricName { get; set; }
    }
}
