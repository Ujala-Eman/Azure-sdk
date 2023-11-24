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
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing a collection of <see cref="AutomationWebhookResource"/> and their operations.
    /// Each <see cref="AutomationWebhookResource"/> in the collection will belong to the same instance of <see cref="AutomationAccountResource"/>.
    /// To get an <see cref="AutomationWebhookCollection"/> instance call the GetAutomationWebhooks method from an instance of <see cref="AutomationAccountResource"/>.
    /// </summary>
    public partial class AutomationWebhookCollection : ArmCollection, IEnumerable<AutomationWebhookResource>, IAsyncEnumerable<AutomationWebhookResource>
    {
        private readonly ClientDiagnostics _automationWebhookWebhookClientDiagnostics;
        private readonly WebhookRestOperations _automationWebhookWebhookRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomationWebhookCollection"/> class for mocking. </summary>
        protected AutomationWebhookCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationWebhookCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomationWebhookCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automationWebhookWebhookClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", AutomationWebhookResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomationWebhookResource.ResourceType, out string automationWebhookWebhookApiVersion);
            _automationWebhookWebhookRestClient = new WebhookRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automationWebhookWebhookApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AutomationAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AutomationAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create the webhook identified by webhook name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhook_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="webhookName"> The webhook name. </param>
        /// <param name="content"> The create or update parameters for webhook. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomationWebhookResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string webhookName, AutomationWebhookCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationWebhookWebhookClientDiagnostics.CreateScope("AutomationWebhookCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _automationWebhookWebhookRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, content, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation<AutomationWebhookResource>(Response.FromValue(new AutomationWebhookResource(Client, response), response.GetRawResponse()));
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
        /// Create the webhook identified by webhook name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhook_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="webhookName"> The webhook name. </param>
        /// <param name="content"> The create or update parameters for webhook. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<AutomationWebhookResource> CreateOrUpdate(WaitUntil waitUntil, string webhookName, AutomationWebhookCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationWebhookWebhookClientDiagnostics.CreateScope("AutomationWebhookCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _automationWebhookWebhookRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, content, cancellationToken);
                var operation = new AutomationArmOperation<AutomationWebhookResource>(Response.FromValue(new AutomationWebhookResource(Client, response), response.GetRawResponse()));
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
        /// Retrieve the webhook identified by webhook name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhook_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webhookName"> The webhook name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public virtual async Task<Response<AutomationWebhookResource>> GetAsync(string webhookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));

            using var scope = _automationWebhookWebhookClientDiagnostics.CreateScope("AutomationWebhookCollection.Get");
            scope.Start();
            try
            {
                var response = await _automationWebhookWebhookRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationWebhookResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the webhook identified by webhook name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhook_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webhookName"> The webhook name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public virtual Response<AutomationWebhookResource> Get(string webhookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));

            using var scope = _automationWebhookWebhookClientDiagnostics.CreateScope("AutomationWebhookCollection.Get");
            scope.Start();
            try
            {
                var response = _automationWebhookWebhookRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationWebhookResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of webhooks.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/webhooks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhook_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomationWebhookResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomationWebhookResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationWebhookWebhookRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationWebhookWebhookRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new AutomationWebhookResource(Client, AutomationWebhookData.DeserializeAutomationWebhookData(e)), _automationWebhookWebhookClientDiagnostics, Pipeline, "AutomationWebhookCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of webhooks.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/webhooks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhook_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomationWebhookResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomationWebhookResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationWebhookWebhookRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationWebhookWebhookRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new AutomationWebhookResource(Client, AutomationWebhookData.DeserializeAutomationWebhookData(e)), _automationWebhookWebhookClientDiagnostics, Pipeline, "AutomationWebhookCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhook_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webhookName"> The webhook name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string webhookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));

            using var scope = _automationWebhookWebhookClientDiagnostics.CreateScope("AutomationWebhookCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automationWebhookWebhookRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhook_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webhookName"> The webhook name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public virtual Response<bool> Exists(string webhookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));

            using var scope = _automationWebhookWebhookClientDiagnostics.CreateScope("AutomationWebhookCollection.Exists");
            scope.Start();
            try
            {
                var response = _automationWebhookWebhookRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhook_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webhookName"> The webhook name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public virtual async Task<NullableResponse<AutomationWebhookResource>> GetIfExistsAsync(string webhookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));

            using var scope = _automationWebhookWebhookClientDiagnostics.CreateScope("AutomationWebhookCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _automationWebhookWebhookRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AutomationWebhookResource>(response.GetRawResponse());
                return Response.FromValue(new AutomationWebhookResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhook_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webhookName"> The webhook name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public virtual NullableResponse<AutomationWebhookResource> GetIfExists(string webhookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));

            using var scope = _automationWebhookWebhookClientDiagnostics.CreateScope("AutomationWebhookCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _automationWebhookWebhookRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webhookName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AutomationWebhookResource>(response.GetRawResponse());
                return Response.FromValue(new AutomationWebhookResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomationWebhookResource> IEnumerable<AutomationWebhookResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomationWebhookResource> IAsyncEnumerable<AutomationWebhookResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
