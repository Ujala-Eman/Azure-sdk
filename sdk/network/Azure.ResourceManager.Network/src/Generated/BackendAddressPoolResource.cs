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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A Class representing a BackendAddressPool along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="BackendAddressPoolResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetBackendAddressPoolResource method.
    /// Otherwise you can get one from its parent resource <see cref="LoadBalancerResource"/> using the GetBackendAddressPool method.
    /// </summary>
    public partial class BackendAddressPoolResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BackendAddressPoolResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="loadBalancerName"> The loadBalancerName. </param>
        /// <param name="backendAddressPoolName"> The backendAddressPoolName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string loadBalancerName, string backendAddressPoolName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics;
        private readonly LoadBalancerBackendAddressPoolsRestOperations _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient;
        private readonly ClientDiagnostics _loadBalancerClientDiagnostics;
        private readonly LoadBalancersRestOperations _loadBalancerRestClient;
        private readonly BackendAddressPoolData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/loadBalancers/backendAddressPools";

        /// <summary> Initializes a new instance of the <see cref="BackendAddressPoolResource"/> class for mocking. </summary>
        protected BackendAddressPoolResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BackendAddressPoolResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BackendAddressPoolResource(ArmClient client, BackendAddressPoolData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BackendAddressPoolResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BackendAddressPoolResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string backendAddressPoolLoadBalancerBackendAddressPoolsApiVersion);
            _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient = new LoadBalancerBackendAddressPoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, backendAddressPoolLoadBalancerBackendAddressPoolsApiVersion);
            _loadBalancerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", LoadBalancerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LoadBalancerResource.ResourceType, out string loadBalancerApiVersion);
            _loadBalancerRestClient = new LoadBalancersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, loadBalancerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BackendAddressPoolData Data
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
        /// Gets load balancer backend address pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerBackendAddressPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackendAddressPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BackendAddressPoolResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolResource.Get");
            scope.Start();
            try
            {
                var response = await _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackendAddressPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets load balancer backend address pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerBackendAddressPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackendAddressPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BackendAddressPoolResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolResource.Get");
            scope.Start();
            try
            {
                var response = _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackendAddressPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified load balancer backend address pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerBackendAddressPools_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackendAddressPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolResource.Delete");
            scope.Start();
            try
            {
                var response = await _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics, Pipeline, _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes the specified load balancer backend address pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerBackendAddressPools_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackendAddressPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolResource.Delete");
            scope.Start();
            try
            {
                var response = _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation(_backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics, Pipeline, _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a load balancer backend address pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerBackendAddressPools_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackendAddressPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the create or update load balancer backend address pool operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BackendAddressPoolResource>> UpdateAsync(WaitUntil waitUntil, BackendAddressPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolResource.Update");
            scope.Start();
            try
            {
                var response = await _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<BackendAddressPoolResource>(new BackendAddressPoolOperationSource(Client), _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics, Pipeline, _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a load balancer backend address pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerBackendAddressPools_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackendAddressPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the create or update load balancer backend address pool operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BackendAddressPoolResource> Update(WaitUntil waitUntil, BackendAddressPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolResource.Update");
            scope.Start();
            try
            {
                var response = _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new NetworkArmOperation<BackendAddressPoolResource>(new BackendAddressPoolOperationSource(Client), _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics, Pipeline, _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// List of inbound NAT rule port mappings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendPoolName}/queryInboundNatRulePortMapping</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancers_ListInboundNatRulePortMappings</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Query inbound NAT rule port mapping request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<BackendAddressInboundNatRulePortMappings>> GetInboundNatRulePortMappingsLoadBalancerAsync(WaitUntil waitUntil, QueryInboundNatRulePortMappingContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("BackendAddressPoolResource.GetInboundNatRulePortMappingsLoadBalancer");
            scope.Start();
            try
            {
                var response = await _loadBalancerRestClient.ListInboundNatRulePortMappingsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<BackendAddressInboundNatRulePortMappings>(new BackendAddressInboundNatRulePortMappingsOperationSource(), _loadBalancerClientDiagnostics, Pipeline, _loadBalancerRestClient.CreateListInboundNatRulePortMappingsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
        /// List of inbound NAT rule port mappings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendPoolName}/queryInboundNatRulePortMapping</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancers_ListInboundNatRulePortMappings</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Query inbound NAT rule port mapping request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<BackendAddressInboundNatRulePortMappings> GetInboundNatRulePortMappingsLoadBalancer(WaitUntil waitUntil, QueryInboundNatRulePortMappingContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("BackendAddressPoolResource.GetInboundNatRulePortMappingsLoadBalancer");
            scope.Start();
            try
            {
                var response = _loadBalancerRestClient.ListInboundNatRulePortMappings(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new NetworkArmOperation<BackendAddressInboundNatRulePortMappings>(new BackendAddressInboundNatRulePortMappingsOperationSource(), _loadBalancerClientDiagnostics, Pipeline, _loadBalancerRestClient.CreateListInboundNatRulePortMappingsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
