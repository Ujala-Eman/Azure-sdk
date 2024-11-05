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

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing a collection of <see cref="AvsPrivateCloudAddonResource"/> and their operations.
    /// Each <see cref="AvsPrivateCloudAddonResource"/> in the collection will belong to the same instance of <see cref="AvsPrivateCloudResource"/>.
    /// To get an <see cref="AvsPrivateCloudAddonCollection"/> instance call the GetAvsPrivateCloudAddons method from an instance of <see cref="AvsPrivateCloudResource"/>.
    /// </summary>
    public partial class AvsPrivateCloudAddonCollection : ArmCollection, IEnumerable<AvsPrivateCloudAddonResource>, IAsyncEnumerable<AvsPrivateCloudAddonResource>
    {
        private readonly ClientDiagnostics _avsPrivateCloudAddonAddonsClientDiagnostics;
        private readonly AddonsRestOperations _avsPrivateCloudAddonAddonsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AvsPrivateCloudAddonCollection"/> class for mocking. </summary>
        protected AvsPrivateCloudAddonCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AvsPrivateCloudAddonCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AvsPrivateCloudAddonCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _avsPrivateCloudAddonAddonsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", AvsPrivateCloudAddonResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AvsPrivateCloudAddonResource.ResourceType, out string avsPrivateCloudAddonAddonsApiVersion);
            _avsPrivateCloudAddonAddonsRestClient = new AddonsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, avsPrivateCloudAddonAddonsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AvsPrivateCloudResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AvsPrivateCloudResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a Addon
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/addons/{addonName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Addons_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudAddonResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="addonName"> Name of the addon. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addonName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addonName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AvsPrivateCloudAddonResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string addonName, AvsPrivateCloudAddonData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(addonName, nameof(addonName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _avsPrivateCloudAddonAddonsClientDiagnostics.CreateScope("AvsPrivateCloudAddonCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _avsPrivateCloudAddonAddonsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, addonName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation<AvsPrivateCloudAddonResource>(new AvsPrivateCloudAddonOperationSource(Client), _avsPrivateCloudAddonAddonsClientDiagnostics, Pipeline, _avsPrivateCloudAddonAddonsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, addonName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a Addon
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/addons/{addonName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Addons_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudAddonResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="addonName"> Name of the addon. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addonName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addonName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AvsPrivateCloudAddonResource> CreateOrUpdate(WaitUntil waitUntil, string addonName, AvsPrivateCloudAddonData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(addonName, nameof(addonName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _avsPrivateCloudAddonAddonsClientDiagnostics.CreateScope("AvsPrivateCloudAddonCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _avsPrivateCloudAddonAddonsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, addonName, data, cancellationToken);
                var operation = new AvsArmOperation<AvsPrivateCloudAddonResource>(new AvsPrivateCloudAddonOperationSource(Client), _avsPrivateCloudAddonAddonsClientDiagnostics, Pipeline, _avsPrivateCloudAddonAddonsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, addonName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a Addon
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/addons/{addonName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Addons_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudAddonResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="addonName"> Name of the addon. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addonName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addonName"/> is null. </exception>
        public virtual async Task<Response<AvsPrivateCloudAddonResource>> GetAsync(string addonName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(addonName, nameof(addonName));

            using var scope = _avsPrivateCloudAddonAddonsClientDiagnostics.CreateScope("AvsPrivateCloudAddonCollection.Get");
            scope.Start();
            try
            {
                var response = await _avsPrivateCloudAddonAddonsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, addonName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvsPrivateCloudAddonResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Addon
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/addons/{addonName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Addons_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudAddonResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="addonName"> Name of the addon. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addonName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addonName"/> is null. </exception>
        public virtual Response<AvsPrivateCloudAddonResource> Get(string addonName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(addonName, nameof(addonName));

            using var scope = _avsPrivateCloudAddonAddonsClientDiagnostics.CreateScope("AvsPrivateCloudAddonCollection.Get");
            scope.Start();
            try
            {
                var response = _avsPrivateCloudAddonAddonsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, addonName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvsPrivateCloudAddonResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Addon resources by PrivateCloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/addons</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Addons_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudAddonResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvsPrivateCloudAddonResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvsPrivateCloudAddonResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _avsPrivateCloudAddonAddonsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _avsPrivateCloudAddonAddonsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AvsPrivateCloudAddonResource(Client, AvsPrivateCloudAddonData.DeserializeAvsPrivateCloudAddonData(e)), _avsPrivateCloudAddonAddonsClientDiagnostics, Pipeline, "AvsPrivateCloudAddonCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Addon resources by PrivateCloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/addons</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Addons_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudAddonResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvsPrivateCloudAddonResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvsPrivateCloudAddonResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _avsPrivateCloudAddonAddonsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _avsPrivateCloudAddonAddonsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AvsPrivateCloudAddonResource(Client, AvsPrivateCloudAddonData.DeserializeAvsPrivateCloudAddonData(e)), _avsPrivateCloudAddonAddonsClientDiagnostics, Pipeline, "AvsPrivateCloudAddonCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/addons/{addonName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Addons_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudAddonResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="addonName"> Name of the addon. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addonName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addonName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string addonName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(addonName, nameof(addonName));

            using var scope = _avsPrivateCloudAddonAddonsClientDiagnostics.CreateScope("AvsPrivateCloudAddonCollection.Exists");
            scope.Start();
            try
            {
                var response = await _avsPrivateCloudAddonAddonsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, addonName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/addons/{addonName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Addons_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudAddonResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="addonName"> Name of the addon. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addonName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addonName"/> is null. </exception>
        public virtual Response<bool> Exists(string addonName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(addonName, nameof(addonName));

            using var scope = _avsPrivateCloudAddonAddonsClientDiagnostics.CreateScope("AvsPrivateCloudAddonCollection.Exists");
            scope.Start();
            try
            {
                var response = _avsPrivateCloudAddonAddonsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, addonName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/addons/{addonName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Addons_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudAddonResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="addonName"> Name of the addon. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addonName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addonName"/> is null. </exception>
        public virtual async Task<NullableResponse<AvsPrivateCloudAddonResource>> GetIfExistsAsync(string addonName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(addonName, nameof(addonName));

            using var scope = _avsPrivateCloudAddonAddonsClientDiagnostics.CreateScope("AvsPrivateCloudAddonCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _avsPrivateCloudAddonAddonsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, addonName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AvsPrivateCloudAddonResource>(response.GetRawResponse());
                return Response.FromValue(new AvsPrivateCloudAddonResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/addons/{addonName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Addons_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudAddonResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="addonName"> Name of the addon. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addonName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addonName"/> is null. </exception>
        public virtual NullableResponse<AvsPrivateCloudAddonResource> GetIfExists(string addonName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(addonName, nameof(addonName));

            using var scope = _avsPrivateCloudAddonAddonsClientDiagnostics.CreateScope("AvsPrivateCloudAddonCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _avsPrivateCloudAddonAddonsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, addonName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AvsPrivateCloudAddonResource>(response.GetRawResponse());
                return Response.FromValue(new AvsPrivateCloudAddonResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AvsPrivateCloudAddonResource> IEnumerable<AvsPrivateCloudAddonResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AvsPrivateCloudAddonResource> IAsyncEnumerable<AvsPrivateCloudAddonResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
