// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> A paginated list of EnvironmentContainer entities. </summary>
    internal partial class EnvironmentContainerResourceArmPaginatedResult
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

        /// <summary> Initializes a new instance of <see cref="EnvironmentContainerResourceArmPaginatedResult"/>. </summary>
        internal EnvironmentContainerResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<MachineLearningEnvironmentContainerData>();
        }

        /// <summary> Initializes a new instance of <see cref="EnvironmentContainerResourceArmPaginatedResult"/>. </summary>
        /// <param name="nextLink"> The link to the next page of EnvironmentContainer objects. If null, there are no additional pages. </param>
        /// <param name="value"> An array of objects of type EnvironmentContainer. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EnvironmentContainerResourceArmPaginatedResult(string nextLink, IReadOnlyList<MachineLearningEnvironmentContainerData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The link to the next page of EnvironmentContainer objects. If null, there are no additional pages. </summary>
        public string NextLink { get; }
        /// <summary> An array of objects of type EnvironmentContainer. </summary>
        public IReadOnlyList<MachineLearningEnvironmentContainerData> Value { get; }
    }
}
