// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> The LoadBalancerLoadBalancingRules service client. </summary>
    public partial class LoadBalancerLoadBalancingRulesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal LoadBalancerLoadBalancingRulesRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of LoadBalancerLoadBalancingRulesOperations for mocking. </summary>
        protected LoadBalancerLoadBalancingRulesOperations()
        {
        }
        /// <summary> Initializes a new instance of LoadBalancerLoadBalancingRulesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal LoadBalancerLoadBalancingRulesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new LoadBalancerLoadBalancingRulesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the specified load balancer load balancing rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="loadBalancingRuleName"> The name of the load balancing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LoadBalancingRule>> GetAsync(string resourceGroupName, string loadBalancerName, string loadBalancingRuleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LoadBalancerLoadBalancingRulesOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, loadBalancerName, loadBalancingRuleName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified load balancer load balancing rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="loadBalancingRuleName"> The name of the load balancing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LoadBalancingRule> Get(string resourceGroupName, string loadBalancerName, string loadBalancingRuleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LoadBalancerLoadBalancingRulesOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, loadBalancerName, loadBalancingRuleName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the load balancing rules in a load balancer. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="loadBalancerName"/> is null. </exception>
        public virtual AsyncPageable<LoadBalancingRule> ListAsync(string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }

            async Task<Page<LoadBalancingRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LoadBalancerLoadBalancingRulesOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, loadBalancerName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<LoadBalancingRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LoadBalancerLoadBalancingRulesOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, loadBalancerName, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets all the load balancing rules in a load balancer. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="loadBalancerName"/> is null. </exception>
        public virtual Pageable<LoadBalancingRule> List(string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }

            Page<LoadBalancingRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LoadBalancerLoadBalancingRulesOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, loadBalancerName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<LoadBalancingRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LoadBalancerLoadBalancingRulesOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, loadBalancerName, cancellationToken);
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
    }
}
