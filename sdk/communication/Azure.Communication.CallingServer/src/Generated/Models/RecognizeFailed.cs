// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.CallingServer
{
    /// <summary> The RecognizeFailed. </summary>
    public partial class RecognizeFailed
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

        /// <summary> Initializes a new instance of <see cref="RecognizeFailed"/>. </summary>
        internal RecognizeFailed()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RecognizeFailed"/>. </summary>
        /// <param name="operationContext"></param>
        /// <param name="resultInformation"></param>
        /// <param name="version"> Used to determine the version of the event. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="publicEventType"> The public event namespace used as the "type" property in the CloudEvent. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecognizeFailed(string operationContext, ResultInformation resultInformation, string version, string callConnectionId, string serverCallId, string correlationId, string publicEventType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            Version = version;
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            PublicEventType = publicEventType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the operation context. </summary>
        public string OperationContext { get; }
        /// <summary> Gets the result information. </summary>
        public ResultInformation ResultInformation { get; }
        /// <summary> Used to determine the version of the event. </summary>
        public string Version { get; }
        /// <summary> The public event namespace used as the "type" property in the CloudEvent. </summary>
        public string PublicEventType { get; }
    }
}
