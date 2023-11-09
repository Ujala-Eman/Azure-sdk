// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Remote device adapter properties. </summary>
    public partial class RemoteDeviceAdapterProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RemoteDeviceAdapterProperties"/>. </summary>
        /// <param name="target"> The IoT device to which this remote device will connect. </param>
        /// <param name="iotHubDeviceConnection"> Information that enables communication between the IoT Hub and the IoT device - allowing this edge module to act as a transparent gateway between the two. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="target"/> or <paramref name="iotHubDeviceConnection"/> is null. </exception>
        public RemoteDeviceAdapterProperties(RemoteDeviceAdapterTarget target, IotHubDeviceConnection iotHubDeviceConnection)
        {
            Argument.AssertNotNull(target, nameof(target));
            Argument.AssertNotNull(iotHubDeviceConnection, nameof(iotHubDeviceConnection));

            Target = target;
            IotHubDeviceConnection = iotHubDeviceConnection;
        }

        /// <summary> Initializes a new instance of <see cref="RemoteDeviceAdapterProperties"/>. </summary>
        /// <param name="description"> An optional description for the remote device adapter. </param>
        /// <param name="target"> The IoT device to which this remote device will connect. </param>
        /// <param name="iotHubDeviceConnection"> Information that enables communication between the IoT Hub and the IoT device - allowing this edge module to act as a transparent gateway between the two. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RemoteDeviceAdapterProperties(string description, RemoteDeviceAdapterTarget target, IotHubDeviceConnection iotHubDeviceConnection, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            Target = target;
            IotHubDeviceConnection = iotHubDeviceConnection;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RemoteDeviceAdapterProperties"/> for deserialization. </summary>
        internal RemoteDeviceAdapterProperties()
        {
        }

        /// <summary> An optional description for the remote device adapter. </summary>
        public string Description { get; set; }
        /// <summary> The IoT device to which this remote device will connect. </summary>
        public RemoteDeviceAdapterTarget Target { get; set; }
        /// <summary> Information that enables communication between the IoT Hub and the IoT device - allowing this edge module to act as a transparent gateway between the two. </summary>
        public IotHubDeviceConnection IotHubDeviceConnection { get; set; }
    }
}
