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

namespace Azure.ResourceManager.Communication
{
    /// <summary>
    /// A Class representing a SuppressionListResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SuppressionListResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSuppressionListResource method.
    /// Otherwise you can get one from its parent resource <see cref="CommunicationDomainResource" /> using the GetSuppressionListResource method.
    /// </summary>
    public partial class SuppressionListResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SuppressionListResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="emailServiceName"> The emailServiceName. </param>
        /// <param name="domainName"> The domainName. </param>
        /// <param name="suppressionListName"> The suppressionListName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string emailServiceName, string domainName, string suppressionListName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/suppressionLists/{suppressionListName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _suppressionListResourceSuppressionListsClientDiagnostics;
        private readonly SuppressionListsRestOperations _suppressionListResourceSuppressionListsRestClient;
        private readonly SuppressionListResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="SuppressionListResource"/> class for mocking. </summary>
        protected SuppressionListResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SuppressionListResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SuppressionListResource(ArmClient client, SuppressionListResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SuppressionListResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SuppressionListResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _suppressionListResourceSuppressionListsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Communication", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string suppressionListResourceSuppressionListsApiVersion);
            _suppressionListResourceSuppressionListsRestClient = new SuppressionListsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, suppressionListResourceSuppressionListsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Communication/emailServices/domains/suppressionLists";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SuppressionListResourceData Data
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

        /// <summary> Gets a collection of SuppressionListAddressResources in the SuppressionListResource. </summary>
        /// <returns> An object representing collection of SuppressionListAddressResources and their operations over a SuppressionListAddressResource. </returns>
        public virtual SuppressionListAddressResourceCollection GetSuppressionListAddressResources()
        {
            return GetCachedClient(client => new SuppressionListAddressResourceCollection(client, Id));
        }

        /// <summary>
        /// Get a SuppressionListAddress.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/suppressionLists/{suppressionListName}/suppressionListAddresses/{addressId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SuppressionListAddresses_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="addressId"> The id of the address in a suppression list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="addressId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="addressId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SuppressionListAddressResource>> GetSuppressionListAddressResourceAsync(string addressId, CancellationToken cancellationToken = default)
        {
            return await GetSuppressionListAddressResources().GetAsync(addressId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a SuppressionListAddress.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/suppressionLists/{suppressionListName}/suppressionListAddresses/{addressId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SuppressionListAddresses_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="addressId"> The id of the address in a suppression list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="addressId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="addressId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SuppressionListAddressResource> GetSuppressionListAddressResource(string addressId, CancellationToken cancellationToken = default)
        {
            return GetSuppressionListAddressResources().Get(addressId, cancellationToken);
        }

        /// <summary>
        /// Get a SuppressionList resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/suppressionLists/{suppressionListName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SuppressionLists_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SuppressionListResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _suppressionListResourceSuppressionListsClientDiagnostics.CreateScope("SuppressionListResource.Get");
            scope.Start();
            try
            {
                var response = await _suppressionListResourceSuppressionListsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SuppressionListResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a SuppressionList resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/suppressionLists/{suppressionListName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SuppressionLists_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SuppressionListResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _suppressionListResourceSuppressionListsClientDiagnostics.CreateScope("SuppressionListResource.Get");
            scope.Start();
            try
            {
                var response = _suppressionListResourceSuppressionListsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SuppressionListResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a SuppressionList.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/suppressionLists/{suppressionListName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SuppressionLists_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _suppressionListResourceSuppressionListsClientDiagnostics.CreateScope("SuppressionListResource.Delete");
            scope.Start();
            try
            {
                var response = await _suppressionListResourceSuppressionListsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CommunicationArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
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
        /// Delete a SuppressionList.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/suppressionLists/{suppressionListName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SuppressionLists_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _suppressionListResourceSuppressionListsClientDiagnostics.CreateScope("SuppressionListResource.Delete");
            scope.Start();
            try
            {
                var response = _suppressionListResourceSuppressionListsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CommunicationArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
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
        /// Add a new SuppressionList resource under the parent Domains resource or update an existing SuppressionList resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/suppressionLists/{suppressionListName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SuppressionLists_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SuppressionListResource>> UpdateAsync(WaitUntil waitUntil, SuppressionListResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _suppressionListResourceSuppressionListsClientDiagnostics.CreateScope("SuppressionListResource.Update");
            scope.Start();
            try
            {
                var response = await _suppressionListResourceSuppressionListsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new CommunicationArmOperation<SuppressionListResource>(Response.FromValue(new SuppressionListResource(Client, response), response.GetRawResponse()));
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
        /// Add a new SuppressionList resource under the parent Domains resource or update an existing SuppressionList resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}/suppressionLists/{suppressionListName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SuppressionLists_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SuppressionListResource> Update(WaitUntil waitUntil, SuppressionListResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _suppressionListResourceSuppressionListsClientDiagnostics.CreateScope("SuppressionListResource.Update");
            scope.Start();
            try
            {
                var response = _suppressionListResourceSuppressionListsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new CommunicationArmOperation<SuppressionListResource>(Response.FromValue(new SuppressionListResource(Client, response), response.GetRawResponse()));
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
    }
}
