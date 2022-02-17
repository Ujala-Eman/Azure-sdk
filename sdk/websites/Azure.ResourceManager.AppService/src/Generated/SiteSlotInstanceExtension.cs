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
    /// <summary> A Class representing a SiteSlotInstanceExtension along with the instance operations that can be performed on it. </summary>
    public partial class SiteSlotInstanceExtension : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotInstanceExtension"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string instanceId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/extensions/MSDeploy";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotInstanceExtensionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotInstanceExtensionWebAppsRestClient;
        private readonly MSDeployStatusData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotInstanceExtension"/> class for mocking. </summary>
        protected SiteSlotInstanceExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSlotInstanceExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotInstanceExtension(ArmClient client, MSDeployStatusData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotInstanceExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotInstanceExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotInstanceExtensionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string siteSlotInstanceExtensionWebAppsApiVersion);
            _siteSlotInstanceExtensionWebAppsRestClient = new WebAppsRestOperations(_siteSlotInstanceExtensionWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteSlotInstanceExtensionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/instances/extensions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MSDeployStatusData Data
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
        /// Description for Get the status of the last MSDeploy operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/extensions/MSDeploy
        /// Operation Id: WebApps_GetInstanceMsDeployStatusSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SiteSlotInstanceExtension>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotInstanceExtensionWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceExtension.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotInstanceExtensionWebAppsRestClient.GetInstanceMsDeployStatusSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteSlotInstanceExtensionWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotInstanceExtension(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the status of the last MSDeploy operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/extensions/MSDeploy
        /// Operation Id: WebApps_GetInstanceMsDeployStatusSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteSlotInstanceExtension> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotInstanceExtensionWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceExtension.Get");
            scope.Start();
            try
            {
                var response = _siteSlotInstanceExtensionWebAppsRestClient.GetInstanceMsDeployStatusSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw _siteSlotInstanceExtensionWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotInstanceExtension(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Invoke the MSDeploy web app extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/extensions/MSDeploy
        /// Operation Id: WebApps_CreateInstanceMSDeployOperationSlot
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="msDeploy"> Details of MSDeploy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="msDeploy"/> is null. </exception>
        public async virtual Task<ArmOperation<SiteSlotInstanceExtension>> CreateOrUpdateAsync(bool waitForCompletion, MsDeploy msDeploy, CancellationToken cancellationToken = default)
        {
            if (msDeploy == null)
            {
                throw new ArgumentNullException(nameof(msDeploy));
            }

            using var scope = _siteSlotInstanceExtensionWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceExtension.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteSlotInstanceExtensionWebAppsRestClient.CreateInstanceMSDeployOperationSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, msDeploy, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteSlotInstanceExtension>(new SiteSlotInstanceExtensionOperationSource(Client), _siteSlotInstanceExtensionWebAppsClientDiagnostics, Pipeline, _siteSlotInstanceExtensionWebAppsRestClient.CreateCreateInstanceMSDeployOperationSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, msDeploy).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Description for Invoke the MSDeploy web app extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/extensions/MSDeploy
        /// Operation Id: WebApps_CreateInstanceMSDeployOperationSlot
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="msDeploy"> Details of MSDeploy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="msDeploy"/> is null. </exception>
        public virtual ArmOperation<SiteSlotInstanceExtension> CreateOrUpdate(bool waitForCompletion, MsDeploy msDeploy, CancellationToken cancellationToken = default)
        {
            if (msDeploy == null)
            {
                throw new ArgumentNullException(nameof(msDeploy));
            }

            using var scope = _siteSlotInstanceExtensionWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceExtension.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteSlotInstanceExtensionWebAppsRestClient.CreateInstanceMSDeployOperationSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, msDeploy, cancellationToken);
                var operation = new AppServiceArmOperation<SiteSlotInstanceExtension>(new SiteSlotInstanceExtensionOperationSource(Client), _siteSlotInstanceExtensionWebAppsClientDiagnostics, Pipeline, _siteSlotInstanceExtensionWebAppsRestClient.CreateCreateInstanceMSDeployOperationSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, msDeploy).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Description for Get the MSDeploy Log for the last MSDeploy operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/extensions/MSDeploy/log
        /// Operation Id: WebApps_GetInstanceMSDeployLogSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<MsDeployLog>> GetInstanceMSDeployLogSlotAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotInstanceExtensionWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceExtension.GetInstanceMSDeployLogSlot");
            scope.Start();
            try
            {
                var response = await _siteSlotInstanceExtensionWebAppsRestClient.GetInstanceMSDeployLogSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the MSDeploy Log for the last MSDeploy operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/extensions/MSDeploy/log
        /// Operation Id: WebApps_GetInstanceMSDeployLogSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MsDeployLog> GetInstanceMSDeployLogSlot(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotInstanceExtensionWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceExtension.GetInstanceMSDeployLogSlot");
            scope.Start();
            try
            {
                var response = _siteSlotInstanceExtensionWebAppsRestClient.GetInstanceMSDeployLogSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
