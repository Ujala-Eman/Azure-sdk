// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RestorableTimeRange
    {
        /// <summary>
        /// Initializes a new instance of the RestorableTimeRange class.
        /// </summary>
        public RestorableTimeRange()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RestorableTimeRange class.
        /// </summary>
        /// <param name="startTime">Start time for the available restore
        /// range</param>
        /// <param name="endTime">End time for the available restore
        /// range</param>
        public RestorableTimeRange(string startTime, string endTime, string objectType = default(string))
        {
            StartTime = startTime;
            EndTime = endTime;
            ObjectType = objectType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets start time for the available restore range
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets end time for the available restore range
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectType")]
        public string ObjectType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StartTime == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StartTime");
            }
            if (EndTime == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EndTime");
            }
        }
    }
}
