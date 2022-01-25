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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VpnServerConfiguration and their operations over its parent. </summary>
    public partial class VpnServerConfigurationCollection : ArmCollection, IEnumerable<VpnServerConfiguration>, IAsyncEnumerable<VpnServerConfiguration>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VpnServerConfigurationsRestOperations _vpnServerConfigurationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VpnServerConfigurationCollection"/> class for mocking. </summary>
        protected VpnServerConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VpnServerConfigurationCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VpnServerConfigurationCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(VpnServerConfiguration.ResourceType, out string apiVersion);
            _vpnServerConfigurationsRestClient = new VpnServerConfigurationsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
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

        /// <summary> Creates a VpnServerConfiguration resource if it doesn&apos;t exist else updates the existing VpnServerConfiguration. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being created or updated. </param>
        /// <param name="vpnServerConfigurationParameters"> Parameters supplied to create or update VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnServerConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnServerConfigurationName"/> or <paramref name="vpnServerConfigurationParameters"/> is null. </exception>
        public virtual VpnServerConfigurationCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string vpnServerConfigurationName, VpnServerConfigurationData vpnServerConfigurationParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));
            if (vpnServerConfigurationParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vpnServerConfigurationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters, cancellationToken);
                var operation = new VpnServerConfigurationCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _vpnServerConfigurationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters).Request, response);
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

        /// <summary> Creates a VpnServerConfiguration resource if it doesn&apos;t exist else updates the existing VpnServerConfiguration. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being created or updated. </param>
        /// <param name="vpnServerConfigurationParameters"> Parameters supplied to create or update VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnServerConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnServerConfigurationName"/> or <paramref name="vpnServerConfigurationParameters"/> is null. </exception>
        public async virtual Task<VpnServerConfigurationCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string vpnServerConfigurationName, VpnServerConfigurationData vpnServerConfigurationParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));
            if (vpnServerConfigurationParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vpnServerConfigurationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters, cancellationToken).ConfigureAwait(false);
                var operation = new VpnServerConfigurationCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _vpnServerConfigurationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters).Request, response);
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

        /// <summary> Retrieves the details of a VpnServerConfiguration. </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnServerConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnServerConfigurationName"/> is null. </exception>
        public virtual Response<VpnServerConfiguration> Get(string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));

            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _vpnServerConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vpnServerConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnServerConfiguration(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a VpnServerConfiguration. </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnServerConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnServerConfigurationName"/> is null. </exception>
        public async virtual Task<Response<VpnServerConfiguration>> GetAsync(string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));

            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _vpnServerConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vpnServerConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VpnServerConfiguration(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnServerConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnServerConfigurationName"/> is null. </exception>
        public virtual Response<VpnServerConfiguration> GetIfExists(string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));

            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _vpnServerConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vpnServerConfigurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VpnServerConfiguration>(null, response.GetRawResponse());
                return Response.FromValue(new VpnServerConfiguration(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnServerConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnServerConfigurationName"/> is null. </exception>
        public async virtual Task<Response<VpnServerConfiguration>> GetIfExistsAsync(string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));

            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _vpnServerConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vpnServerConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VpnServerConfiguration>(null, response.GetRawResponse());
                return Response.FromValue(new VpnServerConfiguration(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnServerConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnServerConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));

            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(vpnServerConfigurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnServerConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnServerConfigurationName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));

            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(vpnServerConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the vpnServerConfigurations in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VpnServerConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VpnServerConfiguration> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VpnServerConfiguration> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vpnServerConfigurationsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnServerConfiguration(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VpnServerConfiguration> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vpnServerConfigurationsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnServerConfiguration(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all the vpnServerConfigurations in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VpnServerConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VpnServerConfiguration> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VpnServerConfiguration>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vpnServerConfigurationsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnServerConfiguration(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VpnServerConfiguration>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vpnServerConfigurationsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnServerConfiguration(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VpnServerConfiguration" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VpnServerConfiguration.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VpnServerConfiguration" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VpnServerConfiguration.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VpnServerConfiguration> IEnumerable<VpnServerConfiguration>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VpnServerConfiguration> IAsyncEnumerable<VpnServerConfiguration>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, VpnServerConfiguration, VpnServerConfigurationData> Construct() { }
    }
}
