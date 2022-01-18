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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.DeviceUpdate.Models;

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary> A class representing collection of DeviceUpdateInstance and their operations over its parent. </summary>
    public partial class DeviceUpdateInstanceCollection : ArmCollection, IEnumerable<DeviceUpdateInstance>, IAsyncEnumerable<DeviceUpdateInstance>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DeviceUpdateInstancesRestOperations _deviceUpdateInstancesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeviceUpdateInstanceCollection"/> class for mocking. </summary>
        protected DeviceUpdateInstanceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceUpdateInstanceCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DeviceUpdateInstanceCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _deviceUpdateInstancesRestClient = new DeviceUpdateInstancesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DeviceUpdateAccount.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DeviceUpdateAccount.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates instance. </summary>
        /// <param name="instanceName"> Instance name. </param>
        /// <param name="instance"> Instance details. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> or <paramref name="instance"/> is null. </exception>
        public virtual DeviceUpdateInstanceCreateOperation CreateOrUpdate(bool waitForCompletion, string instanceName, DeviceUpdateInstanceData instance, CancellationToken cancellationToken = default)
        {
            if (instanceName == null)
            {
                throw new ArgumentNullException(nameof(instanceName));
            }
            if (instance == null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            using var scope = _clientDiagnostics.CreateScope("DeviceUpdateInstanceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _deviceUpdateInstancesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceName, instance, cancellationToken);
                var operation = new DeviceUpdateInstanceCreateOperation(Parent, _clientDiagnostics, Pipeline, _deviceUpdateInstancesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceName, instance).Request, response);
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

        /// <summary> Creates or updates instance. </summary>
        /// <param name="instanceName"> Instance name. </param>
        /// <param name="instance"> Instance details. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> or <paramref name="instance"/> is null. </exception>
        public async virtual Task<DeviceUpdateInstanceCreateOperation> CreateOrUpdateAsync(bool waitForCompletion, string instanceName, DeviceUpdateInstanceData instance, CancellationToken cancellationToken = default)
        {
            if (instanceName == null)
            {
                throw new ArgumentNullException(nameof(instanceName));
            }
            if (instance == null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            using var scope = _clientDiagnostics.CreateScope("DeviceUpdateInstanceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _deviceUpdateInstancesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceName, instance, cancellationToken).ConfigureAwait(false);
                var operation = new DeviceUpdateInstanceCreateOperation(Parent, _clientDiagnostics, Pipeline, _deviceUpdateInstancesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceName, instance).Request, response);
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

        /// <summary> Returns instance details for the given instance and account name. </summary>
        /// <param name="instanceName"> Instance name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> is null. </exception>
        public virtual Response<DeviceUpdateInstance> Get(string instanceName, CancellationToken cancellationToken = default)
        {
            if (instanceName == null)
            {
                throw new ArgumentNullException(nameof(instanceName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeviceUpdateInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = _deviceUpdateInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceUpdateInstance(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns instance details for the given instance and account name. </summary>
        /// <param name="instanceName"> Instance name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> is null. </exception>
        public async virtual Task<Response<DeviceUpdateInstance>> GetAsync(string instanceName, CancellationToken cancellationToken = default)
        {
            if (instanceName == null)
            {
                throw new ArgumentNullException(nameof(instanceName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeviceUpdateInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = await _deviceUpdateInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DeviceUpdateInstance(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceName"> Instance name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> is null. </exception>
        public virtual Response<DeviceUpdateInstance> GetIfExists(string instanceName, CancellationToken cancellationToken = default)
        {
            if (instanceName == null)
            {
                throw new ArgumentNullException(nameof(instanceName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeviceUpdateInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deviceUpdateInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DeviceUpdateInstance>(null, response.GetRawResponse());
                return Response.FromValue(new DeviceUpdateInstance(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceName"> Instance name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> is null. </exception>
        public async virtual Task<Response<DeviceUpdateInstance>> GetIfExistsAsync(string instanceName, CancellationToken cancellationToken = default)
        {
            if (instanceName == null)
            {
                throw new ArgumentNullException(nameof(instanceName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeviceUpdateInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _deviceUpdateInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DeviceUpdateInstance>(null, response.GetRawResponse());
                return Response.FromValue(new DeviceUpdateInstance(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceName"> Instance name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> is null. </exception>
        public virtual Response<bool> Exists(string instanceName, CancellationToken cancellationToken = default)
        {
            if (instanceName == null)
            {
                throw new ArgumentNullException(nameof(instanceName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeviceUpdateInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(instanceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceName"> Instance name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string instanceName, CancellationToken cancellationToken = default)
        {
            if (instanceName == null)
            {
                throw new ArgumentNullException(nameof(instanceName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeviceUpdateInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(instanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns instances for the given account name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeviceUpdateInstance" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeviceUpdateInstance> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DeviceUpdateInstance> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeviceUpdateInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _deviceUpdateInstancesRestClient.ListByAccount(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeviceUpdateInstance(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeviceUpdateInstance> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeviceUpdateInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _deviceUpdateInstancesRestClient.ListByAccountNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeviceUpdateInstance(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Returns instances for the given account name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeviceUpdateInstance" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeviceUpdateInstance> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeviceUpdateInstance>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeviceUpdateInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _deviceUpdateInstancesRestClient.ListByAccountAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeviceUpdateInstance(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeviceUpdateInstance>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeviceUpdateInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _deviceUpdateInstancesRestClient.ListByAccountNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeviceUpdateInstance(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<DeviceUpdateInstance> IEnumerable<DeviceUpdateInstance>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeviceUpdateInstance> IAsyncEnumerable<DeviceUpdateInstance>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, DeviceUpdateInstance, DeviceUpdateInstanceData> Construct() { }
    }
}
