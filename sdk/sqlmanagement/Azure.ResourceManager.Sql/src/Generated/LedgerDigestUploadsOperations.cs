// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> The LedgerDigestUploads service client. </summary>
    public partial class LedgerDigestUploadsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal LedgerDigestUploadsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of LedgerDigestUploadsOperations for mocking. </summary>
        protected LedgerDigestUploadsOperations()
        {
        }

        /// <summary> Initializes a new instance of LedgerDigestUploadsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal LedgerDigestUploadsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new LedgerDigestUploadsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the current ledger digest upload configuration for a database. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="ledgerDigestUploads"> The LedgerDigestUploadsName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LedgerDigestUploads>> GetAsync(string resourceGroupName, string serverName, string databaseName, LedgerDigestUploadsName ledgerDigestUploads, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LedgerDigestUploadsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, serverName, databaseName, ledgerDigestUploads, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the current ledger digest upload configuration for a database. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="ledgerDigestUploads"> The LedgerDigestUploadsName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LedgerDigestUploads> Get(string resourceGroupName, string serverName, string databaseName, LedgerDigestUploadsName ledgerDigestUploads, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LedgerDigestUploadsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, serverName, databaseName, ledgerDigestUploads, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all ledger digest upload settings on a database. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="databaseName"/> is null. </exception>
        public virtual AsyncPageable<LedgerDigestUploads> ListByDatabaseAsync(string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            async Task<Page<LedgerDigestUploads>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LedgerDigestUploadsOperations.ListByDatabase");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByDatabaseAsync(resourceGroupName, serverName, databaseName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<LedgerDigestUploads>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LedgerDigestUploadsOperations.ListByDatabase");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByDatabaseNextPageAsync(nextLink, resourceGroupName, serverName, databaseName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all ledger digest upload settings on a database. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="databaseName"/> is null. </exception>
        public virtual Pageable<LedgerDigestUploads> ListByDatabase(string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            Page<LedgerDigestUploads> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LedgerDigestUploadsOperations.ListByDatabase");
                scope.Start();
                try
                {
                    var response = RestClient.ListByDatabase(resourceGroupName, serverName, databaseName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<LedgerDigestUploads> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LedgerDigestUploadsOperations.ListByDatabase");
                scope.Start();
                try
                {
                    var response = RestClient.ListByDatabaseNextPage(nextLink, resourceGroupName, serverName, databaseName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Enables upload ledger digests to an Azure Storage account or an Azure Confidential Ledger instance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="ledgerDigestUploads"> The LedgerDigestUploadsName to use. </param>
        /// <param name="parameters"> The LedgerDigestUploads to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<LedgerDigestUploadsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string serverName, string databaseName, LedgerDigestUploadsName ledgerDigestUploads, LedgerDigestUploads parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("LedgerDigestUploadsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, serverName, databaseName, ledgerDigestUploads, parameters, cancellationToken).ConfigureAwait(false);
                return new LedgerDigestUploadsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, serverName, databaseName, ledgerDigestUploads, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Enables upload ledger digests to an Azure Storage account or an Azure Confidential Ledger instance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="ledgerDigestUploads"> The LedgerDigestUploadsName to use. </param>
        /// <param name="parameters"> The LedgerDigestUploads to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual LedgerDigestUploadsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string serverName, string databaseName, LedgerDigestUploadsName ledgerDigestUploads, LedgerDigestUploads parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("LedgerDigestUploadsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, serverName, databaseName, ledgerDigestUploads, parameters, cancellationToken);
                return new LedgerDigestUploadsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, serverName, databaseName, ledgerDigestUploads, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Disables uploading ledger digests to an Azure Storage account or an Azure Confidential Ledger instance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="ledgerDigestUploads"> The LedgerDigestUploadsName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="databaseName"/> is null. </exception>
        public virtual async Task<LedgerDigestUploadsDisableOperation> StartDisableAsync(string resourceGroupName, string serverName, string databaseName, LedgerDigestUploadsName ledgerDigestUploads, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            using var scope = _clientDiagnostics.CreateScope("LedgerDigestUploadsOperations.StartDisable");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DisableAsync(resourceGroupName, serverName, databaseName, ledgerDigestUploads, cancellationToken).ConfigureAwait(false);
                return new LedgerDigestUploadsDisableOperation(_clientDiagnostics, _pipeline, RestClient.CreateDisableRequest(resourceGroupName, serverName, databaseName, ledgerDigestUploads).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Disables uploading ledger digests to an Azure Storage account or an Azure Confidential Ledger instance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="ledgerDigestUploads"> The LedgerDigestUploadsName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="databaseName"/> is null. </exception>
        public virtual LedgerDigestUploadsDisableOperation StartDisable(string resourceGroupName, string serverName, string databaseName, LedgerDigestUploadsName ledgerDigestUploads, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            using var scope = _clientDiagnostics.CreateScope("LedgerDigestUploadsOperations.StartDisable");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Disable(resourceGroupName, serverName, databaseName, ledgerDigestUploads, cancellationToken);
                return new LedgerDigestUploadsDisableOperation(_clientDiagnostics, _pipeline, RestClient.CreateDisableRequest(resourceGroupName, serverName, databaseName, ledgerDigestUploads).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
