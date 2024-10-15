// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing the MobileNetworkRoutingInfo data model.
    /// Routing information
    /// Serialized Name: RoutingInfoModel
    /// </summary>
    public partial class MobileNetworkRoutingInfoData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="MobileNetworkRoutingInfoData"/>. </summary>
        public MobileNetworkRoutingInfoData()
        {
            ControlPlaneAccessRoutes = new ChangeTrackingList<MobileNetworkIPv4Route>();
            UserPlaneAccessRoutes = new ChangeTrackingList<MobileNetworkIPv4Route>();
            UserPlaneDataRoutes = new ChangeTrackingList<UserPlaneDataRoutesItem>();
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkRoutingInfoData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="controlPlaneAccessRoutes">
        /// A list of IPv4 routes.
        /// Serialized Name: RoutingInfoModel.properties.controlPlaneAccessRoutes
        /// </param>
        /// <param name="userPlaneAccessRoutes">
        /// A list of IPv4 routes.
        /// Serialized Name: RoutingInfoModel.properties.userPlaneAccessRoutes
        /// </param>
        /// <param name="userPlaneDataRoutes">
        /// A list of attached data networks and their IPv4 routes.
        /// Serialized Name: RoutingInfoModel.properties.userPlaneDataRoutes
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MobileNetworkRoutingInfoData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<MobileNetworkIPv4Route> controlPlaneAccessRoutes, IList<MobileNetworkIPv4Route> userPlaneAccessRoutes, IList<UserPlaneDataRoutesItem> userPlaneDataRoutes, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ControlPlaneAccessRoutes = controlPlaneAccessRoutes;
            UserPlaneAccessRoutes = userPlaneAccessRoutes;
            UserPlaneDataRoutes = userPlaneDataRoutes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// A list of IPv4 routes.
        /// Serialized Name: RoutingInfoModel.properties.controlPlaneAccessRoutes
        /// </summary>
        [WirePath("properties.controlPlaneAccessRoutes")]
        public IList<MobileNetworkIPv4Route> ControlPlaneAccessRoutes { get; }
        /// <summary>
        /// A list of IPv4 routes.
        /// Serialized Name: RoutingInfoModel.properties.userPlaneAccessRoutes
        /// </summary>
        [WirePath("properties.userPlaneAccessRoutes")]
        public IList<MobileNetworkIPv4Route> UserPlaneAccessRoutes { get; }
        /// <summary>
        /// A list of attached data networks and their IPv4 routes.
        /// Serialized Name: RoutingInfoModel.properties.userPlaneDataRoutes
        /// </summary>
        [WirePath("properties.userPlaneDataRoutes")]
        public IList<UserPlaneDataRoutesItem> UserPlaneDataRoutes { get; }
    }
}
