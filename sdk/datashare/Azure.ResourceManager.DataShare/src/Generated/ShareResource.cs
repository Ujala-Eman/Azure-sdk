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
using Azure.ResourceManager.DataShare.Models;

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A Class representing a Share along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ShareResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetShareResource method.
    /// Otherwise you can get one from its parent resource <see cref="AccountResource" /> using the GetShare method.
    /// </summary>
    public partial class ShareResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ShareResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string shareName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _shareClientDiagnostics;
        private readonly SharesRestOperations _shareRestClient;
        private readonly ShareData _data;

        /// <summary> Initializes a new instance of the <see cref="ShareResource"/> class for mocking. </summary>
        protected ShareResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ShareResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ShareResource(ArmClient client, ShareData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ShareResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ShareResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _shareClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataShare", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string shareApiVersion);
            _shareRestClient = new SharesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, shareApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataShare/accounts/shares";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ShareData Data
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

        /// <summary> Gets a collection of DataSetResources in the Share. </summary>
        /// <returns> An object representing collection of DataSetResources and their operations over a DataSetResource. </returns>
        public virtual DataSetCollection GetDataSets()
        {
            return GetCachedClient(Client => new DataSetCollection(Client, Id));
        }

        /// <summary>
        /// Get a DataSet in a share
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/dataSets/{dataSetName}
        /// Operation Id: DataSets_Get
        /// </summary>
        /// <param name="dataSetName"> The name of the dataSet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DataSetResource>> GetDataSetAsync(string dataSetName, CancellationToken cancellationToken = default)
        {
            return await GetDataSets().GetAsync(dataSetName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a DataSet in a share
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/dataSets/{dataSetName}
        /// Operation Id: DataSets_Get
        /// </summary>
        /// <param name="dataSetName"> The name of the dataSet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<DataSetResource> GetDataSet(string dataSetName, CancellationToken cancellationToken = default)
        {
            return GetDataSets().Get(dataSetName, cancellationToken);
        }

        /// <summary> Gets a collection of InvitationResources in the Share. </summary>
        /// <returns> An object representing collection of InvitationResources and their operations over a InvitationResource. </returns>
        public virtual InvitationCollection GetInvitations()
        {
            return GetCachedClient(Client => new InvitationCollection(Client, Id));
        }

        /// <summary>
        /// Get an invitation in a share
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/invitations/{invitationName}
        /// Operation Id: Invitations_Get
        /// </summary>
        /// <param name="invitationName"> The name of the invitation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="invitationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="invitationName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<InvitationResource>> GetInvitationAsync(string invitationName, CancellationToken cancellationToken = default)
        {
            return await GetInvitations().GetAsync(invitationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get an invitation in a share
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/invitations/{invitationName}
        /// Operation Id: Invitations_Get
        /// </summary>
        /// <param name="invitationName"> The name of the invitation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="invitationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="invitationName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<InvitationResource> GetInvitation(string invitationName, CancellationToken cancellationToken = default)
        {
            return GetInvitations().Get(invitationName, cancellationToken);
        }

        /// <summary> Gets a collection of ProviderShareSubscriptionResources in the Share. </summary>
        /// <returns> An object representing collection of ProviderShareSubscriptionResources and their operations over a ProviderShareSubscriptionResource. </returns>
        public virtual ProviderShareSubscriptionCollection GetProviderShareSubscriptions()
        {
            return GetCachedClient(Client => new ProviderShareSubscriptionCollection(Client, Id));
        }

        /// <summary>
        /// Get share subscription in a provider share
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/providerShareSubscriptions/{providerShareSubscriptionId}
        /// Operation Id: ProviderShareSubscriptions_GetByShare
        /// </summary>
        /// <param name="providerShareSubscriptionId"> To locate shareSubscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerShareSubscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerShareSubscriptionId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ProviderShareSubscriptionResource>> GetProviderShareSubscriptionAsync(string providerShareSubscriptionId, CancellationToken cancellationToken = default)
        {
            return await GetProviderShareSubscriptions().GetAsync(providerShareSubscriptionId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get share subscription in a provider share
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/providerShareSubscriptions/{providerShareSubscriptionId}
        /// Operation Id: ProviderShareSubscriptions_GetByShare
        /// </summary>
        /// <param name="providerShareSubscriptionId"> To locate shareSubscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerShareSubscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerShareSubscriptionId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<ProviderShareSubscriptionResource> GetProviderShareSubscription(string providerShareSubscriptionId, CancellationToken cancellationToken = default)
        {
            return GetProviderShareSubscriptions().Get(providerShareSubscriptionId, cancellationToken);
        }

        /// <summary> Gets a collection of SynchronizationSettingResources in the Share. </summary>
        /// <returns> An object representing collection of SynchronizationSettingResources and their operations over a SynchronizationSettingResource. </returns>
        public virtual SynchronizationSettingCollection GetSynchronizationSettings()
        {
            return GetCachedClient(Client => new SynchronizationSettingCollection(Client, Id));
        }

        /// <summary>
        /// Get a synchronizationSetting in a share
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings/{synchronizationSettingName}
        /// Operation Id: SynchronizationSettings_Get
        /// </summary>
        /// <param name="synchronizationSettingName"> The name of the synchronizationSetting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="synchronizationSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="synchronizationSettingName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SynchronizationSettingResource>> GetSynchronizationSettingAsync(string synchronizationSettingName, CancellationToken cancellationToken = default)
        {
            return await GetSynchronizationSettings().GetAsync(synchronizationSettingName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a synchronizationSetting in a share
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings/{synchronizationSettingName}
        /// Operation Id: SynchronizationSettings_Get
        /// </summary>
        /// <param name="synchronizationSettingName"> The name of the synchronizationSetting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="synchronizationSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="synchronizationSettingName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<SynchronizationSettingResource> GetSynchronizationSetting(string synchronizationSettingName, CancellationToken cancellationToken = default)
        {
            return GetSynchronizationSettings().Get(synchronizationSettingName, cancellationToken);
        }

        /// <summary>
        /// Get a share 
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}
        /// Operation Id: Shares_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ShareResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _shareClientDiagnostics.CreateScope("ShareResource.Get");
            scope.Start();
            try
            {
                var response = await _shareRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ShareResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a share 
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}
        /// Operation Id: Shares_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ShareResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _shareClientDiagnostics.CreateScope("ShareResource.Get");
            scope.Start();
            try
            {
                var response = _shareRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ShareResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a share 
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}
        /// Operation Id: Shares_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<OperationResponse>> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _shareClientDiagnostics.CreateScope("ShareResource.Delete");
            scope.Start();
            try
            {
                var response = await _shareRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DataShareArmOperation<OperationResponse>(new OperationResponseOperationSource(), _shareClientDiagnostics, Pipeline, _shareRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Delete a share 
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}
        /// Operation Id: Shares_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<OperationResponse> Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _shareClientDiagnostics.CreateScope("ShareResource.Delete");
            scope.Start();
            try
            {
                var response = _shareRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DataShareArmOperation<OperationResponse>(new OperationResponseOperationSource(), _shareClientDiagnostics, Pipeline, _shareRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Create a share 
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}
        /// Operation Id: Shares_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The share payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ShareResource>> UpdateAsync(WaitUntil waitUntil, ShareData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _shareClientDiagnostics.CreateScope("ShareResource.Update");
            scope.Start();
            try
            {
                var response = await _shareRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataShareArmOperation<ShareResource>(Response.FromValue(new ShareResource(Client, response), response.GetRawResponse()));
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
        /// Create a share 
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}
        /// Operation Id: Shares_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The share payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ShareResource> Update(WaitUntil waitUntil, ShareData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _shareClientDiagnostics.CreateScope("ShareResource.Update");
            scope.Start();
            try
            {
                var response = _shareRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new DataShareArmOperation<ShareResource>(Response.FromValue(new ShareResource(Client, response), response.GetRawResponse()));
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
        /// List synchronization details
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/listSynchronizationDetails
        /// Operation Id: Shares_ListSynchronizationDetails
        /// </summary>
        /// <param name="shareSynchronization"> Share Synchronization payload. </param>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="shareSynchronization"/> is null. </exception>
        /// <returns> An async collection of <see cref="SynchronizationDetails" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynchronizationDetails> GetSynchronizationDetailsAsync(ShareSynchronization shareSynchronization, string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(shareSynchronization, nameof(shareSynchronization));

            async Task<Page<SynchronizationDetails>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _shareClientDiagnostics.CreateScope("ShareResource.GetSynchronizationDetails");
                scope.Start();
                try
                {
                    var response = await _shareRestClient.ListSynchronizationDetailsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, shareSynchronization, skipToken, filter, orderby, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SynchronizationDetails>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _shareClientDiagnostics.CreateScope("ShareResource.GetSynchronizationDetails");
                scope.Start();
                try
                {
                    var response = await _shareRestClient.ListSynchronizationDetailsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, shareSynchronization, skipToken, filter, orderby, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// List synchronization details
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/listSynchronizationDetails
        /// Operation Id: Shares_ListSynchronizationDetails
        /// </summary>
        /// <param name="shareSynchronization"> Share Synchronization payload. </param>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="shareSynchronization"/> is null. </exception>
        /// <returns> A collection of <see cref="SynchronizationDetails" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynchronizationDetails> GetSynchronizationDetails(ShareSynchronization shareSynchronization, string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(shareSynchronization, nameof(shareSynchronization));

            Page<SynchronizationDetails> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _shareClientDiagnostics.CreateScope("ShareResource.GetSynchronizationDetails");
                scope.Start();
                try
                {
                    var response = _shareRestClient.ListSynchronizationDetails(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, shareSynchronization, skipToken, filter, orderby, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SynchronizationDetails> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _shareClientDiagnostics.CreateScope("ShareResource.GetSynchronizationDetails");
                scope.Start();
                try
                {
                    var response = _shareRestClient.ListSynchronizationDetailsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, shareSynchronization, skipToken, filter, orderby, cancellationToken: cancellationToken);
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

        /// <summary>
        /// List synchronizations of a share
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/listSynchronizations
        /// Operation Id: Shares_ListSynchronizations
        /// </summary>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ShareSynchronization" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ShareSynchronization> GetSynchronizationsAsync(string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ShareSynchronization>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _shareClientDiagnostics.CreateScope("ShareResource.GetSynchronizations");
                scope.Start();
                try
                {
                    var response = await _shareRestClient.ListSynchronizationsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, filter, orderby, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ShareSynchronization>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _shareClientDiagnostics.CreateScope("ShareResource.GetSynchronizations");
                scope.Start();
                try
                {
                    var response = await _shareRestClient.ListSynchronizationsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, filter, orderby, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// List synchronizations of a share
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/listSynchronizations
        /// Operation Id: Shares_ListSynchronizations
        /// </summary>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ShareSynchronization" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ShareSynchronization> GetSynchronizations(string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Page<ShareSynchronization> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _shareClientDiagnostics.CreateScope("ShareResource.GetSynchronizations");
                scope.Start();
                try
                {
                    var response = _shareRestClient.ListSynchronizations(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, filter, orderby, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ShareSynchronization> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _shareClientDiagnostics.CreateScope("ShareResource.GetSynchronizations");
                scope.Start();
                try
                {
                    var response = _shareRestClient.ListSynchronizationsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, filter, orderby, cancellationToken: cancellationToken);
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
