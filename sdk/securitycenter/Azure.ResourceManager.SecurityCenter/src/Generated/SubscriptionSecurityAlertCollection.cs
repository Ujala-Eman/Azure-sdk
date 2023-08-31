// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="SubscriptionSecurityAlertResource" /> and their operations.
    /// Each <see cref="SubscriptionSecurityAlertResource" /> in the collection will belong to the same instance of <see cref="SecurityCenterLocationResource" />.
    /// To get a <see cref="SubscriptionSecurityAlertCollection" /> instance call the GetSubscriptionSecurityAlerts method from an instance of <see cref="SecurityCenterLocationResource" />.
    /// </summary>
    public partial class SubscriptionSecurityAlertCollection : ArmCollection, IEnumerable<SubscriptionSecurityAlertResource>, IAsyncEnumerable<SubscriptionSecurityAlertResource>
    {
        private readonly ClientDiagnostics _subscriptionSecurityAlertAlertsClientDiagnostics;
        private readonly AlertsRestOperations _subscriptionSecurityAlertAlertsRestClient;
        private readonly ClientDiagnostics _alertsClientDiagnostics;
        private readonly AlertsRestOperations _alertsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionSecurityAlertCollection"/> class for mocking. </summary>
        protected SubscriptionSecurityAlertCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionSecurityAlertCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SubscriptionSecurityAlertCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionSecurityAlertAlertsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", SubscriptionSecurityAlertResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubscriptionSecurityAlertResource.ResourceType, out string subscriptionSecurityAlertAlertsApiVersion);
            _subscriptionSecurityAlertAlertsRestClient = new AlertsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionSecurityAlertAlertsApiVersion);
            _alertsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _alertsRestClient = new AlertsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SecurityCenterLocationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SecurityCenterLocationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get an alert that is associated with a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetSubscriptionLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertName"> Name of the alert object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertName"/> is null. </exception>
        public virtual async Task<Response<SubscriptionSecurityAlertResource>> GetAsync(string alertName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertName, nameof(alertName));

            using var scope = _subscriptionSecurityAlertAlertsClientDiagnostics.CreateScope("SubscriptionSecurityAlertCollection.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionSecurityAlertAlertsRestClient.GetSubscriptionLevelAsync(Id.SubscriptionId, new AzureLocation(Id.Name), alertName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionSecurityAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an alert that is associated with a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetSubscriptionLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertName"> Name of the alert object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertName"/> is null. </exception>
        public virtual Response<SubscriptionSecurityAlertResource> Get(string alertName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertName, nameof(alertName));

            using var scope = _subscriptionSecurityAlertAlertsClientDiagnostics.CreateScope("SubscriptionSecurityAlertCollection.Get");
            scope.Start();
            try
            {
                var response = _subscriptionSecurityAlertAlertsRestClient.GetSubscriptionLevel(Id.SubscriptionId, new AzureLocation(Id.Name), alertName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionSecurityAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the alerts that are associated with the subscription that are stored in a specific location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_ListSubscriptionLevelByRegion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubscriptionSecurityAlertResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubscriptionSecurityAlertResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _subscriptionSecurityAlertAlertsRestClient.CreateListSubscriptionLevelByRegionRequest(Id.SubscriptionId, new AzureLocation(Id.Name));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _subscriptionSecurityAlertAlertsRestClient.CreateListSubscriptionLevelByRegionNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(Id.Name));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SubscriptionSecurityAlertResource(Client, SecurityAlertData.DeserializeSecurityAlertData(e)), _subscriptionSecurityAlertAlertsClientDiagnostics, Pipeline, "SubscriptionSecurityAlertCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the alerts that are associated with the subscription that are stored in a specific location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_ListSubscriptionLevelByRegion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubscriptionSecurityAlertResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubscriptionSecurityAlertResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _subscriptionSecurityAlertAlertsRestClient.CreateListSubscriptionLevelByRegionRequest(Id.SubscriptionId, new AzureLocation(Id.Name));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _subscriptionSecurityAlertAlertsRestClient.CreateListSubscriptionLevelByRegionNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(Id.Name));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SubscriptionSecurityAlertResource(Client, SecurityAlertData.DeserializeSecurityAlertData(e)), _subscriptionSecurityAlertAlertsClientDiagnostics, Pipeline, "SubscriptionSecurityAlertCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Simulate security alerts
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/default/simulate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_Simulate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Alert Simulator Request Properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation> SimulateAsync(WaitUntil waitUntil, SecurityAlertSimulatorContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _alertsClientDiagnostics.CreateScope("SubscriptionSecurityAlertCollection.Simulate");
            scope.Start();
            try
            {
                var response = await _alertsRestClient.SimulateAsync(Id.SubscriptionId, new AzureLocation(Id.Name), content, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation(_alertsClientDiagnostics, Pipeline, _alertsRestClient.CreateSimulateRequest(Id.SubscriptionId, new AzureLocation(Id.Name), content).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Simulate security alerts
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/default/simulate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_Simulate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Alert Simulator Request Properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation Simulate(WaitUntil waitUntil, SecurityAlertSimulatorContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _alertsClientDiagnostics.CreateScope("SubscriptionSecurityAlertCollection.Simulate");
            scope.Start();
            try
            {
                var response = _alertsRestClient.Simulate(Id.SubscriptionId, new AzureLocation(Id.Name), content, cancellationToken);
                var operation = new SecurityCenterArmOperation(_alertsClientDiagnostics, Pipeline, _alertsRestClient.CreateSimulateRequest(Id.SubscriptionId, new AzureLocation(Id.Name), content).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetSubscriptionLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertName"> Name of the alert object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string alertName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertName, nameof(alertName));

            using var scope = _subscriptionSecurityAlertAlertsClientDiagnostics.CreateScope("SubscriptionSecurityAlertCollection.Exists");
            scope.Start();
            try
            {
                var response = await _subscriptionSecurityAlertAlertsRestClient.GetSubscriptionLevelAsync(Id.SubscriptionId, new AzureLocation(Id.Name), alertName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetSubscriptionLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertName"> Name of the alert object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertName"/> is null. </exception>
        public virtual Response<bool> Exists(string alertName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertName, nameof(alertName));

            using var scope = _subscriptionSecurityAlertAlertsClientDiagnostics.CreateScope("SubscriptionSecurityAlertCollection.Exists");
            scope.Start();
            try
            {
                var response = _subscriptionSecurityAlertAlertsRestClient.GetSubscriptionLevel(Id.SubscriptionId, new AzureLocation(Id.Name), alertName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubscriptionSecurityAlertResource> IEnumerable<SubscriptionSecurityAlertResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubscriptionSecurityAlertResource> IAsyncEnumerable<SubscriptionSecurityAlertResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
