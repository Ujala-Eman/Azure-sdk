// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Appliance details of the migration item. </summary>
    public partial class ApplianceMonitoringDetails
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

        /// <summary> Initializes a new instance of <see cref="ApplianceMonitoringDetails"/>. </summary>
        internal ApplianceMonitoringDetails()
        {
            DatastoreSnapshot = new ChangeTrackingList<DataStoreUtilizationDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplianceMonitoringDetails"/>. </summary>
        /// <param name="cpuDetails"> The appliance CPU details. </param>
        /// <param name="ramDetails"> The appliance RAM details. </param>
        /// <param name="datastoreSnapshot"> The appliance datastore snapshot details. </param>
        /// <param name="disksReplicationDetails"> The disk replication details. </param>
        /// <param name="esxiNfcBuffer"> The ESXi NFC buffer details. </param>
        /// <param name="networkBandwidth"> The appliance network bandwidth details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplianceMonitoringDetails(ApplianceResourceDetails cpuDetails, ApplianceResourceDetails ramDetails, IReadOnlyList<DataStoreUtilizationDetails> datastoreSnapshot, ApplianceResourceDetails disksReplicationDetails, ApplianceResourceDetails esxiNfcBuffer, ApplianceResourceDetails networkBandwidth, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CpuDetails = cpuDetails;
            RamDetails = ramDetails;
            DatastoreSnapshot = datastoreSnapshot;
            DisksReplicationDetails = disksReplicationDetails;
            EsxiNfcBuffer = esxiNfcBuffer;
            NetworkBandwidth = networkBandwidth;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The appliance CPU details. </summary>
        public ApplianceResourceDetails CpuDetails { get; }
        /// <summary> The appliance RAM details. </summary>
        public ApplianceResourceDetails RamDetails { get; }
        /// <summary> The appliance datastore snapshot details. </summary>
        public IReadOnlyList<DataStoreUtilizationDetails> DatastoreSnapshot { get; }
        /// <summary> The disk replication details. </summary>
        public ApplianceResourceDetails DisksReplicationDetails { get; }
        /// <summary> The ESXi NFC buffer details. </summary>
        public ApplianceResourceDetails EsxiNfcBuffer { get; }
        /// <summary> The appliance network bandwidth details. </summary>
        public ApplianceResourceDetails NetworkBandwidth { get; }
    }
}
