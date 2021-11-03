// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using SqlManagementClient.Models;

namespace SqlManagementClient
{
    /// <summary> A class representing collection of ManagedInstanceLongTermRetentionBackup and their operations over its parent. </summary>
    public partial class SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackupCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly LongTermRetentionManagedInstanceBackupsRestOperations _longTermRetentionManagedInstanceBackupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackupCollection"/> class for mocking. </summary>
        protected SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackupCollection()
        {
        }

        /// <summary> Initializes a new instance of SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackupCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackupCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _longTermRetentionManagedInstanceBackupsRestClient = new LongTermRetentionManagedInstanceBackupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Subscription.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: LongTermRetentionManagedInstanceBackups_Get
        /// <summary> Gets a long term retention backup for a managed database. </summary>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the managed database. </param>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/>, or <paramref name="backupName"/> is null. </exception>
        public virtual Response<SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup> Get(string locationName, string managedInstanceName, string databaseName, string backupName, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (backupName == null)
            {
                throw new ArgumentNullException(nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackupCollection.Get");
            scope.Start();
            try
            {
                var response = _longTermRetentionManagedInstanceBackupsRestClient.Get(locationName, managedInstanceName, databaseName, backupName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: LongTermRetentionManagedInstanceBackups_Get
        /// <summary> Gets a long term retention backup for a managed database. </summary>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the managed database. </param>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/>, or <paramref name="backupName"/> is null. </exception>
        public async virtual Task<Response<SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup>> GetAsync(string locationName, string managedInstanceName, string databaseName, string backupName, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (backupName == null)
            {
                throw new ArgumentNullException(nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackupCollection.Get");
            scope.Start();
            try
            {
                var response = await _longTermRetentionManagedInstanceBackupsRestClient.GetAsync(locationName, managedInstanceName, databaseName, backupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the managed database. </param>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/>, or <paramref name="backupName"/> is null. </exception>
        public virtual Response<SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup> GetIfExists(string locationName, string managedInstanceName, string databaseName, string backupName, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (backupName == null)
            {
                throw new ArgumentNullException(nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _longTermRetentionManagedInstanceBackupsRestClient.Get(locationName, managedInstanceName, databaseName, backupName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup>(null, response.GetRawResponse())
                    : Response.FromValue(new SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the managed database. </param>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/>, or <paramref name="backupName"/> is null. </exception>
        public async virtual Task<Response<SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup>> GetIfExistsAsync(string locationName, string managedInstanceName, string databaseName, string backupName, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (backupName == null)
            {
                throw new ArgumentNullException(nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackupCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _longTermRetentionManagedInstanceBackupsRestClient.GetAsync(locationName, managedInstanceName, databaseName, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup>(null, response.GetRawResponse())
                    : Response.FromValue(new SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the managed database. </param>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/>, or <paramref name="backupName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string locationName, string managedInstanceName, string databaseName, string backupName, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (backupName == null)
            {
                throw new ArgumentNullException(nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackupCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(locationName, managedInstanceName, databaseName, backupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the managed database. </param>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/>, or <paramref name="backupName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string locationName, string managedInstanceName, string databaseName, string backupName, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (backupName == null)
            {
                throw new ArgumentNullException(nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackupCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(locationName, managedInstanceName, databaseName, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: LongTermRetentionManagedInstanceBackups_ListByDatabase
        /// <summary> Lists all long term retention backups for a managed database. </summary>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the managed database. </param>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup> GetAll(string locationName, string managedInstanceName, string databaseName, bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            Page<SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _longTermRetentionManagedInstanceBackupsRestClient.ListByDatabase(locationName, managedInstanceName, databaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _longTermRetentionManagedInstanceBackupsRestClient.ListByDatabaseNextPage(nextLink, locationName, managedInstanceName, databaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: LongTermRetentionManagedInstanceBackups_ListByDatabase
        /// <summary> Lists all long term retention backups for a managed database. </summary>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the managed database. </param>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup> GetAllAsync(string locationName, string managedInstanceName, string databaseName, bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            async Task<Page<SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _longTermRetentionManagedInstanceBackupsRestClient.ListByDatabaseAsync(locationName, managedInstanceName, databaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _longTermRetentionManagedInstanceBackupsRestClient.ListByDatabaseNextPageAsync(nextLink, locationName, managedInstanceName, databaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackupCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackupCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, SubscriptionLocationLongTermRetentionManagedInstanceLongTermRetentionDatabaseLongTermRetentionManagedInstanceBackup, ManagedInstanceLongTermRetentionBackupData> Construct() { }
    }
}
