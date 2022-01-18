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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a NetworkVirtualAppliance along with the instance operations that can be performed on it. </summary>
    public partial class NetworkVirtualAppliance : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NetworkVirtualAppliance"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string networkVirtualApplianceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly NetworkVirtualAppliancesRestOperations _networkVirtualAppliancesRestClient;
        private readonly InboundSecurityRuleRestOperations _inboundSecurityRuleRestClient;
        private readonly NetworkVirtualApplianceData _data;

        /// <summary> Initializes a new instance of the <see cref="NetworkVirtualAppliance"/> class for mocking. </summary>
        protected NetworkVirtualAppliance()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "NetworkVirtualAppliance"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal NetworkVirtualAppliance(ArmResource options, NetworkVirtualApplianceData data) : base(options, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _networkVirtualAppliancesRestClient = new NetworkVirtualAppliancesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _inboundSecurityRuleRestClient = new InboundSecurityRuleRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkVirtualAppliance"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NetworkVirtualAppliance(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _networkVirtualAppliancesRestClient = new NetworkVirtualAppliancesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _inboundSecurityRuleRestClient = new InboundSecurityRuleRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkVirtualAppliance"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NetworkVirtualAppliance(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _networkVirtualAppliancesRestClient = new NetworkVirtualAppliancesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _inboundSecurityRuleRestClient = new InboundSecurityRuleRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/networkVirtualAppliances";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual NetworkVirtualApplianceData Data
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

        /// <summary> Gets the specified Network Virtual Appliance. </summary>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<NetworkVirtualAppliance>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliance.Get");
            scope.Start();
            try
            {
                var response = await _networkVirtualAppliancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NetworkVirtualAppliance(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Network Virtual Appliance. </summary>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkVirtualAppliance> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliance.Get");
            scope.Start();
            try
            {
                var response = _networkVirtualAppliancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkVirtualAppliance(this, response.Value), response.GetRawResponse());
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
            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliance.GetAvailableLocations");
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
            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliance.GetAvailableLocations");
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

        /// <summary> Deletes the specified Network Virtual Appliance. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<NetworkVirtualApplianceDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliance.Delete");
            scope.Start();
            try
            {
                var response = await _networkVirtualAppliancesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkVirtualApplianceDeleteOperation(_clientDiagnostics, Pipeline, _networkVirtualAppliancesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Deletes the specified Network Virtual Appliance. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NetworkVirtualApplianceDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliance.Delete");
            scope.Start();
            try
            {
                var response = _networkVirtualAppliancesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new NetworkVirtualApplianceDeleteOperation(_clientDiagnostics, Pipeline, _networkVirtualAppliancesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Updates a Network Virtual Appliance. </summary>
        /// <param name="parameters"> Parameters supplied to Update Network Virtual Appliance Tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<NetworkVirtualAppliance>> UpdateAsync(TagsObject parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliance.Update");
            scope.Start();
            try
            {
                var response = await _networkVirtualAppliancesRestClient.UpdateTagsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new NetworkVirtualAppliance(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a Network Virtual Appliance. </summary>
        /// <param name="parameters"> Parameters supplied to Update Network Virtual Appliance Tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<NetworkVirtualAppliance> Update(TagsObject parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliance.Update");
            scope.Start();
            try
            {
                var response = _networkVirtualAppliancesRestClient.UpdateTags(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                return Response.FromValue(new NetworkVirtualAppliance(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Network Virtual Appliance Inbound Security Rules. </summary>
        /// <param name="ruleCollectionName"> The name of security rule collection. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Network Virtual Appliance Inbound Security Rules operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<InboundSecurityRuleCreateOrUpdateOperation> CreateOrUpdateInboundSecurityRuleAsync(bool waitForCompletion, string ruleCollectionName, InboundSecurityRule parameters, CancellationToken cancellationToken = default)
        {
            if (ruleCollectionName == null)
            {
                throw new ArgumentNullException(nameof(ruleCollectionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliance.CreateOrUpdateInboundSecurityRule");
            scope.Start();
            try
            {
                var response = await _inboundSecurityRuleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleCollectionName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new InboundSecurityRuleCreateOrUpdateOperation(_clientDiagnostics, Pipeline, _inboundSecurityRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleCollectionName, parameters).Request, response);
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

        /// <summary> Creates or updates the specified Network Virtual Appliance Inbound Security Rules. </summary>
        /// <param name="ruleCollectionName"> The name of security rule collection. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Network Virtual Appliance Inbound Security Rules operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual InboundSecurityRuleCreateOrUpdateOperation CreateOrUpdateInboundSecurityRule(bool waitForCompletion, string ruleCollectionName, InboundSecurityRule parameters, CancellationToken cancellationToken = default)
        {
            if (ruleCollectionName == null)
            {
                throw new ArgumentNullException(nameof(ruleCollectionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualAppliance.CreateOrUpdateInboundSecurityRule");
            scope.Start();
            try
            {
                var response = _inboundSecurityRuleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleCollectionName, parameters, cancellationToken);
                var operation = new InboundSecurityRuleCreateOrUpdateOperation(_clientDiagnostics, Pipeline, _inboundSecurityRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleCollectionName, parameters).Request, response);
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

        #region VirtualApplianceSite

        /// <summary> Gets a collection of VirtualApplianceSites in the NetworkVirtualAppliance. </summary>
        /// <returns> An object representing collection of VirtualApplianceSites and their operations over a NetworkVirtualAppliance. </returns>
        public virtual VirtualApplianceSiteCollection GetVirtualApplianceSites()
        {
            return new VirtualApplianceSiteCollection(this);
        }
        #endregion
    }
}
