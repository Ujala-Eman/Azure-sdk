// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Details about a service operation.
    /// </summary>
    public partial class OperationServiceSpecification
    {
        /// <summary>
        /// Initializes a new instance of the OperationServiceSpecification
        /// class.
        /// </summary>
        public OperationServiceSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationServiceSpecification
        /// class.
        /// </summary>
        /// <param name="logSpecifications">Details about operations related to
        /// logs.</param>
        /// <param name="metricSpecifications">Details about operations related
        /// to metrics.</param>
        public OperationServiceSpecification(IList<OperationLogSpecification> logSpecifications = default(IList<OperationLogSpecification>), IList<OperationMetricSpecification> metricSpecifications = default(IList<OperationMetricSpecification>))
        {
            LogSpecifications = logSpecifications;
            MetricSpecifications = metricSpecifications;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets details about operations related to logs.
        /// </summary>
        [JsonProperty(PropertyName = "logSpecifications")]
        public IList<OperationLogSpecification> LogSpecifications { get; set; }

        /// <summary>
        /// Gets or sets details about operations related to metrics.
        /// </summary>
        [JsonProperty(PropertyName = "metricSpecifications")]
        public IList<OperationMetricSpecification> MetricSpecifications { get; set; }

    }
}
