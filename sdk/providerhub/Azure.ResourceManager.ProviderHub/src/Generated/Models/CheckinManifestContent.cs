// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The CheckinManifestContent. </summary>
    public partial class CheckinManifestContent
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

        /// <summary> Initializes a new instance of <see cref="CheckinManifestContent"/>. </summary>
        /// <param name="environment"> The environment supplied to the checkin manifest operation. </param>
        /// <param name="baselineArmManifestLocation"> The baseline ARM manifest location supplied to the checkin manifest operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="environment"/> is null. </exception>
        public CheckinManifestContent(string environment, AzureLocation baselineArmManifestLocation)
        {
            Argument.AssertNotNull(environment, nameof(environment));

            Environment = environment;
            BaselineArmManifestLocation = baselineArmManifestLocation;
        }

        /// <summary> Initializes a new instance of <see cref="CheckinManifestContent"/>. </summary>
        /// <param name="environment"> The environment supplied to the checkin manifest operation. </param>
        /// <param name="baselineArmManifestLocation"> The baseline ARM manifest location supplied to the checkin manifest operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CheckinManifestContent(string environment, AzureLocation baselineArmManifestLocation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Environment = environment;
            BaselineArmManifestLocation = baselineArmManifestLocation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CheckinManifestContent"/> for deserialization. </summary>
        internal CheckinManifestContent()
        {
        }

        /// <summary> The environment supplied to the checkin manifest operation. </summary>
        public string Environment { get; }
        /// <summary> The baseline ARM manifest location supplied to the checkin manifest operation. </summary>
        public AzureLocation BaselineArmManifestLocation { get; }
    }
}
