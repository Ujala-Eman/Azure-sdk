// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PlaywrightTesting
{
    /// <summary>
    /// A class representing a collection of <see cref="PlaywrightTestingAccountResource"/> and their operations.
    /// Each <see cref="PlaywrightTestingAccountResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="PlaywrightTestingAccountCollection"/> instance call the GetPlaywrightTestingAccounts method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class PlaywrightTestingAccountCollection : ArmCollection, IEnumerable<PlaywrightTestingAccountResource>, IAsyncEnumerable<PlaywrightTestingAccountResource>
    {
        private readonly ClientDiagnostics _playwrightTestingAccountAccountsClientDiagnostics;
        private readonly AccountsRestOperations _playwrightTestingAccountAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="PlaywrightTestingAccountCollection"/> class for mocking. </summary>
        protected PlaywrightTestingAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PlaywrightTestingAccountCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PlaywrightTestingAccountCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _playwrightTestingAccountAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PlaywrightTesting", PlaywrightTestingAccountResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PlaywrightTestingAccountResource.ResourceType, out string playwrightTestingAccountAccountsApiVersion);
            _playwrightTestingAccountAccountsRestClient = new AccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, playwrightTestingAccountAccountsApiVersion);
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
        /// Create a Account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzurePlaywrightService/accounts/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Name of account. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PlaywrightTestingAccountResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, PlaywrightTestingAccountData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _playwrightTestingAccountAccountsClientDiagnostics.CreateScope("PlaywrightTestingAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _playwrightTestingAccountAccountsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new PlaywrightTestingArmOperation<PlaywrightTestingAccountResource>(new PlaywrightTestingAccountOperationSource(Client), _playwrightTestingAccountAccountsClientDiagnostics, Pipeline, _playwrightTestingAccountAccountsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a Account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzurePlaywrightService/accounts/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Name of account. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PlaywrightTestingAccountResource> CreateOrUpdate(WaitUntil waitUntil, string name, PlaywrightTestingAccountData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _playwrightTestingAccountAccountsClientDiagnostics.CreateScope("PlaywrightTestingAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _playwrightTestingAccountAccountsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, name, data, cancellationToken);
                var operation = new PlaywrightTestingArmOperation<PlaywrightTestingAccountResource>(new PlaywrightTestingAccountOperationSource(Client), _playwrightTestingAccountAccountsClientDiagnostics, Pipeline, _playwrightTestingAccountAccountsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a Account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzurePlaywrightService/accounts/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<PlaywrightTestingAccountResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _playwrightTestingAccountAccountsClientDiagnostics.CreateScope("PlaywrightTestingAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _playwrightTestingAccountAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PlaywrightTestingAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzurePlaywrightService/accounts/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<PlaywrightTestingAccountResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _playwrightTestingAccountAccountsClientDiagnostics.CreateScope("PlaywrightTestingAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _playwrightTestingAccountAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PlaywrightTestingAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Account resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzurePlaywrightService/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PlaywrightTestingAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PlaywrightTestingAccountResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _playwrightTestingAccountAccountsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _playwrightTestingAccountAccountsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PlaywrightTestingAccountResource(Client, PlaywrightTestingAccountData.DeserializePlaywrightTestingAccountData(e)), _playwrightTestingAccountAccountsClientDiagnostics, Pipeline, "PlaywrightTestingAccountCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Account resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzurePlaywrightService/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PlaywrightTestingAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PlaywrightTestingAccountResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _playwrightTestingAccountAccountsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _playwrightTestingAccountAccountsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PlaywrightTestingAccountResource(Client, PlaywrightTestingAccountData.DeserializePlaywrightTestingAccountData(e)), _playwrightTestingAccountAccountsClientDiagnostics, Pipeline, "PlaywrightTestingAccountCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzurePlaywrightService/accounts/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _playwrightTestingAccountAccountsClientDiagnostics.CreateScope("PlaywrightTestingAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await _playwrightTestingAccountAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzurePlaywrightService/accounts/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _playwrightTestingAccountAccountsClientDiagnostics.CreateScope("PlaywrightTestingAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = _playwrightTestingAccountAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzurePlaywrightService/accounts/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<PlaywrightTestingAccountResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _playwrightTestingAccountAccountsClientDiagnostics.CreateScope("PlaywrightTestingAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _playwrightTestingAccountAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PlaywrightTestingAccountResource>(response.GetRawResponse());
                return Response.FromValue(new PlaywrightTestingAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzurePlaywrightService/accounts/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<PlaywrightTestingAccountResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _playwrightTestingAccountAccountsClientDiagnostics.CreateScope("PlaywrightTestingAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _playwrightTestingAccountAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PlaywrightTestingAccountResource>(response.GetRawResponse());
                return Response.FromValue(new PlaywrightTestingAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PlaywrightTestingAccountResource> IEnumerable<PlaywrightTestingAccountResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PlaywrightTestingAccountResource> IAsyncEnumerable<PlaywrightTestingAccountResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
