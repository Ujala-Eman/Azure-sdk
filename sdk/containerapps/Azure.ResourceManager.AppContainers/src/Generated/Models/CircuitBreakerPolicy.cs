// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Policy that defines circuit breaker conditions. </summary>
    public partial class CircuitBreakerPolicy
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

        /// <summary> Initializes a new instance of <see cref="CircuitBreakerPolicy"/>. </summary>
        public CircuitBreakerPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CircuitBreakerPolicy"/>. </summary>
        /// <param name="consecutiveErrors"> Number of consecutive errors before the circuit breaker opens. </param>
        /// <param name="intervalInSeconds"> The time interval, in seconds, between endpoint checks. This can result in opening the circuit breaker if the check fails as well as closing the circuit breaker if the check succeeds. Defaults to 10s. </param>
        /// <param name="maxEjectionPercent"> Maximum percentage of hosts that will be ejected after failure threshold has been met. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CircuitBreakerPolicy(int? consecutiveErrors, int? intervalInSeconds, int? maxEjectionPercent, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConsecutiveErrors = consecutiveErrors;
            IntervalInSeconds = intervalInSeconds;
            MaxEjectionPercent = maxEjectionPercent;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Number of consecutive errors before the circuit breaker opens. </summary>
        [WirePath("consecutiveErrors")]
        public int? ConsecutiveErrors { get; set; }
        /// <summary> The time interval, in seconds, between endpoint checks. This can result in opening the circuit breaker if the check fails as well as closing the circuit breaker if the check succeeds. Defaults to 10s. </summary>
        [WirePath("intervalInSeconds")]
        public int? IntervalInSeconds { get; set; }
        /// <summary> Maximum percentage of hosts that will be ejected after failure threshold has been met. </summary>
        [WirePath("maxEjectionPercent")]
        public int? MaxEjectionPercent { get; set; }
    }
}
