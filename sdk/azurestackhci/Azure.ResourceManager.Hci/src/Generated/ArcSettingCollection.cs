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

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing a collection of <see cref="ArcSettingResource"/> and their operations.
    /// Each <see cref="ArcSettingResource"/> in the collection will belong to the same instance of <see cref="HciClusterResource"/>.
    /// To get an <see cref="ArcSettingCollection"/> instance call the GetArcSettings method from an instance of <see cref="HciClusterResource"/>.
    /// </summary>
    public partial class ArcSettingCollection : ArmCollection, IEnumerable<ArcSettingResource>, IAsyncEnumerable<ArcSettingResource>
    {
        private readonly ClientDiagnostics _arcSettingClientDiagnostics;
        private readonly ArcSettingsRestOperations _arcSettingRestClient;

        /// <summary> Initializes a new instance of the <see cref="ArcSettingCollection"/> class for mocking. </summary>
        protected ArcSettingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ArcSettingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ArcSettingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _arcSettingClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Hci", ArcSettingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ArcSettingResource.ResourceType, out string arcSettingApiVersion);
            _arcSettingRestClient = new ArcSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, arcSettingApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HciClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HciClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create ArcSetting for HCI cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArcSettings_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="data"> Parameters supplied to the Create ArcSetting resource for this HCI cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="arcSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="arcSettingName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ArcSettingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string arcSettingName, ArcSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(arcSettingName, nameof(arcSettingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _arcSettingRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, arcSettingName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HciArmOperation<ArcSettingResource>(Response.FromValue(new ArcSettingResource(Client, response), response.GetRawResponse()));
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
        /// Create ArcSetting for HCI cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArcSettings_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="data"> Parameters supplied to the Create ArcSetting resource for this HCI cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="arcSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="arcSettingName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ArcSettingResource> CreateOrUpdate(WaitUntil waitUntil, string arcSettingName, ArcSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(arcSettingName, nameof(arcSettingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _arcSettingRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, arcSettingName, data, cancellationToken);
                var operation = new HciArmOperation<ArcSettingResource>(Response.FromValue(new ArcSettingResource(Client, response), response.GetRawResponse()));
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
        /// Get ArcSetting resource details of HCI Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArcSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="arcSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="arcSettingName"/> is null. </exception>
        public virtual async Task<Response<ArcSettingResource>> GetAsync(string arcSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(arcSettingName, nameof(arcSettingName));

            using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSettingCollection.Get");
            scope.Start();
            try
            {
                var response = await _arcSettingRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, arcSettingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArcSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get ArcSetting resource details of HCI Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArcSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="arcSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="arcSettingName"/> is null. </exception>
        public virtual Response<ArcSettingResource> Get(string arcSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(arcSettingName, nameof(arcSettingName));

            using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSettingCollection.Get");
            scope.Start();
            try
            {
                var response = _arcSettingRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, arcSettingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArcSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get ArcSetting resources of HCI Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArcSettings_ListByCluster</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ArcSettingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ArcSettingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _arcSettingRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _arcSettingRestClient.CreateListByClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ArcSettingResource(Client, ArcSettingData.DeserializeArcSettingData(e)), _arcSettingClientDiagnostics, Pipeline, "ArcSettingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get ArcSetting resources of HCI Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArcSettings_ListByCluster</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ArcSettingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ArcSettingResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _arcSettingRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _arcSettingRestClient.CreateListByClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ArcSettingResource(Client, ArcSettingData.DeserializeArcSettingData(e)), _arcSettingClientDiagnostics, Pipeline, "ArcSettingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArcSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="arcSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="arcSettingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string arcSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(arcSettingName, nameof(arcSettingName));

            using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _arcSettingRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, arcSettingName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArcSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="arcSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="arcSettingName"/> is null. </exception>
        public virtual Response<bool> Exists(string arcSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(arcSettingName, nameof(arcSettingName));

            using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = _arcSettingRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, arcSettingName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArcSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="arcSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="arcSettingName"/> is null. </exception>
        public virtual async Task<NullableResponse<ArcSettingResource>> GetIfExistsAsync(string arcSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(arcSettingName, nameof(arcSettingName));

            using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _arcSettingRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, arcSettingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ArcSettingResource>(response.GetRawResponse());
                return Response.FromValue(new ArcSettingResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArcSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="arcSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="arcSettingName"/> is null. </exception>
        public virtual NullableResponse<ArcSettingResource> GetIfExists(string arcSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(arcSettingName, nameof(arcSettingName));

            using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _arcSettingRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, arcSettingName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ArcSettingResource>(response.GetRawResponse());
                return Response.FromValue(new ArcSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ArcSettingResource> IEnumerable<ArcSettingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ArcSettingResource> IAsyncEnumerable<ArcSettingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
