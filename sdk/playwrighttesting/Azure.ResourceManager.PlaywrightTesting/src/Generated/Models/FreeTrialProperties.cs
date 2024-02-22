// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PlaywrightTesting.Models
{
    /// <summary> The free-trial properties. </summary>
    public partial class FreeTrialProperties
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FreeTrialProperties"/>. </summary>
        /// <param name="accountId"> The playwright account id. </param>
        /// <param name="createdOn"> The free-trial createdAt utcDateTime. </param>
        /// <param name="expiryOn"> The free-trial expiryAt utcDateTime. </param>
        /// <param name="allocatedValue"> The free-trial allocated limit value eg. allocated free minutes. </param>
        /// <param name="usedValue"> The free-trial used value eg. used free minutes. </param>
        /// <param name="percentageUsed"> The free-trial percentage used. </param>
        /// <param name="state"> The free-trial state. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountId"/> is null. </exception>
        public FreeTrialProperties(string accountId, DateTimeOffset createdOn, DateTimeOffset expiryOn, int allocatedValue, int usedValue, decimal percentageUsed, FreeTrialState state)
        {
            if (accountId == null)
            {
                throw new ArgumentNullException(nameof(accountId));
            }

            AccountId = accountId;
            CreatedOn = createdOn;
            ExpiryOn = expiryOn;
            AllocatedValue = allocatedValue;
            UsedValue = usedValue;
            PercentageUsed = percentageUsed;
            State = state;
        }

        /// <summary> Initializes a new instance of <see cref="FreeTrialProperties"/>. </summary>
        /// <param name="accountId"> The playwright account id. </param>
        /// <param name="createdOn"> The free-trial createdAt utcDateTime. </param>
        /// <param name="expiryOn"> The free-trial expiryAt utcDateTime. </param>
        /// <param name="allocatedValue"> The free-trial allocated limit value eg. allocated free minutes. </param>
        /// <param name="usedValue"> The free-trial used value eg. used free minutes. </param>
        /// <param name="percentageUsed"> The free-trial percentage used. </param>
        /// <param name="state"> The free-trial state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FreeTrialProperties(string accountId, DateTimeOffset createdOn, DateTimeOffset expiryOn, int allocatedValue, int usedValue, decimal percentageUsed, FreeTrialState state, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AccountId = accountId;
            CreatedOn = createdOn;
            ExpiryOn = expiryOn;
            AllocatedValue = allocatedValue;
            UsedValue = usedValue;
            PercentageUsed = percentageUsed;
            State = state;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FreeTrialProperties"/> for deserialization. </summary>
        internal FreeTrialProperties()
        {
        }

        /// <summary> The playwright account id. </summary>
        public string AccountId { get; }
        /// <summary> The free-trial createdAt utcDateTime. </summary>
        public DateTimeOffset CreatedOn { get; }
        /// <summary> The free-trial expiryAt utcDateTime. </summary>
        public DateTimeOffset ExpiryOn { get; }
        /// <summary> The free-trial allocated limit value eg. allocated free minutes. </summary>
        public int AllocatedValue { get; }
        /// <summary> The free-trial used value eg. used free minutes. </summary>
        public int UsedValue { get; }
        /// <summary> The free-trial percentage used. </summary>
        public decimal PercentageUsed { get; }
        /// <summary> The free-trial state. </summary>
        public FreeTrialState State { get; }
    }
}
