// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm NIC input. </summary>
    public partial class InMageRcmNicContent
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

        /// <summary> Initializes a new instance of <see cref="InMageRcmNicContent"/>. </summary>
        /// <param name="nicId"> The NIC Id. </param>
        /// <param name="isPrimaryNic"> A value indicating whether this is the primary NIC. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nicId"/> or <paramref name="isPrimaryNic"/> is null. </exception>
        public InMageRcmNicContent(string nicId, string isPrimaryNic)
        {
            Argument.AssertNotNull(nicId, nameof(nicId));
            Argument.AssertNotNull(isPrimaryNic, nameof(isPrimaryNic));

            NicId = nicId;
            IsPrimaryNic = isPrimaryNic;
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmNicContent"/>. </summary>
        /// <param name="nicId"> The NIC Id. </param>
        /// <param name="isPrimaryNic"> A value indicating whether this is the primary NIC. </param>
        /// <param name="isSelectedForFailover"> A value indicating whether this NIC is selected for failover. </param>
        /// <param name="targetSubnetName"> Target subnet name. </param>
        /// <param name="targetStaticIPAddress"> The target static IP address. </param>
        /// <param name="testSubnetName"> The test subnet name. </param>
        /// <param name="testStaticIPAddress"> The test static IP address. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageRcmNicContent(string nicId, string isPrimaryNic, string isSelectedForFailover, string targetSubnetName, IPAddress targetStaticIPAddress, string testSubnetName, IPAddress testStaticIPAddress, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NicId = nicId;
            IsPrimaryNic = isPrimaryNic;
            IsSelectedForFailover = isSelectedForFailover;
            TargetSubnetName = targetSubnetName;
            TargetStaticIPAddress = targetStaticIPAddress;
            TestSubnetName = testSubnetName;
            TestStaticIPAddress = testStaticIPAddress;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmNicContent"/> for deserialization. </summary>
        internal InMageRcmNicContent()
        {
        }

        /// <summary> The NIC Id. </summary>
        public string NicId { get; }
        /// <summary> A value indicating whether this is the primary NIC. </summary>
        public string IsPrimaryNic { get; }
        /// <summary> A value indicating whether this NIC is selected for failover. </summary>
        public string IsSelectedForFailover { get; set; }
        /// <summary> Target subnet name. </summary>
        public string TargetSubnetName { get; set; }
        /// <summary> The target static IP address. </summary>
        public IPAddress TargetStaticIPAddress { get; set; }
        /// <summary> The test subnet name. </summary>
        public string TestSubnetName { get; set; }
        /// <summary> The test static IP address. </summary>
        public IPAddress TestStaticIPAddress { get; set; }
    }
}
