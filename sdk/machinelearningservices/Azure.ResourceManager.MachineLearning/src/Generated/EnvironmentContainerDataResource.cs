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

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A Class representing an EnvironmentContainerData along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="EnvironmentContainerDataResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetEnvironmentContainerDataResource method.
    /// Otherwise you can get one from its parent resource <see cref="WorkspaceResource" /> using the GetEnvironmentContainerData method.
    /// </summary>
    public partial class EnvironmentContainerDataResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="EnvironmentContainerDataResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _environmentContainerDataEnvironmentContainersClientDiagnostics;
        private readonly EnvironmentContainersRestOperations _environmentContainerDataEnvironmentContainersRestClient;
        private readonly EnvironmentContainerDataData _data;

        /// <summary> Initializes a new instance of the <see cref="EnvironmentContainerDataResource"/> class for mocking. </summary>
        protected EnvironmentContainerDataResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "EnvironmentContainerDataResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal EnvironmentContainerDataResource(ArmClient client, EnvironmentContainerDataData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="EnvironmentContainerDataResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal EnvironmentContainerDataResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _environmentContainerDataEnvironmentContainersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string environmentContainerDataEnvironmentContainersApiVersion);
            _environmentContainerDataEnvironmentContainersRestClient = new EnvironmentContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, environmentContainerDataEnvironmentContainersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MachineLearningServices/workspaces/environments";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual EnvironmentContainerDataData Data
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

        /// <summary> Gets a collection of EnvironmentVersionDataResources in the EnvironmentContainerData. </summary>
        /// <returns> An object representing collection of EnvironmentVersionDataResources and their operations over a EnvironmentVersionDataResource. </returns>
        public virtual EnvironmentVersionDataCollection GetAllEnvironmentVersionData()
        {
            return GetCachedClient(Client => new EnvironmentVersionDataCollection(Client, Id));
        }

        /// <summary>
        /// Get version.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}/versions/{version}
        /// Operation Id: EnvironmentVersions_Get
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<EnvironmentVersionDataResource>> GetEnvironmentVersionDataAsync(string version, CancellationToken cancellationToken = default)
        {
            return await GetAllEnvironmentVersionData().GetAsync(version, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get version.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}/versions/{version}
        /// Operation Id: EnvironmentVersions_Get
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<EnvironmentVersionDataResource> GetEnvironmentVersionData(string version, CancellationToken cancellationToken = default)
        {
            return GetAllEnvironmentVersionData().Get(version, cancellationToken);
        }

        /// <summary>
        /// Get container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// Operation Id: EnvironmentContainers_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EnvironmentContainerDataResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _environmentContainerDataEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerDataResource.Get");
            scope.Start();
            try
            {
                var response = await _environmentContainerDataEnvironmentContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EnvironmentContainerDataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// Operation Id: EnvironmentContainers_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EnvironmentContainerDataResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _environmentContainerDataEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerDataResource.Get");
            scope.Start();
            try
            {
                var response = _environmentContainerDataEnvironmentContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EnvironmentContainerDataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// Operation Id: EnvironmentContainers_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _environmentContainerDataEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerDataResource.Delete");
            scope.Start();
            try
            {
                var response = await _environmentContainerDataEnvironmentContainersRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation(response);
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
        /// Delete container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// Operation Id: EnvironmentContainers_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _environmentContainerDataEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerDataResource.Delete");
            scope.Start();
            try
            {
                var response = _environmentContainerDataEnvironmentContainersRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MachineLearningArmOperation(response);
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
        /// Create or update container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// Operation Id: EnvironmentContainers_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EnvironmentContainerDataResource>> UpdateAsync(WaitUntil waitUntil, EnvironmentContainerDataData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _environmentContainerDataEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerDataResource.Update");
            scope.Start();
            try
            {
                var response = await _environmentContainerDataEnvironmentContainersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<EnvironmentContainerDataResource>(Response.FromValue(new EnvironmentContainerDataResource(Client, response), response.GetRawResponse()));
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
        /// Create or update container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}
        /// Operation Id: EnvironmentContainers_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EnvironmentContainerDataResource> Update(WaitUntil waitUntil, EnvironmentContainerDataData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _environmentContainerDataEnvironmentContainersClientDiagnostics.CreateScope("EnvironmentContainerDataResource.Update");
            scope.Start();
            try
            {
                var response = _environmentContainerDataEnvironmentContainersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new MachineLearningArmOperation<EnvironmentContainerDataResource>(Response.FromValue(new EnvironmentContainerDataResource(Client, response), response.GetRawResponse()));
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
