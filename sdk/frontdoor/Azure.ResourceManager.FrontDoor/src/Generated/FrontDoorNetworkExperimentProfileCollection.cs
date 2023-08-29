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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.FrontDoor
{
    /// <summary>
    /// A class representing a collection of <see cref="FrontDoorNetworkExperimentProfileResource" /> and their operations.
    /// Each <see cref="FrontDoorNetworkExperimentProfileResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="FrontDoorNetworkExperimentProfileCollection" /> instance call the GetFrontDoorNetworkExperimentProfiles method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class FrontDoorNetworkExperimentProfileCollection : ArmCollection, IEnumerable<FrontDoorNetworkExperimentProfileResource>, IAsyncEnumerable<FrontDoorNetworkExperimentProfileResource>
    {
        private readonly ClientDiagnostics _frontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics;
        private readonly NetworkExperimentProfilesRestOperations _frontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient;

        /// <summary> Initializes a new instance of the <see cref="FrontDoorNetworkExperimentProfileCollection"/> class for mocking. </summary>
        protected FrontDoorNetworkExperimentProfileCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FrontDoorNetworkExperimentProfileCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FrontDoorNetworkExperimentProfileCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _frontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.FrontDoor", FrontDoorNetworkExperimentProfileResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FrontDoorNetworkExperimentProfileResource.ResourceType, out string frontDoorNetworkExperimentProfileNetworkExperimentProfilesApiVersion);
            _frontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient = new NetworkExperimentProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, frontDoorNetworkExperimentProfileNetworkExperimentProfilesApiVersion);
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
        /// Creates an NetworkExperiment Profile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkExperimentProfiles_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="profileName"> The Profile identifier associated with the Tenant and Partner. </param>
        /// <param name="data"> An Network Experiment Profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FrontDoorNetworkExperimentProfileResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string profileName, FrontDoorNetworkExperimentProfileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _frontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics.CreateScope("FrontDoorNetworkExperimentProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _frontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, profileName, data, cancellationToken).ConfigureAwait(false);
                var operation = new FrontDoorArmOperation<FrontDoorNetworkExperimentProfileResource>(new FrontDoorNetworkExperimentProfileOperationSource(Client), _frontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics, Pipeline, _frontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, profileName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates an NetworkExperiment Profile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkExperimentProfiles_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="profileName"> The Profile identifier associated with the Tenant and Partner. </param>
        /// <param name="data"> An Network Experiment Profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FrontDoorNetworkExperimentProfileResource> CreateOrUpdate(WaitUntil waitUntil, string profileName, FrontDoorNetworkExperimentProfileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _frontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics.CreateScope("FrontDoorNetworkExperimentProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _frontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, profileName, data, cancellationToken);
                var operation = new FrontDoorArmOperation<FrontDoorNetworkExperimentProfileResource>(new FrontDoorNetworkExperimentProfileOperationSource(Client), _frontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics, Pipeline, _frontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, profileName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets an NetworkExperiment Profile by ProfileName
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkExperimentProfiles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> The Profile identifier associated with the Tenant and Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual async Task<Response<FrontDoorNetworkExperimentProfileResource>> GetAsync(string profileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var scope = _frontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics.CreateScope("FrontDoorNetworkExperimentProfileCollection.Get");
            scope.Start();
            try
            {
                var response = await _frontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, profileName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontDoorNetworkExperimentProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an NetworkExperiment Profile by ProfileName
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkExperimentProfiles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> The Profile identifier associated with the Tenant and Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual Response<FrontDoorNetworkExperimentProfileResource> Get(string profileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var scope = _frontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics.CreateScope("FrontDoorNetworkExperimentProfileCollection.Get");
            scope.Start();
            try
            {
                var response = _frontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, profileName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontDoorNetworkExperimentProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of Network Experiment Profiles within a resource group under a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkExperimentProfiles_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontDoorNetworkExperimentProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FrontDoorNetworkExperimentProfileResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new FrontDoorNetworkExperimentProfileResource(Client, FrontDoorNetworkExperimentProfileData.DeserializeFrontDoorNetworkExperimentProfileData(e)), _frontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics, Pipeline, "FrontDoorNetworkExperimentProfileCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of Network Experiment Profiles within a resource group under a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkExperimentProfiles_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontDoorNetworkExperimentProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FrontDoorNetworkExperimentProfileResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new FrontDoorNetworkExperimentProfileResource(Client, FrontDoorNetworkExperimentProfileData.DeserializeFrontDoorNetworkExperimentProfileData(e)), _frontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics, Pipeline, "FrontDoorNetworkExperimentProfileCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkExperimentProfiles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> The Profile identifier associated with the Tenant and Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string profileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var scope = _frontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics.CreateScope("FrontDoorNetworkExperimentProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = await _frontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, profileName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkExperimentProfiles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> The Profile identifier associated with the Tenant and Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual Response<bool> Exists(string profileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var scope = _frontDoorNetworkExperimentProfileNetworkExperimentProfilesClientDiagnostics.CreateScope("FrontDoorNetworkExperimentProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = _frontDoorNetworkExperimentProfileNetworkExperimentProfilesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, profileName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FrontDoorNetworkExperimentProfileResource> IEnumerable<FrontDoorNetworkExperimentProfileResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FrontDoorNetworkExperimentProfileResource> IAsyncEnumerable<FrontDoorNetworkExperimentProfileResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
