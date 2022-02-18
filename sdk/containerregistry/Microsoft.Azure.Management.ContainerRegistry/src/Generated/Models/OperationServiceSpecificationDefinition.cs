// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The definition of Azure Monitoring list.
    /// </summary>
    public partial class OperationServiceSpecificationDefinition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OperationServiceSpecificationDefinition class.
        /// </summary>
        public OperationServiceSpecificationDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OperationServiceSpecificationDefinition class.
        /// </summary>
        /// <param name="metricSpecifications">A list of Azure Monitoring
        /// metrics definition.</param>
        /// <param name="logSpecifications">A list of Azure Monitoring log
        /// definitions.</param>
        public OperationServiceSpecificationDefinition(IList<OperationMetricSpecificationDefinition> metricSpecifications = default(IList<OperationMetricSpecificationDefinition>), IList<OperationLogSpecificationDefinition> logSpecifications = default(IList<OperationLogSpecificationDefinition>))
        {
            MetricSpecifications = metricSpecifications;
            LogSpecifications = logSpecifications;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of Azure Monitoring metrics definition.
        /// </summary>
        [JsonProperty(PropertyName = "metricSpecifications")]
        public IList<OperationMetricSpecificationDefinition> MetricSpecifications { get; set; }

        /// <summary>
        /// Gets or sets a list of Azure Monitoring log definitions.
        /// </summary>
        [JsonProperty(PropertyName = "logSpecifications")]
        public IList<OperationLogSpecificationDefinition> LogSpecifications { get; set; }

    }
}
