// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The configuration for virtual machine extensions. </summary>
    public partial class BatchVmExtension
    {
        /// <summary> Initializes a new instance of BatchVmExtension. </summary>
        /// <param name="name"> The name of the virtual machine extension. </param>
        /// <param name="publisher"> The name of the extension handler publisher. </param>
        /// <param name="extensionType"> The type of the extensions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="publisher"/> or <paramref name="extensionType"/> is null. </exception>
        public BatchVmExtension(string name, string publisher, string extensionType)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (publisher == null)
            {
                throw new ArgumentNullException(nameof(publisher));
            }
            if (extensionType == null)
            {
                throw new ArgumentNullException(nameof(extensionType));
            }

            Name = name;
            Publisher = publisher;
            ExtensionType = extensionType;
            ProvisionAfterExtensions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of BatchVmExtension. </summary>
        /// <param name="name"> The name of the virtual machine extension. </param>
        /// <param name="publisher"> The name of the extension handler publisher. </param>
        /// <param name="extensionType"> The type of the extensions. </param>
        /// <param name="typeHandlerVersion"> The version of script handler. </param>
        /// <param name="autoUpgradeMinorVersion"> Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true. </param>
        /// <param name="settings"> JSON formatted public settings for the extension. </param>
        /// <param name="protectedSettings"> The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all. </param>
        /// <param name="provisionAfterExtensions"> Collection of extension names after which this extension needs to be provisioned. </param>
        internal BatchVmExtension(string name, string publisher, string extensionType, string typeHandlerVersion, bool? autoUpgradeMinorVersion, BinaryData settings, BinaryData protectedSettings, IList<string> provisionAfterExtensions)
        {
            Name = name;
            Publisher = publisher;
            ExtensionType = extensionType;
            TypeHandlerVersion = typeHandlerVersion;
            AutoUpgradeMinorVersion = autoUpgradeMinorVersion;
            Settings = settings;
            ProtectedSettings = protectedSettings;
            ProvisionAfterExtensions = provisionAfterExtensions;
        }

        /// <summary> The name of the virtual machine extension. </summary>
        public string Name { get; set; }
        /// <summary> The name of the extension handler publisher. </summary>
        public string Publisher { get; set; }
        /// <summary> The type of the extensions. </summary>
        public string ExtensionType { get; set; }
        /// <summary> The version of script handler. </summary>
        public string TypeHandlerVersion { get; set; }
        /// <summary> Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true. </summary>
        public bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary>
        /// JSON formatted public settings for the extension.
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
        public BinaryData Settings { get; set; }
        /// <summary>
        /// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all. 
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
        public BinaryData ProtectedSettings { get; set; }
        /// <summary> Collection of extension names after which this extension needs to be provisioned. </summary>
        public IList<string> ProvisionAfterExtensions { get; }
    }
}
