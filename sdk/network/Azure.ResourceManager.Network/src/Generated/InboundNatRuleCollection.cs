// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of InboundNatRule and their operations over its parent. </summary>
    public partial class InboundNatRuleCollection : ArmCollection, IEnumerable<InboundNatRule>, IAsyncEnumerable<InboundNatRule>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly InboundNatRulesRestOperations _inboundNatRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="InboundNatRuleCollection"/> class for mocking. </summary>
        protected InboundNatRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of InboundNatRuleCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal InboundNatRuleCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _inboundNatRulesRestClient = new InboundNatRulesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => LoadBalancer.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates a load balancer inbound nat rule. </summary>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="inboundNatRuleParameters"> Parameters supplied to the create or update inbound nat rule operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> or <paramref name="inboundNatRuleParameters"/> is null. </exception>
        public virtual InboundNatRuleCreateOrUpdateOperation CreateOrUpdate(string inboundNatRuleName, InboundNatRuleData inboundNatRuleParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (inboundNatRuleName == null)
            {
                throw new ArgumentNullException(nameof(inboundNatRuleName));
            }
            if (inboundNatRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(inboundNatRuleParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("InboundNatRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _inboundNatRulesRestClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, inboundNatRuleName, inboundNatRuleParameters, cancellationToken);
                var operation = new InboundNatRuleCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _inboundNatRulesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, inboundNatRuleName, inboundNatRuleParameters).Request, response);
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

        /// <summary> Creates or updates a load balancer inbound nat rule. </summary>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="inboundNatRuleParameters"> Parameters supplied to the create or update inbound nat rule operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> or <paramref name="inboundNatRuleParameters"/> is null. </exception>
        public async virtual Task<InboundNatRuleCreateOrUpdateOperation> CreateOrUpdateAsync(string inboundNatRuleName, InboundNatRuleData inboundNatRuleParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (inboundNatRuleName == null)
            {
                throw new ArgumentNullException(nameof(inboundNatRuleName));
            }
            if (inboundNatRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(inboundNatRuleParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("InboundNatRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _inboundNatRulesRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, inboundNatRuleName, inboundNatRuleParameters, cancellationToken).ConfigureAwait(false);
                var operation = new InboundNatRuleCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _inboundNatRulesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, inboundNatRuleName, inboundNatRuleParameters).Request, response);
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

        /// <summary> Gets the specified load balancer inbound nat rule. </summary>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> is null. </exception>
        public virtual Response<InboundNatRule> Get(string inboundNatRuleName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (inboundNatRuleName == null)
            {
                throw new ArgumentNullException(nameof(inboundNatRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("InboundNatRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _inboundNatRulesRestClient.Get(Id.ResourceGroupName, Id.Name, inboundNatRuleName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new InboundNatRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified load balancer inbound nat rule. </summary>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> is null. </exception>
        public async virtual Task<Response<InboundNatRule>> GetAsync(string inboundNatRuleName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (inboundNatRuleName == null)
            {
                throw new ArgumentNullException(nameof(inboundNatRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("InboundNatRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _inboundNatRulesRestClient.GetAsync(Id.ResourceGroupName, Id.Name, inboundNatRuleName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new InboundNatRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> is null. </exception>
        public virtual Response<InboundNatRule> GetIfExists(string inboundNatRuleName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (inboundNatRuleName == null)
            {
                throw new ArgumentNullException(nameof(inboundNatRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("InboundNatRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _inboundNatRulesRestClient.Get(Id.ResourceGroupName, Id.Name, inboundNatRuleName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<InboundNatRule>(null, response.GetRawResponse())
                    : Response.FromValue(new InboundNatRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> is null. </exception>
        public async virtual Task<Response<InboundNatRule>> GetIfExistsAsync(string inboundNatRuleName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (inboundNatRuleName == null)
            {
                throw new ArgumentNullException(nameof(inboundNatRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("InboundNatRuleCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _inboundNatRulesRestClient.GetAsync(Id.ResourceGroupName, Id.Name, inboundNatRuleName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<InboundNatRule>(null, response.GetRawResponse())
                    : Response.FromValue(new InboundNatRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string inboundNatRuleName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (inboundNatRuleName == null)
            {
                throw new ArgumentNullException(nameof(inboundNatRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("InboundNatRuleCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(inboundNatRuleName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string inboundNatRuleName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (inboundNatRuleName == null)
            {
                throw new ArgumentNullException(nameof(inboundNatRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("InboundNatRuleCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(inboundNatRuleName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the inbound nat rules in a load balancer. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="InboundNatRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<InboundNatRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<InboundNatRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InboundNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _inboundNatRulesRestClient.List(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new InboundNatRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<InboundNatRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InboundNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _inboundNatRulesRestClient.ListNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new InboundNatRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the inbound nat rules in a load balancer. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="InboundNatRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<InboundNatRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<InboundNatRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InboundNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _inboundNatRulesRestClient.ListAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new InboundNatRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<InboundNatRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InboundNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _inboundNatRulesRestClient.ListNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new InboundNatRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<InboundNatRule> IEnumerable<InboundNatRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<InboundNatRule> IAsyncEnumerable<InboundNatRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, InboundNatRule, InboundNatRuleData> Construct() { }
    }
}
