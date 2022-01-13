// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ManagedInstanceLongTermRetentionBackup and their operations over its parent. </summary>
    public partial class ResourceGroupLongTermRetentionManagedInstanceBackupCollection : ArmCollection, IEnumerable<ResourceGroupLongTermRetentionManagedInstanceBackup>, IAsyncEnumerable<ResourceGroupLongTermRetentionManagedInstanceBackup>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly LongTermRetentionManagedInstanceBackupsRestOperations _longTermRetentionManagedInstanceBackupsRestClient;
        private readonly string _locationName;
        private readonly string _managedInstanceName;
        private readonly string _databaseName;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupLongTermRetentionManagedInstanceBackupCollection"/> class for mocking. </summary>
        protected ResourceGroupLongTermRetentionManagedInstanceBackupCollection()
        {
        }

        /// <summary> Initializes a new instance of ResourceGroupLongTermRetentionManagedInstanceBackupCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the managed database. </param>
        internal ResourceGroupLongTermRetentionManagedInstanceBackupCollection(ArmResource parent, string locationName, string managedInstanceName, string databaseName) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _longTermRetentionManagedInstanceBackupsRestClient = new LongTermRetentionManagedInstanceBackupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _locationName = locationName;
            _managedInstanceName = managedInstanceName;
            _databaseName = databaseName;
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: LongTermRetentionManagedInstanceBackups_GetByResourceGroup
        /// <summary> Gets a long term retention backup for a managed database. </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<ResourceGroupLongTermRetentionManagedInstanceBackup> Get(string backupName, CancellationToken cancellationToken = default)
        {
            if (backupName == null)
            {
                throw new ArgumentNullException(nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.Get");
            scope.Start();
            try
            {
                var response = _longTermRetentionManagedInstanceBackupsRestClient.GetByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, _locationName, _managedInstanceName, _databaseName, backupName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupLongTermRetentionManagedInstanceBackup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: LongTermRetentionManagedInstanceBackups_GetByResourceGroup
        /// <summary> Gets a long term retention backup for a managed database. </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public async virtual Task<Response<ResourceGroupLongTermRetentionManagedInstanceBackup>> GetAsync(string backupName, CancellationToken cancellationToken = default)
        {
            if (backupName == null)
            {
                throw new ArgumentNullException(nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.Get");
            scope.Start();
            try
            {
                var response = await _longTermRetentionManagedInstanceBackupsRestClient.GetByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, _managedInstanceName, _databaseName, backupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ResourceGroupLongTermRetentionManagedInstanceBackup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<ResourceGroupLongTermRetentionManagedInstanceBackup> GetIfExists(string backupName, CancellationToken cancellationToken = default)
        {
            if (backupName == null)
            {
                throw new ArgumentNullException(nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _longTermRetentionManagedInstanceBackupsRestClient.GetByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, _locationName, _managedInstanceName, _databaseName, backupName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ResourceGroupLongTermRetentionManagedInstanceBackup>(null, response.GetRawResponse())
                    : Response.FromValue(new ResourceGroupLongTermRetentionManagedInstanceBackup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public async virtual Task<Response<ResourceGroupLongTermRetentionManagedInstanceBackup>> GetIfExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            if (backupName == null)
            {
                throw new ArgumentNullException(nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _longTermRetentionManagedInstanceBackupsRestClient.GetByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, _managedInstanceName, _databaseName, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ResourceGroupLongTermRetentionManagedInstanceBackup>(null, response.GetRawResponse())
                    : Response.FromValue(new ResourceGroupLongTermRetentionManagedInstanceBackup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<bool> Exists(string backupName, CancellationToken cancellationToken = default)
        {
            if (backupName == null)
            {
                throw new ArgumentNullException(nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(backupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            if (backupName == null)
            {
                throw new ArgumentNullException(nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: LongTermRetentionManagedInstanceBackups_ListByResourceGroupDatabase
        /// <summary> Lists all long term retention backups for a managed database. </summary>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceGroupLongTermRetentionManagedInstanceBackup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceGroupLongTermRetentionManagedInstanceBackup> GetAll(bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            Page<ResourceGroupLongTermRetentionManagedInstanceBackup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _longTermRetentionManagedInstanceBackupsRestClient.ListByResourceGroupDatabase(Id.SubscriptionId, Id.ResourceGroupName, _locationName, _managedInstanceName, _databaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGroupLongTermRetentionManagedInstanceBackup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceGroupLongTermRetentionManagedInstanceBackup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _longTermRetentionManagedInstanceBackupsRestClient.ListByResourceGroupDatabaseNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _locationName, _managedInstanceName, _databaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGroupLongTermRetentionManagedInstanceBackup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: LongTermRetentionManagedInstanceBackups_ListByResourceGroupDatabase
        /// <summary> Lists all long term retention backups for a managed database. </summary>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceGroupLongTermRetentionManagedInstanceBackup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceGroupLongTermRetentionManagedInstanceBackup> GetAllAsync(bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceGroupLongTermRetentionManagedInstanceBackup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _longTermRetentionManagedInstanceBackupsRestClient.ListByResourceGroupDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, _managedInstanceName, _databaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGroupLongTermRetentionManagedInstanceBackup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceGroupLongTermRetentionManagedInstanceBackup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _longTermRetentionManagedInstanceBackupsRestClient.ListByResourceGroupDatabaseNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _locationName, _managedInstanceName, _databaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGroupLongTermRetentionManagedInstanceBackup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="ResourceGroupLongTermRetentionManagedInstanceBackup" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ResourceGroupLongTermRetentionManagedInstanceBackup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ResourceGroupLongTermRetentionManagedInstanceBackup" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ResourceGroupLongTermRetentionManagedInstanceBackup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResourceGroupLongTermRetentionManagedInstanceBackup> IEnumerable<ResourceGroupLongTermRetentionManagedInstanceBackup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResourceGroupLongTermRetentionManagedInstanceBackup> IAsyncEnumerable<ResourceGroupLongTermRetentionManagedInstanceBackup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ResourceGroupLongTermRetentionManagedInstanceBackup, ManagedInstanceLongTermRetentionBackupData> Construct() { }
    }
}
