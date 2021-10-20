// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a LoadBalancer along with the instance operations that can be performed on it. </summary>
    public partial class LoadBalancer : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly LoadBalancersRestOperations _loadBalancersRestClient;
        private readonly LoadBalancerNetworkInterfacesRestOperations _loadBalancerNetworkInterfacesRestClient;
        private readonly LoadBalancerData _data;

        /// <summary> Initializes a new instance of the <see cref="LoadBalancer"/> class for mocking. </summary>
        protected LoadBalancer()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "LoadBalancer"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal LoadBalancer(ArmResource options, LoadBalancerData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _loadBalancersRestClient = new LoadBalancersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
            _loadBalancerNetworkInterfacesRestClient = new LoadBalancerNetworkInterfacesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="LoadBalancer"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LoadBalancer(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _loadBalancersRestClient = new LoadBalancersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
            _loadBalancerNetworkInterfacesRestClient = new LoadBalancerNetworkInterfacesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="LoadBalancer"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LoadBalancer(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _loadBalancersRestClient = new LoadBalancersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
            _loadBalancerNetworkInterfacesRestClient = new LoadBalancerNetworkInterfacesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/loadBalancers";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LoadBalancerData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Gets the specified load balancer. </summary>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<LoadBalancer>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LoadBalancer.Get");
            scope.Start();
            try
            {
                var response = await _loadBalancersRestClient.GetAsync(Id.ResourceGroupName, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new LoadBalancer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified load balancer. </summary>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LoadBalancer> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LoadBalancer.Get");
            scope.Start();
            try
            {
                var response = _loadBalancersRestClient.Get(Id.ResourceGroupName, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadBalancer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes the specified load balancer. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<LoadBalancerDeleteOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LoadBalancer.Delete");
            scope.Start();
            try
            {
                var response = await _loadBalancersRestClient.DeleteAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new LoadBalancerDeleteOperation(_clientDiagnostics, Pipeline, _loadBalancersRestClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified load balancer. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual LoadBalancerDeleteOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LoadBalancer.Delete");
            scope.Start();
            try
            {
                var response = _loadBalancersRestClient.Delete(Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new LoadBalancerDeleteOperation(_clientDiagnostics, Pipeline, _loadBalancersRestClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Updates a load balancer tags. </summary>
        /// <param name="parameters"> Parameters supplied to update load balancer tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<LoadBalancer>> UpdateAsync(TagsObject parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("LoadBalancer.Update");
            scope.Start();
            try
            {
                var response = await _loadBalancersRestClient.UpdateTagsAsync(Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new LoadBalancer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a load balancer tags. </summary>
        /// <param name="parameters"> Parameters supplied to update load balancer tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<LoadBalancer> Update(TagsObject parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("LoadBalancer.Update");
            scope.Start();
            try
            {
                var response = _loadBalancersRestClient.UpdateTags(Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                return Response.FromValue(new LoadBalancer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets associated load balancer network interfaces. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkInterfaceData" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkInterfaceData> GetAllLoadBalancerNetworkInterfaceAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetworkInterfaceData>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LoadBalancer.GetAllLoadBalancerNetworkInterface");
                scope.Start();
                try
                {
                    var response = await _loadBalancerNetworkInterfacesRestClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NetworkInterfaceData>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LoadBalancer.GetAllLoadBalancerNetworkInterface");
                scope.Start();
                try
                {
                    var response = await _loadBalancerNetworkInterfacesRestClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets associated load balancer network interfaces. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkInterfaceData" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkInterfaceData> GetAllLoadBalancerNetworkInterface(CancellationToken cancellationToken = default)
        {
            Page<NetworkInterfaceData> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LoadBalancer.GetAllLoadBalancerNetworkInterface");
                scope.Start();
                try
                {
                    var response = _loadBalancerNetworkInterfacesRestClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NetworkInterfaceData> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LoadBalancer.GetAllLoadBalancerNetworkInterface");
                scope.Start();
                try
                {
                    var response = _loadBalancerNetworkInterfacesRestClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        #region BackendAddressPool

        /// <summary> Gets a container of BackendAddressPools in the LoadBalancer. </summary>
        /// <returns> An object representing collection of BackendAddressPools and their operations over a LoadBalancer. </returns>
        public BackendAddressPoolContainer GetBackendAddressPools()
        {
            return new BackendAddressPoolContainer(this);
        }
        #endregion

        #region FrontendIPConfiguration

        /// <summary> Gets a container of FrontendIPConfigurations in the LoadBalancer. </summary>
        /// <returns> An object representing collection of FrontendIPConfigurations and their operations over a LoadBalancer. </returns>
        public FrontendIPConfigurationContainer GetFrontendIPConfigurations()
        {
            return new FrontendIPConfigurationContainer(this);
        }
        #endregion

        #region InboundNatRule

        /// <summary> Gets a container of InboundNatRules in the LoadBalancer. </summary>
        /// <returns> An object representing collection of InboundNatRules and their operations over a LoadBalancer. </returns>
        public InboundNatRuleContainer GetInboundNatRules()
        {
            return new InboundNatRuleContainer(this);
        }
        #endregion

        #region LoadBalancingRule

        /// <summary> Gets a container of LoadBalancingRules in the LoadBalancer. </summary>
        /// <returns> An object representing collection of LoadBalancingRules and their operations over a LoadBalancer. </returns>
        public LoadBalancingRuleContainer GetLoadBalancingRules()
        {
            return new LoadBalancingRuleContainer(this);
        }
        #endregion

        #region OutboundRule

        /// <summary> Gets a container of OutboundRules in the LoadBalancer. </summary>
        /// <returns> An object representing collection of OutboundRules and their operations over a LoadBalancer. </returns>
        public OutboundRuleContainer GetOutboundRules()
        {
            return new OutboundRuleContainer(this);
        }
        #endregion

        #region Probe

        /// <summary> Gets a container of Probes in the LoadBalancer. </summary>
        /// <returns> An object representing collection of Probes and their operations over a LoadBalancer. </returns>
        public ProbeContainer GetProbes()
        {
            return new ProbeContainer(this);
        }
        #endregion
    }
}
