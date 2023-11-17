// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> An update to a private cloud resource. </summary>
    public partial class AvsPrivateCloudPatch
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

        /// <summary> Initializes a new instance of <see cref="AvsPrivateCloudPatch"/>. </summary>
        public AvsPrivateCloudPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            IdentitySources = new ChangeTrackingList<SingleSignOnIdentitySource>();
        }

        /// <summary> Initializes a new instance of <see cref="AvsPrivateCloudPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="identity"> The identity of the private cloud, if configured. Current supported identity types: SystemAssigned, None. </param>
        /// <param name="managementCluster"> The default cluster used for management. </param>
        /// <param name="internet"> Connectivity to internet is enabled or disabled. </param>
        /// <param name="identitySources"> vCenter Single Sign On Identity Sources. </param>
        /// <param name="availability"> Properties describing how the cloud is distributed across availability zones. </param>
        /// <param name="encryption"> Customer managed key encryption, can be enabled or disabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AvsPrivateCloudPatch(IDictionary<string, string> tags, ManagedServiceIdentity identity, AvsManagementCluster managementCluster, InternetConnectivityState? internet, IList<SingleSignOnIdentitySource> identitySources, PrivateCloudAvailabilityProperties availability, CustomerManagedEncryption encryption, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Identity = identity;
            ManagementCluster = managementCluster;
            Internet = internet;
            IdentitySources = identitySources;
            Availability = availability;
            Encryption = encryption;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The identity of the private cloud, if configured. Current supported identity types: SystemAssigned, None. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The default cluster used for management. </summary>
        public AvsManagementCluster ManagementCluster { get; set; }
        /// <summary> Connectivity to internet is enabled or disabled. </summary>
        public InternetConnectivityState? Internet { get; set; }
        /// <summary> vCenter Single Sign On Identity Sources. </summary>
        public IList<SingleSignOnIdentitySource> IdentitySources { get; }
        /// <summary> Properties describing how the cloud is distributed across availability zones. </summary>
        public PrivateCloudAvailabilityProperties Availability { get; set; }
        /// <summary> Customer managed key encryption, can be enabled or disabled. </summary>
        public CustomerManagedEncryption Encryption { get; set; }
    }
}
