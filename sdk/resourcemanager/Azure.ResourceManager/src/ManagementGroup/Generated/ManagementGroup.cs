// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Management.Models;

namespace Azure.ResourceManager.Management
{
    /// <summary> A Class representing a ManagementGroup along with the instance operations that can be performed on it. </summary>
    public partial class ManagementGroup : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagementGroup"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string groupId)
        {
            var resourceId = $"/providers/Microsoft.Management/managementGroups/{groupId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managementGroupClientDiagnostics;
        private readonly ManagementGroupsRestOperations _managementGroupRestClient;
        private readonly ManagementGroupData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagementGroup"/> class for mocking. </summary>
        protected ManagementGroup()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagementGroup"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagementGroup(ArmClient client, ManagementGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagementGroup"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagementGroup(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managementGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Management", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string managementGroupApiVersion);
            _managementGroupRestClient = new ManagementGroupsRestOperations(_managementGroupClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, managementGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Management/managementGroups";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagementGroupData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the details of the management group.
        /// 
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}
        /// Operation Id: ManagementGroups_Get
        /// </summary>
        /// <param name="expand"> The $expand=children query string parameter allows clients to request inclusion of children in the response payload.  $expand=path includes the path from the root group to the current group.  $expand=ancestors includes the ancestor Ids of the current group. </param>
        /// <param name="recurse"> The $recurse=true query string parameter allows clients to request inclusion of entire hierarchy in the response payload. Note that  $expand=children must be passed up if $recurse is set to true. </param>
        /// <param name="filter"> A filter which allows the exclusion of subscriptions from results (i.e. &apos;$filter=children.childType ne Subscription&apos;). </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with &apos;no-cache&apos; value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagementGroup>> GetAsync(ManagementGroupExpandType? expand = null, bool? recurse = null, string filter = null, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            using var scope = _managementGroupClientDiagnostics.CreateScope("ManagementGroup.Get");
            scope.Start();
            try
            {
                var response = await _managementGroupRestClient.GetAsync(Id.Name, expand, recurse, filter, cacheControl, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _managementGroupClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagementGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of the management group.
        /// 
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}
        /// Operation Id: ManagementGroups_Get
        /// </summary>
        /// <param name="expand"> The $expand=children query string parameter allows clients to request inclusion of children in the response payload.  $expand=path includes the path from the root group to the current group.  $expand=ancestors includes the ancestor Ids of the current group. </param>
        /// <param name="recurse"> The $recurse=true query string parameter allows clients to request inclusion of entire hierarchy in the response payload. Note that  $expand=children must be passed up if $recurse is set to true. </param>
        /// <param name="filter"> A filter which allows the exclusion of subscriptions from results (i.e. &apos;$filter=children.childType ne Subscription&apos;). </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with &apos;no-cache&apos; value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagementGroup> Get(ManagementGroupExpandType? expand = null, bool? recurse = null, string filter = null, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            using var scope = _managementGroupClientDiagnostics.CreateScope("ManagementGroup.Get");
            scope.Start();
            try
            {
                var response = _managementGroupRestClient.Get(Id.Name, expand, recurse, filter, cacheControl, cancellationToken);
                if (response.Value == null)
                    throw _managementGroupClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagementGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete management group.
        /// If a management group contains child resources, the request will fail.
        /// 
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}
        /// Operation Id: ManagementGroups_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with &apos;no-cache&apos; value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            using var scope = _managementGroupClientDiagnostics.CreateScope("ManagementGroup.Delete");
            scope.Start();
            try
            {
                var response = await _managementGroupRestClient.DeleteAsync(Id.Name, cacheControl, cancellationToken).ConfigureAwait(false);
                var operation = new ManagementArmOperation(_managementGroupClientDiagnostics, Pipeline, _managementGroupRestClient.CreateDeleteRequest(Id.Name, cacheControl).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete management group.
        /// If a management group contains child resources, the request will fail.
        /// 
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}
        /// Operation Id: ManagementGroups_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with &apos;no-cache&apos; value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            using var scope = _managementGroupClientDiagnostics.CreateScope("ManagementGroup.Delete");
            scope.Start();
            try
            {
                var response = _managementGroupRestClient.Delete(Id.Name, cacheControl, cancellationToken);
                var operation = new ManagementArmOperation(_managementGroupClientDiagnostics, Pipeline, _managementGroupRestClient.CreateDeleteRequest(Id.Name, cacheControl).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update a management group.
        /// 
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}
        /// Operation Id: ManagementGroups_Update
        /// </summary>
        /// <param name="options"> Management group patch parameters. </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with &apos;no-cache&apos; value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        public async virtual Task<Response<ManagementGroup>> UpdateAsync(ManagementGroupUpdateOptions options, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            using var scope = _managementGroupClientDiagnostics.CreateScope("ManagementGroup.Update");
            scope.Start();
            try
            {
                var response = await _managementGroupRestClient.UpdateAsync(Id.Name, options, cacheControl, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ManagementGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update a management group.
        /// 
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}
        /// Operation Id: ManagementGroups_Update
        /// </summary>
        /// <param name="options"> Management group patch parameters. </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with &apos;no-cache&apos; value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        public virtual Response<ManagementGroup> Update(ManagementGroupUpdateOptions options, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            using var scope = _managementGroupClientDiagnostics.CreateScope("ManagementGroup.Update");
            scope.Start();
            try
            {
                var response = _managementGroupRestClient.Update(Id.Name, options, cacheControl, cancellationToken);
                return Response.FromValue(new ManagementGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all entities that descend from a management group.
        /// 
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/descendants
        /// Operation Id: ManagementGroups_GetDescendants
        /// </summary>
        /// <param name="skiptoken">
        /// Page continuation token is only used if a previous operation returned a partial result. 
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a token parameter that specifies a starting point to use for subsequent calls.
        /// 
        /// </param>
        /// <param name="top"> Number of elements to return when retrieving results. Passing this in will override $skipToken. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DescendantInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DescendantInfo> GetDescendantsAsync(string skiptoken = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<DescendantInfo>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managementGroupClientDiagnostics.CreateScope("ManagementGroup.GetDescendants");
                scope.Start();
                try
                {
                    var response = await _managementGroupRestClient.GetDescendantsAsync(Id.Name, skiptoken, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DescendantInfo>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managementGroupClientDiagnostics.CreateScope("ManagementGroup.GetDescendants");
                scope.Start();
                try
                {
                    var response = await _managementGroupRestClient.GetDescendantsNextPageAsync(nextLink, Id.Name, skiptoken, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// List all entities that descend from a management group.
        /// 
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/descendants
        /// Operation Id: ManagementGroups_GetDescendants
        /// </summary>
        /// <param name="skiptoken">
        /// Page continuation token is only used if a previous operation returned a partial result. 
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a token parameter that specifies a starting point to use for subsequent calls.
        /// 
        /// </param>
        /// <param name="top"> Number of elements to return when retrieving results. Passing this in will override $skipToken. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DescendantInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DescendantInfo> GetDescendants(string skiptoken = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<DescendantInfo> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managementGroupClientDiagnostics.CreateScope("ManagementGroup.GetDescendants");
                scope.Start();
                try
                {
                    var response = _managementGroupRestClient.GetDescendants(Id.Name, skiptoken, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DescendantInfo> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managementGroupClientDiagnostics.CreateScope("ManagementGroup.GetDescendants");
                scope.Start();
                try
                {
                    var response = _managementGroupRestClient.GetDescendantsNextPage(nextLink, Id.Name, skiptoken, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
