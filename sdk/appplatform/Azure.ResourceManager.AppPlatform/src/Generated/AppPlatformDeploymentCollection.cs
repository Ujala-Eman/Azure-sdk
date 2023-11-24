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

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing a collection of <see cref="AppPlatformDeploymentResource"/> and their operations.
    /// Each <see cref="AppPlatformDeploymentResource"/> in the collection will belong to the same instance of <see cref="AppPlatformAppResource"/>.
    /// To get an <see cref="AppPlatformDeploymentCollection"/> instance call the GetAppPlatformDeployments method from an instance of <see cref="AppPlatformAppResource"/>.
    /// </summary>
    public partial class AppPlatformDeploymentCollection : ArmCollection, IEnumerable<AppPlatformDeploymentResource>, IAsyncEnumerable<AppPlatformDeploymentResource>
    {
        private readonly ClientDiagnostics _appPlatformDeploymentDeploymentsClientDiagnostics;
        private readonly DeploymentsRestOperations _appPlatformDeploymentDeploymentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppPlatformDeploymentCollection"/> class for mocking. </summary>
        protected AppPlatformDeploymentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformDeploymentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppPlatformDeploymentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformDeploymentDeploymentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", AppPlatformDeploymentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppPlatformDeploymentResource.ResourceType, out string appPlatformDeploymentDeploymentsApiVersion);
            _appPlatformDeploymentDeploymentsRestClient = new DeploymentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformDeploymentDeploymentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppPlatformAppResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppPlatformAppResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new Deployment or update an exiting Deployment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/deployments/{deploymentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Deployments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deploymentName"> The name of the Deployment resource. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppPlatformDeploymentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string deploymentName, AppPlatformDeploymentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformDeploymentDeploymentsClientDiagnostics.CreateScope("AppPlatformDeploymentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appPlatformDeploymentDeploymentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<AppPlatformDeploymentResource>(new AppPlatformDeploymentOperationSource(Client), _appPlatformDeploymentDeploymentsClientDiagnostics, Pipeline, _appPlatformDeploymentDeploymentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create a new Deployment or update an exiting Deployment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/deployments/{deploymentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Deployments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deploymentName"> The name of the Deployment resource. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppPlatformDeploymentResource> CreateOrUpdate(WaitUntil waitUntil, string deploymentName, AppPlatformDeploymentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformDeploymentDeploymentsClientDiagnostics.CreateScope("AppPlatformDeploymentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appPlatformDeploymentDeploymentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, data, cancellationToken);
                var operation = new AppPlatformArmOperation<AppPlatformDeploymentResource>(new AppPlatformDeploymentOperationSource(Client), _appPlatformDeploymentDeploymentsClientDiagnostics, Pipeline, _appPlatformDeploymentDeploymentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a Deployment and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/deployments/{deploymentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Deployments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentName"> The name of the Deployment resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual async Task<Response<AppPlatformDeploymentResource>> GetAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _appPlatformDeploymentDeploymentsClientDiagnostics.CreateScope("AppPlatformDeploymentCollection.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformDeploymentDeploymentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformDeploymentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Deployment and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/deployments/{deploymentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Deployments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentName"> The name of the Deployment resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual Response<AppPlatformDeploymentResource> Get(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _appPlatformDeploymentDeploymentsClientDiagnostics.CreateScope("AppPlatformDeploymentCollection.Get");
            scope.Start();
            try
            {
                var response = _appPlatformDeploymentDeploymentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformDeploymentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Handles requests to list all resources in an App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/deployments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Deployments_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version of the deployments to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppPlatformDeploymentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppPlatformDeploymentResource> GetAllAsync(IEnumerable<string> version = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformDeploymentDeploymentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformDeploymentDeploymentsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new AppPlatformDeploymentResource(Client, AppPlatformDeploymentData.DeserializeAppPlatformDeploymentData(e)), _appPlatformDeploymentDeploymentsClientDiagnostics, Pipeline, "AppPlatformDeploymentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in an App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/deployments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Deployments_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version of the deployments to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppPlatformDeploymentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppPlatformDeploymentResource> GetAll(IEnumerable<string> version = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformDeploymentDeploymentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformDeploymentDeploymentsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new AppPlatformDeploymentResource(Client, AppPlatformDeploymentData.DeserializeAppPlatformDeploymentData(e)), _appPlatformDeploymentDeploymentsClientDiagnostics, Pipeline, "AppPlatformDeploymentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/deployments/{deploymentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Deployments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentName"> The name of the Deployment resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _appPlatformDeploymentDeploymentsClientDiagnostics.CreateScope("AppPlatformDeploymentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appPlatformDeploymentDeploymentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/deployments/{deploymentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Deployments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentName"> The name of the Deployment resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual Response<bool> Exists(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _appPlatformDeploymentDeploymentsClientDiagnostics.CreateScope("AppPlatformDeploymentCollection.Exists");
            scope.Start();
            try
            {
                var response = _appPlatformDeploymentDeploymentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/deployments/{deploymentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Deployments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentName"> The name of the Deployment resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual async Task<NullableResponse<AppPlatformDeploymentResource>> GetIfExistsAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _appPlatformDeploymentDeploymentsClientDiagnostics.CreateScope("AppPlatformDeploymentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _appPlatformDeploymentDeploymentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AppPlatformDeploymentResource>(response.GetRawResponse());
                return Response.FromValue(new AppPlatformDeploymentResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/deployments/{deploymentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Deployments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentName"> The name of the Deployment resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual NullableResponse<AppPlatformDeploymentResource> GetIfExists(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _appPlatformDeploymentDeploymentsClientDiagnostics.CreateScope("AppPlatformDeploymentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appPlatformDeploymentDeploymentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AppPlatformDeploymentResource>(response.GetRawResponse());
                return Response.FromValue(new AppPlatformDeploymentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppPlatformDeploymentResource> IEnumerable<AppPlatformDeploymentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppPlatformDeploymentResource> IAsyncEnumerable<AppPlatformDeploymentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
