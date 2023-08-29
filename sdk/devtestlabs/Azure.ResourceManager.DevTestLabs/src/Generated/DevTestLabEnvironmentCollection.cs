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

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A class representing a collection of <see cref="DevTestLabEnvironmentResource" /> and their operations.
    /// Each <see cref="DevTestLabEnvironmentResource" /> in the collection will belong to the same instance of <see cref="DevTestLabUserResource" />.
    /// To get a <see cref="DevTestLabEnvironmentCollection" /> instance call the GetDevTestLabEnvironments method from an instance of <see cref="DevTestLabUserResource" />.
    /// </summary>
    public partial class DevTestLabEnvironmentCollection : ArmCollection, IEnumerable<DevTestLabEnvironmentResource>, IAsyncEnumerable<DevTestLabEnvironmentResource>
    {
        private readonly ClientDiagnostics _devTestLabEnvironmentEnvironmentsClientDiagnostics;
        private readonly EnvironmentsRestOperations _devTestLabEnvironmentEnvironmentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DevTestLabEnvironmentCollection"/> class for mocking. </summary>
        protected DevTestLabEnvironmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DevTestLabEnvironmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DevTestLabEnvironmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devTestLabEnvironmentEnvironmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", DevTestLabEnvironmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DevTestLabEnvironmentResource.ResourceType, out string devTestLabEnvironmentEnvironmentsApiVersion);
            _devTestLabEnvironmentEnvironmentsRestClient = new EnvironmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devTestLabEnvironmentEnvironmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevTestLabUserResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevTestLabUserResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or replace an existing environment. This operation can take a while to complete.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/environments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Environments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the environment. </param>
        /// <param name="data"> An environment, which is essentially an ARM template deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DevTestLabEnvironmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, DevTestLabEnvironmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devTestLabEnvironmentEnvironmentsClientDiagnostics.CreateScope("DevTestLabEnvironmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _devTestLabEnvironmentEnvironmentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevTestLabsArmOperation<DevTestLabEnvironmentResource>(new DevTestLabEnvironmentOperationSource(Client), _devTestLabEnvironmentEnvironmentsClientDiagnostics, Pipeline, _devTestLabEnvironmentEnvironmentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or replace an existing environment. This operation can take a while to complete.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/environments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Environments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the environment. </param>
        /// <param name="data"> An environment, which is essentially an ARM template deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DevTestLabEnvironmentResource> CreateOrUpdate(WaitUntil waitUntil, string name, DevTestLabEnvironmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devTestLabEnvironmentEnvironmentsClientDiagnostics.CreateScope("DevTestLabEnvironmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _devTestLabEnvironmentEnvironmentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, data, cancellationToken);
                var operation = new DevTestLabsArmOperation<DevTestLabEnvironmentResource>(new DevTestLabEnvironmentOperationSource(Client), _devTestLabEnvironmentEnvironmentsClientDiagnostics, Pipeline, _devTestLabEnvironmentEnvironmentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/environments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Environments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the environment. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=deploymentProperties)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DevTestLabEnvironmentResource>> GetAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabEnvironmentEnvironmentsClientDiagnostics.CreateScope("DevTestLabEnvironmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _devTestLabEnvironmentEnvironmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabEnvironmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/environments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Environments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the environment. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=deploymentProperties)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DevTestLabEnvironmentResource> Get(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabEnvironmentEnvironmentsClientDiagnostics.CreateScope("DevTestLabEnvironmentCollection.Get");
            scope.Start();
            try
            {
                var response = _devTestLabEnvironmentEnvironmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabEnvironmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List environments in a given user profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/environments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Environments_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=deploymentProperties)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevTestLabEnvironmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevTestLabEnvironmentResource> GetAllAsync(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devTestLabEnvironmentEnvironmentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devTestLabEnvironmentEnvironmentsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, filter, top, orderby);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DevTestLabEnvironmentResource(Client, DevTestLabEnvironmentData.DeserializeDevTestLabEnvironmentData(e)), _devTestLabEnvironmentEnvironmentsClientDiagnostics, Pipeline, "DevTestLabEnvironmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List environments in a given user profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/environments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Environments_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=deploymentProperties)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevTestLabEnvironmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevTestLabEnvironmentResource> GetAll(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devTestLabEnvironmentEnvironmentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devTestLabEnvironmentEnvironmentsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, filter, top, orderby);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DevTestLabEnvironmentResource(Client, DevTestLabEnvironmentData.DeserializeDevTestLabEnvironmentData(e)), _devTestLabEnvironmentEnvironmentsClientDiagnostics, Pipeline, "DevTestLabEnvironmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/environments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Environments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the environment. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=deploymentProperties)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabEnvironmentEnvironmentsClientDiagnostics.CreateScope("DevTestLabEnvironmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _devTestLabEnvironmentEnvironmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/users/{userName}/environments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Environments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the environment. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=deploymentProperties)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabEnvironmentEnvironmentsClientDiagnostics.CreateScope("DevTestLabEnvironmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _devTestLabEnvironmentEnvironmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DevTestLabEnvironmentResource> IEnumerable<DevTestLabEnvironmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DevTestLabEnvironmentResource> IAsyncEnumerable<DevTestLabEnvironmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
