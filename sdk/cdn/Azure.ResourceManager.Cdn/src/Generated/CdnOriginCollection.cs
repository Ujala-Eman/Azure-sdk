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
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing collection of CdnOrigin and their operations over its parent. </summary>
    public partial class CdnOriginCollection : ArmCollection, IEnumerable<CdnOrigin>, IAsyncEnumerable<CdnOrigin>
    {
        private readonly ClientDiagnostics _cdnOriginClientDiagnostics;
        private readonly CdnOriginsRestOperations _cdnOriginRestClient;

        /// <summary> Initializes a new instance of the <see cref="CdnOriginCollection"/> class for mocking. </summary>
        protected CdnOriginCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CdnOriginCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CdnOriginCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cdnOriginClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", CdnOrigin.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(CdnOrigin.ResourceType, out string cdnOriginApiVersion);
            _cdnOriginRestClient = new CdnOriginsRestOperations(_cdnOriginClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, cdnOriginApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CdnEndpoint.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CdnEndpoint.ResourceType), nameof(id));
        }

        /// <summary> Creates a new origin within the specified endpoint. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="originName"> Name of the origin that is unique within the endpoint. </param>
        /// <param name="origin"> Origin properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> or <paramref name="origin"/> is null. </exception>
        public async virtual Task<CdnOriginCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string originName, CdnOriginData origin, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));
            if (origin == null)
            {
                throw new ArgumentNullException(nameof(origin));
            }

            using var scope = _cdnOriginClientDiagnostics.CreateScope("CdnOriginCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cdnOriginRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, origin, cancellationToken).ConfigureAwait(false);
                var operation = new CdnOriginCreateOrUpdateOperation(Client, _cdnOriginClientDiagnostics, Pipeline, _cdnOriginRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, origin).Request, response);
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

        /// <summary> Creates a new origin within the specified endpoint. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="originName"> Name of the origin that is unique within the endpoint. </param>
        /// <param name="origin"> Origin properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> or <paramref name="origin"/> is null. </exception>
        public virtual CdnOriginCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string originName, CdnOriginData origin, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));
            if (origin == null)
            {
                throw new ArgumentNullException(nameof(origin));
            }

            using var scope = _cdnOriginClientDiagnostics.CreateScope("CdnOriginCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cdnOriginRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, origin, cancellationToken);
                var operation = new CdnOriginCreateOrUpdateOperation(Client, _cdnOriginClientDiagnostics, Pipeline, _cdnOriginRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, origin).Request, response);
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

        /// <summary> Gets an existing origin within an endpoint. </summary>
        /// <param name="originName"> Name of the origin which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public async virtual Task<Response<CdnOrigin>> GetAsync(string originName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));

            using var scope = _cdnOriginClientDiagnostics.CreateScope("CdnOriginCollection.Get");
            scope.Start();
            try
            {
                var response = await _cdnOriginRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _cdnOriginClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CdnOrigin(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing origin within an endpoint. </summary>
        /// <param name="originName"> Name of the origin which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public virtual Response<CdnOrigin> Get(string originName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));

            using var scope = _cdnOriginClientDiagnostics.CreateScope("CdnOriginCollection.Get");
            scope.Start();
            try
            {
                var response = _cdnOriginRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, cancellationToken);
                if (response.Value == null)
                    throw _cdnOriginClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CdnOrigin(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all of the existing origins within an endpoint. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CdnOrigin" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CdnOrigin> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CdnOrigin>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _cdnOriginClientDiagnostics.CreateScope("CdnOriginCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cdnOriginRestClient.ListByEndpointAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CdnOrigin(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CdnOrigin>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _cdnOriginClientDiagnostics.CreateScope("CdnOriginCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cdnOriginRestClient.ListByEndpointNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CdnOrigin(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all of the existing origins within an endpoint. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CdnOrigin" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CdnOrigin> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CdnOrigin> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _cdnOriginClientDiagnostics.CreateScope("CdnOriginCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cdnOriginRestClient.ListByEndpoint(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CdnOrigin(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CdnOrigin> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _cdnOriginClientDiagnostics.CreateScope("CdnOriginCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cdnOriginRestClient.ListByEndpointNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CdnOrigin(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="originName"> Name of the origin which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string originName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));

            using var scope = _cdnOriginClientDiagnostics.CreateScope("CdnOriginCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(originName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="originName"> Name of the origin which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public virtual Response<bool> Exists(string originName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));

            using var scope = _cdnOriginClientDiagnostics.CreateScope("CdnOriginCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(originName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="originName"> Name of the origin which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public async virtual Task<Response<CdnOrigin>> GetIfExistsAsync(string originName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));

            using var scope = _cdnOriginClientDiagnostics.CreateScope("CdnOriginCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cdnOriginRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<CdnOrigin>(null, response.GetRawResponse());
                return Response.FromValue(new CdnOrigin(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="originName"> Name of the origin which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public virtual Response<CdnOrigin> GetIfExists(string originName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));

            using var scope = _cdnOriginClientDiagnostics.CreateScope("CdnOriginCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cdnOriginRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<CdnOrigin>(null, response.GetRawResponse());
                return Response.FromValue(new CdnOrigin(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CdnOrigin> IEnumerable<CdnOrigin>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CdnOrigin> IAsyncEnumerable<CdnOrigin>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
