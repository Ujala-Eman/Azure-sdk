// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.FrontDoor
{
    /// <summary>
    /// A class representing a collection of <see cref="ExperimentResource" /> and their operations.
    /// Each <see cref="ExperimentResource" /> in the collection will belong to the same instance of <see cref="ProfileResource" />.
    /// To get an <see cref="ExperimentCollection" /> instance call the GetExperiments method from an instance of <see cref="ProfileResource" />.
    /// </summary>
    public partial class ExperimentCollection : ArmCollection, IEnumerable<ExperimentResource>, IAsyncEnumerable<ExperimentResource>
    {
        private readonly ClientDiagnostics _experimentClientDiagnostics;
        private readonly ExperimentsRestOperations _experimentRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExperimentCollection"/> class for mocking. </summary>
        protected ExperimentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExperimentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExperimentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _experimentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.FrontDoor", ExperimentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExperimentResource.ResourceType, out string experimentApiVersion);
            _experimentRestClient = new ExperimentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, experimentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ProfileResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ProfileResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an Experiment
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}/Experiments/{experimentName}
        /// Operation Id: Experiments_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="experimentName"> The Experiment identifier associated with the Experiment. </param>
        /// <param name="data"> The Experiment resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ExperimentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string experimentName, ExperimentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(experimentName, nameof(experimentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _experimentClientDiagnostics.CreateScope("ExperimentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _experimentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, experimentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new FrontDoorArmOperation<ExperimentResource>(new ExperimentOperationSource(Client), _experimentClientDiagnostics, Pipeline, _experimentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, experimentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an Experiment
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}/Experiments/{experimentName}
        /// Operation Id: Experiments_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="experimentName"> The Experiment identifier associated with the Experiment. </param>
        /// <param name="data"> The Experiment resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ExperimentResource> CreateOrUpdate(WaitUntil waitUntil, string experimentName, ExperimentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(experimentName, nameof(experimentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _experimentClientDiagnostics.CreateScope("ExperimentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _experimentRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, experimentName, data, cancellationToken);
                var operation = new FrontDoorArmOperation<ExperimentResource>(new ExperimentOperationSource(Client), _experimentClientDiagnostics, Pipeline, _experimentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, experimentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets an Experiment by ExperimentName
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}/Experiments/{experimentName}
        /// Operation Id: Experiments_Get
        /// </summary>
        /// <param name="experimentName"> The Experiment identifier associated with the Experiment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> is null. </exception>
        public virtual async Task<Response<ExperimentResource>> GetAsync(string experimentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(experimentName, nameof(experimentName));

            using var scope = _experimentClientDiagnostics.CreateScope("ExperimentCollection.Get");
            scope.Start();
            try
            {
                var response = await _experimentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, experimentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExperimentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an Experiment by ExperimentName
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}/Experiments/{experimentName}
        /// Operation Id: Experiments_Get
        /// </summary>
        /// <param name="experimentName"> The Experiment identifier associated with the Experiment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> is null. </exception>
        public virtual Response<ExperimentResource> Get(string experimentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(experimentName, nameof(experimentName));

            using var scope = _experimentClientDiagnostics.CreateScope("ExperimentCollection.Get");
            scope.Start();
            try
            {
                var response = _experimentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, experimentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExperimentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of Experiments
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}/Experiments
        /// Operation Id: Experiments_ListByProfile
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExperimentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExperimentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExperimentResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _experimentClientDiagnostics.CreateScope("ExperimentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _experimentRestClient.ListByProfileAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExperimentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExperimentResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _experimentClientDiagnostics.CreateScope("ExperimentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _experimentRestClient.ListByProfileNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExperimentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets a list of Experiments
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}/Experiments
        /// Operation Id: Experiments_ListByProfile
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExperimentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExperimentResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ExperimentResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _experimentClientDiagnostics.CreateScope("ExperimentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _experimentRestClient.ListByProfile(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExperimentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExperimentResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _experimentClientDiagnostics.CreateScope("ExperimentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _experimentRestClient.ListByProfileNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExperimentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}/Experiments/{experimentName}
        /// Operation Id: Experiments_Get
        /// </summary>
        /// <param name="experimentName"> The Experiment identifier associated with the Experiment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string experimentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(experimentName, nameof(experimentName));

            using var scope = _experimentClientDiagnostics.CreateScope("ExperimentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _experimentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, experimentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}/Experiments/{experimentName}
        /// Operation Id: Experiments_Get
        /// </summary>
        /// <param name="experimentName"> The Experiment identifier associated with the Experiment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> is null. </exception>
        public virtual Response<bool> Exists(string experimentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(experimentName, nameof(experimentName));

            using var scope = _experimentClientDiagnostics.CreateScope("ExperimentCollection.Exists");
            scope.Start();
            try
            {
                var response = _experimentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, experimentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExperimentResource> IEnumerable<ExperimentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExperimentResource> IAsyncEnumerable<ExperimentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
