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
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="JobBaseDataResource" /> and their operations.
    /// Each <see cref="JobBaseDataResource" /> in the collection will belong to the same instance of <see cref="WorkspaceResource" />.
    /// To get a <see cref="JobBaseDataCollection" /> instance call the GetJobBaseData method from an instance of <see cref="WorkspaceResource" />.
    /// </summary>
    public partial class JobBaseDataCollection : ArmCollection, IEnumerable<JobBaseDataResource>, IAsyncEnumerable<JobBaseDataResource>
    {
        private readonly ClientDiagnostics _jobBaseDataJobsClientDiagnostics;
        private readonly JobsRestOperations _jobBaseDataJobsRestClient;

        /// <summary> Initializes a new instance of the <see cref="JobBaseDataCollection"/> class for mocking. </summary>
        protected JobBaseDataCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="JobBaseDataCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal JobBaseDataCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _jobBaseDataJobsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", JobBaseDataResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(JobBaseDataResource.ResourceType, out string jobBaseDataJobsApiVersion);
            _jobBaseDataJobsRestClient = new JobsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, jobBaseDataJobsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates and executes a Job.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/jobs/{id}
        /// Operation Id: Jobs_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="id"> The name and identifier for the Job. This is case-sensitive. </param>
        /// <param name="data"> Job definition object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<JobBaseDataResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string id, JobBaseDataData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _jobBaseDataJobsClientDiagnostics.CreateScope("JobBaseDataCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _jobBaseDataJobsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<JobBaseDataResource>(Response.FromValue(new JobBaseDataResource(Client, response), response.GetRawResponse()));
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
        /// Creates and executes a Job.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/jobs/{id}
        /// Operation Id: Jobs_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="id"> The name and identifier for the Job. This is case-sensitive. </param>
        /// <param name="data"> Job definition object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<JobBaseDataResource> CreateOrUpdate(WaitUntil waitUntil, string id, JobBaseDataData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _jobBaseDataJobsClientDiagnostics.CreateScope("JobBaseDataCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _jobBaseDataJobsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, data, cancellationToken);
                var operation = new MachineLearningArmOperation<JobBaseDataResource>(Response.FromValue(new JobBaseDataResource(Client, response), response.GetRawResponse()));
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
        /// Gets a Job by name/id.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/jobs/{id}
        /// Operation Id: Jobs_Get
        /// </summary>
        /// <param name="id"> The name and identifier for the Job. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<JobBaseDataResource>> GetAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _jobBaseDataJobsClientDiagnostics.CreateScope("JobBaseDataCollection.Get");
            scope.Start();
            try
            {
                var response = await _jobBaseDataJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JobBaseDataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Job by name/id.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/jobs/{id}
        /// Operation Id: Jobs_Get
        /// </summary>
        /// <param name="id"> The name and identifier for the Job. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<JobBaseDataResource> Get(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _jobBaseDataJobsClientDiagnostics.CreateScope("JobBaseDataCollection.Get");
            scope.Start();
            try
            {
                var response = _jobBaseDataJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JobBaseDataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists Jobs in the workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/jobs
        /// Operation Id: Jobs_List
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="jobType"> Type of job to be returned. </param>
        /// <param name="tag"> Jobs returned will have this tag key. </param>
        /// <param name="listViewType"> View type for including/excluding (for example) archived entities. </param>
        /// <param name="scheduled"> Indicator whether the job is scheduled job. </param>
        /// <param name="scheduleId"> The scheduled id for listing the job triggered from. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="JobBaseDataResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<JobBaseDataResource> GetAllAsync(string skip = null, string jobType = null, string tag = null, ListViewType? listViewType = null, bool? scheduled = null, string scheduleId = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<JobBaseDataResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _jobBaseDataJobsClientDiagnostics.CreateScope("JobBaseDataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobBaseDataJobsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, jobType, tag, listViewType, scheduled, scheduleId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JobBaseDataResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<JobBaseDataResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _jobBaseDataJobsClientDiagnostics.CreateScope("JobBaseDataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobBaseDataJobsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, jobType, tag, listViewType, scheduled, scheduleId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JobBaseDataResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists Jobs in the workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/jobs
        /// Operation Id: Jobs_List
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="jobType"> Type of job to be returned. </param>
        /// <param name="tag"> Jobs returned will have this tag key. </param>
        /// <param name="listViewType"> View type for including/excluding (for example) archived entities. </param>
        /// <param name="scheduled"> Indicator whether the job is scheduled job. </param>
        /// <param name="scheduleId"> The scheduled id for listing the job triggered from. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="JobBaseDataResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<JobBaseDataResource> GetAll(string skip = null, string jobType = null, string tag = null, ListViewType? listViewType = null, bool? scheduled = null, string scheduleId = null, CancellationToken cancellationToken = default)
        {
            Page<JobBaseDataResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _jobBaseDataJobsClientDiagnostics.CreateScope("JobBaseDataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobBaseDataJobsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, jobType, tag, listViewType, scheduled, scheduleId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JobBaseDataResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<JobBaseDataResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _jobBaseDataJobsClientDiagnostics.CreateScope("JobBaseDataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobBaseDataJobsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, jobType, tag, listViewType, scheduled, scheduleId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JobBaseDataResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/jobs/{id}
        /// Operation Id: Jobs_Get
        /// </summary>
        /// <param name="id"> The name and identifier for the Job. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _jobBaseDataJobsClientDiagnostics.CreateScope("JobBaseDataCollection.Exists");
            scope.Start();
            try
            {
                var response = await _jobBaseDataJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/jobs/{id}
        /// Operation Id: Jobs_Get
        /// </summary>
        /// <param name="id"> The name and identifier for the Job. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<bool> Exists(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _jobBaseDataJobsClientDiagnostics.CreateScope("JobBaseDataCollection.Exists");
            scope.Start();
            try
            {
                var response = _jobBaseDataJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<JobBaseDataResource> IEnumerable<JobBaseDataResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<JobBaseDataResource> IAsyncEnumerable<JobBaseDataResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
