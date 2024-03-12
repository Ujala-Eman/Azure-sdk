// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Rule for trusted access role. </summary>
    public partial class ContainerServiceTrustedAccessRoleRule
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

        /// <summary> Initializes a new instance of <see cref="ContainerServiceTrustedAccessRoleRule"/>. </summary>
        internal ContainerServiceTrustedAccessRoleRule()
        {
            Verbs = new ChangeTrackingList<string>();
            ApiGroups = new ChangeTrackingList<string>();
            Resources = new ChangeTrackingList<string>();
            ResourceNames = new ChangeTrackingList<string>();
            NonResourceUrls = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceTrustedAccessRoleRule"/>. </summary>
        /// <param name="verbs"> List of allowed verbs. </param>
        /// <param name="apiGroups"> List of allowed apiGroups. </param>
        /// <param name="resources"> List of allowed resources. </param>
        /// <param name="resourceNames"> List of allowed names. </param>
        /// <param name="nonResourceUrls"> List of allowed nonResourceURLs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceTrustedAccessRoleRule(IReadOnlyList<string> verbs, IReadOnlyList<string> apiGroups, IReadOnlyList<string> resources, IReadOnlyList<string> resourceNames, IReadOnlyList<string> nonResourceUrls, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Verbs = verbs;
            ApiGroups = apiGroups;
            Resources = resources;
            ResourceNames = resourceNames;
            NonResourceUrls = nonResourceUrls;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of allowed verbs. </summary>
        public IReadOnlyList<string> Verbs { get; }
        /// <summary> List of allowed apiGroups. </summary>
        public IReadOnlyList<string> ApiGroups { get; }
        /// <summary> List of allowed resources. </summary>
        public IReadOnlyList<string> Resources { get; }
        /// <summary> List of allowed names. </summary>
        public IReadOnlyList<string> ResourceNames { get; }
        /// <summary> List of allowed nonResourceURLs. </summary>
        public IReadOnlyList<string> NonResourceUrls { get; }
    }
}
