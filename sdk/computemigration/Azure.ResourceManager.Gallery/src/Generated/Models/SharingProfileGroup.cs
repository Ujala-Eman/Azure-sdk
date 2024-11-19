// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Gallery.Models
{
    /// <summary> Group of the gallery sharing profile. </summary>
    public partial class SharingProfileGroup
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

        /// <summary> Initializes a new instance of <see cref="SharingProfileGroup"/>. </summary>
        public SharingProfileGroup()
        {
            Ids = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SharingProfileGroup"/>. </summary>
        /// <param name="groupType"> This property allows you to specify the type of sharing group. Possible values are: **Subscriptions,** **AADTenants.**. </param>
        /// <param name="ids"> A list of subscription/tenant ids the gallery is aimed to be shared to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SharingProfileGroup(SharingProfileGroupType? groupType, IList<string> ids, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            GroupType = groupType;
            Ids = ids;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> This property allows you to specify the type of sharing group. Possible values are: **Subscriptions,** **AADTenants.**. </summary>
        public SharingProfileGroupType? GroupType { get; set; }
        /// <summary> A list of subscription/tenant ids the gallery is aimed to be shared to. </summary>
        public IList<string> Ids { get; }
    }
}
