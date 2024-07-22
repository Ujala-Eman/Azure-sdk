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
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="DomainOwnershipIdentifierResource"/> and their operations.
    /// Each <see cref="DomainOwnershipIdentifierResource"/> in the collection will belong to the same instance of <see cref="AppServiceDomainResource"/>.
    /// To get a <see cref="DomainOwnershipIdentifierCollection"/> instance call the GetDomainOwnershipIdentifiers method from an instance of <see cref="AppServiceDomainResource"/>.
    /// </summary>
    public partial class DomainOwnershipIdentifierCollection : ArmCollection, IEnumerable<DomainOwnershipIdentifierResource>, IAsyncEnumerable<DomainOwnershipIdentifierResource>
    {
        private readonly ClientDiagnostics _domainOwnershipIdentifierDomainsClientDiagnostics;
        private readonly DomainsRestOperations _domainOwnershipIdentifierDomainsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DomainOwnershipIdentifierCollection"/> class for mocking. </summary>
        protected DomainOwnershipIdentifierCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DomainOwnershipIdentifierCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DomainOwnershipIdentifierCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _domainOwnershipIdentifierDomainsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", DomainOwnershipIdentifierResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DomainOwnershipIdentifierResource.ResourceType, out string domainOwnershipIdentifierDomainsApiVersion);
            _domainOwnershipIdentifierDomainsRestClient = new DomainsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, domainOwnershipIdentifierDomainsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppServiceDomainResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppServiceDomainResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Creates an ownership identifier for a domain or updates identifier details for an existing identifier
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_CreateOrUpdateOwnershipIdentifier</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DomainOwnershipIdentifierResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Name of identifier. </param>
        /// <param name="data"> A JSON representation of the domain ownership properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DomainOwnershipIdentifierResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, DomainOwnershipIdentifierData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _domainOwnershipIdentifierDomainsClientDiagnostics.CreateScope("DomainOwnershipIdentifierCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _domainOwnershipIdentifierDomainsRestClient.CreateOrUpdateOwnershipIdentifierAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var uri = _domainOwnershipIdentifierDomainsRestClient.CreateCreateOrUpdateOwnershipIdentifierRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AppServiceArmOperation<DomainOwnershipIdentifierResource>(Response.FromValue(new DomainOwnershipIdentifierResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Description for Creates an ownership identifier for a domain or updates identifier details for an existing identifier
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_CreateOrUpdateOwnershipIdentifier</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DomainOwnershipIdentifierResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Name of identifier. </param>
        /// <param name="data"> A JSON representation of the domain ownership properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DomainOwnershipIdentifierResource> CreateOrUpdate(WaitUntil waitUntil, string name, DomainOwnershipIdentifierData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _domainOwnershipIdentifierDomainsClientDiagnostics.CreateScope("DomainOwnershipIdentifierCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _domainOwnershipIdentifierDomainsRestClient.CreateOrUpdateOwnershipIdentifier(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var uri = _domainOwnershipIdentifierDomainsRestClient.CreateCreateOrUpdateOwnershipIdentifierRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AppServiceArmOperation<DomainOwnershipIdentifierResource>(Response.FromValue(new DomainOwnershipIdentifierResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Description for Get ownership identifier for domain
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_GetOwnershipIdentifier</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DomainOwnershipIdentifierResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DomainOwnershipIdentifierResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _domainOwnershipIdentifierDomainsClientDiagnostics.CreateScope("DomainOwnershipIdentifierCollection.Get");
            scope.Start();
            try
            {
                var response = await _domainOwnershipIdentifierDomainsRestClient.GetOwnershipIdentifierAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DomainOwnershipIdentifierResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get ownership identifier for domain
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_GetOwnershipIdentifier</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DomainOwnershipIdentifierResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DomainOwnershipIdentifierResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _domainOwnershipIdentifierDomainsClientDiagnostics.CreateScope("DomainOwnershipIdentifierCollection.Get");
            scope.Start();
            try
            {
                var response = _domainOwnershipIdentifierDomainsRestClient.GetOwnershipIdentifier(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DomainOwnershipIdentifierResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Lists domain ownership identifiers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_ListOwnershipIdentifiers</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DomainOwnershipIdentifierResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DomainOwnershipIdentifierResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DomainOwnershipIdentifierResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _domainOwnershipIdentifierDomainsRestClient.CreateListOwnershipIdentifiersRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _domainOwnershipIdentifierDomainsRestClient.CreateListOwnershipIdentifiersNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DomainOwnershipIdentifierResource(Client, DomainOwnershipIdentifierData.DeserializeDomainOwnershipIdentifierData(e)), _domainOwnershipIdentifierDomainsClientDiagnostics, Pipeline, "DomainOwnershipIdentifierCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Lists domain ownership identifiers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_ListOwnershipIdentifiers</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DomainOwnershipIdentifierResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DomainOwnershipIdentifierResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DomainOwnershipIdentifierResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _domainOwnershipIdentifierDomainsRestClient.CreateListOwnershipIdentifiersRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _domainOwnershipIdentifierDomainsRestClient.CreateListOwnershipIdentifiersNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DomainOwnershipIdentifierResource(Client, DomainOwnershipIdentifierData.DeserializeDomainOwnershipIdentifierData(e)), _domainOwnershipIdentifierDomainsClientDiagnostics, Pipeline, "DomainOwnershipIdentifierCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_GetOwnershipIdentifier</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DomainOwnershipIdentifierResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _domainOwnershipIdentifierDomainsClientDiagnostics.CreateScope("DomainOwnershipIdentifierCollection.Exists");
            scope.Start();
            try
            {
                var response = await _domainOwnershipIdentifierDomainsRestClient.GetOwnershipIdentifierAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_GetOwnershipIdentifier</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DomainOwnershipIdentifierResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _domainOwnershipIdentifierDomainsClientDiagnostics.CreateScope("DomainOwnershipIdentifierCollection.Exists");
            scope.Start();
            try
            {
                var response = _domainOwnershipIdentifierDomainsRestClient.GetOwnershipIdentifier(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_GetOwnershipIdentifier</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DomainOwnershipIdentifierResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<DomainOwnershipIdentifierResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _domainOwnershipIdentifierDomainsClientDiagnostics.CreateScope("DomainOwnershipIdentifierCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _domainOwnershipIdentifierDomainsRestClient.GetOwnershipIdentifierAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DomainOwnershipIdentifierResource>(response.GetRawResponse());
                return Response.FromValue(new DomainOwnershipIdentifierResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_GetOwnershipIdentifier</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DomainOwnershipIdentifierResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<DomainOwnershipIdentifierResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _domainOwnershipIdentifierDomainsClientDiagnostics.CreateScope("DomainOwnershipIdentifierCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _domainOwnershipIdentifierDomainsRestClient.GetOwnershipIdentifier(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DomainOwnershipIdentifierResource>(response.GetRawResponse());
                return Response.FromValue(new DomainOwnershipIdentifierResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DomainOwnershipIdentifierResource> IEnumerable<DomainOwnershipIdentifierResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DomainOwnershipIdentifierResource> IAsyncEnumerable<DomainOwnershipIdentifierResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
