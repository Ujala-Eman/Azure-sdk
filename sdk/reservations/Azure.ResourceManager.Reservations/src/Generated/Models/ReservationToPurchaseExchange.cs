// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Reservation purchase details. </summary>
    public partial class ReservationToPurchaseExchange
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ReservationToPurchaseExchange"/>. </summary>
        internal ReservationToPurchaseExchange()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReservationToPurchaseExchange"/>. </summary>
        /// <param name="reservationOrderId"> Fully qualified id of the reservationOrder being purchased. </param>
        /// <param name="reservationId"> Fully qualified id of the reservation being purchased. This value is only guaranteed to be non-null if the purchase is successful. </param>
        /// <param name="properties"> The request for reservation purchase. </param>
        /// <param name="billingCurrencyTotal"> Pricing information containing the amount and the currency code. </param>
        /// <param name="status"> Status of the individual operation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ReservationToPurchaseExchange(ResourceIdentifier reservationOrderId, ResourceIdentifier reservationId, ReservationPurchaseContent properties, PurchasePrice billingCurrencyTotal, ReservationOperationStatus? status, Dictionary<string, BinaryData> rawData)
        {
            ReservationOrderId = reservationOrderId;
            ReservationId = reservationId;
            Properties = properties;
            BillingCurrencyTotal = billingCurrencyTotal;
            Status = status;
            _rawData = rawData;
        }

        /// <summary> Fully qualified id of the reservationOrder being purchased. </summary>
        public ResourceIdentifier ReservationOrderId { get; }
        /// <summary> Fully qualified id of the reservation being purchased. This value is only guaranteed to be non-null if the purchase is successful. </summary>
        public ResourceIdentifier ReservationId { get; }
        /// <summary> The request for reservation purchase. </summary>
        public ReservationPurchaseContent Properties { get; }
        /// <summary> Pricing information containing the amount and the currency code. </summary>
        public PurchasePrice BillingCurrencyTotal { get; }
        /// <summary> Status of the individual operation. </summary>
        public ReservationOperationStatus? Status { get; }
    }
}
