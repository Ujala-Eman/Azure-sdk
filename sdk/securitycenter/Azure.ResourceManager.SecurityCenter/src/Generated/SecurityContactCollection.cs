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

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="SecurityContactResource"/> and their operations.
    /// Each <see cref="SecurityContactResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="SecurityContactCollection"/> instance call the GetSecurityContacts method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class SecurityContactCollection : ArmCollection, IEnumerable<SecurityContactResource>, IAsyncEnumerable<SecurityContactResource>
    {
        private readonly ClientDiagnostics _securityContactClientDiagnostics;
        private readonly SecurityContactsRestOperations _securityContactRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityContactCollection"/> class for mocking. </summary>
        protected SecurityContactCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityContactCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityContactCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityContactClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", SecurityContactResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityContactResource.ResourceType, out string securityContactApiVersion);
            _securityContactRestClient = new SecurityContactsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityContactApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create security contact configurations for the subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/securityContacts/{securityContactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityContacts_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityContactResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityContactName"> Name of the security contact object. </param>
        /// <param name="data"> Security contact object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityContactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityContactName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityContactResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string securityContactName, SecurityContactData data, CancellationToken cancellationToken = default)
        {
            if (securityContactName == null)
            {
                throw new ArgumentNullException(nameof(securityContactName));
            }
            if (securityContactName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(securityContactName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _securityContactClientDiagnostics.CreateScope("SecurityContactCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _securityContactRestClient.CreateAsync(Id.SubscriptionId, securityContactName, data, cancellationToken).ConfigureAwait(false);
                var uri = _securityContactRestClient.CreateCreateRequestUri(Id.SubscriptionId, securityContactName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityCenterArmOperation<SecurityContactResource>(Response.FromValue(new SecurityContactResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create security contact configurations for the subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/securityContacts/{securityContactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityContacts_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityContactResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityContactName"> Name of the security contact object. </param>
        /// <param name="data"> Security contact object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityContactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityContactName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityContactResource> CreateOrUpdate(WaitUntil waitUntil, string securityContactName, SecurityContactData data, CancellationToken cancellationToken = default)
        {
            if (securityContactName == null)
            {
                throw new ArgumentNullException(nameof(securityContactName));
            }
            if (securityContactName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(securityContactName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _securityContactClientDiagnostics.CreateScope("SecurityContactCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _securityContactRestClient.Create(Id.SubscriptionId, securityContactName, data, cancellationToken);
                var uri = _securityContactRestClient.CreateCreateRequestUri(Id.SubscriptionId, securityContactName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityCenterArmOperation<SecurityContactResource>(Response.FromValue(new SecurityContactResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get Default Security contact configurations for the subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/securityContacts/{securityContactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityContacts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityContactResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityContactName"> Name of the security contact object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityContactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityContactName"/> is null. </exception>
        public virtual async Task<Response<SecurityContactResource>> GetAsync(string securityContactName, CancellationToken cancellationToken = default)
        {
            if (securityContactName == null)
            {
                throw new ArgumentNullException(nameof(securityContactName));
            }
            if (securityContactName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(securityContactName));
            }

            using var scope = _securityContactClientDiagnostics.CreateScope("SecurityContactCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityContactRestClient.GetAsync(Id.SubscriptionId, securityContactName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityContactResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Default Security contact configurations for the subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/securityContacts/{securityContactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityContacts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityContactResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityContactName"> Name of the security contact object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityContactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityContactName"/> is null. </exception>
        public virtual Response<SecurityContactResource> Get(string securityContactName, CancellationToken cancellationToken = default)
        {
            if (securityContactName == null)
            {
                throw new ArgumentNullException(nameof(securityContactName));
            }
            if (securityContactName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(securityContactName));
            }

            using var scope = _securityContactClientDiagnostics.CreateScope("SecurityContactCollection.Get");
            scope.Start();
            try
            {
                var response = _securityContactRestClient.Get(Id.SubscriptionId, securityContactName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityContactResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all security contact configurations for the subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/securityContacts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityContacts_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityContactResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityContactResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityContactResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityContactRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityContactRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SecurityContactResource(Client, SecurityContactData.DeserializeSecurityContactData(e)), _securityContactClientDiagnostics, Pipeline, "SecurityContactCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all security contact configurations for the subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/securityContacts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityContacts_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityContactResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityContactResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityContactResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityContactRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityContactRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SecurityContactResource(Client, SecurityContactData.DeserializeSecurityContactData(e)), _securityContactClientDiagnostics, Pipeline, "SecurityContactCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/securityContacts/{securityContactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityContacts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityContactResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityContactName"> Name of the security contact object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityContactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityContactName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string securityContactName, CancellationToken cancellationToken = default)
        {
            if (securityContactName == null)
            {
                throw new ArgumentNullException(nameof(securityContactName));
            }
            if (securityContactName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(securityContactName));
            }

            using var scope = _securityContactClientDiagnostics.CreateScope("SecurityContactCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityContactRestClient.GetAsync(Id.SubscriptionId, securityContactName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/securityContacts/{securityContactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityContacts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityContactResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityContactName"> Name of the security contact object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityContactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityContactName"/> is null. </exception>
        public virtual Response<bool> Exists(string securityContactName, CancellationToken cancellationToken = default)
        {
            if (securityContactName == null)
            {
                throw new ArgumentNullException(nameof(securityContactName));
            }
            if (securityContactName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(securityContactName));
            }

            using var scope = _securityContactClientDiagnostics.CreateScope("SecurityContactCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityContactRestClient.Get(Id.SubscriptionId, securityContactName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/securityContacts/{securityContactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityContacts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityContactResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityContactName"> Name of the security contact object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityContactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityContactName"/> is null. </exception>
        public virtual async Task<NullableResponse<SecurityContactResource>> GetIfExistsAsync(string securityContactName, CancellationToken cancellationToken = default)
        {
            if (securityContactName == null)
            {
                throw new ArgumentNullException(nameof(securityContactName));
            }
            if (securityContactName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(securityContactName));
            }

            using var scope = _securityContactClientDiagnostics.CreateScope("SecurityContactCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _securityContactRestClient.GetAsync(Id.SubscriptionId, securityContactName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SecurityContactResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityContactResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/securityContacts/{securityContactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityContacts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityContactResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityContactName"> Name of the security contact object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityContactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityContactName"/> is null. </exception>
        public virtual NullableResponse<SecurityContactResource> GetIfExists(string securityContactName, CancellationToken cancellationToken = default)
        {
            if (securityContactName == null)
            {
                throw new ArgumentNullException(nameof(securityContactName));
            }
            if (securityContactName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(securityContactName));
            }

            using var scope = _securityContactClientDiagnostics.CreateScope("SecurityContactCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _securityContactRestClient.Get(Id.SubscriptionId, securityContactName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SecurityContactResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityContactResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityContactResource> IEnumerable<SecurityContactResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityContactResource> IAsyncEnumerable<SecurityContactResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
