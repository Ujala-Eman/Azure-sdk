// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment operation properties. </summary>
    public partial class ArmDeploymentOperationProperties
    {
        /// <summary> Initializes a new instance of ArmDeploymentOperationProperties. </summary>
        internal ArmDeploymentOperationProperties()
        {
        }

        /// <summary> Initializes a new instance of ArmDeploymentOperationProperties. </summary>
        /// <param name="provisioningOperation"> The name of the current provisioning operation. </param>
        /// <param name="provisioningState"> The state of the provisioning. </param>
        /// <param name="timestamp"> The date and time of the operation. </param>
        /// <param name="duration"> The duration of the operation. </param>
        /// <param name="serviceRequestId"> Deployment operation service request id. </param>
        /// <param name="statusCode"> Operation status code from the resource provider. This property may not be set if a response has not yet been received. </param>
        /// <param name="statusMessage"> Operation status message from the resource provider. This property is optional.  It will only be provided if an error was received from the resource provider. </param>
        /// <param name="targetResource"> The target resource. </param>
        /// <param name="request"> The HTTP request message. </param>
        /// <param name="response"> The HTTP response message. </param>
        internal ArmDeploymentOperationProperties(ProvisioningOperationKind? provisioningOperation, string provisioningState, DateTimeOffset? timestamp, TimeSpan? duration, string serviceRequestId, string statusCode, StatusMessage statusMessage, TargetResource targetResource, HttpMessage request, HttpMessage response)
        {
            ProvisioningOperation = provisioningOperation;
            ProvisioningState = provisioningState;
            Timestamp = timestamp;
            Duration = duration;
            ServiceRequestId = serviceRequestId;
            StatusCode = statusCode;
            StatusMessage = statusMessage;
            TargetResource = targetResource;
            Request = request;
            Response = response;
        }

        /// <summary> The name of the current provisioning operation. </summary>
        public ProvisioningOperationKind? ProvisioningOperation { get; }
        /// <summary> The state of the provisioning. </summary>
        public string ProvisioningState { get; }
        /// <summary> The date and time of the operation. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> The duration of the operation. </summary>
        public TimeSpan? Duration { get; }
        /// <summary> Deployment operation service request id. </summary>
        public string ServiceRequestId { get; }
        /// <summary> Operation status code from the resource provider. This property may not be set if a response has not yet been received. </summary>
        public string StatusCode { get; }
        /// <summary> Operation status message from the resource provider. This property is optional.  It will only be provided if an error was received from the resource provider. </summary>
        public StatusMessage StatusMessage { get; }
        /// <summary> The target resource. </summary>
        public TargetResource TargetResource { get; }
        /// <summary> The HTTP request message. </summary>
        internal HttpMessage Request { get; }
        /// <summary>
        /// HTTP message content..
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData RequestContent
        {
            get => Request?.Content;
        }

        /// <summary> The HTTP response message. </summary>
        internal HttpMessage Response { get; }
        /// <summary>
        /// HTTP message content..
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData ResponseContent
        {
            get => Response?.Content;
        }
    }
}
