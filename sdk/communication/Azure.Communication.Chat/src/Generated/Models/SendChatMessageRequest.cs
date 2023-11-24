// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Chat
{
    /// <summary> Details of the message to send. </summary>
    internal partial class SendChatMessageRequest
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

        /// <summary> Initializes a new instance of <see cref="SendChatMessageRequest"/>. </summary>
        /// <param name="content"> Chat message content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public SendChatMessageRequest(string content)
        {
            Argument.AssertNotNull(content, nameof(content));

            Content = content;
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="SendChatMessageRequest"/>. </summary>
        /// <param name="content"> Chat message content. </param>
        /// <param name="senderDisplayName"> The display name of the chat message sender. This property is used to populate sender name for push notifications. </param>
        /// <param name="type"> The chat message type. </param>
        /// <param name="metadata"> Message metadata. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SendChatMessageRequest(string content, string senderDisplayName, ChatMessageType? type, IDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Content = content;
            SenderDisplayName = senderDisplayName;
            Type = type;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SendChatMessageRequest"/> for deserialization. </summary>
        internal SendChatMessageRequest()
        {
        }

        /// <summary> Chat message content. </summary>
        public string Content { get; }
        /// <summary> The display name of the chat message sender. This property is used to populate sender name for push notifications. </summary>
        public string SenderDisplayName { get; set; }
        /// <summary> The chat message type. </summary>
        public ChatMessageType? Type { get; set; }
        /// <summary> Message metadata. </summary>
        public IDictionary<string, string> Metadata { get; }
    }
}
