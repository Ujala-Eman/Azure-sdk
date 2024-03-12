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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlServerTrustGroupResource"/> and their operations.
    /// Each <see cref="SqlServerTrustGroupResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="SqlServerTrustGroupCollection"/> instance call the GetSqlServerTrustGroups method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class SqlServerTrustGroupCollection : ArmCollection, IEnumerable<SqlServerTrustGroupResource>, IAsyncEnumerable<SqlServerTrustGroupResource>
    {
        private readonly ClientDiagnostics _sqlServerTrustGroupServerTrustGroupsClientDiagnostics;
        private readonly ServerTrustGroupsRestOperations _sqlServerTrustGroupServerTrustGroupsRestClient;
        private readonly AzureLocation _locationName;

        /// <summary> Initializes a new instance of the <see cref="SqlServerTrustGroupCollection"/> class for mocking. </summary>
        protected SqlServerTrustGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerTrustGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        internal SqlServerTrustGroupCollection(ArmClient client, ResourceIdentifier id, AzureLocation locationName) : base(client, id)
        {
            _locationName = locationName;
            _sqlServerTrustGroupServerTrustGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerTrustGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerTrustGroupResource.ResourceType, out string sqlServerTrustGroupServerTrustGroupsApiVersion);
            _sqlServerTrustGroupServerTrustGroupsRestClient = new ServerTrustGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerTrustGroupServerTrustGroupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a server trust group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerTrustGroups_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerTrustGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="data"> The server trust group parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlServerTrustGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string serverTrustGroupName, SqlServerTrustGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerTrustGroupServerTrustGroupsClientDiagnostics.CreateScope("SqlServerTrustGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlServerTrustGroupServerTrustGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), serverTrustGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerTrustGroupResource>(new SqlServerTrustGroupOperationSource(Client), _sqlServerTrustGroupServerTrustGroupsClientDiagnostics, Pipeline, _sqlServerTrustGroupServerTrustGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), serverTrustGroupName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a server trust group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerTrustGroups_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerTrustGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="data"> The server trust group parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlServerTrustGroupResource> CreateOrUpdate(WaitUntil waitUntil, string serverTrustGroupName, SqlServerTrustGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerTrustGroupServerTrustGroupsClientDiagnostics.CreateScope("SqlServerTrustGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlServerTrustGroupServerTrustGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), serverTrustGroupName, data, cancellationToken);
                var operation = new SqlArmOperation<SqlServerTrustGroupResource>(new SqlServerTrustGroupOperationSource(Client), _sqlServerTrustGroupServerTrustGroupsClientDiagnostics, Pipeline, _sqlServerTrustGroupServerTrustGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), serverTrustGroupName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server trust group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerTrustGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerTrustGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public virtual async Task<Response<SqlServerTrustGroupResource>> GetAsync(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));

            using var scope = _sqlServerTrustGroupServerTrustGroupsClientDiagnostics.CreateScope("SqlServerTrustGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerTrustGroupServerTrustGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), serverTrustGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerTrustGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server trust group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerTrustGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerTrustGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public virtual Response<SqlServerTrustGroupResource> Get(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));

            using var scope = _sqlServerTrustGroupServerTrustGroupsClientDiagnostics.CreateScope("SqlServerTrustGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerTrustGroupServerTrustGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), serverTrustGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerTrustGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a server trust group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerTrustGroups_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerTrustGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerTrustGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerTrustGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerTrustGroupServerTrustGroupsRestClient.CreateListByLocationRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerTrustGroupServerTrustGroupsRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SqlServerTrustGroupResource(Client, SqlServerTrustGroupData.DeserializeSqlServerTrustGroupData(e)), _sqlServerTrustGroupServerTrustGroupsClientDiagnostics, Pipeline, "SqlServerTrustGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a server trust group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerTrustGroups_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerTrustGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerTrustGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerTrustGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerTrustGroupServerTrustGroupsRestClient.CreateListByLocationRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerTrustGroupServerTrustGroupsRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SqlServerTrustGroupResource(Client, SqlServerTrustGroupData.DeserializeSqlServerTrustGroupData(e)), _sqlServerTrustGroupServerTrustGroupsClientDiagnostics, Pipeline, "SqlServerTrustGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerTrustGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerTrustGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));

            using var scope = _sqlServerTrustGroupServerTrustGroupsClientDiagnostics.CreateScope("SqlServerTrustGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerTrustGroupServerTrustGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), serverTrustGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerTrustGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerTrustGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));

            using var scope = _sqlServerTrustGroupServerTrustGroupsClientDiagnostics.CreateScope("SqlServerTrustGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerTrustGroupServerTrustGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), serverTrustGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerTrustGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerTrustGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public virtual async Task<NullableResponse<SqlServerTrustGroupResource>> GetIfExistsAsync(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));

            using var scope = _sqlServerTrustGroupServerTrustGroupsClientDiagnostics.CreateScope("SqlServerTrustGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlServerTrustGroupServerTrustGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), serverTrustGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerTrustGroupResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerTrustGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerTrustGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerTrustGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public virtual NullableResponse<SqlServerTrustGroupResource> GetIfExists(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));

            using var scope = _sqlServerTrustGroupServerTrustGroupsClientDiagnostics.CreateScope("SqlServerTrustGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlServerTrustGroupServerTrustGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), serverTrustGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerTrustGroupResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerTrustGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerTrustGroupResource> IEnumerable<SqlServerTrustGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServerTrustGroupResource> IAsyncEnumerable<SqlServerTrustGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
