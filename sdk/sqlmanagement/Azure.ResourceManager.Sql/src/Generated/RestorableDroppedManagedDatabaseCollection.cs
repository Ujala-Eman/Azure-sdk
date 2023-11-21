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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="RestorableDroppedManagedDatabaseResource"/> and their operations.
    /// Each <see cref="RestorableDroppedManagedDatabaseResource"/> in the collection will belong to the same instance of <see cref="ManagedInstanceResource"/>.
    /// To get a <see cref="RestorableDroppedManagedDatabaseCollection"/> instance call the GetRestorableDroppedManagedDatabases method from an instance of <see cref="ManagedInstanceResource"/>.
    /// </summary>
    public partial class RestorableDroppedManagedDatabaseCollection : ArmCollection, IEnumerable<RestorableDroppedManagedDatabaseResource>, IAsyncEnumerable<RestorableDroppedManagedDatabaseResource>
    {
        private readonly ClientDiagnostics _restorableDroppedManagedDatabaseClientDiagnostics;
        private readonly RestorableDroppedManagedDatabasesRestOperations _restorableDroppedManagedDatabaseRestClient;

        /// <summary> Initializes a new instance of the <see cref="RestorableDroppedManagedDatabaseCollection"/> class for mocking. </summary>
        protected RestorableDroppedManagedDatabaseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RestorableDroppedManagedDatabaseCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RestorableDroppedManagedDatabaseCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _restorableDroppedManagedDatabaseClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", RestorableDroppedManagedDatabaseResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RestorableDroppedManagedDatabaseResource.ResourceType, out string restorableDroppedManagedDatabaseApiVersion);
            _restorableDroppedManagedDatabaseRestClient = new RestorableDroppedManagedDatabasesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, restorableDroppedManagedDatabaseApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a restorable dropped managed database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedManagedDatabases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorableDroppedDatabaseId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorableDroppedDatabaseId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedDatabaseId"/> is null. </exception>
        public virtual async Task<Response<RestorableDroppedManagedDatabaseResource>> GetAsync(string restorableDroppedDatabaseId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorableDroppedDatabaseId, nameof(restorableDroppedDatabaseId));

            using var scope = _restorableDroppedManagedDatabaseClientDiagnostics.CreateScope("RestorableDroppedManagedDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = await _restorableDroppedManagedDatabaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorableDroppedDatabaseId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorableDroppedManagedDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a restorable dropped managed database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedManagedDatabases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorableDroppedDatabaseId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorableDroppedDatabaseId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedDatabaseId"/> is null. </exception>
        public virtual Response<RestorableDroppedManagedDatabaseResource> Get(string restorableDroppedDatabaseId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorableDroppedDatabaseId, nameof(restorableDroppedDatabaseId));

            using var scope = _restorableDroppedManagedDatabaseClientDiagnostics.CreateScope("RestorableDroppedManagedDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = _restorableDroppedManagedDatabaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorableDroppedDatabaseId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorableDroppedManagedDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of restorable dropped managed databases.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedManagedDatabases_ListByInstance</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorableDroppedManagedDatabaseResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorableDroppedManagedDatabaseResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _restorableDroppedManagedDatabaseRestClient.CreateListByInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _restorableDroppedManagedDatabaseRestClient.CreateListByInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new RestorableDroppedManagedDatabaseResource(Client, RestorableDroppedManagedDatabaseData.DeserializeRestorableDroppedManagedDatabaseData(e)), _restorableDroppedManagedDatabaseClientDiagnostics, Pipeline, "RestorableDroppedManagedDatabaseCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of restorable dropped managed databases.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedManagedDatabases_ListByInstance</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorableDroppedManagedDatabaseResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorableDroppedManagedDatabaseResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _restorableDroppedManagedDatabaseRestClient.CreateListByInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _restorableDroppedManagedDatabaseRestClient.CreateListByInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new RestorableDroppedManagedDatabaseResource(Client, RestorableDroppedManagedDatabaseData.DeserializeRestorableDroppedManagedDatabaseData(e)), _restorableDroppedManagedDatabaseClientDiagnostics, Pipeline, "RestorableDroppedManagedDatabaseCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedManagedDatabases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorableDroppedDatabaseId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorableDroppedDatabaseId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedDatabaseId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string restorableDroppedDatabaseId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorableDroppedDatabaseId, nameof(restorableDroppedDatabaseId));

            using var scope = _restorableDroppedManagedDatabaseClientDiagnostics.CreateScope("RestorableDroppedManagedDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = await _restorableDroppedManagedDatabaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorableDroppedDatabaseId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedManagedDatabases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorableDroppedDatabaseId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorableDroppedDatabaseId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedDatabaseId"/> is null. </exception>
        public virtual Response<bool> Exists(string restorableDroppedDatabaseId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorableDroppedDatabaseId, nameof(restorableDroppedDatabaseId));

            using var scope = _restorableDroppedManagedDatabaseClientDiagnostics.CreateScope("RestorableDroppedManagedDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = _restorableDroppedManagedDatabaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorableDroppedDatabaseId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedManagedDatabases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorableDroppedDatabaseId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorableDroppedDatabaseId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedDatabaseId"/> is null. </exception>
        public virtual async Task<NullableResponse<RestorableDroppedManagedDatabaseResource>> GetIfExistsAsync(string restorableDroppedDatabaseId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorableDroppedDatabaseId, nameof(restorableDroppedDatabaseId));

            using var scope = _restorableDroppedManagedDatabaseClientDiagnostics.CreateScope("RestorableDroppedManagedDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _restorableDroppedManagedDatabaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorableDroppedDatabaseId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RestorableDroppedManagedDatabaseResource>(response.GetRawResponse());
                return Response.FromValue(new RestorableDroppedManagedDatabaseResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedManagedDatabases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorableDroppedDatabaseId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorableDroppedDatabaseId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedDatabaseId"/> is null. </exception>
        public virtual NullableResponse<RestorableDroppedManagedDatabaseResource> GetIfExists(string restorableDroppedDatabaseId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorableDroppedDatabaseId, nameof(restorableDroppedDatabaseId));

            using var scope = _restorableDroppedManagedDatabaseClientDiagnostics.CreateScope("RestorableDroppedManagedDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _restorableDroppedManagedDatabaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorableDroppedDatabaseId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RestorableDroppedManagedDatabaseResource>(response.GetRawResponse());
                return Response.FromValue(new RestorableDroppedManagedDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RestorableDroppedManagedDatabaseResource> IEnumerable<RestorableDroppedManagedDatabaseResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RestorableDroppedManagedDatabaseResource> IAsyncEnumerable<RestorableDroppedManagedDatabaseResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
