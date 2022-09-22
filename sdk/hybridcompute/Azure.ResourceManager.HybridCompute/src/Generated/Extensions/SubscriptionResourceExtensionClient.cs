// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.HybridCompute.Models;

namespace Azure.ResourceManager.HybridCompute
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _machineClientDiagnostics;
        private MachinesRestOperations _machineRestClient;
        private ClientDiagnostics _hybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics;
        private PrivateLinkScopesRestOperations _hybridComputePrivateLinkScopePrivateLinkScopesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics MachineClientDiagnostics => _machineClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HybridCompute", MachineResource.ResourceType.Namespace, Diagnostics);
        private MachinesRestOperations MachineRestClient => _machineRestClient ??= new MachinesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(MachineResource.ResourceType));
        private ClientDiagnostics HybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics => _hybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HybridCompute", HybridComputePrivateLinkScopeResource.ResourceType.Namespace, Diagnostics);
        private PrivateLinkScopesRestOperations HybridComputePrivateLinkScopePrivateLinkScopesRestClient => _hybridComputePrivateLinkScopePrivateLinkScopesRestClient ??= new PrivateLinkScopesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(HybridComputePrivateLinkScopeResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all the hybrid machines in the specified subscription. Use the nextLink property in the response to get the next page of hybrid machines.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/machines
        /// Operation Id: Machines_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineResource> GetMachinesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MachineResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = MachineClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetMachines");
                scope.Start();
                try
                {
                    var response = await MachineRestClient.ListBySubscriptionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MachineResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MachineResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = MachineClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetMachines");
                scope.Start();
                try
                {
                    var response = await MachineRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MachineResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all the hybrid machines in the specified subscription. Use the nextLink property in the response to get the next page of hybrid machines.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/machines
        /// Operation Id: Machines_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineResource> GetMachines(CancellationToken cancellationToken = default)
        {
            Page<MachineResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = MachineClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetMachines");
                scope.Start();
                try
                {
                    var response = MachineRestClient.ListBySubscription(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MachineResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MachineResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = MachineClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetMachines");
                scope.Start();
                try
                {
                    var response = MachineRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MachineResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of all Azure Arc PrivateLinkScopes within a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/privateLinkScopes
        /// Operation Id: PrivateLinkScopes_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridComputePrivateLinkScopeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridComputePrivateLinkScopeResource> GetHybridComputePrivateLinkScopesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<HybridComputePrivateLinkScopeResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = HybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetHybridComputePrivateLinkScopes");
                scope.Start();
                try
                {
                    var response = await HybridComputePrivateLinkScopePrivateLinkScopesRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridComputePrivateLinkScopeResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<HybridComputePrivateLinkScopeResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = HybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetHybridComputePrivateLinkScopes");
                scope.Start();
                try
                {
                    var response = await HybridComputePrivateLinkScopePrivateLinkScopesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridComputePrivateLinkScopeResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of all Azure Arc PrivateLinkScopes within a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/privateLinkScopes
        /// Operation Id: PrivateLinkScopes_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridComputePrivateLinkScopeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridComputePrivateLinkScopeResource> GetHybridComputePrivateLinkScopes(CancellationToken cancellationToken = default)
        {
            Page<HybridComputePrivateLinkScopeResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = HybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetHybridComputePrivateLinkScopes");
                scope.Start();
                try
                {
                    var response = HybridComputePrivateLinkScopePrivateLinkScopesRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridComputePrivateLinkScopeResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<HybridComputePrivateLinkScopeResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = HybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetHybridComputePrivateLinkScopes");
                scope.Start();
                try
                {
                    var response = HybridComputePrivateLinkScopePrivateLinkScopesRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridComputePrivateLinkScopeResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Returns a Azure Arc PrivateLinkScope&apos;s validation details.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/locations/{location}/privateLinkScopes/{privateLinkScopeId}
        /// Operation Id: PrivateLinkScopes_GetValidationDetails
        /// </summary>
        /// <param name="location"> The location of the target resource. </param>
        /// <param name="privateLinkScopeId"> The id (Guid) of the Azure Arc PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PrivateLinkScopeValidationDetails>> GetValidationDetailsPrivateLinkScopeAsync(AzureLocation location, string privateLinkScopeId, CancellationToken cancellationToken = default)
        {
            using var scope = HybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetValidationDetailsPrivateLinkScope");
            scope.Start();
            try
            {
                var response = await HybridComputePrivateLinkScopePrivateLinkScopesRestClient.GetValidationDetailsAsync(Id.SubscriptionId, location, privateLinkScopeId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a Azure Arc PrivateLinkScope&apos;s validation details.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/locations/{location}/privateLinkScopes/{privateLinkScopeId}
        /// Operation Id: PrivateLinkScopes_GetValidationDetails
        /// </summary>
        /// <param name="location"> The location of the target resource. </param>
        /// <param name="privateLinkScopeId"> The id (Guid) of the Azure Arc PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PrivateLinkScopeValidationDetails> GetValidationDetailsPrivateLinkScope(AzureLocation location, string privateLinkScopeId, CancellationToken cancellationToken = default)
        {
            using var scope = HybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetValidationDetailsPrivateLinkScope");
            scope.Start();
            try
            {
                var response = HybridComputePrivateLinkScopePrivateLinkScopesRestClient.GetValidationDetails(Id.SubscriptionId, location, privateLinkScopeId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
