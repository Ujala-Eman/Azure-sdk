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
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A Class representing a ReplicationProtectionIntent along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ReplicationProtectionIntentResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetReplicationProtectionIntentResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource"/> using the GetReplicationProtectionIntent method.
    /// </summary>
    public partial class ReplicationProtectionIntentResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ReplicationProtectionIntentResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="resourceName"> The resourceName. </param>
        /// <param name="intentObjectName"> The intentObjectName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string intentObjectName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationProtectionIntents/{intentObjectName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _replicationProtectionIntentClientDiagnostics;
        private readonly ReplicationProtectionIntentsRestOperations _replicationProtectionIntentRestClient;
        private readonly ReplicationProtectionIntentData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.RecoveryServices/vaults/replicationProtectionIntents";

        /// <summary> Initializes a new instance of the <see cref="ReplicationProtectionIntentResource"/> class for mocking. </summary>
        protected ReplicationProtectionIntentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ReplicationProtectionIntentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ReplicationProtectionIntentResource(ArmClient client, ReplicationProtectionIntentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ReplicationProtectionIntentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ReplicationProtectionIntentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _replicationProtectionIntentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string replicationProtectionIntentApiVersion);
            _replicationProtectionIntentRestClient = new ReplicationProtectionIntentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, replicationProtectionIntentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ReplicationProtectionIntentData Data
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
        /// Gets the details of an ASR replication protection intent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationProtectionIntents/{intentObjectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionIntents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReplicationProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ReplicationProtectionIntentResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _replicationProtectionIntentClientDiagnostics.CreateScope("ReplicationProtectionIntentResource.Get");
            scope.Start();
            try
            {
                var response = await _replicationProtectionIntentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReplicationProtectionIntentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of an ASR replication protection intent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationProtectionIntents/{intentObjectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionIntents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReplicationProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ReplicationProtectionIntentResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _replicationProtectionIntentClientDiagnostics.CreateScope("ReplicationProtectionIntentResource.Get");
            scope.Start();
            try
            {
                var response = _replicationProtectionIntentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReplicationProtectionIntentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to create an ASR replication protection intent item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationProtectionIntents/{intentObjectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionIntents_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReplicationProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Create Protection Intent Input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ReplicationProtectionIntentResource>> UpdateAsync(WaitUntil waitUntil, ReplicationProtectionIntentCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _replicationProtectionIntentClientDiagnostics.CreateScope("ReplicationProtectionIntentResource.Update");
            scope.Start();
            try
            {
                var response = await _replicationProtectionIntentRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var uri = _replicationProtectionIntentRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new RecoveryServicesSiteRecoveryArmOperation<ReplicationProtectionIntentResource>(Response.FromValue(new ReplicationProtectionIntentResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// The operation to create an ASR replication protection intent item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationProtectionIntents/{intentObjectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionIntents_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReplicationProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Create Protection Intent Input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ReplicationProtectionIntentResource> Update(WaitUntil waitUntil, ReplicationProtectionIntentCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _replicationProtectionIntentClientDiagnostics.CreateScope("ReplicationProtectionIntentResource.Update");
            scope.Start();
            try
            {
                var response = _replicationProtectionIntentRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
                var uri = _replicationProtectionIntentRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new RecoveryServicesSiteRecoveryArmOperation<ReplicationProtectionIntentResource>(Response.FromValue(new ReplicationProtectionIntentResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
