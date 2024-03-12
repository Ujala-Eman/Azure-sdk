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

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing a collection of <see cref="MarketplaceGalleryImageResource"/> and their operations.
    /// Each <see cref="MarketplaceGalleryImageResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="MarketplaceGalleryImageCollection"/> instance call the GetMarketplaceGalleryImages method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class MarketplaceGalleryImageCollection : ArmCollection, IEnumerable<MarketplaceGalleryImageResource>, IAsyncEnumerable<MarketplaceGalleryImageResource>
    {
        private readonly ClientDiagnostics _marketplaceGalleryImageClientDiagnostics;
        private readonly MarketplaceGalleryImagesRestOperations _marketplaceGalleryImageRestClient;

        /// <summary> Initializes a new instance of the <see cref="MarketplaceGalleryImageCollection"/> class for mocking. </summary>
        protected MarketplaceGalleryImageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MarketplaceGalleryImageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MarketplaceGalleryImageCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _marketplaceGalleryImageClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Hci", MarketplaceGalleryImageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MarketplaceGalleryImageResource.ResourceType, out string marketplaceGalleryImageApiVersion);
            _marketplaceGalleryImageRestClient = new MarketplaceGalleryImagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, marketplaceGalleryImageApiVersion);
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
        /// The operation to create or update a marketplace gallery image. Please note some properties can be set only during marketplace gallery image creation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/marketplaceGalleryImages/{marketplaceGalleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceGalleryImages_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceGalleryImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="marketplaceGalleryImageName"> Name of the marketplace gallery image. </param>
        /// <param name="data"> The <see cref="MarketplaceGalleryImageData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceGalleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceGalleryImageName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MarketplaceGalleryImageResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string marketplaceGalleryImageName, MarketplaceGalleryImageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(marketplaceGalleryImageName, nameof(marketplaceGalleryImageName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _marketplaceGalleryImageClientDiagnostics.CreateScope("MarketplaceGalleryImageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _marketplaceGalleryImageRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, marketplaceGalleryImageName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HciArmOperation<MarketplaceGalleryImageResource>(new MarketplaceGalleryImageOperationSource(Client), _marketplaceGalleryImageClientDiagnostics, Pipeline, _marketplaceGalleryImageRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, marketplaceGalleryImageName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// The operation to create or update a marketplace gallery image. Please note some properties can be set only during marketplace gallery image creation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/marketplaceGalleryImages/{marketplaceGalleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceGalleryImages_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceGalleryImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="marketplaceGalleryImageName"> Name of the marketplace gallery image. </param>
        /// <param name="data"> The <see cref="MarketplaceGalleryImageData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceGalleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceGalleryImageName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MarketplaceGalleryImageResource> CreateOrUpdate(WaitUntil waitUntil, string marketplaceGalleryImageName, MarketplaceGalleryImageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(marketplaceGalleryImageName, nameof(marketplaceGalleryImageName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _marketplaceGalleryImageClientDiagnostics.CreateScope("MarketplaceGalleryImageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _marketplaceGalleryImageRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, marketplaceGalleryImageName, data, cancellationToken);
                var operation = new HciArmOperation<MarketplaceGalleryImageResource>(new MarketplaceGalleryImageOperationSource(Client), _marketplaceGalleryImageClientDiagnostics, Pipeline, _marketplaceGalleryImageRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, marketplaceGalleryImageName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets a marketplace gallery image
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/marketplaceGalleryImages/{marketplaceGalleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceGalleryImages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceGalleryImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="marketplaceGalleryImageName"> Name of the marketplace gallery image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceGalleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceGalleryImageName"/> is null. </exception>
        public virtual async Task<Response<MarketplaceGalleryImageResource>> GetAsync(string marketplaceGalleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(marketplaceGalleryImageName, nameof(marketplaceGalleryImageName));

            using var scope = _marketplaceGalleryImageClientDiagnostics.CreateScope("MarketplaceGalleryImageCollection.Get");
            scope.Start();
            try
            {
                var response = await _marketplaceGalleryImageRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, marketplaceGalleryImageName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MarketplaceGalleryImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a marketplace gallery image
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/marketplaceGalleryImages/{marketplaceGalleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceGalleryImages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceGalleryImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="marketplaceGalleryImageName"> Name of the marketplace gallery image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceGalleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceGalleryImageName"/> is null. </exception>
        public virtual Response<MarketplaceGalleryImageResource> Get(string marketplaceGalleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(marketplaceGalleryImageName, nameof(marketplaceGalleryImageName));

            using var scope = _marketplaceGalleryImageClientDiagnostics.CreateScope("MarketplaceGalleryImageCollection.Get");
            scope.Start();
            try
            {
                var response = _marketplaceGalleryImageRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, marketplaceGalleryImageName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MarketplaceGalleryImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the marketplace gallery images in the specified resource group. Use the nextLink property in the response to get the next page of marketplace gallery images.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/marketplaceGalleryImages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceGalleryImages_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceGalleryImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MarketplaceGalleryImageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MarketplaceGalleryImageResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _marketplaceGalleryImageRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _marketplaceGalleryImageRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MarketplaceGalleryImageResource(Client, MarketplaceGalleryImageData.DeserializeMarketplaceGalleryImageData(e)), _marketplaceGalleryImageClientDiagnostics, Pipeline, "MarketplaceGalleryImageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the marketplace gallery images in the specified resource group. Use the nextLink property in the response to get the next page of marketplace gallery images.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/marketplaceGalleryImages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceGalleryImages_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceGalleryImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MarketplaceGalleryImageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MarketplaceGalleryImageResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _marketplaceGalleryImageRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _marketplaceGalleryImageRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MarketplaceGalleryImageResource(Client, MarketplaceGalleryImageData.DeserializeMarketplaceGalleryImageData(e)), _marketplaceGalleryImageClientDiagnostics, Pipeline, "MarketplaceGalleryImageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/marketplaceGalleryImages/{marketplaceGalleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceGalleryImages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceGalleryImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="marketplaceGalleryImageName"> Name of the marketplace gallery image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceGalleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceGalleryImageName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string marketplaceGalleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(marketplaceGalleryImageName, nameof(marketplaceGalleryImageName));

            using var scope = _marketplaceGalleryImageClientDiagnostics.CreateScope("MarketplaceGalleryImageCollection.Exists");
            scope.Start();
            try
            {
                var response = await _marketplaceGalleryImageRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, marketplaceGalleryImageName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/marketplaceGalleryImages/{marketplaceGalleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceGalleryImages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceGalleryImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="marketplaceGalleryImageName"> Name of the marketplace gallery image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceGalleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceGalleryImageName"/> is null. </exception>
        public virtual Response<bool> Exists(string marketplaceGalleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(marketplaceGalleryImageName, nameof(marketplaceGalleryImageName));

            using var scope = _marketplaceGalleryImageClientDiagnostics.CreateScope("MarketplaceGalleryImageCollection.Exists");
            scope.Start();
            try
            {
                var response = _marketplaceGalleryImageRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, marketplaceGalleryImageName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/marketplaceGalleryImages/{marketplaceGalleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceGalleryImages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceGalleryImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="marketplaceGalleryImageName"> Name of the marketplace gallery image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceGalleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceGalleryImageName"/> is null. </exception>
        public virtual async Task<NullableResponse<MarketplaceGalleryImageResource>> GetIfExistsAsync(string marketplaceGalleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(marketplaceGalleryImageName, nameof(marketplaceGalleryImageName));

            using var scope = _marketplaceGalleryImageClientDiagnostics.CreateScope("MarketplaceGalleryImageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _marketplaceGalleryImageRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, marketplaceGalleryImageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MarketplaceGalleryImageResource>(response.GetRawResponse());
                return Response.FromValue(new MarketplaceGalleryImageResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/marketplaceGalleryImages/{marketplaceGalleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceGalleryImages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceGalleryImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="marketplaceGalleryImageName"> Name of the marketplace gallery image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceGalleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceGalleryImageName"/> is null. </exception>
        public virtual NullableResponse<MarketplaceGalleryImageResource> GetIfExists(string marketplaceGalleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(marketplaceGalleryImageName, nameof(marketplaceGalleryImageName));

            using var scope = _marketplaceGalleryImageClientDiagnostics.CreateScope("MarketplaceGalleryImageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _marketplaceGalleryImageRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, marketplaceGalleryImageName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MarketplaceGalleryImageResource>(response.GetRawResponse());
                return Response.FromValue(new MarketplaceGalleryImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MarketplaceGalleryImageResource> IEnumerable<MarketplaceGalleryImageResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MarketplaceGalleryImageResource> IAsyncEnumerable<MarketplaceGalleryImageResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
