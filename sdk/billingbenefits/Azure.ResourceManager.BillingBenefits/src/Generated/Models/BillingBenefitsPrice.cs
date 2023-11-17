// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> The BillingBenefitsPrice. </summary>
    public partial class BillingBenefitsPrice
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BillingBenefitsPrice"/>. </summary>
        public BillingBenefitsPrice()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BillingBenefitsPrice"/>. </summary>
        /// <param name="currencyCode"> The ISO 4217 3-letter currency code for the currency used by this purchase record. </param>
        /// <param name="amount"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingBenefitsPrice(string currencyCode, double? amount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CurrencyCode = currencyCode;
            Amount = amount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ISO 4217 3-letter currency code for the currency used by this purchase record. </summary>
        public string CurrencyCode { get; set; }
        /// <summary> Gets or sets the amount. </summary>
        public double? Amount { get; set; }
    }
}
