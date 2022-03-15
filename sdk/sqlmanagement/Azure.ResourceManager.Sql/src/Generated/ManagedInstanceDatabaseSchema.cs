// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a ManagedInstanceDatabaseSchema along with the instance operations that can be performed on it. </summary>
    public partial class ManagedInstanceDatabaseSchema : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedInstanceDatabaseSchema"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedInstanceDatabaseSchemaManagedDatabaseSchemasClientDiagnostics;
        private readonly ManagedDatabaseSchemasRestOperations _managedInstanceDatabaseSchemaManagedDatabaseSchemasRestClient;
        private readonly DatabaseSchemaData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchema"/> class for mocking. </summary>
        protected ManagedInstanceDatabaseSchema()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagedInstanceDatabaseSchema"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedInstanceDatabaseSchema(ArmClient client, DatabaseSchemaData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchema"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedInstanceDatabaseSchema(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceDatabaseSchemaManagedDatabaseSchemasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string managedInstanceDatabaseSchemaManagedDatabaseSchemasApiVersion);
            _managedInstanceDatabaseSchemaManagedDatabaseSchemasRestClient = new ManagedDatabaseSchemasRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, managedInstanceDatabaseSchemaManagedDatabaseSchemasApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/databases/schemas";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DatabaseSchemaData Data
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

        /// <summary> Gets a collection of ManagedInstanceDatabaseSchemaTables in the ManagedInstanceDatabaseSchemaTable. </summary>
        /// <returns> An object representing collection of ManagedInstanceDatabaseSchemaTables and their operations over a ManagedInstanceDatabaseSchemaTable. </returns>
        public virtual ManagedInstanceDatabaseSchemaTableCollection GetManagedInstanceDatabaseSchemaTables()
        {
            return GetCachedClient(Client => new ManagedInstanceDatabaseSchemaTableCollection(Client, Id));
        }

        /// <summary>
        /// Get managed database table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: ManagedDatabaseTables_Get
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual async Task<Response<ManagedInstanceDatabaseSchemaTable>> GetManagedInstanceDatabaseSchemaTableAsync(string tableName, CancellationToken cancellationToken = default)
        {
            return await GetManagedInstanceDatabaseSchemaTables().GetAsync(tableName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get managed database table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: ManagedDatabaseTables_Get
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<ManagedInstanceDatabaseSchemaTable> GetManagedInstanceDatabaseSchemaTable(string tableName, CancellationToken cancellationToken = default)
        {
            return GetManagedInstanceDatabaseSchemaTables().Get(tableName, cancellationToken);
        }

        /// <summary>
        /// Get managed database schema
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}
        /// Operation Id: ManagedDatabaseSchemas_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstanceDatabaseSchema>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseSchemaManagedDatabaseSchemasClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchema.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceDatabaseSchemaManagedDatabaseSchemasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchema(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get managed database schema
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}
        /// Operation Id: ManagedDatabaseSchemas_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceDatabaseSchema> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseSchemaManagedDatabaseSchemasClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchema.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceDatabaseSchemaManagedDatabaseSchemasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchema(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
