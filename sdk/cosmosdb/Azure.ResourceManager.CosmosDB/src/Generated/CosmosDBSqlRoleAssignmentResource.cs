// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A Class representing a CosmosDBSqlRoleAssignment along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="CosmosDBSqlRoleAssignmentResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetCosmosDBSqlRoleAssignmentResource method.
    /// Otherwise you can get one from its parent resource <see cref="CosmosDBAccountResource"/> using the GetCosmosDBSqlRoleAssignment method.
    /// </summary>
    public partial class CosmosDBSqlRoleAssignmentResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CosmosDBSqlRoleAssignmentResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="accountName"> The accountName. </param>
        /// <param name="roleAssignmentId"> The roleAssignmentId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string roleAssignmentId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleAssignments/{roleAssignmentId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics;
        private readonly SqlResourcesRestOperations _cosmosDBSqlRoleAssignmentSqlResourcesRestClient;
        private readonly CosmosDBSqlRoleAssignmentData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DocumentDB/databaseAccounts/sqlRoleAssignments";

        /// <summary> Initializes a new instance of the <see cref="CosmosDBSqlRoleAssignmentResource"/> class for mocking. </summary>
        protected CosmosDBSqlRoleAssignmentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBSqlRoleAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CosmosDBSqlRoleAssignmentResource(ArmClient client, CosmosDBSqlRoleAssignmentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBSqlRoleAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CosmosDBSqlRoleAssignmentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string cosmosDBSqlRoleAssignmentSqlResourcesApiVersion);
            _cosmosDBSqlRoleAssignmentSqlResourcesRestClient = new SqlResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBSqlRoleAssignmentSqlResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CosmosDBSqlRoleAssignmentData Data
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

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB SQL Role Assignment with the given Id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CosmosDBSqlRoleAssignmentResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.GetSqlRoleAssignmentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlRoleAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB SQL Role Assignment with the given Id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CosmosDBSqlRoleAssignmentResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.GetSqlRoleAssignment(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlRoleAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing Azure Cosmos DB SQL Role Assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_DeleteSqlRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleAssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.DeleteSqlRoleAssignmentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation(_cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.CreateDeleteSqlRoleAssignmentRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing Azure Cosmos DB SQL Role Assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_DeleteSqlRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleAssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.DeleteSqlRoleAssignment(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CosmosDBArmOperation(_cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.CreateDeleteSqlRoleAssignmentRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an Azure Cosmos DB SQL Role Assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_CreateUpdateSqlRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The properties required to create or update a Role Assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosDBSqlRoleAssignmentResource>> UpdateAsync(WaitUntil waitUntil, CosmosDBSqlRoleAssignmentCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleAssignmentResource.Update");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.CreateUpdateSqlRoleAssignmentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CosmosDBSqlRoleAssignmentResource>(new CosmosDBSqlRoleAssignmentOperationSource(Client), _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.CreateCreateUpdateSqlRoleAssignmentRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an Azure Cosmos DB SQL Role Assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlRoleAssignments/{roleAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_CreateUpdateSqlRoleAssignment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The properties required to create or update a Role Assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<CosmosDBSqlRoleAssignmentResource> Update(WaitUntil waitUntil, CosmosDBSqlRoleAssignmentCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlRoleAssignmentResource.Update");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.CreateUpdateSqlRoleAssignment(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new CosmosDBArmOperation<CosmosDBSqlRoleAssignmentResource>(new CosmosDBSqlRoleAssignmentOperationSource(Client), _cosmosDBSqlRoleAssignmentSqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlRoleAssignmentSqlResourcesRestClient.CreateCreateUpdateSqlRoleAssignmentRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
    }
}
