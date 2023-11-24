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
    /// A class representing a collection of <see cref="AutomationJobScheduleResource"/> and their operations.
    /// Each <see cref="AutomationJobScheduleResource"/> in the collection will belong to the same instance of <see cref="AutomationAccountResource"/>.
    /// To get an <see cref="AutomationJobScheduleCollection"/> instance call the GetAutomationJobSchedules method from an instance of <see cref="AutomationAccountResource"/>.
    /// </summary>
    public partial class AutomationJobScheduleCollection : ArmCollection, IEnumerable<AutomationJobScheduleResource>, IAsyncEnumerable<AutomationJobScheduleResource>
    {
        private readonly ClientDiagnostics _automationJobScheduleJobScheduleClientDiagnostics;
        private readonly JobScheduleRestOperations _automationJobScheduleJobScheduleRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomationJobScheduleCollection"/> class for mocking. </summary>
        protected AutomationJobScheduleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationJobScheduleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomationJobScheduleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automationJobScheduleJobScheduleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", AutomationJobScheduleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomationJobScheduleResource.ResourceType, out string automationJobScheduleJobScheduleApiVersion);
            _automationJobScheduleJobScheduleRestClient = new JobScheduleRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automationJobScheduleJobScheduleApiVersion);
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
        /// Create a job schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobSchedules/{jobScheduleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSchedule_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobScheduleId"> The job schedule name. </param>
        /// <param name="content"> The parameters supplied to the create job schedule operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomationJobScheduleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, Guid jobScheduleId, AutomationJobScheduleCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationJobScheduleJobScheduleClientDiagnostics.CreateScope("AutomationJobScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _automationJobScheduleJobScheduleRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobScheduleId, content, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation<AutomationJobScheduleResource>(Response.FromValue(new AutomationJobScheduleResource(Client, response), response.GetRawResponse()));
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
        /// Create a job schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobSchedules/{jobScheduleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSchedule_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobScheduleId"> The job schedule name. </param>
        /// <param name="content"> The parameters supplied to the create job schedule operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<AutomationJobScheduleResource> CreateOrUpdate(WaitUntil waitUntil, Guid jobScheduleId, AutomationJobScheduleCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationJobScheduleJobScheduleClientDiagnostics.CreateScope("AutomationJobScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _automationJobScheduleJobScheduleRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobScheduleId, content, cancellationToken);
                var operation = new AutomationArmOperation<AutomationJobScheduleResource>(Response.FromValue(new AutomationJobScheduleResource(Client, response), response.GetRawResponse()));
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
        /// Retrieve the job schedule identified by job schedule name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobSchedules/{jobScheduleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSchedule_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobScheduleId"> The job schedule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AutomationJobScheduleResource>> GetAsync(Guid jobScheduleId, CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobScheduleJobScheduleClientDiagnostics.CreateScope("AutomationJobScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = await _automationJobScheduleJobScheduleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobScheduleId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationJobScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the job schedule identified by job schedule name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobSchedules/{jobScheduleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSchedule_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobScheduleId"> The job schedule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AutomationJobScheduleResource> Get(Guid jobScheduleId, CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobScheduleJobScheduleClientDiagnostics.CreateScope("AutomationJobScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = _automationJobScheduleJobScheduleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobScheduleId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationJobScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of job schedules.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobSchedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSchedule_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomationJobScheduleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomationJobScheduleResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationJobScheduleJobScheduleRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationJobScheduleJobScheduleRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new AutomationJobScheduleResource(Client, AutomationJobScheduleData.DeserializeAutomationJobScheduleData(e)), _automationJobScheduleJobScheduleClientDiagnostics, Pipeline, "AutomationJobScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of job schedules.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobSchedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSchedule_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomationJobScheduleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomationJobScheduleResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationJobScheduleJobScheduleRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationJobScheduleJobScheduleRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new AutomationJobScheduleResource(Client, AutomationJobScheduleData.DeserializeAutomationJobScheduleData(e)), _automationJobScheduleJobScheduleClientDiagnostics, Pipeline, "AutomationJobScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobSchedules/{jobScheduleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSchedule_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobScheduleId"> The job schedule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(Guid jobScheduleId, CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobScheduleJobScheduleClientDiagnostics.CreateScope("AutomationJobScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automationJobScheduleJobScheduleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobScheduleId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobSchedules/{jobScheduleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSchedule_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobScheduleId"> The job schedule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(Guid jobScheduleId, CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobScheduleJobScheduleClientDiagnostics.CreateScope("AutomationJobScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = _automationJobScheduleJobScheduleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobScheduleId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobSchedules/{jobScheduleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSchedule_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobScheduleId"> The job schedule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<AutomationJobScheduleResource>> GetIfExistsAsync(Guid jobScheduleId, CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobScheduleJobScheduleClientDiagnostics.CreateScope("AutomationJobScheduleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _automationJobScheduleJobScheduleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobScheduleId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AutomationJobScheduleResource>(response.GetRawResponse());
                return Response.FromValue(new AutomationJobScheduleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobSchedules/{jobScheduleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSchedule_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobScheduleId"> The job schedule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<AutomationJobScheduleResource> GetIfExists(Guid jobScheduleId, CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobScheduleJobScheduleClientDiagnostics.CreateScope("AutomationJobScheduleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _automationJobScheduleJobScheduleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobScheduleId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AutomationJobScheduleResource>(response.GetRawResponse());
                return Response.FromValue(new AutomationJobScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomationJobScheduleResource> IEnumerable<AutomationJobScheduleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomationJobScheduleResource> IAsyncEnumerable<AutomationJobScheduleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
