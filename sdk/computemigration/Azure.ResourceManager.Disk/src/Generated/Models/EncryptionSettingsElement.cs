// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Disk.Models
{
    /// <summary> Encryption settings for one disk volume. </summary>
    public partial class EncryptionSettingsElement
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

        /// <summary> Initializes a new instance of <see cref="EncryptionSettingsElement"/>. </summary>
        public EncryptionSettingsElement()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EncryptionSettingsElement"/>. </summary>
        /// <param name="diskEncryptionKey"> Key Vault Secret Url and vault id of the disk encryption key. </param>
        /// <param name="keyEncryptionKey"> Key Vault Key Url and vault id of the key encryption key. KeyEncryptionKey is optional and when provided is used to unwrap the disk encryption key. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EncryptionSettingsElement(KeyVaultAndSecretReference diskEncryptionKey, KeyVaultAndKeyReference keyEncryptionKey, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiskEncryptionKey = diskEncryptionKey;
            KeyEncryptionKey = keyEncryptionKey;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Key Vault Secret Url and vault id of the disk encryption key. </summary>
        public KeyVaultAndSecretReference DiskEncryptionKey { get; set; }
        /// <summary> Key Vault Key Url and vault id of the key encryption key. KeyEncryptionKey is optional and when provided is used to unwrap the disk encryption key. </summary>
        public KeyVaultAndKeyReference KeyEncryptionKey { get; set; }
    }
}
