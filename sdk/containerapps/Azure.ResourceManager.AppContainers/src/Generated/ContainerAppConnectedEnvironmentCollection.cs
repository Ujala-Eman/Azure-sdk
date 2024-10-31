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
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerAppConnectedEnvironmentResource"/> and their operations.
    /// Each <see cref="ContainerAppConnectedEnvironmentResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="ContainerAppConnectedEnvironmentCollection"/> instance call the GetContainerAppConnectedEnvironments method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class ContainerAppConnectedEnvironmentCollection : ArmCollection, IEnumerable<ContainerAppConnectedEnvironmentResource>, IAsyncEnumerable<ContainerAppConnectedEnvironmentResource>
    {
        private readonly ClientDiagnostics _containerAppConnectedEnvironmentConnectedEnvironmentsClientDiagnostics;
        private readonly ConnectedEnvironmentsRestOperations _containerAppConnectedEnvironmentConnectedEnvironmentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerAppConnectedEnvironmentCollection"/> class for mocking. </summary>
        protected ContainerAppConnectedEnvironmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppConnectedEnvironmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerAppConnectedEnvironmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppConnectedEnvironmentConnectedEnvironmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ContainerAppConnectedEnvironmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerAppConnectedEnvironmentResource.ResourceType, out string containerAppConnectedEnvironmentConnectedEnvironmentsApiVersion);
            _containerAppConnectedEnvironmentConnectedEnvironmentsRestClient = new ConnectedEnvironmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppConnectedEnvironmentConnectedEnvironmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an connectedEnvironment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironments_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectedEnvironmentName"> Name of the connectedEnvironment. </param>
        /// <param name="data"> Configuration details of the connectedEnvironment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectedEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedEnvironmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerAppConnectedEnvironmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string connectedEnvironmentName, ContainerAppConnectedEnvironmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectedEnvironmentName, nameof(connectedEnvironmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerAppConnectedEnvironmentConnectedEnvironmentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerAppConnectedEnvironmentConnectedEnvironmentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, connectedEnvironmentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppContainersArmOperation<ContainerAppConnectedEnvironmentResource>(new ContainerAppConnectedEnvironmentOperationSource(Client), _containerAppConnectedEnvironmentConnectedEnvironmentsClientDiagnostics, Pipeline, _containerAppConnectedEnvironmentConnectedEnvironmentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, connectedEnvironmentName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates an connectedEnvironment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironments_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectedEnvironmentName"> Name of the connectedEnvironment. </param>
        /// <param name="data"> Configuration details of the connectedEnvironment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectedEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedEnvironmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerAppConnectedEnvironmentResource> CreateOrUpdate(WaitUntil waitUntil, string connectedEnvironmentName, ContainerAppConnectedEnvironmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectedEnvironmentName, nameof(connectedEnvironmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerAppConnectedEnvironmentConnectedEnvironmentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerAppConnectedEnvironmentConnectedEnvironmentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, connectedEnvironmentName, data, cancellationToken);
                var operation = new AppContainersArmOperation<ContainerAppConnectedEnvironmentResource>(new ContainerAppConnectedEnvironmentOperationSource(Client), _containerAppConnectedEnvironmentConnectedEnvironmentsClientDiagnostics, Pipeline, _containerAppConnectedEnvironmentConnectedEnvironmentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, connectedEnvironmentName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get the properties of an connectedEnvironment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectedEnvironmentName"> Name of the connectedEnvironment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectedEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedEnvironmentName"/> is null. </exception>
        public virtual async Task<Response<ContainerAppConnectedEnvironmentResource>> GetAsync(string connectedEnvironmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectedEnvironmentName, nameof(connectedEnvironmentName));

            using var scope = _containerAppConnectedEnvironmentConnectedEnvironmentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerAppConnectedEnvironmentConnectedEnvironmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, connectedEnvironmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppConnectedEnvironmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of an connectedEnvironment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectedEnvironmentName"> Name of the connectedEnvironment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectedEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedEnvironmentName"/> is null. </exception>
        public virtual Response<ContainerAppConnectedEnvironmentResource> Get(string connectedEnvironmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectedEnvironmentName, nameof(connectedEnvironmentName));

            using var scope = _containerAppConnectedEnvironmentConnectedEnvironmentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentCollection.Get");
            scope.Start();
            try
            {
                var response = _containerAppConnectedEnvironmentConnectedEnvironmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, connectedEnvironmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppConnectedEnvironmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all connectedEnvironments in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironments_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppConnectedEnvironmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppConnectedEnvironmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppConnectedEnvironmentConnectedEnvironmentsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppConnectedEnvironmentConnectedEnvironmentsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerAppConnectedEnvironmentResource(Client, ContainerAppConnectedEnvironmentData.DeserializeContainerAppConnectedEnvironmentData(e)), _containerAppConnectedEnvironmentConnectedEnvironmentsClientDiagnostics, Pipeline, "ContainerAppConnectedEnvironmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all connectedEnvironments in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironments_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppConnectedEnvironmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppConnectedEnvironmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppConnectedEnvironmentConnectedEnvironmentsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppConnectedEnvironmentConnectedEnvironmentsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerAppConnectedEnvironmentResource(Client, ContainerAppConnectedEnvironmentData.DeserializeContainerAppConnectedEnvironmentData(e)), _containerAppConnectedEnvironmentConnectedEnvironmentsClientDiagnostics, Pipeline, "ContainerAppConnectedEnvironmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectedEnvironmentName"> Name of the connectedEnvironment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectedEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedEnvironmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string connectedEnvironmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectedEnvironmentName, nameof(connectedEnvironmentName));

            using var scope = _containerAppConnectedEnvironmentConnectedEnvironmentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerAppConnectedEnvironmentConnectedEnvironmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, connectedEnvironmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectedEnvironmentName"> Name of the connectedEnvironment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectedEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedEnvironmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectedEnvironmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectedEnvironmentName, nameof(connectedEnvironmentName));

            using var scope = _containerAppConnectedEnvironmentConnectedEnvironmentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerAppConnectedEnvironmentConnectedEnvironmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, connectedEnvironmentName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectedEnvironmentName"> Name of the connectedEnvironment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectedEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedEnvironmentName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerAppConnectedEnvironmentResource>> GetIfExistsAsync(string connectedEnvironmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectedEnvironmentName, nameof(connectedEnvironmentName));

            using var scope = _containerAppConnectedEnvironmentConnectedEnvironmentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerAppConnectedEnvironmentConnectedEnvironmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, connectedEnvironmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppConnectedEnvironmentResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppConnectedEnvironmentResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectedEnvironmentName"> Name of the connectedEnvironment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectedEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedEnvironmentName"/> is null. </exception>
        public virtual NullableResponse<ContainerAppConnectedEnvironmentResource> GetIfExists(string connectedEnvironmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectedEnvironmentName, nameof(connectedEnvironmentName));

            using var scope = _containerAppConnectedEnvironmentConnectedEnvironmentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerAppConnectedEnvironmentConnectedEnvironmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, connectedEnvironmentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppConnectedEnvironmentResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppConnectedEnvironmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerAppConnectedEnvironmentResource> IEnumerable<ContainerAppConnectedEnvironmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerAppConnectedEnvironmentResource> IAsyncEnumerable<ContainerAppConnectedEnvironmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
