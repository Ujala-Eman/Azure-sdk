// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Properties to configure Encryption. </summary>
    public partial class EventHubsEncryption
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

        /// <summary> Initializes a new instance of <see cref="EventHubsEncryption"/>. </summary>
        public EventHubsEncryption()
        {
            KeyVaultProperties = new ChangeTrackingList<EventHubsKeyVaultProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsEncryption"/>. </summary>
        /// <param name="keyVaultProperties"> Properties of KeyVault. </param>
        /// <param name="keySource"> Enumerates the possible value of keySource for Encryption. </param>
        /// <param name="requireInfrastructureEncryption"> Enable Infrastructure Encryption (Double Encryption). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EventHubsEncryption(IList<EventHubsKeyVaultProperties> keyVaultProperties, EventHubsKeySource? keySource, bool? requireInfrastructureEncryption, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyVaultProperties = keyVaultProperties;
            KeySource = keySource;
            RequireInfrastructureEncryption = requireInfrastructureEncryption;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Properties of KeyVault. </summary>
        public IList<EventHubsKeyVaultProperties> KeyVaultProperties { get; }
        /// <summary> Enumerates the possible value of keySource for Encryption. </summary>
        public EventHubsKeySource? KeySource { get; set; }
        /// <summary> Enable Infrastructure Encryption (Double Encryption). </summary>
        public bool? RequireInfrastructureEncryption { get; set; }
    }
}
