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
    public partial class SubscriptionLongTermRetentionManagedInstanceBackupCollection : ArmCollection, IEnumerable<SubscriptionLongTermRetentionManagedInstanceBackup>, IAsyncEnumerable<SubscriptionLongTermRetentionManagedInstanceBackup>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly LongTermRetentionManagedInstanceBackupsRestOperations _longTermRetentionManagedInstanceBackupsRestClient;
        private readonly string _locationName;
        private readonly string _managedInstanceName;
        private readonly string _databaseName;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionLongTermRetentionManagedInstanceBackupCollection"/> class for mocking. </summary>
        protected SubscriptionLongTermRetentionManagedInstanceBackupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionLongTermRetentionManagedInstanceBackupCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the managed database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/>, <paramref name="managedInstanceName"/>, or <paramref name="databaseName"/> is null. </exception>
        internal SubscriptionLongTermRetentionManagedInstanceBackupCollection(ArmResource parent, string locationName, string managedInstanceName, string databaseName) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SubscriptionLongTermRetentionManagedInstanceBackup.ResourceType, out string apiVersion);
            _longTermRetentionManagedInstanceBackupsRestClient = new LongTermRetentionManagedInstanceBackupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _locationName = locationName;
            _managedInstanceName = managedInstanceName;
            _databaseName = databaseName;
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: LongTermRetentionManagedInstanceBackups_Get
        /// <summary> Gets a long term retention backup for a managed database. </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is null or empty. </exception>
        public virtual Response<SubscriptionLongTermRetentionManagedInstanceBackup> Get(string backupName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(backupName))
            {
                throw new ArgumentException($"Parameter {nameof(backupName)} cannot be null or empty", nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackupCollection.Get");
            scope.Start();
            try
            {
                var response = _longTermRetentionManagedInstanceBackupsRestClient.Get(Id.SubscriptionId, _locationName, _managedInstanceName, _databaseName, backupName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionLongTermRetentionManagedInstanceBackup(this, response.Value), response.GetRawResponse());
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
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is null or empty. </exception>
        public async virtual Task<Response<SubscriptionLongTermRetentionManagedInstanceBackup>> GetAsync(string backupName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(backupName))
            {
                throw new ArgumentException($"Parameter {nameof(backupName)} cannot be null or empty", nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackupCollection.Get");
            scope.Start();
            try
            {
                var response = await _longTermRetentionManagedInstanceBackupsRestClient.GetAsync(Id.SubscriptionId, _locationName, _managedInstanceName, _databaseName, backupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SubscriptionLongTermRetentionManagedInstanceBackup(this, response.Value), response.GetRawResponse());
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
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is null or empty. </exception>
        public virtual Response<SubscriptionLongTermRetentionManagedInstanceBackup> GetIfExists(string backupName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(backupName))
            {
                throw new ArgumentException($"Parameter {nameof(backupName)} cannot be null or empty", nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _longTermRetentionManagedInstanceBackupsRestClient.Get(Id.SubscriptionId, _locationName, _managedInstanceName, _databaseName, backupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SubscriptionLongTermRetentionManagedInstanceBackup>(null, response.GetRawResponse());
                return Response.FromValue(new SubscriptionLongTermRetentionManagedInstanceBackup(this, response.Value), response.GetRawResponse());
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
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is null or empty. </exception>
        public async virtual Task<Response<SubscriptionLongTermRetentionManagedInstanceBackup>> GetIfExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(backupName))
            {
                throw new ArgumentException($"Parameter {nameof(backupName)} cannot be null or empty", nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _longTermRetentionManagedInstanceBackupsRestClient.GetAsync(Id.SubscriptionId, _locationName, _managedInstanceName, _databaseName, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SubscriptionLongTermRetentionManagedInstanceBackup>(null, response.GetRawResponse());
                return Response.FromValue(new SubscriptionLongTermRetentionManagedInstanceBackup(this, response.Value), response.GetRawResponse());
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
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string backupName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(backupName))
            {
                throw new ArgumentException($"Parameter {nameof(backupName)} cannot be null or empty", nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackupCollection.Exists");
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
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(backupName))
            {
                throw new ArgumentException($"Parameter {nameof(backupName)} cannot be null or empty", nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackupCollection.Exists");
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

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: LongTermRetentionManagedInstanceBackups_ListByDatabase
        /// <summary> Lists all long term retention backups for a managed database. </summary>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubscriptionLongTermRetentionManagedInstanceBackup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubscriptionLongTermRetentionManagedInstanceBackup> GetAll(bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            Page<SubscriptionLongTermRetentionManagedInstanceBackup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _longTermRetentionManagedInstanceBackupsRestClient.ListByDatabase(Id.SubscriptionId, _locationName, _managedInstanceName, _databaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionLongTermRetentionManagedInstanceBackup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubscriptionLongTermRetentionManagedInstanceBackup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _longTermRetentionManagedInstanceBackupsRestClient.ListByDatabaseNextPage(nextLink, Id.SubscriptionId, _locationName, _managedInstanceName, _databaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionLongTermRetentionManagedInstanceBackup(this, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubscriptionLongTermRetentionManagedInstanceBackup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubscriptionLongTermRetentionManagedInstanceBackup> GetAllAsync(bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SubscriptionLongTermRetentionManagedInstanceBackup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _longTermRetentionManagedInstanceBackupsRestClient.ListByDatabaseAsync(Id.SubscriptionId, _locationName, _managedInstanceName, _databaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionLongTermRetentionManagedInstanceBackup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubscriptionLongTermRetentionManagedInstanceBackup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _longTermRetentionManagedInstanceBackupsRestClient.ListByDatabaseNextPageAsync(nextLink, Id.SubscriptionId, _locationName, _managedInstanceName, _databaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionLongTermRetentionManagedInstanceBackup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="SubscriptionLongTermRetentionManagedInstanceBackup" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackupCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubscriptionLongTermRetentionManagedInstanceBackup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="SubscriptionLongTermRetentionManagedInstanceBackup" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackupCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubscriptionLongTermRetentionManagedInstanceBackup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubscriptionLongTermRetentionManagedInstanceBackup> IEnumerable<SubscriptionLongTermRetentionManagedInstanceBackup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubscriptionLongTermRetentionManagedInstanceBackup> IAsyncEnumerable<SubscriptionLongTermRetentionManagedInstanceBackup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SubscriptionLongTermRetentionManagedInstanceBackup, ManagedInstanceLongTermRetentionBackupData> Construct() { }
    }
}
