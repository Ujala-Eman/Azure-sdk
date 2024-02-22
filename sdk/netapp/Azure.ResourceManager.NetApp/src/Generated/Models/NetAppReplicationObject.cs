// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary>
    /// Replication properties
    /// Serialized Name: ReplicationObject
    /// </summary>
    public partial class NetAppReplicationObject
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

        /// <summary> Initializes a new instance of <see cref="NetAppReplicationObject"/>. </summary>
        /// <param name="remoteVolumeResourceId">
        /// The resource ID of the remote volume. Required for cross region and cross zone replication
        /// Serialized Name: ReplicationObject.remoteVolumeResourceId
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="remoteVolumeResourceId"/> is null. </exception>
        public NetAppReplicationObject(ResourceIdentifier remoteVolumeResourceId)
        {
            if (remoteVolumeResourceId == null)
            {
                throw new ArgumentNullException(nameof(remoteVolumeResourceId));
            }

            RemoteVolumeResourceId = remoteVolumeResourceId;
        }

        /// <summary> Initializes a new instance of <see cref="NetAppReplicationObject"/>. </summary>
        /// <param name="replicationId">
        /// Id
        /// Serialized Name: ReplicationObject.replicationId
        /// </param>
        /// <param name="endpointType">
        /// Indicates whether the local volume is the source or destination for the Volume Replication
        /// Serialized Name: ReplicationObject.endpointType
        /// </param>
        /// <param name="replicationSchedule">
        /// Schedule
        /// Serialized Name: ReplicationObject.replicationSchedule
        /// </param>
        /// <param name="remoteVolumeResourceId">
        /// The resource ID of the remote volume. Required for cross region and cross zone replication
        /// Serialized Name: ReplicationObject.remoteVolumeResourceId
        /// </param>
        /// <param name="remotePath">
        /// The full path to a volume that is to be migrated into ANF. Required for Migration volumes
        /// Serialized Name: ReplicationObject.remotePath
        /// </param>
        /// <param name="remoteVolumeRegion">
        /// The remote region for the other end of the Volume Replication.
        /// Serialized Name: ReplicationObject.remoteVolumeRegion
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppReplicationObject(string replicationId, NetAppEndpointType? endpointType, NetAppReplicationSchedule? replicationSchedule, ResourceIdentifier remoteVolumeResourceId, RemotePath remotePath, string remoteVolumeRegion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ReplicationId = replicationId;
            EndpointType = endpointType;
            ReplicationSchedule = replicationSchedule;
            RemoteVolumeResourceId = remoteVolumeResourceId;
            RemotePath = remotePath;
            RemoteVolumeRegion = remoteVolumeRegion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetAppReplicationObject"/> for deserialization. </summary>
        internal NetAppReplicationObject()
        {
        }
        /// <summary>
        /// Indicates whether the local volume is the source or destination for the Volume Replication
        /// Serialized Name: ReplicationObject.endpointType
        /// </summary>
        public NetAppEndpointType? EndpointType { get; set; }
        /// <summary>
        /// Schedule
        /// Serialized Name: ReplicationObject.replicationSchedule
        /// </summary>
        public NetAppReplicationSchedule? ReplicationSchedule { get; set; }
        /// <summary>
        /// The resource ID of the remote volume. Required for cross region and cross zone replication
        /// Serialized Name: ReplicationObject.remoteVolumeResourceId
        /// </summary>
        public ResourceIdentifier RemoteVolumeResourceId { get; set; }
        /// <summary>
        /// The full path to a volume that is to be migrated into ANF. Required for Migration volumes
        /// Serialized Name: ReplicationObject.remotePath
        /// </summary>
        public RemotePath RemotePath { get; set; }
        /// <summary>
        /// The remote region for the other end of the Volume Replication.
        /// Serialized Name: ReplicationObject.remoteVolumeRegion
        /// </summary>
        public string RemoteVolumeRegion { get; set; }
    }
}
