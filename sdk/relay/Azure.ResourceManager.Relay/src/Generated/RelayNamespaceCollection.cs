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

namespace Azure.ResourceManager.Relay
{
    /// <summary>
    /// A class representing a collection of <see cref="RelayNamespaceResource"/> and their operations.
    /// Each <see cref="RelayNamespaceResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="RelayNamespaceCollection"/> instance call the GetRelayNamespaces method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class RelayNamespaceCollection : ArmCollection, IEnumerable<RelayNamespaceResource>, IAsyncEnumerable<RelayNamespaceResource>
    {
        private readonly ClientDiagnostics _relayNamespaceNamespacesClientDiagnostics;
        private readonly NamespacesRestOperations _relayNamespaceNamespacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="RelayNamespaceCollection"/> class for mocking. </summary>
        protected RelayNamespaceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RelayNamespaceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RelayNamespaceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _relayNamespaceNamespacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Relay", RelayNamespaceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RelayNamespaceResource.ResourceType, out string relayNamespaceNamespacesApiVersion);
            _relayNamespaceNamespacesRestClient = new NamespacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, relayNamespaceNamespacesApiVersion);
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
        /// Create Azure Relay namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="data"> Parameters supplied to create a namespace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RelayNamespaceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string namespaceName, RelayNamespaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _relayNamespaceNamespacesClientDiagnostics.CreateScope("RelayNamespaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _relayNamespaceNamespacesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new RelayArmOperation<RelayNamespaceResource>(new RelayNamespaceOperationSource(Client), _relayNamespaceNamespacesClientDiagnostics, Pipeline, _relayNamespaceNamespacesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create Azure Relay namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="data"> Parameters supplied to create a namespace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RelayNamespaceResource> CreateOrUpdate(WaitUntil waitUntil, string namespaceName, RelayNamespaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _relayNamespaceNamespacesClientDiagnostics.CreateScope("RelayNamespaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _relayNamespaceNamespacesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, data, cancellationToken);
                var operation = new RelayArmOperation<RelayNamespaceResource>(new RelayNamespaceOperationSource(Client), _relayNamespaceNamespacesClientDiagnostics, Pipeline, _relayNamespaceNamespacesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Returns the description for the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual async Task<Response<RelayNamespaceResource>> GetAsync(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _relayNamespaceNamespacesClientDiagnostics.CreateScope("RelayNamespaceCollection.Get");
            scope.Start();
            try
            {
                var response = await _relayNamespaceNamespacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RelayNamespaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the description for the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual Response<RelayNamespaceResource> Get(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _relayNamespaceNamespacesClientDiagnostics.CreateScope("RelayNamespaceCollection.Get");
            scope.Start();
            try
            {
                var response = _relayNamespaceNamespacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RelayNamespaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the available namespaces within the ResourceGroup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RelayNamespaceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RelayNamespaceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _relayNamespaceNamespacesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _relayNamespaceNamespacesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new RelayNamespaceResource(Client, RelayNamespaceData.DeserializeRelayNamespaceData(e)), _relayNamespaceNamespacesClientDiagnostics, Pipeline, "RelayNamespaceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the available namespaces within the ResourceGroup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RelayNamespaceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RelayNamespaceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _relayNamespaceNamespacesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _relayNamespaceNamespacesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new RelayNamespaceResource(Client, RelayNamespaceData.DeserializeRelayNamespaceData(e)), _relayNamespaceNamespacesClientDiagnostics, Pipeline, "RelayNamespaceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _relayNamespaceNamespacesClientDiagnostics.CreateScope("RelayNamespaceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _relayNamespaceNamespacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _relayNamespaceNamespacesClientDiagnostics.CreateScope("RelayNamespaceCollection.Exists");
            scope.Start();
            try
            {
                var response = _relayNamespaceNamespacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual async Task<NullableResponse<RelayNamespaceResource>> GetIfExistsAsync(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _relayNamespaceNamespacesClientDiagnostics.CreateScope("RelayNamespaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _relayNamespaceNamespacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RelayNamespaceResource>(response.GetRawResponse());
                return Response.FromValue(new RelayNamespaceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual NullableResponse<RelayNamespaceResource> GetIfExists(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _relayNamespaceNamespacesClientDiagnostics.CreateScope("RelayNamespaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _relayNamespaceNamespacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RelayNamespaceResource>(response.GetRawResponse());
                return Response.FromValue(new RelayNamespaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RelayNamespaceResource> IEnumerable<RelayNamespaceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RelayNamespaceResource> IAsyncEnumerable<RelayNamespaceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
