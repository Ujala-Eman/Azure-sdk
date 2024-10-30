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

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    /// <summary>
    /// A class representing a collection of <see cref="PostgreSqlFlexibleServerBackupResource"/> and their operations.
    /// Each <see cref="PostgreSqlFlexibleServerBackupResource"/> in the collection will belong to the same instance of <see cref="PostgreSqlFlexibleServerResource"/>.
    /// To get a <see cref="PostgreSqlFlexibleServerBackupCollection"/> instance call the GetPostgreSqlFlexibleServerBackups method from an instance of <see cref="PostgreSqlFlexibleServerResource"/>.
    /// </summary>
    public partial class PostgreSqlFlexibleServerBackupCollection : ArmCollection, IEnumerable<PostgreSqlFlexibleServerBackupResource>, IAsyncEnumerable<PostgreSqlFlexibleServerBackupResource>
    {
        private readonly ClientDiagnostics _postgreSqlFlexibleServerBackupBackupsClientDiagnostics;
        private readonly BackupsRestOperations _postgreSqlFlexibleServerBackupBackupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlFlexibleServerBackupCollection"/> class for mocking. </summary>
        protected PostgreSqlFlexibleServerBackupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlFlexibleServerBackupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PostgreSqlFlexibleServerBackupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _postgreSqlFlexibleServerBackupBackupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PostgreSql.FlexibleServers", PostgreSqlFlexibleServerBackupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PostgreSqlFlexibleServerBackupResource.ResourceType, out string postgreSqlFlexibleServerBackupBackupsApiVersion);
            _postgreSqlFlexibleServerBackupBackupsRestClient = new BackupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, postgreSqlFlexibleServerBackupBackupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PostgreSqlFlexibleServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PostgreSqlFlexibleServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a specific backup for PostgreSQL flexible server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/backups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Backups_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlFlexibleServerBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<ArmOperation<PostgreSqlFlexibleServerBackupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _postgreSqlFlexibleServerBackupBackupsClientDiagnostics.CreateScope("PostgreSqlFlexibleServerBackupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _postgreSqlFlexibleServerBackupBackupsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken).ConfigureAwait(false);
                var operation = new FlexibleServersArmOperation<PostgreSqlFlexibleServerBackupResource>(new PostgreSqlFlexibleServerBackupOperationSource(Client), _postgreSqlFlexibleServerBackupBackupsClientDiagnostics, Pipeline, _postgreSqlFlexibleServerBackupBackupsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a specific backup for PostgreSQL flexible server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/backups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Backups_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlFlexibleServerBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual ArmOperation<PostgreSqlFlexibleServerBackupResource> CreateOrUpdate(WaitUntil waitUntil, string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _postgreSqlFlexibleServerBackupBackupsClientDiagnostics.CreateScope("PostgreSqlFlexibleServerBackupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _postgreSqlFlexibleServerBackupBackupsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken);
                var operation = new FlexibleServersArmOperation<PostgreSqlFlexibleServerBackupResource>(new PostgreSqlFlexibleServerBackupOperationSource(Client), _postgreSqlFlexibleServerBackupBackupsClientDiagnostics, Pipeline, _postgreSqlFlexibleServerBackupBackupsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get specific backup for a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/backups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Backups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlFlexibleServerBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<Response<PostgreSqlFlexibleServerBackupResource>> GetAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _postgreSqlFlexibleServerBackupBackupsClientDiagnostics.CreateScope("PostgreSqlFlexibleServerBackupCollection.Get");
            scope.Start();
            try
            {
                var response = await _postgreSqlFlexibleServerBackupBackupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlFlexibleServerBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get specific backup for a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/backups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Backups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlFlexibleServerBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<PostgreSqlFlexibleServerBackupResource> Get(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _postgreSqlFlexibleServerBackupBackupsClientDiagnostics.CreateScope("PostgreSqlFlexibleServerBackupCollection.Get");
            scope.Start();
            try
            {
                var response = _postgreSqlFlexibleServerBackupBackupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlFlexibleServerBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the backups for a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/backups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Backups_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlFlexibleServerBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlFlexibleServerBackupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PostgreSqlFlexibleServerBackupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlFlexibleServerBackupBackupsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _postgreSqlFlexibleServerBackupBackupsRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PostgreSqlFlexibleServerBackupResource(Client, PostgreSqlFlexibleServerBackupData.DeserializePostgreSqlFlexibleServerBackupData(e)), _postgreSqlFlexibleServerBackupBackupsClientDiagnostics, Pipeline, "PostgreSqlFlexibleServerBackupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the backups for a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/backups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Backups_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlFlexibleServerBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlFlexibleServerBackupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PostgreSqlFlexibleServerBackupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlFlexibleServerBackupBackupsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _postgreSqlFlexibleServerBackupBackupsRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PostgreSqlFlexibleServerBackupResource(Client, PostgreSqlFlexibleServerBackupData.DeserializePostgreSqlFlexibleServerBackupData(e)), _postgreSqlFlexibleServerBackupBackupsClientDiagnostics, Pipeline, "PostgreSqlFlexibleServerBackupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/backups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Backups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlFlexibleServerBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _postgreSqlFlexibleServerBackupBackupsClientDiagnostics.CreateScope("PostgreSqlFlexibleServerBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _postgreSqlFlexibleServerBackupBackupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/backups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Backups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlFlexibleServerBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<bool> Exists(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _postgreSqlFlexibleServerBackupBackupsClientDiagnostics.CreateScope("PostgreSqlFlexibleServerBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = _postgreSqlFlexibleServerBackupBackupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/backups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Backups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlFlexibleServerBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<NullableResponse<PostgreSqlFlexibleServerBackupResource>> GetIfExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _postgreSqlFlexibleServerBackupBackupsClientDiagnostics.CreateScope("PostgreSqlFlexibleServerBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _postgreSqlFlexibleServerBackupBackupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PostgreSqlFlexibleServerBackupResource>(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlFlexibleServerBackupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/backups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Backups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlFlexibleServerBackupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual NullableResponse<PostgreSqlFlexibleServerBackupResource> GetIfExists(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _postgreSqlFlexibleServerBackupBackupsClientDiagnostics.CreateScope("PostgreSqlFlexibleServerBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _postgreSqlFlexibleServerBackupBackupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PostgreSqlFlexibleServerBackupResource>(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlFlexibleServerBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PostgreSqlFlexibleServerBackupResource> IEnumerable<PostgreSqlFlexibleServerBackupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PostgreSqlFlexibleServerBackupResource> IAsyncEnumerable<PostgreSqlFlexibleServerBackupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
