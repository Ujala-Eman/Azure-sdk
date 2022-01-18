// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel along with the instance operations that can be performed on it. </summary>
    public partial class ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, string columnName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/current";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ManagedDatabaseSensitivityLabelsRestOperations _managedDatabaseSensitivityLabelsRestClient;
        private readonly SensitivityLabelData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel"/> class for mocking. </summary>
        protected ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel(ArmResource options, SensitivityLabelData data) : base(options, data.Id)
        {
            HasData = true;
            _data = data;
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _managedDatabaseSensitivityLabelsRestClient = new ManagedDatabaseSensitivityLabelsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _managedDatabaseSensitivityLabelsRestClient = new ManagedDatabaseSensitivityLabelsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _managedDatabaseSensitivityLabelsRestClient = new ManagedDatabaseSensitivityLabelsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/databases/schemas/tables/columns/sensitivityLabels";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SensitivityLabelData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets the parent resource of this resource. </summary>
        public ArmResource Parent { get; }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// OperationId: ManagedDatabaseSensitivityLabels_Get
        /// <summary> Gets the sensitivity label of a given column. </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel>> GetAsync(SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel.Get");
            scope.Start();
            try
            {
                var response = await _managedDatabaseSensitivityLabelsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, sensitivityLabelSource, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// OperationId: ManagedDatabaseSensitivityLabels_Get
        /// <summary> Gets the sensitivity label of a given column. </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel> Get(SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel.Get");
            scope.Start();
            try
            {
                var response = _managedDatabaseSensitivityLabelsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, sensitivityLabelSource, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// OperationId: ManagedDatabaseSensitivityLabels_Delete
        /// <summary> Deletes the sensitivity label of a given column. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ManagedDatabaseSensitivityLabelDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel.Delete");
            scope.Start();
            try
            {
                var response = await _managedDatabaseSensitivityLabelsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedDatabaseSensitivityLabelDeleteOperation(response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// OperationId: ManagedDatabaseSensitivityLabels_Delete
        /// <summary> Deletes the sensitivity label of a given column. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ManagedDatabaseSensitivityLabelDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel.Delete");
            scope.Start();
            try
            {
                var response = _managedDatabaseSensitivityLabelsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                var operation = new ManagedDatabaseSensitivityLabelDeleteOperation(response);
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
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// OperationId: ManagedDatabaseSensitivityLabels_CreateOrUpdate
        /// <summary> Creates or updates the sensitivity label of a given column. </summary>
        /// <param name="parameters"> The column sensitivity label resource. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ManagedDatabaseSensitivityLabelCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, SensitivityLabelData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedDatabaseSensitivityLabelsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedDatabaseSensitivityLabelCreateOrUpdateOperation(this, response);
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
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// OperationId: ManagedDatabaseSensitivityLabels_CreateOrUpdate
        /// <summary> Creates or updates the sensitivity label of a given column. </summary>
        /// <param name="parameters"> The column sensitivity label resource. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ManagedDatabaseSensitivityLabelCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, SensitivityLabelData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedDatabaseSensitivityLabelsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, parameters, cancellationToken);
                var operation = new ManagedDatabaseSensitivityLabelCreateOrUpdateOperation(this, response);
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
    }
}
