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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of GalleryApplication and their operations over its parent. </summary>
    public partial class GalleryApplicationCollection : ArmCollection, IEnumerable<GalleryApplication>, IAsyncEnumerable<GalleryApplication>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly GalleryApplicationsRestOperations _galleryApplicationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="GalleryApplicationCollection"/> class for mocking. </summary>
        protected GalleryApplicationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GalleryApplicationCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal GalleryApplicationCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(GalleryApplication.ResourceType, out string apiVersion);
            _galleryApplicationsRestClient = new GalleryApplicationsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Gallery.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Gallery.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Create or update a gallery Application Definition. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryApplication"> Parameters supplied to the create or update gallery Application operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> or <paramref name="galleryApplication"/> is null. </exception>
        public virtual GalleryApplicationCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string galleryApplicationName, GalleryApplicationData galleryApplication, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryApplicationName, nameof(galleryApplicationName));
            if (galleryApplication == null)
            {
                throw new ArgumentNullException(nameof(galleryApplication));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _galleryApplicationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryApplicationName, galleryApplication, cancellationToken);
                var operation = new GalleryApplicationCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _galleryApplicationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryApplicationName, galleryApplication).Request, response);
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

        /// <summary> Create or update a gallery Application Definition. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryApplication"> Parameters supplied to the create or update gallery Application operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> or <paramref name="galleryApplication"/> is null. </exception>
        public async virtual Task<GalleryApplicationCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string galleryApplicationName, GalleryApplicationData galleryApplication, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryApplicationName, nameof(galleryApplicationName));
            if (galleryApplication == null)
            {
                throw new ArgumentNullException(nameof(galleryApplication));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _galleryApplicationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryApplicationName, galleryApplication, cancellationToken).ConfigureAwait(false);
                var operation = new GalleryApplicationCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _galleryApplicationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryApplicationName, galleryApplication).Request, response);
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

        /// <summary> Retrieves information about a gallery Application Definition. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> is null. </exception>
        public virtual Response<GalleryApplication> Get(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryApplicationName, nameof(galleryApplicationName));

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.Get");
            scope.Start();
            try
            {
                var response = _galleryApplicationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryApplicationName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GalleryApplication(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about a gallery Application Definition. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> is null. </exception>
        public async virtual Task<Response<GalleryApplication>> GetAsync(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryApplicationName, nameof(galleryApplicationName));

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.Get");
            scope.Start();
            try
            {
                var response = await _galleryApplicationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryApplicationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new GalleryApplication(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> is null. </exception>
        public virtual Response<GalleryApplication> GetIfExists(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryApplicationName, nameof(galleryApplicationName));

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _galleryApplicationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryApplicationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<GalleryApplication>(null, response.GetRawResponse());
                return Response.FromValue(new GalleryApplication(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> is null. </exception>
        public async virtual Task<Response<GalleryApplication>> GetIfExistsAsync(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryApplicationName, nameof(galleryApplicationName));

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _galleryApplicationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryApplicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<GalleryApplication>(null, response.GetRawResponse());
                return Response.FromValue(new GalleryApplication(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> is null. </exception>
        public virtual Response<bool> Exists(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryApplicationName, nameof(galleryApplicationName));

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(galleryApplicationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryApplicationName, nameof(galleryApplicationName));

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(galleryApplicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List gallery Application Definitions in a gallery. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GalleryApplication" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GalleryApplication> GetAll(CancellationToken cancellationToken = default)
        {
            Page<GalleryApplication> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _galleryApplicationsRestClient.ListByGallery(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryApplication(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<GalleryApplication> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _galleryApplicationsRestClient.ListByGalleryNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryApplication(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List gallery Application Definitions in a gallery. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GalleryApplication" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GalleryApplication> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GalleryApplication>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _galleryApplicationsRestClient.ListByGalleryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryApplication(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<GalleryApplication>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryApplicationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _galleryApplicationsRestClient.ListByGalleryNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryApplication(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<GalleryApplication> IEnumerable<GalleryApplication>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GalleryApplication> IAsyncEnumerable<GalleryApplication>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, GalleryApplication, GalleryApplicationData> Construct() { }
    }
}
