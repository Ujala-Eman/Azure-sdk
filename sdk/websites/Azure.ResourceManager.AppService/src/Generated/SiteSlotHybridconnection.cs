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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a SiteSlotHybridconnection along with the instance operations that can be performed on it. </summary>
    public partial class SiteSlotHybridconnection : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotHybridconnection"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string entityName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;
        private readonly RelayServiceConnectionEntityData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotHybridconnection"/> class for mocking. </summary>
        protected SiteSlotHybridconnection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSlotHybridconnection"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal SiteSlotHybridconnection(ArmResource options, RelayServiceConnectionEntityData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotHybridconnection"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotHybridconnection(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotHybridconnection"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotHybridconnection(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/hybridconnection";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RelayServiceConnectionEntityData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// OperationId: WebApps_GetRelayServiceConnectionSlot
        /// <summary> Description for Gets a hybrid connection configuration by its name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SiteSlotHybridconnection>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridconnection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetRelayServiceConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotHybridconnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// OperationId: WebApps_GetRelayServiceConnectionSlot
        /// <summary> Description for Gets a hybrid connection configuration by its name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteSlotHybridconnection> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridconnection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetRelayServiceConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotHybridconnection(this, response.Value), response.GetRawResponse());
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
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// OperationId: WebApps_DeleteRelayServiceConnectionSlot
        /// <summary> Description for Deletes a relay service connection by its name. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<WebAppDeleteRelayServiceConnectionSlotOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridconnection.Delete");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.DeleteRelayServiceConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new WebAppDeleteRelayServiceConnectionSlotOperation(response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// OperationId: WebApps_DeleteRelayServiceConnectionSlot
        /// <summary> Description for Deletes a relay service connection by its name. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual WebAppDeleteRelayServiceConnectionSlotOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridconnection.Delete");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.DeleteRelayServiceConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new WebAppDeleteRelayServiceConnectionSlotOperation(response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// OperationId: WebApps_UpdateRelayServiceConnectionSlot
        /// <summary> Description for Creates a new hybrid connection configuration (PUT), or updates an existing one (PATCH). </summary>
        /// <param name="connectionEnvelope"> Details of the hybrid connection configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionEnvelope"/> is null. </exception>
        public async virtual Task<Response<SiteSlotHybridconnection>> UpdateAsync(RelayServiceConnectionEntityData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            if (connectionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(connectionEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridconnection.Update");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.UpdateRelayServiceConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, connectionEnvelope, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotHybridconnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// OperationId: WebApps_UpdateRelayServiceConnectionSlot
        /// <summary> Description for Creates a new hybrid connection configuration (PUT), or updates an existing one (PATCH). </summary>
        /// <param name="connectionEnvelope"> Details of the hybrid connection configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionEnvelope"/> is null. </exception>
        public virtual Response<SiteSlotHybridconnection> Update(RelayServiceConnectionEntityData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            if (connectionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(connectionEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridconnection.Update");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.UpdateRelayServiceConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, connectionEnvelope, cancellationToken);
                return Response.FromValue(new SiteSlotHybridconnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
