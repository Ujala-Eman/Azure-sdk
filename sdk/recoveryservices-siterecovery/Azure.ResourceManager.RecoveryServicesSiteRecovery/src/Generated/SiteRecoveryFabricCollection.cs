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
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteRecoveryFabricResource" /> and their operations.
    /// Each <see cref="SiteRecoveryFabricResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="SiteRecoveryFabricCollection" /> instance call the GetSiteRecoveryFabrics method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class SiteRecoveryFabricCollection : ArmCollection, IEnumerable<SiteRecoveryFabricResource>, IAsyncEnumerable<SiteRecoveryFabricResource>
    {
        private readonly ClientDiagnostics _siteRecoveryFabricReplicationFabricsClientDiagnostics;
        private readonly ReplicationFabricsRestOperations _siteRecoveryFabricReplicationFabricsRestClient;
        private readonly string _resourceName;

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryFabricCollection"/> class for mocking. </summary>
        protected SiteRecoveryFabricCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryFabricCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        internal SiteRecoveryFabricCollection(ArmClient client, ResourceIdentifier id, string resourceName) : base(client, id)
        {
            _resourceName = resourceName;
            _siteRecoveryFabricReplicationFabricsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", SiteRecoveryFabricResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteRecoveryFabricResource.ResourceType, out string siteRecoveryFabricReplicationFabricsApiVersion);
            _siteRecoveryFabricReplicationFabricsRestClient = new ReplicationFabricsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteRecoveryFabricReplicationFabricsApiVersion);
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
        /// The operation to create an Azure Site Recovery fabric (for e.g. Hyper-V site).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationFabrics_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fabricName"> Name of the ASR fabric. </param>
        /// <param name="content"> Fabric creation input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteRecoveryFabricResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string fabricName, SiteRecoveryFabricCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _siteRecoveryFabricReplicationFabricsClientDiagnostics.CreateScope("SiteRecoveryFabricCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteRecoveryFabricReplicationFabricsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, fabricName, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryFabricResource>(new SiteRecoveryFabricOperationSource(Client), _siteRecoveryFabricReplicationFabricsClientDiagnostics, Pipeline, _siteRecoveryFabricReplicationFabricsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, fabricName, content).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to create an Azure Site Recovery fabric (for e.g. Hyper-V site).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationFabrics_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fabricName"> Name of the ASR fabric. </param>
        /// <param name="content"> Fabric creation input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<SiteRecoveryFabricResource> CreateOrUpdate(WaitUntil waitUntil, string fabricName, SiteRecoveryFabricCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _siteRecoveryFabricReplicationFabricsClientDiagnostics.CreateScope("SiteRecoveryFabricCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteRecoveryFabricReplicationFabricsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, fabricName, content, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryFabricResource>(new SiteRecoveryFabricOperationSource(Client), _siteRecoveryFabricReplicationFabricsClientDiagnostics, Pipeline, _siteRecoveryFabricReplicationFabricsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, fabricName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the details of an Azure Site Recovery fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationFabrics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fabricName"> Fabric name. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricName"/> is null. </exception>
        public virtual async Task<Response<SiteRecoveryFabricResource>> GetAsync(string fabricName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));

            using var scope = _siteRecoveryFabricReplicationFabricsClientDiagnostics.CreateScope("SiteRecoveryFabricCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteRecoveryFabricReplicationFabricsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, fabricName, filter, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryFabricResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of an Azure Site Recovery fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationFabrics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fabricName"> Fabric name. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricName"/> is null. </exception>
        public virtual Response<SiteRecoveryFabricResource> Get(string fabricName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));

            using var scope = _siteRecoveryFabricReplicationFabricsClientDiagnostics.CreateScope("SiteRecoveryFabricCollection.Get");
            scope.Start();
            try
            {
                var response = _siteRecoveryFabricReplicationFabricsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, fabricName, filter, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryFabricResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of the Azure Site Recovery fabrics in the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationFabrics_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteRecoveryFabricResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteRecoveryFabricResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteRecoveryFabricReplicationFabricsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteRecoveryFabricReplicationFabricsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SiteRecoveryFabricResource(Client, SiteRecoveryFabricData.DeserializeSiteRecoveryFabricData(e)), _siteRecoveryFabricReplicationFabricsClientDiagnostics, Pipeline, "SiteRecoveryFabricCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of the Azure Site Recovery fabrics in the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationFabrics_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteRecoveryFabricResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteRecoveryFabricResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteRecoveryFabricReplicationFabricsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteRecoveryFabricReplicationFabricsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SiteRecoveryFabricResource(Client, SiteRecoveryFabricData.DeserializeSiteRecoveryFabricData(e)), _siteRecoveryFabricReplicationFabricsClientDiagnostics, Pipeline, "SiteRecoveryFabricCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationFabrics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fabricName"> Fabric name. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string fabricName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));

            using var scope = _siteRecoveryFabricReplicationFabricsClientDiagnostics.CreateScope("SiteRecoveryFabricCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteRecoveryFabricReplicationFabricsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, fabricName, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationFabrics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fabricName"> Fabric name. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricName"/> is null. </exception>
        public virtual Response<bool> Exists(string fabricName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));

            using var scope = _siteRecoveryFabricReplicationFabricsClientDiagnostics.CreateScope("SiteRecoveryFabricCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteRecoveryFabricReplicationFabricsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, fabricName, filter, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationFabrics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fabricName"> Fabric name. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricName"/> is null. </exception>
        public virtual async Task<NullableResponse<SiteRecoveryFabricResource>> GetIfExistsAsync(string fabricName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));

            using var scope = _siteRecoveryFabricReplicationFabricsClientDiagnostics.CreateScope("SiteRecoveryFabricCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteRecoveryFabricReplicationFabricsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, fabricName, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SiteRecoveryFabricResource>(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryFabricResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationFabrics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fabricName"> Fabric name. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricName"/> is null. </exception>
        public virtual NullableResponse<SiteRecoveryFabricResource> GetIfExists(string fabricName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));

            using var scope = _siteRecoveryFabricReplicationFabricsClientDiagnostics.CreateScope("SiteRecoveryFabricCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteRecoveryFabricReplicationFabricsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, fabricName, filter, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SiteRecoveryFabricResource>(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryFabricResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteRecoveryFabricResource> IEnumerable<SiteRecoveryFabricResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteRecoveryFabricResource> IAsyncEnumerable<SiteRecoveryFabricResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
