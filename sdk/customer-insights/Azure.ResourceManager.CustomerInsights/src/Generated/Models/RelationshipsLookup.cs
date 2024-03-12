// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The definition of suggested relationship for the type. </summary>
    public partial class RelationshipsLookup
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

        /// <summary> Initializes a new instance of <see cref="RelationshipsLookup"/>. </summary>
        internal RelationshipsLookup()
        {
            ProfilePropertyReferences = new ChangeTrackingList<ParticipantProfilePropertyReference>();
            RelatedProfilePropertyReferences = new ChangeTrackingList<ParticipantProfilePropertyReference>();
        }

        /// <summary> Initializes a new instance of <see cref="RelationshipsLookup"/>. </summary>
        /// <param name="profileName"> The relationship profile. </param>
        /// <param name="profilePropertyReferences"> The property references for the profile type. </param>
        /// <param name="relatedProfileName"> The related profile. </param>
        /// <param name="relatedProfilePropertyReferences"> The property references for the related profile type. </param>
        /// <param name="existingRelationshipName"> The name of existing Relationship. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RelationshipsLookup(string profileName, IReadOnlyList<ParticipantProfilePropertyReference> profilePropertyReferences, string relatedProfileName, IReadOnlyList<ParticipantProfilePropertyReference> relatedProfilePropertyReferences, string existingRelationshipName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProfileName = profileName;
            ProfilePropertyReferences = profilePropertyReferences;
            RelatedProfileName = relatedProfileName;
            RelatedProfilePropertyReferences = relatedProfilePropertyReferences;
            ExistingRelationshipName = existingRelationshipName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The relationship profile. </summary>
        public string ProfileName { get; }
        /// <summary> The property references for the profile type. </summary>
        public IReadOnlyList<ParticipantProfilePropertyReference> ProfilePropertyReferences { get; }
        /// <summary> The related profile. </summary>
        public string RelatedProfileName { get; }
        /// <summary> The property references for the related profile type. </summary>
        public IReadOnlyList<ParticipantProfilePropertyReference> RelatedProfilePropertyReferences { get; }
        /// <summary> The name of existing Relationship. </summary>
        public string ExistingRelationshipName { get; }
    }
}
