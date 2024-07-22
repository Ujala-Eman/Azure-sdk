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
    /// A class representing a collection of <see cref="WorkflowRunActionScopeRepetitionResource"/> and their operations.
    /// Each <see cref="WorkflowRunActionScopeRepetitionResource"/> in the collection will belong to the same instance of <see cref="WorkflowRunActionResource"/>.
    /// To get a <see cref="WorkflowRunActionScopeRepetitionCollection"/> instance call the GetWorkflowRunActionScopeRepetitions method from an instance of <see cref="WorkflowRunActionResource"/>.
    /// </summary>
    public partial class WorkflowRunActionScopeRepetitionCollection : ArmCollection, IEnumerable<WorkflowRunActionScopeRepetitionResource>, IAsyncEnumerable<WorkflowRunActionScopeRepetitionResource>
    {
        private readonly ClientDiagnostics _workflowRunActionScopeRepetitionClientDiagnostics;
        private readonly WorkflowRunActionScopeRepetitionsRestOperations _workflowRunActionScopeRepetitionRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkflowRunActionScopeRepetitionCollection"/> class for mocking. </summary>
        protected WorkflowRunActionScopeRepetitionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkflowRunActionScopeRepetitionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WorkflowRunActionScopeRepetitionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workflowRunActionScopeRepetitionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", WorkflowRunActionScopeRepetitionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WorkflowRunActionScopeRepetitionResource.ResourceType, out string workflowRunActionScopeRepetitionApiVersion);
            _workflowRunActionScopeRepetitionRestClient = new WorkflowRunActionScopeRepetitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workflowRunActionScopeRepetitionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WorkflowRunActionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WorkflowRunActionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a workflow run action scoped repetition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions/{repetitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionScopeRepetitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkflowRunActionScopeRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repetitionName"/> is null. </exception>
        public virtual async Task<Response<WorkflowRunActionScopeRepetitionResource>> GetAsync(string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var scope = _workflowRunActionScopeRepetitionClientDiagnostics.CreateScope("WorkflowRunActionScopeRepetitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _workflowRunActionScopeRepetitionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, repetitionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkflowRunActionScopeRepetitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a workflow run action scoped repetition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions/{repetitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionScopeRepetitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkflowRunActionScopeRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repetitionName"/> is null. </exception>
        public virtual Response<WorkflowRunActionScopeRepetitionResource> Get(string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var scope = _workflowRunActionScopeRepetitionClientDiagnostics.CreateScope("WorkflowRunActionScopeRepetitionCollection.Get");
            scope.Start();
            try
            {
                var response = _workflowRunActionScopeRepetitionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, repetitionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkflowRunActionScopeRepetitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List the workflow run action scoped repetitions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionScopeRepetitions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkflowRunActionScopeRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkflowRunActionScopeRepetitionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkflowRunActionScopeRepetitionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workflowRunActionScopeRepetitionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workflowRunActionScopeRepetitionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WorkflowRunActionScopeRepetitionResource(Client, WorkflowRunActionRepetitionDefinitionData.DeserializeWorkflowRunActionRepetitionDefinitionData(e)), _workflowRunActionScopeRepetitionClientDiagnostics, Pipeline, "WorkflowRunActionScopeRepetitionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List the workflow run action scoped repetitions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionScopeRepetitions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkflowRunActionScopeRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkflowRunActionScopeRepetitionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkflowRunActionScopeRepetitionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workflowRunActionScopeRepetitionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workflowRunActionScopeRepetitionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WorkflowRunActionScopeRepetitionResource(Client, WorkflowRunActionRepetitionDefinitionData.DeserializeWorkflowRunActionRepetitionDefinitionData(e)), _workflowRunActionScopeRepetitionClientDiagnostics, Pipeline, "WorkflowRunActionScopeRepetitionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions/{repetitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionScopeRepetitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkflowRunActionScopeRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repetitionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var scope = _workflowRunActionScopeRepetitionClientDiagnostics.CreateScope("WorkflowRunActionScopeRepetitionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _workflowRunActionScopeRepetitionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, repetitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions/{repetitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionScopeRepetitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkflowRunActionScopeRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repetitionName"/> is null. </exception>
        public virtual Response<bool> Exists(string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var scope = _workflowRunActionScopeRepetitionClientDiagnostics.CreateScope("WorkflowRunActionScopeRepetitionCollection.Exists");
            scope.Start();
            try
            {
                var response = _workflowRunActionScopeRepetitionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, repetitionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions/{repetitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionScopeRepetitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkflowRunActionScopeRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repetitionName"/> is null. </exception>
        public virtual async Task<NullableResponse<WorkflowRunActionScopeRepetitionResource>> GetIfExistsAsync(string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var scope = _workflowRunActionScopeRepetitionClientDiagnostics.CreateScope("WorkflowRunActionScopeRepetitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _workflowRunActionScopeRepetitionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, repetitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<WorkflowRunActionScopeRepetitionResource>(response.GetRawResponse());
                return Response.FromValue(new WorkflowRunActionScopeRepetitionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions/{repetitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionScopeRepetitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkflowRunActionScopeRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repetitionName"/> is null. </exception>
        public virtual NullableResponse<WorkflowRunActionScopeRepetitionResource> GetIfExists(string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var scope = _workflowRunActionScopeRepetitionClientDiagnostics.CreateScope("WorkflowRunActionScopeRepetitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _workflowRunActionScopeRepetitionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, repetitionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<WorkflowRunActionScopeRepetitionResource>(response.GetRawResponse());
                return Response.FromValue(new WorkflowRunActionScopeRepetitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WorkflowRunActionScopeRepetitionResource> IEnumerable<WorkflowRunActionScopeRepetitionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkflowRunActionScopeRepetitionResource> IAsyncEnumerable<WorkflowRunActionScopeRepetitionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
