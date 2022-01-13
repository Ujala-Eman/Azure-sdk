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
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class representing collection of DisasterRecovery and their operations over its parent. </summary>
    public partial class DisasterRecoveryCollection : ArmCollection, IEnumerable<DisasterRecovery>, IAsyncEnumerable<DisasterRecovery>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DisasterRecoveryConfigsRestOperations _disasterRecoveryConfigsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DisasterRecoveryCollection"/> class for mocking. </summary>
        protected DisasterRecoveryCollection()
        {
        }

        /// <summary> Initializes a new instance of DisasterRecoveryCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DisasterRecoveryCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _disasterRecoveryConfigsRestClient = new DisasterRecoveryConfigsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceBusNamespace.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceBusNamespace.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates a new Alias(Disaster Recovery configuration). </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="parameters"> Parameters required to create an Alias(Disaster Recovery configuration). </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> or <paramref name="parameters"/> is null. </exception>
        public virtual DisasterRecoveryConfigCreateOrUpdateOperation CreateOrUpdate(string @alias, DisasterRecoveryData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _disasterRecoveryConfigsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, parameters, cancellationToken);
                var operation = new DisasterRecoveryConfigCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Creates or updates a new Alias(Disaster Recovery configuration). </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="parameters"> Parameters required to create an Alias(Disaster Recovery configuration). </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<DisasterRecoveryConfigCreateOrUpdateOperation> CreateOrUpdateAsync(string @alias, DisasterRecoveryData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _disasterRecoveryConfigsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new DisasterRecoveryConfigCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Retrieves Alias(Disaster Recovery configuration) for primary or secondary namespace. </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public virtual Response<DisasterRecovery> Get(string @alias, CancellationToken cancellationToken = default)
        {
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }

            using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryCollection.Get");
            scope.Start();
            try
            {
                var response = _disasterRecoveryConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DisasterRecovery(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves Alias(Disaster Recovery configuration) for primary or secondary namespace. </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public async virtual Task<Response<DisasterRecovery>> GetAsync(string @alias, CancellationToken cancellationToken = default)
        {
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }

            using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryCollection.Get");
            scope.Start();
            try
            {
                var response = await _disasterRecoveryConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DisasterRecovery(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public virtual Response<DisasterRecovery> GetIfExists(string @alias, CancellationToken cancellationToken = default)
        {
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }

            using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _disasterRecoveryConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<DisasterRecovery>(null, response.GetRawResponse())
                    : Response.FromValue(new DisasterRecovery(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public async virtual Task<Response<DisasterRecovery>> GetIfExistsAsync(string @alias, CancellationToken cancellationToken = default)
        {
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }

            using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _disasterRecoveryConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<DisasterRecovery>(null, response.GetRawResponse())
                    : Response.FromValue(new DisasterRecovery(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public virtual Response<bool> Exists(string @alias, CancellationToken cancellationToken = default)
        {
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }

            using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(alias, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string @alias, CancellationToken cancellationToken = default)
        {
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }

            using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(alias, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all Alias(Disaster Recovery configurations). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DisasterRecovery" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DisasterRecovery> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DisasterRecovery> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _disasterRecoveryConfigsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DisasterRecovery(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DisasterRecovery> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _disasterRecoveryConfigsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DisasterRecovery(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all Alias(Disaster Recovery configurations). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DisasterRecovery" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DisasterRecovery> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DisasterRecovery>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _disasterRecoveryConfigsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DisasterRecovery(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DisasterRecovery>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _disasterRecoveryConfigsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DisasterRecovery(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<DisasterRecovery> IEnumerable<DisasterRecovery>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DisasterRecovery> IAsyncEnumerable<DisasterRecovery>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, DisasterRecovery, DisasterRecoveryData> Construct() { }
    }
}
