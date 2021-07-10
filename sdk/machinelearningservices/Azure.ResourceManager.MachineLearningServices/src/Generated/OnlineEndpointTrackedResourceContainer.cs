// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A class representing collection of OnlineEndpointTrackedResource and their operations over a Workspace. </summary>
    public partial class OnlineEndpointTrackedResourceContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, OnlineEndpointTrackedResource, OnlineEndpointTrackedResourceData>
    {
        /// <summary> Initializes a new instance of the <see cref="OnlineEndpointTrackedResourceContainer"/> class for mocking. </summary>
        protected OnlineEndpointTrackedResourceContainer()
        {
        }

        /// <summary> Initializes a new instance of OnlineEndpointTrackedResourceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal OnlineEndpointTrackedResourceContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private OnlineEndpointsRestOperations _restClient => new OnlineEndpointsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => WorkspaceOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a OnlineEndpointTrackedResource. Please note some properties can be set only during creation. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="body"> Online Endpoint entity to apply during operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<OnlineEndpointTrackedResource> CreateOrUpdate(string workspaceName, OnlineEndpointTrackedResourceData body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }
                if (body == null)
                {
                    throw new ArgumentNullException(nameof(body));
                }

                return StartCreateOrUpdate(workspaceName, body, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a OnlineEndpointTrackedResource. Please note some properties can be set only during creation. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="body"> Online Endpoint entity to apply during operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<OnlineEndpointTrackedResource>> CreateOrUpdateAsync(string workspaceName, OnlineEndpointTrackedResourceData body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }
                if (body == null)
                {
                    throw new ArgumentNullException(nameof(body));
                }

                var operation = await StartCreateOrUpdateAsync(workspaceName, body, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a OnlineEndpointTrackedResource. Please note some properties can be set only during creation. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="body"> Online Endpoint entity to apply during operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public OnlineEndpointsCreateOrUpdateOperation StartCreateOrUpdate(string workspaceName, OnlineEndpointTrackedResourceData body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }
                if (body == null)
                {
                    throw new ArgumentNullException(nameof(body));
                }

                var originalResponse = _restClient.CreateOrUpdate(Id.Name, Id.ResourceGroupName, workspaceName, body, cancellationToken: cancellationToken);
                return new OnlineEndpointsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.Name, Id.ResourceGroupName, workspaceName, body).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a OnlineEndpointTrackedResource. Please note some properties can be set only during creation. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="body"> Online Endpoint entity to apply during operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<OnlineEndpointsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string workspaceName, OnlineEndpointTrackedResourceData body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }
                if (body == null)
                {
                    throw new ArgumentNullException(nameof(body));
                }

                var originalResponse = await _restClient.CreateOrUpdateAsync(Id.Name, Id.ResourceGroupName, workspaceName, body, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new OnlineEndpointsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.Name, Id.ResourceGroupName, workspaceName, body).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<OnlineEndpointTrackedResource> Get(string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.Get");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }

                var response = _restClient.Get(Id.Name, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken);
                return Response.FromValue(new OnlineEndpointTrackedResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<OnlineEndpointTrackedResource>> GetAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.Get");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }

                var response = await _restClient.GetAsync(Id.Name, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new OnlineEndpointTrackedResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List Online Endpoints. </summary>
        /// <param name="name"> Name of the endpoint. </param>
        /// <param name="count"> Number of endpoints to be retrieved in a page of results. </param>
        /// <param name="computeType"> EndpointComputeType to be filtered by. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="tags"> A set of tags with which to filter the returned models. It is a comma separated string of tags key or tags key=value. Example: tagKey1,tagKey2,tagKey3=value3 . </param>
        /// <param name="properties"> A set of properties with which to filter the returned models. It is a comma separated string of properties key and/or properties key=value Example: propKey1,propKey2,propKey3=value3 . </param>
        /// <param name="orderBy"> The option to order the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OnlineEndpointTrackedResource" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<OnlineEndpointTrackedResource> List(string name = null, int? count = null, EndpointComputeType? computeType = null, string skip = null, string tags = null, string properties = null, OrderString? orderBy = null, CancellationToken cancellationToken = default)
        {
            Page<OnlineEndpointTrackedResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.List(Id.ResourceGroupName, Id.Name, name, count, computeType, skip, tags, properties, orderBy, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OnlineEndpointTrackedResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OnlineEndpointTrackedResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListNextPage(nextLink, Id.ResourceGroupName, Id.Name, name, count, computeType, skip, tags, properties, orderBy, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OnlineEndpointTrackedResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List Online Endpoints. </summary>
        /// <param name="name"> Name of the endpoint. </param>
        /// <param name="count"> Number of endpoints to be retrieved in a page of results. </param>
        /// <param name="computeType"> EndpointComputeType to be filtered by. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="tags"> A set of tags with which to filter the returned models. It is a comma separated string of tags key or tags key=value. Example: tagKey1,tagKey2,tagKey3=value3 . </param>
        /// <param name="properties"> A set of properties with which to filter the returned models. It is a comma separated string of properties key and/or properties key=value Example: propKey1,propKey2,propKey3=value3 . </param>
        /// <param name="orderBy"> The option to order the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OnlineEndpointTrackedResource" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<OnlineEndpointTrackedResource> ListAsync(string name = null, int? count = null, EndpointComputeType? computeType = null, string skip = null, string tags = null, string properties = null, OrderString? orderBy = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<OnlineEndpointTrackedResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAsync(Id.ResourceGroupName, Id.Name, name, count, computeType, skip, tags, properties, orderBy, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OnlineEndpointTrackedResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OnlineEndpointTrackedResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, name, count, computeType, skip, tags, properties, orderBy, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OnlineEndpointTrackedResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of OnlineEndpointTrackedResource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(OnlineEndpointTrackedResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of OnlineEndpointTrackedResource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(OnlineEndpointTrackedResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List EndpointAuthKeys for an Endpoint using Key-based authentication. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EndpointAuthKeys>> ListKeysAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.ListKeys");
            scope.Start();
            try
            {
                var response = await _restClient.ListKeysAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List EndpointAuthKeys for an Endpoint using Key-based authentication. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EndpointAuthKeys> ListKeys(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceContainer.ListKeys");
            scope.Start();
            try
            {
                var response = _restClient.ListKeys(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, OnlineEndpointTrackedResource, OnlineEndpointTrackedResourceData> Construct() { }
    }
}
