// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.Chat
{
    /// <summary> Chat thread. </summary>
    internal partial class ChatThreadPropertiesInternal
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

        /// <summary> Initializes a new instance of <see cref="ChatThreadPropertiesInternal"/>. </summary>
        /// <param name="id"> Chat thread id. </param>
        /// <param name="topic"> Chat thread topic. </param>
        /// <param name="createdOn"> The timestamp when the chat thread was created. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="createdByCommunicationIdentifier"> Identifies a participant in Azure Communication services. A participant is, for example, a phone number or an Azure communication user. This model must be interpreted as a union: Apart from rawId, at most one further property may be set. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="topic"/> or <paramref name="createdByCommunicationIdentifier"/> is null. </exception>
        internal ChatThreadPropertiesInternal(string id, string topic, DateTimeOffset createdOn, CommunicationIdentifierModel createdByCommunicationIdentifier)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(topic, nameof(topic));
            Argument.AssertNotNull(createdByCommunicationIdentifier, nameof(createdByCommunicationIdentifier));

            Id = id;
            Topic = topic;
            CreatedOn = createdOn;
            CreatedByCommunicationIdentifier = createdByCommunicationIdentifier;
        }

        /// <summary> Initializes a new instance of <see cref="ChatThreadPropertiesInternal"/>. </summary>
        /// <param name="id"> Chat thread id. </param>
        /// <param name="topic"> Chat thread topic. </param>
        /// <param name="createdOn"> The timestamp when the chat thread was created. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="createdByCommunicationIdentifier"> Identifies a participant in Azure Communication services. A participant is, for example, a phone number or an Azure communication user. This model must be interpreted as a union: Apart from rawId, at most one further property may be set. </param>
        /// <param name="deletedOn"> The timestamp when the chat thread was deleted. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChatThreadPropertiesInternal(string id, string topic, DateTimeOffset createdOn, CommunicationIdentifierModel createdByCommunicationIdentifier, DateTimeOffset? deletedOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Topic = topic;
            CreatedOn = createdOn;
            CreatedByCommunicationIdentifier = createdByCommunicationIdentifier;
            DeletedOn = deletedOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ChatThreadPropertiesInternal"/> for deserialization. </summary>
        internal ChatThreadPropertiesInternal()
        {
        }

        /// <summary> Chat thread id. </summary>
        public string Id { get; }
        /// <summary> Chat thread topic. </summary>
        public string Topic { get; }
        /// <summary> The timestamp when the chat thread was created. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </summary>
        public DateTimeOffset CreatedOn { get; }
        /// <summary> Identifies a participant in Azure Communication services. A participant is, for example, a phone number or an Azure communication user. This model must be interpreted as a union: Apart from rawId, at most one further property may be set. </summary>
        public CommunicationIdentifierModel CreatedByCommunicationIdentifier { get; }
        /// <summary> The timestamp when the chat thread was deleted. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </summary>
        public DateTimeOffset? DeletedOn { get; }
    }
}
