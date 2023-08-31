// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DataProtectionBackup
{
    /// <summary>
    /// A class representing a collection of <see cref="DeletedDataProtectionBackupInstanceResource" /> and their operations.
    /// Each <see cref="DeletedDataProtectionBackupInstanceResource" /> in the collection will belong to the same instance of <see cref="DataProtectionBackupVaultResource" />.
    /// To get a <see cref="DeletedDataProtectionBackupInstanceCollection" /> instance call the GetDeletedDataProtectionBackupInstances method from an instance of <see cref="DataProtectionBackupVaultResource" />.
    /// </summary>
    public partial class DeletedDataProtectionBackupInstanceCollection : ArmCollection, IEnumerable<DeletedDataProtectionBackupInstanceResource>, IAsyncEnumerable<DeletedDataProtectionBackupInstanceResource>
    {
        private readonly ClientDiagnostics _deletedDataProtectionBackupInstanceDeletedBackupInstancesClientDiagnostics;
        private readonly DeletedBackupInstancesRestOperations _deletedDataProtectionBackupInstanceDeletedBackupInstancesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeletedDataProtectionBackupInstanceCollection"/> class for mocking. </summary>
        protected DeletedDataProtectionBackupInstanceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeletedDataProtectionBackupInstanceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DeletedDataProtectionBackupInstanceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deletedDataProtectionBackupInstanceDeletedBackupInstancesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataProtectionBackup", DeletedDataProtectionBackupInstanceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DeletedDataProtectionBackupInstanceResource.ResourceType, out string deletedDataProtectionBackupInstanceDeletedBackupInstancesApiVersion);
            _deletedDataProtectionBackupInstanceDeletedBackupInstancesRestClient = new DeletedBackupInstancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deletedDataProtectionBackupInstanceDeletedBackupInstancesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataProtectionBackupVaultResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataProtectionBackupVaultResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a deleted backup instance with name in a backup vault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/deletedBackupInstances/{backupInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedBackupInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupInstanceName"> The name of the deleted backup instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupInstanceName"/> is null. </exception>
        public virtual async Task<Response<DeletedDataProtectionBackupInstanceResource>> GetAsync(string backupInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupInstanceName, nameof(backupInstanceName));

            using var scope = _deletedDataProtectionBackupInstanceDeletedBackupInstancesClientDiagnostics.CreateScope("DeletedDataProtectionBackupInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = await _deletedDataProtectionBackupInstanceDeletedBackupInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupInstanceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedDataProtectionBackupInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a deleted backup instance with name in a backup vault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/deletedBackupInstances/{backupInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedBackupInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupInstanceName"> The name of the deleted backup instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupInstanceName"/> is null. </exception>
        public virtual Response<DeletedDataProtectionBackupInstanceResource> Get(string backupInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupInstanceName, nameof(backupInstanceName));

            using var scope = _deletedDataProtectionBackupInstanceDeletedBackupInstancesClientDiagnostics.CreateScope("DeletedDataProtectionBackupInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = _deletedDataProtectionBackupInstanceDeletedBackupInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupInstanceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedDataProtectionBackupInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets deleted backup instances belonging to a backup vault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/deletedBackupInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedBackupInstances_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedDataProtectionBackupInstanceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeletedDataProtectionBackupInstanceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deletedDataProtectionBackupInstanceDeletedBackupInstancesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _deletedDataProtectionBackupInstanceDeletedBackupInstancesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DeletedDataProtectionBackupInstanceResource(Client, DeletedDataProtectionBackupInstanceData.DeserializeDeletedDataProtectionBackupInstanceData(e)), _deletedDataProtectionBackupInstanceDeletedBackupInstancesClientDiagnostics, Pipeline, "DeletedDataProtectionBackupInstanceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets deleted backup instances belonging to a backup vault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/deletedBackupInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedBackupInstances_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedDataProtectionBackupInstanceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeletedDataProtectionBackupInstanceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deletedDataProtectionBackupInstanceDeletedBackupInstancesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _deletedDataProtectionBackupInstanceDeletedBackupInstancesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DeletedDataProtectionBackupInstanceResource(Client, DeletedDataProtectionBackupInstanceData.DeserializeDeletedDataProtectionBackupInstanceData(e)), _deletedDataProtectionBackupInstanceDeletedBackupInstancesClientDiagnostics, Pipeline, "DeletedDataProtectionBackupInstanceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/deletedBackupInstances/{backupInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedBackupInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupInstanceName"> The name of the deleted backup instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupInstanceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string backupInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupInstanceName, nameof(backupInstanceName));

            using var scope = _deletedDataProtectionBackupInstanceDeletedBackupInstancesClientDiagnostics.CreateScope("DeletedDataProtectionBackupInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _deletedDataProtectionBackupInstanceDeletedBackupInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupInstanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/deletedBackupInstances/{backupInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedBackupInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupInstanceName"> The name of the deleted backup instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupInstanceName"/> is null. </exception>
        public virtual Response<bool> Exists(string backupInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupInstanceName, nameof(backupInstanceName));

            using var scope = _deletedDataProtectionBackupInstanceDeletedBackupInstancesClientDiagnostics.CreateScope("DeletedDataProtectionBackupInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = _deletedDataProtectionBackupInstanceDeletedBackupInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupInstanceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DeletedDataProtectionBackupInstanceResource> IEnumerable<DeletedDataProtectionBackupInstanceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeletedDataProtectionBackupInstanceResource> IAsyncEnumerable<DeletedDataProtectionBackupInstanceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
