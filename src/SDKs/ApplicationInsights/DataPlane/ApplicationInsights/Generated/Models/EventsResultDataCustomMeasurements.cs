// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ApplicationInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Custom measurements of the event
    /// </summary>
    public partial class EventsResultDataCustomMeasurements
    {
        /// <summary>
        /// Initializes a new instance of the
        /// EventsResultDataCustomMeasurements class.
        /// </summary>
        public EventsResultDataCustomMeasurements()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// EventsResultDataCustomMeasurements class.
        /// </summary>
        public EventsResultDataCustomMeasurements(object additionalProperties = default(object))
        {
            AdditionalProperties = additionalProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "additionalProperties")]
        public object AdditionalProperties { get; set; }

    }
}
