// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Disk.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Disk
{
    /// <summary>
    /// A class representing the DiskEncryptionSet data model.
    /// disk encryption set resource.
    /// </summary>
    public partial class DiskEncryptionSetData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="DiskEncryptionSetData"/>. </summary>
        /// <param name="location"> The location. </param>
        public DiskEncryptionSetData(AzureLocation location) : base(location)
        {
            PreviousKeys = new ChangeTrackingList<KeyForDiskEncryptionSet>();
        }

        /// <summary> Initializes a new instance of <see cref="DiskEncryptionSetData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The managed identity for the disk encryption set. It should be given permission on the key vault before it can be used to encrypt disks. </param>
        /// <param name="encryptionType"> The type of key used to encrypt the data of the disk. </param>
        /// <param name="activeKey"> The key vault key which is currently used by this disk encryption set. </param>
        /// <param name="previousKeys"> A readonly collection of key vault keys previously used by this disk encryption set while a key rotation is in progress. It will be empty if there is no ongoing key rotation. </param>
        /// <param name="provisioningState"> The disk encryption set provisioning state. </param>
        /// <param name="rotationToLatestKeyVersionEnabled"> Set this flag to true to enable auto-updating of this disk encryption set to the latest key version. </param>
        /// <param name="lastKeyRotationTimestamp"> The time when the active key of this disk encryption set was updated. </param>
        /// <param name="autoKeyRotationError"> The error that was encountered during auto-key rotation. If an error is present, then auto-key rotation will not be attempted until the error on this disk encryption set is fixed. </param>
        /// <param name="federatedClientId"> Multi-tenant application client id to access key vault in a different tenant. Setting the value to 'None' will clear the property. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiskEncryptionSetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, DiskEncryptionSetType? encryptionType, KeyForDiskEncryptionSet activeKey, IReadOnlyList<KeyForDiskEncryptionSet> previousKeys, string provisioningState, bool? rotationToLatestKeyVersionEnabled, DateTimeOffset? lastKeyRotationTimestamp, DiskApiError autoKeyRotationError, string federatedClientId, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            EncryptionType = encryptionType;
            ActiveKey = activeKey;
            PreviousKeys = previousKeys;
            ProvisioningState = provisioningState;
            RotationToLatestKeyVersionEnabled = rotationToLatestKeyVersionEnabled;
            LastKeyRotationTimestamp = lastKeyRotationTimestamp;
            AutoKeyRotationError = autoKeyRotationError;
            FederatedClientId = federatedClientId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DiskEncryptionSetData"/> for deserialization. </summary>
        internal DiskEncryptionSetData()
        {
        }

        /// <summary> The managed identity for the disk encryption set. It should be given permission on the key vault before it can be used to encrypt disks. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The type of key used to encrypt the data of the disk. </summary>
        public DiskEncryptionSetType? EncryptionType { get; set; }
        /// <summary> The key vault key which is currently used by this disk encryption set. </summary>
        public KeyForDiskEncryptionSet ActiveKey { get; set; }
        /// <summary> A readonly collection of key vault keys previously used by this disk encryption set while a key rotation is in progress. It will be empty if there is no ongoing key rotation. </summary>
        public IReadOnlyList<KeyForDiskEncryptionSet> PreviousKeys { get; }
        /// <summary> The disk encryption set provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> Set this flag to true to enable auto-updating of this disk encryption set to the latest key version. </summary>
        public bool? RotationToLatestKeyVersionEnabled { get; set; }
        /// <summary> The time when the active key of this disk encryption set was updated. </summary>
        public DateTimeOffset? LastKeyRotationTimestamp { get; }
        /// <summary> The error that was encountered during auto-key rotation. If an error is present, then auto-key rotation will not be attempted until the error on this disk encryption set is fixed. </summary>
        public DiskApiError AutoKeyRotationError { get; }
        /// <summary> Multi-tenant application client id to access key vault in a different tenant. Setting the value to 'None' will clear the property. </summary>
        public string FederatedClientId { get; set; }
    }
}
