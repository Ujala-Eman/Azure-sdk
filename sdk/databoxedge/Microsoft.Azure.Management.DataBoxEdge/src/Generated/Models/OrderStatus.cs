// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a single status change.
    /// </summary>
    public partial class OrderStatus
    {
        /// <summary>
        /// Initializes a new instance of the OrderStatus class.
        /// </summary>
        public OrderStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrderStatus class.
        /// </summary>
        /// <param name="status">Status of the order as per the allowed status
        /// types. Possible values include: 'Untracked', 'AwaitingFulfillment',
        /// 'AwaitingPreparation', 'AwaitingShipment', 'Shipped', 'Arriving',
        /// 'Delivered', 'ReplacementRequested', 'LostDevice', 'Declined',
        /// 'ReturnInitiated', 'AwaitingReturnShipment', 'ShippedBack',
        /// 'CollectedAtMicrosoft', 'AwaitingPickup', 'PickupCompleted',
        /// 'AwaitingDrop'</param>
        /// <param name="updateDateTime">Time of status update.</param>
        /// <param name="comments">Comments related to this status
        /// change.</param>
        /// <param name="trackingInformation">Tracking information related to
        /// the state in the ordering flow</param>
        /// <param name="additionalOrderDetails">Dictionary to hold generic
        /// information which is not stored
        /// by the already existing properties</param>
        public OrderStatus(string status, System.DateTime? updateDateTime = default(System.DateTime?), string comments = default(string), TrackingInfo trackingInformation = default(TrackingInfo), IDictionary<string, string> additionalOrderDetails = default(IDictionary<string, string>))
        {
            Status = status;
            UpdateDateTime = updateDateTime;
            Comments = comments;
            TrackingInformation = trackingInformation;
            AdditionalOrderDetails = additionalOrderDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets status of the order as per the allowed status types.
        /// Possible values include: 'Untracked', 'AwaitingFulfillment',
        /// 'AwaitingPreparation', 'AwaitingShipment', 'Shipped', 'Arriving',
        /// 'Delivered', 'ReplacementRequested', 'LostDevice', 'Declined',
        /// 'ReturnInitiated', 'AwaitingReturnShipment', 'ShippedBack',
        /// 'CollectedAtMicrosoft', 'AwaitingPickup', 'PickupCompleted',
        /// 'AwaitingDrop'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets time of status update.
        /// </summary>
        [JsonProperty(PropertyName = "updateDateTime")]
        public System.DateTime? UpdateDateTime { get; private set; }

        /// <summary>
        /// Gets or sets comments related to this status change.
        /// </summary>
        [JsonProperty(PropertyName = "comments")]
        public string Comments { get; set; }

        /// <summary>
        /// Gets tracking information related to the state in the ordering flow
        /// </summary>
        [JsonProperty(PropertyName = "trackingInformation")]
        public TrackingInfo TrackingInformation { get; private set; }

        /// <summary>
        /// Gets dictionary to hold generic information which is not stored
        /// by the already existing properties
        /// </summary>
        [JsonProperty(PropertyName = "additionalOrderDetails")]
        public IDictionary<string, string> AdditionalOrderDetails { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
        }
    }
}
