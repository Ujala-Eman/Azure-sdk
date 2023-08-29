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

namespace Azure.ResourceManager.Dynatrace
{
    /// <summary>
    /// A class representing a collection of <see cref="DynatraceSingleSignOnResource" /> and their operations.
    /// Each <see cref="DynatraceSingleSignOnResource" /> in the collection will belong to the same instance of <see cref="DynatraceMonitorResource" />.
    /// To get a <see cref="DynatraceSingleSignOnCollection" /> instance call the GetDynatraceSingleSignOns method from an instance of <see cref="DynatraceMonitorResource" />.
    /// </summary>
    public partial class DynatraceSingleSignOnCollection : ArmCollection, IEnumerable<DynatraceSingleSignOnResource>, IAsyncEnumerable<DynatraceSingleSignOnResource>
    {
        private readonly ClientDiagnostics _dynatraceSingleSignOnSingleSignOnClientDiagnostics;
        private readonly SingleSignOnRestOperations _dynatraceSingleSignOnSingleSignOnRestClient;

        /// <summary> Initializes a new instance of the <see cref="DynatraceSingleSignOnCollection"/> class for mocking. </summary>
        protected DynatraceSingleSignOnCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DynatraceSingleSignOnCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DynatraceSingleSignOnCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dynatraceSingleSignOnSingleSignOnClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Dynatrace", DynatraceSingleSignOnResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DynatraceSingleSignOnResource.ResourceType, out string dynatraceSingleSignOnSingleSignOnApiVersion);
            _dynatraceSingleSignOnSingleSignOnRestClient = new SingleSignOnRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dynatraceSingleSignOnSingleSignOnApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DynatraceMonitorResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DynatraceMonitorResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a DynatraceSingleSignOnResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOn_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationName"> Single Sign On Configuration Name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DynatraceSingleSignOnResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string configurationName, DynatraceSingleSignOnData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dynatraceSingleSignOnSingleSignOnClientDiagnostics.CreateScope("DynatraceSingleSignOnCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dynatraceSingleSignOnSingleSignOnRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DynatraceArmOperation<DynatraceSingleSignOnResource>(new DynatraceSingleSignOnOperationSource(Client), _dynatraceSingleSignOnSingleSignOnClientDiagnostics, Pipeline, _dynatraceSingleSignOnSingleSignOnRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a DynatraceSingleSignOnResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOn_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationName"> Single Sign On Configuration Name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DynatraceSingleSignOnResource> CreateOrUpdate(WaitUntil waitUntil, string configurationName, DynatraceSingleSignOnData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dynatraceSingleSignOnSingleSignOnClientDiagnostics.CreateScope("DynatraceSingleSignOnCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dynatraceSingleSignOnSingleSignOnRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data, cancellationToken);
                var operation = new DynatraceArmOperation<DynatraceSingleSignOnResource>(new DynatraceSingleSignOnOperationSource(Client), _dynatraceSingleSignOnSingleSignOnClientDiagnostics, Pipeline, _dynatraceSingleSignOnSingleSignOnRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a DynatraceSingleSignOnResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOn_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> Single Sign On Configuration Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual async Task<Response<DynatraceSingleSignOnResource>> GetAsync(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _dynatraceSingleSignOnSingleSignOnClientDiagnostics.CreateScope("DynatraceSingleSignOnCollection.Get");
            scope.Start();
            try
            {
                var response = await _dynatraceSingleSignOnSingleSignOnRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DynatraceSingleSignOnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a DynatraceSingleSignOnResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOn_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> Single Sign On Configuration Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual Response<DynatraceSingleSignOnResource> Get(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _dynatraceSingleSignOnSingleSignOnClientDiagnostics.CreateScope("DynatraceSingleSignOnCollection.Get");
            scope.Start();
            try
            {
                var response = _dynatraceSingleSignOnSingleSignOnRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DynatraceSingleSignOnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all DynatraceSingleSignOnResource by monitorName
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/singleSignOnConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOn_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DynatraceSingleSignOnResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DynatraceSingleSignOnResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dynatraceSingleSignOnSingleSignOnRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dynatraceSingleSignOnSingleSignOnRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DynatraceSingleSignOnResource(Client, DynatraceSingleSignOnData.DeserializeDynatraceSingleSignOnData(e)), _dynatraceSingleSignOnSingleSignOnClientDiagnostics, Pipeline, "DynatraceSingleSignOnCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all DynatraceSingleSignOnResource by monitorName
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/singleSignOnConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOn_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DynatraceSingleSignOnResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DynatraceSingleSignOnResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dynatraceSingleSignOnSingleSignOnRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dynatraceSingleSignOnSingleSignOnRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DynatraceSingleSignOnResource(Client, DynatraceSingleSignOnData.DeserializeDynatraceSingleSignOnData(e)), _dynatraceSingleSignOnSingleSignOnClientDiagnostics, Pipeline, "DynatraceSingleSignOnCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOn_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> Single Sign On Configuration Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _dynatraceSingleSignOnSingleSignOnClientDiagnostics.CreateScope("DynatraceSingleSignOnCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dynatraceSingleSignOnSingleSignOnRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOn_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> Single Sign On Configuration Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _dynatraceSingleSignOnSingleSignOnClientDiagnostics.CreateScope("DynatraceSingleSignOnCollection.Exists");
            scope.Start();
            try
            {
                var response = _dynatraceSingleSignOnSingleSignOnRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DynatraceSingleSignOnResource> IEnumerable<DynatraceSingleSignOnResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DynatraceSingleSignOnResource> IAsyncEnumerable<DynatraceSingleSignOnResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
