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

namespace Azure.ResourceManager.SqlVirtualMachine
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _sqlVirtualMachineGroupClientDiagnostics;
        private SqlVirtualMachineGroupsRestOperations _sqlVirtualMachineGroupRestClient;
        private ClientDiagnostics _sqlVirtualMachineClientDiagnostics;
        private SqlVirtualMachinesRestOperations _sqlVirtualMachineRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics SqlVirtualMachineGroupClientDiagnostics => _sqlVirtualMachineGroupClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.SqlVirtualMachine", SqlVirtualMachineGroupResource.ResourceType.Namespace, Diagnostics);
        private SqlVirtualMachineGroupsRestOperations SqlVirtualMachineGroupRestClient => _sqlVirtualMachineGroupRestClient ??= new SqlVirtualMachineGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(SqlVirtualMachineGroupResource.ResourceType));
        private ClientDiagnostics SqlVirtualMachineClientDiagnostics => _sqlVirtualMachineClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.SqlVirtualMachine", SqlVirtualMachineResource.ResourceType.Namespace, Diagnostics);
        private SqlVirtualMachinesRestOperations SqlVirtualMachineRestClient => _sqlVirtualMachineRestClient ??= new SqlVirtualMachinesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(SqlVirtualMachineResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets all SQL virtual machine groups in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups
        /// Operation Id: SqlVirtualMachineGroups_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlVirtualMachineGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlVirtualMachineGroupResource> GetSqlVirtualMachineGroupsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlVirtualMachineGroupResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = SqlVirtualMachineGroupClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSqlVirtualMachineGroups");
                scope.Start();
                try
                {
                    var response = await SqlVirtualMachineGroupRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlVirtualMachineGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SqlVirtualMachineGroupResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = SqlVirtualMachineGroupClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSqlVirtualMachineGroups");
                scope.Start();
                try
                {
                    var response = await SqlVirtualMachineGroupRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlVirtualMachineGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all SQL virtual machine groups in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups
        /// Operation Id: SqlVirtualMachineGroups_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlVirtualMachineGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlVirtualMachineGroupResource> GetSqlVirtualMachineGroups(CancellationToken cancellationToken = default)
        {
            Page<SqlVirtualMachineGroupResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = SqlVirtualMachineGroupClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSqlVirtualMachineGroups");
                scope.Start();
                try
                {
                    var response = SqlVirtualMachineGroupRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlVirtualMachineGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SqlVirtualMachineGroupResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = SqlVirtualMachineGroupClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSqlVirtualMachineGroups");
                scope.Start();
                try
                {
                    var response = SqlVirtualMachineGroupRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlVirtualMachineGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all SQL virtual machines in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines
        /// Operation Id: SqlVirtualMachines_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlVirtualMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlVirtualMachineResource> GetSqlVirtualMachinesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlVirtualMachineResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = SqlVirtualMachineClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSqlVirtualMachines");
                scope.Start();
                try
                {
                    var response = await SqlVirtualMachineRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlVirtualMachineResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SqlVirtualMachineResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = SqlVirtualMachineClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSqlVirtualMachines");
                scope.Start();
                try
                {
                    var response = await SqlVirtualMachineRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlVirtualMachineResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all SQL virtual machines in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines
        /// Operation Id: SqlVirtualMachines_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlVirtualMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlVirtualMachineResource> GetSqlVirtualMachines(CancellationToken cancellationToken = default)
        {
            Page<SqlVirtualMachineResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = SqlVirtualMachineClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSqlVirtualMachines");
                scope.Start();
                try
                {
                    var response = SqlVirtualMachineRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlVirtualMachineResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SqlVirtualMachineResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = SqlVirtualMachineClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSqlVirtualMachines");
                scope.Start();
                try
                {
                    var response = SqlVirtualMachineRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlVirtualMachineResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
