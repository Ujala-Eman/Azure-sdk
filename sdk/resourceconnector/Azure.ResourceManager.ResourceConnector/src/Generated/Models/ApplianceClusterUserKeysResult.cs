// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ResourceConnector;

namespace Azure.ResourceManager.ResourceConnector.Models
{
    /// <summary> The List Cluster Keys Results appliance. </summary>
    public partial class ApplianceClusterUserKeysResult
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

        /// <summary> Initializes a new instance of <see cref="ApplianceClusterUserKeysResult"/>. </summary>
        internal ApplianceClusterUserKeysResult()
        {
            ArtifactProfiles = new ChangeTrackingDictionary<string, ApplianceArtifactProfile>();
            Kubeconfigs = new ChangeTrackingList<ApplianceCredentialKubeconfig>();
            SshKeys = new ChangeTrackingDictionary<string, ApplianceSshKey>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplianceClusterUserKeysResult"/>. </summary>
        /// <param name="artifactProfiles"> Map of artifacts that contains a list of ArtifactProfile used to upload artifacts such as logs. </param>
        /// <param name="kubeconfigs"> The list of appliance kubeconfigs. </param>
        /// <param name="sshKeys"> Map of Customer User Public, Private SSH Keys and Certificate when available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplianceClusterUserKeysResult(IReadOnlyDictionary<string, ApplianceArtifactProfile> artifactProfiles, IReadOnlyList<ApplianceCredentialKubeconfig> kubeconfigs, IReadOnlyDictionary<string, ApplianceSshKey> sshKeys, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ArtifactProfiles = artifactProfiles;
            Kubeconfigs = kubeconfigs;
            SshKeys = sshKeys;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Map of artifacts that contains a list of ArtifactProfile used to upload artifacts such as logs. </summary>
        public IReadOnlyDictionary<string, ApplianceArtifactProfile> ArtifactProfiles { get; }
        /// <summary> The list of appliance kubeconfigs. </summary>
        public IReadOnlyList<ApplianceCredentialKubeconfig> Kubeconfigs { get; }
        /// <summary> Map of Customer User Public, Private SSH Keys and Certificate when available. </summary>
        public IReadOnlyDictionary<string, ApplianceSshKey> SshKeys { get; }
    }
}
