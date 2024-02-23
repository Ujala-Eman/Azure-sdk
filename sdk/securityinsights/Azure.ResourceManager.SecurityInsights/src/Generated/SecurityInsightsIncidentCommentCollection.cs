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

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="SecurityInsightsIncidentCommentResource"/> and their operations.
    /// Each <see cref="SecurityInsightsIncidentCommentResource"/> in the collection will belong to the same instance of <see cref="SecurityInsightsIncidentResource"/>.
    /// To get a <see cref="SecurityInsightsIncidentCommentCollection"/> instance call the GetSecurityInsightsIncidentComments method from an instance of <see cref="SecurityInsightsIncidentResource"/>.
    /// </summary>
    public partial class SecurityInsightsIncidentCommentCollection : ArmCollection, IEnumerable<SecurityInsightsIncidentCommentResource>, IAsyncEnumerable<SecurityInsightsIncidentCommentResource>
    {
        private readonly ClientDiagnostics _securityInsightsIncidentCommentIncidentCommentsClientDiagnostics;
        private readonly IncidentCommentsRestOperations _securityInsightsIncidentCommentIncidentCommentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsIncidentCommentCollection"/> class for mocking. </summary>
        protected SecurityInsightsIncidentCommentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsIncidentCommentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityInsightsIncidentCommentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityInsightsIncidentCommentIncidentCommentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", SecurityInsightsIncidentCommentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityInsightsIncidentCommentResource.ResourceType, out string securityInsightsIncidentCommentIncidentCommentsApiVersion);
            _securityInsightsIncidentCommentIncidentCommentsRestClient = new IncidentCommentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityInsightsIncidentCommentIncidentCommentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SecurityInsightsIncidentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SecurityInsightsIncidentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a comment for a given incident.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/comments/{incidentCommentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IncidentComments_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsIncidentCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="incidentCommentId"> Incident comment ID. </param>
        /// <param name="data"> The incident comment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="incidentCommentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="incidentCommentId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityInsightsIncidentCommentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string incidentCommentId, SecurityInsightsIncidentCommentData data, CancellationToken cancellationToken = default)
        {
            if (incidentCommentId == null)
            {
                throw new ArgumentNullException(nameof(incidentCommentId));
            }
            if (incidentCommentId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(incidentCommentId));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _securityInsightsIncidentCommentIncidentCommentsClientDiagnostics.CreateScope("SecurityInsightsIncidentCommentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _securityInsightsIncidentCommentIncidentCommentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, incidentCommentId, data, cancellationToken).ConfigureAwait(false);
                var uri = _securityInsightsIncidentCommentIncidentCommentsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, incidentCommentId, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityInsightsArmOperation<SecurityInsightsIncidentCommentResource>(Response.FromValue(new SecurityInsightsIncidentCommentResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates or updates a comment for a given incident.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/comments/{incidentCommentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IncidentComments_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsIncidentCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="incidentCommentId"> Incident comment ID. </param>
        /// <param name="data"> The incident comment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="incidentCommentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="incidentCommentId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityInsightsIncidentCommentResource> CreateOrUpdate(WaitUntil waitUntil, string incidentCommentId, SecurityInsightsIncidentCommentData data, CancellationToken cancellationToken = default)
        {
            if (incidentCommentId == null)
            {
                throw new ArgumentNullException(nameof(incidentCommentId));
            }
            if (incidentCommentId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(incidentCommentId));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _securityInsightsIncidentCommentIncidentCommentsClientDiagnostics.CreateScope("SecurityInsightsIncidentCommentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _securityInsightsIncidentCommentIncidentCommentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, incidentCommentId, data, cancellationToken);
                var uri = _securityInsightsIncidentCommentIncidentCommentsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, incidentCommentId, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityInsightsArmOperation<SecurityInsightsIncidentCommentResource>(Response.FromValue(new SecurityInsightsIncidentCommentResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets a comment for a given incident.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/comments/{incidentCommentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IncidentComments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsIncidentCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="incidentCommentId"> Incident comment ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="incidentCommentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="incidentCommentId"/> is null. </exception>
        public virtual async Task<Response<SecurityInsightsIncidentCommentResource>> GetAsync(string incidentCommentId, CancellationToken cancellationToken = default)
        {
            if (incidentCommentId == null)
            {
                throw new ArgumentNullException(nameof(incidentCommentId));
            }
            if (incidentCommentId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(incidentCommentId));
            }

            using var scope = _securityInsightsIncidentCommentIncidentCommentsClientDiagnostics.CreateScope("SecurityInsightsIncidentCommentCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityInsightsIncidentCommentIncidentCommentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, incidentCommentId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsIncidentCommentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a comment for a given incident.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/comments/{incidentCommentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IncidentComments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsIncidentCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="incidentCommentId"> Incident comment ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="incidentCommentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="incidentCommentId"/> is null. </exception>
        public virtual Response<SecurityInsightsIncidentCommentResource> Get(string incidentCommentId, CancellationToken cancellationToken = default)
        {
            if (incidentCommentId == null)
            {
                throw new ArgumentNullException(nameof(incidentCommentId));
            }
            if (incidentCommentId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(incidentCommentId));
            }

            using var scope = _securityInsightsIncidentCommentIncidentCommentsClientDiagnostics.CreateScope("SecurityInsightsIncidentCommentCollection.Get");
            scope.Start();
            try
            {
                var response = _securityInsightsIncidentCommentIncidentCommentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, incidentCommentId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsIncidentCommentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all comments for a given incident.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/comments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IncidentComments_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsIncidentCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filters the results, based on a Boolean condition. Optional. </param>
        /// <param name="orderBy"> Sorts the results. Optional. </param>
        /// <param name="top"> Returns only the first n results. Optional. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityInsightsIncidentCommentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityInsightsIncidentCommentResource> GetAllAsync(string filter = null, string orderBy = null, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityInsightsIncidentCommentIncidentCommentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, orderBy, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityInsightsIncidentCommentIncidentCommentsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, orderBy, top, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SecurityInsightsIncidentCommentResource(Client, SecurityInsightsIncidentCommentData.DeserializeSecurityInsightsIncidentCommentData(e)), _securityInsightsIncidentCommentIncidentCommentsClientDiagnostics, Pipeline, "SecurityInsightsIncidentCommentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all comments for a given incident.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/comments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IncidentComments_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsIncidentCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filters the results, based on a Boolean condition. Optional. </param>
        /// <param name="orderBy"> Sorts the results. Optional. </param>
        /// <param name="top"> Returns only the first n results. Optional. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityInsightsIncidentCommentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityInsightsIncidentCommentResource> GetAll(string filter = null, string orderBy = null, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityInsightsIncidentCommentIncidentCommentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, orderBy, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityInsightsIncidentCommentIncidentCommentsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, orderBy, top, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SecurityInsightsIncidentCommentResource(Client, SecurityInsightsIncidentCommentData.DeserializeSecurityInsightsIncidentCommentData(e)), _securityInsightsIncidentCommentIncidentCommentsClientDiagnostics, Pipeline, "SecurityInsightsIncidentCommentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/comments/{incidentCommentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IncidentComments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsIncidentCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="incidentCommentId"> Incident comment ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="incidentCommentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="incidentCommentId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string incidentCommentId, CancellationToken cancellationToken = default)
        {
            if (incidentCommentId == null)
            {
                throw new ArgumentNullException(nameof(incidentCommentId));
            }
            if (incidentCommentId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(incidentCommentId));
            }

            using var scope = _securityInsightsIncidentCommentIncidentCommentsClientDiagnostics.CreateScope("SecurityInsightsIncidentCommentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityInsightsIncidentCommentIncidentCommentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, incidentCommentId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/comments/{incidentCommentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IncidentComments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsIncidentCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="incidentCommentId"> Incident comment ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="incidentCommentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="incidentCommentId"/> is null. </exception>
        public virtual Response<bool> Exists(string incidentCommentId, CancellationToken cancellationToken = default)
        {
            if (incidentCommentId == null)
            {
                throw new ArgumentNullException(nameof(incidentCommentId));
            }
            if (incidentCommentId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(incidentCommentId));
            }

            using var scope = _securityInsightsIncidentCommentIncidentCommentsClientDiagnostics.CreateScope("SecurityInsightsIncidentCommentCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityInsightsIncidentCommentIncidentCommentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, incidentCommentId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/comments/{incidentCommentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IncidentComments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsIncidentCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="incidentCommentId"> Incident comment ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="incidentCommentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="incidentCommentId"/> is null. </exception>
        public virtual async Task<NullableResponse<SecurityInsightsIncidentCommentResource>> GetIfExistsAsync(string incidentCommentId, CancellationToken cancellationToken = default)
        {
            if (incidentCommentId == null)
            {
                throw new ArgumentNullException(nameof(incidentCommentId));
            }
            if (incidentCommentId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(incidentCommentId));
            }

            using var scope = _securityInsightsIncidentCommentIncidentCommentsClientDiagnostics.CreateScope("SecurityInsightsIncidentCommentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _securityInsightsIncidentCommentIncidentCommentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, incidentCommentId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SecurityInsightsIncidentCommentResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsIncidentCommentResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}/comments/{incidentCommentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IncidentComments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsIncidentCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="incidentCommentId"> Incident comment ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="incidentCommentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="incidentCommentId"/> is null. </exception>
        public virtual NullableResponse<SecurityInsightsIncidentCommentResource> GetIfExists(string incidentCommentId, CancellationToken cancellationToken = default)
        {
            if (incidentCommentId == null)
            {
                throw new ArgumentNullException(nameof(incidentCommentId));
            }
            if (incidentCommentId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(incidentCommentId));
            }

            using var scope = _securityInsightsIncidentCommentIncidentCommentsClientDiagnostics.CreateScope("SecurityInsightsIncidentCommentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _securityInsightsIncidentCommentIncidentCommentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, incidentCommentId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SecurityInsightsIncidentCommentResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsIncidentCommentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityInsightsIncidentCommentResource> IEnumerable<SecurityInsightsIncidentCommentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityInsightsIncidentCommentResource> IAsyncEnumerable<SecurityInsightsIncidentCommentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
