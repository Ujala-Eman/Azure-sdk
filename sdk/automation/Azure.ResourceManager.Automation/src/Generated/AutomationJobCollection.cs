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
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing a collection of <see cref="AutomationJobResource" /> and their operations.
    /// Each <see cref="AutomationJobResource" /> in the collection will belong to the same instance of <see cref="AutomationAccountResource" />.
    /// To get an <see cref="AutomationJobCollection" /> instance call the GetAutomationJobs method from an instance of <see cref="AutomationAccountResource" />.
    /// </summary>
    public partial class AutomationJobCollection : ArmCollection, IEnumerable<AutomationJobCollectionItemData>, IAsyncEnumerable<AutomationJobCollectionItemData>
    {
        private readonly ClientDiagnostics _automationJobJobClientDiagnostics;
        private readonly JobRestOperations _automationJobJobRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomationJobCollection"/> class for mocking. </summary>
        protected AutomationJobCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationJobCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomationJobCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automationJobJobClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", AutomationJobResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomationJobResource.ResourceType, out string automationJobJobApiVersion);
            _automationJobJobRestClient = new JobRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automationJobJobApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AutomationAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AutomationAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a job of the runbook.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobName"> The job name. </param>
        /// <param name="content"> The parameters supplied to the create job operation. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomationJobResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string jobName, AutomationJobCreateOrUpdateContent content, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationJobJobClientDiagnostics.CreateScope("AutomationJobCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _automationJobJobRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, content, clientRequestId, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation<AutomationJobResource>(Response.FromValue(new AutomationJobResource(Client, response), response.GetRawResponse()));
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
        /// Create a job of the runbook.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobName"> The job name. </param>
        /// <param name="content"> The parameters supplied to the create job operation. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<AutomationJobResource> CreateOrUpdate(WaitUntil waitUntil, string jobName, AutomationJobCreateOrUpdateContent content, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationJobJobClientDiagnostics.CreateScope("AutomationJobCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _automationJobJobRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, content, clientRequestId, cancellationToken);
                var operation = new AutomationArmOperation<AutomationJobResource>(Response.FromValue(new AutomationJobResource(Client, response), response.GetRawResponse()));
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
        /// Retrieve the job identified by job name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The job name. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual async Task<Response<AutomationJobResource>> GetAsync(string jobName, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _automationJobJobClientDiagnostics.CreateScope("AutomationJobCollection.Get");
            scope.Start();
            try
            {
                var response = await _automationJobJobRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, clientRequestId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the job identified by job name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The job name. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<AutomationJobResource> Get(string jobName, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _automationJobJobClientDiagnostics.CreateScope("AutomationJobCollection.Get");
            scope.Start();
            try
            {
                var response = _automationJobJobRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, clientRequestId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of jobs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomationJobCollectionItemData" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomationJobCollectionItemData> GetAllAsync(string filter = null, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationJobJobRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, clientRequestId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationJobJobRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, clientRequestId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, AutomationJobCollectionItemData.DeserializeAutomationJobCollectionItemData, _automationJobJobClientDiagnostics, Pipeline, "AutomationJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of jobs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomationJobCollectionItemData" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomationJobCollectionItemData> GetAll(string filter = null, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationJobJobRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, clientRequestId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationJobJobRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, clientRequestId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, AutomationJobCollectionItemData.DeserializeAutomationJobCollectionItemData, _automationJobJobClientDiagnostics, Pipeline, "AutomationJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The job name. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string jobName, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _automationJobJobClientDiagnostics.CreateScope("AutomationJobCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automationJobJobRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, clientRequestId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The job name. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<bool> Exists(string jobName, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _automationJobJobClientDiagnostics.CreateScope("AutomationJobCollection.Exists");
            scope.Start();
            try
            {
                var response = _automationJobJobRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, clientRequestId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomationJobCollectionItemData> IEnumerable<AutomationJobCollectionItemData>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomationJobCollectionItemData> IAsyncEnumerable<AutomationJobCollectionItemData>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
