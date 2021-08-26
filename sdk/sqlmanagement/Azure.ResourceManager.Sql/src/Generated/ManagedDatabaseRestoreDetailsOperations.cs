// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> The ManagedDatabaseRestoreDetails service client. </summary>
    public partial class ManagedDatabaseRestoreDetailsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ManagedDatabaseRestoreDetailsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of ManagedDatabaseRestoreDetailsOperations for mocking. </summary>
        protected ManagedDatabaseRestoreDetailsOperations()
        {
        }

        /// <summary> Initializes a new instance of ManagedDatabaseRestoreDetailsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ManagedDatabaseRestoreDetailsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ManagedDatabaseRestoreDetailsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets managed database restore details. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="restoreDetailsName"> The name of the restore details to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedDatabaseRestoreDetailsResult>> GetAsync(string resourceGroupName, string managedInstanceName, string databaseName, RestoreDetailsName restoreDetailsName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedDatabaseRestoreDetailsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, managedInstanceName, databaseName, restoreDetailsName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets managed database restore details. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="restoreDetailsName"> The name of the restore details to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedDatabaseRestoreDetailsResult> Get(string resourceGroupName, string managedInstanceName, string databaseName, RestoreDetailsName restoreDetailsName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedDatabaseRestoreDetailsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, managedInstanceName, databaseName, restoreDetailsName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
