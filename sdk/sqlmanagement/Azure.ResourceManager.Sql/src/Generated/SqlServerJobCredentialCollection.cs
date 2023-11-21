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
    /// A class representing a collection of <see cref="SqlServerJobCredentialResource"/> and their operations.
    /// Each <see cref="SqlServerJobCredentialResource"/> in the collection will belong to the same instance of <see cref="SqlServerJobAgentResource"/>.
    /// To get a <see cref="SqlServerJobCredentialCollection"/> instance call the GetSqlServerJobCredentials method from an instance of <see cref="SqlServerJobAgentResource"/>.
    /// </summary>
    public partial class SqlServerJobCredentialCollection : ArmCollection, IEnumerable<SqlServerJobCredentialResource>, IAsyncEnumerable<SqlServerJobCredentialResource>
    {
        private readonly ClientDiagnostics _sqlServerJobCredentialJobCredentialsClientDiagnostics;
        private readonly JobCredentialsRestOperations _sqlServerJobCredentialJobCredentialsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobCredentialCollection"/> class for mocking. </summary>
        protected SqlServerJobCredentialCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobCredentialCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerJobCredentialCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerJobCredentialJobCredentialsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerJobCredentialResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerJobCredentialResource.ResourceType, out string sqlServerJobCredentialJobCredentialsApiVersion);
            _sqlServerJobCredentialJobCredentialsRestClient = new JobCredentialsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerJobCredentialJobCredentialsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerJobAgentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerJobAgentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a job credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobCredentials_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="data"> The requested job credential state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlServerJobCredentialResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string credentialName, SqlServerJobCredentialData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerJobCredentialJobCredentialsClientDiagnostics.CreateScope("SqlServerJobCredentialCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlServerJobCredentialJobCredentialsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerJobCredentialResource>(Response.FromValue(new SqlServerJobCredentialResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a job credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobCredentials_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="data"> The requested job credential state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlServerJobCredentialResource> CreateOrUpdate(WaitUntil waitUntil, string credentialName, SqlServerJobCredentialData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerJobCredentialJobCredentialsClientDiagnostics.CreateScope("SqlServerJobCredentialCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlServerJobCredentialJobCredentialsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, data, cancellationToken);
                var operation = new SqlArmOperation<SqlServerJobCredentialResource>(Response.FromValue(new SqlServerJobCredentialResource(Client, response), response.GetRawResponse()));
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
        /// Gets a jobs credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobCredentials_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual async Task<Response<SqlServerJobCredentialResource>> GetAsync(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _sqlServerJobCredentialJobCredentialsClientDiagnostics.CreateScope("SqlServerJobCredentialCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerJobCredentialJobCredentialsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobCredentialResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a jobs credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobCredentials_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual Response<SqlServerJobCredentialResource> Get(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _sqlServerJobCredentialJobCredentialsClientDiagnostics.CreateScope("SqlServerJobCredentialCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerJobCredentialJobCredentialsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobCredentialResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of jobs credentials.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobCredentials_ListByAgent</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerJobCredentialResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerJobCredentialResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerJobCredentialJobCredentialsRestClient.CreateListByAgentRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerJobCredentialJobCredentialsRestClient.CreateListByAgentNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SqlServerJobCredentialResource(Client, SqlServerJobCredentialData.DeserializeSqlServerJobCredentialData(e)), _sqlServerJobCredentialJobCredentialsClientDiagnostics, Pipeline, "SqlServerJobCredentialCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of jobs credentials.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobCredentials_ListByAgent</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerJobCredentialResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerJobCredentialResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerJobCredentialJobCredentialsRestClient.CreateListByAgentRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerJobCredentialJobCredentialsRestClient.CreateListByAgentNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SqlServerJobCredentialResource(Client, SqlServerJobCredentialData.DeserializeSqlServerJobCredentialData(e)), _sqlServerJobCredentialJobCredentialsClientDiagnostics, Pipeline, "SqlServerJobCredentialCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobCredentials_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _sqlServerJobCredentialJobCredentialsClientDiagnostics.CreateScope("SqlServerJobCredentialCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerJobCredentialJobCredentialsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobCredentials_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual Response<bool> Exists(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _sqlServerJobCredentialJobCredentialsClientDiagnostics.CreateScope("SqlServerJobCredentialCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerJobCredentialJobCredentialsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobCredentials_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual async Task<NullableResponse<SqlServerJobCredentialResource>> GetIfExistsAsync(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _sqlServerJobCredentialJobCredentialsClientDiagnostics.CreateScope("SqlServerJobCredentialCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlServerJobCredentialJobCredentialsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerJobCredentialResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobCredentialResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobCredentials_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual NullableResponse<SqlServerJobCredentialResource> GetIfExists(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _sqlServerJobCredentialJobCredentialsClientDiagnostics.CreateScope("SqlServerJobCredentialCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlServerJobCredentialJobCredentialsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerJobCredentialResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobCredentialResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerJobCredentialResource> IEnumerable<SqlServerJobCredentialResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServerJobCredentialResource> IAsyncEnumerable<SqlServerJobCredentialResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
