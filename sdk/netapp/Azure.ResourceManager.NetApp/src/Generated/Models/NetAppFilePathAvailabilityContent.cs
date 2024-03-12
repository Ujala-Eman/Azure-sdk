// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> File path availability request content - availability is based on the name and the subnetId. </summary>
    public partial class NetAppFilePathAvailabilityContent
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

        /// <summary> Initializes a new instance of <see cref="NetAppFilePathAvailabilityContent"/>. </summary>
        /// <param name="name"> File path to verify. </param>
        /// <param name="subnetId"> The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="subnetId"/> is null. </exception>
        public NetAppFilePathAvailabilityContent(string name, ResourceIdentifier subnetId)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(subnetId, nameof(subnetId));

            Name = name;
            SubnetId = subnetId;
        }

        /// <summary> Initializes a new instance of <see cref="NetAppFilePathAvailabilityContent"/>. </summary>
        /// <param name="name"> File path to verify. </param>
        /// <param name="subnetId"> The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppFilePathAvailabilityContent(string name, ResourceIdentifier subnetId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            SubnetId = subnetId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetAppFilePathAvailabilityContent"/> for deserialization. </summary>
        internal NetAppFilePathAvailabilityContent()
        {
        }

        /// <summary> File path to verify. </summary>
        public string Name { get; }
        /// <summary> The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes. </summary>
        public ResourceIdentifier SubnetId { get; }
    }
}
