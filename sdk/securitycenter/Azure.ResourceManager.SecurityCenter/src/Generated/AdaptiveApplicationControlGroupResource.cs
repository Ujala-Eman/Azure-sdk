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

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing an AdaptiveApplicationControlGroup along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AdaptiveApplicationControlGroupResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAdaptiveApplicationControlGroupResource method.
    /// Otherwise you can get one from its parent resource <see cref="SecurityCenterLocationResource"/> using the GetAdaptiveApplicationControlGroup method.
    /// </summary>
    public partial class AdaptiveApplicationControlGroupResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AdaptiveApplicationControlGroupResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="ascLocation"> The ascLocation. </param>
        /// <param name="groupName"> The groupName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation ascLocation, string groupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/applicationWhitelistings/{groupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _adaptiveApplicationControlGroupAdaptiveApplicationControlsClientDiagnostics;
        private readonly AdaptiveApplicationControlsRestOperations _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient;
        private readonly AdaptiveApplicationControlGroupData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/locations/applicationWhitelistings";

        /// <summary> Initializes a new instance of the <see cref="AdaptiveApplicationControlGroupResource"/> class for mocking. </summary>
        protected AdaptiveApplicationControlGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AdaptiveApplicationControlGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AdaptiveApplicationControlGroupResource(ArmClient client, AdaptiveApplicationControlGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AdaptiveApplicationControlGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AdaptiveApplicationControlGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _adaptiveApplicationControlGroupAdaptiveApplicationControlsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string adaptiveApplicationControlGroupAdaptiveApplicationControlsApiVersion);
            _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient = new AdaptiveApplicationControlsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, adaptiveApplicationControlGroupAdaptiveApplicationControlsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AdaptiveApplicationControlGroupData Data
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
        /// Gets an application control VM/server group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/applicationWhitelistings/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveApplicationControls_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdaptiveApplicationControlGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AdaptiveApplicationControlGroupResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _adaptiveApplicationControlGroupAdaptiveApplicationControlsClientDiagnostics.CreateScope("AdaptiveApplicationControlGroupResource.Get");
            scope.Start();
            try
            {
                var response = await _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AdaptiveApplicationControlGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an application control VM/server group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/applicationWhitelistings/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveApplicationControls_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdaptiveApplicationControlGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AdaptiveApplicationControlGroupResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _adaptiveApplicationControlGroupAdaptiveApplicationControlsClientDiagnostics.CreateScope("AdaptiveApplicationControlGroupResource.Get");
            scope.Start();
            try
            {
                var response = _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AdaptiveApplicationControlGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete an application control machine group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/applicationWhitelistings/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveApplicationControls_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdaptiveApplicationControlGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _adaptiveApplicationControlGroupAdaptiveApplicationControlsClientDiagnostics.CreateScope("AdaptiveApplicationControlGroupResource.Delete");
            scope.Start();
            try
            {
                var response = await _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient.DeleteAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient.CreateDeleteRequestUri(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityCenterArmOperation(response, rehydrationToken);
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
        /// Delete an application control machine group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/applicationWhitelistings/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveApplicationControls_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdaptiveApplicationControlGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _adaptiveApplicationControlGroupAdaptiveApplicationControlsClientDiagnostics.CreateScope("AdaptiveApplicationControlGroupResource.Delete");
            scope.Start();
            try
            {
                var response = _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient.Delete(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                var uri = _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient.CreateDeleteRequestUri(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityCenterArmOperation(response, rehydrationToken);
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
        /// Update an application control machine group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/applicationWhitelistings/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveApplicationControls_Put</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdaptiveApplicationControlGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The <see cref="AdaptiveApplicationControlGroupData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AdaptiveApplicationControlGroupResource>> UpdateAsync(WaitUntil waitUntil, AdaptiveApplicationControlGroupData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _adaptiveApplicationControlGroupAdaptiveApplicationControlsClientDiagnostics.CreateScope("AdaptiveApplicationControlGroupResource.Update");
            scope.Start();
            try
            {
                var response = await _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient.PutAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, data, cancellationToken).ConfigureAwait(false);
                var uri = _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient.CreatePutRequestUri(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityCenterArmOperation<AdaptiveApplicationControlGroupResource>(Response.FromValue(new AdaptiveApplicationControlGroupResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Update an application control machine group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/applicationWhitelistings/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdaptiveApplicationControls_Put</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdaptiveApplicationControlGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The <see cref="AdaptiveApplicationControlGroupData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AdaptiveApplicationControlGroupResource> Update(WaitUntil waitUntil, AdaptiveApplicationControlGroupData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _adaptiveApplicationControlGroupAdaptiveApplicationControlsClientDiagnostics.CreateScope("AdaptiveApplicationControlGroupResource.Update");
            scope.Start();
            try
            {
                var response = _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient.Put(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, data, cancellationToken);
                var uri = _adaptiveApplicationControlGroupAdaptiveApplicationControlsRestClient.CreatePutRequestUri(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityCenterArmOperation<AdaptiveApplicationControlGroupResource>(Response.FromValue(new AdaptiveApplicationControlGroupResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
