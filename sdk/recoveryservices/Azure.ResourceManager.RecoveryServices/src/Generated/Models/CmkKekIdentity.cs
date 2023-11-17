// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> The details of the identity used for CMK. </summary>
    public partial class CmkKekIdentity
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

        /// <summary> Initializes a new instance of <see cref="CmkKekIdentity"/>. </summary>
        public CmkKekIdentity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CmkKekIdentity"/>. </summary>
        /// <param name="useSystemAssignedIdentity"> Indicate that system assigned identity should be used. Mutually exclusive with 'userAssignedIdentity' field. </param>
        /// <param name="userAssignedIdentity"> The user assigned identity to be used to grant permissions in case the type of identity used is UserAssigned. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CmkKekIdentity(bool? useSystemAssignedIdentity, ResourceIdentifier userAssignedIdentity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UseSystemAssignedIdentity = useSystemAssignedIdentity;
            UserAssignedIdentity = userAssignedIdentity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicate that system assigned identity should be used. Mutually exclusive with 'userAssignedIdentity' field. </summary>
        public bool? UseSystemAssignedIdentity { get; set; }
        /// <summary> The user assigned identity to be used to grant permissions in case the type of identity used is UserAssigned. </summary>
        public ResourceIdentifier UserAssignedIdentity { get; set; }
    }
}
