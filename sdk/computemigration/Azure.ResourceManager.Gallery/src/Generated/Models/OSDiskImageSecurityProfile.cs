// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Gallery.Models
{
    /// <summary> Contains security profile for an OS disk image. </summary>
    public partial class OSDiskImageSecurityProfile
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

        /// <summary> Initializes a new instance of <see cref="OSDiskImageSecurityProfile"/>. </summary>
        public OSDiskImageSecurityProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OSDiskImageSecurityProfile"/>. </summary>
        /// <param name="confidentialVmEncryptionType"> confidential VM encryption types. </param>
        /// <param name="secureVmDiskEncryptionSetId"> secure VM disk encryption set id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OSDiskImageSecurityProfile(ConfidentialVmEncryptionType? confidentialVmEncryptionType, string secureVmDiskEncryptionSetId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConfidentialVmEncryptionType = confidentialVmEncryptionType;
            SecureVmDiskEncryptionSetId = secureVmDiskEncryptionSetId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> confidential VM encryption types. </summary>
        public ConfidentialVmEncryptionType? ConfidentialVmEncryptionType { get; set; }
        /// <summary> secure VM disk encryption set id. </summary>
        public string SecureVmDiskEncryptionSetId { get; set; }
    }
}
