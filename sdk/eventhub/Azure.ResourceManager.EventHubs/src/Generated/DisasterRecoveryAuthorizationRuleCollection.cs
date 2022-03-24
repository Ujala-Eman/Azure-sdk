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

namespace Azure.ResourceManager.EventHubs
{
    /// <summary>
    /// A class representing a collection of <see cref="DisasterRecoveryAuthorizationRuleResource" /> and their operations.
    /// Each <see cref="DisasterRecoveryAuthorizationRuleResource" /> in the collection will belong to the same instance of <see cref="DisasterRecoveryResource" />.
    /// To get a <see cref="DisasterRecoveryAuthorizationRuleCollection" /> instance call the GetDisasterRecoveryAuthorizationRules method from an instance of <see cref="DisasterRecoveryResource" />.
    /// </summary>
    public partial class DisasterRecoveryAuthorizationRuleCollection : ArmCollection, IEnumerable<DisasterRecoveryAuthorizationRuleResource>, IAsyncEnumerable<DisasterRecoveryAuthorizationRuleResource>
    {
        private readonly ClientDiagnostics _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics;
        private readonly DisasterRecoveryConfigsRestOperations _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DisasterRecoveryAuthorizationRuleCollection"/> class for mocking. </summary>
        protected DisasterRecoveryAuthorizationRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DisasterRecoveryAuthorizationRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DisasterRecoveryAuthorizationRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", DisasterRecoveryAuthorizationRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DisasterRecoveryAuthorizationRuleResource.ResourceType, out string disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsApiVersion);
            _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient = new DisasterRecoveryConfigsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DisasterRecoveryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DisasterRecoveryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets an AuthorizationRule for a Namespace by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}
        /// Operation Id: DisasterRecoveryConfigs_GetAuthorizationRule
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<Response<DisasterRecoveryAuthorizationRuleResource>> GetAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DisasterRecoveryAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an AuthorizationRule for a Namespace by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}
        /// Operation Id: DisasterRecoveryConfigs_GetAuthorizationRule
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<DisasterRecoveryAuthorizationRuleResource> Get(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DisasterRecoveryAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of authorization rules for a Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules
        /// Operation Id: DisasterRecoveryConfigs_ListAuthorizationRules
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DisasterRecoveryAuthorizationRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DisasterRecoveryAuthorizationRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DisasterRecoveryAuthorizationRuleResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.ListAuthorizationRulesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DisasterRecoveryAuthorizationRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DisasterRecoveryAuthorizationRuleResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.ListAuthorizationRulesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DisasterRecoveryAuthorizationRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of authorization rules for a Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules
        /// Operation Id: DisasterRecoveryConfigs_ListAuthorizationRules
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DisasterRecoveryAuthorizationRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DisasterRecoveryAuthorizationRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DisasterRecoveryAuthorizationRuleResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.ListAuthorizationRules(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DisasterRecoveryAuthorizationRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DisasterRecoveryAuthorizationRuleResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.ListAuthorizationRulesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DisasterRecoveryAuthorizationRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}
        /// Operation Id: DisasterRecoveryConfigs_GetAuthorizationRule
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}
        /// Operation Id: DisasterRecoveryConfigs_GetAuthorizationRule
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(authorizationRuleName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}
        /// Operation Id: DisasterRecoveryConfigs_GetAuthorizationRule
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<Response<DisasterRecoveryAuthorizationRuleResource>> GetIfExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryAuthorizationRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DisasterRecoveryAuthorizationRuleResource>(null, response.GetRawResponse());
                return Response.FromValue(new DisasterRecoveryAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}
        /// Operation Id: DisasterRecoveryConfigs_GetAuthorizationRule
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<DisasterRecoveryAuthorizationRuleResource> GetIfExists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryAuthorizationRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _disasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DisasterRecoveryAuthorizationRuleResource>(null, response.GetRawResponse());
                return Response.FromValue(new DisasterRecoveryAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DisasterRecoveryAuthorizationRuleResource> IEnumerable<DisasterRecoveryAuthorizationRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DisasterRecoveryAuthorizationRuleResource> IAsyncEnumerable<DisasterRecoveryAuthorizationRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
