// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Gallery.Models
{
    /// <summary> Information of community gallery if current gallery is shared to community. </summary>
    public partial class CommunityGalleryInfo
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

        /// <summary> Initializes a new instance of <see cref="CommunityGalleryInfo"/>. </summary>
        public CommunityGalleryInfo()
        {
            PublicNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="CommunityGalleryInfo"/>. </summary>
        /// <param name="publisherUriString"> The link to the publisher website. Visible to all users. </param>
        /// <param name="publisherContact"> Community gallery publisher support email. The email address of the publisher. Visible to all users. </param>
        /// <param name="eula"> End-user license agreement for community gallery image. </param>
        /// <param name="publicNamePrefix"> The prefix of the gallery name that will be displayed publicly. Visible to all users. </param>
        /// <param name="communityGalleryEnabled"> Contains info about whether community gallery sharing is enabled. </param>
        /// <param name="publicNames"> Community gallery public name list. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CommunityGalleryInfo(string publisherUriString, string publisherContact, string eula, string publicNamePrefix, bool? communityGalleryEnabled, IReadOnlyList<string> publicNames, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PublisherUriString = publisherUriString;
            PublisherContact = publisherContact;
            Eula = eula;
            PublicNamePrefix = publicNamePrefix;
            CommunityGalleryEnabled = communityGalleryEnabled;
            PublicNames = publicNames;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The link to the publisher website. Visible to all users. </summary>
        public string PublisherUriString { get; set; }
        /// <summary> Community gallery publisher support email. The email address of the publisher. Visible to all users. </summary>
        public string PublisherContact { get; set; }
        /// <summary> End-user license agreement for community gallery image. </summary>
        public string Eula { get; set; }
        /// <summary> The prefix of the gallery name that will be displayed publicly. Visible to all users. </summary>
        public string PublicNamePrefix { get; set; }
        /// <summary> Contains info about whether community gallery sharing is enabled. </summary>
        public bool? CommunityGalleryEnabled { get; }
        /// <summary> Community gallery public name list. </summary>
        public IReadOnlyList<string> PublicNames { get; }
    }
}
