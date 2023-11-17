// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A2A disk input details. </summary>
    public partial class A2AVmDiskDetails
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

        /// <summary> Initializes a new instance of <see cref="A2AVmDiskDetails"/>. </summary>
        /// <param name="diskUri"> The disk Uri. </param>
        /// <param name="recoveryAzureStorageAccountId"> The recovery VHD storage account Id. </param>
        /// <param name="primaryStagingAzureStorageAccountId"> The primary staging storage account Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskUri"/>, <paramref name="recoveryAzureStorageAccountId"/> or <paramref name="primaryStagingAzureStorageAccountId"/> is null. </exception>
        public A2AVmDiskDetails(Uri diskUri, ResourceIdentifier recoveryAzureStorageAccountId, ResourceIdentifier primaryStagingAzureStorageAccountId)
        {
            Argument.AssertNotNull(diskUri, nameof(diskUri));
            Argument.AssertNotNull(recoveryAzureStorageAccountId, nameof(recoveryAzureStorageAccountId));
            Argument.AssertNotNull(primaryStagingAzureStorageAccountId, nameof(primaryStagingAzureStorageAccountId));

            DiskUri = diskUri;
            RecoveryAzureStorageAccountId = recoveryAzureStorageAccountId;
            PrimaryStagingAzureStorageAccountId = primaryStagingAzureStorageAccountId;
        }

        /// <summary> Initializes a new instance of <see cref="A2AVmDiskDetails"/>. </summary>
        /// <param name="diskUri"> The disk Uri. </param>
        /// <param name="recoveryAzureStorageAccountId"> The recovery VHD storage account Id. </param>
        /// <param name="primaryStagingAzureStorageAccountId"> The primary staging storage account Id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal A2AVmDiskDetails(Uri diskUri, ResourceIdentifier recoveryAzureStorageAccountId, ResourceIdentifier primaryStagingAzureStorageAccountId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiskUri = diskUri;
            RecoveryAzureStorageAccountId = recoveryAzureStorageAccountId;
            PrimaryStagingAzureStorageAccountId = primaryStagingAzureStorageAccountId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="A2AVmDiskDetails"/> for deserialization. </summary>
        internal A2AVmDiskDetails()
        {
        }

        /// <summary> The disk Uri. </summary>
        public Uri DiskUri { get; }
        /// <summary> The recovery VHD storage account Id. </summary>
        public ResourceIdentifier RecoveryAzureStorageAccountId { get; }
        /// <summary> The primary staging storage account Id. </summary>
        public ResourceIdentifier PrimaryStagingAzureStorageAccountId { get; }
    }
}
