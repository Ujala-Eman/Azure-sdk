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

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing a collection of <see cref="LogicAppResource"/> and their operations.
    /// Each <see cref="LogicAppResource"/> in the collection will belong to the same instance of <see cref="ContainerAppResource"/>.
    /// To get a <see cref="LogicAppCollection"/> instance call the GetLogicApps method from an instance of <see cref="ContainerAppResource"/>.
    /// </summary>
    public partial class LogicAppCollection : ArmCollection
    {
        private readonly ClientDiagnostics _logicAppClientDiagnostics;
        private readonly LogicAppsRestOperations _logicAppRestClient;

        /// <summary> Initializes a new instance of the <see cref="LogicAppCollection"/> class for mocking. </summary>
        protected LogicAppCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LogicAppCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LogicAppCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _logicAppClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", LogicAppResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LogicAppResource.ResourceType, out string logicAppApiVersion);
            _logicAppRestClient = new LogicAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logicAppApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerAppResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerAppResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Logic App extension resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/providers/Microsoft.App/logicApps/{logicAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogicApps_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="logicAppName"> Name of the Logic App, the extension resource. </param>
        /// <param name="data"> Logic app resource properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logicAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logicAppName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LogicAppResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string logicAppName, LogicAppData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(logicAppName, nameof(logicAppName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _logicAppClientDiagnostics.CreateScope("LogicAppCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _logicAppRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, logicAppName, data, cancellationToken).ConfigureAwait(false);
                var uri = _logicAppRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, logicAppName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AppContainersArmOperation<LogicAppResource>(Response.FromValue(new LogicAppResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create or update a Logic App extension resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/providers/Microsoft.App/logicApps/{logicAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogicApps_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="logicAppName"> Name of the Logic App, the extension resource. </param>
        /// <param name="data"> Logic app resource properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logicAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logicAppName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LogicAppResource> CreateOrUpdate(WaitUntil waitUntil, string logicAppName, LogicAppData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(logicAppName, nameof(logicAppName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _logicAppClientDiagnostics.CreateScope("LogicAppCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _logicAppRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, logicAppName, data, cancellationToken);
                var uri = _logicAppRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, logicAppName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AppContainersArmOperation<LogicAppResource>(Response.FromValue(new LogicAppResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets a logic app extension resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/providers/Microsoft.App/logicApps/{logicAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogicApps_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="logicAppName"> Name of the Logic App, the extension resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logicAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logicAppName"/> is null. </exception>
        public virtual async Task<Response<LogicAppResource>> GetAsync(string logicAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(logicAppName, nameof(logicAppName));

            using var scope = _logicAppClientDiagnostics.CreateScope("LogicAppCollection.Get");
            scope.Start();
            try
            {
                var response = await _logicAppRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, logicAppName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicAppResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a logic app extension resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/providers/Microsoft.App/logicApps/{logicAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogicApps_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="logicAppName"> Name of the Logic App, the extension resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logicAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logicAppName"/> is null. </exception>
        public virtual Response<LogicAppResource> Get(string logicAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(logicAppName, nameof(logicAppName));

            using var scope = _logicAppClientDiagnostics.CreateScope("LogicAppCollection.Get");
            scope.Start();
            try
            {
                var response = _logicAppRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, logicAppName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicAppResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/providers/Microsoft.App/logicApps/{logicAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogicApps_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="logicAppName"> Name of the Logic App, the extension resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logicAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logicAppName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string logicAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(logicAppName, nameof(logicAppName));

            using var scope = _logicAppClientDiagnostics.CreateScope("LogicAppCollection.Exists");
            scope.Start();
            try
            {
                var response = await _logicAppRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, logicAppName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/providers/Microsoft.App/logicApps/{logicAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogicApps_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="logicAppName"> Name of the Logic App, the extension resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logicAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logicAppName"/> is null. </exception>
        public virtual Response<bool> Exists(string logicAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(logicAppName, nameof(logicAppName));

            using var scope = _logicAppClientDiagnostics.CreateScope("LogicAppCollection.Exists");
            scope.Start();
            try
            {
                var response = _logicAppRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, logicAppName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/providers/Microsoft.App/logicApps/{logicAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogicApps_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="logicAppName"> Name of the Logic App, the extension resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logicAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logicAppName"/> is null. </exception>
        public virtual async Task<NullableResponse<LogicAppResource>> GetIfExistsAsync(string logicAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(logicAppName, nameof(logicAppName));

            using var scope = _logicAppClientDiagnostics.CreateScope("LogicAppCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _logicAppRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, logicAppName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<LogicAppResource>(response.GetRawResponse());
                return Response.FromValue(new LogicAppResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/providers/Microsoft.App/logicApps/{logicAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogicApps_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="logicAppName"> Name of the Logic App, the extension resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logicAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logicAppName"/> is null. </exception>
        public virtual NullableResponse<LogicAppResource> GetIfExists(string logicAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(logicAppName, nameof(logicAppName));

            using var scope = _logicAppClientDiagnostics.CreateScope("LogicAppCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _logicAppRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, logicAppName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<LogicAppResource>(response.GetRawResponse());
                return Response.FromValue(new LogicAppResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
