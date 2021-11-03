// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using SqlManagementClient.Models;

namespace SqlManagementClient
{
    /// <summary> A class representing collection of SensitivityLabel and their operations over its parent. </summary>
    public partial class ManagedInstanceDatabaseSchemaTableColumnSensitivityLabelCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ManagedDatabaseSensitivityLabelsRestOperations _managedDatabaseSensitivityLabelsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchemaTableColumnSensitivityLabelCollection"/> class for mocking. </summary>
        protected ManagedInstanceDatabaseSchemaTableColumnSensitivityLabelCollection()
        {
        }

        /// <summary> Initializes a new instance of ManagedInstanceDatabaseSchemaTableColumnSensitivityLabelCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ManagedInstanceDatabaseSchemaTableColumnSensitivityLabelCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _managedDatabaseSensitivityLabelsRestClient = new ManagedDatabaseSensitivityLabelsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ManagedInstanceDatabaseSchemaTableColumn.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// OperationId: ManagedDatabaseSensitivityLabels_CreateOrUpdate
        /// <summary> Creates or updates the sensitivity label of a given column. </summary>
        /// <param name="parameters"> The column sensitivity label resource. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ManagedDatabaseSensitivityLabelCreateOrUpdateOperation CreateOrUpdate(SensitivityLabelData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnSensitivityLabelCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedDatabaseSensitivityLabelsRestClient.CreateOrUpdate(Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken);
                var operation = new ManagedDatabaseSensitivityLabelCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// OperationId: ManagedDatabaseSensitivityLabels_CreateOrUpdate
        /// <summary> Creates or updates the sensitivity label of a given column. </summary>
        /// <param name="parameters"> The column sensitivity label resource. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ManagedDatabaseSensitivityLabelCreateOrUpdateOperation> CreateOrUpdateAsync(SensitivityLabelData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnSensitivityLabelCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedDatabaseSensitivityLabelsRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedDatabaseSensitivityLabelCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// OperationId: ManagedDatabaseSensitivityLabels_Get
        /// <summary> Gets the sensitivity label of a given column. </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel> Get(SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnSensitivityLabelCollection.Get");
            scope.Start();
            try
            {
                var response = _managedDatabaseSensitivityLabelsRestClient.Get(Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, sensitivityLabelSource, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// OperationId: ManagedDatabaseSensitivityLabels_Get
        /// <summary> Gets the sensitivity label of a given column. </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel>> GetAsync(SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnSensitivityLabelCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedDatabaseSensitivityLabelsRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, sensitivityLabelSource, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel> GetIfExists(SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnSensitivityLabelCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedDatabaseSensitivityLabelsRestClient.Get(Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, sensitivityLabelSource, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel>(null, response.GetRawResponse())
                    : Response.FromValue(new ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel>> GetIfExistsAsync(SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnSensitivityLabelCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _managedDatabaseSensitivityLabelsRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, sensitivityLabelSource, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel>(null, response.GetRawResponse())
                    : Response.FromValue(new ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> CheckIfExists(SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnSensitivityLabelCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(sensitivityLabelSource, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnSensitivityLabelCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(sensitivityLabelSource, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel, SensitivityLabelData> Construct() { }
    }
}
