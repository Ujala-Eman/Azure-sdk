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
using Azure.ResourceManager.Marketplace.Models;

namespace Azure.ResourceManager.Marketplace
{
    /// <summary>
    /// A Class representing a MarketplaceApprovalRequest along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="MarketplaceApprovalRequestResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetMarketplaceApprovalRequestResource method.
    /// Otherwise you can get one from its parent resource <see cref="PrivateStoreResource" /> using the GetMarketplaceApprovalRequest method.
    /// </summary>
    public partial class MarketplaceApprovalRequestResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MarketplaceApprovalRequestResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(Guid privateStoreId, string requestApprovalId)
        {
            var resourceId = $"/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/requestApprovals/{requestApprovalId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _marketplaceApprovalRequestPrivateStoreClientDiagnostics;
        private readonly PrivateStoreRestOperations _marketplaceApprovalRequestPrivateStoreRestClient;
        private readonly MarketplaceApprovalRequestData _data;

        /// <summary> Initializes a new instance of the <see cref="MarketplaceApprovalRequestResource"/> class for mocking. </summary>
        protected MarketplaceApprovalRequestResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MarketplaceApprovalRequestResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MarketplaceApprovalRequestResource(ArmClient client, MarketplaceApprovalRequestData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MarketplaceApprovalRequestResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MarketplaceApprovalRequestResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _marketplaceApprovalRequestPrivateStoreClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Marketplace", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string marketplaceApprovalRequestPrivateStoreApiVersion);
            _marketplaceApprovalRequestPrivateStoreRestClient = new PrivateStoreRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, marketplaceApprovalRequestPrivateStoreApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Marketplace/privateStores/requestApprovals";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MarketplaceApprovalRequestData Data
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
        /// Get open request approval details
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/requestApprovals/{requestApprovalId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStore_GetRequestApproval</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MarketplaceApprovalRequestResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _marketplaceApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceApprovalRequestResource.Get");
            scope.Start();
            try
            {
                var response = await _marketplaceApprovalRequestPrivateStoreRestClient.GetRequestApprovalAsync(Guid.Parse(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MarketplaceApprovalRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get open request approval details
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/requestApprovals/{requestApprovalId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStore_GetRequestApproval</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MarketplaceApprovalRequestResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _marketplaceApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceApprovalRequestResource.Get");
            scope.Start();
            try
            {
                var response = _marketplaceApprovalRequestPrivateStoreRestClient.GetRequestApproval(Guid.Parse(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MarketplaceApprovalRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create approval request
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/requestApprovals/{requestApprovalId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStore_CreateApprovalRequest</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The MarketplaceApprovalRequestData to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MarketplaceApprovalRequestResource>> UpdateAsync(WaitUntil waitUntil, MarketplaceApprovalRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _marketplaceApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceApprovalRequestResource.Update");
            scope.Start();
            try
            {
                var response = await _marketplaceApprovalRequestPrivateStoreRestClient.CreateApprovalRequestAsync(Guid.Parse(Id.Parent.Name), Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MarketplaceArmOperation<MarketplaceApprovalRequestResource>(Response.FromValue(new MarketplaceApprovalRequestResource(Client, response), response.GetRawResponse()));
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
        /// Create approval request
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/requestApprovals/{requestApprovalId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStore_CreateApprovalRequest</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The MarketplaceApprovalRequestData to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MarketplaceApprovalRequestResource> Update(WaitUntil waitUntil, MarketplaceApprovalRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _marketplaceApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceApprovalRequestResource.Update");
            scope.Start();
            try
            {
                var response = _marketplaceApprovalRequestPrivateStoreRestClient.CreateApprovalRequest(Guid.Parse(Id.Parent.Name), Id.Name, data, cancellationToken);
                var operation = new MarketplaceArmOperation<MarketplaceApprovalRequestResource>(Response.FromValue(new MarketplaceApprovalRequestResource(Client, response), response.GetRawResponse()));
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
        /// Get request statuses foreach plan, this api is used as a complex GET action.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/requestApprovals/{requestApprovalId}/query</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStore_QueryRequestApproval</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The QueryApprovalRequestContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<QueryApprovalRequestResult>> QueryApprovalRequestAsync(QueryApprovalRequestContent content = null, CancellationToken cancellationToken = default)
        {
            using var scope = _marketplaceApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceApprovalRequestResource.QueryApprovalRequest");
            scope.Start();
            try
            {
                var response = await _marketplaceApprovalRequestPrivateStoreRestClient.QueryRequestApprovalAsync(Guid.Parse(Id.Parent.Name), Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get request statuses foreach plan, this api is used as a complex GET action.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/requestApprovals/{requestApprovalId}/query</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStore_QueryRequestApproval</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The QueryApprovalRequestContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<QueryApprovalRequestResult> QueryApprovalRequest(QueryApprovalRequestContent content = null, CancellationToken cancellationToken = default)
        {
            using var scope = _marketplaceApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceApprovalRequestResource.QueryApprovalRequest");
            scope.Start();
            try
            {
                var response = _marketplaceApprovalRequestPrivateStoreRestClient.QueryRequestApproval(Guid.Parse(Id.Parent.Name), Id.Name, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Withdraw a user request approval on specific plan
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/requestApprovals/{requestApprovalId}/withdrawPlan</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStore_WithdrawPlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The WithdrawPlanContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> WithdrawPlanAsync(WithdrawPlanContent content = null, CancellationToken cancellationToken = default)
        {
            using var scope = _marketplaceApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceApprovalRequestResource.WithdrawPlan");
            scope.Start();
            try
            {
                var response = await _marketplaceApprovalRequestPrivateStoreRestClient.WithdrawPlanAsync(Guid.Parse(Id.Parent.Name), Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Withdraw a user request approval on specific plan
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/requestApprovals/{requestApprovalId}/withdrawPlan</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStore_WithdrawPlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The WithdrawPlanContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response WithdrawPlan(WithdrawPlanContent content = null, CancellationToken cancellationToken = default)
        {
            using var scope = _marketplaceApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceApprovalRequestResource.WithdrawPlan");
            scope.Start();
            try
            {
                var response = _marketplaceApprovalRequestPrivateStoreRestClient.WithdrawPlan(Guid.Parse(Id.Parent.Name), Id.Name, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
