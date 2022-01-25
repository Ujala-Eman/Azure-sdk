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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of HostNameBinding and their operations over its parent. </summary>
    public partial class SiteSlotHostNameBindingCollection : ArmCollection, IEnumerable<SiteSlotHostNameBinding>, IAsyncEnumerable<SiteSlotHostNameBinding>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotHostNameBindingCollection"/> class for mocking. </summary>
        protected SiteSlotHostNameBindingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotHostNameBindingCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteSlotHostNameBindingCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SiteSlotHostNameBinding.ResourceType, out string apiVersion);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlot.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlot.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hostNameBindings/{hostName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_CreateOrUpdateHostNameBindingSlot
        /// <summary> Description for Creates a hostname binding for an app. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="hostName"> Hostname in the hostname binding. </param>
        /// <param name="hostNameBinding"> Binding details. This is the JSON representation of a HostNameBinding object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> or <paramref name="hostNameBinding"/> is null. </exception>
        public virtual SiteSlotHostNameBindingCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string hostName, HostNameBindingData hostNameBinding, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));
            if (hostNameBinding == null)
            {
                throw new ArgumentNullException(nameof(hostNameBinding));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHostNameBindingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.CreateOrUpdateHostNameBindingSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hostName, hostNameBinding, cancellationToken);
                var operation = new SiteSlotHostNameBindingCreateOrUpdateOperation(this, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hostNameBindings/{hostName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_CreateOrUpdateHostNameBindingSlot
        /// <summary> Description for Creates a hostname binding for an app. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="hostName"> Hostname in the hostname binding. </param>
        /// <param name="hostNameBinding"> Binding details. This is the JSON representation of a HostNameBinding object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> or <paramref name="hostNameBinding"/> is null. </exception>
        public async virtual Task<SiteSlotHostNameBindingCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string hostName, HostNameBindingData hostNameBinding, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));
            if (hostNameBinding == null)
            {
                throw new ArgumentNullException(nameof(hostNameBinding));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHostNameBindingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.CreateOrUpdateHostNameBindingSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hostName, hostNameBinding, cancellationToken).ConfigureAwait(false);
                var operation = new SiteSlotHostNameBindingCreateOrUpdateOperation(this, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hostNameBindings/{hostName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetHostNameBindingSlot
        /// <summary> Description for Get the named hostname binding for an app (or deployment slot, if specified). </summary>
        /// <param name="hostName"> Hostname in the hostname binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual Response<SiteSlotHostNameBinding> Get(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHostNameBindingCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetHostNameBindingSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hostName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotHostNameBinding(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hostNameBindings/{hostName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetHostNameBindingSlot
        /// <summary> Description for Get the named hostname binding for an app (or deployment slot, if specified). </summary>
        /// <param name="hostName"> Hostname in the hostname binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotHostNameBinding>> GetAsync(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHostNameBindingCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetHostNameBindingSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hostName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotHostNameBinding(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hostName"> Hostname in the hostname binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual Response<SiteSlotHostNameBinding> GetIfExists(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHostNameBindingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetHostNameBindingSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hostName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotHostNameBinding>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotHostNameBinding(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hostName"> Hostname in the hostname binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotHostNameBinding>> GetIfExistsAsync(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHostNameBindingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetHostNameBindingSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hostName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotHostNameBinding>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotHostNameBinding(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hostName"> Hostname in the hostname binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual Response<bool> Exists(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHostNameBindingCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(hostName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hostName"> Hostname in the hostname binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHostNameBindingCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(hostName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hostNameBindings
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_ListHostNameBindingsSlot
        /// <summary> Description for Get hostname bindings for an app or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotHostNameBinding" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotHostNameBinding> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotHostNameBinding> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotHostNameBindingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListHostNameBindingsSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotHostNameBinding(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotHostNameBinding> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotHostNameBindingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListHostNameBindingsSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotHostNameBinding(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hostNameBindings
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_ListHostNameBindingsSlot
        /// <summary> Description for Get hostname bindings for an app or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotHostNameBinding" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotHostNameBinding> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotHostNameBinding>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotHostNameBindingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListHostNameBindingsSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotHostNameBinding(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotHostNameBinding>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotHostNameBindingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListHostNameBindingsSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotHostNameBinding(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteSlotHostNameBinding> IEnumerable<SiteSlotHostNameBinding>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotHostNameBinding> IAsyncEnumerable<SiteSlotHostNameBinding>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SiteSlotHostNameBinding, HostNameBindingData> Construct() { }
    }
}
