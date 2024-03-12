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
    /// A class representing a collection of <see cref="SecurityConnectorResource"/> and their operations.
    /// Each <see cref="SecurityConnectorResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="SecurityConnectorCollection"/> instance call the GetSecurityConnectors method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class SecurityConnectorCollection : ArmCollection, IEnumerable<SecurityConnectorResource>, IAsyncEnumerable<SecurityConnectorResource>
    {
        private readonly ClientDiagnostics _securityConnectorClientDiagnostics;
        private readonly SecurityConnectorsRestOperations _securityConnectorRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityConnectorCollection"/> class for mocking. </summary>
        protected SecurityConnectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityConnectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityConnectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityConnectorClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", SecurityConnectorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityConnectorResource.ResourceType, out string securityConnectorApiVersion);
            _securityConnectorRestClient = new SecurityConnectorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityConnectorApiVersion);
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
        /// Creates or updates a security connector. If a security connector is already created and a subsequent request is issued for the same security connector id, then it will be updated.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectors_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="data"> The security connector resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityConnectorName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityConnectorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string securityConnectorName, SecurityConnectorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityConnectorName, nameof(securityConnectorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityConnectorClientDiagnostics.CreateScope("SecurityConnectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _securityConnectorRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, securityConnectorName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<SecurityConnectorResource>(Response.FromValue(new SecurityConnectorResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a security connector. If a security connector is already created and a subsequent request is issued for the same security connector id, then it will be updated.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectors_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="data"> The security connector resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityConnectorName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityConnectorResource> CreateOrUpdate(WaitUntil waitUntil, string securityConnectorName, SecurityConnectorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityConnectorName, nameof(securityConnectorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityConnectorClientDiagnostics.CreateScope("SecurityConnectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _securityConnectorRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, securityConnectorName, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<SecurityConnectorResource>(Response.FromValue(new SecurityConnectorResource(Client, response), response.GetRawResponse()));
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
        /// Retrieves details of a specific security connector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityConnectorName"/> is null. </exception>
        public virtual async Task<Response<SecurityConnectorResource>> GetAsync(string securityConnectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityConnectorName, nameof(securityConnectorName));

            using var scope = _securityConnectorClientDiagnostics.CreateScope("SecurityConnectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityConnectorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, securityConnectorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves details of a specific security connector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityConnectorName"/> is null. </exception>
        public virtual Response<SecurityConnectorResource> Get(string securityConnectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityConnectorName, nameof(securityConnectorName));

            using var scope = _securityConnectorClientDiagnostics.CreateScope("SecurityConnectorCollection.Get");
            scope.Start();
            try
            {
                var response = _securityConnectorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, securityConnectorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the security connectors in the specified resource group. Use the 'nextLink' property in the response to get the next page of security connectors for the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectors_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityConnectorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityConnectorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityConnectorRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityConnectorRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SecurityConnectorResource(Client, SecurityConnectorData.DeserializeSecurityConnectorData(e)), _securityConnectorClientDiagnostics, Pipeline, "SecurityConnectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the security connectors in the specified resource group. Use the 'nextLink' property in the response to get the next page of security connectors for the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectors_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityConnectorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityConnectorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityConnectorRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityConnectorRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SecurityConnectorResource(Client, SecurityConnectorData.DeserializeSecurityConnectorData(e)), _securityConnectorClientDiagnostics, Pipeline, "SecurityConnectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityConnectorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string securityConnectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityConnectorName, nameof(securityConnectorName));

            using var scope = _securityConnectorClientDiagnostics.CreateScope("SecurityConnectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityConnectorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, securityConnectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityConnectorName"/> is null. </exception>
        public virtual Response<bool> Exists(string securityConnectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityConnectorName, nameof(securityConnectorName));

            using var scope = _securityConnectorClientDiagnostics.CreateScope("SecurityConnectorCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityConnectorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, securityConnectorName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityConnectorName"/> is null. </exception>
        public virtual async Task<NullableResponse<SecurityConnectorResource>> GetIfExistsAsync(string securityConnectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityConnectorName, nameof(securityConnectorName));

            using var scope = _securityConnectorClientDiagnostics.CreateScope("SecurityConnectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _securityConnectorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, securityConnectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SecurityConnectorResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityConnectorName"/> is null. </exception>
        public virtual NullableResponse<SecurityConnectorResource> GetIfExists(string securityConnectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityConnectorName, nameof(securityConnectorName));

            using var scope = _securityConnectorClientDiagnostics.CreateScope("SecurityConnectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _securityConnectorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, securityConnectorName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SecurityConnectorResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityConnectorResource> IEnumerable<SecurityConnectorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityConnectorResource> IAsyncEnumerable<SecurityConnectorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
