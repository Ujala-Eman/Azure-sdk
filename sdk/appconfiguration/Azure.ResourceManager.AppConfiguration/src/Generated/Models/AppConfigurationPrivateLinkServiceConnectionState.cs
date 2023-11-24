// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> The state of a private link service connection. </summary>
    public partial class AppConfigurationPrivateLinkServiceConnectionState
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

        /// <summary> Initializes a new instance of <see cref="AppConfigurationPrivateLinkServiceConnectionState"/>. </summary>
        public AppConfigurationPrivateLinkServiceConnectionState()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppConfigurationPrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The private link service connection description. </param>
        /// <param name="actionsRequired"> Any action that is required beyond basic workflow (approve/ reject/ disconnect). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppConfigurationPrivateLinkServiceConnectionState(AppConfigurationPrivateLinkServiceConnectionStatus? status, string description, AppConfigurationActionsRequired? actionsRequired, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The private link service connection status. </summary>
        public AppConfigurationPrivateLinkServiceConnectionStatus? Status { get; set; }
        /// <summary> The private link service connection description. </summary>
        public string Description { get; set; }
        /// <summary> Any action that is required beyond basic workflow (approve/ reject/ disconnect). </summary>
        public AppConfigurationActionsRequired? ActionsRequired { get; }
    }
}
