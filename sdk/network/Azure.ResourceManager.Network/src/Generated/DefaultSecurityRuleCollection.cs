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
    /// <summary> A class representing collection of SecurityRule and their operations over its parent. </summary>
    public partial class DefaultSecurityRuleCollection : ArmCollection, IEnumerable<DefaultSecurityRule>, IAsyncEnumerable<DefaultSecurityRule>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DefaultSecurityRulesRestOperations _defaultSecurityRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DefaultSecurityRuleCollection"/> class for mocking. </summary>
        protected DefaultSecurityRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DefaultSecurityRuleCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DefaultSecurityRuleCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(DefaultSecurityRule.ResourceType, out string apiVersion);
            _defaultSecurityRulesRestClient = new DefaultSecurityRulesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkSecurityGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkSecurityGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Get the specified default network security rule. </summary>
        /// <param name="defaultSecurityRuleName"> The name of the default security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="defaultSecurityRuleName"/> is null or empty. </exception>
        public virtual Response<DefaultSecurityRule> Get(string defaultSecurityRuleName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(defaultSecurityRuleName))
            {
                throw new ArgumentException($"Parameter {nameof(defaultSecurityRuleName)} cannot be null or empty", nameof(defaultSecurityRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("DefaultSecurityRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _defaultSecurityRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, defaultSecurityRuleName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DefaultSecurityRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the specified default network security rule. </summary>
        /// <param name="defaultSecurityRuleName"> The name of the default security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="defaultSecurityRuleName"/> is null or empty. </exception>
        public async virtual Task<Response<DefaultSecurityRule>> GetAsync(string defaultSecurityRuleName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(defaultSecurityRuleName))
            {
                throw new ArgumentException($"Parameter {nameof(defaultSecurityRuleName)} cannot be null or empty", nameof(defaultSecurityRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("DefaultSecurityRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _defaultSecurityRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, defaultSecurityRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DefaultSecurityRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="defaultSecurityRuleName"> The name of the default security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="defaultSecurityRuleName"/> is null or empty. </exception>
        public virtual Response<DefaultSecurityRule> GetIfExists(string defaultSecurityRuleName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(defaultSecurityRuleName))
            {
                throw new ArgumentException($"Parameter {nameof(defaultSecurityRuleName)} cannot be null or empty", nameof(defaultSecurityRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("DefaultSecurityRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _defaultSecurityRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, defaultSecurityRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DefaultSecurityRule>(null, response.GetRawResponse());
                return Response.FromValue(new DefaultSecurityRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="defaultSecurityRuleName"> The name of the default security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="defaultSecurityRuleName"/> is null or empty. </exception>
        public async virtual Task<Response<DefaultSecurityRule>> GetIfExistsAsync(string defaultSecurityRuleName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(defaultSecurityRuleName))
            {
                throw new ArgumentException($"Parameter {nameof(defaultSecurityRuleName)} cannot be null or empty", nameof(defaultSecurityRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("DefaultSecurityRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _defaultSecurityRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, defaultSecurityRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DefaultSecurityRule>(null, response.GetRawResponse());
                return Response.FromValue(new DefaultSecurityRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="defaultSecurityRuleName"> The name of the default security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="defaultSecurityRuleName"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string defaultSecurityRuleName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(defaultSecurityRuleName))
            {
                throw new ArgumentException($"Parameter {nameof(defaultSecurityRuleName)} cannot be null or empty", nameof(defaultSecurityRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("DefaultSecurityRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(defaultSecurityRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="defaultSecurityRuleName"> The name of the default security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="defaultSecurityRuleName"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string defaultSecurityRuleName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(defaultSecurityRuleName))
            {
                throw new ArgumentException($"Parameter {nameof(defaultSecurityRuleName)} cannot be null or empty", nameof(defaultSecurityRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("DefaultSecurityRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(defaultSecurityRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all default security rules in a network security group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DefaultSecurityRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DefaultSecurityRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DefaultSecurityRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DefaultSecurityRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _defaultSecurityRulesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DefaultSecurityRule(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DefaultSecurityRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DefaultSecurityRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _defaultSecurityRulesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DefaultSecurityRule(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all default security rules in a network security group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DefaultSecurityRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DefaultSecurityRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DefaultSecurityRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DefaultSecurityRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _defaultSecurityRulesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DefaultSecurityRule(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DefaultSecurityRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DefaultSecurityRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _defaultSecurityRulesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DefaultSecurityRule(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<DefaultSecurityRule> IEnumerable<DefaultSecurityRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DefaultSecurityRule> IAsyncEnumerable<DefaultSecurityRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, DefaultSecurityRule, SecurityRuleData> Construct() { }
    }
}
