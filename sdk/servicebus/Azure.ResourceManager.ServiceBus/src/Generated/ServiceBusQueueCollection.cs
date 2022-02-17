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

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class representing collection of ServiceBusQueue and their operations over its parent. </summary>
    public partial class ServiceBusQueueCollection : ArmCollection, IEnumerable<ServiceBusQueue>, IAsyncEnumerable<ServiceBusQueue>
    {
        private readonly ClientDiagnostics _serviceBusQueueQueuesClientDiagnostics;
        private readonly QueuesRestOperations _serviceBusQueueQueuesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceBusQueueCollection"/> class for mocking. </summary>
        protected ServiceBusQueueCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceBusQueueCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceBusQueueCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceBusQueueQueuesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ServiceBusQueue.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ServiceBusQueue.ResourceType, out string serviceBusQueueQueuesApiVersion);
            _serviceBusQueueQueuesRestClient = new QueuesRestOperations(_serviceBusQueueQueuesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serviceBusQueueQueuesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceBusNamespace.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceBusNamespace.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a Service Bus queue. This operation is idempotent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}
        /// Operation Id: Queues_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="parameters"> Parameters supplied to create or update a queue resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<ServiceBusQueue>> CreateOrUpdateAsync(bool waitForCompletion, string queueName, ServiceBusQueueData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _serviceBusQueueQueuesClientDiagnostics.CreateScope("ServiceBusQueueCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceBusQueueQueuesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, queueName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation<ServiceBusQueue>(Response.FromValue(new ServiceBusQueue(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
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
        /// Creates or updates a Service Bus queue. This operation is idempotent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}
        /// Operation Id: Queues_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="parameters"> Parameters supplied to create or update a queue resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ServiceBusQueue> CreateOrUpdate(bool waitForCompletion, string queueName, ServiceBusQueueData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _serviceBusQueueQueuesClientDiagnostics.CreateScope("ServiceBusQueueCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceBusQueueQueuesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, queueName, parameters, cancellationToken);
                var operation = new ServiceBusArmOperation<ServiceBusQueue>(Response.FromValue(new ServiceBusQueue(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
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
        /// Returns a description for the specified queue.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}
        /// Operation Id: Queues_Get
        /// </summary>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public async virtual Task<Response<ServiceBusQueue>> GetAsync(string queueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));

            using var scope = _serviceBusQueueQueuesClientDiagnostics.CreateScope("ServiceBusQueueCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceBusQueueQueuesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, queueName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _serviceBusQueueQueuesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServiceBusQueue(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a description for the specified queue.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}
        /// Operation Id: Queues_Get
        /// </summary>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public virtual Response<ServiceBusQueue> Get(string queueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));

            using var scope = _serviceBusQueueQueuesClientDiagnostics.CreateScope("ServiceBusQueueCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceBusQueueQueuesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, queueName, cancellationToken);
                if (response.Value == null)
                    throw _serviceBusQueueQueuesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusQueue(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the queues within a namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues
        /// Operation Id: Queues_ListByNamespace
        /// </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceBusQueue" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceBusQueue> GetAllAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ServiceBusQueue>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceBusQueueQueuesClientDiagnostics.CreateScope("ServiceBusQueueCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceBusQueueQueuesRestClient.ListByNamespaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceBusQueue(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServiceBusQueue>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serviceBusQueueQueuesClientDiagnostics.CreateScope("ServiceBusQueueCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceBusQueueQueuesRestClient.ListByNamespaceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceBusQueue(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets the queues within a namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues
        /// Operation Id: Queues_ListByNamespace
        /// </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceBusQueue" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceBusQueue> GetAll(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<ServiceBusQueue> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceBusQueueQueuesClientDiagnostics.CreateScope("ServiceBusQueueCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceBusQueueQueuesRestClient.ListByNamespace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceBusQueue(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServiceBusQueue> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serviceBusQueueQueuesClientDiagnostics.CreateScope("ServiceBusQueueCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceBusQueueQueuesRestClient.ListByNamespaceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceBusQueue(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}
        /// Operation Id: Queues_Get
        /// </summary>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string queueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));

            using var scope = _serviceBusQueueQueuesClientDiagnostics.CreateScope("ServiceBusQueueCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(queueName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}
        /// Operation Id: Queues_Get
        /// </summary>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public virtual Response<bool> Exists(string queueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));

            using var scope = _serviceBusQueueQueuesClientDiagnostics.CreateScope("ServiceBusQueueCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(queueName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}
        /// Operation Id: Queues_Get
        /// </summary>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public async virtual Task<Response<ServiceBusQueue>> GetIfExistsAsync(string queueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));

            using var scope = _serviceBusQueueQueuesClientDiagnostics.CreateScope("ServiceBusQueueCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceBusQueueQueuesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, queueName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServiceBusQueue>(null, response.GetRawResponse());
                return Response.FromValue(new ServiceBusQueue(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}
        /// Operation Id: Queues_Get
        /// </summary>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public virtual Response<ServiceBusQueue> GetIfExists(string queueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));

            using var scope = _serviceBusQueueQueuesClientDiagnostics.CreateScope("ServiceBusQueueCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceBusQueueQueuesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, queueName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServiceBusQueue>(null, response.GetRawResponse());
                return Response.FromValue(new ServiceBusQueue(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceBusQueue> IEnumerable<ServiceBusQueue>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceBusQueue> IAsyncEnumerable<ServiceBusQueue>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
