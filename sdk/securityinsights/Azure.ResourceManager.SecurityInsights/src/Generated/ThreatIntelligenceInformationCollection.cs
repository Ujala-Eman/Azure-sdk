// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="ThreatIntelligenceInformationResource" /> and their operations.
    /// Each <see cref="ThreatIntelligenceInformationResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ThreatIntelligenceInformationCollection" /> instance call the GetThreatIntelligenceInformation method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ThreatIntelligenceInformationCollection : ArmCollection, IEnumerable<ThreatIntelligenceInformationResource>, IAsyncEnumerable<ThreatIntelligenceInformationResource>
    {
        private readonly ClientDiagnostics _threatIntelligenceInformationThreatIntelligenceIndicatorClientDiagnostics;
        private readonly ThreatIntelligenceIndicatorRestOperations _threatIntelligenceInformationThreatIntelligenceIndicatorRestClient;
        private readonly ClientDiagnostics _threatIntelligenceInformationThreatIntelligenceIndicatorsClientDiagnostics;
        private readonly ThreatIntelligenceIndicatorsRestOperations _threatIntelligenceInformationThreatIntelligenceIndicatorsRestClient;
        private readonly string _workspaceName;

        /// <summary> Initializes a new instance of the <see cref="ThreatIntelligenceInformationCollection"/> class for mocking. </summary>
        protected ThreatIntelligenceInformationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ThreatIntelligenceInformationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        internal ThreatIntelligenceInformationCollection(ArmClient client, ResourceIdentifier id, string workspaceName) : base(client, id)
        {
            _workspaceName = workspaceName;
            _threatIntelligenceInformationThreatIntelligenceIndicatorClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", ThreatIntelligenceInformationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ThreatIntelligenceInformationResource.ResourceType, out string threatIntelligenceInformationThreatIntelligenceIndicatorApiVersion);
            _threatIntelligenceInformationThreatIntelligenceIndicatorRestClient = new ThreatIntelligenceIndicatorRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, threatIntelligenceInformationThreatIntelligenceIndicatorApiVersion);
            _threatIntelligenceInformationThreatIntelligenceIndicatorsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", ThreatIntelligenceInformationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ThreatIntelligenceInformationResource.ResourceType, out string threatIntelligenceInformationThreatIntelligenceIndicatorsApiVersion);
            _threatIntelligenceInformationThreatIntelligenceIndicatorsRestClient = new ThreatIntelligenceIndicatorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, threatIntelligenceInformationThreatIntelligenceIndicatorsApiVersion);
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
        /// Update a threat Intelligence indicator.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators/{name}
        /// Operation Id: ThreatIntelligenceIndicator_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Threat intelligence indicator name field. </param>
        /// <param name="threatIntelligenceProperties"> Properties of threat intelligence indicators to create and update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="threatIntelligenceProperties"/> is null. </exception>
        public virtual async Task<ArmOperation<ThreatIntelligenceInformationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, ThreatIntelligenceIndicatorModel threatIntelligenceProperties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(threatIntelligenceProperties, nameof(threatIntelligenceProperties));

            using var scope = _threatIntelligenceInformationThreatIntelligenceIndicatorClientDiagnostics.CreateScope("ThreatIntelligenceInformationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _threatIntelligenceInformationThreatIntelligenceIndicatorRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, name, threatIntelligenceProperties, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityInsightsArmOperation<ThreatIntelligenceInformationResource>(Response.FromValue(new ThreatIntelligenceInformationResource(Client, response), response.GetRawResponse()));
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
        /// Update a threat Intelligence indicator.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators/{name}
        /// Operation Id: ThreatIntelligenceIndicator_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Threat intelligence indicator name field. </param>
        /// <param name="threatIntelligenceProperties"> Properties of threat intelligence indicators to create and update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="threatIntelligenceProperties"/> is null. </exception>
        public virtual ArmOperation<ThreatIntelligenceInformationResource> CreateOrUpdate(WaitUntil waitUntil, string name, ThreatIntelligenceIndicatorModel threatIntelligenceProperties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(threatIntelligenceProperties, nameof(threatIntelligenceProperties));

            using var scope = _threatIntelligenceInformationThreatIntelligenceIndicatorClientDiagnostics.CreateScope("ThreatIntelligenceInformationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _threatIntelligenceInformationThreatIntelligenceIndicatorRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, name, threatIntelligenceProperties, cancellationToken);
                var operation = new SecurityInsightsArmOperation<ThreatIntelligenceInformationResource>(Response.FromValue(new ThreatIntelligenceInformationResource(Client, response), response.GetRawResponse()));
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
        /// View a threat intelligence indicator by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators/{name}
        /// Operation Id: ThreatIntelligenceIndicator_Get
        /// </summary>
        /// <param name="name"> Threat intelligence indicator name field. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<ThreatIntelligenceInformationResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _threatIntelligenceInformationThreatIntelligenceIndicatorClientDiagnostics.CreateScope("ThreatIntelligenceInformationCollection.Get");
            scope.Start();
            try
            {
                var response = await _threatIntelligenceInformationThreatIntelligenceIndicatorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ThreatIntelligenceInformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// View a threat intelligence indicator by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators/{name}
        /// Operation Id: ThreatIntelligenceIndicator_Get
        /// </summary>
        /// <param name="name"> Threat intelligence indicator name field. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<ThreatIntelligenceInformationResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _threatIntelligenceInformationThreatIntelligenceIndicatorClientDiagnostics.CreateScope("ThreatIntelligenceInformationCollection.Get");
            scope.Start();
            try
            {
                var response = _threatIntelligenceInformationThreatIntelligenceIndicatorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ThreatIntelligenceInformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all threat intelligence indicators.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators
        /// Operation Id: ThreatIntelligenceIndicators_List
        /// </summary>
        /// <param name="filter"> Filters the results, based on a Boolean condition. Optional. </param>
        /// <param name="orderby"> Sorts the results. Optional. </param>
        /// <param name="top"> Returns only the first n results. Optional. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ThreatIntelligenceInformationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ThreatIntelligenceInformationResource> GetAllAsync(string filter = null, string orderby = null, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ThreatIntelligenceInformationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _threatIntelligenceInformationThreatIntelligenceIndicatorsClientDiagnostics.CreateScope("ThreatIntelligenceInformationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _threatIntelligenceInformationThreatIntelligenceIndicatorsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, filter, orderby, top, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ThreatIntelligenceInformationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ThreatIntelligenceInformationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _threatIntelligenceInformationThreatIntelligenceIndicatorsClientDiagnostics.CreateScope("ThreatIntelligenceInformationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _threatIntelligenceInformationThreatIntelligenceIndicatorsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, filter, orderby, top, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ThreatIntelligenceInformationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Get all threat intelligence indicators.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators
        /// Operation Id: ThreatIntelligenceIndicators_List
        /// </summary>
        /// <param name="filter"> Filters the results, based on a Boolean condition. Optional. </param>
        /// <param name="orderby"> Sorts the results. Optional. </param>
        /// <param name="top"> Returns only the first n results. Optional. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ThreatIntelligenceInformationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ThreatIntelligenceInformationResource> GetAll(string filter = null, string orderby = null, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<ThreatIntelligenceInformationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _threatIntelligenceInformationThreatIntelligenceIndicatorsClientDiagnostics.CreateScope("ThreatIntelligenceInformationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _threatIntelligenceInformationThreatIntelligenceIndicatorsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, filter, orderby, top, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ThreatIntelligenceInformationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ThreatIntelligenceInformationResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _threatIntelligenceInformationThreatIntelligenceIndicatorsClientDiagnostics.CreateScope("ThreatIntelligenceInformationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _threatIntelligenceInformationThreatIntelligenceIndicatorsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, filter, orderby, top, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ThreatIntelligenceInformationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators/{name}
        /// Operation Id: ThreatIntelligenceIndicator_Get
        /// </summary>
        /// <param name="name"> Threat intelligence indicator name field. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _threatIntelligenceInformationThreatIntelligenceIndicatorClientDiagnostics.CreateScope("ThreatIntelligenceInformationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _threatIntelligenceInformationThreatIntelligenceIndicatorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators/{name}
        /// Operation Id: ThreatIntelligenceIndicator_Get
        /// </summary>
        /// <param name="name"> Threat intelligence indicator name field. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _threatIntelligenceInformationThreatIntelligenceIndicatorClientDiagnostics.CreateScope("ThreatIntelligenceInformationCollection.Exists");
            scope.Start();
            try
            {
                var response = _threatIntelligenceInformationThreatIntelligenceIndicatorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _workspaceName, name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ThreatIntelligenceInformationResource> IEnumerable<ThreatIntelligenceInformationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ThreatIntelligenceInformationResource> IAsyncEnumerable<ThreatIntelligenceInformationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
