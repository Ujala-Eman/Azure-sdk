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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of Gallery and their operations over its parent. </summary>
    public partial class GalleryCollection : ArmCollection, IEnumerable<Gallery>, IAsyncEnumerable<Gallery>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly GalleriesRestOperations _galleriesRestClient;

        /// <summary> Initializes a new instance of the <see cref="GalleryCollection"/> class for mocking. </summary>
        protected GalleryCollection()
        {
        }

        /// <summary> Initializes a new instance of GalleryCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal GalleryCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _galleriesRestClient = new GalleriesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Galleries_CreateOrUpdate
        /// <summary> Create or update a Shared Image Gallery. </summary>
        /// <param name="galleryName"> The name of the Shared Image Gallery. The allowed characters are alphabets and numbers with dots and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="gallery"> Parameters supplied to the create or update Shared Image Gallery operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryName"/> or <paramref name="gallery"/> is null. </exception>
        public virtual GalleryCreateOrUpdateOperation CreateOrUpdate(string galleryName, GalleryData gallery, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (gallery == null)
            {
                throw new ArgumentNullException(nameof(gallery));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _galleriesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, galleryName, gallery, cancellationToken);
                var operation = new GalleryCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _galleriesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, galleryName, gallery).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Galleries_CreateOrUpdate
        /// <summary> Create or update a Shared Image Gallery. </summary>
        /// <param name="galleryName"> The name of the Shared Image Gallery. The allowed characters are alphabets and numbers with dots and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="gallery"> Parameters supplied to the create or update Shared Image Gallery operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryName"/> or <paramref name="gallery"/> is null. </exception>
        public async virtual Task<GalleryCreateOrUpdateOperation> CreateOrUpdateAsync(string galleryName, GalleryData gallery, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (gallery == null)
            {
                throw new ArgumentNullException(nameof(gallery));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _galleriesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, galleryName, gallery, cancellationToken).ConfigureAwait(false);
                var operation = new GalleryCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _galleriesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, galleryName, gallery).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Galleries_Get
        /// <summary> Retrieves information about a Shared Image Gallery. </summary>
        /// <param name="galleryName"> The name of the Shared Image Gallery. </param>
        /// <param name="select"> The select expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryName"/> is null. </exception>
        public virtual Response<Gallery> Get(string galleryName, SelectPermissions? select = null, CancellationToken cancellationToken = default)
        {
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryCollection.Get");
            scope.Start();
            try
            {
                var response = _galleriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, galleryName, select, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Gallery(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Galleries_Get
        /// <summary> Retrieves information about a Shared Image Gallery. </summary>
        /// <param name="galleryName"> The name of the Shared Image Gallery. </param>
        /// <param name="select"> The select expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryName"/> is null. </exception>
        public async virtual Task<Response<Gallery>> GetAsync(string galleryName, SelectPermissions? select = null, CancellationToken cancellationToken = default)
        {
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryCollection.Get");
            scope.Start();
            try
            {
                var response = await _galleriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, galleryName, select, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Gallery(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryName"> The name of the Shared Image Gallery. </param>
        /// <param name="select"> The select expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryName"/> is null. </exception>
        public virtual Response<Gallery> GetIfExists(string galleryName, SelectPermissions? select = null, CancellationToken cancellationToken = default)
        {
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _galleriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, galleryName, select, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<Gallery>(null, response.GetRawResponse())
                    : Response.FromValue(new Gallery(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryName"> The name of the Shared Image Gallery. </param>
        /// <param name="select"> The select expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryName"/> is null. </exception>
        public async virtual Task<Response<Gallery>> GetIfExistsAsync(string galleryName, SelectPermissions? select = null, CancellationToken cancellationToken = default)
        {
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _galleriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, galleryName, select, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<Gallery>(null, response.GetRawResponse())
                    : Response.FromValue(new Gallery(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryName"> The name of the Shared Image Gallery. </param>
        /// <param name="select"> The select expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryName"/> is null. </exception>
        public virtual Response<bool> Exists(string galleryName, SelectPermissions? select = null, CancellationToken cancellationToken = default)
        {
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(galleryName, select, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryName"> The name of the Shared Image Gallery. </param>
        /// <param name="select"> The select expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string galleryName, SelectPermissions? select = null, CancellationToken cancellationToken = default)
        {
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(galleryName, select, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Galleries_ListByResourceGroup
        /// <summary> List galleries under a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Gallery" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Gallery> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Gallery> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _galleriesRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Gallery(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Gallery> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _galleriesRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Gallery(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Galleries_ListByResourceGroup
        /// <summary> List galleries under a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Gallery" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Gallery> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Gallery>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _galleriesRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Gallery(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Gallery>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _galleriesRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Gallery(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="Gallery" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Gallery.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Gallery" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Gallery.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Gallery> IEnumerable<Gallery>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Gallery> IAsyncEnumerable<Gallery>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, Gallery, GalleryData> Construct() { }
    }
}
