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

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    /// <summary>
    /// A class representing a collection of <see cref="ServerBackupResource" /> and their operations.
    /// Each <see cref="ServerBackupResource" /> in the collection will belong to the same instance of <see cref="ServerResource" />.
    /// To get a <see cref="ServerBackupCollection" /> instance call the GetServerBackups method from an instance of <see cref="ServerResource" />.
    /// </summary>
    public partial class ServerBackupCollection : ArmCollection, IEnumerable<ServerBackupResource>, IAsyncEnumerable<ServerBackupResource>
    {
        private readonly ClientDiagnostics _serverBackupBackupsClientDiagnostics;
        private readonly BackupsRestOperations _serverBackupBackupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerBackupCollection"/> class for mocking. </summary>
        protected ServerBackupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerBackupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServerBackupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverBackupBackupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", ServerBackupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServerBackupResource.ResourceType, out string serverBackupBackupsApiVersion);
            _serverBackupBackupsRestClient = new BackupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serverBackupBackupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// List all the backups for a given server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backups/{backupName}
        /// Operation Id: Backups_Get
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<Response<ServerBackupResource>> GetAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _serverBackupBackupsClientDiagnostics.CreateScope("ServerBackupCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverBackupBackupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the backups for a given server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backups/{backupName}
        /// Operation Id: Backups_Get
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<ServerBackupResource> Get(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _serverBackupBackupsClientDiagnostics.CreateScope("ServerBackupCollection.Get");
            scope.Start();
            try
            {
                var response = _serverBackupBackupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the backups for a given server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backups
        /// Operation Id: Backups_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerBackupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerBackupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerBackupResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverBackupBackupsClientDiagnostics.CreateScope("ServerBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverBackupBackupsRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerBackupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerBackupResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverBackupBackupsClientDiagnostics.CreateScope("ServerBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverBackupBackupsRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerBackupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List all the backups for a given server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backups
        /// Operation Id: Backups_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerBackupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerBackupResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerBackupResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverBackupBackupsClientDiagnostics.CreateScope("ServerBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverBackupBackupsRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerBackupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerBackupResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverBackupBackupsClientDiagnostics.CreateScope("ServerBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverBackupBackupsRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerBackupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backups/{backupName}
        /// Operation Id: Backups_Get
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _serverBackupBackupsClientDiagnostics.CreateScope("ServerBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serverBackupBackupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backups/{backupName}
        /// Operation Id: Backups_Get
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<bool> Exists(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _serverBackupBackupsClientDiagnostics.CreateScope("ServerBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = _serverBackupBackupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerBackupResource> IEnumerable<ServerBackupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerBackupResource> IAsyncEnumerable<ServerBackupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
