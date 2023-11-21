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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlServerJobVersionStepResource"/> and their operations.
    /// Each <see cref="SqlServerJobVersionStepResource"/> in the collection will belong to the same instance of <see cref="SqlServerJobVersionResource"/>.
    /// To get a <see cref="SqlServerJobVersionStepCollection"/> instance call the GetSqlServerJobVersionSteps method from an instance of <see cref="SqlServerJobVersionResource"/>.
    /// </summary>
    public partial class SqlServerJobVersionStepCollection : ArmCollection, IEnumerable<SqlServerJobVersionStepResource>, IAsyncEnumerable<SqlServerJobVersionStepResource>
    {
        private readonly ClientDiagnostics _sqlServerJobVersionStepJobStepsClientDiagnostics;
        private readonly JobStepsRestOperations _sqlServerJobVersionStepJobStepsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobVersionStepCollection"/> class for mocking. </summary>
        protected SqlServerJobVersionStepCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobVersionStepCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerJobVersionStepCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerJobVersionStepJobStepsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerJobVersionStepResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerJobVersionStepResource.ResourceType, out string sqlServerJobVersionStepJobStepsApiVersion);
            _sqlServerJobVersionStepJobStepsRestClient = new JobStepsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerJobVersionStepJobStepsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerJobVersionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerJobVersionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the specified version of a job step.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSteps_GetByVersion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual async Task<Response<SqlServerJobVersionStepResource>> GetAsync(string stepName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stepName, nameof(stepName));

            using var scope = _sqlServerJobVersionStepJobStepsClientDiagnostics.CreateScope("SqlServerJobVersionStepCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerJobVersionStepJobStepsRestClient.GetByVersionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, int.Parse(Id.Name), stepName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobVersionStepResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified version of a job step.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSteps_GetByVersion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual Response<SqlServerJobVersionStepResource> Get(string stepName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stepName, nameof(stepName));

            using var scope = _sqlServerJobVersionStepJobStepsClientDiagnostics.CreateScope("SqlServerJobVersionStepCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerJobVersionStepJobStepsRestClient.GetByVersion(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, int.Parse(Id.Name), stepName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobVersionStepResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all job steps in the specified job version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}/steps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSteps_ListByVersion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerJobVersionStepResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerJobVersionStepResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerJobVersionStepJobStepsRestClient.CreateListByVersionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, int.Parse(Id.Name));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerJobVersionStepJobStepsRestClient.CreateListByVersionNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, int.Parse(Id.Name));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SqlServerJobVersionStepResource(Client, SqlServerJobStepData.DeserializeSqlServerJobStepData(e)), _sqlServerJobVersionStepJobStepsClientDiagnostics, Pipeline, "SqlServerJobVersionStepCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all job steps in the specified job version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}/steps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSteps_ListByVersion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerJobVersionStepResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerJobVersionStepResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerJobVersionStepJobStepsRestClient.CreateListByVersionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, int.Parse(Id.Name));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerJobVersionStepJobStepsRestClient.CreateListByVersionNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, int.Parse(Id.Name));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SqlServerJobVersionStepResource(Client, SqlServerJobStepData.DeserializeSqlServerJobStepData(e)), _sqlServerJobVersionStepJobStepsClientDiagnostics, Pipeline, "SqlServerJobVersionStepCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSteps_GetByVersion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string stepName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stepName, nameof(stepName));

            using var scope = _sqlServerJobVersionStepJobStepsClientDiagnostics.CreateScope("SqlServerJobVersionStepCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerJobVersionStepJobStepsRestClient.GetByVersionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, int.Parse(Id.Name), stepName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSteps_GetByVersion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual Response<bool> Exists(string stepName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stepName, nameof(stepName));

            using var scope = _sqlServerJobVersionStepJobStepsClientDiagnostics.CreateScope("SqlServerJobVersionStepCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerJobVersionStepJobStepsRestClient.GetByVersion(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, int.Parse(Id.Name), stepName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSteps_GetByVersion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual async Task<NullableResponse<SqlServerJobVersionStepResource>> GetIfExistsAsync(string stepName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stepName, nameof(stepName));

            using var scope = _sqlServerJobVersionStepJobStepsClientDiagnostics.CreateScope("SqlServerJobVersionStepCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlServerJobVersionStepJobStepsRestClient.GetByVersionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, int.Parse(Id.Name), stepName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerJobVersionStepResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobVersionStepResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSteps_GetByVersion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual NullableResponse<SqlServerJobVersionStepResource> GetIfExists(string stepName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stepName, nameof(stepName));

            using var scope = _sqlServerJobVersionStepJobStepsClientDiagnostics.CreateScope("SqlServerJobVersionStepCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlServerJobVersionStepJobStepsRestClient.GetByVersion(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, int.Parse(Id.Name), stepName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerJobVersionStepResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobVersionStepResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerJobVersionStepResource> IEnumerable<SqlServerJobVersionStepResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServerJobVersionStepResource> IAsyncEnumerable<SqlServerJobVersionStepResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
