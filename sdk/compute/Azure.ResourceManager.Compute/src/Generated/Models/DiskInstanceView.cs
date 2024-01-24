// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The instance view of the disk. </summary>
    public partial class DiskInstanceView
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

        /// <summary> Initializes a new instance of <see cref="DiskInstanceView"/>. </summary>
        internal DiskInstanceView()
        {
            EncryptionSettings = new ChangeTrackingList<DiskEncryptionSettings>();
            Statuses = new ChangeTrackingList<InstanceViewStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="DiskInstanceView"/>. </summary>
        /// <param name="name"> The disk name. </param>
        /// <param name="encryptionSettings"> Specifies the encryption settings for the OS Disk. &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </param>
        /// <param name="statuses"> The resource status information. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiskInstanceView(string name, IReadOnlyList<DiskEncryptionSettings> encryptionSettings, IReadOnlyList<InstanceViewStatus> statuses, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            EncryptionSettings = encryptionSettings;
            Statuses = statuses;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The disk name. </summary>
        public string Name { get; }
        /// <summary> Specifies the encryption settings for the OS Disk. &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </summary>
        public IReadOnlyList<DiskEncryptionSettings> EncryptionSettings { get; }
        /// <summary> The resource status information. </summary>
        public IReadOnlyList<InstanceViewStatus> Statuses { get; }
    }
}
