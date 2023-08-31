// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Reservation purchase details. </summary>
    public partial class ReservationToPurchaseCalculateExchange
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ReservationToPurchaseCalculateExchange"/>. </summary>
        internal ReservationToPurchaseCalculateExchange()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReservationToPurchaseCalculateExchange"/>. </summary>
        /// <param name="properties"> The request for reservation purchase. </param>
        /// <param name="billingCurrencyTotal"> Pricing information containing the amount and the currency code. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ReservationToPurchaseCalculateExchange(ReservationPurchaseContent properties, PurchasePrice billingCurrencyTotal, Dictionary<string, BinaryData> rawData)
        {
            Properties = properties;
            BillingCurrencyTotal = billingCurrencyTotal;
            _rawData = rawData;
        }

        /// <summary> The request for reservation purchase. </summary>
        public ReservationPurchaseContent Properties { get; }
        /// <summary> Pricing information containing the amount and the currency code. </summary>
        public PurchasePrice BillingCurrencyTotal { get; }
    }
}
