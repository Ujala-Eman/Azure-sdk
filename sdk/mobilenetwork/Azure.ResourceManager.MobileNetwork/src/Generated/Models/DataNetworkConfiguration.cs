// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Settings controlling data network use. </summary>
    public partial class DataNetworkConfiguration
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

        /// <summary> Initializes a new instance of <see cref="DataNetworkConfiguration"/>. </summary>
        /// <param name="dataNetwork"> A reference to the data network that these settings apply to. The data network must be in the same location as the SIM policy. </param>
        /// <param name="sessionAmbr"> Aggregate maximum bit rate across all non-GBR QoS flows of a given PDU session. See 3GPP TS23.501 section 5.7.2.6 for a full description of the Session-AMBR. </param>
        /// <param name="allowedServices"> List of services that can be used as part of this SIM policy. The list must not contain duplicate items and must contain at least one item. The services must be in the same location as the SIM policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataNetwork"/>, <paramref name="sessionAmbr"/> or <paramref name="allowedServices"/> is null. </exception>
        public DataNetworkConfiguration(WritableSubResource dataNetwork, Ambr sessionAmbr, IEnumerable<WritableSubResource> allowedServices)
        {
            Argument.AssertNotNull(dataNetwork, nameof(dataNetwork));
            Argument.AssertNotNull(sessionAmbr, nameof(sessionAmbr));
            Argument.AssertNotNull(allowedServices, nameof(allowedServices));

            DataNetwork = dataNetwork;
            SessionAmbr = sessionAmbr;
            AdditionalAllowedSessionTypes = new ChangeTrackingList<MobileNetworkPduSessionType>();
            AllowedServices = allowedServices.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DataNetworkConfiguration"/>. </summary>
        /// <param name="dataNetwork"> A reference to the data network that these settings apply to. The data network must be in the same location as the SIM policy. </param>
        /// <param name="sessionAmbr"> Aggregate maximum bit rate across all non-GBR QoS flows of a given PDU session. See 3GPP TS23.501 section 5.7.2.6 for a full description of the Session-AMBR. </param>
        /// <param name="fiveQi"> Default 5G QoS Flow Indicator value. The 5QI identifies a specific QoS forwarding treatment to be provided to a flow. See 3GPP TS23.501 section 5.7.2.1 for a full description of the 5QI parameter, and table 5.7.4-1 for the definition the 5QI values. </param>
        /// <param name="allocationAndRetentionPriorityLevel"> Default QoS Flow allocation and retention priority (ARP) level. Flows with higher priority preempt flows with lower priority, if the settings of `preemptionCapability` and `preemptionVulnerability` allow it. 1 is the highest level of priority. If this field is not specified then `5qi` is used to derive the ARP value. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </param>
        /// <param name="preemptionCapability"> Default QoS Flow preemption capability. The preemption capability of a QoS Flow controls whether it can preempt another QoS Flow with a lower priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </param>
        /// <param name="preemptionVulnerability"> Default QoS Flow preemption vulnerability. The preemption vulnerability of a QoS Flow controls whether it can be preempted by a QoS Flow with a higher priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </param>
        /// <param name="defaultSessionType"> The default PDU session type, which is used if the UE does not request a specific session type. </param>
        /// <param name="additionalAllowedSessionTypes"> Allowed session types in addition to the default session type. Must not duplicate the default session type. </param>
        /// <param name="allowedServices"> List of services that can be used as part of this SIM policy. The list must not contain duplicate items and must contain at least one item. The services must be in the same location as the SIM policy. </param>
        /// <param name="maximumNumberOfBufferedPackets"> The maximum number of downlink packets to buffer at the user plane for High Latency Communication - Extended Buffering. See 3GPP TS29.272 v15.10.0 section 7.3.188 for a full description. This maximum is not guaranteed because there is a internal limit on buffered packets across all PDU sessions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataNetworkConfiguration(WritableSubResource dataNetwork, Ambr sessionAmbr, int? fiveQi, int? allocationAndRetentionPriorityLevel, MobileNetworkPreemptionCapability? preemptionCapability, MobileNetworkPreemptionVulnerability? preemptionVulnerability, MobileNetworkPduSessionType? defaultSessionType, IList<MobileNetworkPduSessionType> additionalAllowedSessionTypes, IList<WritableSubResource> allowedServices, int? maximumNumberOfBufferedPackets, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DataNetwork = dataNetwork;
            SessionAmbr = sessionAmbr;
            FiveQi = fiveQi;
            AllocationAndRetentionPriorityLevel = allocationAndRetentionPriorityLevel;
            PreemptionCapability = preemptionCapability;
            PreemptionVulnerability = preemptionVulnerability;
            DefaultSessionType = defaultSessionType;
            AdditionalAllowedSessionTypes = additionalAllowedSessionTypes;
            AllowedServices = allowedServices;
            MaximumNumberOfBufferedPackets = maximumNumberOfBufferedPackets;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataNetworkConfiguration"/> for deserialization. </summary>
        internal DataNetworkConfiguration()
        {
        }

        /// <summary> A reference to the data network that these settings apply to. The data network must be in the same location as the SIM policy. </summary>
        internal WritableSubResource DataNetwork { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DataNetworkId
        {
            get => DataNetwork is null ? default : DataNetwork.Id;
            set
            {
                if (DataNetwork is null)
                    DataNetwork = new WritableSubResource();
                DataNetwork.Id = value;
            }
        }

        /// <summary> Aggregate maximum bit rate across all non-GBR QoS flows of a given PDU session. See 3GPP TS23.501 section 5.7.2.6 for a full description of the Session-AMBR. </summary>
        public Ambr SessionAmbr { get; set; }
        /// <summary> Default 5G QoS Flow Indicator value. The 5QI identifies a specific QoS forwarding treatment to be provided to a flow. See 3GPP TS23.501 section 5.7.2.1 for a full description of the 5QI parameter, and table 5.7.4-1 for the definition the 5QI values. </summary>
        public int? FiveQi { get; set; }
        /// <summary> Default QoS Flow allocation and retention priority (ARP) level. Flows with higher priority preempt flows with lower priority, if the settings of `preemptionCapability` and `preemptionVulnerability` allow it. 1 is the highest level of priority. If this field is not specified then `5qi` is used to derive the ARP value. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </summary>
        public int? AllocationAndRetentionPriorityLevel { get; set; }
        /// <summary> Default QoS Flow preemption capability. The preemption capability of a QoS Flow controls whether it can preempt another QoS Flow with a lower priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </summary>
        public MobileNetworkPreemptionCapability? PreemptionCapability { get; set; }
        /// <summary> Default QoS Flow preemption vulnerability. The preemption vulnerability of a QoS Flow controls whether it can be preempted by a QoS Flow with a higher priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </summary>
        public MobileNetworkPreemptionVulnerability? PreemptionVulnerability { get; set; }
        /// <summary> The default PDU session type, which is used if the UE does not request a specific session type. </summary>
        public MobileNetworkPduSessionType? DefaultSessionType { get; set; }
        /// <summary> Allowed session types in addition to the default session type. Must not duplicate the default session type. </summary>
        public IList<MobileNetworkPduSessionType> AdditionalAllowedSessionTypes { get; }
        /// <summary> List of services that can be used as part of this SIM policy. The list must not contain duplicate items and must contain at least one item. The services must be in the same location as the SIM policy. </summary>
        public IList<WritableSubResource> AllowedServices { get; }
        /// <summary> The maximum number of downlink packets to buffer at the user plane for High Latency Communication - Extended Buffering. See 3GPP TS29.272 v15.10.0 section 7.3.188 for a full description. This maximum is not guaranteed because there is a internal limit on buffered packets across all PDU sessions. </summary>
        public int? MaximumNumberOfBufferedPackets { get; set; }
    }
}
