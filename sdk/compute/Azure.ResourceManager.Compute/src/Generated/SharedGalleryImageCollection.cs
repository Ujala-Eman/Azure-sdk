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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of SharedGalleryImage and their operations over its parent. </summary>
    public partial class SharedGalleryImageCollection : ArmCollection, IEnumerable<SharedGalleryImage>, IAsyncEnumerable<SharedGalleryImage>
    {
        private readonly ClientDiagnostics _sharedGalleryImageClientDiagnostics;
        private readonly SharedGalleryImagesRestOperations _sharedGalleryImageRestClient;

        /// <summary> Initializes a new instance of the <see cref="SharedGalleryImageCollection"/> class for mocking. </summary>
        protected SharedGalleryImageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SharedGalleryImageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SharedGalleryImageCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sharedGalleryImageClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", SharedGalleryImage.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(SharedGalleryImage.ResourceType, out string sharedGalleryImageApiVersion);
            _sharedGalleryImageRestClient = new SharedGalleryImagesRestOperations(_sharedGalleryImageClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, sharedGalleryImageApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SharedGallery.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SharedGallery.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a shared gallery image by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}
        /// Operation Id: SharedGalleryImages_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public async virtual Task<Response<SharedGalleryImage>> GetAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _sharedGalleryImageClientDiagnostics.CreateScope("SharedGalleryImageCollection.Get");
            scope.Start();
            try
            {
                var response = await _sharedGalleryImageRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, galleryImageName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _sharedGalleryImageClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                response.Value.Id = SharedGalleryImage.CreateResourceIdentifier(Id.SubscriptionId, Id.Parent.Name, Id.Name, galleryImageName);
                return Response.FromValue(new SharedGalleryImage(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a shared gallery image by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}
        /// Operation Id: SharedGalleryImages_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual Response<SharedGalleryImage> Get(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _sharedGalleryImageClientDiagnostics.CreateScope("SharedGalleryImageCollection.Get");
            scope.Start();
            try
            {
                var response = _sharedGalleryImageRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, galleryImageName, cancellationToken);
                if (response.Value == null)
                    throw _sharedGalleryImageClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                response.Value.Id = SharedGalleryImage.CreateResourceIdentifier(Id.SubscriptionId, Id.Parent.Name, Id.Name, galleryImageName);
                return Response.FromValue(new SharedGalleryImage(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List shared gallery images by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images
        /// Operation Id: SharedGalleryImages_List
        /// </summary>
        /// <param name="sharedTo"> The query parameter to decide what shared galleries to fetch when doing listing operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SharedGalleryImage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SharedGalleryImage> GetAllAsync(SharedToValues? sharedTo = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SharedGalleryImage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sharedGalleryImageClientDiagnostics.CreateScope("SharedGalleryImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sharedGalleryImageRestClient.ListAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, sharedTo, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value =>
                    {
                        value.Id = SharedGalleryImage.CreateResourceIdentifier(Id.SubscriptionId, Id.Parent.Name, Id.Name, value.Name);
                        return new SharedGalleryImage(Client, value);
                    }
                    ), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SharedGalleryImage>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sharedGalleryImageClientDiagnostics.CreateScope("SharedGalleryImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sharedGalleryImageRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name, sharedTo, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value =>
                    {
                        value.Id = SharedGalleryImage.CreateResourceIdentifier(Id.SubscriptionId, Id.Parent.Name, Id.Name, value.Name);
                        return new SharedGalleryImage(Client, value);
                    }
                    ), response.Value.NextLink, response.GetRawResponse());
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
        /// List shared gallery images by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images
        /// Operation Id: SharedGalleryImages_List
        /// </summary>
        /// <param name="sharedTo"> The query parameter to decide what shared galleries to fetch when doing listing operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SharedGalleryImage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SharedGalleryImage> GetAll(SharedToValues? sharedTo = null, CancellationToken cancellationToken = default)
        {
            Page<SharedGalleryImage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sharedGalleryImageClientDiagnostics.CreateScope("SharedGalleryImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sharedGalleryImageRestClient.List(Id.SubscriptionId, Id.Parent.Name, Id.Name, sharedTo, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value =>
                    {
                        value.Id = SharedGalleryImage.CreateResourceIdentifier(Id.SubscriptionId, Id.Parent.Name, Id.Name, value.Name);
                        return new SharedGalleryImage(Client, value);
                    }
                    ), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SharedGalleryImage> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sharedGalleryImageClientDiagnostics.CreateScope("SharedGalleryImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sharedGalleryImageRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name, sharedTo, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value =>
                    {
                        value.Id = SharedGalleryImage.CreateResourceIdentifier(Id.SubscriptionId, Id.Parent.Name, Id.Name, value.Name);
                        return new SharedGalleryImage(Client, value);
                    }
                    ), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}
        /// Operation Id: SharedGalleryImages_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _sharedGalleryImageClientDiagnostics.CreateScope("SharedGalleryImageCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(galleryImageName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}
        /// Operation Id: SharedGalleryImages_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual Response<bool> Exists(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _sharedGalleryImageClientDiagnostics.CreateScope("SharedGalleryImageCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(galleryImageName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}
        /// Operation Id: SharedGalleryImages_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public async virtual Task<Response<SharedGalleryImage>> GetIfExistsAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _sharedGalleryImageClientDiagnostics.CreateScope("SharedGalleryImageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sharedGalleryImageRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, galleryImageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SharedGalleryImage>(null, response.GetRawResponse());
                response.Value.Id = SharedGalleryImage.CreateResourceIdentifier(Id.SubscriptionId, Id.Parent.Name, Id.Name, galleryImageName);
                return Response.FromValue(new SharedGalleryImage(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}
        /// Operation Id: SharedGalleryImages_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual Response<SharedGalleryImage> GetIfExists(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _sharedGalleryImageClientDiagnostics.CreateScope("SharedGalleryImageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sharedGalleryImageRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, galleryImageName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SharedGalleryImage>(null, response.GetRawResponse());
                response.Value.Id = SharedGalleryImage.CreateResourceIdentifier(Id.SubscriptionId, Id.Parent.Name, Id.Name, galleryImageName);
                return Response.FromValue(new SharedGalleryImage(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SharedGalleryImage> IEnumerable<SharedGalleryImage>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SharedGalleryImage> IAsyncEnumerable<SharedGalleryImage>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
