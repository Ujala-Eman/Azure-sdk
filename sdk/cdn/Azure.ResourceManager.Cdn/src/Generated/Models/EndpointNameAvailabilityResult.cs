// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Output of check name availability API. </summary>
    public partial class EndpointNameAvailabilityResult
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

        /// <summary> Initializes a new instance of <see cref="EndpointNameAvailabilityResult"/>. </summary>
        internal EndpointNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EndpointNameAvailabilityResult"/>. </summary>
        /// <param name="nameAvailable"> Indicates whether the name is available. </param>
        /// <param name="availableHostname"> Returns the available hostname generated based on the AutoGeneratedDomainNameLabelScope when the name is available, otherwise it returns empty string. </param>
        /// <param name="reason"> The reason why the name is not available. </param>
        /// <param name="message"> The detailed error message describing why the name is not available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EndpointNameAvailabilityResult(bool? nameAvailable, string availableHostname, string reason, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NameAvailable = nameAvailable;
            AvailableHostname = availableHostname;
            Reason = reason;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates whether the name is available. </summary>
        public bool? NameAvailable { get; }
        /// <summary> Returns the available hostname generated based on the AutoGeneratedDomainNameLabelScope when the name is available, otherwise it returns empty string. </summary>
        public string AvailableHostname { get; }
        /// <summary> The reason why the name is not available. </summary>
        public string Reason { get; }
        /// <summary> The detailed error message describing why the name is not available. </summary>
        public string Message { get; }
    }
}
