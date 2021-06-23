// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The instance view of a Capacity Reservation that includes the name of
    /// the Capacity Reservation. It is used for the response to the instance
    /// view of a Capacity Reservation group.
    /// </summary>
    public partial class CapacityReservationInstanceViewWithName : CapacityReservationInstanceView
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CapacityReservationInstanceViewWithName class.
        /// </summary>
        public CapacityReservationInstanceViewWithName()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CapacityReservationInstanceViewWithName class.
        /// </summary>
        /// <param name="utilizationInfo">Unutilized capacity of the capacity
        /// reservation.</param>
        /// <param name="statuses">The resource status information.</param>
        /// <param name="name">The name of the Capacity Reservation.</param>
        public CapacityReservationInstanceViewWithName(CapacityReservationUtilization utilizationInfo = default(CapacityReservationUtilization), IList<InstanceViewStatus> statuses = default(IList<InstanceViewStatus>), string name = default(string))
            : base(utilizationInfo, statuses)
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the Capacity Reservation.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

    }
}
