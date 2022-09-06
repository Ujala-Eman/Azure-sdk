// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Specifies the metric alert criteria for a single resource that has multiple metric criteria. </summary>
    public partial class MetricAlertSingleResourceMultipleMetricCriteria : MetricAlertCriteria
    {
        /// <summary> Initializes a new instance of MetricAlertSingleResourceMultipleMetricCriteria. </summary>
        public MetricAlertSingleResourceMultipleMetricCriteria()
        {
            AllOf = new ChangeTrackingList<MetricCriteria>();
            OdataType = MonitorOdataType.MicrosoftAzureMonitorSingleResourceMultipleMetricCriteria;
        }

        /// <summary> Initializes a new instance of MetricAlertSingleResourceMultipleMetricCriteria. </summary>
        /// <param name="odataType"> specifies the type of the alert criteria. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="allOf"> The list of metric criteria for this &apos;all of&apos; operation. </param>
        internal MetricAlertSingleResourceMultipleMetricCriteria(MonitorOdataType odataType, IDictionary<string, BinaryData> additionalProperties, IList<MetricCriteria> allOf) : base(odataType, additionalProperties)
        {
            AllOf = allOf;
            OdataType = odataType;
        }

        /// <summary> The list of metric criteria for this &apos;all of&apos; operation. </summary>
        public IList<MetricCriteria> AllOf { get; }
    }
}
