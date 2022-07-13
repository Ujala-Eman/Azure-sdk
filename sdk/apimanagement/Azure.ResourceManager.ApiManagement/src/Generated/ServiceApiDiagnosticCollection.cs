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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceApiDiagnosticResource" /> and their operations.
    /// Each <see cref="ServiceApiDiagnosticResource" /> in the collection will belong to the same instance of <see cref="ApiContractResource" />.
    /// To get a <see cref="ServiceApiDiagnosticCollection" /> instance call the GetServiceApiDiagnostics method from an instance of <see cref="ApiContractResource" />.
    /// </summary>
    public partial class ServiceApiDiagnosticCollection : ArmCollection, IEnumerable<ServiceApiDiagnosticResource>, IAsyncEnumerable<ServiceApiDiagnosticResource>
    {
        private readonly ClientDiagnostics _serviceApiDiagnosticApiDiagnosticClientDiagnostics;
        private readonly ApiDiagnosticRestOperations _serviceApiDiagnosticApiDiagnosticRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceApiDiagnosticCollection"/> class for mocking. </summary>
        protected ServiceApiDiagnosticCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceApiDiagnosticCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceApiDiagnosticCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceApiDiagnosticApiDiagnosticClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ServiceApiDiagnosticResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceApiDiagnosticResource.ResourceType, out string serviceApiDiagnosticApiDiagnosticApiVersion);
            _serviceApiDiagnosticApiDiagnosticRestClient = new ApiDiagnosticRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceApiDiagnosticApiDiagnosticApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiContractResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiContractResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new Diagnostic for an API or updates an existing one.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
        /// Operation Id: ApiDiagnostic_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="diagnosticId"> Diagnostic identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceApiDiagnosticResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string diagnosticId, DiagnosticContractData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticId, nameof(diagnosticId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceApiDiagnosticApiDiagnosticClientDiagnostics.CreateScope("ServiceApiDiagnosticCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceApiDiagnosticApiDiagnosticRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ServiceApiDiagnosticResource>(Response.FromValue(new ServiceApiDiagnosticResource(Client, response), response.GetRawResponse()));
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
        /// Creates a new Diagnostic for an API or updates an existing one.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
        /// Operation Id: ApiDiagnostic_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="diagnosticId"> Diagnostic identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceApiDiagnosticResource> CreateOrUpdate(WaitUntil waitUntil, string diagnosticId, DiagnosticContractData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticId, nameof(diagnosticId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceApiDiagnosticApiDiagnosticClientDiagnostics.CreateScope("ServiceApiDiagnosticCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceApiDiagnosticApiDiagnosticRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ServiceApiDiagnosticResource>(Response.FromValue(new ServiceApiDiagnosticResource(Client, response), response.GetRawResponse()));
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
        /// Gets the details of the Diagnostic for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
        /// Operation Id: ApiDiagnostic_Get
        /// </summary>
        /// <param name="diagnosticId"> Diagnostic identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticId"/> is null. </exception>
        public virtual async Task<Response<ServiceApiDiagnosticResource>> GetAsync(string diagnosticId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticId, nameof(diagnosticId));

            using var scope = _serviceApiDiagnosticApiDiagnosticClientDiagnostics.CreateScope("ServiceApiDiagnosticCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceApiDiagnosticApiDiagnosticRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceApiDiagnosticResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the Diagnostic for an API specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
        /// Operation Id: ApiDiagnostic_Get
        /// </summary>
        /// <param name="diagnosticId"> Diagnostic identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticId"/> is null. </exception>
        public virtual Response<ServiceApiDiagnosticResource> Get(string diagnosticId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticId, nameof(diagnosticId));

            using var scope = _serviceApiDiagnosticApiDiagnosticClientDiagnostics.CreateScope("ServiceApiDiagnosticCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceApiDiagnosticApiDiagnosticRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceApiDiagnosticResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all diagnostics of an API.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics
        /// Operation Id: ApiDiagnostic_ListByService
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceApiDiagnosticResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceApiDiagnosticResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ServiceApiDiagnosticResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceApiDiagnosticApiDiagnosticClientDiagnostics.CreateScope("ServiceApiDiagnosticCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceApiDiagnosticApiDiagnosticRestClient.ListByServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceApiDiagnosticResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServiceApiDiagnosticResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serviceApiDiagnosticApiDiagnosticClientDiagnostics.CreateScope("ServiceApiDiagnosticCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceApiDiagnosticApiDiagnosticRestClient.ListByServiceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceApiDiagnosticResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all diagnostics of an API.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics
        /// Operation Id: ApiDiagnostic_ListByService
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceApiDiagnosticResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceApiDiagnosticResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            Page<ServiceApiDiagnosticResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceApiDiagnosticApiDiagnosticClientDiagnostics.CreateScope("ServiceApiDiagnosticCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceApiDiagnosticApiDiagnosticRestClient.ListByService(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceApiDiagnosticResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServiceApiDiagnosticResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serviceApiDiagnosticApiDiagnosticClientDiagnostics.CreateScope("ServiceApiDiagnosticCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceApiDiagnosticApiDiagnosticRestClient.ListByServiceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceApiDiagnosticResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
        /// Operation Id: ApiDiagnostic_Get
        /// </summary>
        /// <param name="diagnosticId"> Diagnostic identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string diagnosticId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticId, nameof(diagnosticId));

            using var scope = _serviceApiDiagnosticApiDiagnosticClientDiagnostics.CreateScope("ServiceApiDiagnosticCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceApiDiagnosticApiDiagnosticRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
        /// Operation Id: ApiDiagnostic_Get
        /// </summary>
        /// <param name="diagnosticId"> Diagnostic identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticId"/> is null. </exception>
        public virtual Response<bool> Exists(string diagnosticId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticId, nameof(diagnosticId));

            using var scope = _serviceApiDiagnosticApiDiagnosticClientDiagnostics.CreateScope("ServiceApiDiagnosticCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceApiDiagnosticApiDiagnosticRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceApiDiagnosticResource> IEnumerable<ServiceApiDiagnosticResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceApiDiagnosticResource> IAsyncEnumerable<ServiceApiDiagnosticResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
