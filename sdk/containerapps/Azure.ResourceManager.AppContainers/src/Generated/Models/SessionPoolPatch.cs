// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Container App session pool updatable properties. </summary>
    public partial class SessionPoolPatch
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

        /// <summary> Initializes a new instance of <see cref="SessionPoolPatch"/>. </summary>
        public SessionPoolPatch()
        {
            Secrets = new ChangeTrackingList<SessionPoolSecret>();
        }

        /// <summary> Initializes a new instance of <see cref="SessionPoolPatch"/>. </summary>
        /// <param name="identity"> Managed identities needed by a session pool to interact with other Azure services to not maintain any secrets or credentials in code. </param>
        /// <param name="scaleConfiguration"> The scale configuration of the session pool. </param>
        /// <param name="secrets"> The secrets of the session pool. </param>
        /// <param name="dynamicPoolConfiguration"> The pool configuration if the poolManagementType is dynamic. </param>
        /// <param name="customContainerTemplate"> The custom container configuration if the containerType is CustomContainer. </param>
        /// <param name="sessionNetworkConfiguration"> The network configuration of the sessions in the session pool. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SessionPoolPatch(ManagedServiceIdentity identity, ScaleConfiguration scaleConfiguration, IList<SessionPoolSecret> secrets, DynamicPoolConfiguration dynamicPoolConfiguration, CustomContainerTemplate customContainerTemplate, SessionNetworkConfiguration sessionNetworkConfiguration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Identity = identity;
            ScaleConfiguration = scaleConfiguration;
            Secrets = secrets;
            DynamicPoolConfiguration = dynamicPoolConfiguration;
            CustomContainerTemplate = customContainerTemplate;
            SessionNetworkConfiguration = sessionNetworkConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Managed identities needed by a session pool to interact with other Azure services to not maintain any secrets or credentials in code. </summary>
        [WirePath("identity")]
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The scale configuration of the session pool. </summary>
        [WirePath("properties.scaleConfiguration")]
        public ScaleConfiguration ScaleConfiguration { get; set; }
        /// <summary> The secrets of the session pool. </summary>
        [WirePath("properties.secrets")]
        public IList<SessionPoolSecret> Secrets { get; }
        /// <summary> The pool configuration if the poolManagementType is dynamic. </summary>
        [WirePath("properties.dynamicPoolConfiguration")]
        public DynamicPoolConfiguration DynamicPoolConfiguration { get; set; }
        /// <summary> The custom container configuration if the containerType is CustomContainer. </summary>
        [WirePath("properties.customContainerTemplate")]
        public CustomContainerTemplate CustomContainerTemplate { get; set; }
        /// <summary> The network configuration of the sessions in the session pool. </summary>
        internal SessionNetworkConfiguration SessionNetworkConfiguration { get; set; }
        /// <summary> Network status for the sessions. </summary>
        [WirePath("properties.sessionNetworkConfiguration.status")]
        public SessionNetworkStatus? SessionNetworkStatus
        {
            get => SessionNetworkConfiguration is null ? default : SessionNetworkConfiguration.Status;
            set
            {
                if (SessionNetworkConfiguration is null)
                    SessionNetworkConfiguration = new SessionNetworkConfiguration();
                SessionNetworkConfiguration.Status = value;
            }
        }
    }
}
