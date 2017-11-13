// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Reservations;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class AppliedReservationList
    {
        /// <summary>
        /// Initializes a new instance of the AppliedReservationList class.
        /// </summary>
        public AppliedReservationList()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppliedReservationList class.
        /// </summary>
        /// <param name="nextLink">Url to get the next page of
        /// reservations</param>
        public AppliedReservationList(IList<string> value = default(IList<string>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<string> Value { get; set; }

        /// <summary>
        /// Gets or sets url to get the next page of reservations
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
