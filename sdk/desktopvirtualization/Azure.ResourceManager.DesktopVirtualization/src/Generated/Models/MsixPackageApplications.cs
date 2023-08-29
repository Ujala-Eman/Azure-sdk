// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Schema for MSIX Package Application properties. </summary>
    public partial class MsixPackageApplications
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MsixPackageApplications"/>. </summary>
        public MsixPackageApplications()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MsixPackageApplications"/>. </summary>
        /// <param name="appId"> Package Application Id, found in appxmanifest.xml. </param>
        /// <param name="description"> Description of Package Application. </param>
        /// <param name="appUserModelId"> Used to activate Package Application. Consists of Package Name and ApplicationID. Found in appxmanifest.xml. </param>
        /// <param name="friendlyName"> User friendly name. </param>
        /// <param name="iconImageName"> User friendly name. </param>
        /// <param name="rawIcon"> the icon a 64 bit string as a byte array. </param>
        /// <param name="rawPng"> the icon a 64 bit string as a byte array. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MsixPackageApplications(string appId, string description, string appUserModelId, string friendlyName, string iconImageName, BinaryData rawIcon, BinaryData rawPng, Dictionary<string, BinaryData> rawData)
        {
            AppId = appId;
            Description = description;
            AppUserModelId = appUserModelId;
            FriendlyName = friendlyName;
            IconImageName = iconImageName;
            RawIcon = rawIcon;
            RawPng = rawPng;
            _rawData = rawData;
        }

        /// <summary> Package Application Id, found in appxmanifest.xml. </summary>
        public string AppId { get; set; }
        /// <summary> Description of Package Application. </summary>
        public string Description { get; set; }
        /// <summary> Used to activate Package Application. Consists of Package Name and ApplicationID. Found in appxmanifest.xml. </summary>
        public string AppUserModelId { get; set; }
        /// <summary> User friendly name. </summary>
        public string FriendlyName { get; set; }
        /// <summary> User friendly name. </summary>
        public string IconImageName { get; set; }
        /// <summary>
        /// the icon a 64 bit string as a byte array.
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
        public BinaryData RawIcon { get; set; }
        /// <summary>
        /// the icon a 64 bit string as a byte array.
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
        public BinaryData RawPng { get; set; }
    }
}
