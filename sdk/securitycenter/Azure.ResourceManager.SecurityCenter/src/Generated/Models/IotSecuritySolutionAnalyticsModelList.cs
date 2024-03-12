// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> List of Security analytics of your IoT Security solution. </summary>
    internal partial class IotSecuritySolutionAnalyticsModelList
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

        /// <summary> Initializes a new instance of <see cref="IotSecuritySolutionAnalyticsModelList"/>. </summary>
        /// <param name="value"> List of Security analytics of your IoT Security solution. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal IotSecuritySolutionAnalyticsModelList(IEnumerable<IotSecuritySolutionAnalyticsModelData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="IotSecuritySolutionAnalyticsModelList"/>. </summary>
        /// <param name="value"> List of Security analytics of your IoT Security solution. </param>
        /// <param name="nextLink"> When there is too much alert data for one page, use this URI to fetch the next page. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotSecuritySolutionAnalyticsModelList(IReadOnlyList<IotSecuritySolutionAnalyticsModelData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IotSecuritySolutionAnalyticsModelList"/> for deserialization. </summary>
        internal IotSecuritySolutionAnalyticsModelList()
        {
        }

        /// <summary> List of Security analytics of your IoT Security solution. </summary>
        public IReadOnlyList<IotSecuritySolutionAnalyticsModelData> Value { get; }
        /// <summary> When there is too much alert data for one page, use this URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
