// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Storage;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class StorageResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="StorageResourceGroupMockingExtension"/> class for mocking. </summary>
        protected StorageResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StorageResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of StorageAccountResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of StorageAccountResources and their operations over a StorageAccountResource. </returns>
        public virtual StorageAccountCollection GetStorageAccounts()
        {
            return GetCachedClient(Client => new StorageAccountCollection(Client, Id));
        }

        /// <summary>
        /// Returns the properties for the specified storage account including but not limited to name, SKU name, location, and account status. The ListKeys operation should be used to retrieve storage keys.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_GetProperties</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="expand"> May be used to expand the properties within account's properties. By default, data is not included when fetching properties. Currently we only support geoReplicationStats and blobRestoreStatus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<StorageAccountResource>> GetStorageAccountAsync(string accountName, StorageAccountExpand? expand = null, CancellationToken cancellationToken = default)
        {
            return await GetStorageAccounts().GetAsync(accountName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the properties for the specified storage account including but not limited to name, SKU name, location, and account status. The ListKeys operation should be used to retrieve storage keys.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_GetProperties</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="expand"> May be used to expand the properties within account's properties. By default, data is not included when fetching properties. Currently we only support geoReplicationStats and blobRestoreStatus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<StorageAccountResource> GetStorageAccount(string accountName, StorageAccountExpand? expand = null, CancellationToken cancellationToken = default)
        {
            return GetStorageAccounts().Get(accountName, expand, cancellationToken);
        }
    }
}
