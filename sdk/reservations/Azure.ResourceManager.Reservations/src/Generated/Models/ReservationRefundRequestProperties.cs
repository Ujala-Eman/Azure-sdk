// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Properties needed for refund request including the session id from calculate refund, the scope, the reservation to be returned and the return reason. </summary>
    public partial class ReservationRefundRequestProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ReservationRefundRequestProperties"/>. </summary>
        public ReservationRefundRequestProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReservationRefundRequestProperties"/>. </summary>
        /// <param name="sessionId"> SessionId that was returned by CalculateRefund API. </param>
        /// <param name="scope"> The scope of the refund, e.g. Reservation. </param>
        /// <param name="reservationToReturn"> Reservation to return. </param>
        /// <param name="returnReason"> The reason of returning the reservation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ReservationRefundRequestProperties(Guid? sessionId, string scope, ReservationToReturn reservationToReturn, string returnReason, Dictionary<string, BinaryData> rawData)
        {
            SessionId = sessionId;
            Scope = scope;
            ReservationToReturn = reservationToReturn;
            ReturnReason = returnReason;
            _rawData = rawData;
        }

        /// <summary> SessionId that was returned by CalculateRefund API. </summary>
        public Guid? SessionId { get; set; }
        /// <summary> The scope of the refund, e.g. Reservation. </summary>
        public string Scope { get; set; }
        /// <summary> Reservation to return. </summary>
        public ReservationToReturn ReservationToReturn { get; set; }
        /// <summary> The reason of returning the reservation. </summary>
        public string ReturnReason { get; set; }
    }
}
