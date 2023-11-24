// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The remove participant by identifier request. </summary>
    internal partial class RemoveParticipantRequestInternal
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

        /// <summary> Initializes a new instance of <see cref="RemoveParticipantRequestInternal"/>. </summary>
        /// <param name="participantToRemove"> The participants to be removed from the call. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="participantToRemove"/> is null. </exception>
        public RemoveParticipantRequestInternal(CommunicationIdentifierModel participantToRemove)
        {
            Argument.AssertNotNull(participantToRemove, nameof(participantToRemove));

            ParticipantToRemove = participantToRemove;
        }

        /// <summary> Initializes a new instance of <see cref="RemoveParticipantRequestInternal"/>. </summary>
        /// <param name="participantToRemove"> The participants to be removed from the call. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="callbackUri"> The callback URI to override the main callback URI. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RemoveParticipantRequestInternal(CommunicationIdentifierModel participantToRemove, string operationContext, string callbackUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ParticipantToRemove = participantToRemove;
            OperationContext = operationContext;
            CallbackUri = callbackUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RemoveParticipantRequestInternal"/> for deserialization. </summary>
        internal RemoveParticipantRequestInternal()
        {
        }

        /// <summary> The participants to be removed from the call. </summary>
        public CommunicationIdentifierModel ParticipantToRemove { get; }
        /// <summary> Used by customers when calling mid-call actions to correlate the request to the response event. </summary>
        public string OperationContext { get; set; }
        /// <summary> The callback URI to override the main callback URI. </summary>
        public string CallbackUri { get; set; }
    }
}
