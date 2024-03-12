// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ExtendedLocation represents the Azure custom location where the resource will be created. </summary>
    public partial class ExtendedLocation
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

        /// <summary> Initializes a new instance of <see cref="ExtendedLocation"/>. </summary>
        /// <param name="name"> The resource ID of the extended location on which the resource will be created. </param>
        /// <param name="extendedLocationType"> The extended location type, for example, CustomLocation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="extendedLocationType"/> is null. </exception>
        public ExtendedLocation(string name, string extendedLocationType)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(extendedLocationType, nameof(extendedLocationType));

            Name = name;
            ExtendedLocationType = extendedLocationType;
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedLocation"/>. </summary>
        /// <param name="name"> The resource ID of the extended location on which the resource will be created. </param>
        /// <param name="extendedLocationType"> The extended location type, for example, CustomLocation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExtendedLocation(string name, string extendedLocationType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ExtendedLocationType = extendedLocationType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedLocation"/> for deserialization. </summary>
        internal ExtendedLocation()
        {
        }

        /// <summary> The resource ID of the extended location on which the resource will be created. </summary>
        public string Name { get; set; }
        /// <summary> The extended location type, for example, CustomLocation. </summary>
        public string ExtendedLocationType { get; set; }
    }
}
