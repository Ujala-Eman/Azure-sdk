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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="SecurityPartnerProviderResource" /> and their operations.
    /// Each <see cref="SecurityPartnerProviderResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="SecurityPartnerProviderCollection" /> instance call the GetSecurityPartnerProviders method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class SecurityPartnerProviderCollection : ArmCollection, IEnumerable<SecurityPartnerProviderResource>, IAsyncEnumerable<SecurityPartnerProviderResource>
    {
        private readonly ClientDiagnostics _securityPartnerProviderClientDiagnostics;
        private readonly SecurityPartnerProvidersRestOperations _securityPartnerProviderRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityPartnerProviderCollection"/> class for mocking. </summary>
        protected SecurityPartnerProviderCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityPartnerProviderCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityPartnerProviderCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityPartnerProviderClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", SecurityPartnerProviderResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityPartnerProviderResource.ResourceType, out string securityPartnerProviderApiVersion);
            _securityPartnerProviderRestClient = new SecurityPartnerProvidersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityPartnerProviderApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the specified Security Partner Provider.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/securityPartnerProviders/{securityPartnerProviderName}
        /// Operation Id: SecurityPartnerProviders_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Security Partner Provider operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPartnerProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPartnerProviderName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityPartnerProviderResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string securityPartnerProviderName, SecurityPartnerProviderData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPartnerProviderName, nameof(securityPartnerProviderName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _securityPartnerProviderClientDiagnostics.CreateScope("SecurityPartnerProviderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _securityPartnerProviderRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, securityPartnerProviderName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<SecurityPartnerProviderResource>(new SecurityPartnerProviderOperationSource(Client), _securityPartnerProviderClientDiagnostics, Pipeline, _securityPartnerProviderRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, securityPartnerProviderName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
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
        /// Creates or updates the specified Security Partner Provider.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/securityPartnerProviders/{securityPartnerProviderName}
        /// Operation Id: SecurityPartnerProviders_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Security Partner Provider operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPartnerProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPartnerProviderName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<SecurityPartnerProviderResource> CreateOrUpdate(WaitUntil waitUntil, string securityPartnerProviderName, SecurityPartnerProviderData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPartnerProviderName, nameof(securityPartnerProviderName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _securityPartnerProviderClientDiagnostics.CreateScope("SecurityPartnerProviderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _securityPartnerProviderRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, securityPartnerProviderName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<SecurityPartnerProviderResource>(new SecurityPartnerProviderOperationSource(Client), _securityPartnerProviderClientDiagnostics, Pipeline, _securityPartnerProviderRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, securityPartnerProviderName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
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
        /// Gets the specified Security Partner Provider.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/securityPartnerProviders/{securityPartnerProviderName}
        /// Operation Id: SecurityPartnerProviders_Get
        /// </summary>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPartnerProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPartnerProviderName"/> is null. </exception>
        public virtual async Task<Response<SecurityPartnerProviderResource>> GetAsync(string securityPartnerProviderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPartnerProviderName, nameof(securityPartnerProviderName));

            using var scope = _securityPartnerProviderClientDiagnostics.CreateScope("SecurityPartnerProviderCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityPartnerProviderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, securityPartnerProviderName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityPartnerProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Security Partner Provider.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/securityPartnerProviders/{securityPartnerProviderName}
        /// Operation Id: SecurityPartnerProviders_Get
        /// </summary>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPartnerProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPartnerProviderName"/> is null. </exception>
        public virtual Response<SecurityPartnerProviderResource> Get(string securityPartnerProviderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPartnerProviderName, nameof(securityPartnerProviderName));

            using var scope = _securityPartnerProviderClientDiagnostics.CreateScope("SecurityPartnerProviderCollection.Get");
            scope.Start();
            try
            {
                var response = _securityPartnerProviderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, securityPartnerProviderName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityPartnerProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Security Partner Providers in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/securityPartnerProviders
        /// Operation Id: SecurityPartnerProviders_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityPartnerProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityPartnerProviderResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SecurityPartnerProviderResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _securityPartnerProviderClientDiagnostics.CreateScope("SecurityPartnerProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _securityPartnerProviderRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SecurityPartnerProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SecurityPartnerProviderResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _securityPartnerProviderClientDiagnostics.CreateScope("SecurityPartnerProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _securityPartnerProviderRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SecurityPartnerProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all Security Partner Providers in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/securityPartnerProviders
        /// Operation Id: SecurityPartnerProviders_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityPartnerProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityPartnerProviderResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SecurityPartnerProviderResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _securityPartnerProviderClientDiagnostics.CreateScope("SecurityPartnerProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _securityPartnerProviderRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SecurityPartnerProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SecurityPartnerProviderResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _securityPartnerProviderClientDiagnostics.CreateScope("SecurityPartnerProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _securityPartnerProviderRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SecurityPartnerProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/securityPartnerProviders/{securityPartnerProviderName}
        /// Operation Id: SecurityPartnerProviders_Get
        /// </summary>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPartnerProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPartnerProviderName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string securityPartnerProviderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPartnerProviderName, nameof(securityPartnerProviderName));

            using var scope = _securityPartnerProviderClientDiagnostics.CreateScope("SecurityPartnerProviderCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(securityPartnerProviderName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/securityPartnerProviders/{securityPartnerProviderName}
        /// Operation Id: SecurityPartnerProviders_Get
        /// </summary>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPartnerProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPartnerProviderName"/> is null. </exception>
        public virtual Response<bool> Exists(string securityPartnerProviderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPartnerProviderName, nameof(securityPartnerProviderName));

            using var scope = _securityPartnerProviderClientDiagnostics.CreateScope("SecurityPartnerProviderCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(securityPartnerProviderName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/securityPartnerProviders/{securityPartnerProviderName}
        /// Operation Id: SecurityPartnerProviders_Get
        /// </summary>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPartnerProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPartnerProviderName"/> is null. </exception>
        public virtual async Task<Response<SecurityPartnerProviderResource>> GetIfExistsAsync(string securityPartnerProviderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPartnerProviderName, nameof(securityPartnerProviderName));

            using var scope = _securityPartnerProviderClientDiagnostics.CreateScope("SecurityPartnerProviderCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _securityPartnerProviderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, securityPartnerProviderName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SecurityPartnerProviderResource>(null, response.GetRawResponse());
                return Response.FromValue(new SecurityPartnerProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/securityPartnerProviders/{securityPartnerProviderName}
        /// Operation Id: SecurityPartnerProviders_Get
        /// </summary>
        /// <param name="securityPartnerProviderName"> The name of the Security Partner Provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityPartnerProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPartnerProviderName"/> is null. </exception>
        public virtual Response<SecurityPartnerProviderResource> GetIfExists(string securityPartnerProviderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityPartnerProviderName, nameof(securityPartnerProviderName));

            using var scope = _securityPartnerProviderClientDiagnostics.CreateScope("SecurityPartnerProviderCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _securityPartnerProviderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, securityPartnerProviderName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SecurityPartnerProviderResource>(null, response.GetRawResponse());
                return Response.FromValue(new SecurityPartnerProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityPartnerProviderResource> IEnumerable<SecurityPartnerProviderResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityPartnerProviderResource> IAsyncEnumerable<SecurityPartnerProviderResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
