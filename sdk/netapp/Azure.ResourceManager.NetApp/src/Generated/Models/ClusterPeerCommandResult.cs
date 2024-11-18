// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Information about cluster peering process. </summary>
    public partial class ClusterPeerCommandResult
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

        /// <summary> Initializes a new instance of <see cref="ClusterPeerCommandResult"/>. </summary>
        internal ClusterPeerCommandResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ClusterPeerCommandResult"/>. </summary>
        /// <param name="peerAcceptCommand"> A command that needs to be run on the external ONTAP to accept cluster peering.  Will only be present if &lt;code&gt;clusterPeeringStatus&lt;/code&gt; is &lt;code&gt;pending&lt;/code&gt;. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterPeerCommandResult(string peerAcceptCommand, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PeerAcceptCommand = peerAcceptCommand;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A command that needs to be run on the external ONTAP to accept cluster peering.  Will only be present if &lt;code&gt;clusterPeeringStatus&lt;/code&gt; is &lt;code&gt;pending&lt;/code&gt;. </summary>
        public string PeerAcceptCommand { get; }
    }
}
