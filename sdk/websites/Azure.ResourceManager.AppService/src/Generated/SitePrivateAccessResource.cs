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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a SitePrivateAccess along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SitePrivateAccessResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSitePrivateAccessResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteResource" /> using the GetSitePrivateAccess method.
    /// </summary>
    public partial class SitePrivateAccessResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SitePrivateAccessResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateAccess/virtualNetworks";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sitePrivateAccessWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _sitePrivateAccessWebAppsRestClient;
        private readonly PrivateAccessData _data;

        /// <summary> Initializes a new instance of the <see cref="SitePrivateAccessResource"/> class for mocking. </summary>
        protected SitePrivateAccessResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SitePrivateAccessResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SitePrivateAccessResource(ArmClient client, PrivateAccessData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SitePrivateAccessResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SitePrivateAccessResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sitePrivateAccessWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sitePrivateAccessWebAppsApiVersion);
            _sitePrivateAccessWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sitePrivateAccessWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/privateAccess";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PrivateAccessData Data
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
        /// Description for Gets data around private site access enablement and authorized Virtual Networks that can access the site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateAccess/virtualNetworks
        /// Operation Id: WebApps_GetPrivateAccess
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SitePrivateAccessResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sitePrivateAccessWebAppsClientDiagnostics.CreateScope("SitePrivateAccessResource.Get");
            scope.Start();
            try
            {
                var response = await _sitePrivateAccessWebAppsRestClient.GetPrivateAccessAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SitePrivateAccessResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets data around private site access enablement and authorized Virtual Networks that can access the site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateAccess/virtualNetworks
        /// Operation Id: WebApps_GetPrivateAccess
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SitePrivateAccessResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sitePrivateAccessWebAppsClientDiagnostics.CreateScope("SitePrivateAccessResource.Get");
            scope.Start();
            try
            {
                var response = _sitePrivateAccessWebAppsRestClient.GetPrivateAccess(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SitePrivateAccessResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Sets data around private site access enablement and authorized Virtual Networks that can access the site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateAccess/virtualNetworks
        /// Operation Id: WebApps_PutPrivateAccessVnet
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="access"> The information for the private access. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="access"/> is null. </exception>
        public virtual async Task<ArmOperation<SitePrivateAccessResource>> CreateOrUpdateAsync(WaitUntil waitUntil, PrivateAccessData access, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(access, nameof(access));

            using var scope = _sitePrivateAccessWebAppsClientDiagnostics.CreateScope("SitePrivateAccessResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sitePrivateAccessWebAppsRestClient.PutPrivateAccessVnetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, access, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SitePrivateAccessResource>(Response.FromValue(new SitePrivateAccessResource(Client, response), response.GetRawResponse()));
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
        /// Description for Sets data around private site access enablement and authorized Virtual Networks that can access the site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateAccess/virtualNetworks
        /// Operation Id: WebApps_PutPrivateAccessVnet
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="access"> The information for the private access. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="access"/> is null. </exception>
        public virtual ArmOperation<SitePrivateAccessResource> CreateOrUpdate(WaitUntil waitUntil, PrivateAccessData access, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(access, nameof(access));

            using var scope = _sitePrivateAccessWebAppsClientDiagnostics.CreateScope("SitePrivateAccessResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sitePrivateAccessWebAppsRestClient.PutPrivateAccessVnet(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, access, cancellationToken);
                var operation = new AppServiceArmOperation<SitePrivateAccessResource>(Response.FromValue(new SitePrivateAccessResource(Client, response), response.GetRawResponse()));
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
