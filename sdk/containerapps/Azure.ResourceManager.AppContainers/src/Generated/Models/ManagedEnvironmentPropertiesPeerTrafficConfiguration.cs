// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Peer traffic settings for the Managed Environment. </summary>
    internal partial class ManagedEnvironmentPropertiesPeerTrafficConfiguration
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

        /// <summary> Initializes a new instance of <see cref="ManagedEnvironmentPropertiesPeerTrafficConfiguration"/>. </summary>
        public ManagedEnvironmentPropertiesPeerTrafficConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedEnvironmentPropertiesPeerTrafficConfiguration"/>. </summary>
        /// <param name="encryption"> Peer traffic encryption settings for the Managed Environment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedEnvironmentPropertiesPeerTrafficConfiguration(ManagedEnvironmentPropertiesPeerTrafficConfigurationEncryption encryption, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Encryption = encryption;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Peer traffic encryption settings for the Managed Environment. </summary>
        internal ManagedEnvironmentPropertiesPeerTrafficConfigurationEncryption Encryption { get; set; }
        /// <summary> Boolean indicating whether the peer traffic encryption is enabled. </summary>
        [WirePath("encryption.enabled")]
        public bool? IsPeerToPeerEncryptionEnabled
        {
            get => Encryption is null ? default : Encryption.IsPeerToPeerEncryptionEnabled;
            set
            {
                if (Encryption is null)
                    Encryption = new ManagedEnvironmentPropertiesPeerTrafficConfigurationEncryption();
                Encryption.IsPeerToPeerEncryptionEnabled = value;
            }
        }
    }
}
