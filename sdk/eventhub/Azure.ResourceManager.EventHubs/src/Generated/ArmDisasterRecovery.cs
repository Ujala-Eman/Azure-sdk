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
using Azure.ResourceManager.EventHub.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.EventHub
{
    /// <summary> A Class representing a ArmDisasterRecovery along with the instance operations that can be performed on it. </summary>
    public partial class ArmDisasterRecovery : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DisasterRecoveryConfigsRestOperations _restClient;
        private readonly ArmDisasterRecoveryData _data;

        /// <summary> Initializes a new instance of the <see cref="ArmDisasterRecovery"/> class for mocking. </summary>
        protected ArmDisasterRecovery()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ArmDisasterRecovery"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ArmDisasterRecovery(ArmResource options, ArmDisasterRecoveryData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new DisasterRecoveryConfigsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="ArmDisasterRecovery"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ArmDisasterRecovery(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new DisasterRecoveryConfigsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.EventHub/namespaces/disasterRecoveryConfigs";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ArmDisasterRecoveryData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Retrieves Alias(Disaster Recovery configuration) for primary or secondary namespace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ArmDisasterRecovery>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ArmDisasterRecovery.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ArmDisasterRecovery(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves Alias(Disaster Recovery configuration) for primary or secondary namespace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ArmDisasterRecovery> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ArmDisasterRecovery.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArmDisasterRecovery(this, response.Value), response.GetRawResponse());
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

        /// <summary> Deletes an Alias(Disaster Recovery configuration). </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<DisasterRecoveryConfigDeleteOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ArmDisasterRecovery.Delete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DisasterRecoveryConfigDeleteOperation(response);
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

        /// <summary> Deletes an Alias(Disaster Recovery configuration). </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual DisasterRecoveryConfigDeleteOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ArmDisasterRecovery.Delete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DisasterRecoveryConfigDeleteOperation(response);
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
        /// <summary> Gets an AuthorizationRule for a Namespace by rule name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AuthorizationRuleData>> GetAuthorizationRuleAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ArmDisasterRecovery.GetAuthorizationRule");
            scope.Start();
            try
            {
                var response = await _restClient.GetAuthorizationRuleAsync(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an AuthorizationRule for a Namespace by rule name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AuthorizationRuleData> GetAuthorizationRule(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ArmDisasterRecovery.GetAuthorizationRule");
            scope.Start();
            try
            {
                var response = _restClient.GetAuthorizationRule(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Check the give Namespace name availability. </summary>
        /// <param name="parameters"> Parameters to check availability of the given Alias name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<Response<CheckNameAvailabilityResult>> CheckNameAvailabilityAsync(CheckNameAvailabilityParameter parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ArmDisasterRecovery.CheckNameAvailability");
            scope.Start();
            try
            {
                var response = await _restClient.CheckNameAvailabilityAsync(Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Check the give Namespace name availability. </summary>
        /// <param name="parameters"> Parameters to check availability of the given Alias name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<CheckNameAvailabilityResult> CheckNameAvailability(CheckNameAvailabilityParameter parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ArmDisasterRecovery.CheckNameAvailability");
            scope.Start();
            try
            {
                var response = _restClient.CheckNameAvailability(Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation disables the Disaster Recovery and stops replicating changes from primary to secondary namespaces. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> BreakPairingAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ArmDisasterRecovery.BreakPairing");
            scope.Start();
            try
            {
                var response = await _restClient.BreakPairingAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation disables the Disaster Recovery and stops replicating changes from primary to secondary namespaces. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response BreakPairing(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ArmDisasterRecovery.BreakPairing");
            scope.Start();
            try
            {
                var response = _restClient.BreakPairing(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Invokes GEO DR failover and reconfigure the alias to point to the secondary namespace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> FailOverAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ArmDisasterRecovery.FailOver");
            scope.Start();
            try
            {
                var response = await _restClient.FailOverAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Invokes GEO DR failover and reconfigure the alias to point to the secondary namespace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response FailOver(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ArmDisasterRecovery.FailOver");
            scope.Start();
            try
            {
                var response = _restClient.FailOver(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of authorization rules for a Namespace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AuthorizationRuleData" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AuthorizationRuleData> GetAuthorizationRules(CancellationToken cancellationToken = default)
        {
            Page<AuthorizationRuleData> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ArmDisasterRecovery.GetAuthorizationRules");
                scope.Start();
                try
                {
                    var response = _restClient.GetAuthorizationRules(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AuthorizationRuleData> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ArmDisasterRecovery.GetAuthorizationRules");
                scope.Start();
                try
                {
                    var response = _restClient.GetAuthorizationRulesNextPage(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
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

        /// <summary> Gets a list of authorization rules for a Namespace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AuthorizationRuleData" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AuthorizationRuleData> GetAuthorizationRulesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AuthorizationRuleData>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ArmDisasterRecovery.GetAuthorizationRules");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAuthorizationRulesAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AuthorizationRuleData>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ArmDisasterRecovery.GetAuthorizationRules");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAuthorizationRulesNextPageAsync(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
    }
}
