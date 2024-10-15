// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> List of all the workspace manager assignments. </summary>
    internal partial class WorkspaceManagerAssignmentList
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

        /// <summary> Initializes a new instance of <see cref="WorkspaceManagerAssignmentList"/>. </summary>
        /// <param name="value"> Array of workspace manager assignments. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal WorkspaceManagerAssignmentList(IEnumerable<WorkspaceManagerAssignmentData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceManagerAssignmentList"/>. </summary>
        /// <param name="nextLink"> URL to fetch the next set of workspace manager assignments. </param>
        /// <param name="value"> Array of workspace manager assignments. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkspaceManagerAssignmentList(string nextLink, IReadOnlyList<WorkspaceManagerAssignmentData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceManagerAssignmentList"/> for deserialization. </summary>
        internal WorkspaceManagerAssignmentList()
        {
        }

        /// <summary> URL to fetch the next set of workspace manager assignments. </summary>
        public string NextLink { get; }
        /// <summary> Array of workspace manager assignments. </summary>
        public IReadOnlyList<WorkspaceManagerAssignmentData> Value { get; }
    }
}
