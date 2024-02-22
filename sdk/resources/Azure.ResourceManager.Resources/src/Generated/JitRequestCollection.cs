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

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing a collection of <see cref="JitRequestResource"/> and their operations.
    /// Each <see cref="JitRequestResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="JitRequestCollection"/> instance call the GetJitRequests method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class JitRequestCollection : ArmCollection, IEnumerable<JitRequestResource>, IAsyncEnumerable<JitRequestResource>
    {
        private readonly ClientDiagnostics _jitRequestClientDiagnostics;
        private readonly JitRequestsRestOperations _jitRequestRestClient;

        /// <summary> Initializes a new instance of the <see cref="JitRequestCollection"/> class for mocking. </summary>
        protected JitRequestCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="JitRequestCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal JitRequestCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _jitRequestClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", JitRequestResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(JitRequestResource.ResourceType, out string jitRequestApiVersion);
            _jitRequestRestClient = new JitRequestsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, jitRequestApiVersion);
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
        /// Creates or updates the JIT request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests/{jitRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>jitRequests_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="JitRequestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="data"> Parameters supplied to the update JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jitRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<JitRequestResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string jitRequestName, JitRequestData data, CancellationToken cancellationToken = default)
        {
            if (jitRequestName == null)
            {
                throw new ArgumentNullException(nameof(jitRequestName));
            }
            if (jitRequestName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(jitRequestName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _jitRequestClientDiagnostics.CreateScope("JitRequestCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _jitRequestRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, jitRequestName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation<JitRequestResource>(new JitRequestOperationSource(Client), _jitRequestClientDiagnostics, Pipeline, _jitRequestRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, jitRequestName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates the JIT request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests/{jitRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>jitRequests_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="JitRequestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="data"> Parameters supplied to the update JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jitRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<JitRequestResource> CreateOrUpdate(WaitUntil waitUntil, string jitRequestName, JitRequestData data, CancellationToken cancellationToken = default)
        {
            if (jitRequestName == null)
            {
                throw new ArgumentNullException(nameof(jitRequestName));
            }
            if (jitRequestName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(jitRequestName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _jitRequestClientDiagnostics.CreateScope("JitRequestCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _jitRequestRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, jitRequestName, data, cancellationToken);
                var operation = new ResourcesArmOperation<JitRequestResource>(new JitRequestOperationSource(Client), _jitRequestClientDiagnostics, Pipeline, _jitRequestRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, jitRequestName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the JIT request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests/{jitRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JitRequests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="JitRequestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jitRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> is null. </exception>
        public virtual async Task<Response<JitRequestResource>> GetAsync(string jitRequestName, CancellationToken cancellationToken = default)
        {
            if (jitRequestName == null)
            {
                throw new ArgumentNullException(nameof(jitRequestName));
            }
            if (jitRequestName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(jitRequestName));
            }

            using var scope = _jitRequestClientDiagnostics.CreateScope("JitRequestCollection.Get");
            scope.Start();
            try
            {
                var response = await _jitRequestRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, jitRequestName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JitRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the JIT request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests/{jitRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JitRequests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="JitRequestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jitRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> is null. </exception>
        public virtual Response<JitRequestResource> Get(string jitRequestName, CancellationToken cancellationToken = default)
        {
            if (jitRequestName == null)
            {
                throw new ArgumentNullException(nameof(jitRequestName));
            }
            if (jitRequestName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(jitRequestName));
            }

            using var scope = _jitRequestClientDiagnostics.CreateScope("JitRequestCollection.Get");
            scope.Start();
            try
            {
                var response = _jitRequestRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, jitRequestName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JitRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves all JIT requests within the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>jitRequests_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="JitRequestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="JitRequestResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<JitRequestResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _jitRequestRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new JitRequestResource(Client, JitRequestData.DeserializeJitRequestData(e)), _jitRequestClientDiagnostics, Pipeline, "JitRequestCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Retrieves all JIT requests within the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>jitRequests_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="JitRequestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="JitRequestResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<JitRequestResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _jitRequestRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new JitRequestResource(Client, JitRequestData.DeserializeJitRequestData(e)), _jitRequestClientDiagnostics, Pipeline, "JitRequestCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests/{jitRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JitRequests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="JitRequestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jitRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string jitRequestName, CancellationToken cancellationToken = default)
        {
            if (jitRequestName == null)
            {
                throw new ArgumentNullException(nameof(jitRequestName));
            }
            if (jitRequestName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(jitRequestName));
            }

            using var scope = _jitRequestClientDiagnostics.CreateScope("JitRequestCollection.Exists");
            scope.Start();
            try
            {
                var response = await _jitRequestRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, jitRequestName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests/{jitRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JitRequests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="JitRequestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jitRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> is null. </exception>
        public virtual Response<bool> Exists(string jitRequestName, CancellationToken cancellationToken = default)
        {
            if (jitRequestName == null)
            {
                throw new ArgumentNullException(nameof(jitRequestName));
            }
            if (jitRequestName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(jitRequestName));
            }

            using var scope = _jitRequestClientDiagnostics.CreateScope("JitRequestCollection.Exists");
            scope.Start();
            try
            {
                var response = _jitRequestRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, jitRequestName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests/{jitRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JitRequests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="JitRequestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jitRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> is null. </exception>
        public virtual async Task<NullableResponse<JitRequestResource>> GetIfExistsAsync(string jitRequestName, CancellationToken cancellationToken = default)
        {
            if (jitRequestName == null)
            {
                throw new ArgumentNullException(nameof(jitRequestName));
            }
            if (jitRequestName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(jitRequestName));
            }

            using var scope = _jitRequestClientDiagnostics.CreateScope("JitRequestCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _jitRequestRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, jitRequestName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<JitRequestResource>(response.GetRawResponse());
                return Response.FromValue(new JitRequestResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests/{jitRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JitRequests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="JitRequestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jitRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> is null. </exception>
        public virtual NullableResponse<JitRequestResource> GetIfExists(string jitRequestName, CancellationToken cancellationToken = default)
        {
            if (jitRequestName == null)
            {
                throw new ArgumentNullException(nameof(jitRequestName));
            }
            if (jitRequestName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(jitRequestName));
            }

            using var scope = _jitRequestClientDiagnostics.CreateScope("JitRequestCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _jitRequestRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, jitRequestName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<JitRequestResource>(response.GetRawResponse());
                return Response.FromValue(new JitRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<JitRequestResource> IEnumerable<JitRequestResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<JitRequestResource> IAsyncEnumerable<JitRequestResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
