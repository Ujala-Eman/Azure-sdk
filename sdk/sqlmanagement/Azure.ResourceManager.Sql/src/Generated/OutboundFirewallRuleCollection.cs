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

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of OutboundFirewallRule and their operations over its parent. </summary>
    public partial class OutboundFirewallRuleCollection : ArmCollection, IEnumerable<OutboundFirewallRule>, IAsyncEnumerable<OutboundFirewallRule>
    {
        private readonly ClientDiagnostics _outboundFirewallRuleClientDiagnostics;
        private readonly OutboundFirewallRulesRestOperations _outboundFirewallRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="OutboundFirewallRuleCollection"/> class for mocking. </summary>
        protected OutboundFirewallRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OutboundFirewallRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal OutboundFirewallRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _outboundFirewallRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", OutboundFirewallRule.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(OutboundFirewallRule.ResourceType, out string outboundFirewallRuleApiVersion);
            _outboundFirewallRuleRestClient = new OutboundFirewallRulesRestOperations(_outboundFirewallRuleClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, outboundFirewallRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServer.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a outbound firewall rule with a given name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}
        /// Operation Id: OutboundFirewallRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="outboundRuleFqdn"> The String to use. </param>
        /// <param name="parameters"> The OutboundFirewallRule to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleFqdn"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleFqdn"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<OutboundFirewallRule>> CreateOrUpdateAsync(bool waitForCompletion, string outboundRuleFqdn, OutboundFirewallRuleData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleFqdn, nameof(outboundRuleFqdn));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _outboundFirewallRuleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleFqdn, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<OutboundFirewallRule>(new OutboundFirewallRuleOperationSource(Client), _outboundFirewallRuleClientDiagnostics, Pipeline, _outboundFirewallRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleFqdn, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Create a outbound firewall rule with a given name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}
        /// Operation Id: OutboundFirewallRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="outboundRuleFqdn"> The String to use. </param>
        /// <param name="parameters"> The OutboundFirewallRule to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleFqdn"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleFqdn"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<OutboundFirewallRule> CreateOrUpdate(bool waitForCompletion, string outboundRuleFqdn, OutboundFirewallRuleData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleFqdn, nameof(outboundRuleFqdn));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _outboundFirewallRuleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleFqdn, parameters, cancellationToken);
                var operation = new SqlArmOperation<OutboundFirewallRule>(new OutboundFirewallRuleOperationSource(Client), _outboundFirewallRuleClientDiagnostics, Pipeline, _outboundFirewallRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleFqdn, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Gets an outbound firewall rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}
        /// Operation Id: OutboundFirewallRules_Get
        /// </summary>
        /// <param name="outboundRuleFqdn"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleFqdn"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleFqdn"/> is null. </exception>
        public async virtual Task<Response<OutboundFirewallRule>> GetAsync(string outboundRuleFqdn, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleFqdn, nameof(outboundRuleFqdn));

            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _outboundFirewallRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleFqdn, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _outboundFirewallRuleClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new OutboundFirewallRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an outbound firewall rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}
        /// Operation Id: OutboundFirewallRules_Get
        /// </summary>
        /// <param name="outboundRuleFqdn"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleFqdn"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleFqdn"/> is null. </exception>
        public virtual Response<OutboundFirewallRule> Get(string outboundRuleFqdn, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleFqdn, nameof(outboundRuleFqdn));

            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _outboundFirewallRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleFqdn, cancellationToken);
                if (response.Value == null)
                    throw _outboundFirewallRuleClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OutboundFirewallRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all outbound firewall rules on a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules
        /// Operation Id: OutboundFirewallRules_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OutboundFirewallRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OutboundFirewallRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<OutboundFirewallRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _outboundFirewallRuleRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OutboundFirewallRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OutboundFirewallRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _outboundFirewallRuleRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OutboundFirewallRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all outbound firewall rules on a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules
        /// Operation Id: OutboundFirewallRules_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OutboundFirewallRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OutboundFirewallRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<OutboundFirewallRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _outboundFirewallRuleRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OutboundFirewallRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OutboundFirewallRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _outboundFirewallRuleRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OutboundFirewallRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}
        /// Operation Id: OutboundFirewallRules_Get
        /// </summary>
        /// <param name="outboundRuleFqdn"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleFqdn"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleFqdn"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string outboundRuleFqdn, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleFqdn, nameof(outboundRuleFqdn));

            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(outboundRuleFqdn, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}
        /// Operation Id: OutboundFirewallRules_Get
        /// </summary>
        /// <param name="outboundRuleFqdn"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleFqdn"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleFqdn"/> is null. </exception>
        public virtual Response<bool> Exists(string outboundRuleFqdn, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleFqdn, nameof(outboundRuleFqdn));

            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(outboundRuleFqdn, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}
        /// Operation Id: OutboundFirewallRules_Get
        /// </summary>
        /// <param name="outboundRuleFqdn"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleFqdn"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleFqdn"/> is null. </exception>
        public async virtual Task<Response<OutboundFirewallRule>> GetIfExistsAsync(string outboundRuleFqdn, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleFqdn, nameof(outboundRuleFqdn));

            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _outboundFirewallRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleFqdn, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<OutboundFirewallRule>(null, response.GetRawResponse());
                return Response.FromValue(new OutboundFirewallRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}
        /// Operation Id: OutboundFirewallRules_Get
        /// </summary>
        /// <param name="outboundRuleFqdn"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleFqdn"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleFqdn"/> is null. </exception>
        public virtual Response<OutboundFirewallRule> GetIfExists(string outboundRuleFqdn, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleFqdn, nameof(outboundRuleFqdn));

            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _outboundFirewallRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleFqdn, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<OutboundFirewallRule>(null, response.GetRawResponse());
                return Response.FromValue(new OutboundFirewallRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<OutboundFirewallRule> IEnumerable<OutboundFirewallRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<OutboundFirewallRule> IAsyncEnumerable<OutboundFirewallRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
