// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Messaging.EventGrid;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.ChatThreadCreated event. </summary>
    public partial class AcsChatThreadCreatedEventData : AcsChatThreadEventInThreadBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="AcsChatThreadCreatedEventData"/>. </summary>
        internal AcsChatThreadCreatedEventData()
        {
            Properties = new ChangeTrackingDictionary<string, object>();
            Metadata = new ChangeTrackingDictionary<string, string>();
            Participants = new ChangeTrackingList<AcsChatThreadParticipantProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="AcsChatThreadCreatedEventData"/>. </summary>
        /// <param name="transactionId"> The transaction id will be used as co-relation vector. </param>
        /// <param name="threadId"> The chat thread id. </param>
        /// <param name="createTime"> The original creation time of the thread. </param>
        /// <param name="version"> The version of the thread. </param>
        /// <param name="createdByCommunicationIdentifier"> The communication identifier of the user who created the thread. </param>
        /// <param name="properties"> The thread properties. </param>
        /// <param name="metadata"> The chat thread created metadata. </param>
        /// <param name="participants"> The list of properties of participants who are part of the thread. </param>
        internal AcsChatThreadCreatedEventData(string transactionId, string threadId, DateTimeOffset? createTime, long? version, CommunicationIdentifierModel createdByCommunicationIdentifier, IReadOnlyDictionary<string, object> properties, IReadOnlyDictionary<string, string> metadata, IReadOnlyList<AcsChatThreadParticipantProperties> participants) : base(transactionId, threadId, createTime, version)
        {
            CreatedByCommunicationIdentifier = createdByCommunicationIdentifier;
            Properties = properties;
            Metadata = metadata;
            Participants = participants;
        }

        /// <summary> The communication identifier of the user who created the thread. </summary>
        public CommunicationIdentifierModel CreatedByCommunicationIdentifier { get; }
        /// <summary> The thread properties. </summary>
        public IReadOnlyDictionary<string, object> Properties { get; }
        /// <summary> The chat thread created metadata. </summary>
        public IReadOnlyDictionary<string, string> Metadata { get; }
        /// <summary> The list of properties of participants who are part of the thread. </summary>
        public IReadOnlyList<AcsChatThreadParticipantProperties> Participants { get; }
    }
}
