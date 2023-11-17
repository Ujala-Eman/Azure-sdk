// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary>
    /// The action of the probe.
    /// Please note <see cref="AppInstanceProbeAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AppInstanceExecAction"/>, <see cref="AppInstanceHttpGetAction"/> and <see cref="AppInstanceTcpSocketAction"/>.
    /// </summary>
    public abstract partial class AppInstanceProbeAction
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
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppInstanceProbeAction"/>. </summary>
        protected AppInstanceProbeAction()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppInstanceProbeAction"/>. </summary>
        /// <param name="probeActionType"> The type of the action to take to perform the health check. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppInstanceProbeAction(ProbeActionType probeActionType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProbeActionType = probeActionType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of the action to take to perform the health check. </summary>
        internal ProbeActionType ProbeActionType { get; set; }
    }
}
