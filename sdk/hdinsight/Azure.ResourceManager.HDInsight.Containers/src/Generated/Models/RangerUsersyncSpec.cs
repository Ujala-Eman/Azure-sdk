// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Specification for the Ranger Usersync service. </summary>
    public partial class RangerUsersyncSpec
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

        /// <summary> Initializes a new instance of <see cref="RangerUsersyncSpec"/>. </summary>
        public RangerUsersyncSpec()
        {
            Groups = new ChangeTrackingList<string>();
            Users = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="RangerUsersyncSpec"/>. </summary>
        /// <param name="isEnabled"> Denotes whether usersync service should be enabled. </param>
        /// <param name="groups"> List of groups that should be synced. These group names should match the object id of the respective AAD groups. </param>
        /// <param name="mode"> User &amp; groups can be synced automatically or via a static list that's refreshed. </param>
        /// <param name="userMappingLocation"> Azure storage location of a mapping file that lists user &amp; group associations. </param>
        /// <param name="users"> List of user names that should be synced. These usernames should match the User principal name of the respective AAD users. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RangerUsersyncSpec(bool? isEnabled, IList<string> groups, RangerUsersyncMode? mode, string userMappingLocation, IList<string> users, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            Groups = groups;
            Mode = mode;
            UserMappingLocation = userMappingLocation;
            Users = users;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Denotes whether usersync service should be enabled. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> List of groups that should be synced. These group names should match the object id of the respective AAD groups. </summary>
        public IList<string> Groups { get; }
        /// <summary> User &amp; groups can be synced automatically or via a static list that's refreshed. </summary>
        public RangerUsersyncMode? Mode { get; set; }
        /// <summary> Azure storage location of a mapping file that lists user &amp; group associations. </summary>
        public string UserMappingLocation { get; set; }
        /// <summary> List of user names that should be synced. These usernames should match the User principal name of the respective AAD users. </summary>
        public IList<string> Users { get; }
    }
}
