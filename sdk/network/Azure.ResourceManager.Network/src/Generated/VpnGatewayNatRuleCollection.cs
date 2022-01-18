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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VpnGatewayNatRule and their operations over its parent. </summary>
    public partial class VpnGatewayNatRuleCollection : ArmCollection, IEnumerable<VpnGatewayNatRule>, IAsyncEnumerable<VpnGatewayNatRule>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly NatRulesRestOperations _natRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="VpnGatewayNatRuleCollection"/> class for mocking. </summary>
        protected VpnGatewayNatRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VpnGatewayNatRuleCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VpnGatewayNatRuleCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(VpnGatewayNatRule.ResourceType, out string apiVersion);
            _natRulesRestClient = new NatRulesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VpnGateway.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VpnGateway.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates a nat rule to a scalable vpn gateway if it doesn&apos;t exist else updates the existing nat rules. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="natRuleParameters"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleParameters"/> is null. </exception>
        public virtual VpnGatewayNatRuleCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string natRuleName, VpnGatewayNatRuleData natRuleParameters, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(natRuleName))
            {
                throw new ArgumentException($"Parameter {nameof(natRuleName)} cannot be null or empty", nameof(natRuleName));
            }
            if (natRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(natRuleParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _natRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters, cancellationToken);
                var operation = new VpnGatewayNatRuleCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _natRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters).Request, response);
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

        /// <summary> Creates a nat rule to a scalable vpn gateway if it doesn&apos;t exist else updates the existing nat rules. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="natRuleParameters"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleParameters"/> is null. </exception>
        public async virtual Task<VpnGatewayNatRuleCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string natRuleName, VpnGatewayNatRuleData natRuleParameters, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(natRuleName))
            {
                throw new ArgumentException($"Parameter {nameof(natRuleName)} cannot be null or empty", nameof(natRuleName));
            }
            if (natRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(natRuleParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _natRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters, cancellationToken).ConfigureAwait(false);
                var operation = new VpnGatewayNatRuleCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _natRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters).Request, response);
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

        /// <summary> Retrieves the details of a nat ruleGet. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is null or empty. </exception>
        public virtual Response<VpnGatewayNatRule> Get(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(natRuleName))
            {
                throw new ArgumentException($"Parameter {nameof(natRuleName)} cannot be null or empty", nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _natRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnGatewayNatRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a nat ruleGet. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is null or empty. </exception>
        public async virtual Task<Response<VpnGatewayNatRule>> GetAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(natRuleName))
            {
                throw new ArgumentException($"Parameter {nameof(natRuleName)} cannot be null or empty", nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _natRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VpnGatewayNatRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is null or empty. </exception>
        public virtual Response<VpnGatewayNatRule> GetIfExists(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(natRuleName))
            {
                throw new ArgumentException($"Parameter {nameof(natRuleName)} cannot be null or empty", nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _natRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VpnGatewayNatRule>(null, response.GetRawResponse());
                return Response.FromValue(new VpnGatewayNatRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is null or empty. </exception>
        public async virtual Task<Response<VpnGatewayNatRule>> GetIfExistsAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(natRuleName))
            {
                throw new ArgumentException($"Parameter {nameof(natRuleName)} cannot be null or empty", nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _natRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VpnGatewayNatRule>(null, response.GetRawResponse());
                return Response.FromValue(new VpnGatewayNatRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(natRuleName))
            {
                throw new ArgumentException($"Parameter {nameof(natRuleName)} cannot be null or empty", nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(natRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(natRuleName))
            {
                throw new ArgumentException($"Parameter {nameof(natRuleName)} cannot be null or empty", nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(natRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves all nat rules for a particular virtual wan vpn gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VpnGatewayNatRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VpnGatewayNatRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VpnGatewayNatRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _natRulesRestClient.ListByVpnGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGatewayNatRule(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VpnGatewayNatRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _natRulesRestClient.ListByVpnGatewayNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGatewayNatRule(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves all nat rules for a particular virtual wan vpn gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VpnGatewayNatRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VpnGatewayNatRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VpnGatewayNatRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _natRulesRestClient.ListByVpnGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGatewayNatRule(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VpnGatewayNatRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _natRulesRestClient.ListByVpnGatewayNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGatewayNatRule(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<VpnGatewayNatRule> IEnumerable<VpnGatewayNatRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VpnGatewayNatRule> IAsyncEnumerable<VpnGatewayNatRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, VpnGatewayNatRule, VpnGatewayNatRuleData> Construct() { }
    }
}
