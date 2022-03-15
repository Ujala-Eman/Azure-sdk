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
    /// <summary> A Class representing a StaticSiteBuildARMResource along with the instance operations that can be performed on it. </summary>
    public partial class StaticSiteBuildARMResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StaticSiteBuildARMResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string environmentName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _staticSiteBuildARMResourceStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSiteBuildARMResourceStaticSitesRestClient;
        private readonly StaticSiteBuildARMResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildARMResource"/> class for mocking. </summary>
        protected StaticSiteBuildARMResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "StaticSiteBuildARMResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StaticSiteBuildARMResource(ArmClient client, StaticSiteBuildARMResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildARMResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StaticSiteBuildARMResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSiteBuildARMResourceStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string staticSiteBuildARMResourceStaticSitesApiVersion);
            _staticSiteBuildARMResourceStaticSitesRestClient = new StaticSitesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, staticSiteBuildARMResourceStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/staticSites/builds";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StaticSiteBuildARMResourceData Data
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

        /// <summary> Gets a collection of StaticSiteBuildUserProvidedFunctionApps in the StaticSiteBuildUserProvidedFunctionApp. </summary>
        /// <returns> An object representing collection of StaticSiteBuildUserProvidedFunctionApps and their operations over a StaticSiteBuildUserProvidedFunctionApp. </returns>
        public virtual StaticSiteBuildUserProvidedFunctionAppCollection GetStaticSiteBuildUserProvidedFunctionApps()
        {
            return GetCachedClient(Client => new StaticSiteBuildUserProvidedFunctionAppCollection(Client, Id));
        }

        /// <summary>
        /// Description for Gets the details of the user provided function app registered with a static site build
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild
        /// </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site build. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual async Task<Response<StaticSiteBuildUserProvidedFunctionApp>> GetStaticSiteBuildUserProvidedFunctionAppAsync(string functionAppName, CancellationToken cancellationToken = default)
        {
            return await GetStaticSiteBuildUserProvidedFunctionApps().GetAsync(functionAppName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Gets the details of the user provided function app registered with a static site build
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild
        /// </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site build. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual Response<StaticSiteBuildUserProvidedFunctionApp> GetStaticSiteBuildUserProvidedFunctionApp(string functionAppName, CancellationToken cancellationToken = default)
        {
            return GetStaticSiteBuildUserProvidedFunctionApps().Get(functionAppName, cancellationToken);
        }

        /// <summary>
        /// Description for Gets the details of a static site build.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}
        /// Operation Id: StaticSites_GetStaticSiteBuild
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StaticSiteBuildARMResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMResource.Get");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildARMResourceStaticSitesRestClient.GetStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildARMResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the details of a static site build.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}
        /// Operation Id: StaticSites_GetStaticSiteBuild
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StaticSiteBuildARMResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMResource.Get");
            scope.Start();
            try
            {
                var response = _staticSiteBuildARMResourceStaticSitesRestClient.GetStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildARMResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Deletes a static site build.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}
        /// Operation Id: StaticSites_DeleteStaticSiteBuild
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMResource.Delete");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildARMResourceStaticSitesRestClient.DeleteStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation(_staticSiteBuildARMResourceStaticSitesClientDiagnostics, Pipeline, _staticSiteBuildARMResourceStaticSitesRestClient.CreateDeleteStaticSiteBuildRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Deletes a static site build.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}
        /// Operation Id: StaticSites_DeleteStaticSiteBuild
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMResource.Delete");
            scope.Start();
            try
            {
                var response = _staticSiteBuildARMResourceStaticSitesRestClient.DeleteStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation(_staticSiteBuildARMResourceStaticSitesClientDiagnostics, Pipeline, _staticSiteBuildARMResourceStaticSitesRestClient.CreateDeleteStaticSiteBuildRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Creates or updates the app settings of a static site build.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/config/appsettings
        /// Operation Id: StaticSites_CreateOrUpdateStaticSiteBuildAppSettings
        /// </summary>
        /// <param name="appSettings"> The dictionary containing the static site app settings to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appSettings"/> is null. </exception>
        public virtual async Task<Response<StringDictionary>> CreateOrUpdateStaticSiteBuildAppSettingsAsync(StringDictionary appSettings, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(appSettings, nameof(appSettings));

            using var scope = _staticSiteBuildARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMResource.CreateOrUpdateStaticSiteBuildAppSettings");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildARMResourceStaticSitesRestClient.CreateOrUpdateStaticSiteBuildAppSettingsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, appSettings, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Creates or updates the app settings of a static site build.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/config/appsettings
        /// Operation Id: StaticSites_CreateOrUpdateStaticSiteBuildAppSettings
        /// </summary>
        /// <param name="appSettings"> The dictionary containing the static site app settings to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appSettings"/> is null. </exception>
        public virtual Response<StringDictionary> CreateOrUpdateStaticSiteBuildAppSettings(StringDictionary appSettings, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(appSettings, nameof(appSettings));

            using var scope = _staticSiteBuildARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMResource.CreateOrUpdateStaticSiteBuildAppSettings");
            scope.Start();
            try
            {
                var response = _staticSiteBuildARMResourceStaticSitesRestClient.CreateOrUpdateStaticSiteBuildAppSettings(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, appSettings, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Creates or updates the function app settings of a static site build.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/config/functionappsettings
        /// Operation Id: StaticSites_CreateOrUpdateStaticSiteBuildFunctionAppSettings
        /// </summary>
        /// <param name="appSettings"> The dictionary containing the static site function app settings to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appSettings"/> is null. </exception>
        public virtual async Task<Response<StringDictionary>> CreateOrUpdateStaticSiteBuildFunctionAppSettingsAsync(StringDictionary appSettings, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(appSettings, nameof(appSettings));

            using var scope = _staticSiteBuildARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMResource.CreateOrUpdateStaticSiteBuildFunctionAppSettings");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildARMResourceStaticSitesRestClient.CreateOrUpdateStaticSiteBuildFunctionAppSettingsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, appSettings, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Creates or updates the function app settings of a static site build.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/config/functionappsettings
        /// Operation Id: StaticSites_CreateOrUpdateStaticSiteBuildFunctionAppSettings
        /// </summary>
        /// <param name="appSettings"> The dictionary containing the static site function app settings to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appSettings"/> is null. </exception>
        public virtual Response<StringDictionary> CreateOrUpdateStaticSiteBuildFunctionAppSettings(StringDictionary appSettings, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(appSettings, nameof(appSettings));

            using var scope = _staticSiteBuildARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMResource.CreateOrUpdateStaticSiteBuildFunctionAppSettings");
            scope.Start();
            try
            {
                var response = _staticSiteBuildARMResourceStaticSitesRestClient.CreateOrUpdateStaticSiteBuildFunctionAppSettings(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, appSettings, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the functions of a particular static site build.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/functions
        /// Operation Id: StaticSites_ListStaticSiteBuildFunctions
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StaticSiteFunctionOverviewARMResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StaticSiteFunctionOverviewARMResource> GetStaticSiteBuildFunctionsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<StaticSiteFunctionOverviewARMResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _staticSiteBuildARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMResource.GetStaticSiteBuildFunctions");
                scope.Start();
                try
                {
                    var response = await _staticSiteBuildARMResourceStaticSitesRestClient.ListStaticSiteBuildFunctionsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<StaticSiteFunctionOverviewARMResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _staticSiteBuildARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMResource.GetStaticSiteBuildFunctions");
                scope.Start();
                try
                {
                    var response = await _staticSiteBuildARMResourceStaticSitesRestClient.ListStaticSiteBuildFunctionsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Description for Gets the functions of a particular static site build.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/functions
        /// Operation Id: StaticSites_ListStaticSiteBuildFunctions
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StaticSiteFunctionOverviewARMResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StaticSiteFunctionOverviewARMResource> GetStaticSiteBuildFunctions(CancellationToken cancellationToken = default)
        {
            Page<StaticSiteFunctionOverviewARMResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _staticSiteBuildARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMResource.GetStaticSiteBuildFunctions");
                scope.Start();
                try
                {
                    var response = _staticSiteBuildARMResourceStaticSitesRestClient.ListStaticSiteBuildFunctions(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<StaticSiteFunctionOverviewARMResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _staticSiteBuildARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMResource.GetStaticSiteBuildFunctions");
                scope.Start();
                try
                {
                    var response = _staticSiteBuildARMResourceStaticSitesRestClient.ListStaticSiteBuildFunctionsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Description for Gets the application settings of a static site build.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/listAppSettings
        /// Operation Id: StaticSites_ListStaticSiteBuildAppSettings
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StringDictionary>> GetStaticSiteBuildAppSettingsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMResource.GetStaticSiteBuildAppSettings");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildARMResourceStaticSitesRestClient.ListStaticSiteBuildAppSettingsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the application settings of a static site build.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/listAppSettings
        /// Operation Id: StaticSites_ListStaticSiteBuildAppSettings
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StringDictionary> GetStaticSiteBuildAppSettings(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMResource.GetStaticSiteBuildAppSettings");
            scope.Start();
            try
            {
                var response = _staticSiteBuildARMResourceStaticSitesRestClient.ListStaticSiteBuildAppSettings(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the application settings of a static site build.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/listFunctionAppSettings
        /// Operation Id: StaticSites_ListStaticSiteBuildFunctionAppSettings
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StringDictionary>> GetStaticSiteBuildFunctionAppSettingsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMResource.GetStaticSiteBuildFunctionAppSettings");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildARMResourceStaticSitesRestClient.ListStaticSiteBuildFunctionAppSettingsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the application settings of a static site build.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/listFunctionAppSettings
        /// Operation Id: StaticSites_ListStaticSiteBuildFunctionAppSettings
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StringDictionary> GetStaticSiteBuildFunctionAppSettings(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMResource.GetStaticSiteBuildFunctionAppSettings");
            scope.Start();
            try
            {
                var response = _staticSiteBuildARMResourceStaticSitesRestClient.ListStaticSiteBuildFunctionAppSettings(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Deploys zipped content to a specific environment of a static site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/zipdeploy
        /// Operation Id: StaticSites_CreateZipDeploymentForStaticSiteBuild
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="staticSiteZipDeploymentEnvelope"> A JSON representation of the StaticSiteZipDeployment properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="staticSiteZipDeploymentEnvelope"/> is null. </exception>
        public virtual async Task<ArmOperation> CreateZipDeploymentForStaticSiteBuildAsync(WaitUntil waitUntil, StaticSiteZipDeploymentARMResource staticSiteZipDeploymentEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(staticSiteZipDeploymentEnvelope, nameof(staticSiteZipDeploymentEnvelope));

            using var scope = _staticSiteBuildARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMResource.CreateZipDeploymentForStaticSiteBuild");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildARMResourceStaticSitesRestClient.CreateZipDeploymentForStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, staticSiteZipDeploymentEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation(_staticSiteBuildARMResourceStaticSitesClientDiagnostics, Pipeline, _staticSiteBuildARMResourceStaticSitesRestClient.CreateCreateZipDeploymentForStaticSiteBuildRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, staticSiteZipDeploymentEnvelope).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Deploys zipped content to a specific environment of a static site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/zipdeploy
        /// Operation Id: StaticSites_CreateZipDeploymentForStaticSiteBuild
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="staticSiteZipDeploymentEnvelope"> A JSON representation of the StaticSiteZipDeployment properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="staticSiteZipDeploymentEnvelope"/> is null. </exception>
        public virtual ArmOperation CreateZipDeploymentForStaticSiteBuild(WaitUntil waitUntil, StaticSiteZipDeploymentARMResource staticSiteZipDeploymentEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(staticSiteZipDeploymentEnvelope, nameof(staticSiteZipDeploymentEnvelope));

            using var scope = _staticSiteBuildARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMResource.CreateZipDeploymentForStaticSiteBuild");
            scope.Start();
            try
            {
                var response = _staticSiteBuildARMResourceStaticSitesRestClient.CreateZipDeploymentForStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, staticSiteZipDeploymentEnvelope, cancellationToken);
                var operation = new AppServiceArmOperation(_staticSiteBuildARMResourceStaticSitesClientDiagnostics, Pipeline, _staticSiteBuildARMResourceStaticSitesRestClient.CreateCreateZipDeploymentForStaticSiteBuildRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, staticSiteZipDeploymentEnvelope).Request, response, OperationFinalStateVia.Location);
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
