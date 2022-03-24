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

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualDesktopResource" /> and their operations.
    /// Each <see cref="VirtualDesktopResource" /> in the collection will belong to the same instance of <see cref="VirtualApplicationGroupResource" />.
    /// To get a <see cref="VirtualDesktopCollection" /> instance call the GetVirtualDesktops method from an instance of <see cref="VirtualApplicationGroupResource" />.
    /// </summary>
    public partial class VirtualDesktopCollection : ArmCollection, IEnumerable<VirtualDesktopResource>, IAsyncEnumerable<VirtualDesktopResource>
    {
        private readonly ClientDiagnostics _virtualDesktopDesktopsClientDiagnostics;
        private readonly DesktopsRestOperations _virtualDesktopDesktopsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualDesktopCollection"/> class for mocking. </summary>
        protected VirtualDesktopCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualDesktopCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualDesktopCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualDesktopDesktopsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", VirtualDesktopResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualDesktopResource.ResourceType, out string virtualDesktopDesktopsApiVersion);
            _virtualDesktopDesktopsRestClient = new DesktopsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualDesktopDesktopsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualApplicationGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualApplicationGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a desktop.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops/{desktopName}
        /// Operation Id: Desktops_Get
        /// </summary>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="desktopName"/> is null. </exception>
        public virtual async Task<Response<VirtualDesktopResource>> GetAsync(string desktopName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));

            using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualDesktopDesktopsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, desktopName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualDesktopResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a desktop.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops/{desktopName}
        /// Operation Id: Desktops_Get
        /// </summary>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="desktopName"/> is null. </exception>
        public virtual Response<VirtualDesktopResource> Get(string desktopName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));

            using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualDesktopDesktopsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, desktopName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualDesktopResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List desktops.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops
        /// Operation Id: Desktops_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualDesktopResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualDesktopResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualDesktopResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualDesktopDesktopsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualDesktopResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// List desktops.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops
        /// Operation Id: Desktops_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualDesktopResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualDesktopResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualDesktopResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualDesktopDesktopsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualDesktopResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops/{desktopName}
        /// Operation Id: Desktops_Get
        /// </summary>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="desktopName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string desktopName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));

            using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(desktopName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops/{desktopName}
        /// Operation Id: Desktops_Get
        /// </summary>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="desktopName"/> is null. </exception>
        public virtual Response<bool> Exists(string desktopName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));

            using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(desktopName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops/{desktopName}
        /// Operation Id: Desktops_Get
        /// </summary>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="desktopName"/> is null. </exception>
        public virtual async Task<Response<VirtualDesktopResource>> GetIfExistsAsync(string desktopName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));

            using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualDesktopDesktopsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, desktopName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualDesktopResource>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualDesktopResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops/{desktopName}
        /// Operation Id: Desktops_Get
        /// </summary>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="desktopName"/> is null. </exception>
        public virtual Response<VirtualDesktopResource> GetIfExists(string desktopName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));

            using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualDesktopDesktopsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, desktopName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualDesktopResource>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualDesktopResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualDesktopResource> IEnumerable<VirtualDesktopResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualDesktopResource> IAsyncEnumerable<VirtualDesktopResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
