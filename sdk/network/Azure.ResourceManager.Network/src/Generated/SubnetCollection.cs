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

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of Subnet and their operations over its parent. </summary>
    public partial class SubnetCollection : ArmCollection, IEnumerable<Subnet>, IAsyncEnumerable<Subnet>
    {
        private readonly ClientDiagnostics _subnetClientDiagnostics;
        private readonly SubnetsRestOperations _subnetRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubnetCollection"/> class for mocking. </summary>
        protected SubnetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubnetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SubnetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subnetClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", Subnet.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(Subnet.ResourceType, out string subnetApiVersion);
            _subnetRestClient = new SubnetsRestOperations(_subnetClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, subnetApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualNetwork.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualNetwork.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a subnet in the specified virtual network.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
        /// Operation Id: Subnets_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="subnetParameters"> Parameters supplied to the create or update subnet operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subnetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> or <paramref name="subnetParameters"/> is null. </exception>
        public async virtual Task<ArmOperation<Subnet>> CreateOrUpdateAsync(bool waitForCompletion, string subnetName, SubnetData subnetParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subnetName, nameof(subnetName));
            if (subnetParameters == null)
            {
                throw new ArgumentNullException(nameof(subnetParameters));
            }

            using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _subnetRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, subnetParameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<Subnet>(new SubnetOperationSource(Client), _subnetClientDiagnostics, Pipeline, _subnetRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, subnetParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// <summary>
        /// Creates or updates a subnet in the specified virtual network.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
        /// Operation Id: Subnets_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="subnetParameters"> Parameters supplied to the create or update subnet operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subnetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> or <paramref name="subnetParameters"/> is null. </exception>
        public virtual ArmOperation<Subnet> CreateOrUpdate(bool waitForCompletion, string subnetName, SubnetData subnetParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subnetName, nameof(subnetName));
            if (subnetParameters == null)
            {
                throw new ArgumentNullException(nameof(subnetParameters));
            }

            using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _subnetRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, subnetParameters, cancellationToken);
                var operation = new NetworkArmOperation<Subnet>(new SubnetOperationSource(Client), _subnetClientDiagnostics, Pipeline, _subnetRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, subnetParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// <summary>
        /// Gets the specified subnet by virtual network and resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
        /// Operation Id: Subnets_Get
        /// </summary>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subnetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> is null. </exception>
        public async virtual Task<Response<Subnet>> GetAsync(string subnetName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subnetName, nameof(subnetName));

            using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.Get");
            scope.Start();
            try
            {
                var response = await _subnetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _subnetClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Subnet(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified subnet by virtual network and resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
        /// Operation Id: Subnets_Get
        /// </summary>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subnetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> is null. </exception>
        public virtual Response<Subnet> Get(string subnetName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subnetName, nameof(subnetName));

            using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.Get");
            scope.Start();
            try
            {
                var response = _subnetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, expand, cancellationToken);
                if (response.Value == null)
                    throw _subnetClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Subnet(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all subnets in a virtual network.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets
        /// Operation Id: Subnets_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Subnet" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Subnet> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Subnet>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subnetRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Subnet(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Subnet>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subnetRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Subnet(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all subnets in a virtual network.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets
        /// Operation Id: Subnets_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Subnet" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Subnet> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Subnet> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subnetRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Subnet(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Subnet> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subnetRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Subnet(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
        /// Operation Id: Subnets_Get
        /// </summary>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subnetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string subnetName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subnetName, nameof(subnetName));

            using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(subnetName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
        /// Operation Id: Subnets_Get
        /// </summary>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subnetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> is null. </exception>
        public virtual Response<bool> Exists(string subnetName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subnetName, nameof(subnetName));

            using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(subnetName, expand: expand, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
        /// Operation Id: Subnets_Get
        /// </summary>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subnetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> is null. </exception>
        public async virtual Task<Response<Subnet>> GetIfExistsAsync(string subnetName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subnetName, nameof(subnetName));

            using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _subnetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Subnet>(null, response.GetRawResponse());
                return Response.FromValue(new Subnet(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
        /// Operation Id: Subnets_Get
        /// </summary>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subnetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> is null. </exception>
        public virtual Response<Subnet> GetIfExists(string subnetName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subnetName, nameof(subnetName));

            using var scope = _subnetClientDiagnostics.CreateScope("SubnetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _subnetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Subnet>(null, response.GetRawResponse());
                return Response.FromValue(new Subnet(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Subnet> IEnumerable<Subnet>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Subnet> IAsyncEnumerable<Subnet>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
