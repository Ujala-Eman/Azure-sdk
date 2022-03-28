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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="JobAgentResource" /> and their operations.
    /// Each <see cref="JobAgentResource" /> in the collection will belong to the same instance of <see cref="SqlServerResource" />.
    /// To get a <see cref="JobAgentCollection" /> instance call the GetJobAgents method from an instance of <see cref="SqlServerResource" />.
    /// </summary>
    public partial class JobAgentCollection : ArmCollection, IEnumerable<JobAgentResource>, IAsyncEnumerable<JobAgentResource>
    {
        private readonly ClientDiagnostics _jobAgentClientDiagnostics;
        private readonly JobAgentsRestOperations _jobAgentRestClient;

        /// <summary> Initializes a new instance of the <see cref="JobAgentCollection"/> class for mocking. </summary>
        protected JobAgentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="JobAgentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal JobAgentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _jobAgentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", JobAgentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(JobAgentResource.ResourceType, out string jobAgentApiVersion);
            _jobAgentRestClient = new JobAgentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, jobAgentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a job agent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// Operation Id: JobAgents_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobAgentName"> The name of the job agent to be created or updated. </param>
        /// <param name="data"> The requested job agent resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<JobAgentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string jobAgentName, JobAgentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _jobAgentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<JobAgentResource>(new JobAgentOperationSource(Client), _jobAgentClientDiagnostics, Pipeline, _jobAgentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a job agent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// Operation Id: JobAgents_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobAgentName"> The name of the job agent to be created or updated. </param>
        /// <param name="data"> The requested job agent resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<JobAgentResource> CreateOrUpdate(WaitUntil waitUntil, string jobAgentName, JobAgentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _jobAgentRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, data, cancellationToken);
                var operation = new SqlArmOperation<JobAgentResource>(new JobAgentOperationSource(Client), _jobAgentClientDiagnostics, Pipeline, _jobAgentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a job agent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// Operation Id: JobAgents_Get
        /// </summary>
        /// <param name="jobAgentName"> The name of the job agent to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> is null. </exception>
        public virtual async Task<Response<JobAgentResource>> GetAsync(string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.Get");
            scope.Start();
            try
            {
                var response = await _jobAgentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JobAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a job agent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// Operation Id: JobAgents_Get
        /// </summary>
        /// <param name="jobAgentName"> The name of the job agent to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> is null. </exception>
        public virtual Response<JobAgentResource> Get(string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.Get");
            scope.Start();
            try
            {
                var response = _jobAgentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JobAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of job agents in a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents
        /// Operation Id: JobAgents_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="JobAgentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<JobAgentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<JobAgentResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobAgentRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JobAgentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<JobAgentResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobAgentRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JobAgentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of job agents in a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents
        /// Operation Id: JobAgents_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="JobAgentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<JobAgentResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<JobAgentResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobAgentRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JobAgentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<JobAgentResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobAgentRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JobAgentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// Operation Id: JobAgents_Get
        /// </summary>
        /// <param name="jobAgentName"> The name of the job agent to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(jobAgentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// Operation Id: JobAgents_Get
        /// </summary>
        /// <param name="jobAgentName"> The name of the job agent to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> is null. </exception>
        public virtual Response<bool> Exists(string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(jobAgentName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// Operation Id: JobAgents_Get
        /// </summary>
        /// <param name="jobAgentName"> The name of the job agent to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> is null. </exception>
        public virtual async Task<Response<JobAgentResource>> GetIfExistsAsync(string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _jobAgentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<JobAgentResource>(null, response.GetRawResponse());
                return Response.FromValue(new JobAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// Operation Id: JobAgents_Get
        /// </summary>
        /// <param name="jobAgentName"> The name of the job agent to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> is null. </exception>
        public virtual Response<JobAgentResource> GetIfExists(string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _jobAgentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<JobAgentResource>(null, response.GetRawResponse());
                return Response.FromValue(new JobAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<JobAgentResource> IEnumerable<JobAgentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<JobAgentResource> IAsyncEnumerable<JobAgentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
