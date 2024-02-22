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

namespace Azure.ResourceManager.Purview
{
    /// <summary>
    /// A class representing a collection of <see cref="PurviewAccountResource"/> and their operations.
    /// Each <see cref="PurviewAccountResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="PurviewAccountCollection"/> instance call the GetPurviewAccounts method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class PurviewAccountCollection : ArmCollection, IEnumerable<PurviewAccountResource>, IAsyncEnumerable<PurviewAccountResource>
    {
        private readonly ClientDiagnostics _purviewAccountAccountsClientDiagnostics;
        private readonly AccountsRestOperations _purviewAccountAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="PurviewAccountCollection"/> class for mocking. </summary>
        protected PurviewAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PurviewAccountCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PurviewAccountCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _purviewAccountAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Purview", PurviewAccountResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PurviewAccountResource.ResourceType, out string purviewAccountAccountsApiVersion);
            _purviewAccountAccountsRestClient = new AccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, purviewAccountAccountsApiVersion);
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
        /// Creates or updates an account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accountName"> The name of the account. </param>
        /// <param name="data"> The account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PurviewAccountResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string accountName, PurviewAccountData data, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _purviewAccountAccountsClientDiagnostics.CreateScope("PurviewAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _purviewAccountAccountsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, data, cancellationToken).ConfigureAwait(false);
                var operation = new PurviewArmOperation<PurviewAccountResource>(new PurviewAccountOperationSource(Client), _purviewAccountAccountsClientDiagnostics, Pipeline, _purviewAccountAccountsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, accountName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accountName"> The name of the account. </param>
        /// <param name="data"> The account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PurviewAccountResource> CreateOrUpdate(WaitUntil waitUntil, string accountName, PurviewAccountData data, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _purviewAccountAccountsClientDiagnostics.CreateScope("PurviewAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _purviewAccountAccountsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, accountName, data, cancellationToken);
                var operation = new PurviewArmOperation<PurviewAccountResource>(new PurviewAccountOperationSource(Client), _purviewAccountAccountsClientDiagnostics, Pipeline, _purviewAccountAccountsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, accountName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get an account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<PurviewAccountResource>> GetAsync(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }

            using var scope = _purviewAccountAccountsClientDiagnostics.CreateScope("PurviewAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _purviewAccountAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PurviewAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<PurviewAccountResource> Get(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }

            using var scope = _purviewAccountAccountsClientDiagnostics.CreateScope("PurviewAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _purviewAccountAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PurviewAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List accounts in ResourceGroup
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> The skip token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PurviewAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PurviewAccountResource> GetAllAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _purviewAccountAccountsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _purviewAccountAccountsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PurviewAccountResource(Client, PurviewAccountData.DeserializePurviewAccountData(e)), _purviewAccountAccountsClientDiagnostics, Pipeline, "PurviewAccountCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List accounts in ResourceGroup
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> The skip token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PurviewAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PurviewAccountResource> GetAll(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _purviewAccountAccountsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _purviewAccountAccountsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PurviewAccountResource(Client, PurviewAccountData.DeserializePurviewAccountData(e)), _purviewAccountAccountsClientDiagnostics, Pipeline, "PurviewAccountCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }

            using var scope = _purviewAccountAccountsClientDiagnostics.CreateScope("PurviewAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await _purviewAccountAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<bool> Exists(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }

            using var scope = _purviewAccountAccountsClientDiagnostics.CreateScope("PurviewAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = _purviewAccountAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<NullableResponse<PurviewAccountResource>> GetIfExistsAsync(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }

            using var scope = _purviewAccountAccountsClientDiagnostics.CreateScope("PurviewAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _purviewAccountAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PurviewAccountResource>(response.GetRawResponse());
                return Response.FromValue(new PurviewAccountResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PurviewAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual NullableResponse<PurviewAccountResource> GetIfExists(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }

            using var scope = _purviewAccountAccountsClientDiagnostics.CreateScope("PurviewAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _purviewAccountAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PurviewAccountResource>(response.GetRawResponse());
                return Response.FromValue(new PurviewAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PurviewAccountResource> IEnumerable<PurviewAccountResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PurviewAccountResource> IAsyncEnumerable<PurviewAccountResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
