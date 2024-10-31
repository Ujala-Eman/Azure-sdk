// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing the BuildResource data model.
    /// Information pertaining to an individual build.
    /// </summary>
    public partial class BuildResourceData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="BuildResourceData"/>. </summary>
        public BuildResourceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BuildResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Build provisioning state. </param>
        /// <param name="buildStatus"> Status of the build once it has been provisioned. </param>
        /// <param name="destinationContainerRegistry"> Container registry that the final image will be uploaded to. </param>
        /// <param name="configuration"> Configuration of the build. </param>
        /// <param name="uploadEndpoint"> Endpoint to which the source code should be uploaded. </param>
        /// <param name="logStreamEndpoint"> Endpoint from which the build logs can be streamed. </param>
        /// <param name="tokenEndpoint"> Endpoint to use to retrieve an authentication token for log streaming and uploading source code. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BuildResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, BuildProvisioningState? provisioningState, BuildStatus? buildStatus, ContainerRegistryWithCustomImage destinationContainerRegistry, BuildConfiguration configuration, string uploadEndpoint, string logStreamEndpoint, string tokenEndpoint, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            BuildStatus = buildStatus;
            DestinationContainerRegistry = destinationContainerRegistry;
            Configuration = configuration;
            UploadEndpoint = uploadEndpoint;
            LogStreamEndpoint = logStreamEndpoint;
            TokenEndpoint = tokenEndpoint;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Build provisioning state. </summary>
        [WirePath("properties.provisioningState")]
        public BuildProvisioningState? ProvisioningState { get; }
        /// <summary> Status of the build once it has been provisioned. </summary>
        [WirePath("properties.buildStatus")]
        public BuildStatus? BuildStatus { get; }
        /// <summary> Container registry that the final image will be uploaded to. </summary>
        [WirePath("properties.destinationContainerRegistry")]
        public ContainerRegistryWithCustomImage DestinationContainerRegistry { get; set; }
        /// <summary> Configuration of the build. </summary>
        [WirePath("properties.configuration")]
        public BuildConfiguration Configuration { get; set; }
        /// <summary> Endpoint to which the source code should be uploaded. </summary>
        [WirePath("properties.uploadEndpoint")]
        public string UploadEndpoint { get; }
        /// <summary> Endpoint from which the build logs can be streamed. </summary>
        [WirePath("properties.logStreamEndpoint")]
        public string LogStreamEndpoint { get; }
        /// <summary> Endpoint to use to retrieve an authentication token for log streaming and uploading source code. </summary>
        [WirePath("properties.tokenEndpoint")]
        public string TokenEndpoint { get; }
    }
}
