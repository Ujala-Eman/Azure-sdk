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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="AppServiceCertificateOrderResource" /> and their operations.
    /// Each <see cref="AppServiceCertificateOrderResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="AppServiceCertificateOrderCollection" /> instance call the GetAppServiceCertificateOrders method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class AppServiceCertificateOrderCollection : ArmCollection, IEnumerable<AppServiceCertificateOrderResource>, IAsyncEnumerable<AppServiceCertificateOrderResource>
    {
        private readonly ClientDiagnostics _appServiceCertificateOrderClientDiagnostics;
        private readonly AppServiceCertificateOrdersRestOperations _appServiceCertificateOrderRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppServiceCertificateOrderCollection"/> class for mocking. </summary>
        protected AppServiceCertificateOrderCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppServiceCertificateOrderCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppServiceCertificateOrderCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appServiceCertificateOrderClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", AppServiceCertificateOrderResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppServiceCertificateOrderResource.ResourceType, out string appServiceCertificateOrderApiVersion);
            _appServiceCertificateOrderRestClient = new AppServiceCertificateOrdersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appServiceCertificateOrderApiVersion);
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
        /// Description for Create or update a certificate purchase order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceCertificateOrders_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateOrderName"> Name of the certificate order. </param>
        /// <param name="data"> Distinguished name to use for the certificate order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateOrderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppServiceCertificateOrderResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string certificateOrderName, AppServiceCertificateOrderData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateOrderName, nameof(certificateOrderName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appServiceCertificateOrderClientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appServiceCertificateOrderRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<AppServiceCertificateOrderResource>(new AppServiceCertificateOrderOperationSource(Client), _appServiceCertificateOrderClientDiagnostics, Pipeline, _appServiceCertificateOrderRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Description for Create or update a certificate purchase order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceCertificateOrders_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateOrderName"> Name of the certificate order. </param>
        /// <param name="data"> Distinguished name to use for the certificate order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateOrderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppServiceCertificateOrderResource> CreateOrUpdate(WaitUntil waitUntil, string certificateOrderName, AppServiceCertificateOrderData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateOrderName, nameof(certificateOrderName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appServiceCertificateOrderClientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appServiceCertificateOrderRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, data, cancellationToken);
                var operation = new AppServiceArmOperation<AppServiceCertificateOrderResource>(new AppServiceCertificateOrderOperationSource(Client), _appServiceCertificateOrderClientDiagnostics, Pipeline, _appServiceCertificateOrderRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Description for Get a certificate order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceCertificateOrders_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateOrderName"> Name of the certificate order.. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateOrderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> is null. </exception>
        public virtual async Task<Response<AppServiceCertificateOrderResource>> GetAsync(string certificateOrderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateOrderName, nameof(certificateOrderName));

            using var scope = _appServiceCertificateOrderClientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.Get");
            scope.Start();
            try
            {
                var response = await _appServiceCertificateOrderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceCertificateOrderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get a certificate order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceCertificateOrders_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateOrderName"> Name of the certificate order.. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateOrderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> is null. </exception>
        public virtual Response<AppServiceCertificateOrderResource> Get(string certificateOrderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateOrderName, nameof(certificateOrderName));

            using var scope = _appServiceCertificateOrderClientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.Get");
            scope.Start();
            try
            {
                var response = _appServiceCertificateOrderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceCertificateOrderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get certificate orders in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceCertificateOrders_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppServiceCertificateOrderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppServiceCertificateOrderResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appServiceCertificateOrderRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appServiceCertificateOrderRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AppServiceCertificateOrderResource(Client, AppServiceCertificateOrderData.DeserializeAppServiceCertificateOrderData(e)), _appServiceCertificateOrderClientDiagnostics, Pipeline, "AppServiceCertificateOrderCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get certificate orders in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceCertificateOrders_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppServiceCertificateOrderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppServiceCertificateOrderResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appServiceCertificateOrderRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appServiceCertificateOrderRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AppServiceCertificateOrderResource(Client, AppServiceCertificateOrderData.DeserializeAppServiceCertificateOrderData(e)), _appServiceCertificateOrderClientDiagnostics, Pipeline, "AppServiceCertificateOrderCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceCertificateOrders_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateOrderName"> Name of the certificate order.. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateOrderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string certificateOrderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateOrderName, nameof(certificateOrderName));

            using var scope = _appServiceCertificateOrderClientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appServiceCertificateOrderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceCertificateOrders_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateOrderName"> Name of the certificate order.. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateOrderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> is null. </exception>
        public virtual Response<bool> Exists(string certificateOrderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateOrderName, nameof(certificateOrderName));

            using var scope = _appServiceCertificateOrderClientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.Exists");
            scope.Start();
            try
            {
                var response = _appServiceCertificateOrderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppServiceCertificateOrderResource> IEnumerable<AppServiceCertificateOrderResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppServiceCertificateOrderResource> IAsyncEnumerable<AppServiceCertificateOrderResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
