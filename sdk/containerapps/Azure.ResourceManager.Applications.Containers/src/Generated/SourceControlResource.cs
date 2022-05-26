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

namespace Azure.ResourceManager.Applications.Containers
{
    /// <summary>
    /// A Class representing a SourceControl along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SourceControlResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSourceControlResource method.
    /// Otherwise you can get one from its parent resource <see cref="ContainerAppResource" /> using the GetSourceControl method.
    /// </summary>
    public partial class SourceControlResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SourceControlResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string containerAppName, string sourceControlName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sourceControlContainerAppsSourceControlsClientDiagnostics;
        private readonly ContainerAppsSourceControlsRestOperations _sourceControlContainerAppsSourceControlsRestClient;
        private readonly SourceControlData _data;

        /// <summary> Initializes a new instance of the <see cref="SourceControlResource"/> class for mocking. </summary>
        protected SourceControlResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SourceControlResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SourceControlResource(ArmClient client, SourceControlData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SourceControlResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SourceControlResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sourceControlContainerAppsSourceControlsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Applications.Containers", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sourceControlContainerAppsSourceControlsApiVersion);
            _sourceControlContainerAppsSourceControlsRestClient = new ContainerAppsSourceControlsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sourceControlContainerAppsSourceControlsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.App/containerApps/sourcecontrols";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SourceControlData Data
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
        /// Get a SourceControl of a Container App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}
        /// Operation Id: ContainerAppsSourceControls_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SourceControlResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("SourceControlResource.Get");
            scope.Start();
            try
            {
                var response = await _sourceControlContainerAppsSourceControlsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SourceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a SourceControl of a Container App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}
        /// Operation Id: ContainerAppsSourceControls_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SourceControlResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("SourceControlResource.Get");
            scope.Start();
            try
            {
                var response = _sourceControlContainerAppsSourceControlsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SourceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a Container App SourceControl.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}
        /// Operation Id: ContainerAppsSourceControls_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("SourceControlResource.Delete");
            scope.Start();
            try
            {
                var response = await _sourceControlContainerAppsSourceControlsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ContainersArmOperation(_sourceControlContainerAppsSourceControlsClientDiagnostics, Pipeline, _sourceControlContainerAppsSourceControlsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Delete a Container App SourceControl.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}
        /// Operation Id: ContainerAppsSourceControls_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("SourceControlResource.Delete");
            scope.Start();
            try
            {
                var response = _sourceControlContainerAppsSourceControlsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ContainersArmOperation(_sourceControlContainerAppsSourceControlsClientDiagnostics, Pipeline, _sourceControlContainerAppsSourceControlsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update the SourceControl for a Container App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}
        /// Operation Id: ContainerAppsSourceControls_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Properties used to create a Container App SourceControl. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SourceControlResource>> UpdateAsync(WaitUntil waitUntil, SourceControlData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("SourceControlResource.Update");
            scope.Start();
            try
            {
                var response = await _sourceControlContainerAppsSourceControlsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ContainersArmOperation<SourceControlResource>(new SourceControlOperationSource(Client), _sourceControlContainerAppsSourceControlsClientDiagnostics, Pipeline, _sourceControlContainerAppsSourceControlsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update the SourceControl for a Container App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}
        /// Operation Id: ContainerAppsSourceControls_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Properties used to create a Container App SourceControl. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SourceControlResource> Update(WaitUntil waitUntil, SourceControlData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("SourceControlResource.Update");
            scope.Start();
            try
            {
                var response = _sourceControlContainerAppsSourceControlsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new ContainersArmOperation<SourceControlResource>(new SourceControlOperationSource(Client), _sourceControlContainerAppsSourceControlsClientDiagnostics, Pipeline, _sourceControlContainerAppsSourceControlsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
