// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Metadata of IoT device/IoT Edge device to be configured. </summary>
    public partial class EdgeIotDeviceInfo
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

        /// <summary> Initializes a new instance of <see cref="EdgeIotDeviceInfo"/>. </summary>
        /// <param name="deviceId"> ID of the IoT device/edge device. </param>
        /// <param name="iotHostHub"> Host name for the IoT hub associated to the device. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceId"/> or <paramref name="iotHostHub"/> is null. </exception>
        public EdgeIotDeviceInfo(string deviceId, string iotHostHub)
        {
            Argument.AssertNotNull(deviceId, nameof(deviceId));
            Argument.AssertNotNull(iotHostHub, nameof(iotHostHub));

            DeviceId = deviceId;
            IotHostHub = iotHostHub;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeIotDeviceInfo"/>. </summary>
        /// <param name="deviceId"> ID of the IoT device/edge device. </param>
        /// <param name="iotHostHub"> Host name for the IoT hub associated to the device. </param>
        /// <param name="iotHostHubId"> Id for the IoT hub associated to the device. </param>
        /// <param name="authentication"> Encrypted IoT device/IoT edge device connection string. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeIotDeviceInfo(string deviceId, string iotHostHub, ResourceIdentifier iotHostHubId, Authentication authentication, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DeviceId = deviceId;
            IotHostHub = iotHostHub;
            IotHostHubId = iotHostHubId;
            Authentication = authentication;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeIotDeviceInfo"/> for deserialization. </summary>
        internal EdgeIotDeviceInfo()
        {
        }

        /// <summary> ID of the IoT device/edge device. </summary>
        public string DeviceId { get; set; }
        /// <summary> Host name for the IoT hub associated to the device. </summary>
        public string IotHostHub { get; set; }
        /// <summary> Id for the IoT hub associated to the device. </summary>
        public ResourceIdentifier IotHostHubId { get; set; }
        /// <summary> Encrypted IoT device/IoT edge device connection string. </summary>
        internal Authentication Authentication { get; set; }
        /// <summary> Connection string based on the symmetric key. </summary>
        public AsymmetricEncryptedSecret SymmetricKeyConnectionString
        {
            get => Authentication is null ? default : Authentication.SymmetricKeyConnectionString;
            set
            {
                if (Authentication is null)
                    Authentication = new Authentication();
                Authentication.SymmetricKeyConnectionString = value;
            }
        }
    }
}
