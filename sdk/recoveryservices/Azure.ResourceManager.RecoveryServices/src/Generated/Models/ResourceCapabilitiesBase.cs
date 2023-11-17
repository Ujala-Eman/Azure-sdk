// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Base class for request and response capabilities information for Microsoft.RecoveryServices. </summary>
    public partial class ResourceCapabilitiesBase
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
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ResourceCapabilitiesBase"/>. </summary>
        /// <param name="resourceCapabilitiesBaseType"> Describes the Resource type: Microsoft.RecoveryServices/Vaults. </param>
        public ResourceCapabilitiesBase(ResourceType resourceCapabilitiesBaseType)
        {
            ResourceCapabilitiesBaseType = resourceCapabilitiesBaseType;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceCapabilitiesBase"/>. </summary>
        /// <param name="resourceCapabilitiesBaseType"> Describes the Resource type: Microsoft.RecoveryServices/Vaults. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceCapabilitiesBase(ResourceType resourceCapabilitiesBaseType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceCapabilitiesBaseType = resourceCapabilitiesBaseType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceCapabilitiesBase"/> for deserialization. </summary>
        internal ResourceCapabilitiesBase()
        {
        }

        /// <summary> Describes the Resource type: Microsoft.RecoveryServices/Vaults. </summary>
        public ResourceType ResourceCapabilitiesBaseType { get; set; }
    }
}
