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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AgFoodPlatform
{
    /// <summary>
    /// A class representing a collection of <see cref="FarmBeatResource" /> and their operations.
    /// Each <see cref="FarmBeatResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="FarmBeatCollection" /> instance call the GetFarmBeats method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class FarmBeatCollection : ArmCollection, IEnumerable<FarmBeatResource>, IAsyncEnumerable<FarmBeatResource>
    {
        private readonly ClientDiagnostics _farmBeatFarmBeatsModelsClientDiagnostics;
        private readonly FarmBeatsModelsRestOperations _farmBeatFarmBeatsModelsRestClient;

        /// <summary> Initializes a new instance of the <see cref="FarmBeatCollection"/> class for mocking. </summary>
        protected FarmBeatCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FarmBeatCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FarmBeatCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _farmBeatFarmBeatsModelsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AgFoodPlatform", FarmBeatResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FarmBeatResource.ResourceType, out string farmBeatFarmBeatsModelsApiVersion);
            _farmBeatFarmBeatsModelsRestClient = new FarmBeatsModelsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, farmBeatFarmBeatsModelsApiVersion);
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
        /// Create or update FarmBeats resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FarmBeatsModels_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="data"> FarmBeats resource create or update request object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="farmBeatsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="farmBeatsResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FarmBeatResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string farmBeatsResourceName, FarmBeatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(farmBeatsResourceName, nameof(farmBeatsResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _farmBeatFarmBeatsModelsClientDiagnostics.CreateScope("FarmBeatCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _farmBeatFarmBeatsModelsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, farmBeatsResourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AgFoodPlatformArmOperation<FarmBeatResource>(Response.FromValue(new FarmBeatResource(Client, response), response.GetRawResponse()));
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
        /// Create or update FarmBeats resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FarmBeatsModels_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="data"> FarmBeats resource create or update request object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="farmBeatsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="farmBeatsResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FarmBeatResource> CreateOrUpdate(WaitUntil waitUntil, string farmBeatsResourceName, FarmBeatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(farmBeatsResourceName, nameof(farmBeatsResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _farmBeatFarmBeatsModelsClientDiagnostics.CreateScope("FarmBeatCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _farmBeatFarmBeatsModelsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, farmBeatsResourceName, data, cancellationToken);
                var operation = new AgFoodPlatformArmOperation<FarmBeatResource>(Response.FromValue(new FarmBeatResource(Client, response), response.GetRawResponse()));
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
        /// Get FarmBeats resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FarmBeatsModels_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="farmBeatsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="farmBeatsResourceName"/> is null. </exception>
        public virtual async Task<Response<FarmBeatResource>> GetAsync(string farmBeatsResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(farmBeatsResourceName, nameof(farmBeatsResourceName));

            using var scope = _farmBeatFarmBeatsModelsClientDiagnostics.CreateScope("FarmBeatCollection.Get");
            scope.Start();
            try
            {
                var response = await _farmBeatFarmBeatsModelsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, farmBeatsResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FarmBeatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get FarmBeats resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FarmBeatsModels_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="farmBeatsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="farmBeatsResourceName"/> is null. </exception>
        public virtual Response<FarmBeatResource> Get(string farmBeatsResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(farmBeatsResourceName, nameof(farmBeatsResourceName));

            using var scope = _farmBeatFarmBeatsModelsClientDiagnostics.CreateScope("FarmBeatCollection.Get");
            scope.Start();
            try
            {
                var response = _farmBeatFarmBeatsModelsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, farmBeatsResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FarmBeatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the FarmBeats instances for a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FarmBeatsModels_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Continuation token for getting next set of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FarmBeatResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FarmBeatResource> GetAllAsync(int? maxPageSize = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _farmBeatFarmBeatsModelsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, pageSizeHint, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _farmBeatFarmBeatsModelsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, pageSizeHint, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new FarmBeatResource(Client, FarmBeatData.DeserializeFarmBeatData(e)), _farmBeatFarmBeatsModelsClientDiagnostics, Pipeline, "FarmBeatCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the FarmBeats instances for a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FarmBeatsModels_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Continuation token for getting next set of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FarmBeatResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FarmBeatResource> GetAll(int? maxPageSize = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _farmBeatFarmBeatsModelsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, pageSizeHint, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _farmBeatFarmBeatsModelsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, pageSizeHint, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new FarmBeatResource(Client, FarmBeatData.DeserializeFarmBeatData(e)), _farmBeatFarmBeatsModelsClientDiagnostics, Pipeline, "FarmBeatCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FarmBeatsModels_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="farmBeatsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="farmBeatsResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string farmBeatsResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(farmBeatsResourceName, nameof(farmBeatsResourceName));

            using var scope = _farmBeatFarmBeatsModelsClientDiagnostics.CreateScope("FarmBeatCollection.Exists");
            scope.Start();
            try
            {
                var response = await _farmBeatFarmBeatsModelsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, farmBeatsResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FarmBeatsModels_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="farmBeatsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="farmBeatsResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string farmBeatsResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(farmBeatsResourceName, nameof(farmBeatsResourceName));

            using var scope = _farmBeatFarmBeatsModelsClientDiagnostics.CreateScope("FarmBeatCollection.Exists");
            scope.Start();
            try
            {
                var response = _farmBeatFarmBeatsModelsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, farmBeatsResourceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FarmBeatsModels_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="farmBeatsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="farmBeatsResourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<FarmBeatResource>> GetIfExistsAsync(string farmBeatsResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(farmBeatsResourceName, nameof(farmBeatsResourceName));

            using var scope = _farmBeatFarmBeatsModelsClientDiagnostics.CreateScope("FarmBeatCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _farmBeatFarmBeatsModelsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, farmBeatsResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<FarmBeatResource>(response.GetRawResponse());
                return Response.FromValue(new FarmBeatResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FarmBeatsModels_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="farmBeatsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="farmBeatsResourceName"/> is null. </exception>
        public virtual NullableResponse<FarmBeatResource> GetIfExists(string farmBeatsResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(farmBeatsResourceName, nameof(farmBeatsResourceName));

            using var scope = _farmBeatFarmBeatsModelsClientDiagnostics.CreateScope("FarmBeatCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _farmBeatFarmBeatsModelsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, farmBeatsResourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<FarmBeatResource>(response.GetRawResponse());
                return Response.FromValue(new FarmBeatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FarmBeatResource> IEnumerable<FarmBeatResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FarmBeatResource> IAsyncEnumerable<FarmBeatResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
