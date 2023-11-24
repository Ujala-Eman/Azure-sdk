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
    /// A class representing a collection of <see cref="AutomationConnectionTypeResource"/> and their operations.
    /// Each <see cref="AutomationConnectionTypeResource"/> in the collection will belong to the same instance of <see cref="AutomationAccountResource"/>.
    /// To get an <see cref="AutomationConnectionTypeCollection"/> instance call the GetAutomationConnectionTypes method from an instance of <see cref="AutomationAccountResource"/>.
    /// </summary>
    public partial class AutomationConnectionTypeCollection : ArmCollection, IEnumerable<AutomationConnectionTypeResource>, IAsyncEnumerable<AutomationConnectionTypeResource>
    {
        private readonly ClientDiagnostics _automationConnectionTypeConnectionTypeClientDiagnostics;
        private readonly ConnectionTypeRestOperations _automationConnectionTypeConnectionTypeRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomationConnectionTypeCollection"/> class for mocking. </summary>
        protected AutomationConnectionTypeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationConnectionTypeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomationConnectionTypeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automationConnectionTypeConnectionTypeClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", AutomationConnectionTypeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomationConnectionTypeResource.ResourceType, out string automationConnectionTypeConnectionTypeApiVersion);
            _automationConnectionTypeConnectionTypeRestClient = new ConnectionTypeRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automationConnectionTypeConnectionTypeApiVersion);
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
        /// Create a connection type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/connectionTypes/{connectionTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionType_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionTypeName"> The parameters supplied to the create or update connection type operation. </param>
        /// <param name="content"> The parameters supplied to the create or update connection type operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionTypeName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomationConnectionTypeResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string connectionTypeName, AutomationConnectionTypeCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionTypeName, nameof(connectionTypeName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationConnectionTypeConnectionTypeClientDiagnostics.CreateScope("AutomationConnectionTypeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _automationConnectionTypeConnectionTypeRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionTypeName, content, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation<AutomationConnectionTypeResource>(Response.FromValue(new AutomationConnectionTypeResource(Client, response), response.GetRawResponse()));
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
        /// Create a connection type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/connectionTypes/{connectionTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionType_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionTypeName"> The parameters supplied to the create or update connection type operation. </param>
        /// <param name="content"> The parameters supplied to the create or update connection type operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionTypeName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<AutomationConnectionTypeResource> CreateOrUpdate(WaitUntil waitUntil, string connectionTypeName, AutomationConnectionTypeCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionTypeName, nameof(connectionTypeName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationConnectionTypeConnectionTypeClientDiagnostics.CreateScope("AutomationConnectionTypeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _automationConnectionTypeConnectionTypeRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionTypeName, content, cancellationToken);
                var operation = new AutomationArmOperation<AutomationConnectionTypeResource>(Response.FromValue(new AutomationConnectionTypeResource(Client, response), response.GetRawResponse()));
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
        /// Retrieve the connection type identified by connection type name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/connectionTypes/{connectionTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionType_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionTypeName"> The name of connection type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionTypeName"/> is null. </exception>
        public virtual async Task<Response<AutomationConnectionTypeResource>> GetAsync(string connectionTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionTypeName, nameof(connectionTypeName));

            using var scope = _automationConnectionTypeConnectionTypeClientDiagnostics.CreateScope("AutomationConnectionTypeCollection.Get");
            scope.Start();
            try
            {
                var response = await _automationConnectionTypeConnectionTypeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionTypeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationConnectionTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the connection type identified by connection type name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/connectionTypes/{connectionTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionType_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionTypeName"> The name of connection type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionTypeName"/> is null. </exception>
        public virtual Response<AutomationConnectionTypeResource> Get(string connectionTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionTypeName, nameof(connectionTypeName));

            using var scope = _automationConnectionTypeConnectionTypeClientDiagnostics.CreateScope("AutomationConnectionTypeCollection.Get");
            scope.Start();
            try
            {
                var response = _automationConnectionTypeConnectionTypeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionTypeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationConnectionTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of connection types.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/connectionTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionType_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomationConnectionTypeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomationConnectionTypeResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationConnectionTypeConnectionTypeRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationConnectionTypeConnectionTypeRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new AutomationConnectionTypeResource(Client, AutomationConnectionTypeData.DeserializeAutomationConnectionTypeData(e)), _automationConnectionTypeConnectionTypeClientDiagnostics, Pipeline, "AutomationConnectionTypeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of connection types.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/connectionTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionType_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomationConnectionTypeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomationConnectionTypeResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationConnectionTypeConnectionTypeRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationConnectionTypeConnectionTypeRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new AutomationConnectionTypeResource(Client, AutomationConnectionTypeData.DeserializeAutomationConnectionTypeData(e)), _automationConnectionTypeConnectionTypeClientDiagnostics, Pipeline, "AutomationConnectionTypeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/connectionTypes/{connectionTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionType_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionTypeName"> The name of connection type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionTypeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string connectionTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionTypeName, nameof(connectionTypeName));

            using var scope = _automationConnectionTypeConnectionTypeClientDiagnostics.CreateScope("AutomationConnectionTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automationConnectionTypeConnectionTypeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionTypeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/connectionTypes/{connectionTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionType_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionTypeName"> The name of connection type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionTypeName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionTypeName, nameof(connectionTypeName));

            using var scope = _automationConnectionTypeConnectionTypeClientDiagnostics.CreateScope("AutomationConnectionTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = _automationConnectionTypeConnectionTypeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionTypeName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/connectionTypes/{connectionTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionType_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionTypeName"> The name of connection type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionTypeName"/> is null. </exception>
        public virtual async Task<NullableResponse<AutomationConnectionTypeResource>> GetIfExistsAsync(string connectionTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionTypeName, nameof(connectionTypeName));

            using var scope = _automationConnectionTypeConnectionTypeClientDiagnostics.CreateScope("AutomationConnectionTypeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _automationConnectionTypeConnectionTypeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionTypeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AutomationConnectionTypeResource>(response.GetRawResponse());
                return Response.FromValue(new AutomationConnectionTypeResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/connectionTypes/{connectionTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionType_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionTypeName"> The name of connection type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionTypeName"/> is null. </exception>
        public virtual NullableResponse<AutomationConnectionTypeResource> GetIfExists(string connectionTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionTypeName, nameof(connectionTypeName));

            using var scope = _automationConnectionTypeConnectionTypeClientDiagnostics.CreateScope("AutomationConnectionTypeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _automationConnectionTypeConnectionTypeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionTypeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AutomationConnectionTypeResource>(response.GetRawResponse());
                return Response.FromValue(new AutomationConnectionTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomationConnectionTypeResource> IEnumerable<AutomationConnectionTypeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomationConnectionTypeResource> IAsyncEnumerable<AutomationConnectionTypeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
