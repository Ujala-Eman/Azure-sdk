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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a SiteProcessModule along with the instance operations that can be performed on it. </summary>
    public partial class SiteProcessModule : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteProcessModule"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string processId, string baseAddress)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/modules/{baseAddress}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteProcessModuleWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteProcessModuleWebAppsRestClient;
        private readonly ProcessModuleInfoData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteProcessModule"/> class for mocking. </summary>
        protected SiteProcessModule()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteProcessModule"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteProcessModule(ArmClient client, ProcessModuleInfoData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteProcessModule"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteProcessModule(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteProcessModuleWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string siteProcessModuleWebAppsApiVersion);
            _siteProcessModuleWebAppsRestClient = new WebAppsRestOperations(_siteProcessModuleWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteProcessModuleWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/processes/modules";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ProcessModuleInfoData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/modules/{baseAddress}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/modules/{baseAddress}
        /// OperationId: WebApps_GetProcessModule
        /// <summary> Description for Get process information by its ID for a specific scaled-out instance in a web site. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SiteProcessModule>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteProcessModuleWebAppsClientDiagnostics.CreateScope("SiteProcessModule.Get");
            scope.Start();
            try
            {
                var response = await _siteProcessModuleWebAppsRestClient.GetProcessModuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteProcessModuleWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteProcessModule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/modules/{baseAddress}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/modules/{baseAddress}
        /// OperationId: WebApps_GetProcessModule
        /// <summary> Description for Get process information by its ID for a specific scaled-out instance in a web site. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteProcessModule> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteProcessModuleWebAppsClientDiagnostics.CreateScope("SiteProcessModule.Get");
            scope.Start();
            try
            {
                var response = _siteProcessModuleWebAppsRestClient.GetProcessModule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _siteProcessModuleWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteProcessModule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
