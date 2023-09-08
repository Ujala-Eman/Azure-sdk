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

namespace Azure.ResourceManager.Media
{
    /// <summary>
    /// A class representing a collection of <see cref="MediaLiveEventResource" /> and their operations.
    /// Each <see cref="MediaLiveEventResource" /> in the collection will belong to the same instance of <see cref="MediaServicesAccountResource" />.
    /// To get a <see cref="MediaLiveEventCollection" /> instance call the GetMediaLiveEvents method from an instance of <see cref="MediaServicesAccountResource" />.
    /// </summary>
    public partial class MediaLiveEventCollection : ArmCollection, IEnumerable<MediaLiveEventResource>, IAsyncEnumerable<MediaLiveEventResource>
    {
        private readonly ClientDiagnostics _mediaLiveEventLiveEventsClientDiagnostics;
        private readonly LiveEventsRestOperations _mediaLiveEventLiveEventsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MediaLiveEventCollection"/> class for mocking. </summary>
        protected MediaLiveEventCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MediaLiveEventCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MediaLiveEventCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mediaLiveEventLiveEventsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Media", MediaLiveEventResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MediaLiveEventResource.ResourceType, out string mediaLiveEventLiveEventsApiVersion);
            _mediaLiveEventLiveEventsRestClient = new LiveEventsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mediaLiveEventLiveEventsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MediaServicesAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MediaServicesAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new live event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents/{liveEventName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LiveEvents_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="data"> Live event properties needed for creation. </param>
        /// <param name="autoStart"> The flag indicates if the resource should be automatically started on creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="liveEventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="liveEventName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MediaLiveEventResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string liveEventName, MediaLiveEventData data, bool? autoStart = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mediaLiveEventLiveEventsClientDiagnostics.CreateScope("MediaLiveEventCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mediaLiveEventLiveEventsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, liveEventName, data, autoStart, cancellationToken).ConfigureAwait(false);
                var operation = new MediaArmOperation<MediaLiveEventResource>(new MediaLiveEventOperationSource(Client), _mediaLiveEventLiveEventsClientDiagnostics, Pipeline, _mediaLiveEventLiveEventsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, liveEventName, data, autoStart).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a new live event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents/{liveEventName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LiveEvents_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="data"> Live event properties needed for creation. </param>
        /// <param name="autoStart"> The flag indicates if the resource should be automatically started on creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="liveEventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="liveEventName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MediaLiveEventResource> CreateOrUpdate(WaitUntil waitUntil, string liveEventName, MediaLiveEventData data, bool? autoStart = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mediaLiveEventLiveEventsClientDiagnostics.CreateScope("MediaLiveEventCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mediaLiveEventLiveEventsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, liveEventName, data, autoStart, cancellationToken);
                var operation = new MediaArmOperation<MediaLiveEventResource>(new MediaLiveEventOperationSource(Client), _mediaLiveEventLiveEventsClientDiagnostics, Pipeline, _mediaLiveEventLiveEventsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, liveEventName, data, autoStart).Request, response, OperationFinalStateVia.Location);
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
        /// Gets properties of a live event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents/{liveEventName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LiveEvents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="liveEventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="liveEventName"/> is null. </exception>
        public virtual async Task<Response<MediaLiveEventResource>> GetAsync(string liveEventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));

            using var scope = _mediaLiveEventLiveEventsClientDiagnostics.CreateScope("MediaLiveEventCollection.Get");
            scope.Start();
            try
            {
                var response = await _mediaLiveEventLiveEventsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, liveEventName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MediaLiveEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets properties of a live event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents/{liveEventName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LiveEvents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="liveEventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="liveEventName"/> is null. </exception>
        public virtual Response<MediaLiveEventResource> Get(string liveEventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));

            using var scope = _mediaLiveEventLiveEventsClientDiagnostics.CreateScope("MediaLiveEventCollection.Get");
            scope.Start();
            try
            {
                var response = _mediaLiveEventLiveEventsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, liveEventName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MediaLiveEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the live events in the account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LiveEvents_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MediaLiveEventResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MediaLiveEventResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mediaLiveEventLiveEventsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mediaLiveEventLiveEventsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MediaLiveEventResource(Client, MediaLiveEventData.DeserializeMediaLiveEventData(e)), _mediaLiveEventLiveEventsClientDiagnostics, Pipeline, "MediaLiveEventCollection.GetAll", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the live events in the account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LiveEvents_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MediaLiveEventResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MediaLiveEventResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mediaLiveEventLiveEventsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mediaLiveEventLiveEventsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MediaLiveEventResource(Client, MediaLiveEventData.DeserializeMediaLiveEventData(e)), _mediaLiveEventLiveEventsClientDiagnostics, Pipeline, "MediaLiveEventCollection.GetAll", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents/{liveEventName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LiveEvents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="liveEventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="liveEventName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string liveEventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));

            using var scope = _mediaLiveEventLiveEventsClientDiagnostics.CreateScope("MediaLiveEventCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mediaLiveEventLiveEventsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, liveEventName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents/{liveEventName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LiveEvents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="liveEventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="liveEventName"/> is null. </exception>
        public virtual Response<bool> Exists(string liveEventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));

            using var scope = _mediaLiveEventLiveEventsClientDiagnostics.CreateScope("MediaLiveEventCollection.Exists");
            scope.Start();
            try
            {
                var response = _mediaLiveEventLiveEventsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, liveEventName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MediaLiveEventResource> IEnumerable<MediaLiveEventResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MediaLiveEventResource> IAsyncEnumerable<MediaLiveEventResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
