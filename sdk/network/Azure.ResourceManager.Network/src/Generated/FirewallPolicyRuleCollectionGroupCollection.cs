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
    /// <summary> A class representing collection of FirewallPolicyRuleCollectionGroup and their operations over its parent. </summary>
    public partial class FirewallPolicyRuleCollectionGroupCollection : ArmCollection, IEnumerable<FirewallPolicyRuleCollectionGroup>, IAsyncEnumerable<FirewallPolicyRuleCollectionGroup>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly FirewallPolicyRuleCollectionGroupsRestOperations _firewallPolicyRuleCollectionGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="FirewallPolicyRuleCollectionGroupCollection"/> class for mocking. </summary>
        protected FirewallPolicyRuleCollectionGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FirewallPolicyRuleCollectionGroupCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal FirewallPolicyRuleCollectionGroupCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(FirewallPolicyRuleCollectionGroup.ResourceType, out string apiVersion);
            _firewallPolicyRuleCollectionGroupsRestClient = new FirewallPolicyRuleCollectionGroupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != FirewallPolicy.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, FirewallPolicy.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates the specified FirewallPolicyRuleCollectionGroup. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="parameters"> Parameters supplied to the create or update FirewallPolicyRuleCollectionGroup operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionGroupName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual FirewallPolicyRuleCollectionGroupCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string ruleCollectionGroupName, FirewallPolicyRuleCollectionGroupData parameters, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(ruleCollectionGroupName))
            {
                throw new ArgumentException($"Parameter {nameof(ruleCollectionGroupName)} cannot be null or empty", nameof(ruleCollectionGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _firewallPolicyRuleCollectionGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleCollectionGroupName, parameters, cancellationToken);
                var operation = new FirewallPolicyRuleCollectionGroupCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _firewallPolicyRuleCollectionGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleCollectionGroupName, parameters).Request, response);
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

        /// <summary> Creates or updates the specified FirewallPolicyRuleCollectionGroup. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="parameters"> Parameters supplied to the create or update FirewallPolicyRuleCollectionGroup operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionGroupName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<FirewallPolicyRuleCollectionGroupCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string ruleCollectionGroupName, FirewallPolicyRuleCollectionGroupData parameters, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(ruleCollectionGroupName))
            {
                throw new ArgumentException($"Parameter {nameof(ruleCollectionGroupName)} cannot be null or empty", nameof(ruleCollectionGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _firewallPolicyRuleCollectionGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleCollectionGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new FirewallPolicyRuleCollectionGroupCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _firewallPolicyRuleCollectionGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleCollectionGroupName, parameters).Request, response);
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

        /// <summary> Gets the specified FirewallPolicyRuleCollectionGroup. </summary>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionGroupName"/> is null or empty. </exception>
        public virtual Response<FirewallPolicyRuleCollectionGroup> Get(string ruleCollectionGroupName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(ruleCollectionGroupName))
            {
                throw new ArgumentException($"Parameter {nameof(ruleCollectionGroupName)} cannot be null or empty", nameof(ruleCollectionGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _firewallPolicyRuleCollectionGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleCollectionGroupName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FirewallPolicyRuleCollectionGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified FirewallPolicyRuleCollectionGroup. </summary>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionGroupName"/> is null or empty. </exception>
        public async virtual Task<Response<FirewallPolicyRuleCollectionGroup>> GetAsync(string ruleCollectionGroupName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(ruleCollectionGroupName))
            {
                throw new ArgumentException($"Parameter {nameof(ruleCollectionGroupName)} cannot be null or empty", nameof(ruleCollectionGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _firewallPolicyRuleCollectionGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleCollectionGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new FirewallPolicyRuleCollectionGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionGroupName"/> is null or empty. </exception>
        public virtual Response<FirewallPolicyRuleCollectionGroup> GetIfExists(string ruleCollectionGroupName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(ruleCollectionGroupName))
            {
                throw new ArgumentException($"Parameter {nameof(ruleCollectionGroupName)} cannot be null or empty", nameof(ruleCollectionGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _firewallPolicyRuleCollectionGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleCollectionGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<FirewallPolicyRuleCollectionGroup>(null, response.GetRawResponse());
                return Response.FromValue(new FirewallPolicyRuleCollectionGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionGroupName"/> is null or empty. </exception>
        public async virtual Task<Response<FirewallPolicyRuleCollectionGroup>> GetIfExistsAsync(string ruleCollectionGroupName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(ruleCollectionGroupName))
            {
                throw new ArgumentException($"Parameter {nameof(ruleCollectionGroupName)} cannot be null or empty", nameof(ruleCollectionGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _firewallPolicyRuleCollectionGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleCollectionGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<FirewallPolicyRuleCollectionGroup>(null, response.GetRawResponse());
                return Response.FromValue(new FirewallPolicyRuleCollectionGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionGroupName"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string ruleCollectionGroupName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(ruleCollectionGroupName))
            {
                throw new ArgumentException($"Parameter {nameof(ruleCollectionGroupName)} cannot be null or empty", nameof(ruleCollectionGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(ruleCollectionGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionGroupName"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string ruleCollectionGroupName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(ruleCollectionGroupName))
            {
                throw new ArgumentException($"Parameter {nameof(ruleCollectionGroupName)} cannot be null or empty", nameof(ruleCollectionGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(ruleCollectionGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all FirewallPolicyRuleCollectionGroups in a FirewallPolicy resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FirewallPolicyRuleCollectionGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FirewallPolicyRuleCollectionGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<FirewallPolicyRuleCollectionGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _firewallPolicyRuleCollectionGroupsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FirewallPolicyRuleCollectionGroup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FirewallPolicyRuleCollectionGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _firewallPolicyRuleCollectionGroupsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FirewallPolicyRuleCollectionGroup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all FirewallPolicyRuleCollectionGroups in a FirewallPolicy resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FirewallPolicyRuleCollectionGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FirewallPolicyRuleCollectionGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FirewallPolicyRuleCollectionGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _firewallPolicyRuleCollectionGroupsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FirewallPolicyRuleCollectionGroup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FirewallPolicyRuleCollectionGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _firewallPolicyRuleCollectionGroupsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FirewallPolicyRuleCollectionGroup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<FirewallPolicyRuleCollectionGroup> IEnumerable<FirewallPolicyRuleCollectionGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FirewallPolicyRuleCollectionGroup> IAsyncEnumerable<FirewallPolicyRuleCollectionGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, FirewallPolicyRuleCollectionGroup, FirewallPolicyRuleCollectionGroupData> Construct() { }
    }
}
