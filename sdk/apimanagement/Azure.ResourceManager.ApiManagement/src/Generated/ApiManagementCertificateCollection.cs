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
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementCertificateResource" /> and their operations.
    /// Each <see cref="ApiManagementCertificateResource" /> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource" />.
    /// To get an <see cref="ApiManagementCertificateCollection" /> instance call the GetApiManagementCertificates method from an instance of <see cref="ApiManagementServiceResource" />.
    /// </summary>
    public partial class ApiManagementCertificateCollection : ArmCollection, IEnumerable<ApiManagementCertificateResource>, IAsyncEnumerable<ApiManagementCertificateResource>
    {
        private readonly ClientDiagnostics _apiManagementCertificateCertificateClientDiagnostics;
        private readonly CertificateRestOperations _apiManagementCertificateCertificateRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementCertificateCollection"/> class for mocking. </summary>
        protected ApiManagementCertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementCertificateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementCertificateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementCertificateCertificateClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementCertificateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementCertificateResource.ResourceType, out string apiManagementCertificateCertificateApiVersion);
            _apiManagementCertificateCertificateRestClient = new CertificateRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementCertificateCertificateApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the certificate being used for authentication with the backend.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/certificates/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateId"> Identifier of the certificate entity. Must be unique in the current API Management service instance. </param>
        /// <param name="content"> Create or Update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateId"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementCertificateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string certificateId, ApiManagementCertificateCreateOrUpdateContent content, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateId, nameof(certificateId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiManagementCertificateCertificateClientDiagnostics.CreateScope("ApiManagementCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementCertificateCertificateRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateId, content, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementCertificateResource>(Response.FromValue(new ApiManagementCertificateResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates the certificate being used for authentication with the backend.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/certificates/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateId"> Identifier of the certificate entity. Must be unique in the current API Management service instance. </param>
        /// <param name="content"> Create or Update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateId"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ApiManagementCertificateResource> CreateOrUpdate(WaitUntil waitUntil, string certificateId, ApiManagementCertificateCreateOrUpdateContent content, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateId, nameof(certificateId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiManagementCertificateCertificateClientDiagnostics.CreateScope("ApiManagementCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementCertificateCertificateRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateId, content, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementCertificateResource>(Response.FromValue(new ApiManagementCertificateResource(Client, response), response.GetRawResponse()));
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
        /// Gets the details of the certificate specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/certificates/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateId"> Identifier of the certificate entity. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateId"/> is null. </exception>
        public virtual async Task<Response<ApiManagementCertificateResource>> GetAsync(string certificateId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateId, nameof(certificateId));

            using var scope = _apiManagementCertificateCertificateClientDiagnostics.CreateScope("ApiManagementCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementCertificateCertificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the certificate specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/certificates/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateId"> Identifier of the certificate entity. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateId"/> is null. </exception>
        public virtual Response<ApiManagementCertificateResource> Get(string certificateId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateId, nameof(certificateId));

            using var scope = _apiManagementCertificateCertificateClientDiagnostics.CreateScope("ApiManagementCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementCertificateCertificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of all certificates in the specified service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| subject | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| thumbprint | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| expirationDate | filter | ge, le, eq, ne, gt, lt |     |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="isKeyVaultRefreshFailed"> When set to true, the response contains only certificates entities which failed refresh. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementCertificateResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, bool? isKeyVaultRefreshFailed = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementCertificateCertificateRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, isKeyVaultRefreshFailed);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementCertificateCertificateRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, isKeyVaultRefreshFailed);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ApiManagementCertificateResource(Client, ApiManagementCertificateData.DeserializeApiManagementCertificateData(e)), _apiManagementCertificateCertificateClientDiagnostics, Pipeline, "ApiManagementCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a collection of all certificates in the specified service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| subject | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| thumbprint | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| expirationDate | filter | ge, le, eq, ne, gt, lt |     |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="isKeyVaultRefreshFailed"> When set to true, the response contains only certificates entities which failed refresh. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementCertificateResource> GetAll(string filter = null, int? top = null, int? skip = null, bool? isKeyVaultRefreshFailed = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementCertificateCertificateRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, isKeyVaultRefreshFailed);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementCertificateCertificateRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, isKeyVaultRefreshFailed);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ApiManagementCertificateResource(Client, ApiManagementCertificateData.DeserializeApiManagementCertificateData(e)), _apiManagementCertificateCertificateClientDiagnostics, Pipeline, "ApiManagementCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/certificates/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateId"> Identifier of the certificate entity. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string certificateId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateId, nameof(certificateId));

            using var scope = _apiManagementCertificateCertificateClientDiagnostics.CreateScope("ApiManagementCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementCertificateCertificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/certificates/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateId"> Identifier of the certificate entity. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateId"/> is null. </exception>
        public virtual Response<bool> Exists(string certificateId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateId, nameof(certificateId));

            using var scope = _apiManagementCertificateCertificateClientDiagnostics.CreateScope("ApiManagementCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementCertificateCertificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementCertificateResource> IEnumerable<ApiManagementCertificateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementCertificateResource> IAsyncEnumerable<ApiManagementCertificateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
