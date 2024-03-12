// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The ETA (estimated time of arrival) for remediation. </summary>
    public partial class RemediationEta
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

        /// <summary> Initializes a new instance of <see cref="RemediationEta"/>. </summary>
        /// <param name="eta"> ETA for remediation. </param>
        /// <param name="justification"> Justification for change of Eta. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="justification"/> is null. </exception>
        public RemediationEta(DateTimeOffset eta, string justification)
        {
            Argument.AssertNotNull(justification, nameof(justification));

            Eta = eta;
            Justification = justification;
        }

        /// <summary> Initializes a new instance of <see cref="RemediationEta"/>. </summary>
        /// <param name="eta"> ETA for remediation. </param>
        /// <param name="justification"> Justification for change of Eta. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RemediationEta(DateTimeOffset eta, string justification, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Eta = eta;
            Justification = justification;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RemediationEta"/> for deserialization. </summary>
        internal RemediationEta()
        {
        }

        /// <summary> ETA for remediation. </summary>
        public DateTimeOffset Eta { get; set; }
        /// <summary> Justification for change of Eta. </summary>
        public string Justification { get; set; }
    }
}
