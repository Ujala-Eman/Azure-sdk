// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    /// <summary> GitHub Repo properties. </summary>
    public partial class GitHubRepoProperties
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

        /// <summary> Initializes a new instance of <see cref="GitHubRepoProperties"/>. </summary>
        public GitHubRepoProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GitHubRepoProperties"/>. </summary>
        /// <param name="provisioningState"></param>
        /// <param name="accountId"> Gets or sets gitHub repo account id. </param>
        /// <param name="repoUri"> Gets or sets gitHub repo url. </param>
        /// <param name="ownerName"> Gets or sets GitHub Owner Name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GitHubRepoProperties(ProvisioningState? provisioningState, long? accountId, Uri repoUri, string ownerName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            AccountId = accountId;
            RepoUri = repoUri;
            OwnerName = ownerName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; set; }
        /// <summary> Gets or sets gitHub repo account id. </summary>
        public long? AccountId { get; set; }
        /// <summary> Gets or sets gitHub repo url. </summary>
        public Uri RepoUri { get; set; }
        /// <summary> Gets or sets GitHub Owner Name. </summary>
        public string OwnerName { get; set; }
    }
}
