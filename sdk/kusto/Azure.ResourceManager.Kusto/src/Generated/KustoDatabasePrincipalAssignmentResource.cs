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

namespace Azure.ResourceManager.Kusto
{
    /// <summary>
    /// A Class representing a KustoDatabasePrincipalAssignment along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="KustoDatabasePrincipalAssignmentResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetKustoDatabasePrincipalAssignmentResource method.
    /// Otherwise you can get one from its parent resource <see cref="KustoDatabaseResource"/> using the GetKustoDatabasePrincipalAssignment method.
    /// </summary>
    public partial class KustoDatabasePrincipalAssignmentResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="KustoDatabasePrincipalAssignmentResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="clusterName"> The clusterName. </param>
        /// <param name="databaseName"> The databaseName. </param>
        /// <param name="principalAssignmentName"> The principalAssignmentName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string clusterName, string databaseName, string principalAssignmentName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/principalAssignments/{principalAssignmentName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsClientDiagnostics;
        private readonly DatabasePrincipalAssignmentsRestOperations _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsRestClient;
        private readonly KustoDatabasePrincipalAssignmentData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Kusto/clusters/databases/principalAssignments";

        /// <summary> Initializes a new instance of the <see cref="KustoDatabasePrincipalAssignmentResource"/> class for mocking. </summary>
        protected KustoDatabasePrincipalAssignmentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="KustoDatabasePrincipalAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal KustoDatabasePrincipalAssignmentResource(ArmClient client, KustoDatabasePrincipalAssignmentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="KustoDatabasePrincipalAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal KustoDatabasePrincipalAssignmentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Kusto", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsApiVersion);
            _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsRestClient = new DatabasePrincipalAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual KustoDatabasePrincipalAssignmentData Data
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
        /// Gets a Kusto cluster database principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabasePrincipalAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoDatabasePrincipalAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<KustoDatabasePrincipalAssignmentResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsClientDiagnostics.CreateScope("KustoDatabasePrincipalAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = await _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KustoDatabasePrincipalAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Kusto cluster database principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabasePrincipalAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoDatabasePrincipalAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<KustoDatabasePrincipalAssignmentResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsClientDiagnostics.CreateScope("KustoDatabasePrincipalAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KustoDatabasePrincipalAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a Kusto principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabasePrincipalAssignments_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoDatabasePrincipalAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsClientDiagnostics.CreateScope("KustoDatabasePrincipalAssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = await _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new KustoArmOperation(_kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsClientDiagnostics, Pipeline, _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes a Kusto principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabasePrincipalAssignments_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoDatabasePrincipalAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsClientDiagnostics.CreateScope("KustoDatabasePrincipalAssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new KustoArmOperation(_kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsClientDiagnostics, Pipeline, _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a Kusto cluster database principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabasePrincipalAssignments_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoDatabasePrincipalAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The Kusto principalAssignments parameters supplied for the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<KustoDatabasePrincipalAssignmentResource>> UpdateAsync(WaitUntil waitUntil, KustoDatabasePrincipalAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsClientDiagnostics.CreateScope("KustoDatabasePrincipalAssignmentResource.Update");
            scope.Start();
            try
            {
                var response = await _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new KustoArmOperation<KustoDatabasePrincipalAssignmentResource>(new KustoDatabasePrincipalAssignmentOperationSource(Client), _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsClientDiagnostics, Pipeline, _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a Kusto cluster database principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabasePrincipalAssignments_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoDatabasePrincipalAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The Kusto principalAssignments parameters supplied for the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<KustoDatabasePrincipalAssignmentResource> Update(WaitUntil waitUntil, KustoDatabasePrincipalAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsClientDiagnostics.CreateScope("KustoDatabasePrincipalAssignmentResource.Update");
            scope.Start();
            try
            {
                var response = _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new KustoArmOperation<KustoDatabasePrincipalAssignmentResource>(new KustoDatabasePrincipalAssignmentOperationSource(Client), _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsClientDiagnostics, Pipeline, _kustoDatabasePrincipalAssignmentDatabasePrincipalAssignmentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
