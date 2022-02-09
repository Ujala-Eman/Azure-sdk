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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a StaticSiteBuildUserProvidedFunctionApp along with the instance operations that can be performed on it. </summary>
    public partial class StaticSiteBuildUserProvidedFunctionApp : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StaticSiteBuildUserProvidedFunctionApp"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string environmentName, string functionAppName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient;
        private readonly StaticSiteUserProvidedFunctionAppARMResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildUserProvidedFunctionApp"/> class for mocking. </summary>
        protected StaticSiteBuildUserProvidedFunctionApp()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "StaticSiteBuildUserProvidedFunctionApp"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StaticSiteBuildUserProvidedFunctionApp(ArmClient client, StaticSiteUserProvidedFunctionAppARMResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildUserProvidedFunctionApp"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StaticSiteBuildUserProvidedFunctionApp(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string staticSiteBuildUserProvidedFunctionAppStaticSitesApiVersion);
            _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient = new StaticSitesRestOperations(_staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, staticSiteBuildUserProvidedFunctionAppStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/staticSites/builds/userProvidedFunctionApps";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StaticSiteUserProvidedFunctionAppARMResourceData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// OperationId: StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild
        /// <summary> Description for Gets the details of the user provided function app registered with a static site build. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<StaticSiteBuildUserProvidedFunctionApp>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionApp.Get");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new StaticSiteBuildUserProvidedFunctionApp(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// OperationId: StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild
        /// <summary> Description for Gets the details of the user provided function app registered with a static site build. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StaticSiteBuildUserProvidedFunctionApp> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionApp.Get");
            scope.Start();
            try
            {
                var response = _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildUserProvidedFunctionApp(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// OperationId: StaticSites_DetachUserProvidedFunctionAppFromStaticSiteBuild
        /// <summary> Description for Detach the user provided function app from the static site build. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<StaticSiteBuildUserProvidedFunctionAppDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionApp.Delete");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.DetachUserProvidedFunctionAppFromStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new StaticSiteBuildUserProvidedFunctionAppDeleteOperation(response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// OperationId: StaticSites_DetachUserProvidedFunctionAppFromStaticSiteBuild
        /// <summary> Description for Detach the user provided function app from the static site build. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual StaticSiteBuildUserProvidedFunctionAppDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionApp.Delete");
            scope.Start();
            try
            {
                var response = _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.DetachUserProvidedFunctionAppFromStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new StaticSiteBuildUserProvidedFunctionAppDeleteOperation(response);
                if (waitForCompletion)
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
