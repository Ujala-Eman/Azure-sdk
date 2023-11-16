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
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    /// <summary>
    /// A Class representing a StorageSyncRegisteredServer along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="StorageSyncRegisteredServerResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetStorageSyncRegisteredServerResource method.
    /// Otherwise you can get one from its parent resource <see cref="StorageSyncServiceResource" /> using the GetStorageSyncRegisteredServer method.
    /// </summary>
    public partial class StorageSyncRegisteredServerResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StorageSyncRegisteredServerResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="storageSyncServiceName"> The storageSyncServiceName. </param>
        /// <param name="serverId"> The serverId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string storageSyncServiceName, Guid serverId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _storageSyncRegisteredServerRegisteredServersClientDiagnostics;
        private readonly RegisteredServersRestOperations _storageSyncRegisteredServerRegisteredServersRestClient;
        private readonly StorageSyncRegisteredServerData _data;

        /// <summary> Initializes a new instance of the <see cref="StorageSyncRegisteredServerResource"/> class for mocking. </summary>
        protected StorageSyncRegisteredServerResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "StorageSyncRegisteredServerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StorageSyncRegisteredServerResource(ArmClient client, StorageSyncRegisteredServerData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StorageSyncRegisteredServerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StorageSyncRegisteredServerResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageSyncRegisteredServerRegisteredServersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageSync", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string storageSyncRegisteredServerRegisteredServersApiVersion);
            _storageSyncRegisteredServerRegisteredServersRestClient = new RegisteredServersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageSyncRegisteredServerRegisteredServersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.StorageSync/storageSyncServices/registeredServers";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StorageSyncRegisteredServerData Data
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
        /// Get a given registered server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredServers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StorageSyncRegisteredServerResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _storageSyncRegisteredServerRegisteredServersClientDiagnostics.CreateScope("StorageSyncRegisteredServerResource.Get");
            scope.Start();
            try
            {
                var response = await _storageSyncRegisteredServerRegisteredServersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageSyncRegisteredServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a given registered server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredServers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StorageSyncRegisteredServerResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _storageSyncRegisteredServerRegisteredServersClientDiagnostics.CreateScope("StorageSyncRegisteredServerResource.Get");
            scope.Start();
            try
            {
                var response = _storageSyncRegisteredServerRegisteredServersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageSyncRegisteredServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the given registered server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredServers_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _storageSyncRegisteredServerRegisteredServersClientDiagnostics.CreateScope("StorageSyncRegisteredServerResource.Delete");
            scope.Start();
            try
            {
                var response = await _storageSyncRegisteredServerRegisteredServersRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                var operation = new StorageSyncArmOperation(_storageSyncRegisteredServerRegisteredServersClientDiagnostics, Pipeline, _storageSyncRegisteredServerRegisteredServersRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name)).Request, response, OperationFinalStateVia.Location);
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
        /// Delete the given registered server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredServers_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _storageSyncRegisteredServerRegisteredServersClientDiagnostics.CreateScope("StorageSyncRegisteredServerResource.Delete");
            scope.Start();
            try
            {
                var response = _storageSyncRegisteredServerRegisteredServersRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken);
                var operation = new StorageSyncArmOperation(_storageSyncRegisteredServerRegisteredServersClientDiagnostics, Pipeline, _storageSyncRegisteredServerRegisteredServersRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name)).Request, response, OperationFinalStateVia.Location);
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
        /// Update registered server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredServers_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Body of Registered Server object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<StorageSyncRegisteredServerResource>> UpdateAsync(WaitUntil waitUntil, StorageSyncRegisteredServerPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _storageSyncRegisteredServerRegisteredServersClientDiagnostics.CreateScope("StorageSyncRegisteredServerResource.Update");
            scope.Start();
            try
            {
                var response = await _storageSyncRegisteredServerRegisteredServersRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), patch, cancellationToken).ConfigureAwait(false);
                var operation = new StorageSyncArmOperation<StorageSyncRegisteredServerResource>(new StorageSyncRegisteredServerOperationSource(Client), _storageSyncRegisteredServerRegisteredServersClientDiagnostics, Pipeline, _storageSyncRegisteredServerRegisteredServersRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), patch).Request, response, OperationFinalStateVia.Location);
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
        /// Update registered server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredServers_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Body of Registered Server object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<StorageSyncRegisteredServerResource> Update(WaitUntil waitUntil, StorageSyncRegisteredServerPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _storageSyncRegisteredServerRegisteredServersClientDiagnostics.CreateScope("StorageSyncRegisteredServerResource.Update");
            scope.Start();
            try
            {
                var response = _storageSyncRegisteredServerRegisteredServersRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), patch, cancellationToken);
                var operation = new StorageSyncArmOperation<StorageSyncRegisteredServerResource>(new StorageSyncRegisteredServerOperationSource(Client), _storageSyncRegisteredServerRegisteredServersClientDiagnostics, Pipeline, _storageSyncRegisteredServerRegisteredServersRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), patch).Request, response, OperationFinalStateVia.Location);
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
        /// Triggers Server certificate rollover.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}/triggerRollover</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredServers_triggerRollover</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Body of Trigger Rollover request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation> TriggerRolloverAsync(WaitUntil waitUntil, TriggerRolloverContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _storageSyncRegisteredServerRegisteredServersClientDiagnostics.CreateScope("StorageSyncRegisteredServerResource.TriggerRollover");
            scope.Start();
            try
            {
                var response = await _storageSyncRegisteredServerRegisteredServersRestClient.TriggerRolloverAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), content, cancellationToken).ConfigureAwait(false);
                var operation = new StorageSyncArmOperation(_storageSyncRegisteredServerRegisteredServersClientDiagnostics, Pipeline, _storageSyncRegisteredServerRegisteredServersRestClient.CreateTriggerRolloverRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), content).Request, response, OperationFinalStateVia.Location);
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
        /// Triggers Server certificate rollover.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}/triggerRollover</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredServers_triggerRollover</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Body of Trigger Rollover request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation TriggerRollover(WaitUntil waitUntil, TriggerRolloverContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _storageSyncRegisteredServerRegisteredServersClientDiagnostics.CreateScope("StorageSyncRegisteredServerResource.TriggerRollover");
            scope.Start();
            try
            {
                var response = _storageSyncRegisteredServerRegisteredServersRestClient.TriggerRollover(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), content, cancellationToken);
                var operation = new StorageSyncArmOperation(_storageSyncRegisteredServerRegisteredServersClientDiagnostics, Pipeline, _storageSyncRegisteredServerRegisteredServersRestClient.CreateTriggerRolloverRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), content).Request, response, OperationFinalStateVia.Location);
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
    }
}
