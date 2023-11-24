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
    /// A class representing a collection of <see cref="AppPlatformBuildServiceAgentPoolResource"/> and their operations.
    /// Each <see cref="AppPlatformBuildServiceAgentPoolResource"/> in the collection will belong to the same instance of <see cref="AppPlatformBuildServiceResource"/>.
    /// To get an <see cref="AppPlatformBuildServiceAgentPoolCollection"/> instance call the GetAppPlatformBuildServiceAgentPools method from an instance of <see cref="AppPlatformBuildServiceResource"/>.
    /// </summary>
    public partial class AppPlatformBuildServiceAgentPoolCollection : ArmCollection, IEnumerable<AppPlatformBuildServiceAgentPoolResource>, IAsyncEnumerable<AppPlatformBuildServiceAgentPoolResource>
    {
        private readonly ClientDiagnostics _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics;
        private readonly BuildServiceAgentPoolRestOperations _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppPlatformBuildServiceAgentPoolCollection"/> class for mocking. </summary>
        protected AppPlatformBuildServiceAgentPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformBuildServiceAgentPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppPlatformBuildServiceAgentPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", AppPlatformBuildServiceAgentPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppPlatformBuildServiceAgentPoolResource.ResourceType, out string appPlatformBuildServiceAgentPoolBuildServiceAgentPoolApiVersion);
            _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient = new BuildServiceAgentPoolRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformBuildServiceAgentPoolBuildServiceAgentPoolApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppPlatformBuildServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppPlatformBuildServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update build service agent pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceAgentPool_UpdatePut</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="agentPoolName"> The name of the build service agent pool resource. </param>
        /// <param name="data"> Parameters for the update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppPlatformBuildServiceAgentPoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string agentPoolName, AppPlatformBuildServiceAgentPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics.CreateScope("AppPlatformBuildServiceAgentPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient.UpdatePutAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, agentPoolName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<AppPlatformBuildServiceAgentPoolResource>(new AppPlatformBuildServiceAgentPoolOperationSource(Client), _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics, Pipeline, _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient.CreateUpdatePutRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, agentPoolName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update build service agent pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceAgentPool_UpdatePut</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="agentPoolName"> The name of the build service agent pool resource. </param>
        /// <param name="data"> Parameters for the update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppPlatformBuildServiceAgentPoolResource> CreateOrUpdate(WaitUntil waitUntil, string agentPoolName, AppPlatformBuildServiceAgentPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics.CreateScope("AppPlatformBuildServiceAgentPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient.UpdatePut(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, agentPoolName, data, cancellationToken);
                var operation = new AppPlatformArmOperation<AppPlatformBuildServiceAgentPoolResource>(new AppPlatformBuildServiceAgentPoolOperationSource(Client), _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics, Pipeline, _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient.CreateUpdatePutRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, agentPoolName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get build service agent pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceAgentPool_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentPoolName"> The name of the build service agent pool resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual async Task<Response<AppPlatformBuildServiceAgentPoolResource>> GetAsync(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics.CreateScope("AppPlatformBuildServiceAgentPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, agentPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformBuildServiceAgentPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get build service agent pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceAgentPool_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentPoolName"> The name of the build service agent pool resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual Response<AppPlatformBuildServiceAgentPoolResource> Get(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics.CreateScope("AppPlatformBuildServiceAgentPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, agentPoolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformBuildServiceAgentPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List build service agent pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceAgentPool_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppPlatformBuildServiceAgentPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppPlatformBuildServiceAgentPoolResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new AppPlatformBuildServiceAgentPoolResource(Client, AppPlatformBuildServiceAgentPoolData.DeserializeAppPlatformBuildServiceAgentPoolData(e)), _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics, Pipeline, "AppPlatformBuildServiceAgentPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List build service agent pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceAgentPool_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppPlatformBuildServiceAgentPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppPlatformBuildServiceAgentPoolResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new AppPlatformBuildServiceAgentPoolResource(Client, AppPlatformBuildServiceAgentPoolData.DeserializeAppPlatformBuildServiceAgentPoolData(e)), _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics, Pipeline, "AppPlatformBuildServiceAgentPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceAgentPool_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentPoolName"> The name of the build service agent pool resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics.CreateScope("AppPlatformBuildServiceAgentPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, agentPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceAgentPool_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentPoolName"> The name of the build service agent pool resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics.CreateScope("AppPlatformBuildServiceAgentPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, agentPoolName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceAgentPool_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentPoolName"> The name of the build service agent pool resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual async Task<NullableResponse<AppPlatformBuildServiceAgentPoolResource>> GetIfExistsAsync(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics.CreateScope("AppPlatformBuildServiceAgentPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, agentPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AppPlatformBuildServiceAgentPoolResource>(response.GetRawResponse());
                return Response.FromValue(new AppPlatformBuildServiceAgentPoolResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceAgentPool_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentPoolName"> The name of the build service agent pool resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual NullableResponse<AppPlatformBuildServiceAgentPoolResource> GetIfExists(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics.CreateScope("AppPlatformBuildServiceAgentPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, agentPoolName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AppPlatformBuildServiceAgentPoolResource>(response.GetRawResponse());
                return Response.FromValue(new AppPlatformBuildServiceAgentPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppPlatformBuildServiceAgentPoolResource> IEnumerable<AppPlatformBuildServiceAgentPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppPlatformBuildServiceAgentPoolResource> IAsyncEnumerable<AppPlatformBuildServiceAgentPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
