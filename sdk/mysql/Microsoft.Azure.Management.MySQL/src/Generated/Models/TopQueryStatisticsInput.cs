// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MySQL.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Input to get top query statistics
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TopQueryStatisticsInput
    {
        /// <summary>
        /// Initializes a new instance of the TopQueryStatisticsInput class.
        /// </summary>
        public TopQueryStatisticsInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TopQueryStatisticsInput class.
        /// </summary>
        /// <param name="numberOfTopQueries">Max number of top queries to
        /// return.</param>
        /// <param name="aggregationFunction">Aggregation function
        /// name.</param>
        /// <param name="observedMetric">Observed metric name.</param>
        /// <param name="observationStartTime">Observation start time.</param>
        /// <param name="observationEndTime">Observation end time.</param>
        /// <param name="aggregationWindow">Aggregation interval type in ISO
        /// 8601 format.</param>
        public TopQueryStatisticsInput(int numberOfTopQueries, string aggregationFunction, string observedMetric, System.DateTime observationStartTime, System.DateTime observationEndTime, string aggregationWindow)
        {
            NumberOfTopQueries = numberOfTopQueries;
            AggregationFunction = aggregationFunction;
            ObservedMetric = observedMetric;
            ObservationStartTime = observationStartTime;
            ObservationEndTime = observationEndTime;
            AggregationWindow = aggregationWindow;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets max number of top queries to return.
        /// </summary>
        [JsonProperty(PropertyName = "properties.numberOfTopQueries")]
        public int NumberOfTopQueries { get; set; }

        /// <summary>
        /// Gets or sets aggregation function name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.aggregationFunction")]
        public string AggregationFunction { get; set; }

        /// <summary>
        /// Gets or sets observed metric name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.observedMetric")]
        public string ObservedMetric { get; set; }

        /// <summary>
        /// Gets or sets observation start time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.observationStartTime")]
        public System.DateTime ObservationStartTime { get; set; }

        /// <summary>
        /// Gets or sets observation end time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.observationEndTime")]
        public System.DateTime ObservationEndTime { get; set; }

        /// <summary>
        /// Gets or sets aggregation interval type in ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.aggregationWindow")]
        public string AggregationWindow { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AggregationFunction == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AggregationFunction");
            }
            if (ObservedMetric == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ObservedMetric");
            }
            if (AggregationWindow == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AggregationWindow");
            }
        }
    }
}
