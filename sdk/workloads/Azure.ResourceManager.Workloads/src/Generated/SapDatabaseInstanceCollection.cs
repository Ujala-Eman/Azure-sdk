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

namespace Azure.ResourceManager.Workloads
{
    /// <summary>
    /// A class representing a collection of <see cref="SapDatabaseInstanceResource" /> and their operations.
    /// Each <see cref="SapDatabaseInstanceResource" /> in the collection will belong to the same instance of <see cref="SapVirtualInstanceResource" />.
    /// To get a <see cref="SapDatabaseInstanceCollection" /> instance call the GetSapDatabaseInstances method from an instance of <see cref="SapVirtualInstanceResource" />.
    /// </summary>
    public partial class SapDatabaseInstanceCollection : ArmCollection, IEnumerable<SapDatabaseInstanceResource>, IAsyncEnumerable<SapDatabaseInstanceResource>
    {
        private readonly ClientDiagnostics _sapDatabaseInstanceSapDatabaseInstancesClientDiagnostics;
        private readonly SAPDatabaseInstancesRestOperations _sapDatabaseInstanceSapDatabaseInstancesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SapDatabaseInstanceCollection"/> class for mocking. </summary>
        protected SapDatabaseInstanceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SapDatabaseInstanceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SapDatabaseInstanceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sapDatabaseInstanceSapDatabaseInstancesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Workloads", SapDatabaseInstanceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SapDatabaseInstanceResource.ResourceType, out string sapDatabaseInstanceSapDatabaseInstancesApiVersion);
            _sapDatabaseInstanceSapDatabaseInstancesRestClient = new SAPDatabaseInstancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sapDatabaseInstanceSapDatabaseInstancesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SapVirtualInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SapVirtualInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates the Database resource corresponding to the Virtual Instance for SAP solutions resource. &lt;br&gt;&lt;br&gt;This will be used by service only. PUT by end user will return a Bad Request error.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/databaseInstances/{databaseInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SAPDatabaseInstances_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="databaseInstanceName"> Database resource name string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="data"> Request body of Database resource of a SAP system. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseInstanceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SapDatabaseInstanceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string databaseInstanceName, SapDatabaseInstanceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseInstanceName, nameof(databaseInstanceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sapDatabaseInstanceSapDatabaseInstancesClientDiagnostics.CreateScope("SapDatabaseInstanceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sapDatabaseInstanceSapDatabaseInstancesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseInstanceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new WorkloadsArmOperation<SapDatabaseInstanceResource>(new SapDatabaseInstanceOperationSource(Client), _sapDatabaseInstanceSapDatabaseInstancesClientDiagnostics, Pipeline, _sapDatabaseInstanceSapDatabaseInstancesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseInstanceName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates the Database resource corresponding to the Virtual Instance for SAP solutions resource. &lt;br&gt;&lt;br&gt;This will be used by service only. PUT by end user will return a Bad Request error.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/databaseInstances/{databaseInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SAPDatabaseInstances_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="databaseInstanceName"> Database resource name string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="data"> Request body of Database resource of a SAP system. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseInstanceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SapDatabaseInstanceResource> CreateOrUpdate(WaitUntil waitUntil, string databaseInstanceName, SapDatabaseInstanceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseInstanceName, nameof(databaseInstanceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sapDatabaseInstanceSapDatabaseInstancesClientDiagnostics.CreateScope("SapDatabaseInstanceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sapDatabaseInstanceSapDatabaseInstancesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseInstanceName, data, cancellationToken);
                var operation = new WorkloadsArmOperation<SapDatabaseInstanceResource>(new SapDatabaseInstanceOperationSource(Client), _sapDatabaseInstanceSapDatabaseInstancesClientDiagnostics, Pipeline, _sapDatabaseInstanceSapDatabaseInstancesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseInstanceName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the SAP Database Instance resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/databaseInstances/{databaseInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SAPDatabaseInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseInstanceName"> Database resource name string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseInstanceName"/> is null. </exception>
        public virtual async Task<Response<SapDatabaseInstanceResource>> GetAsync(string databaseInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseInstanceName, nameof(databaseInstanceName));

            using var scope = _sapDatabaseInstanceSapDatabaseInstancesClientDiagnostics.CreateScope("SapDatabaseInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = await _sapDatabaseInstanceSapDatabaseInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseInstanceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SapDatabaseInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the SAP Database Instance resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/databaseInstances/{databaseInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SAPDatabaseInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseInstanceName"> Database resource name string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseInstanceName"/> is null. </exception>
        public virtual Response<SapDatabaseInstanceResource> Get(string databaseInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseInstanceName, nameof(databaseInstanceName));

            using var scope = _sapDatabaseInstanceSapDatabaseInstancesClientDiagnostics.CreateScope("SapDatabaseInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = _sapDatabaseInstanceSapDatabaseInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseInstanceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SapDatabaseInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Database resources associated with a Virtual Instance for SAP solutions resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/databaseInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SAPDatabaseInstances_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SapDatabaseInstanceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SapDatabaseInstanceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sapDatabaseInstanceSapDatabaseInstancesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sapDatabaseInstanceSapDatabaseInstancesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SapDatabaseInstanceResource(Client, SapDatabaseInstanceData.DeserializeSapDatabaseInstanceData(e)), _sapDatabaseInstanceSapDatabaseInstancesClientDiagnostics, Pipeline, "SapDatabaseInstanceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the Database resources associated with a Virtual Instance for SAP solutions resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/databaseInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SAPDatabaseInstances_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SapDatabaseInstanceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SapDatabaseInstanceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sapDatabaseInstanceSapDatabaseInstancesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sapDatabaseInstanceSapDatabaseInstancesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SapDatabaseInstanceResource(Client, SapDatabaseInstanceData.DeserializeSapDatabaseInstanceData(e)), _sapDatabaseInstanceSapDatabaseInstancesClientDiagnostics, Pipeline, "SapDatabaseInstanceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/databaseInstances/{databaseInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SAPDatabaseInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseInstanceName"> Database resource name string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseInstanceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string databaseInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseInstanceName, nameof(databaseInstanceName));

            using var scope = _sapDatabaseInstanceSapDatabaseInstancesClientDiagnostics.CreateScope("SapDatabaseInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sapDatabaseInstanceSapDatabaseInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseInstanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/databaseInstances/{databaseInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SAPDatabaseInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseInstanceName"> Database resource name string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseInstanceName"/> is null. </exception>
        public virtual Response<bool> Exists(string databaseInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseInstanceName, nameof(databaseInstanceName));

            using var scope = _sapDatabaseInstanceSapDatabaseInstancesClientDiagnostics.CreateScope("SapDatabaseInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = _sapDatabaseInstanceSapDatabaseInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseInstanceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SapDatabaseInstanceResource> IEnumerable<SapDatabaseInstanceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SapDatabaseInstanceResource> IAsyncEnumerable<SapDatabaseInstanceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
